namespace GameOverLoaderBuilder.Tools
{
    #region Зависимости
    using System;
    #endregion

    /*
        Created by r3xq1
        https://github.com/r3xq1/
        Telegram: https://t.me/r3xq1
    */

    public static class GetFileSize
    {
        private static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        public static string Inizialize(long value)
        {
            if (value >= 0)
            {
                int i = 0, size = 1024; decimal dValue = value;
                while (Math.Round(dValue / size) >= 1)
                {
                    dValue /= size;
                    i++;
                }
                return $"{dValue:n1} {SizeSuffixes[i]}";
            }
            return $"-{Inizialize(-value)}";
        }
    }
}