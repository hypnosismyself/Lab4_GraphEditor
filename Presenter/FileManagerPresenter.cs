using Lab4_GraphEditor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_GraphEditor.Presenter
{
    internal class FileManagerPresenter
    {
        // Презентер | Менеджер файлов

        // Инициализация представления
        public GraphView View { get => _view; set => _view = value; }
        private GraphView _view;

        // Инициализация модели
        public FileManager FileManager { get => _file_manager; set => _file_manager = value; }
        private FileManager _file_manager;

        // Конструктор
        public FileManagerPresenter(FileManager model, GraphView view)
        {
            View = view;
            FileManager = model;
        }

        // Презентер открытия файла
        public void GetFromFile(string file_path)
        {
            FileManager.FilePath = file_path;

            // перерисовываем представление по тексту файла
            try
            {
                var result = FileManager.GetContent();
                View.ClearAll();
                View.UpdateTable(result);
            }
            catch { }
        }

        // Презентер сохранения файла
        public bool Save(string file_path, Dictionary<double, double> file_content)
        {
            // arg: file_path - путь к файлу
            // arg: file_content - содержимое файла
            // return: файл создан и сохранён?

            FileManager.FilePath = file_path;

            // сохраняем на БЛ
            FileManager.Save(file_content);

            // проверяем, что файл сохранён и существует
            return FileManager.Exist();
        }

        // Служебный метод отображения ошибки БЛ
        public void ShowBLError(string error_message)
        {
            // arr: error_message - текст ошибки

            View.ShowErrorMessageBox("Ошибка чтения файла", error_message);
        }
    }
}
