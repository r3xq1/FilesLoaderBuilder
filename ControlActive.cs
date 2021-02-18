namespace GameOverLoaderBuilder
{
    #region Зависимости

    using System;
    using System.Drawing;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    #endregion

    /*
        Created by r3xq1
        https://github.com/r3xq1/
        Telegram: https://t.me/r3xq1
    */

    public static class ControlActive
    {
        private static void Active(Label l, int timer, bool visible = false)
        {
            try
            {
                Task.Run(() =>
                {
                    Thread.Sleep(timer);
                    l.Invoke((Action)(() => l.Visible = visible));
                });
            }
            catch { }
        }
        public static void CheckMessage(Label MessageShow, string Text, Color color, int timer, bool True = true)
        {
            MessageShow.Visible = True;
            Active(MessageShow, timer);
            MessageShow.ForeColor = color;
            MessageShow.Text = Text;
        }
        public static void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;

                if (c.GetType() == typeof(GroupBox))
                    CleanAllTextBoxesIn(c);
            }
        }
        public static bool ShowAnima(IntPtr hWnd, int time, Animation.Enums.AnimateWindowFlags flags) => 
        NativeMethods.AnimateWindow(hWnd, time, flags);
    }
}
