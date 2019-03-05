using System;
using TaskDatas;

namespace Solvers
{
    class DifferModelSolver : AnalyticSolver, INumericalSolver
    {
        public DifferModelSolver(ITaskData task) : base(task)
        {
        }

        private double h = 0;
        private int _knots;

        public int Knots
        {
            get => _knots;
            set
            {
                _knots = value;
                h = 1.0 / (value-1);
            }
        }

        private double Al (int l)
        {
            if (l == 0)
            {
                return task.Mkx;
            } else if (l == Knots-1)
            {
                return 0;
            } else
            {
                return task.Mkx;
            }
        }

        private double Bl(int l)
        {
            if (l == 0)
            {
                return -task.Mkx - task.B1 * h;
            } else if (l == Knots-1)
            {
                return -task.Mkx - task.B2 * h;
            } else
            {
                return -2 * task.Mkx - task.Mqx * Math.Pow(h, 2);
            }
        }

        private double Cl(int l)
        {
            if (l == 0)
            {
                return 0;
            } else if (l == Knots-1)
            {
                return task.Mkx;
            } else
            {
                return task.Mkx;
            }
        }

        private double Dl(int l)
        {
            if (l == 0)
            {
                return -task.E1 * h;
            } else if (l == Knots-1) {
                return -task.E2 * h;
            } else
            {
                return -task.Mfx * Math.Pow(h, 2);
            }
        }

        private double Alpha(int l)
        {
            return l == 0 ? -(Al(0) / Bl(0)) : -(Al(l) / (Bl(l) + Cl(l) * Alpha(l - 1)));
        }

        private double Beta(int l)
        {
            return l == 0 ? Dl(0) / Bl(0) : (Dl(l) - Cl(l) * Beta(l - 1)) / (Bl(l) + Cl(l) * Alpha(l - 1));
        }

        public double[] GetSolution()
        {
            double[] values = new double[Knots];
            values[Knots-1] = (Dl(Knots-1) - (Cl(Knots-1) * Beta(Knots - 2))) / (Bl(Knots-1) + (Cl(Knots-1) * Alpha(Knots - 2)));
            for (int l = Knots-2; l>=0; l--)
            {
                values[l] = Alpha(l) * values[l + 1] + Beta(l);
            }
            return values;
        }

    }
    class VariableCoefsNumericalSolver : AnalyticSolver, INumericalSolver
    {
        public VariableCoefsNumericalSolver(ITaskData task) : base(task)
        {
        }

        private double h = 0;
        int _knots;

        public int Knots
        {
            get => _knots;
            set
            {
                _knots = value;
                h = 1.0 / (value-1);
            }
        }

        private double X(int l)
        {
            if (l == 0)
            {
                return 0;
            } else
            {
                return X(0) + l * h;
            }
        }

        private double K(int l, double add)
        {
            return task.EvaluteKx(X(l) + (h * add));
        }

        private double Q(int l)
        {
            return task.EvaluateQx(X(l));
        }

        private double F(int l)
        {
            return task.EvaluateFx(X(l));
        }

        private double Al(int l)
        {
            if (l == 0)
            {
                return K(0, 0.0);
            }
            else if (l == Knots-1)
            {
                return 0;
            }
            else
            {
                return K(l, 0.5);
            }
        }

        private double Bl(int l)
        {
            if (l == 0)
            {
                return -(K(0, 0.0) + task.B1 * h);
            }
            else if (l == Knots-1)
            {
                return -(K(Knots-1, 0.0) + task.B2 * h);
            }
            else
            {
                return -(K(l, 0.5) + K(l, -0.5) + Q(l) * Math.Pow(h, 2));
            }
        }

        private double Cl(int l)
        {
            if (l == 0)
            {
                return 0;
            }
            else if (l == Knots-1)
            {
                return K(Knots-1, 0.0);
            }
            else
            {
                return K(l, -0.5);
            }
        }

        private double Dl(int l)
        {
            if (l == 0)
            {
                return -(task.E1 * h);
            }
            else if (l == Knots-1)
            {
                return -(task.E2 * h);
            }
            else
            {
                return -(F(l) * Math.Pow(h, 2));
            }
        }

        private double Alpha(int l)
        {
            return l == 0 ? -(Al(0) / Bl(0)) : -(Al(l) / (Bl(l) + Cl(l) * Alpha(l - 1)));
        }

        private double Beta(int l)
        {
            return l == 0 ? Dl(0) / Bl(0) : (Dl(l) - Cl(l) * Beta(l - 1)) / (Bl(l) + Cl(l) * Alpha(l - 1));
        }

        public double[] GetSolution()
        {
            double[] values = new double[Knots];
            values[Knots - 1] = (Dl(Knots - 1) - (Cl(Knots - 1) * Beta(Knots - 2))) / (Bl(Knots - 1) + (Cl(Knots - 1) * Alpha(Knots - 2)));
            for (int l = Knots - 2; l >= 0; l--)
            {
                values[l] = Alpha(l) * values[l + 1] + Beta(l);
            }
            return values;
        }
    }
}
