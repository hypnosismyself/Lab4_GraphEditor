using Lab4_GraphEditor.Model;
using Lab4_GraphEditor.Presenter;
using Lab4_GraphEditor.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab4_GraphEditor
{
    public partial class GraphView : Form
    {
        // Константы
        private const string _FILE_FILTER = "CSV файл (*.csv)|*.csv";
        private readonly string[] _GRAPH_MODES =
        {
            "Line",
            "Spline",
            "Point"
        };

        // Текущий тип графика
        public string CurrentComboBoxItemText = "Line";

        // Презентеры
        private CalculationPresenter CalculationPresenter;
        private FileManagerPresenter FilePresenter;

        // Хелпер для представления
        private readonly ViewHelper ViewHelper = new ViewHelper();

        // Инициализатор представления
        public GraphView()
        {
            InitializeComponent();
        }

        // Обработчики событий формы

        // При загрузке формы
        private void GraphView_Load(object sender, EventArgs e)
        {
            // заполняем комбо
            foreach (var mode in _GRAPH_MODES)
            {
                GraphModeComboBox.Items.Add(mode);
            }

            // выбираем итем
            GraphModeComboBox.SelectedItem = "Line";
        }

        // При вводе в текстовые поля
        private void DataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (ViewHelper.HasComma(textBox.Text))
            {
                if (e.KeyChar == ',')
                    e.Handled = true;
            }
            else if (!ViewHelper.HasMinus(textBox.Text))
            {
                if (ViewHelper.CanInputMinus(textBox.Text, textBox.Name))
                {
                    if (e.KeyChar == '-')
                        e.Handled = false;
                    else if (!char.IsDigit(e.KeyChar))
                        e.Handled = true;
                }
                else if (ViewHelper.CanInput(e))
                {
                    e.Handled = true;
                }
            }
            else if (ViewHelper.CanInput(e))
            {
                e.Handled = true;
            }
        }

        // При нажатии "Выполнить расчет"
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            CalculationPresenter = new CalculationPresenter(new Calculation(), this);

            // проверка ввода в поля
            if (CheckFields())
            {
                CoordinatesGridView.Rows.Clear();
                CalculationPresenter.GetCells
                    (
                        Convert.ToDouble(LeftBorderTextBox.Text),
                        Convert.ToDouble(RightBorderTextBox.Text),
                        Convert.ToDouble(StepTextBox.Text)
                    );
            }
        }

        // При клике "Очистить все"
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        // При клике "Загрузить данные"
        private void UploadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOpenDialog();
        }

        // При клике "Сохранить расчеты"
        private void SaveCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();
        }

        // При клике "О программе"
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "Табулирование формулы с построением графика | Автор Никольский В.А. ЗЦИС-27",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // При клике на график
        private void GraphVisulizerChart_Click(object sender, EventArgs e)
        {
            GraphVisulizerChart.Dock = DockStyle.None;
            ShowGraphMode(true);
        }

        // При двойном клике на график
        private void GraphVisulizerChart_DoubleClick(object sender, EventArgs e)
        {
            GraphVisulizerChart.Dock = DockStyle.Fill;
            ShowGraphMode(false);
        }

        // При смене значения в комбобоксе
        private void GraphModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            CurrentComboBoxItemText = combo.SelectedItem.ToString();

            UpdateChart();
        }

        // Служебные методы

        // Служебный метод смены отображения элементов на форме
        private void ShowGraphMode(bool mode)
        {
            LeftBorderTextBox.Visible = mode;
            RightBorderTextBox.Visible = mode;
            StepTextBox.Visible = mode;
            label1.Visible = mode;
            label2.Visible = mode;
            label3.Visible = mode;
            ExecuteButton.Visible = mode;
            ClearButton.Visible = mode;
            CoordinatesGridView.Visible = mode;
            GraphModeComboBox.Visible = mode;
        }

        // Служебный метод проверки текстовых полей
        private bool CheckFields()
        {
            bool flag = true;

            TextBox[] text_to_check = new TextBox[3] 
            {
                LeftBorderTextBox,
                RightBorderTextBox,
                StepTextBox,
            };

            double left_border = Convert.ToDouble(LeftBorderTextBox.Text);
            double right_border = Convert.ToDouble(RightBorderTextBox.Text);

            for (int i = 0; i < text_to_check.Length; i++)
            {
                if (text_to_check[i].Text.StartsWith(",") || text_to_check[i].Text.Trim() == "")
                {
                    _ = SelectText(text_to_check[i]);
                    flag = false;
                }
            }

            if (left_border >= right_border)
            {
                _ = SelectText(LeftBorderTextBox);
                _ = SelectText(RightBorderTextBox);
                flag = false;
            }

            return flag;
        }

        // Служебный метод вызова диалога сохранения
        private void ShowOpenDialog()
        {
            FilePresenter = new FileManagerPresenter(new FileManager(), this);

            // инициализация диалога открытия
            OpenFileDialog OpenFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = _FILE_FILTER,
                RestoreDirectory = false
            };

            using (OpenFileDialog)
            {
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // если ок
                    // открываем файл
                    FilePresenter.GetFromFile(OpenFileDialog.FileName);
                }
            }
        }

        // Служебный метод очистки представления
        public void ClearAll()
        {
            CoordinatesGridView.Rows.Clear();
            LeftBorderTextBox.Clear();
            RightBorderTextBox.Clear();
            StepTextBox.Clear();
            GraphVisulizerChart.Series.Clear();
        }

        // Служебный метод вычитки данных из DataGrid
        private Dictionary<double, double> GetContentFromGrid()
        {
            // result: словарь значений X: Y

            Dictionary<double, double> сontent = new Dictionary<double, double>();

            for (int i = 0; i < CoordinatesGridView.RowCount - 1; i++)
            {
                double a = Convert.ToDouble(CoordinatesGridView[0, i].Value);
                double b = Convert.ToDouble(CoordinatesGridView[1, i].Value);

                сontent[a] = b;
            }

            return сontent;
        }

        // Асинхронный метод подсветки текстовых полей с ошибкой
        private async Task SelectText(TextBox e)
        {
            e.BackColor = Color.IndianRed;

            await Task.Delay(1800);

            e.BackColor = Color.White;
        }

        // Метод обновления таблицы
        public void UpdateTable(List<double[]> cells)
        {
            for (int i = 0; i < cells.Count; i++)
            {
                CoordinatesGridView.Rows.Add(cells[i][0], cells[i][1]);
            }
        }

        // Метод обновления графика
        public void UpdateChart()
        {
            GraphVisulizerChart.Series.Clear();

            SeriesChartType graph_type = SeriesChartType.Line;

            // выбираем тип графика по тексту итема комбобокса
            switch (CurrentComboBoxItemText)
            {
                case ("Line"):
                    graph_type = SeriesChartType.Line;
                    break;
                case ("Spline"):
                    graph_type = SeriesChartType.Spline;
                    break;
                case ("Point"):
                    graph_type = SeriesChartType.Point;
                    break;
            }

            Series SeriaPoints = new Series("Sinus")
            {
                ChartType = graph_type
            };

            for (int i = 0; i < CoordinatesGridView.RowCount - 1; i++)
            {
                SeriaPoints.Points.AddXY
                    (
                        CoordinatesGridView[0, i].Value,
                        CoordinatesGridView[1, i].Value
                    );
            }

            // добавляем созданный набор точек в Chart
            GraphVisulizerChart.Series.Add(SeriaPoints);
        }

        // Метод вызова окна сохранения
        private void ShowSaveDialog()
        {
            string temp_path;
            FilePresenter = new FileManagerPresenter(new FileManager(), this);

            // инициализация диалога сохранения файла
            SaveFileDialog SaveFileDialog = new SaveFileDialog
            {
                Title = "Сохранить как",
                InitialDirectory = "c:\\",
                Filter = _FILE_FILTER,
                RestoreDirectory = false,
                OverwritePrompt = true,
                FileName = "Точки построения.csv"
            };

            using (SaveFileDialog)
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // если ок
                    // открываем диалог сохранения
                    temp_path = SaveFileDialog.FileName;

                    Dictionary<double, double> Content = new Dictionary<double, double>();
                    Content = GetContentFromGrid();

                    // сохраняем файл на БЛ
                    FileSave(temp_path, GetContentFromGrid());
                }
            }
        }

        // Метод сохранения файла
        private void FileSave(string file_path, Dictionary<double, double> file_content)
        {
            // arg: file_path - путь к файлу
            // arg: file_content - содержимое файла

            FilePresenter = new FileManagerPresenter(new FileManager(), this);

            if (!FilePresenter.Save(file_path, file_content))
            {
                // если файл не смогли сохранить
                ShowErrorMessageBox("Файл не сохранен", "Не удалось найти сохранённый файл");
            }
            else
            {
                // если файл смогли сохранить
                ShowInformationMessageBox("Файл сохранен", $"Путь к файлу:\n{file_path}");
            }
        }

        // Метод вызова информационного сообщения
        private void ShowInformationMessageBox(string title, string message)
        {
            // arg: title - текст окна
            // message: title - текст сообщения

            MessageBox.Show(
                message, title, 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        // Метод вызова сообщения об ошибке
        public void ShowErrorMessageBox(string title, string message)
        {
            // arg: title - текст окна
            // message: title - текст сообщения

            MessageBox.Show(
                message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
