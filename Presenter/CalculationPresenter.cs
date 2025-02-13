using Lab4_GraphEditor.Model;
using System;
using System.Collections.Generic;

namespace Lab4_GraphEditor
{
    internal class CalculationPresenter
    {
        // Презентер | Презентер вычислений

        public Calculation Calculation { get => _calculation; set => _calculation = value; }
        private Calculation _calculation;

        public GraphView GraphView { get => _graphView; set => _graphView = value; }
        private GraphView _graphView;

        public CalculationPresenter(Calculation model, GraphView view)
        {
            Calculation = model;
            GraphView = view;
        }

        // Презентер подсчета ячеек
        public void GetCells(double start, double finish, double step)
        {
            try
            {
                List<double[]> cells = new List<double[]>();

                for (double i = start; i <= finish; i += step)
                {
                    double[] str = new double[2];

                    str[0] = i;
                    Calculation.CoordinateX = i;
                    str[1] = Calculation.CoordinateY;

                    cells.Add(str);
                }

                GraphView.UpdateTable(cells);
            }
            catch (Exception ex)
            {
                GraphView.ShowErrorMessageBox("Ошибка вычисления", ex.Message);
            }
            
            GraphView.UpdateChart();
        }
    }
}
