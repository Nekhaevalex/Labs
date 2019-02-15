using System;

namespace Lab4
{
    class NumericalSolver : AnalyticSolver
    {
        public NumericalSolver(TaskData task) : base(task)
        {
        }

        private double[] GetXPoints(int knots)
        {
            double[] points = new double[knots];
            double[] array1 = new double[knots];
            double currentX = 0.0;
            double step = 1.0 / (knots - 1);
            for (int i = 0; i<knots; i++)
            {
                points[i] = currentX;
                

                currentX += step;
            }
            return null;
        }

    }
}
