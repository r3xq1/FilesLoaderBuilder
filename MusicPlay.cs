namespace GameOverLoaderBuilder
{
    #region Зависимости
    using System;
    using System.IO;
    using System.Media;
    #endregion

    /*
        Created by r3xq1
        https://github.com/r3xq1/
        Telegram: https://t.me/r3xq1
    */

    public static class MusicPlay
    {
        public static void Inizialize(UnmanagedMemoryStream stream)
        {
            try
            {
                using var snd = new SoundPlayer(stream);
                snd.Load();
                if (snd.IsLoadCompleted) snd?.Play();
            }
            catch (Exception ex) { throw new Exception("Error MusicPlay: ", ex); }
        }
    }
}