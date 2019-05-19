using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2019, Nekhav Alexander\nLab 6 Var 2 Task 4");
            Solution solution = new Solution(1281,81,81);
            solution.Calculate();
            Array analytic = solution.getAnalytic();
            Array numerical = solution.getNumerical();
            Array difference = solution.getDifference();
        }
    }
    class Solution
    {
        public int N;
        public int L;
        public int M;
        public int LK;
        public int MK;
        public double X0;
        public double XN;
        public double Y0;
        public double EPS;
        public double AK;
        public int lk1;
        public int MK1;
        public int LJ;
        public double H;
        public double T;
        public double DT;
        public double DTX;
        public double TK;
        public double RK;
        public double R0;
        public double QK;
        public double Q0;
        public double NN;
        public double HX;
        public double HY;
        public Array X;
        public Array UA;
        public Array UM;
        public Array UV;
        private int MyTaskNo = 4;

        public Solution(int n, int lK, int mK)
        {
            N = n;
            LK = lK;
            MK = mK;
        }

        public void Calculate()
        {
            this.MyTaskNo = 4;
            this.TK = 1.0;
            this.RK = 1.0;
            this.R0 = 0.0;
            this.lk1 = this.LK - 1;
            this.LJ = (int)Math.Round((double)this.lk1 / 10.0);
            this.DT = this.TK / (double)(this.N - 1);
            this.HX = (this.RK - this.R0) / (double)this.lk1;
            this.Q0 = 0.0;
            this.QK = 1.0;
            this.MK1 = this.MK - 1;
            this.HY = (this.QK - this.Q0) / (double)this.MK1;
            this.UA = Array.CreateInstance(typeof(double), 801, 801);
            this.UM = Array.CreateInstance(typeof(double), 801, 801);
            this.UV = Array.CreateInstance(typeof(double), 801, 801);
            this.CalculateVar();
            Console.WriteLine("Initial values:");
            Console.WriteLine("N = "+N+" L="+LK+" M="+MK);
            for (int i = 0; i < 100; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            Console.WriteLine("Analytic:");
            int lj1 = LJ;
            for (int i = 1; (lj1 >> 31^i) <= (lj1 >> 31^(MK)); i+=LJ)
            {
                int temp = LJ;
                for (int j = 1; (temp >> 31^j) <= (temp >> 31^(LK)); j+=LJ)
                {
                    Console.Write(UA.GetValue(i, j)+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Numerical:");
            for (int i = 1; (lj1 >> 31 ^ i) <= (lj1 >> 31 ^ (MK)); i += LJ)
            {
                int temp = LJ;
                for (int j = 1; (temp >> 31 ^ j) <= (temp >> 31 ^ (LK)); j += LJ)
                {
                    Console.Write(UM.GetValue(i, j) + " ");
                }
                Console.WriteLine();
            }
            Object maxDiff = UV.GetValue(1, 1);
            Console.WriteLine("Differ:");
            for (int i = 1; (lj1 >> 31 ^ i) <= (lj1 >> 31 ^ (MK)); i += LJ)
            {
                int temp = LJ;
                for (int j = 1; (temp >> 31 ^ j) <= (temp >> 31 ^ (LK)); j += LJ)
                {
                    Console.Write(UV.GetValue(i, j) + " ");
                }
                Console.WriteLine();
            }
        }

        public Array getAnalytic()
        {
            return this.UA;
        }

        public Array getNumerical()
        {
            return this.UM;
        }
        
        public Array getDifference()
        {
            return this.UV;
        }

        private void CalculateVar()
        {
            int lk1 = this.LK;
            for (this.L = 1; this.L <= lk1; ++this.L)
            {
                int mk = this.MK;
                for (this.M = 1; this.M <= mk; ++this.M)
                {
                    NewLateBinding.LateIndexSet((object)this.UA, new object[3]
                    {
            (object) this.L,
            (object) this.M,
            (object) this.FANv2(this.R0 + this.HX * (double) (this.L - 1), this.Q0 + this.HY * (double) (this.M - 1))
                    }, (string[])null);
                    NewLateBinding.LateIndexSet((object)this.UM, new object[3]
                    {
            (object) this.L,
            (object) this.M,
            (object) this.InitNv2(this.R0 + this.HX * (double) (this.L - 1), this.Q0 + this.HY * (double) (this.M - 1))
                    }, (string[])null);
                }
            }
            this.NumSolverV21();
            this.LJ = (int)Math.Round((double)this.lk1 / 5.0);
            int lk2 = this.LK;
            for (this.L = 1; this.L <= lk2; ++this.L)
            {
                int mk = this.MK;
                for (this.M = 1; this.M <= mk; ++this.M)
                    NewLateBinding.LateIndexSet((object)this.UV, new object[3]
                    {
            (object) this.L,
            (object) this.M,
            Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) this.M
            }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) this.M
            }, (string[]) null))
                    }, (string[])null);
            }
        }
        public double FANv2(double Xin, double Yin)
        {
            return Math.Pow(1.0 + Xin + Yin, 4.0 / 3.0) / Math.Pow(10.0 - 28.0 * this.TK / 3.0, 2.0 / 3.0);
        }
        public double InitNv2(double Xin, double Yin)
        {

            return Math.Pow(1.0 + Xin + Yin, 4.0 / 3.0) / Math.Pow(100.0, 1.0 / 3.0);
        }
        private void NumSolverV21()
        {
            Array instance1 = Array.CreateInstance(typeof(double), 801);
            Array instance2 = Array.CreateInstance(typeof(double), 801);
            Array instance3 = Array.CreateInstance(typeof(double), 801, 801);
            Array instance4 = Array.CreateInstance(typeof(double), 801);
            object instance5 = (object)Array.CreateInstance(typeof(double), 801, 801);
            this.UV = Array.CreateInstance(typeof(double), 801, 801);
            double num1 = this.HX / 2.0;
            double num2 = this.HY / 2.0;
            this.T = this.DT;
            while (true)
            {
                int num3 = 0;
                int mk1 = this.MK;
                for (this.M = 1; this.M <= mk1; ++this.M)
                {
                    int lk = this.LK;
                    for (this.L = 1; this.L <= lk; ++this.L)
                        NewLateBinding.LateIndexSet(instance5, new object[3]
                        {
              (object) this.L,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.UM, new object[2]
              {
                (object) this.L,
                (object) this.M
              }, (string[]) null))
                        }, (string[])null);
                }
                double num4 = this.DT / (this.HX * this.HX);
                double num5 = this.DT / (this.HY * this.HY);
                int num6;
                do
                {
                    ++num3;
                    num6 = 0;
                    double q0 = this.Q0;
                    int mk1_1 = this.MK1;
                    for (this.M = 2; this.M <= mk1_1; ++this.M)
                    {
                        q0 += this.HY;
                        int lk1 = this.LK;
                        for (this.L = 1; this.L <= lk1; ++this.L)
                            NewLateBinding.LateIndexSet((object)instance4, new object[2]
                            {
                (object) this.L,
                RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
                {
                  (object) this.L,
                  (object) this.M
                }, (string[]) null))
                            }, (string[])null);
                        NewLateBinding.LateIndexSet((object)instance1, new object[2]
                        {
              (object) 1,
              (object) 0.0
                        }, (string[])null);
                        NewLateBinding.LateIndexSet((object)instance2, new object[2]
                        {
              (object) 1,
              (object) this.G0Nv2(this.T, q0)
                        }, (string[])null);
                        NewLateBinding.LateIndexSet((object)instance4, new object[2]
                        {
              (object) 1,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance2, new object[1]
              {
                (object) 1
              }, (string[]) null))
                        }, (string[])null);
                        NewLateBinding.LateIndexSet((object)instance4, new object[2]
                        {
              (object) this.LK,
              (object) this.G1Nv2(this.T, q0)
                        }, (string[])null);
                        double num7 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)instance4, new object[1]
                        {
              (object) 1
                        }, (string[])null)));
                        double num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)instance4, new object[1]
                        {
              (object) 2
                        }, (string[])null)));
                        double num9 = num4 * (num8 + num7) * this.HNv2(this.R0 + num1) / 2.0;
                        int lk1_1 = this.lk1;
                        for (this.L = 2; this.L <= lk1_1; ++this.L)
                        {
                            double Xin1 = this.R0 + this.HX * (double)(this.L - 1);
                            double Xin2 = Xin1 + num1;
                            double num10 = num8;
                            num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)instance4, new object[1]
                            {
                (object) (this.L + 1)
                            }, (string[])null)));
                            double num11 = num9;
                            num9 = num4 * (num8 + num10) * this.HNv2(Xin2) / 2.0;
                            double num12 = Conversions.ToDouble(Operators.SubtractObject((object)(this.HNv2(Xin1) + num9 + num11), Operators.MultiplyObject((object)num11, NewLateBinding.LateIndexGet((object)instance1, new object[1]
                            {
                (object) (this.L - 1)
                            }, (string[])null))));
                            NewLateBinding.LateIndexSet((object)instance1, new object[2]
                            {
                (object) this.L,
                (object) (num9 / num12)
                            }, (string[])null);
                            NewLateBinding.LateIndexSet((object)instance2, new object[2]
                            {
                (object) this.L,
                Operators.DivideObject(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.UM, new object[2]
                {
                  (object) this.L,
                  (object) this.M
                }, (string[]) null), (object) this.HNv2(Xin1)), Operators.MultiplyObject((object) num11, NewLateBinding.LateIndexGet((object) instance2, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), (object) num12)
                            }, (string[])null);
                        }
                        NewLateBinding.LateIndexSet((object)instance3, new object[3]
                        {
              (object) 1,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance4, new object[1]
              {
                (object) 1
              }, (string[]) null))
                        }, (string[])null);
                        NewLateBinding.LateIndexSet((object)instance3, new object[3]
                        {
              (object) this.LK,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance4, new object[1]
              {
                (object) this.LK
              }, (string[]) null))
                        }, (string[])null);
                        int lk2 = this.LK;
                        int lk1_2 = this.lk1;
                        for (this.L = 2; this.L <= lk1_2; ++this.L)
                        {
                            --lk2;
                            NewLateBinding.LateIndexSet((object)instance3, new object[3]
                            {
                (object) lk2,
                (object) this.M,
                Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
                {
                  (object) lk2
                }, (string[]) null), NewLateBinding.LateIndexGet((object) instance3, new object[2]
                {
                  (object) (lk2 + 1),
                  (object) this.M
                }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance2, new object[1]
                {
                  (object) lk2
                }, (string[]) null))
                            }, (string[])null);
                        }
                    }
                    double r0 = this.R0;
                    int lk1_3 = this.lk1;
                    for (this.L = 2; this.L <= lk1_3; ++this.L)
                    {
                        r0 += this.HX;
                        int mk2 = this.MK;
                        for (this.M = 1; this.M <= mk2; ++this.M)
                            NewLateBinding.LateIndexSet((object)instance4, new object[2]
                            {
                (object) this.M,
                RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
                {
                  (object) this.L,
                  (object) this.M
                }, (string[]) null))
                            }, (string[])null);
                        NewLateBinding.LateIndexSet((object)instance1, new object[2]
                        {
              (object) 1,
              (object) 0.0
                        }, (string[])null);
                        NewLateBinding.LateIndexSet((object)instance2, new object[2]
                        {
              (object) 1,
              (object) this.D0Nv2(this.T, r0)
                        }, (string[])null);
                        NewLateBinding.LateIndexSet((object)instance4, new object[2]
                        {
              (object) 1,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance2, new object[1]
              {
                (object) 1
              }, (string[]) null))
                        }, (string[])null);
                        NewLateBinding.LateIndexSet((object)instance4, new object[2]
                        {
              (object) this.MK,
              (object) this.D1Nv2(this.T, r0)
                        }, (string[])null);
                        double num7 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)instance4, new object[1]
                        {
              (object) 1
                        }, (string[])null)));
                        double num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)instance4, new object[1]
                        {
              (object) 2
                        }, (string[])null)));
                        double num9 = num5 * (num8 + num7) * this.HNv2(this.Q0 + num2) / 2.0;
                        int mk1_2 = this.MK1;
                        for (this.M = 2; this.M <= mk1_2; ++this.M)
                        {
                            double Xin1 = this.Q0 + this.HY * (double)(this.M - 1);
                            double Xin2 = Xin1 + num2;
                            double num10 = num8;
                            num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object)instance4, new object[1]
                            {
                (object) (this.M + 1)
                            }, (string[])null)));
                            double num11 = num9;
                            num9 = num5 * (num8 + num10) * this.HNv2(Xin2) / 2.0;
                            double num12 = Conversions.ToDouble(Operators.SubtractObject((object)(this.HNv2(Xin1) + num9 + num11), Operators.MultiplyObject((object)num11, NewLateBinding.LateIndexGet((object)instance1, new object[1]
                            {
                (object) (this.M - 1)
                            }, (string[])null))));
                            NewLateBinding.LateIndexSet((object)instance1, new object[2]
                            {
                (object) this.M,
                (object) (num9 / num12)
                            }, (string[])null);
                            NewLateBinding.LateIndexSet((object)instance2, new object[2]
                            {
                (object) this.M,
                Operators.DivideObject(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance3, new object[2]
                {
                  (object) this.L,
                  (object) this.M
                }, (string[]) null), (object) this.HNv2(Xin1)), Operators.MultiplyObject((object) num11, NewLateBinding.LateIndexGet((object) instance2, new object[1]
                {
                  (object) (this.M - 1)
                }, (string[]) null))), (object) num12)
                            }, (string[])null);
                        }
                        NewLateBinding.LateIndexSet(instance5, new object[3]
                        {
              (object) this.L,
              (object) 1,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance4, new object[1]
              {
                (object) 1
              }, (string[]) null))
                        }, (string[])null);
                        NewLateBinding.LateIndexSet(instance5, new object[3]
                        {
              (object) this.L,
              (object) this.MK,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance4, new object[1]
              {
                (object) this.MK
              }, (string[]) null))
                        }, (string[])null);
                        int mk3 = this.MK;
                        int mk1_3 = this.MK1;
                        for (this.M = 2; this.M <= mk1_3; ++this.M)
                        {
                            --mk3;
                            double num10 = Conversions.ToDouble(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object)instance1, new object[1]
                            {
                (object) mk3
                            }, (string[])null), NewLateBinding.LateIndexGet(instance5, new object[2]
                            {
                (object) this.L,
                (object) (mk3 + 1)
                            }, (string[])null)), NewLateBinding.LateIndexGet((object)instance2, new object[1]
                            {
                (object) mk3
                            }, (string[])null)));
                            if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1]
                            {
                Operators.DivideObject(Operators.SubtractObject(NewLateBinding.LateIndexGet(instance5, new object[2]
                {
                  (object) this.L,
                  (object) mk3
                }, (string[]) null), (object) num10), (object) num10)
                            }, (string[])null, (Type[])null, (bool[])null), (object)0.0001, false))
                                num6 = 1;
                            NewLateBinding.LateIndexSet(instance5, new object[3]
                            {
                (object) this.L,
                (object) mk3,
                (object) num10
                            }, (string[])null);
                        }
                    }
                }
                while (num6 == 1 & num3 < 100);
                int mk1_4 = this.MK1;
                for (this.M = 2; this.M <= mk1_4; ++this.M)
                {
                    int lk1 = this.lk1;
                    for (this.L = 2; this.L <= lk1; ++this.L)
                        NewLateBinding.LateIndexSet((object)this.UM, new object[3]
                        {
              (object) this.L,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
              {
                (object) this.L,
                (object) this.M
              }, (string[]) null))
                        }, (string[])null);
                }
                int mk4 = this.MK;
                for (this.M = 1; this.M <= mk4; ++this.M)
                {
                    double Yin = this.Q0 + this.HY * (double)(this.M - 1);
                    NewLateBinding.LateIndexSet(instance5, new object[3]
                    {
            (object) 1,
            (object) this.M,
            (object) this.G0Nv2(this.T, Yin)
                    }, (string[])null);
                    NewLateBinding.LateIndexSet((object)this.UM, new object[3]
                    {
            (object) 1,
            (object) this.M,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
            {
              (object) 1,
              (object) this.M
            }, (string[]) null))
                    }, (string[])null);
                    NewLateBinding.LateIndexSet(instance5, new object[3]
                    {
            (object) this.LK,
            (object) this.M,
            (object) this.G1Nv2(this.T, Yin)
                    }, (string[])null);
                    NewLateBinding.LateIndexSet((object)this.UM, new object[3]
                    {
            (object) this.LK,
            (object) this.M,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
            {
              (object) this.LK,
              (object) this.M
            }, (string[]) null))
                    }, (string[])null);
                }
                int lk1_4 = this.lk1;
                for (this.L = 2; this.L <= lk1_4; ++this.L)
                {
                    double Xin = this.R0 + this.HX * (double)(this.L - 1);
                    NewLateBinding.LateIndexSet(instance5, new object[3]
                    {
            (object) this.L,
            (object) 1,
            (object) this.D0Nv2(this.T, Xin)
                    }, (string[])null);
                    NewLateBinding.LateIndexSet((object)this.UM, new object[3]
                    {
            (object) this.L,
            (object) 1,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
            {
              (object) this.L,
              (object) 1
            }, (string[]) null))
                    }, (string[])null);
                    NewLateBinding.LateIndexSet(instance5, new object[3]
                    {
            (object) this.L,
            (object) this.MK,
            (object) this.D1Nv2(this.T, Xin)
                    }, (string[])null);
                    NewLateBinding.LateIndexSet((object)this.UM, new object[3]
                    {
            (object) this.L,
            (object) this.MK,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
            {
              (object) this.L,
              (object) this.MK
            }, (string[]) null))
                    }, (string[])null);
                }
                if (this.T != this.TK)
                {
                    double num7 = this.T + this.DT;
                    if (num7 > this.TK)
                    {
                        this.DT = this.TK - this.T;
                        this.T = this.TK;
                    }
                    else
                        this.T = num7;
                }
                else
                    break;
            }
        }
        public double G0Nv1(double Xin)
        {
            return 1.0 / Math.Exp(2.0 / 3.0 * Math.Log(5.0 - 14.0 * Xin / 3.0));

        }

        public double G0Nv2(double Tin, double Yin)
        {
            return Math.Pow(1.0 + Yin, 4.0 / 3.0) / Math.Pow(10.0 - 28.0 * Tin / 3.0, 2.0 / 3.0);

        }

        public double G1Nv1(double Xin)
        {

            return Math.Exp(4.0 / 3.0 * Math.Log(2.0)) / Math.Exp(2.0 / 3.0 * Math.Log(5.0 - 14.0 * Xin / 3.0));
        }

        public double G1Nv2(double Tin, double Yin)
        {
            return Math.Pow(2.0 + Yin, 4.0 / 3.0) / Math.Pow(10.0 - 28.0 * Tin / 3.0, 2.0 / 3.0);
        }

        public double D0Nv2(double Tin, double Xin)
        {
            return Math.Pow(1.0 + Xin, 4.0 / 3.0) / Math.Pow(10.0 - 28.0 * Tin / 3.0, 2.0 / 3.0);
        }

        public double D1Nv2(double Tin, double Xin)
        {
            return Math.Pow(2.0 + Xin, 4.0 / 3.0) / Math.Pow(10.0 - 28.0 * Tin / 3.0, 2.0 / 3.0);
        }
        public double FNv2(double Xin)
        {
            return Math.Pow(Xin, 1.5);

        }
        public double HNv2(double Xin)
        {
            return 1.0;
        }

    }
}
