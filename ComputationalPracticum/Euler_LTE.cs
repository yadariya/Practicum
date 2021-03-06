﻿using System;

namespace ComputationalPracticum
{
    public class Euler_LTE : Grid
    {
        public Euler_LTE(int N, double x0, double X, double y0) : base(N, x0, X, y0)
        {
            y[0] = 0;
            double h = (X - x0) / N;
            for (int i = 1; i < N; i++)
            {
                if (i != N - 1)
                {
                    double y_exact_1 = Math.Sin(x[i + 1]) + Math.Cos(x[i + 1]);
                    double y_exact = Math.Sin(x[i]) + Math.Cos(x[i]);
                    double f = 1 / Math.Cos(x[i]) - y_exact * Math.Tan(x[i]);
                    y[i] = Math.Abs(y_exact_1 - y_exact - h * f);
                }
                else
                {
                    double y_exact_1 = Math.Sin(x[i] + h) + Math.Cos(x[i] + h);
                    double y_exact = Math.Sin(x[i]) + Math.Cos(x[i]);
                    double f = 1 / Math.Cos(x[i]) - y_exact * Math.Tan(x[i]);
                    y[i] = Math.Abs(y_exact_1 - y_exact - h * f);

                }
            }

        }

    }
}
