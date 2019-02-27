using System;

namespace Lab4
{
    class NumericalSolver : AnalyticSolver
    {
        public NumericalSolver(TaskData task) : base(task)
        {
        }

        private double[] GetSolution(int knots)
        {
            double[] points = new double[knots];
            double[] array1 = new double[knots];
            double currentX = 0.0;
            double step = 1.0 / (knots - 1);

            //Initialization block
            double a0 = task.EvaluteKx(0.0);
            double b0 = -(task.EvaluteKx(0.0) + (task.B1 * step));
            double c0 = 0;
            double d0 = -task.E1 * step;

            double alpha = -a0 / b0;
            double beta = d0 / b0;

            for (int i = 1; i<knots; i++)
            {
                points[i] = currentX;
                
                currentX += step;
            }
            return null;
        }

    }
}
