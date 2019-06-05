// Decompiled with JetBrains decompiler
// Type: Proverka.NumericLab2
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace Proverka
{
  public class NumericLab2
  {
    public double S;
    public double XI;
    public double XI1;
    public double H;
    public double FI;
    public double FI1;
    public double F1I;
    public double F1I1;
    public double DFI;
    public double DH3;
    public double F1;
    public double XX;
    public Array PN;
    public Array PN1;
    public Array C;
    public Array C1;
    public Array X;
    public Array A;
    public Array F;
    public Array B;
    public int NK;

    public NumericLab2()
    {
      this.PN = Array.CreateInstance(typeof (double), 8);
      this.PN1 = Array.CreateInstance(typeof (double), 8);
      this.C = Array.CreateInstance(typeof (double), 8);
      this.C1 = Array.CreateInstance(typeof (double), 8);
      this.X = Array.CreateInstance(typeof (double), 8);
      this.A = Array.CreateInstance(typeof (double), 8);
      this.F = Array.CreateInstance(typeof (double), 8, 8);
      this.B = Array.CreateInstance(typeof (double), 5, 7);
    }

    public void BuildInterpolation()
    {
      int num1 = this.NK - 1;
      for (int index1 = 1; index1 <= num1; ++index1)
      {
        int num2 = this.NK - index1;
        for (int index2 = 1; index2 <= num2; ++index2)
          NewLateBinding.LateIndexSet((object) this.F, new object[3]
          {
            (object) (index1 + 1),
            (object) index2,
            Operators.DivideObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.F, new object[2]
            {
              (object) index1,
              (object) (index2 + 1)
            }, (string[]) null), NewLateBinding.LateIndexGet((object) this.F, new object[2]
            {
              (object) index1,
              (object) index2
            }, (string[]) null)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
            {
              (object) (index2 + index1)
            }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
            {
              (object) index2
            }, (string[]) null)))
          }, (string[]) null);
      }
      int nk1 = this.NK;
      for (int index = 1; index <= nk1; ++index)
        NewLateBinding.LateIndexSet((object) this.A, new object[2]
        {
          (object) index,
          (object) 0.0
        }, (string[]) null);
      int num3 = this.NK - 1;
      for (int index1 = 1; index1 <= num3; ++index1)
      {
        if (index1 >= 6)
        {
          this.S = 0.0;
          for (int index2 = 1; index2 <= index1 - 5; ++index2)
          {
            for (int index3 = index2 + 1; index3 <= index1 - 4; ++index3)
            {
              for (int index4 = index3 + 1; index4 <= index1 - 3; ++index4)
              {
                for (int index5 = index4 + 1; index5 <= index1 - 2; ++index5)
                {
                  for (int index6 = index5 + 1; index6 <= index1 - 1; ++index6)
                  {
                    for (int index7 = index6 + 1; index7 <= index1; ++index7)
                      this.S = Conversions.ToDouble(Operators.AddObject((object) this.S, Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                      {
                        (object) index2
                      }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                      {
                        (object) index3
                      }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                      {
                        (object) index4
                      }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                      {
                        (object) index5
                      }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                      {
                        (object) index6
                      }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                      {
                        (object) index7
                      }, (string[]) null))));
                  }
                }
              }
            }
          }
          NewLateBinding.LateIndexSet((object) this.A, new object[2]
          {
            (object) (index1 - 5),
            Operators.AddObject(NewLateBinding.LateIndexGet((object) this.A, new object[1]
            {
              (object) (index1 - 5)
            }, (string[]) null), Operators.MultiplyObject((object) this.S, NewLateBinding.LateIndexGet((object) this.F, new object[2]
            {
              (object) (index1 + 1),
              (object) 1
            }, (string[]) null)))
          }, (string[]) null);
          int num2 = 1 + 1 + 1 + 1 + 1;
        }
        if (index1 >= 5)
        {
          this.S = 0.0;
          for (int index2 = 1; index2 <= index1 - 4; ++index2)
          {
            for (int index3 = index2 + 1; index3 <= index1 - 3; ++index3)
            {
              for (int index4 = index3 + 1; index4 <= index1 - 2; ++index4)
              {
                for (int index5 = index4 + 1; index5 <= index1 - 1; ++index5)
                {
                  for (int index6 = index5 + 1; index6 <= index1; ++index6)
                    this.S = Conversions.ToDouble(Operators.AddObject((object) this.S, Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                    {
                      (object) index2
                    }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                    {
                      (object) index3
                    }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                    {
                      (object) index4
                    }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                    {
                      (object) index5
                    }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                    {
                      (object) index6
                    }, (string[]) null))));
                }
              }
            }
          }
          NewLateBinding.LateIndexSet((object) this.A, new object[2]
          {
            (object) (index1 - 4),
            Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.A, new object[1]
            {
              (object) (index1 - 4)
            }, (string[]) null), Operators.MultiplyObject((object) this.S, NewLateBinding.LateIndexGet((object) this.F, new object[2]
            {
              (object) (index1 + 1),
              (object) 1
            }, (string[]) null)))
          }, (string[]) null);
        }
        if (index1 >= 4)
        {
          this.S = 0.0;
          for (int index2 = 1; index2 <= index1 - 3; ++index2)
          {
            for (int index3 = index2 + 1; index3 <= index1 - 2; ++index3)
            {
              for (int index4 = index3 + 1; index4 <= index1 - 1; ++index4)
              {
                for (int index5 = index4 + 1; index5 <= index1; ++index5)
                  this.S = Conversions.ToDouble(Operators.AddObject((object) this.S, Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                  {
                    (object) index2
                  }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                  {
                    (object) index3
                  }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                  {
                    (object) index4
                  }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                  {
                    (object) index5
                  }, (string[]) null))));
              }
            }
          }
          NewLateBinding.LateIndexSet((object) this.A, new object[2]
          {
            (object) (index1 - 3),
            Operators.AddObject(NewLateBinding.LateIndexGet((object) this.A, new object[1]
            {
              (object) (index1 - 3)
            }, (string[]) null), Operators.MultiplyObject((object) this.S, NewLateBinding.LateIndexGet((object) this.F, new object[2]
            {
              (object) (index1 + 1),
              (object) 1
            }, (string[]) null)))
          }, (string[]) null);
        }
        if (index1 >= 3)
        {
          this.S = 0.0;
          for (int index2 = 1; index2 <= index1 - 2; ++index2)
          {
            for (int index3 = index2 + 1; index3 <= index1 - 1; ++index3)
            {
              for (int index4 = index3 + 1; index4 <= index1; ++index4)
                this.S = Conversions.ToDouble(Operators.AddObject((object) this.S, Operators.MultiplyObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) index2
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) index3
                }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) index4
                }, (string[]) null))));
            }
          }
          NewLateBinding.LateIndexSet((object) this.A, new object[2]
          {
            (object) (index1 - 2),
            Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.A, new object[1]
            {
              (object) (index1 - 2)
            }, (string[]) null), Operators.MultiplyObject((object) this.S, NewLateBinding.LateIndexGet((object) this.F, new object[2]
            {
              (object) (index1 + 1),
              (object) 1
            }, (string[]) null)))
          }, (string[]) null);
        }
        if (index1 >= 2)
        {
          this.S = 0.0;
          for (int index2 = 1; index2 <= index1 - 1; ++index2)
          {
            for (int index3 = index2 + 1; index3 <= index1; ++index3)
              this.S = Conversions.ToDouble(Operators.AddObject((object) this.S, Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) index2
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) index3
              }, (string[]) null))));
          }
          NewLateBinding.LateIndexSet((object) this.A, new object[2]
          {
            (object) (index1 - 1),
            Operators.AddObject(NewLateBinding.LateIndexGet((object) this.A, new object[1]
            {
              (object) (index1 - 1)
            }, (string[]) null), Operators.MultiplyObject((object) this.S, NewLateBinding.LateIndexGet((object) this.F, new object[2]
            {
              (object) (index1 + 1),
              (object) 1
            }, (string[]) null)))
          }, (string[]) null);
        }
        if (index1 >= 1)
        {
          this.S = 0.0;
          for (int index2 = 1; index2 <= index1; ++index2)
            this.S = Conversions.ToDouble(Operators.AddObject((object) this.S, NewLateBinding.LateIndexGet((object) this.X, new object[1]
            {
              (object) index2
            }, (string[]) null)));
          NewLateBinding.LateIndexSet((object) this.A, new object[2]
          {
            (object) index1,
            Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.A, new object[1]
            {
              (object) index1
            }, (string[]) null), Operators.MultiplyObject((object) this.S, NewLateBinding.LateIndexGet((object) this.F, new object[2]
            {
              (object) (index1 + 1),
              (object) 1
            }, (string[]) null)))
          }, (string[]) null);
        }
      }
      int nk2 = this.NK;
      for (int index = 1; index <= nk2; ++index)
        NewLateBinding.LateIndexSet((object) this.A, new object[2]
        {
          (object) index,
          Operators.AddObject(NewLateBinding.LateIndexGet((object) this.A, new object[1]
          {
            (object) index
          }, (string[]) null), NewLateBinding.LateIndexGet((object) this.F, new object[2]
          {
            (object) index,
            (object) 1
          }, (string[]) null))
        }, (string[]) null);
      int num4 = this.NK - 1;
      for (int index = 1; index <= num4; ++index)
      {
        this.XI = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
        {
          (object) index
        }, (string[]) null));
        this.XI1 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null));
        this.H = this.XI1 - this.XI;
        this.FI = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.F, new object[2]
        {
          (object) 1,
          (object) index
        }, (string[]) null));
        this.FI1 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.F, new object[2]
        {
          (object) 1,
          (object) (index + 1)
        }, (string[]) null));
        this.F1I = this.myF1((object) this.XI);
        this.F1I1 = this.myF1((object) this.XI1);
        this.DFI = this.FI1 - this.FI;
        this.DH3 = Math.Pow(this.H, 3.0);
        NewLateBinding.LateIndexSet((object) this.B, new object[3]
        {
          (object) 1,
          (object) index,
          (object) ((this.F1I1 * this.H - 2.0 * this.DFI + this.F1I * this.H) / this.DH3)
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) this.B, new object[3]
        {
          (object) 2,
          (object) index,
          (object) ((-this.F1I1 * this.H * (this.XI1 + 2.0 * this.XI) + 3.0 * this.DFI * (this.XI1 + this.XI) - this.F1I * this.H * (this.XI + 2.0 * this.XI1)) / this.DH3)
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) this.B, new object[3]
        {
          (object) 3,
          (object) index,
          (object) ((this.F1I1 * this.XI * (this.XI + 2.0 * this.XI1) * this.H - 6.0 * this.DFI * this.XI * this.XI1 + this.F1I * this.XI1 * (this.XI1 + 2.0 * this.XI) * this.H) / this.DH3)
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) this.B, new object[3]
        {
          (object) 4,
          (object) index,
          (object) ((-this.F1I1 * this.XI * this.XI * this.XI1 * this.H + this.FI1 * this.XI * this.XI * (3.0 * this.XI1 - this.XI) + this.FI * this.XI1 * this.XI1 * (this.XI1 - 3.0 * this.XI) - this.F1I * this.XI * this.XI1 * this.XI1 * this.H) / this.DH3)
        }, (string[]) null);
      }
    }

    public void CalculateY(
      double XX,
      ref double Sval,
      ref int Snum,
      ref double Fval,
      ref bool bres)
    {
      int num1 = 0;
      int num2 = this.NK - 1;
      for (int index = 1; index <= num2; ++index)
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLessEqual(NewLateBinding.LateIndexGet((object) this.X, new object[1]
        {
          (object) index
        }, (string[]) null), (object) XX, false), Operators.CompareObjectLessEqual((object) XX, NewLateBinding.LateIndexGet((object) this.X, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null), false))))
          num1 = index;
      }
      if (num1 > 0)
      {
        NewLateBinding.LateIndexSet((object) this.PN, new object[2]
        {
          (object) 4,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.B, new object[2]
          {
            (object) 4,
            (object) num1
          }, (string[]) null))
        }, (string[]) null);
        int num3 = 1;
        do
        {
          NewLateBinding.LateIndexSet((object) this.PN, new object[2]
          {
            (object) num3,
            Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.B, new object[2]
            {
              (object) num3,
              (object) num1
            }, (string[]) null), (object) Math.Pow(XX, (double) (4 - num3)))
          }, (string[]) null);
          ++num3;
        }
        while (num3 <= 3);
        int num4 = 1;
        do
        {
          double num5 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
          {
            (object) num4
          }, (string[]) null));
          int num6 = 1;
          do
          {
            if (Operators.ConditionalCompareObjectGreater((object) num5, NewLateBinding.LateIndexGet((object) this.PN, new object[1]
            {
              (object) num6
            }, (string[]) null), false))
            {
              num5 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
              {
                (object) num6
              }, (string[]) null));
              double num7 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
              {
                (object) num6
              }, (string[]) null));
              NewLateBinding.LateIndexSet((object) this.PN, new object[2]
              {
                (object) num6,
                RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
                {
                  (object) num4
                }, (string[]) null))
              }, (string[]) null);
              NewLateBinding.LateIndexSet((object) this.PN, new object[2]
              {
                (object) num4,
                (object) num7
              }, (string[]) null);
            }
            ++num6;
          }
          while (num6 <= 4);
          ++num4;
        }
        while (num4 <= 4);
        int num8 = 5;
        int num9 = 1;
        do
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
          {
            (object) num9
          }, (string[]) null), (object) 0.0, false), (object) (num8 == 5))))
            num8 = num9;
          ++num9;
        }
        while (num9 <= 4);
        double num10 = 0.0;
        for (int index = num8 - 1; index >= 1; index += -1)
          num10 = Conversions.ToDouble(Operators.AddObject((object) num10, NewLateBinding.LateIndexGet((object) this.PN, new object[1]
          {
            (object) index
          }, (string[]) null)));
        double num11 = 0.0;
        for (int index = num8; index <= 4; ++index)
          num11 = Conversions.ToDouble(Operators.AddObject((object) num11, NewLateBinding.LateIndexGet((object) this.PN, new object[1]
          {
            (object) index
          }, (string[]) null)));
        double num12 = num11 + num10;
        Sval = num12;
        Snum = num1;
        double num13 = 0.0;
        int nk = this.NK;
        for (int index = 1; index <= nk; ++index)
          num13 = Conversions.ToDouble(Operators.AddObject((object) num13, Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.A, new object[1]
          {
            (object) index
          }, (string[]) null), (object) Math.Pow(XX, (double) (index - 1)))));
        Fval = num13;
        bres = true;
      }
      else
        bres = false;
    }

    public double GetValBySpline(double XX)
    {
      int num1 = 0;
      int num2 = this.NK - 1;
      for (int index = 1; index <= num2; ++index)
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLessEqual(NewLateBinding.LateIndexGet((object) this.X, new object[1]
        {
          (object) index
        }, (string[]) null), (object) XX, false), Operators.CompareObjectLessEqual((object) XX, NewLateBinding.LateIndexGet((object) this.X, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null), false))))
          num1 = index;
      }
      double num3;
      if (num1 > 0)
      {
        NewLateBinding.LateIndexSet((object) this.PN, new object[2]
        {
          (object) 4,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.B, new object[2]
          {
            (object) 4,
            (object) num1
          }, (string[]) null))
        }, (string[]) null);
        int num4 = 1;
        do
        {
          NewLateBinding.LateIndexSet((object) this.PN, new object[2]
          {
            (object) num4,
            Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.B, new object[2]
            {
              (object) num4,
              (object) num1
            }, (string[]) null), (object) Math.Pow(XX, (double) (4 - num4)))
          }, (string[]) null);
          ++num4;
        }
        while (num4 <= 3);
        int num5 = 1;
        do
        {
          double num6 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
          {
            (object) num5
          }, (string[]) null));
          int num7 = 1;
          do
          {
            if (Operators.ConditionalCompareObjectGreater((object) num6, NewLateBinding.LateIndexGet((object) this.PN, new object[1]
            {
              (object) num7
            }, (string[]) null), false))
            {
              num6 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
              {
                (object) num7
              }, (string[]) null));
              double num8 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
              {
                (object) num7
              }, (string[]) null));
              NewLateBinding.LateIndexSet((object) this.PN, new object[2]
              {
                (object) num7,
                RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
                {
                  (object) num5
                }, (string[]) null))
              }, (string[]) null);
              NewLateBinding.LateIndexSet((object) this.PN, new object[2]
              {
                (object) num5,
                (object) num8
              }, (string[]) null);
            }
            ++num7;
          }
          while (num7 <= 4);
          ++num5;
        }
        while (num5 <= 4);
        int num9 = 5;
        int num10 = 1;
        do
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
          {
            (object) num10
          }, (string[]) null), (object) 0.0, false), (object) (num9 == 5))))
            num9 = num10;
          ++num10;
        }
        while (num10 <= 4);
        double num11 = 0.0;
        for (int index = num9 - 1; index >= 1; index += -1)
          num11 = Conversions.ToDouble(Operators.AddObject((object) num11, NewLateBinding.LateIndexGet((object) this.PN, new object[1]
          {
            (object) index
          }, (string[]) null)));
        double num12 = 0.0;
        for (int index = num9; index <= 4; ++index)
          num12 = Conversions.ToDouble(Operators.AddObject((object) num12, NewLateBinding.LateIndexGet((object) this.PN, new object[1]
          {
            (object) index
          }, (string[]) null)));
        num3 = num12 + num11;
      }
      else
        num3 = 0.0;
      return num3;
    }

    public double myF1(object X)
    {
      NewLateBinding.LateIndexSet((object) this.PN, new object[2]
      {
        (object) 1,
        RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.A, new object[1]
        {
          (object) 2
        }, (string[]) null))
      }, (string[]) null);
      int num1 = this.NK - 1;
      for (int index = 2; index <= num1; ++index)
        NewLateBinding.LateIndexSet((object) this.PN, new object[2]
        {
          (object) index,
          Operators.MultiplyObject(Operators.MultiplyObject((object) index, NewLateBinding.LateIndexGet((object) this.A, new object[1]
          {
            (object) (index + 1)
          }, (string[]) null)), Operators.ExponentObject(X, (object) (index - 1)))
        }, (string[]) null);
      int num2 = this.NK - 1;
      for (int index1 = 1; index1 <= num2; ++index1)
      {
        double num3 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
        {
          (object) index1
        }, (string[]) null));
        int num4 = index1;
        int num5 = this.NK - 1;
        for (int index2 = num4; index2 <= num5; ++index2)
        {
          if (Operators.ConditionalCompareObjectGreater((object) num3, NewLateBinding.LateIndexGet((object) this.PN, new object[1]
          {
            (object) index2
          }, (string[]) null), false))
          {
            num3 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
            {
              (object) index2
            }, (string[]) null));
            double num6 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
            {
              (object) index2
            }, (string[]) null));
            NewLateBinding.LateIndexSet((object) this.PN, new object[2]
            {
              (object) index2,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
              {
                (object) index1
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.PN, new object[2]
            {
              (object) index1,
              (object) num6
            }, (string[]) null);
          }
        }
      }
      int num7 = this.NK;
      int num8 = this.NK - 1;
      for (int index = 1; index <= num8; ++index)
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(NewLateBinding.LateIndexGet((object) this.PN, new object[1]
        {
          (object) index
        }, (string[]) null), (object) 0.0, false), (object) (num7 == this.NK))))
          num7 = index;
      }
      double num9 = 0.0;
      for (int index = num7 - 1; index >= 1; index += -1)
        num9 = Conversions.ToDouble(Operators.AddObject((object) num9, NewLateBinding.LateIndexGet((object) this.PN, new object[1]
        {
          (object) index
        }, (string[]) null)));
      double num10 = 0.0;
      int num11 = num7;
      int num12 = this.NK - 1;
      for (int index = num11; index <= num12; ++index)
        num10 = Conversions.ToDouble(Operators.AddObject((object) num10, NewLateBinding.LateIndexGet((object) this.PN, new object[1]
        {
          (object) index
        }, (string[]) null)));
      return num10 + num9;
    }
  }
}
