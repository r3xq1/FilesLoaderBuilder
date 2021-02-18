namespace GameOverLoaderBuilder
{
    partial class LrBFrm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LrBFrm));
            this.AddLink = new System.Windows.Forms.Button();
            this.LinkBox = new System.Windows.Forms.ListBox();
            this.MenuLinkBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CheckLinkBox = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadLinkBox = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveLinkBox = new System.Windows.Forms.ToolStripMenuItem();
            this.LinkTextBox = new System.Windows.Forms.TextBox();
            this.Lcount = new System.Windows.Forms.Label();
            this.Lfield = new System.Windows.Forms.Label();
            this.Lsave = new System.Windows.Forms.Label();
            this.ListSave = new System.Windows.Forms.ComboBox();
            this.UPanel = new System.Windows.Forms.Panel();
            this.AppExit = new System.Windows.Forms.Button();
            this.LogoText = new System.Windows.Forms.Label();
            this.CleanLink = new System.Windows.Forms.Button();
            this.CleanAll = new System.Windows.Forms.Button();
            this.Build = new System.Windows.Forms.Button();
            this.StatusMessage = new System.Windows.Forms.Label();
            this.LAssVerText = new System.Windows.Forms.Label();
            this.AssVerTextBox = new System.Windows.Forms.TextBox();
            this.LAssGuidText = new System.Windows.Forms.Label();
            this.AssGuidTextBox = new System.Windows.Forms.TextBox();
            this.LAssCompanyText = new System.Windows.Forms.Label();
            this.AssCompanyTextBox = new System.Windows.Forms.TextBox();
            this.LAssFVText = new System.Windows.Forms.Label();
            this.AssFileVerTextBox = new System.Windows.Forms.TextBox();
            this.LAssCopyText = new System.Windows.Forms.Label();
            this.AssCopyrightTextBox = new System.Windows.Forms.TextBox();
            this.LAssProdText = new System.Windows.Forms.Label();
            this.AssProductTextBox = new System.Windows.Forms.TextBox();
            this.LAssDescText = new System.Windows.Forms.Label();
            this.AssDescriptTextBox = new System.Windows.Forms.TextBox();
            this.LAssTitleText = new System.Windows.Forms.Label();
            this.AssTitleTextBox = new System.Windows.Forms.TextBox();
            this.GenAss = new System.Windows.Forms.Button();
            this.LnameBuild = new System.Windows.Forms.Label();
            this.NameBuildTextBox = new System.Windows.Forms.TextBox();
            this.IcoViewer = new System.Windows.Forms.PictureBox();
            this.SelectIcon = new System.Windows.Forms.Button();
            this.IcoPath = new System.Windows.Forms.TextBox();
            this.IconText = new System.Windows.Forms.Label();
            this.LsizeIco = new System.Windows.Forms.Label();
            this.nPump = new System.Windows.Forms.NumericUpDown();
            this.LpumpBuild = new System.Windows.Forms.Label();
            this.HelpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.AddToTelegram = new System.Windows.Forms.LinkLabel();
            this.SuicideActivate = new System.Windows.Forms.CheckBox();
            this.RunFromAdminActivate = new System.Windows.Forms.CheckBox();
            this.MenuLinkBox.SuspendLayout();
            this.UPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPump)).BeginInit();
            this.SuspendLayout();
            // 
            // AddLink
            // 
            this.AddLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.AddLink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.AddLink.FlatAppearance.BorderSize = 0;
            this.AddLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLink.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddLink.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddLink.Location = new System.Drawing.Point(15, 185);
            this.AddLink.Name = "AddLink";
            this.AddLink.Size = new System.Drawing.Size(177, 23);
            this.AddLink.TabIndex = 0;
            this.AddLink.TabStop = false;
            this.AddLink.Text = "Добавить ссылку в список";
            this.AddLink.UseVisualStyleBackColor = false;
            this.AddLink.Click += new System.EventHandler(this.AddLink_Click);
            // 
            // LinkBox
            // 
            this.LinkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.LinkBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinkBox.ContextMenuStrip = this.MenuLinkBox;
            this.LinkBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.LinkBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LinkBox.FormattingEnabled = true;
            this.LinkBox.ItemHeight = 16;
            this.LinkBox.Location = new System.Drawing.Point(15, 61);
            this.LinkBox.Name = "LinkBox";
            this.LinkBox.Size = new System.Drawing.Size(375, 66);
            this.LinkBox.Sorted = true;
            this.LinkBox.TabIndex = 1;
            this.LinkBox.TabStop = false;
            this.LinkBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LinkBox_DrawItem);
            this.LinkBox.SelectedIndexChanged += new System.EventHandler(this.LinkBox_SelectedIndexChanged);
            this.LinkBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LinkBox_MouseMove);
            // 
            // MenuLinkBox
            // 
            this.MenuLinkBox.AllowMerge = false;
            this.MenuLinkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.MenuLinkBox.DropShadowEnabled = false;
            this.MenuLinkBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.MenuLinkBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckLinkBox,
            this.DownloadLinkBox,
            this.RemoveLinkBox});
            this.MenuLinkBox.Name = "MenuLinkBox";
            this.MenuLinkBox.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuLinkBox.ShowImageMargin = false;
            this.MenuLinkBox.ShowItemToolTips = false;
            this.MenuLinkBox.Size = new System.Drawing.Size(146, 70);
            this.MenuLinkBox.Opening += new System.ComponentModel.CancelEventHandler(this.MenuLinkBox_Opening);
            // 
            // CheckLinkBox
            // 
            this.CheckLinkBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CheckLinkBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.CheckLinkBox.ForeColor = System.Drawing.Color.White;
            this.CheckLinkBox.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CheckLinkBox.Name = "CheckLinkBox";
            this.CheckLinkBox.ShowShortcutKeys = false;
            this.CheckLinkBox.Size = new System.Drawing.Size(145, 22);
            this.CheckLinkBox.Text = "Проверить ссылку";
            this.CheckLinkBox.Click += new System.EventHandler(this.CheckLinkBox_Click);
            // 
            // DownloadLinkBox
            // 
            this.DownloadLinkBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.DownloadLinkBox.ForeColor = System.Drawing.Color.White;
            this.DownloadLinkBox.Name = "DownloadLinkBox";
            this.DownloadLinkBox.Size = new System.Drawing.Size(145, 22);
            this.DownloadLinkBox.Text = "Загрузить файл";
            this.DownloadLinkBox.Click += new System.EventHandler(this.DownloadLinkBox_Click);
            // 
            // RemoveLinkBox
            // 
            this.RemoveLinkBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.RemoveLinkBox.ForeColor = System.Drawing.Color.White;
            this.RemoveLinkBox.Name = "RemoveLinkBox";
            this.RemoveLinkBox.Size = new System.Drawing.Size(145, 22);
            this.RemoveLinkBox.Text = "Удалить ссылку";
            this.RemoveLinkBox.Click += new System.EventHandler(this.RemoveLinkBox_Click);
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.LinkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinkTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LinkTextBox.Location = new System.Drawing.Point(15, 159);
            this.LinkTextBox.MaxLength = 190;
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(375, 21);
            this.LinkTextBox.TabIndex = 3;
            this.LinkTextBox.TabStop = false;
            this.HelpInfo.SetToolTip(this.LinkTextBox, "Введите в поле прямую ссылку на файл для загрузки");
            this.LinkTextBox.TextChanged += new System.EventHandler(this.LinkTextBox_TextChanged);
            // 
            // Lcount
            // 
            this.Lcount.AutoSize = true;
            this.Lcount.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lcount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lcount.Location = new System.Drawing.Point(12, 40);
            this.Lcount.Name = "Lcount";
            this.Lcount.Size = new System.Drawing.Size(218, 16);
            this.Lcount.TabIndex = 4;
            this.Lcount.Text = "Список ссылок для загрузки файлов: 0";
            // 
            // Lfield
            // 
            this.Lfield.AutoSize = true;
            this.Lfield.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.Lfield.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lfield.Location = new System.Drawing.Point(12, 138);
            this.Lfield.Name = "Lfield";
            this.Lfield.Size = new System.Drawing.Size(223, 16);
            this.Lfield.TabIndex = 5;
            this.Lfield.Text = "Впишите прямую ссылку в поле ввода:";
            // 
            // Lsave
            // 
            this.Lsave.AutoSize = true;
            this.Lsave.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.Lsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lsave.Location = new System.Drawing.Point(12, 250);
            this.Lsave.Name = "Lsave";
            this.Lsave.Size = new System.Drawing.Size(163, 16);
            this.Lsave.TabIndex = 8;
            this.Lsave.Text = "Выберите путь сохранения:";
            // 
            // ListSave
            // 
            this.ListSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ListSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListSave.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.ListSave.ForeColor = System.Drawing.SystemColors.Window;
            this.ListSave.FormattingEnabled = true;
            this.ListSave.Location = new System.Drawing.Point(188, 246);
            this.ListSave.MaxDropDownItems = 4;
            this.ListSave.Name = "ListSave";
            this.ListSave.Size = new System.Drawing.Size(202, 22);
            this.ListSave.TabIndex = 9;
            this.ListSave.TabStop = false;
            this.ListSave.SelectedIndexChanged += new System.EventHandler(this.ListSave_SelectedIndexChanged);
            // 
            // UPanel
            // 
            this.UPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.UPanel.Controls.Add(this.AppExit);
            this.UPanel.Controls.Add(this.LogoText);
            this.UPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UPanel.Location = new System.Drawing.Point(0, 0);
            this.UPanel.Name = "UPanel";
            this.UPanel.Size = new System.Drawing.Size(762, 29);
            this.UPanel.TabIndex = 11;
            // 
            // AppExit
            // 
            this.AppExit.FlatAppearance.BorderSize = 0;
            this.AppExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.AppExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AppExit.Location = new System.Drawing.Point(732, -1);
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(31, 30);
            this.AppExit.TabIndex = 13;
            this.AppExit.TabStop = false;
            this.AppExit.Text = "X";
            this.AppExit.UseVisualStyleBackColor = true;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // LogoText
            // 
            this.LogoText.AutoSize = true;
            this.LogoText.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogoText.Location = new System.Drawing.Point(16, 7);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(304, 15);
            this.LogoText.TabIndex = 12;
            this.LogoText.Text = "GameOver Loader Builder [RU] - Special for Game";
            // 
            // CleanLink
            // 
            this.CleanLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.CleanLink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.CleanLink.FlatAppearance.BorderSize = 0;
            this.CleanLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanLink.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.CleanLink.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CleanLink.Location = new System.Drawing.Point(198, 185);
            this.CleanLink.Name = "CleanLink";
            this.CleanLink.Size = new System.Drawing.Size(192, 23);
            this.CleanLink.TabIndex = 12;
            this.CleanLink.TabStop = false;
            this.CleanLink.Text = "Удалить выбранную ссылку";
            this.CleanLink.UseVisualStyleBackColor = false;
            this.CleanLink.Click += new System.EventHandler(this.CleanLink_Click);
            // 
            // CleanAll
            // 
            this.CleanAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.CleanAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.CleanAll.FlatAppearance.BorderSize = 0;
            this.CleanAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanAll.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.CleanAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CleanAll.Location = new System.Drawing.Point(15, 214);
            this.CleanAll.Name = "CleanAll";
            this.CleanAll.Size = new System.Drawing.Size(375, 23);
            this.CleanAll.TabIndex = 13;
            this.CleanAll.TabStop = false;
            this.CleanAll.Text = "Очистить все поля ";
            this.CleanAll.UseVisualStyleBackColor = false;
            this.CleanAll.Click += new System.EventHandler(this.CleanAll_Click);
            // 
            // Build
            // 
            this.Build.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.Build.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Build.FlatAppearance.BorderSize = 0;
            this.Build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Build.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.Build.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Build.Location = new System.Drawing.Point(404, 335);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(347, 23);
            this.Build.TabIndex = 14;
            this.Build.TabStop = false;
            this.Build.Text = "Создать загрузчик";
            this.Build.UseVisualStyleBackColor = false;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // StatusMessage
            // 
            this.StatusMessage.AutoSize = true;
            this.StatusMessage.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusMessage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.StatusMessage.Location = new System.Drawing.Point(524, 371);
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(0, 16);
            this.StatusMessage.TabIndex = 15;
            // 
            // LAssVerText
            // 
            this.LAssVerText.AutoSize = true;
            this.LAssVerText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.LAssVerText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAssVerText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LAssVerText.Location = new System.Drawing.Point(401, 186);
            this.LAssVerText.Name = "LAssVerText";
            this.LAssVerText.Size = new System.Drawing.Size(111, 14);
            this.LAssVerText.TabIndex = 141;
            this.LAssVerText.Text = "AssemblyVersion:";
            // 
            // AssVerTextBox
            // 
            this.AssVerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.AssVerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssVerTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssVerTextBox.Location = new System.Drawing.Point(540, 183);
            this.AssVerTextBox.MaxLength = 15;
            this.AssVerTextBox.Name = "AssVerTextBox";
            this.AssVerTextBox.Size = new System.Drawing.Size(211, 20);
            this.AssVerTextBox.TabIndex = 140;
            this.AssVerTextBox.TabStop = false;
            this.AssVerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpInfo.SetToolTip(this.AssVerTextBox, "Версия сборки");
            // 
            // LAssGuidText
            // 
            this.LAssGuidText.AutoSize = true;
            this.LAssGuidText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.LAssGuidText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAssGuidText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LAssGuidText.Location = new System.Drawing.Point(401, 239);
            this.LAssGuidText.Name = "LAssGuidText";
            this.LAssGuidText.Size = new System.Drawing.Size(95, 14);
            this.LAssGuidText.TabIndex = 139;
            this.LAssGuidText.Text = "AssemblyGuid:";
            // 
            // AssGuidTextBox
            // 
            this.AssGuidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.AssGuidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssGuidTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssGuidTextBox.Location = new System.Drawing.Point(540, 236);
            this.AssGuidTextBox.MaxLength = 70;
            this.AssGuidTextBox.Name = "AssGuidTextBox";
            this.AssGuidTextBox.ReadOnly = true;
            this.AssGuidTextBox.Size = new System.Drawing.Size(211, 20);
            this.AssGuidTextBox.TabIndex = 138;
            this.AssGuidTextBox.TabStop = false;
            this.AssGuidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpInfo.SetToolTip(this.AssGuidTextBox, "GUID для идентификатора typelib");
            // 
            // LAssCompanyText
            // 
            this.LAssCompanyText.AutoSize = true;
            this.LAssCompanyText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.LAssCompanyText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAssCompanyText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LAssCompanyText.Location = new System.Drawing.Point(401, 105);
            this.LAssCompanyText.Name = "LAssCompanyText";
            this.LAssCompanyText.Size = new System.Drawing.Size(123, 14);
            this.LAssCompanyText.TabIndex = 137;
            this.LAssCompanyText.Text = "AssemblyCompany:";
            // 
            // AssCompanyTextBox
            // 
            this.AssCompanyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.AssCompanyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssCompanyTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssCompanyTextBox.Location = new System.Drawing.Point(540, 103);
            this.AssCompanyTextBox.MaxLength = 70;
            this.AssCompanyTextBox.Name = "AssCompanyTextBox";
            this.AssCompanyTextBox.Size = new System.Drawing.Size(211, 20);
            this.AssCompanyTextBox.TabIndex = 136;
            this.AssCompanyTextBox.TabStop = false;
            this.AssCompanyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpInfo.SetToolTip(this.AssCompanyTextBox, "Название компании");
            // 
            // LAssFVText
            // 
            this.LAssFVText.AutoSize = true;
            this.LAssFVText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.LAssFVText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAssFVText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LAssFVText.Location = new System.Drawing.Point(401, 212);
            this.LAssFVText.Name = "LAssFVText";
            this.LAssFVText.Size = new System.Drawing.Size(132, 14);
            this.LAssFVText.TabIndex = 135;
            this.LAssFVText.Text = "AssemblyFileVersion:";
            // 
            // AssFileVerTextBox
            // 
            this.AssFileVerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.AssFileVerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssFileVerTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssFileVerTextBox.Location = new System.Drawing.Point(540, 209);
            this.AssFileVerTextBox.MaxLength = 15;
            this.AssFileVerTextBox.Name = "AssFileVerTextBox";
            this.AssFileVerTextBox.Size = new System.Drawing.Size(211, 20);
            this.AssFileVerTextBox.TabIndex = 134;
            this.AssFileVerTextBox.TabStop = false;
            this.AssFileVerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpInfo.SetToolTip(this.AssFileVerTextBox, "Номер версии файла Win32. \r\nПо умолчанию совпадает с версией сборки.");
            // 
            // LAssCopyText
            // 
            this.LAssCopyText.AutoSize = true;
            this.LAssCopyText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.LAssCopyText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAssCopyText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LAssCopyText.Location = new System.Drawing.Point(401, 159);
            this.LAssCopyText.Name = "LAssCopyText";
            this.LAssCopyText.Size = new System.Drawing.Size(126, 14);
            this.LAssCopyText.TabIndex = 133;
            this.LAssCopyText.Text = "AssemblyCopyright:";
            // 
            // AssCopyrightTextBox
            // 
            this.AssCopyrightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.AssCopyrightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssCopyrightTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssCopyrightTextBox.Location = new System.Drawing.Point(540, 156);
            this.AssCopyrightTextBox.MaxLength = 70;
            this.AssCopyrightTextBox.Name = "AssCopyrightTextBox";
            this.AssCopyrightTextBox.Size = new System.Drawing.Size(211, 20);
            this.AssCopyrightTextBox.TabIndex = 132;
            this.AssCopyrightTextBox.TabStop = false;
            this.AssCopyrightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpInfo.SetToolTip(this.AssCopyrightTextBox, "Авторское право на программу");
            // 
            // LAssProdText
            // 
            this.LAssProdText.AutoSize = true;
            this.LAssProdText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.LAssProdText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAssProdText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LAssProdText.Location = new System.Drawing.Point(401, 132);
            this.LAssProdText.Name = "LAssProdText";
            this.LAssProdText.Size = new System.Drawing.Size(112, 14);
            this.LAssProdText.TabIndex = 131;
            this.LAssProdText.Text = "AssemblyProduct:";
            // 
            // AssProductTextBox
            // 
            this.AssProductTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.AssProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssProductTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssProductTextBox.Location = new System.Drawing.Point(540, 129);
            this.AssProductTextBox.MaxLength = 70;
            this.AssProductTextBox.Name = "AssProductTextBox";
            this.AssProductTextBox.Size = new System.Drawing.Size(211, 20);
            this.AssProductTextBox.TabIndex = 130;
            this.AssProductTextBox.TabStop = false;
            this.AssProductTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpInfo.SetToolTip(this.AssProductTextBox, "Информация о продукте");
            // 
            // LAssDescText
            // 
            this.LAssDescText.AutoSize = true;
            this.LAssDescText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.LAssDescText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAssDescText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LAssDescText.Location = new System.Drawing.Point(401, 80);
            this.LAssDescText.Name = "LAssDescText";
            this.LAssDescText.Size = new System.Drawing.Size(132, 14);
            this.LAssDescText.TabIndex = 129;
            this.LAssDescText.Text = "AssemblyDescription:";
            // 
            // AssDescriptTextBox
            // 
            this.AssDescriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.AssDescriptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssDescriptTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssDescriptTextBox.Location = new System.Drawing.Point(540, 77);
            this.AssDescriptTextBox.MaxLength = 70;
            this.AssDescriptTextBox.Name = "AssDescriptTextBox";
            this.AssDescriptTextBox.Size = new System.Drawing.Size(211, 20);
            this.AssDescriptTextBox.TabIndex = 128;
            this.AssDescriptTextBox.TabStop = false;
            this.AssDescriptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpInfo.SetToolTip(this.AssDescriptTextBox, "Краткое описание сборки");
            // 
            // LAssTitleText
            // 
            this.LAssTitleText.AutoSize = true;
            this.LAssTitleText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.LAssTitleText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAssTitleText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LAssTitleText.Location = new System.Drawing.Point(401, 53);
            this.LAssTitleText.Name = "LAssTitleText";
            this.LAssTitleText.Size = new System.Drawing.Size(94, 14);
            this.LAssTitleText.TabIndex = 127;
            this.LAssTitleText.Text = "AssemblyTitle:";
            // 
            // AssTitleTextBox
            // 
            this.AssTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.AssTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssTitleTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssTitleTextBox.Location = new System.Drawing.Point(540, 50);
            this.AssTitleTextBox.MaxLength = 70;
            this.AssTitleTextBox.Name = "AssTitleTextBox";
            this.AssTitleTextBox.Size = new System.Drawing.Size(211, 20);
            this.AssTitleTextBox.TabIndex = 126;
            this.AssTitleTextBox.TabStop = false;
            this.AssTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpInfo.SetToolTip(this.AssTitleTextBox, "Название сборки как информационного продукта");
            // 
            // GenAss
            // 
            this.GenAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.GenAss.FlatAppearance.BorderSize = 0;
            this.GenAss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GenAss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenAss.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.GenAss.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenAss.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GenAss.Location = new System.Drawing.Point(404, 303);
            this.GenAss.Name = "GenAss";
            this.GenAss.Size = new System.Drawing.Size(347, 23);
            this.GenAss.TabIndex = 125;
            this.GenAss.TabStop = false;
            this.GenAss.Text = "Генерировать свойства для загрузчика";
            this.GenAss.UseVisualStyleBackColor = false;
            this.GenAss.Click += new System.EventHandler(this.GenAss_Click);
            // 
            // LnameBuild
            // 
            this.LnameBuild.AutoSize = true;
            this.LnameBuild.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.LnameBuild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LnameBuild.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LnameBuild.Location = new System.Drawing.Point(401, 277);
            this.LnameBuild.Name = "LnameBuild";
            this.LnameBuild.Size = new System.Drawing.Size(78, 14);
            this.LnameBuild.TabIndex = 143;
            this.LnameBuild.Text = "Имя файла:";
            // 
            // NameBuildTextBox
            // 
            this.NameBuildTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.NameBuildTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBuildTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBuildTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.NameBuildTextBox.Location = new System.Drawing.Point(485, 273);
            this.NameBuildTextBox.MaxLength = 50;
            this.NameBuildTextBox.Name = "NameBuildTextBox";
            this.NameBuildTextBox.Size = new System.Drawing.Size(265, 21);
            this.NameBuildTextBox.TabIndex = 142;
            this.NameBuildTextBox.TabStop = false;
            this.NameBuildTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpInfo.SetToolTip(this.NameBuildTextBox, "Имя билд файла.\r\nВводить без .exe");
            // 
            // IcoViewer
            // 
            this.IcoViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IcoViewer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IcoViewer.Location = new System.Drawing.Point(15, 304);
            this.IcoViewer.Name = "IcoViewer";
            this.IcoViewer.Size = new System.Drawing.Size(93, 54);
            this.IcoViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IcoViewer.TabIndex = 147;
            this.IcoViewer.TabStop = false;
            this.HelpInfo.SetToolTip(this.IcoViewer, "Перетащите иконку в это окно для вставки.");
            this.IcoViewer.DragDrop += new System.Windows.Forms.DragEventHandler(this.IcoViewer_DragDrop);
            this.IcoViewer.DragEnter += new System.Windows.Forms.DragEventHandler(this.IcoViewer_DragEnter);
            // 
            // SelectIcon
            // 
            this.SelectIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(97)))));
            this.SelectIcon.FlatAppearance.BorderSize = 0;
            this.SelectIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectIcon.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.SelectIcon.ForeColor = System.Drawing.Color.White;
            this.SelectIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectIcon.Location = new System.Drawing.Point(119, 307);
            this.SelectIcon.Name = "SelectIcon";
            this.SelectIcon.Size = new System.Drawing.Size(271, 23);
            this.SelectIcon.TabIndex = 146;
            this.SelectIcon.TabStop = false;
            this.SelectIcon.Text = "Выбрать иконку для загрузчика";
            this.SelectIcon.UseVisualStyleBackColor = false;
            this.SelectIcon.Click += new System.EventHandler(this.SelectIcon_Click);
            // 
            // IcoPath
            // 
            this.IcoPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.IcoPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IcoPath.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IcoPath.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.IcoPath.Location = new System.Drawing.Point(119, 281);
            this.IcoPath.MaxLength = 999999;
            this.IcoPath.Name = "IcoPath";
            this.IcoPath.Size = new System.Drawing.Size(271, 21);
            this.IcoPath.TabIndex = 145;
            this.IcoPath.TabStop = false;
            this.IcoPath.TextChanged += new System.EventHandler(this.IcoPath_TextChanged);
            // 
            // IconText
            // 
            this.IconText.AutoSize = true;
            this.IconText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.IconText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IconText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IconText.Location = new System.Drawing.Point(12, 283);
            this.IconText.Name = "IconText";
            this.IconText.Size = new System.Drawing.Size(96, 14);
            this.IconText.TabIndex = 144;
            this.IconText.Text = "Путь к иконке:";
            // 
            // LsizeIco
            // 
            this.LsizeIco.AutoSize = true;
            this.LsizeIco.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LsizeIco.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LsizeIco.Location = new System.Drawing.Point(12, 362);
            this.LsizeIco.Name = "LsizeIco";
            this.LsizeIco.Size = new System.Drawing.Size(106, 16);
            this.LsizeIco.TabIndex = 148;
            this.LsizeIco.Text = "Размер иконки: 0 ";
            // 
            // nPump
            // 
            this.nPump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.nPump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nPump.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.nPump.ForeColor = System.Drawing.Color.White;
            this.nPump.Location = new System.Drawing.Point(313, 336);
            this.nPump.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nPump.Name = "nPump";
            this.nPump.Size = new System.Drawing.Size(77, 21);
            this.nPump.TabIndex = 149;
            this.nPump.TabStop = false;
            this.nPump.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpInfo.SetToolTip(this.nPump, "По умолчанию (0 kb) - Не увеличивает!\r\nУвеличить размер можно максимально до 5000" +
        " (кб)\r\n10 - 10 KB\r\n100 - 100 KB\r\n1000 - 1.00 MB\r\n5000 - 5.00 MB");
            this.nPump.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // LpumpBuild
            // 
            this.LpumpBuild.AutoSize = true;
            this.LpumpBuild.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.LpumpBuild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LpumpBuild.Location = new System.Drawing.Point(116, 338);
            this.LpumpBuild.Name = "LpumpBuild";
            this.LpumpBuild.Size = new System.Drawing.Size(191, 16);
            this.LpumpBuild.TabIndex = 150;
            this.LpumpBuild.Text = "Увеличить размер загрузчика на:";
            // 
            // HelpInfo
            // 
            this.HelpInfo.AutoPopDelay = 3000;
            this.HelpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.HelpInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HelpInfo.InitialDelay = 100;
            this.HelpInfo.IsBalloon = true;
            this.HelpInfo.ReshowDelay = 100;
            this.HelpInfo.ToolTipTitle = "Подсказка";
            // 
            // AddToTelegram
            // 
            this.AddToTelegram.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.AddToTelegram.AutoSize = true;
            this.AddToTelegram.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.AddToTelegram.LinkColor = System.Drawing.Color.SlateGray;
            this.AddToTelegram.Location = new System.Drawing.Point(687, 421);
            this.AddToTelegram.Name = "AddToTelegram";
            this.AddToTelegram.Size = new System.Drawing.Size(63, 13);
            this.AddToTelegram.TabIndex = 151;
            this.AddToTelegram.TabStop = true;
            this.AddToTelegram.Text = "Tg: @r3xq1";
            this.HelpInfo.SetToolTip(this.AddToTelegram, "Кликните чтобы добавить разработчика в телеграм");
            this.AddToTelegram.VisitedLinkColor = System.Drawing.Color.DarkGreen;
            this.AddToTelegram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddToTelegram_LinkClicked);
            // 
            // SuicideActivate
            // 
            this.SuicideActivate.AutoSize = true;
            this.SuicideActivate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SuicideActivate.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.SuicideActivate.ForeColor = System.Drawing.Color.White;
            this.SuicideActivate.Location = new System.Drawing.Point(15, 391);
            this.SuicideActivate.Name = "SuicideActivate";
            this.SuicideActivate.Size = new System.Drawing.Size(175, 20);
            this.SuicideActivate.TabIndex = 152;
            this.SuicideActivate.TabStop = false;
            this.SuicideActivate.Text = "Само-удаление билд файла";
            this.SuicideActivate.UseVisualStyleBackColor = true;
            // 
            // RunFromAdminActivate
            // 
            this.RunFromAdminActivate.AutoSize = true;
            this.RunFromAdminActivate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RunFromAdminActivate.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.RunFromAdminActivate.ForeColor = System.Drawing.Color.White;
            this.RunFromAdminActivate.Location = new System.Drawing.Point(15, 416);
            this.RunFromAdminActivate.Name = "RunFromAdminActivate";
            this.RunFromAdminActivate.Size = new System.Drawing.Size(168, 20);
            this.RunFromAdminActivate.TabIndex = 153;
            this.RunFromAdminActivate.TabStop = false;
            this.RunFromAdminActivate.Text = "Запуск файлов от Админа";
            this.RunFromAdminActivate.UseVisualStyleBackColor = true;
            // 
            // LrBFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(762, 445);
            this.Controls.Add(this.RunFromAdminActivate);
            this.Controls.Add(this.SuicideActivate);
            this.Controls.Add(this.AddToTelegram);
            this.Controls.Add(this.LpumpBuild);
            this.Controls.Add(this.nPump);
            this.Controls.Add(this.LsizeIco);
            this.Controls.Add(this.IcoViewer);
            this.Controls.Add(this.SelectIcon);
            this.Controls.Add(this.IcoPath);
            this.Controls.Add(this.IconText);
            this.Controls.Add(this.LnameBuild);
            this.Controls.Add(this.NameBuildTextBox);
            this.Controls.Add(this.LAssVerText);
            this.Controls.Add(this.AssVerTextBox);
            this.Controls.Add(this.LAssGuidText);
            this.Controls.Add(this.AssGuidTextBox);
            this.Controls.Add(this.LAssCompanyText);
            this.Controls.Add(this.AssCompanyTextBox);
            this.Controls.Add(this.LAssFVText);
            this.Controls.Add(this.AssFileVerTextBox);
            this.Controls.Add(this.LAssCopyText);
            this.Controls.Add(this.AssCopyrightTextBox);
            this.Controls.Add(this.LAssProdText);
            this.Controls.Add(this.AssProductTextBox);
            this.Controls.Add(this.LAssDescText);
            this.Controls.Add(this.AssDescriptTextBox);
            this.Controls.Add(this.LAssTitleText);
            this.Controls.Add(this.AssTitleTextBox);
            this.Controls.Add(this.GenAss);
            this.Controls.Add(this.StatusMessage);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.CleanAll);
            this.Controls.Add(this.CleanLink);
            this.Controls.Add(this.UPanel);
            this.Controls.Add(this.ListSave);
            this.Controls.Add(this.Lsave);
            this.Controls.Add(this.Lfield);
            this.Controls.Add(this.Lcount);
            this.Controls.Add(this.LinkTextBox);
            this.Controls.Add(this.LinkBox);
            this.Controls.Add(this.AddLink);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LrBFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mass Loader by r3xq1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LrBFrm_Load);
            this.MenuLinkBox.ResumeLayout(false);
            this.UPanel.ResumeLayout(false);
            this.UPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPump)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddLink;
        private System.Windows.Forms.ListBox LinkBox;
        private System.Windows.Forms.TextBox LinkTextBox;
        private System.Windows.Forms.Label Lcount;
        private System.Windows.Forms.Label Lfield;
        private System.Windows.Forms.Label Lsave;
        private System.Windows.Forms.ComboBox ListSave;
        private System.Windows.Forms.Panel UPanel;
        private System.Windows.Forms.Button AppExit;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Button CleanLink;
        private System.Windows.Forms.Button CleanAll;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.Label StatusMessage;
        private System.Windows.Forms.Label LAssVerText;
        private System.Windows.Forms.TextBox AssVerTextBox;
        private System.Windows.Forms.Label LAssGuidText;
        private System.Windows.Forms.TextBox AssGuidTextBox;
        private System.Windows.Forms.Label LAssCompanyText;
        private System.Windows.Forms.TextBox AssCompanyTextBox;
        private System.Windows.Forms.Label LAssFVText;
        private System.Windows.Forms.TextBox AssFileVerTextBox;
        private System.Windows.Forms.Label LAssCopyText;
        private System.Windows.Forms.TextBox AssCopyrightTextBox;
        private System.Windows.Forms.Label LAssProdText;
        private System.Windows.Forms.TextBox AssProductTextBox;
        private System.Windows.Forms.Label LAssDescText;
        private System.Windows.Forms.TextBox AssDescriptTextBox;
        private System.Windows.Forms.Label LAssTitleText;
        private System.Windows.Forms.TextBox AssTitleTextBox;
        private System.Windows.Forms.Button GenAss;
        private System.Windows.Forms.Label LnameBuild;
        private System.Windows.Forms.TextBox NameBuildTextBox;
        private System.Windows.Forms.PictureBox IcoViewer;
        private System.Windows.Forms.Button SelectIcon;
        private System.Windows.Forms.TextBox IcoPath;
        private System.Windows.Forms.Label IconText;
        private System.Windows.Forms.Label LsizeIco;
        private System.Windows.Forms.NumericUpDown nPump;
        private System.Windows.Forms.Label LpumpBuild;
        private System.Windows.Forms.ToolTip HelpInfo;
        private System.Windows.Forms.LinkLabel AddToTelegram;
        private System.Windows.Forms.ContextMenuStrip MenuLinkBox;
        private System.Windows.Forms.ToolStripMenuItem CheckLinkBox;
        private System.Windows.Forms.ToolStripMenuItem DownloadLinkBox;
        private System.Windows.Forms.ToolStripMenuItem RemoveLinkBox;
        private System.Windows.Forms.CheckBox SuicideActivate;
        private System.Windows.Forms.CheckBox RunFromAdminActivate;
    }
}

