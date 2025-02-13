using System;
using System.Collections.Generic;
using System.IO;
using Lab4_GraphEditor.Presenter;

namespace Lab4_GraphEditor.Model
{
    internal class FileManager
    {
        // Модель | Менеджер файлов

        // инициализация презентера
        private FileManagerPresenter FileManagerPresenter;

        // поле путь к файлу
        public string FilePath;

        // константа разделитель
        private const char _SPLIT_CHAR = ';';

        // Метод вычитки из файла
        public List<double[]> GetContent()
        {
            // result: список строк

            List<double[]> result = new List<double[]>();

            try
            {
                using(StreamReader StreamReader = new StreamReader(FilePath))
                {
                    // счетчик строк
                    int counter = 0;

                    string line;

                    while ((line = StreamReader.ReadLine()) != null)
                    {
                        counter++;

                        // проверяем строку
                        if (line.Split(_SPLIT_CHAR).Length != 2)
                        {
                            // генерим исключение, если строка на 2 не делится

                            throw new Exception($"Строка {counter} не соответствует формату");
                        }

                        double[] str = new double[2];
                        str[0] = Convert.ToDouble(line.Split(_SPLIT_CHAR)[0]);
                        str[1] = Convert.ToDouble(line.Split(_SPLIT_CHAR)[1]);

                        result.Add(str);
                    }
                }
            }
            catch (Exception ex)
            {
                // ловим исключения и выводим на UI
                FileManagerPresenter = new FileManagerPresenter(this, new GraphView());
                FileManagerPresenter.ShowBLError(ex.Message);
            }

            return result;
        }

        // Метод сохранения файла
        public void Save(Dictionary<double, double> data)
        {
            try
            {
                using (StreamWriter StreamWriter = new StreamWriter(FilePath, true))
                {
                    foreach (var item in data)
                    {
                        StreamWriter.WriteLine
                            (
                                $"{item.Key}{_SPLIT_CHAR}{item.Value}"
                            );
                    }
                }
            }
            catch { }
        }

        // Метод проверки существования файла
        public bool Exist()
        {
            // return: файл существует?

            return File.Exists(FilePath);
        }
    }
}
