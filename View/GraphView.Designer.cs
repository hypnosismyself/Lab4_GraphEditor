using System.Windows.Forms;

namespace Lab4_GraphEditor
{
    partial class GraphView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphView));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphModeComboBox = new System.Windows.Forms.ComboBox();
            this.GraphVisulizerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CoordinatesGridView = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LeftBorderTextBox = new System.Windows.Forms.TextBox();
            this.RightBorderTextBox = new System.Windows.Forms.TextBox();
            this.StepTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphVisulizerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordinatesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UploadDataToolStripMenuItem,
            this.SaveCalcToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // UploadDataToolStripMenuItem
            // 
            this.UploadDataToolStripMenuItem.Name = "UploadDataToolStripMenuItem";
            this.UploadDataToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.UploadDataToolStripMenuItem.Text = "Загрузить данные";
            this.UploadDataToolStripMenuItem.Click += new System.EventHandler(this.UploadDataToolStripMenuItem_Click);
            // 
            // SaveCalcToolStripMenuItem
            // 
            this.SaveCalcToolStripMenuItem.Name = "SaveCalcToolStripMenuItem";
            this.SaveCalcToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.SaveCalcToolStripMenuItem.Text = "Сохранить расчеты";
            this.SaveCalcToolStripMenuItem.Click += new System.EventHandler(this.SaveCalcToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // GraphModeComboBox
            // 
            this.GraphModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GraphModeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphModeComboBox.Location = new System.Drawing.Point(12, 27);
            this.GraphModeComboBox.Name = "GraphModeComboBox";
            this.GraphModeComboBox.Size = new System.Drawing.Size(386, 33);
            this.GraphModeComboBox.TabIndex = 1;
            this.GraphModeComboBox.SelectedIndexChanged += new System.EventHandler(this.GraphModeComboBox_SelectedIndexChanged);
            // 
            // GraphVisulizerChart
            // 
            this.GraphVisulizerChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "MainArea";
            this.GraphVisulizerChart.ChartAreas.Add(chartArea1);
            this.GraphVisulizerChart.Location = new System.Drawing.Point(404, 27);
            this.GraphVisulizerChart.Name = "GraphVisulizerChart";
            this.GraphVisulizerChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.GraphVisulizerChart.Size = new System.Drawing.Size(384, 376);
            this.GraphVisulizerChart.TabIndex = 2;
            this.GraphVisulizerChart.Text = "chart1";
            this.GraphVisulizerChart.Click += new System.EventHandler(this.GraphVisulizerChart_Click);
            this.GraphVisulizerChart.DoubleClick += new System.EventHandler(this.GraphVisulizerChart_DoubleClick);
            // 
            // CoordinatesGridView
            // 
            this.CoordinatesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoordinatesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoordinatesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.CoordinatesGridView.Location = new System.Drawing.Point(12, 66);
            this.CoordinatesGridView.Name = "CoordinatesGridView";
            this.CoordinatesGridView.ReadOnly = true;
            this.CoordinatesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CoordinatesGridView.Size = new System.Drawing.Size(386, 337);
            this.CoordinatesGridView.TabIndex = 3;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 160;
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.ReadOnly = true;
            this.ColumnY.Width = 160;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteButton.Location = new System.Drawing.Point(194, 409);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(204, 51);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "Выполнить расчет";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(12, 409);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(176, 51);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Очистить все";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LeftBorderTextBox
            // 
            this.LeftBorderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftBorderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftBorderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftBorderTextBox.Location = new System.Drawing.Point(404, 429);
            this.LeftBorderTextBox.MaxLength = 8;
            this.LeftBorderTextBox.Name = "LeftBorderTextBox";
            this.LeftBorderTextBox.Size = new System.Drawing.Size(130, 31);
            this.LeftBorderTextBox.TabIndex = 6;
            this.LeftBorderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataTextBox_KeyPress);
            // 
            // RightBorderTextBox
            // 
            this.RightBorderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RightBorderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightBorderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightBorderTextBox.Location = new System.Drawing.Point(540, 429);
            this.RightBorderTextBox.MaxLength = 8;
            this.RightBorderTextBox.Name = "RightBorderTextBox";
            this.RightBorderTextBox.Size = new System.Drawing.Size(117, 31);
            this.RightBorderTextBox.TabIndex = 7;
            this.RightBorderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataTextBox_KeyPress);
            // 
            // StepTextBox
            // 
            this.StepTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StepTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepTextBox.Location = new System.Drawing.Point(663, 429);
            this.StepTextBox.MaxLength = 8;
            this.StepTextBox.Name = "StepTextBox";
            this.StepTextBox.Size = new System.Drawing.Size(125, 31);
            this.StepTextBox.TabIndex = 8;
            this.StepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(401, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Нижняя граница";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(537, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Верхняя граница";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(660, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Шаг";
            // 
            // GraphView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StepTextBox);
            this.Controls.Add(this.RightBorderTextBox);
            this.Controls.Add(this.LeftBorderTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.CoordinatesGridView);
            this.Controls.Add(this.GraphVisulizerChart);
            this.Controls.Add(this.GraphModeComboBox);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphView";
            this.Text = "Табулирование функции с построением графика";
            this.Load += new System.EventHandler(this.GraphView_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphVisulizerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordinatesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ComboBox GraphModeComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphVisulizerChart;
        private System.Windows.Forms.DataGridView CoordinatesGridView;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem UploadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveCalcToolStripMenuItem;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox LeftBorderTextBox;
        private System.Windows.Forms.TextBox RightBorderTextBox;
        private System.Windows.Forms.TextBox StepTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnY;
        private ToolStripMenuItem AboutToolStripMenuItem;
    }
}

