using System;
using TaskDatas;

namespace Solvers
{
    class DifferModelSolver : AnalyticSolver, INumericalSolver
    {
        public DifferModelSolver(TaskData task) : base(task)
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
                h = 1.0 / (value);
            }
        }

        private double Al (int l)
        {
            if (l == 0)
            {
                return task.Mkx;
            } else if (l == Knots)
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
            } else if (l == Knots)
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
            } else if (l == Knots)
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
            } else if (l == Knots) {
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
            double[] values = new double[Knots+1];
            values[Knots] = (Dl(Knots) - (Cl(Knots) * Beta(Knots - 1))) / (Bl(Knots) + (Cl(Knots) * Alpha(Knots - 1)));
            for (int l = Knots-1; l>=0; l--)
            {
                values[l] = Alpha(l) * values[l + 1] + Beta(l);
            }
            return values;
        }

    }
    class VariableCoefsNumericalSolver : AnalyticSolver, INumericalSolver
    {
        public VariableCoefsNumericalSolver(TaskData task) : base(task)
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
                h = 1.0 / (value);
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
                return task.EvaluteKx(0);
            }
            else if (l == Knots)
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
                return -(task.EvaluteKx(0) + task.B1 * h);
            }
            else if (l == Knots)
            {
                return -(task.EvaluteKx(l) + task.B2 * h);
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
            } else if (l == Knots)
            {
                return K(Knots, 0.0);
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
            else if (l == Knots)
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
            int L = Knots;
            double[] values = new double[L + 1];
            values[L] = (Dl(L) - Cl(L) * Beta(L - 1)) / (Bl(L) + Cl(L) * Alpha(L - 1));
            for (int i = L - 1; i >= 0; i--)
            {
                values[i] = Alpha(i) * values[i + 1] + Beta(i);
            }
            return values;
        }
    }
}
