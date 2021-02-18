namespace GameOverLoaderBuilder
{
    #region Зависимости

    using System;
    using System.Runtime.InteropServices;

    #endregion

    internal static partial class NativeMethods
    {
        #region Для удаления фокуса с кнопок

        [DllImport("user32.dll")]
        internal extern static IntPtr SetFocus(IntPtr hWnd);

        #endregion

        #region Для загрузки анимации формы

        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hWnd, int time, Animation.Enums.AnimateWindowFlags flags);

        #endregion
    }
}