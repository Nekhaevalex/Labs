// Decompiled with JetBrains decompiler
// Type: Proverka.NumericLab3
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace Proverka
{
  public class NumericLab3
  {
    private int cF1;
    private int cF2;
    private int cF3;
    private int cF4;
    private int cF5;
    private int cF6;
    private int cF7;
    private int cF8;
    private int cF9;
    private int cF10;
    private int cF11;
    private int cF12;
    private int cF13;
    private int cF14;
    private int cF15;
    private int cF16;
    public Array X;
    public Array Z;
    public Array Y;
    public int N;
    public int L;
    public double X0;
    public double XN;
    public double Y0;
    public double EPS;

    public NumericLab3()
    {
      this.cF1 = 1;
      this.cF2 = 2;
      this.cF3 = 3;
      this.cF4 = 4;
      this.cF5 = 5;
      this.cF6 = 6;
      this.cF7 = 7;
      this.cF8 = 8;
      this.cF9 = 9;
      this.cF10 = 10;
      this.cF11 = 11;
      this.cF12 = 12;
      this.cF13 = 13;
      this.cF14 = 14;
      this.cF15 = 15;
      this.cF16 = 16;
      this.X = Array.CreateInstance(typeof (double), 12);
      this.Z = Array.CreateInstance(typeof (double), 12);
      this.Y = Array.CreateInstance(typeof (double), 12);
    }

    public void Calculate(int No)
    {
      int num1 = this.N + 1;
      double num2 = (this.XN - this.X0) / (double) this.N;
      double num3 = (this.XN - this.X0) / (double) this.N;
      this.L = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) this.X, new object[2]
        {
          (object) this.L,
          (object) (num3 * (double) (this.L - 1) * (double) this.N / 10.0 + this.X0)
        }, (string[]) null);
        ++this.L;
      }
      while (this.L <= 11);
      double num4 = 0.0;
      switch (No)
      {
        case 1:
          double num5 = (Math.Pow(this.Y0, 2.0) - Math.Pow(this.X0, 2.0)) * Math.Exp(-1.0 / this.X0);
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              (object) ((double) Math.Sign(this.Y0) * Math.Sqrt(Conversions.ToDouble(Operators.AddObject(Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2), (object) (num5 * Math.Exp(Conversions.ToDouble(Operators.DivideObject((object) 1, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))))))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.RUNKU4(this.cF1);
          break;
        case 2:
          double num6 = Math.Pow(this.X0, 2.0) * Math.Pow(this.Y0, 2.0) - 2.0 * (this.X0 + this.Y0);
          double y0_1 = this.Y0;
          this.L = 1;
          do
          {
            double num7;
            do
            {
              num7 = y0_1;
              y0_1 = Conversions.ToDouble(Operators.SubtractObject((object) num7, Operators.DivideObject(Operators.SubtractObject(Operators.SubtractObject(Operators.ExponentObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) num7), (object) 2), Operators.MultiplyObject((object) 2.0, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) num7))), (object) num6), Operators.MultiplyObject((object) 2.0, Operators.SubtractObject(Operators.MultiplyObject((object) num7, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)), (object) 1)))));
            }
            while (Math.Abs((y0_1 - num7) / y0_1) > 1E-06);
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              (object) y0_1
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.RUNKU3(this.cF2);
          break;
        case 3:
          double num8 = 3.0 * this.X0 * Math.Pow(this.Y0, 2.0) + Math.Pow(this.X0, 2.0) * this.Y0 + 3.0 * this.Y0 + Math.Pow(this.X0, 2.0);
          double y0_2 = this.Y0;
          this.L = 1;
          do
          {
            double x;
            do
            {
              x = y0_2;
              y0_2 = Conversions.ToDouble(Operators.SubtractObject((object) x, Operators.DivideObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Operators.MultiplyObject(Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) Math.Pow(x, 2.0)), Operators.MultiplyObject(Operators.AddObject(Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2), (object) 3.0), (object) x)), Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)), (object) num8), Operators.AddObject(Operators.AddObject(Operators.MultiplyObject((object) (6.0 * x), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)), (object) 3.0))));
            }
            while (Math.Abs((y0_2 - x) / y0_2) > 1E-06);
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              (object) y0_2
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.EJL2R(this.cF3);
          break;
        case 4:
          double num9 = Math.Pow(this.X0, 2.0) * Math.Pow(this.Y0, 2.0) - 2.0 * Math.Pow(this.X0, 3.0) * this.Y0 - Math.Pow(this.X0, 4.0);
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) ((double) Math.Sign(this.Y0) * Math.Sqrt(Conversions.ToDouble(Operators.AddObject(Operators.MultiplyObject((object) 2.0, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)), Operators.DivideObject((object) num9, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)))))))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.EJL2M(this.cF4);
          break;
        case 5:
          num4 = (2.0 * this.Y0 + this.X0 * this.X0 * (this.Y0 * this.Y0 * 2.0 * Math.Log(this.Y0) - this.Y0)) / (this.X0 * this.X0);
          double y0_3 = this.Y0;
          this.L = 1;
          do
          {
            double d;
            do
            {
              d = y0_3;
              y0_3 = Conversions.ToDouble(Operators.SubtractObject((object) d, Operators.DivideObject(Operators.SubtractObject(Operators.AddObject((object) (2.0 * d), Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) (d * d), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) (2.0 * Math.Log(d) - 1.0))), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), Operators.AddObject((object) 2.0, Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 4), (object) d), (object) Math.Log(d))))));
            }
            while (Math.Abs((y0_3 - d) / y0_3) > 1E-06);
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              (object) y0_3
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.EJL2R(this.cF5);
          break;
        case 6:
          double num10 = (3.0 / this.Y0 + 1.0) * Math.Exp(1.5 * this.X0 * this.X0);
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              (object) (3.0 / (num10 * Math.Exp(Conversions.ToDouble(Operators.MultiplyObject((object) -1.5, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)))) - 1.0))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.EJL2M(this.cF6);
          break;
        case 7:
          double num11 = (this.Y0 * this.Y0 + 5.0 * this.X0 * Math.Log(this.X0)) / this.X0;
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              (object) ((double) Math.Sign(this.Y0) * Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject(Operators.MultiplyObject((object) num11, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), Operators.MultiplyObject(Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) Math.Log(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))))))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.RUNKU3(this.cF7);
          break;
        case 8:
          double num12 = (2.0 * this.X0 - this.X0 * this.X0 * this.Y0) / this.Y0;
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              Operators.DivideObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), Operators.AddObject(Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2), (object) num12))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.RUNKU4(this.cF8);
          break;
        case 9:
          double num13 = (2.0 * this.X0 * this.X0 - this.Y0 * this.X0) / (this.Y0 - 1.0);
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              Operators.DivideObject(Operators.AddObject(Operators.MultiplyObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) num13), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) num13))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.RUNKU3(this.cF9);
          break;
        case 10:
          double num14 = (this.Y0 + this.X0 / 2.0) / Math.Sqrt(this.X0);
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject((object) (num14 * Math.Sqrt(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.DivideObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2.0))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.RUNKU4(this.cF10);
          break;
        case 11:
          double num15 = -(Math.Pow(this.X0, 3.0) + 2.0 * this.X0 + this.Y0 * Math.Pow(this.X0, 2.0)) / (this.X0 + this.Y0);
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              Operators.DivideObject(Operators.NegateObject(Operators.AddObject(Operators.AddObject(Operators.MultiplyObject((object) num15, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 3)), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.AddObject((object) num15, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.EJL2M(this.cF11);
          break;
        case 12:
          double num16 = this.X0 * (1.0 + this.X0 * this.Y0) / (2.0 + this.X0 * this.Y0);
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              Operators.DivideObject(Operators.SubtractObject((object) (2.0 * num16), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) num16)))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.EJL2R(this.cF12);
          break;
        case 13:
          double num17 = (this.X0 * this.X0 - this.Y0 + 0.5) * Math.Exp(this.Y0);
          double y0_4 = this.Y0;
          this.L = 1;
          do
          {
            double num7;
            do
            {
              num7 = y0_4;
              y0_4 = Conversions.ToDouble(Operators.SubtractObject((object) num7, Operators.DivideObject(Operators.SubtractObject(Operators.SubtractObject((object) (num7 + num17 * Math.Exp(-num7)), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), (object) 0.5), (object) (1.0 - num17 * Math.Exp(-num7)))));
            }
            while (Math.Abs((y0_4 - num7) / y0_4) > 1E-05);
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              (object) y0_4
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.RUNKU4(this.cF13);
          break;
        case 14:
          double num18 = (4.0 * this.X0 * this.X0 + this.Y0 * this.Y0) * Math.Exp(2.0 * this.X0);
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              (object) ((double) Math.Sign(this.Y0) * Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject((object) (num18 * Math.Exp(Conversions.ToDouble(Operators.MultiplyObject((object) -2, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject(Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.RUNKU3(this.cF14);
          break;
        case 15:
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              Operators.DivideObject((object) 4.0, Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.EJL2M(this.cF15);
          break;
        case 16:
          double num19 = (this.X0 * this.X0 - this.Y0) / (this.Y0 * (this.X0 - 1.0));
          this.L = 1;
          do
          {
            NewLateBinding.LateIndexSet((object) this.Z, new object[2]
            {
              (object) this.L,
              Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), Operators.AddObject((object) 1.0, Operators.MultiplyObject((object) num19, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0))))
            }, (string[]) null);
            ++this.L;
          }
          while (this.L <= 11);
          this.EJL2R(this.cF16);
          break;
      }
    }

    private void EJL2M(int Fidx)
    {
      Array instance = Array.CreateInstance(typeof (double), 12);
      int num1 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) instance, new object[2]
        {
          (object) num1,
          (object) this.Y0
        }, (string[]) null);
        ++num1;
      }
      while (num1 <= 11);
      double num2 = this.EPS / 3.0;
      int num3;
      do
      {
        double x0 = this.X0;
        double num4 = this.Y0;
        this.N = 2 * this.N;
        double num5 = (this.XN - this.X0) / (double) this.N;
        double num6 = num5 / 2.0;
        int num7 = (int) Math.Round((double) this.N / 10.0);
        int num8 = 0;
        num3 = 0;
        int num9 = 1;
        int n = this.N;
        for (int index = 1; index <= n; ++index)
        {
          ++num8;
          double X = x0;
          x0 += num5;
          double Y1 = num4;
          switch (Fidx)
          {
            case 4:
              double Y2 = Y1 + num6 * this.calcF4(X, Y1);
              num4 = Y1 + num5 * this.calcF4(X + num6, Y2);
              break;
            case 6:
              double Y3 = Y1 + num6 * this.calcF6(X, Y1);
              num4 = Y1 + num5 * this.calcF6(X + num6, Y3);
              break;
            case 11:
              double Y4 = Y1 + num6 * this.calcF11(X, Y1);
              num4 = Y1 + num5 * this.calcF11(X + num6, Y4);
              break;
            case 15:
              double Y5 = Y1 + num6 * this.calcF15(X, Y1);
              num4 = Y1 + num5 * this.calcF15(X + num6, Y5);
              break;
          }
          if (num8 == num7)
          {
            num8 = 0;
            ++num9;
            if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
            {
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) instance, new object[1]
              {
                (object) num9
              }, (string[]) null), (object) num4)
            }, (string[]) null, (Type[]) null, (bool[]) null), (object) num2, false))
              ++num3;
            NewLateBinding.LateIndexSet((object) instance, new object[2]
            {
              (object) num9,
              (object) num4
            }, (string[]) null);
          }
        }
      }
      while (num3 > 0 & this.N < 11);
      int num10 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) this.Y, new object[2]
        {
          (object) num10,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance, new object[1]
          {
            (object) num10
          }, (string[]) null))
        }, (string[]) null);
        ++num10;
      }
      while (num10 <= 11);
    }

    private void EJL2R(int Fidx)
    {
      Array instance = Array.CreateInstance(typeof (double), 12);
      int num1 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) instance, new object[2]
        {
          (object) num1,
          (object) this.Y0
        }, (string[]) null);
        ++num1;
      }
      while (num1 <= 11);
      double num2 = this.EPS / 3.0;
      int num3;
      do
      {
        double x0 = this.X0;
        double num4 = this.Y0;
        this.N = 2 * this.N;
        double num5 = (this.XN - this.X0) / (double) this.N;
        double num6 = num5 / 2.0;
        int num7 = (int) Math.Round((double) this.N / 10.0);
        int num8 = 0;
        num3 = 0;
        int num9 = 1;
        int n = this.N;
        for (int index = 1; index <= n; ++index)
        {
          ++num8;
          double X = x0;
          x0 += num5;
          double Y = num4;
          switch (Fidx)
          {
            case 3:
              double num10 = this.calcF3(X, Y);
              num4 = Y + num6 * (num10 + this.calcF3(x0, Y + num5 * num10));
              break;
            case 5:
              double num11 = this.calcF5(X, Y);
              num4 = Y + num6 * (num11 + this.calcF5(x0, Y + num5 * num11));
              break;
            case 12:
              double num12 = this.calcF12(X, Y);
              num4 = Y + num6 * (num12 + this.calcF12(x0, Y + num5 * num12));
              break;
            case 16:
              double num13 = this.calcF16(X, Y);
              num4 = Y + num6 * (num13 + this.calcF16(x0, Y + num5 * num13));
              break;
          }
          if (num8 == num7)
          {
            num8 = 0;
            ++num9;
            if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
            {
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) instance, new object[1]
              {
                (object) num9
              }, (string[]) null), (object) num4)
            }, (string[]) null, (Type[]) null, (bool[]) null), (object) num2, false))
              ++num3;
            NewLateBinding.LateIndexSet((object) instance, new object[2]
            {
              (object) num9,
              (object) num4
            }, (string[]) null);
          }
        }
      }
      while (num3 > 0 & this.N > 11);
      int num14 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) this.Y, new object[2]
        {
          (object) num14,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance, new object[1]
          {
            (object) num14
          }, (string[]) null))
        }, (string[]) null);
        ++num14;
      }
      while (num14 <= 11);
    }

    private void RUNKU3(int Fidx)
    {
      Array instance = Array.CreateInstance(typeof (double), 12);
      int num1 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) instance, new object[2]
        {
          (object) num1,
          (object) this.Y0
        }, (string[]) null);
        ++num1;
      }
      while (num1 <= 11);
      double num2 = this.EPS / 7.0;
      int num3;
      do
      {
        double x0 = this.X0;
        double num4 = this.Y0;
        this.N = 2 * this.N;
        double num5 = (this.XN - this.X0) / (double) this.N;
        double num6 = num5 / 2.0;
        double num7 = num5 / 6.0;
        int num8 = (int) Math.Round((double) this.N / 10.0);
        int num9 = 0;
        num3 = 0;
        int num10 = 1;
        int n = this.N;
        for (int index = 1; index <= n; ++index)
        {
          ++num9;
          double X1 = x0;
          x0 += num5;
          double X2 = X1 + num6;
          double Y = num4;
          double num11;
          double num12;
          double num13;
          switch (Fidx)
          {
            case 2:
              num11 = this.calcF2(X1, Y);
              num12 = this.calcF2(X2, Y + num11 * num6);
              num13 = this.calcF2(x0, Y + (2.0 * num12 - num11) * num5);
              break;
            case 7:
              num11 = this.calcF7(X1, Y);
              num12 = this.calcF7(X2, Y + num11 * num6);
              num13 = this.calcF7(x0, Y + (2.0 * num12 - num11) * num5);
              break;
            case 9:
              num11 = this.calcF9(X1, Y);
              num12 = this.calcF9(X2, Y + num11 * num6);
              num13 = this.calcF9(x0, Y + (2.0 * num12 - num11) * num5);
              break;
            case 14:
              num11 = this.calcF14(X1, Y);
              num12 = this.calcF14(X2, Y + num11 * num6);
              num13 = this.calcF14(x0, Y + (2.0 * num12 - num11) * num5);
              break;
          }
          num4 = Y + num7 * (num11 + 4.0 * num12 + num13);
          if (num9 == num8)
          {
            num9 = 0;
            ++num10;
            if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
            {
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) instance, new object[1]
              {
                (object) num10
              }, (string[]) null), (object) num4)
            }, (string[]) null, (Type[]) null, (bool[]) null), (object) num2, false))
              ++num3;
            NewLateBinding.LateIndexSet((object) instance, new object[2]
            {
              (object) num10,
              (object) num4
            }, (string[]) null);
          }
        }
      }
      while (num3 > 0 & this.N < 11);
      int num14 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) this.Y, new object[2]
        {
          (object) num14,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance, new object[1]
          {
            (object) num14
          }, (string[]) null))
        }, (string[]) null);
        ++num14;
      }
      while (num14 <= 11);
    }

    private void RUNKU4(int Fidx)
    {
      Array instance = Array.CreateInstance(typeof (double), 12);
      int num1 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) instance, new object[2]
        {
          (object) num1,
          (object) this.Y0
        }, (string[]) null);
        ++num1;
      }
      while (num1 <= 11);
      double num2 = this.EPS / 15.0;
      int num3;
      do
      {
        double x0 = this.X0;
        double num4 = this.Y0;
        this.N = 2 * this.N;
        double num5 = (this.XN - this.X0) / (double) this.N;
        double num6 = num5 / 2.0;
        double num7 = num5 / 6.0;
        int num8 = (int) Math.Round((double) this.N / 10.0);
        int num9 = 0;
        num3 = 0;
        int num10 = 1;
        int n = this.N;
        for (int index = 1; index <= n; ++index)
        {
          ++num9;
          double X1 = x0;
          double X2 = X1 + num6;
          x0 += num5;
          double Y = num4;
          double num11;
          double num12;
          double num13;
          double num14;
          switch (Fidx)
          {
            case 1:
              num11 = this.calcF1(X1, Y);
              num12 = this.calcF1(X2, Y + num11 * num6);
              num13 = this.calcF1(X2, Y + num12 * num6);
              num14 = this.calcF1(x0, Y + num13 * num5);
              break;
            case 8:
              num11 = this.calcF8(X1, Y);
              num12 = this.calcF8(X2, Y + num11 * num6);
              num13 = this.calcF8(X2, Y + num12 * num6);
              num14 = this.calcF8(x0, Y + num13 * num5);
              break;
            case 10:
              num11 = this.calcF10(X1, Y);
              num12 = this.calcF10(X2, Y + num11 * num6);
              num13 = this.calcF10(X2, Y + num12 * num6);
              num14 = this.calcF10(x0, Y + num13 * num5);
              break;
            case 13:
              num11 = this.calcF13(X1, Y);
              num12 = this.calcF13(X2, Y + num11 * num6);
              num13 = this.calcF13(X2, Y + num12 * num6);
              num14 = this.calcF13(x0, Y + num13 * num5);
              break;
          }
          num4 = Y + num7 * (num11 + 2.0 * (num12 + num13) + num14);
          if (num9 == num8)
          {
            num9 = 0;
            ++num10;
            if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
            {
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) instance, new object[1]
              {
                (object) num10
              }, (string[]) null), (object) num4)
            }, (string[]) null, (Type[]) null, (bool[]) null), (object) num2, false))
              ++num3;
            NewLateBinding.LateIndexSet((object) instance, new object[2]
            {
              (object) num10,
              (object) num4
            }, (string[]) null);
          }
        }
      }
      while (num3 > 0 & this.N < 11);
      int num15 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) this.Y, new object[2]
        {
          (object) num15,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance, new object[1]
          {
            (object) num15
          }, (string[]) null))
        }, (string[]) null);
        ++num15;
      }
      while (num15 <= 11);
    }

    public double calcF1(double X, double Y)
    {
      return (2.0 * X * X * X + X * X - Y * Y) / (2.0 * X * X * Y);
    }

    public double calcF2(double X, double Y)
    {
      return (1.0 - X * Y * Y) / (X * X * Y - 1.0);
    }

    public double calcF3(double X, double Y)
    {
      return -(3.0 * Y * Y + 2.0 * X * Y + 2.0 * X) / (6.0 * X * Y + X * X + 3.0);
    }

    public double calcF4(double X, double Y)
    {
      return (2.0 * X * X + 3.0 * X * Y - Y * Y) / (X * Y - X * X);
    }

    public double calcF5(double X, double Y)
    {
      return 2.0 * Y / (X * (2.0 * X * X * Y * Math.Log(Y) + 1.0));
    }

    public double calcF6(double X, double Y)
    {
      return X * Y * Y + 3.0 * X * Y;
    }

    public double calcF7(double X, double Y)
    {
      return (Y * Y - 5.0 * X) / (2.0 * X * Y);
    }

    public double calcF8(double X, double Y)
    {
      return Y / X - Y * Y;
    }

    public double calcF9(double X, double Y)
    {
      return (Y * (4.0 * X + 1.0) - Y * Y - 4.0 * X) / (X * (2.0 * X - 1.0));
    }

    public double calcF10(double X, double Y)
    {
      return (2.0 * Y * Y + 3.0 * X * Y - 2.0 * X) / (2.0 * X * X);
    }

    public double calcF11(double X, double Y)
    {
      return (X * X * X + X * Y * Y + Y * (2.0 * X * X + 1.0)) / X;
    }

    public double calcF12(double X, double Y)
    {
      return -(2.0 + 4.0 * X * Y + X * X * Y * Y) / (X * X);
    }

    public double calcF13(double X, double Y)
    {
      return X / (Y - X * X);
    }

    public double calcF14(double X, double Y)
    {
      return -(Y * Y + 4.0 * X * (X + 1.0)) / Y;
    }

    public double calcF15(double X, double Y)
    {
      return (Math.Pow(X, 4.0) * Y * Y - X * X * Y - 20.0) / (X * X * X);
    }

    public double calcF16(double X, double Y)
    {
      return (Y * Y + X * (X - 2.0) * Y) / (X * X * (X - 1.0));
    }
  }
}
