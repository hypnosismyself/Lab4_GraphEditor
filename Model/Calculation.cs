﻿using System;

namespace Lab4_GraphEditor.Model
{
    internal class Calculation
    {
        // Модель | Вычисление формулы

        // Поля
        public double CoordinateX { get; set; }
        public double CoordinateY 
        {
            get => Expression();
        }

        // Метод подсчета координаты Y
        private double Expression()
        {
            return 2 * Math.Sin(CoordinateX / 3);
        }
    }
}
