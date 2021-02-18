namespace GameOverLoaderBuilder.Tools
{
    #region Зависимости

    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;

    #endregion

    /*
        Created by r3xq1
        https://github.com/r3xq1/
        Telegram: https://t.me/r3xq1
    */
    public static class RndShuffle
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            try
            {
                using var provider = new RNGCryptoServiceProvider();
                int n = list.Count;
                while (n > 1)
                {
                    byte[] box = new byte[1];
                    do provider.GetBytes(box);
                    while (!(box[0] < n * (byte.MaxValue / n)));
                    int k = box[0] % n;
                    n--;
                    T value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
            }
            catch (Exception ex) { throw new Exception("Error Shuffle<T>", ex); }
        }
    }
}