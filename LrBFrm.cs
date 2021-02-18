namespace GameOverLoaderBuilder
{
    #region Зависимости

    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Tools;

    #endregion

    public partial class LrBFrm : Form
    {
        protected void Controls_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                ((Control)sender).Capture = false;
                var m = Message.Create(this.Handle, 0xa1, new IntPtr(0x2), IntPtr.Zero);
                WndProc(ref m);
            }
        }
        public LrBFrm()
        {
            InitializeComponent();
            this.LinkBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.LinkBox.DrawItem += new DrawItemEventHandler(LinkBox_DrawItem);
            this.LinkBox.SelectedIndexChanged += new EventHandler(LinkBox_SelectedIndexChanged);

            this.AllowDrop = true;
            DragEnter += new DragEventHandler(IcoViewer_DragEnter);
            DragDrop += new DragEventHandler(IcoViewer_DragDrop);

            this.AssVerTextBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.AssFileVerTextBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.LogoText.MouseDown += Controls_MouseDown;
            this.UPanel.MouseDown += Controls_MouseDown;
        }
        private void AppExit_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();
            ControlActive.ShowAnima(this.Handle, 500, Animation.Enums.AnimateWindowFlags.AW_VER_POSITIVE | Animation.Enums.AnimateWindowFlags.AW_HIDE);
            Application.Exit();
        }
        private void CleanLink_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();
            if (this.LinkBox.SelectedIndex != -1)
            {
                this.LinkBox.Items.RemoveAt(this.LinkBox.SelectedIndex);
                this.Lcount.Text = $"Список ссылок для загрузки файлов: {this.LinkBox.Items.Count}";
            }
            else
            {
                this.StatusMessage.Location = new Point(460, 371);
                ControlActive.CheckMessage(this.StatusMessage, "Выберите элемент из списка для удаления.", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
            }
        }
        private void CleanAll_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();
            if (this.LinkBox.Items.Count != 0 || !string.IsNullOrWhiteSpace(this.LinkTextBox.Text))
            {
                this.LinkBox.Items.Clear();
                this.LinkTextBox.Clear();
                this.Lcount.Text = $"Список ссылок для загрузки файлов: {this.LinkBox.Items.Count}";
                this.StatusMessage.Location = new Point(525, 371);
                ControlActive.CheckMessage(this.StatusMessage, "Все поля отчищены!", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
            }
            else
            {
                this.StatusMessage.Location = new Point(150, 334);
                ControlActive.CheckMessage(this.StatusMessage, "Нечего отчищать", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
            }
        }    
        private async void Build_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();
            if (CheckIsEmptyBoxs())
            {
                this.StatusMessage.Location = new Point(515, 371);
                ControlActive.CheckMessage(this.StatusMessage, "Заполните все поля!", Color.FromKnownColor(KnownColor.MenuHighlight), 5000); // #3399FF
            }
            else
            {
                if (string.IsNullOrEmpty(this.ListSave.Text))
                {
                    this.StatusMessage.Location = new Point(515, 371);
                    ControlActive.CheckMessage(this.StatusMessage, "Выберите путь сохранения!", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                }
                else
                {
                    if (this.LinkBox.Items.Count <= 0)
                    {
                        this.StatusMessage.Location = new Point(515, 371);
                        ControlActive.CheckMessage(this.StatusMessage, "Нет ссылок для загрузки!", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                    }
                    else
                    {
                        #region Добавление ссылок 

                        var Linklist = new StringBuilder();
                        for (int i = 0; i < this.LinkBox.Items.Count; i++) Linklist.AppendLine($"\"{this.LinkBox.Items[i]}\",");
                        if (Linklist.Length > 0) Linklist.Length--;
                        #endregion
                        #region Добавляем все данные

                        var build = new Build()
                        {
                            AssCompany = this.AssCompanyTextBox.Text,
                            AssCopyright = this.AssCopyrightTextBox.Text,
                            AssDescription = this.AssDescriptTextBox.Text,
                            AssVersion = this.AssVerTextBox.Text,
                            AssFileVersion = this.AssFileVerTextBox.Text,
                            AssProduct = this.AssProductTextBox.Text,
                            AssTitle = this.AssTitleTextBox.Text,
                            BoxFileName = this.NameBuildTextBox.Text,
                            GuidBox = this.AssGuidTextBox.Text,
                            ComboPath = FormatDataEx,
                            BoxIcon = this.IcoPath.Text,
                            ListBoxUrl = Linklist?.ToString(),
                            LMessage = StatusMessage,
                            NUp = nPump,
                            Suicide = SuicideActivate.Checked,
                            Runadmin = RunFromAdminActivate.Checked,
                            RandomNameSpace = GenX.Update
                        };

                        #endregion
                        #region Запускаем создание загрузчика в новой задачи и ждём её завершения.

                        this.AppExit.Enabled = false; // Отключаем кнопку чтобы пользователь не мог закрыть программу 
                        await Task.Run(() => SourceEdition.Inizialize(build)).ConfigureAwait(false);
                        this.AppExit.Enabled = true; // Включаем кнопку чтобы пользователь мог закрыть кнопку

                        #endregion

                        Linklist.Clear(); // Отчищяем StringBuilder
                    }
                }
            }
        }
        private void LrBFrm_Load(object sender, EventArgs e)
        {
            string[] FormatText = { "LocalAppData", "AppData", "Temp", "Desktop" };
            this.ListSave.Items?.AddRange(FormatText);
            ControlActive.ShowAnima(this.Handle, 500, Animation.Enums.AnimateWindowFlags.AW_VER_POSITIVE | Animation.Enums.AnimateWindowFlags.AW_ACTIVATE);
        }
        private static string FormatDataEx = string.Empty;
        private void ListSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();
            switch (this.ListSave.SelectedIndex)
            {
                case 0: FormatDataEx = "LocalAppData"; break;
                case 1: FormatDataEx = "AppData"; break;
                case 2: FormatDataEx = "Temp"; break;
                case 3: FormatDataEx = "Desktop"; break;
            }
        }
        private void AddLink_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();
            if (!string.IsNullOrWhiteSpace(this.LinkTextBox.Text))
            {
                if (rgx.IsMatch(this.LinkTextBox.Text))
                {
                    if (this.LinkTextBox.Text.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
                    {
                        if (!this.LinkBox.Items.Contains(this.LinkTextBox.Text))
                        {
                            this.LinkBox.Items.Add(this.LinkTextBox.Text.Replace("\r", "").Replace("\n", ""));
                            this.LinkTextBox.Clear();
                            this.Lcount.Text = $"Список ссылок для загрузки файлов: {this.LinkBox.Items.Count}";
                        }
                        else
                        {
                            this.StatusMessage.Location = new Point(500, 371);
                            ControlActive.CheckMessage(this.StatusMessage, "Такая ссылка уже есть в списке!", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                        }
                    }
                    else
                    {
                        this.StatusMessage.Location = new Point(505, 371);
                        ControlActive.CheckMessage(this.StatusMessage, "Расширения файла только .exe", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                    }
                }
                else
                {
                    this.StatusMessage.Location = new Point(515, 371);
                    ControlActive.CheckMessage(this.StatusMessage, "Некорректная ссылка", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                    this.LinkTextBox.Clear();
                }
            }
            else
            {
                this.StatusMessage.Location = new Point(505, 371);
                ControlActive.CheckMessage(this.StatusMessage, "Введите ссылку в поле ввода", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
            }
        }
        private void GenAss_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();

            this.AssProductTextBox.Text = GenX.Update;
            this.AssTitleTextBox.Text = GenX.GenerateIdentifier(15);
            this.AssDescriptTextBox.Text = GenX.GenerateIdentifier(15);
            this.AssCompanyTextBox.Text = GenX.Update;
            this.AssCopyrightTextBox.Text = GenX.GenerateIdentifier(15);
            this.AssVerTextBox.Text = Convert.ToString($"{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}");
            this.AssFileVerTextBox.Text = Convert.ToString($"{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}.{GenX.Next(10)}");
            this.AssGuidTextBox.Text = Guid.NewGuid().ToString();
           // this.NameBuildTextBox.Text = GenX.GenerateIdentifier(7);
        }
        protected void TextBoxOnTextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 46)
                e.Handled = true;
        }
        private void SelectIcon_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            this.LogoText.Focus();
            try
            {
                using var Open = new OpenFileDialog
                {
                    Title = "Выберите иконку для загрузчика",
                    Filter = "Icon (*.ico)|*.ico",
                    Multiselect = false,
                    AutoUpgradeEnabled = true,
                    CheckFileExists = true,
                    RestoreDirectory = true
                };
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    this.IcoPath.Text = Open.FileName;
                    if (FileManager.ExistsFile(this.IcoPath.Text))
                    {
                        this.StatusMessage.Location = new Point(524, 371);
                        this.IcoViewer.ImageLocation = this.IcoPath.Text;
                        this.IcoViewer.BorderStyle = BorderStyle.None;
                        this.LsizeIco.Text = $"Размер иконки: {GetFileSize.Inizialize(new FileInfo(this.IcoPath.Text).Length)}";
                    }
                    else
                    {
                        this.IcoViewer.BorderStyle = BorderStyle.FixedSingle;
                        this.StatusMessage.Location = new Point(524, 371); 
                        this.LsizeIco.Text = $"Размер иконки: 0";
                        ControlActive.CheckMessage(this.StatusMessage, "Иконка повреждена!", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                    }
                }
                else
                {
                    this.IcoPath.Clear();
                    this.IcoViewer.Image = null;
                    this.IcoViewer.BorderStyle = BorderStyle.FixedSingle;
                    this.StatusMessage.Location = new Point(524, 371);
                    this.LsizeIco.Text = $"Размер иконки: 0";
                    ControlActive.CheckMessage(this.StatusMessage, "Иконка не выбрана", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                }
            }
            catch (Exception ex) { throw new Exception("Error OpenFile", ex); }
        }
        private void IcoViewer_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string text in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                this.IcoPath.Text = text;
                this.IcoViewer.Image = Image.FromFile(text);
                if (FileManager.ExistsFile(this.IcoPath.Text))
                {
                    this.StatusMessage.Location = new Point(12, 418);
                    this.LsizeIco.Text = $"Размер иконки: {GetFileSize.Inizialize(new FileInfo(this.IcoPath.Text).Length)}";
                }
                else
                {
                    this.StatusMessage.Location = new Point(12, 418);
                    this.LsizeIco.Text = $"Размер иконки: 0";
                    ControlActive.CheckMessage(this.StatusMessage, "Иконка повреждена!", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                }
            }
        }
        private void IcoViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                bool allowFilesDrop = true;
                foreach (string test in (string[])e.Data.GetData(DataFormats.FileDrop, true))
                {
                    allowFilesDrop = !(new FileInfo(test).Extension != ".ico");
                }

                if (allowFilesDrop)
                {
                    e.Effect = DragDropEffects.Move;
                    this.IcoViewer.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
        private void AddToTelegram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using var info = Process.Start("tg://resolve?domain=R3XQ1");
                info?.Refresh();
            }
            catch (Win32Exception)
            {
                try
                {
                    using var info = Process.Start("IExplore.exe", "https://t.me/r3xq1");
                    info?.Refresh();
                }
                catch (Exception ex) { throw new Exception("Error Add @r3xq1 to Telegram", ex); }
            }
        }
        private void RemoveLinkBox_Click(object sender, EventArgs e)
        {
            if (this.LinkBox.SelectedIndex != -1)
            {
                this.LinkBox.Items?.RemoveAt(this.LinkBox.SelectedIndex);
                this.Lcount.Text = $"Список ссылок для загрузки файлов: {this.LinkBox.Items.Count}";
            }
            else
            {
                this.StatusMessage.Location = new Point(460, 371);
                ControlActive.CheckMessage(this.StatusMessage, "Выберите элемент из списка для удаления.", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
            }
        }
        private void DownloadLinkBox_Click(object sender, EventArgs e)
        {
            if (this.LinkBox.SelectedIndex != -1)
            {
                this.StatusMessage.Location = new Point(515, 371);
                ControlActive.CheckMessage(this.StatusMessage, "Проверка загрузки..", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                new Thread(async () => await CheckerFiles.Loader(this.LinkBox.SelectedItem.ToString(), this.StatusMessage)).Start();
            }
        }
        private async void CheckLinkBox_Click(object sender, EventArgs e)
        {
            if (this.LinkBox.SelectedIndex != -1)
            {
                await Task.Run(() =>
                {
                    this.StatusMessage.Location = new Point(515, 371);
                    ControlActive.CheckMessage(this.StatusMessage, "Проверяем...", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                    if (!rgx.IsMatch(this.LinkBox.SelectedItem.ToString()))
                    {
                        this.StatusMessage.Location = new Point(515, 371);
                        ControlActive.CheckMessage(this.StatusMessage, "Некорректная ссылка", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
                        this.LinkBox.Items.RemoveAt(this.LinkBox.SelectedIndex);
                        this.Lcount.Text = $"Список ссылок для загрузки файлов: {this.LinkBox.Items.Count}";
                    }
                    else
                    {
                        if (CheckerFiles.URLExists(this.LinkBox.SelectedItem.ToString(), this.StatusMessage))
                        {
                            this.StatusMessage.Location = new Point(505, 371);
                            ControlActive.CheckMessage(this.StatusMessage, "Ссылка с файлом рабочая!", Color.FromKnownColor(KnownColor.MenuHighlight), 4000);
                        }
                        else
                        {
                            this.StatusMessage.Location = new Point(505, 371);
                            ControlActive.CheckMessage(this.StatusMessage, "Ссылка с файлом не рабочая!", Color.FromKnownColor(KnownColor.MenuHighlight), 4000);
                        }
                    }
                }).ConfigureAwait(false);
            }
        }
        private void MenuLinkBox_Opening(object sender, CancelEventArgs e)
        {
            if (this.LinkBox.Items.Count <= 0) e.Cancel = true;
        }
        private void LinkTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!rgx.IsMatch(this.LinkTextBox.Text) && this.LinkTextBox.Text.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
            {
                this.LinkTextBox.Clear();
                this.StatusMessage.Location = new Point(515, 371);
                ControlActive.CheckMessage(this.StatusMessage, "Некорректная ссылка", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
            }
        }
        private void LinkBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index;
            if (index < 0) return; // Во избежания исключения проверка на 0
            Graphics graph = e.Graphics;
            foreach (int selectedIndex in this.LinkBox.SelectedIndices)
            {
                if (index == selectedIndex)
                {
                    e.DrawBackground();
                    using Brush brush = new SolidBrush(Color.FromArgb(80, 85, 97)); // default 30, 149, 80
                    graph.FillRectangle(brush, e.Bounds); // Цвет background выделенного элемента
                }
            }
            using (Brush forecolor = new SolidBrush(Color.White)) // Цвет forecolor выделенного элемента
            {
                graph.DrawString(this.LinkBox.Items[index]?.ToString(), this.LinkBox.Font, forecolor, e.Bounds.X, e.Bounds.Y);
            }
            e.DrawFocusRectangle();
        }
        private void LinkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LinkBox?.Invalidate();
        }
        private void LinkBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(sender is ListBox listbox)) return;
            string strTip = string.Empty;
            int index = listbox.IndexFromPoint(e.Location);
            if ((index >= 0) && (index < listbox.Items.Count))
                strTip = listbox.Items[index].ToString();
            if (this.HelpInfo.GetToolTip(listbox) != strTip)
                this.HelpInfo.SetToolTip(listbox, strTip);
        }
        private void IcoPath_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.IcoPath.Text))
            {
                this.IcoPath.Clear();
                this.IcoViewer.Image = null;
                this.IcoViewer.BorderStyle = BorderStyle.FixedSingle;
                this.StatusMessage.Location = new Point(524, 371);
                this.LsizeIco.Text = $"Размер иконки: 0";
                ControlActive.CheckMessage(this.StatusMessage, "Иконка не выбрана", Color.FromKnownColor(KnownColor.MenuHighlight), 5000);
            }
        }

        private static readonly Regex rgx = new Regex("^(?:ftp|http)s?://(?!.*://)(?!.*[А-ЯЁа-яё])[^/]+(?:/[^/]+)*/?$");
        private bool CheckIsEmptyBoxs() => this.Controls.OfType<TextBox>().Except(new TextBox[] { this.LinkTextBox, this.IcoPath }).Any(t => string.IsNullOrEmpty(t.Text)) ? true : false;
    }
}
