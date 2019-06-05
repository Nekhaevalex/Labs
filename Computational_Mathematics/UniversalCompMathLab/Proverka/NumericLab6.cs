// Decompiled with JetBrains decompiler
// Type: Proverka.NumericLab6
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace Proverka
{
  public class NumericLab6
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
    public int LK1;
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
    private int MyTaskNo;

    public void Calculate(int varNo, int taskNo)
    {
      this.MyTaskNo = taskNo;
      this.TK = 1.0;
      this.RK = 1.0;
      this.R0 = 0.0;
      this.LK1 = this.LK - 1;
      this.LJ = (int) Math.Round((double) this.LK1 / 10.0);
      this.DT = this.TK / (double) (this.N - 1);
      this.HX = (this.RK - this.R0) / (double) this.LK1;
      switch (varNo)
      {
        case 1:
          this.X = Array.CreateInstance(typeof (double), 100001);
          int lk = this.LK;
          for (this.L = 1; this.L <= lk; ++this.L)
            NewLateBinding.LateIndexSet((object) this.X, new object[2]
            {
              (object) this.L,
              (object) ((double) (this.L - 1) * this.HX)
            }, (string[]) null);
          this.UA = Array.CreateInstance(typeof (double), 100001);
          this.UM = Array.CreateInstance(typeof (double), 100001);
          this.UV = Array.CreateInstance(typeof (double), 100001);
          this.CalculateVar1();
          break;
        case 2:
          this.Q0 = 0.0;
          switch (this.MyTaskNo)
          {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
              this.QK = 1.0;
              break;
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
              this.QK = Math.PI / 2.0;
              break;
          }
          this.MK1 = this.MK - 1;
          this.HY = (this.QK - this.Q0) / (double) this.MK1;
          this.UA = Array.CreateInstance(typeof (double), 801, 801);
          this.UM = Array.CreateInstance(typeof (double), 801, 801);
          this.UV = Array.CreateInstance(typeof (double), 801, 801);
          this.CalculateVar2();
          break;
      }
    }

    private void CalculateVar1()
    {
      Array instance1 = Array.CreateInstance(typeof (double), 100001);
      Array instance2 = Array.CreateInstance(typeof (double), 100001);
      Array instance3 = Array.CreateInstance(typeof (double), 100001);
      int lk1 = this.LK;
      for (this.L = 1; this.L <= lk1; ++this.L)
      {
        NewLateBinding.LateIndexSet((object) this.UA, new object[2]
        {
          (object) this.L,
          (object) this.FANv1(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
          {
            (object) this.L
          }, (string[]) null)))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) this.UM, new object[2]
        {
          (object) this.L,
          (object) this.InitNv1(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
          {
            (object) this.L
          }, (string[]) null)))
        }, (string[]) null);
      }
      double num1 = this.HX / 2.0;
      this.T = this.DT;
      int lk2 = this.LK;
      for (this.L = 1; this.L <= lk2; ++this.L)
        NewLateBinding.LateIndexSet((object) instance3, new object[2]
        {
          (object) this.L,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
          {
            (object) this.L
          }, (string[]) null))
        }, (string[]) null);
      while (true)
      {
        int num2 = 0;
        double num3 = this.DT / (this.HX * this.HX);
        NewLateBinding.LateIndexSet((object) instance1, new object[2]
        {
          (object) 1,
          (object) 0.0
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance2, new object[2]
        {
          (object) 1,
          (object) this.G0Nv1(this.T)
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance3, new object[2]
        {
          (object) 1,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance2, new object[1]
          {
            (object) 1
          }, (string[]) null))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance3, new object[2]
        {
          (object) this.LK,
          (object) this.G1Nv1(this.T)
        }, (string[]) null);
        int num4;
        do
        {
          ++num2;
          num4 = 0;
          double num5 = this.FNv1(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance3, new object[1]
          {
            (object) 1
          }, (string[]) null)));
          double num6 = this.FNv1(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance3, new object[1]
          {
            (object) 2
          }, (string[]) null)));
          double num7 = num3 * (num6 + num5) * this.HNv1(this.R0 + num1) / 2.0;
          int lk1_1 = this.LK1;
          for (this.L = 2; this.L <= lk1_1; ++this.L)
          {
            double Xin1 = this.R0 + this.HX * (double) (this.L - 1);
            double Xin2 = Xin1 + num1;
            double num8 = num6;
            num6 = this.FNv1(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance3, new object[1]
            {
              (object) (this.L + 1)
            }, (string[]) null)));
            double num9 = num7;
            num7 = num3 * (num6 + num8) * this.HNv1(Xin2) / 2.0;
            double num10 = Conversions.ToDouble(Operators.SubtractObject((object) (this.HNv1(Xin1) + num7 + num9), Operators.MultiplyObject((object) num9, NewLateBinding.LateIndexGet((object) instance1, new object[1]
            {
              (object) (this.L - 1)
            }, (string[]) null))));
            NewLateBinding.LateIndexSet((object) instance1, new object[2]
            {
              (object) this.L,
              (object) (num7 / num10)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance2, new object[2]
            {
              (object) this.L,
              Operators.DivideObject(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) this.HNv1(Xin1)), Operators.MultiplyObject((object) num9, NewLateBinding.LateIndexGet((object) instance2, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), (object) num10)
            }, (string[]) null);
          }
          int lk3 = this.LK;
          int lk1_2 = this.LK1;
          for (this.L = 2; this.L <= lk1_2; ++this.L)
          {
            --lk3;
            double num8 = Conversions.ToDouble(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
            {
              (object) lk3
            }, (string[]) null), NewLateBinding.LateIndexGet((object) instance3, new object[1]
            {
              (object) (lk3 + 1)
            }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance2, new object[1]
            {
              (object) lk3
            }, (string[]) null)));
            if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
            {
              Operators.DivideObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) instance3, new object[1]
              {
                (object) lk3
              }, (string[]) null), (object) num8), (object) num8)
            }, (string[]) null, (Type[]) null, (bool[]) null), (object) 0.0001, false))
              num4 = 1;
            NewLateBinding.LateIndexSet((object) instance3, new object[2]
            {
              (object) lk3,
              (object) num8
            }, (string[]) null);
          }
        }
        while (num4 == 1 & num2 < 100);
        int lk4 = this.LK;
        for (this.L = 1; this.L <= lk4; ++this.L)
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.L,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance3, new object[1]
            {
              (object) this.L
            }, (string[]) null))
          }, (string[]) null);
        if (this.T != this.TK)
        {
          double num5 = this.T + this.DT;
          if (num5 > this.TK)
          {
            this.DT = this.TK - this.T;
            this.T = this.TK;
          }
          else
            this.T = num5;
        }
        else
          break;
      }
      int lk5 = this.LK;
      for (this.L = 1; this.L <= lk5; ++this.L)
        NewLateBinding.LateIndexSet((object) this.UV, new object[2]
        {
          (object) this.L,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
          {
            Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UA, new object[1]
            {
              (object) this.L
            }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
            {
              (object) this.L
            }, (string[]) null))
          }, (string[]) null, (Type[]) null, (bool[]) null))
        }, (string[]) null);
    }

    private void CalculateVar2()
    {
      int lk1 = this.LK;
      for (this.L = 1; this.L <= lk1; ++this.L)
      {
        int mk = this.MK;
        for (this.M = 1; this.M <= mk; ++this.M)
        {
          NewLateBinding.LateIndexSet((object) this.UA, new object[3]
          {
            (object) this.L,
            (object) this.M,
            (object) this.FANv2(this.R0 + this.HX * (double) (this.L - 1), this.Q0 + this.HY * (double) (this.M - 1))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[3]
          {
            (object) this.L,
            (object) this.M,
            (object) this.InitNv2(this.R0 + this.HX * (double) (this.L - 1), this.Q0 + this.HY * (double) (this.M - 1))
          }, (string[]) null);
        }
      }
      switch (this.MyTaskNo)
      {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
          this.NumSolverV21();
          break;
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
          this.NumSolverV22();
          break;
      }
      this.LJ = (int) Math.Round((double) this.LK1 / 5.0);
      int lk2 = this.LK;
      for (this.L = 1; this.L <= lk2; ++this.L)
      {
        int mk = this.MK;
        for (this.M = 1; this.M <= mk; ++this.M)
          NewLateBinding.LateIndexSet((object) this.UV, new object[3]
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
          }, (string[]) null);
      }
    }

    private void NumSolverV21()
    {
      Array instance1 = Array.CreateInstance(typeof (double), 801);
      Array instance2 = Array.CreateInstance(typeof (double), 801);
      Array instance3 = Array.CreateInstance(typeof (double), 801, 801);
      Array instance4 = Array.CreateInstance(typeof (double), 801);
      object instance5 = (object) Array.CreateInstance(typeof (double), 801, 801);
      this.UV = Array.CreateInstance(typeof (double), 801, 801);
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
            }, (string[]) null);
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
              NewLateBinding.LateIndexSet((object) instance4, new object[2]
              {
                (object) this.L,
                RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
                {
                  (object) this.L,
                  (object) this.M
                }, (string[]) null))
              }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance1, new object[2]
            {
              (object) 1,
              (object) 0.0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance2, new object[2]
            {
              (object) 1,
              (object) this.G0Nv2(this.T, q0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance4, new object[2]
            {
              (object) 1,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance2, new object[1]
              {
                (object) 1
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance4, new object[2]
            {
              (object) this.LK,
              (object) this.G1Nv2(this.T, q0)
            }, (string[]) null);
            double num7 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance4, new object[1]
            {
              (object) 1
            }, (string[]) null)));
            double num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance4, new object[1]
            {
              (object) 2
            }, (string[]) null)));
            double num9 = num4 * (num8 + num7) * this.HNv2(this.R0 + num1) / 2.0;
            int lk1_1 = this.LK1;
            for (this.L = 2; this.L <= lk1_1; ++this.L)
            {
              double Xin1 = this.R0 + this.HX * (double) (this.L - 1);
              double Xin2 = Xin1 + num1;
              double num10 = num8;
              num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance4, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null)));
              double num11 = num9;
              num9 = num4 * (num8 + num10) * this.HNv2(Xin2) / 2.0;
              double num12 = Conversions.ToDouble(Operators.SubtractObject((object) (this.HNv2(Xin1) + num9 + num11), Operators.MultiplyObject((object) num11, NewLateBinding.LateIndexGet((object) instance1, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))));
              NewLateBinding.LateIndexSet((object) instance1, new object[2]
              {
                (object) this.L,
                (object) (num9 / num12)
              }, (string[]) null);
              NewLateBinding.LateIndexSet((object) instance2, new object[2]
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
              }, (string[]) null);
            }
            NewLateBinding.LateIndexSet((object) instance3, new object[3]
            {
              (object) 1,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance4, new object[1]
              {
                (object) 1
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance3, new object[3]
            {
              (object) this.LK,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance4, new object[1]
              {
                (object) this.LK
              }, (string[]) null))
            }, (string[]) null);
            int lk2 = this.LK;
            int lk1_2 = this.LK1;
            for (this.L = 2; this.L <= lk1_2; ++this.L)
            {
              --lk2;
              NewLateBinding.LateIndexSet((object) instance3, new object[3]
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
              }, (string[]) null);
            }
          }
          double r0 = this.R0;
          int lk1_3 = this.LK1;
          for (this.L = 2; this.L <= lk1_3; ++this.L)
          {
            r0 += this.HX;
            int mk2 = this.MK;
            for (this.M = 1; this.M <= mk2; ++this.M)
              NewLateBinding.LateIndexSet((object) instance4, new object[2]
              {
                (object) this.M,
                RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
                {
                  (object) this.L,
                  (object) this.M
                }, (string[]) null))
              }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance1, new object[2]
            {
              (object) 1,
              (object) 0.0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance2, new object[2]
            {
              (object) 1,
              (object) this.D0Nv2(this.T, r0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance4, new object[2]
            {
              (object) 1,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance2, new object[1]
              {
                (object) 1
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance4, new object[2]
            {
              (object) this.MK,
              (object) this.D1Nv2(this.T, r0)
            }, (string[]) null);
            double num7 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance4, new object[1]
            {
              (object) 1
            }, (string[]) null)));
            double num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance4, new object[1]
            {
              (object) 2
            }, (string[]) null)));
            double num9 = num5 * (num8 + num7) * this.HNv2(this.Q0 + num2) / 2.0;
            int mk1_2 = this.MK1;
            for (this.M = 2; this.M <= mk1_2; ++this.M)
            {
              double Xin1 = this.Q0 + this.HY * (double) (this.M - 1);
              double Xin2 = Xin1 + num2;
              double num10 = num8;
              num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance4, new object[1]
              {
                (object) (this.M + 1)
              }, (string[]) null)));
              double num11 = num9;
              num9 = num5 * (num8 + num10) * this.HNv2(Xin2) / 2.0;
              double num12 = Conversions.ToDouble(Operators.SubtractObject((object) (this.HNv2(Xin1) + num9 + num11), Operators.MultiplyObject((object) num11, NewLateBinding.LateIndexGet((object) instance1, new object[1]
              {
                (object) (this.M - 1)
              }, (string[]) null))));
              NewLateBinding.LateIndexSet((object) instance1, new object[2]
              {
                (object) this.M,
                (object) (num9 / num12)
              }, (string[]) null);
              NewLateBinding.LateIndexSet((object) instance2, new object[2]
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
              }, (string[]) null);
            }
            NewLateBinding.LateIndexSet(instance5, new object[3]
            {
              (object) this.L,
              (object) 1,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance4, new object[1]
              {
                (object) 1
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet(instance5, new object[3]
            {
              (object) this.L,
              (object) this.MK,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance4, new object[1]
              {
                (object) this.MK
              }, (string[]) null))
            }, (string[]) null);
            int mk3 = this.MK;
            int mk1_3 = this.MK1;
            for (this.M = 2; this.M <= mk1_3; ++this.M)
            {
              --mk3;
              double num10 = Conversions.ToDouble(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
              {
                (object) mk3
              }, (string[]) null), NewLateBinding.LateIndexGet(instance5, new object[2]
              {
                (object) this.L,
                (object) (mk3 + 1)
              }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance2, new object[1]
              {
                (object) mk3
              }, (string[]) null)));
              if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
              {
                Operators.DivideObject(Operators.SubtractObject(NewLateBinding.LateIndexGet(instance5, new object[2]
                {
                  (object) this.L,
                  (object) mk3
                }, (string[]) null), (object) num10), (object) num10)
              }, (string[]) null, (Type[]) null, (bool[]) null), (object) 0.0001, false))
                num6 = 1;
              NewLateBinding.LateIndexSet(instance5, new object[3]
              {
                (object) this.L,
                (object) mk3,
                (object) num10
              }, (string[]) null);
            }
          }
        }
        while (num6 == 1 & num3 < 100);
        int mk1_4 = this.MK1;
        for (this.M = 2; this.M <= mk1_4; ++this.M)
        {
          int lk1 = this.LK1;
          for (this.L = 2; this.L <= lk1; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[3]
            {
              (object) this.L,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
              {
                (object) this.L,
                (object) this.M
              }, (string[]) null))
            }, (string[]) null);
        }
        int mk4 = this.MK;
        for (this.M = 1; this.M <= mk4; ++this.M)
        {
          double Yin = this.Q0 + this.HY * (double) (this.M - 1);
          NewLateBinding.LateIndexSet(instance5, new object[3]
          {
            (object) 1,
            (object) this.M,
            (object) this.G0Nv2(this.T, Yin)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[3]
          {
            (object) 1,
            (object) this.M,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
            {
              (object) 1,
              (object) this.M
            }, (string[]) null))
          }, (string[]) null);
          NewLateBinding.LateIndexSet(instance5, new object[3]
          {
            (object) this.LK,
            (object) this.M,
            (object) this.G1Nv2(this.T, Yin)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[3]
          {
            (object) this.LK,
            (object) this.M,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
            {
              (object) this.LK,
              (object) this.M
            }, (string[]) null))
          }, (string[]) null);
        }
        int lk1_4 = this.LK1;
        for (this.L = 2; this.L <= lk1_4; ++this.L)
        {
          double Xin = this.R0 + this.HX * (double) (this.L - 1);
          NewLateBinding.LateIndexSet(instance5, new object[3]
          {
            (object) this.L,
            (object) 1,
            (object) this.D0Nv2(this.T, Xin)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[3]
          {
            (object) this.L,
            (object) 1,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
            {
              (object) this.L,
              (object) 1
            }, (string[]) null))
          }, (string[]) null);
          NewLateBinding.LateIndexSet(instance5, new object[3]
          {
            (object) this.L,
            (object) this.MK,
            (object) this.D1Nv2(this.T, Xin)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[3]
          {
            (object) this.L,
            (object) this.MK,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(instance5, new object[2]
            {
              (object) this.L,
              (object) this.MK
            }, (string[]) null))
          }, (string[]) null);
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

    private void NumSolverV22()
    {
      Array instance1 = Array.CreateInstance(typeof (double), 801);
      Array instance2 = Array.CreateInstance(typeof (double), 801);
      Array instance3 = Array.CreateInstance(typeof (double), 801, 801);
      Array instance4 = Array.CreateInstance(typeof (double), 801, 801);
      Array instance5 = Array.CreateInstance(typeof (double), 801);
      this.UV = Array.CreateInstance(typeof (double), 801, 801);
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
            NewLateBinding.LateIndexSet((object) instance3, new object[3]
            {
              (object) this.L,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.UM, new object[2]
              {
                (object) this.L,
                (object) this.M
              }, (string[]) null))
            }, (string[]) null);
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
              NewLateBinding.LateIndexSet((object) instance5, new object[2]
              {
                (object) this.L,
                RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance3, new object[2]
                {
                  (object) this.L,
                  (object) this.M
                }, (string[]) null))
              }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance1, new object[2]
            {
              (object) 1,
              (object) 0.0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance2, new object[2]
            {
              (object) 1,
              (object) this.G0Nv2(this.T, q0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance5, new object[2]
            {
              (object) 1,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance2, new object[1]
              {
                (object) 1
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance5, new object[2]
            {
              (object) this.LK,
              (object) this.G1Nv2(this.T, q0)
            }, (string[]) null);
            double num7 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance5, new object[1]
            {
              (object) 1
            }, (string[]) null)));
            double num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance5, new object[1]
            {
              (object) 2
            }, (string[]) null)));
            double num9 = num4 * (num8 + num7) * this.HNv2(this.R0 + num1) / 2.0;
            int lk1_1 = this.LK1;
            for (this.L = 2; this.L <= lk1_1; ++this.L)
            {
              double Xin1 = this.R0 + this.HX * (double) (this.L - 1);
              double Xin2 = Xin1 + num1;
              double num10 = num8;
              num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance5, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null)));
              double num11 = num9;
              num9 = num4 * (num8 + num10) * this.HNv2(Xin2) / 2.0;
              double num12 = Conversions.ToDouble(Operators.SubtractObject((object) (this.HNv2(Xin1) + num9 + num11), Operators.MultiplyObject((object) num11, NewLateBinding.LateIndexGet((object) instance1, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))));
              NewLateBinding.LateIndexSet((object) instance1, new object[2]
              {
                (object) this.L,
                (object) (num9 / num12)
              }, (string[]) null);
              NewLateBinding.LateIndexSet((object) instance2, new object[2]
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
              }, (string[]) null);
            }
            NewLateBinding.LateIndexSet((object) instance4, new object[3]
            {
              (object) 1,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance5, new object[1]
              {
                (object) 1
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance4, new object[3]
            {
              (object) this.LK,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance5, new object[1]
              {
                (object) this.LK
              }, (string[]) null))
            }, (string[]) null);
            int lk2 = this.LK;
            int lk1_2 = this.LK1;
            for (this.L = 2; this.L <= lk1_2; ++this.L)
            {
              --lk2;
              NewLateBinding.LateIndexSet((object) instance4, new object[3]
              {
                (object) lk2,
                (object) this.M,
                Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
                {
                  (object) lk2
                }, (string[]) null), NewLateBinding.LateIndexGet((object) instance4, new object[2]
                {
                  (object) (lk2 + 1),
                  (object) this.M
                }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance2, new object[1]
                {
                  (object) lk2
                }, (string[]) null))
              }, (string[]) null);
            }
          }
          double r0 = this.R0;
          int lk1_3 = this.LK1;
          for (this.L = 2; this.L <= lk1_3; ++this.L)
          {
            r0 += this.HX;
            int mk2 = this.MK;
            for (this.M = 1; this.M <= mk2; ++this.M)
              NewLateBinding.LateIndexSet((object) instance5, new object[2]
              {
                (object) this.M,
                RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance3, new object[2]
                {
                  (object) this.L,
                  (object) this.M
                }, (string[]) null))
              }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance1, new object[2]
            {
              (object) 1,
              (object) 0.0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance2, new object[2]
            {
              (object) 1,
              (object) this.D0Nv2(this.T, r0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance5, new object[2]
            {
              (object) 1,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance2, new object[1]
              {
                (object) 1
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance5, new object[2]
            {
              (object) this.MK,
              (object) this.D1Nv2(this.T, r0)
            }, (string[]) null);
            double num7 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance5, new object[1]
            {
              (object) 1
            }, (string[]) null)));
            double num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance5, new object[1]
            {
              (object) 2
            }, (string[]) null)));
            double num9 = num5 * (num8 + num7) * this.H0Nv2(this.Q0 + num2) / 2.0;
            int mk1_2 = this.MK1;
            for (this.M = 2; this.M <= mk1_2; ++this.M)
            {
              double Xin1 = this.Q0 + this.HY * (double) (this.M - 1);
              double Xin2 = Xin1 + num2;
              double num10 = num8;
              num8 = this.FNv2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance5, new object[1]
              {
                (object) (this.M + 1)
              }, (string[]) null)));
              double num11 = num9;
              num9 = num5 * (num8 + num10) * this.H0Nv2(Xin2) / 2.0;
              double num12 = Conversions.ToDouble(Operators.SubtractObject((object) (this.H0Nv2(Xin1) * Math.Pow(r0, 2.0) + num9 + num11), Operators.MultiplyObject((object) num11, NewLateBinding.LateIndexGet((object) instance1, new object[1]
              {
                (object) (this.M - 1)
              }, (string[]) null))));
              NewLateBinding.LateIndexSet((object) instance1, new object[2]
              {
                (object) this.M,
                (object) (num9 / num12)
              }, (string[]) null);
              NewLateBinding.LateIndexSet((object) instance2, new object[2]
              {
                (object) this.M,
                Operators.DivideObject(Operators.AddObject(Operators.MultiplyObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance4, new object[2]
                {
                  (object) this.L,
                  (object) this.M
                }, (string[]) null), (object) this.H0Nv2(Xin1)), (object) Math.Pow(r0, 2.0)), Operators.MultiplyObject((object) num11, NewLateBinding.LateIndexGet((object) instance2, new object[1]
                {
                  (object) (this.M - 1)
                }, (string[]) null))), (object) num12)
              }, (string[]) null);
            }
            NewLateBinding.LateIndexSet((object) instance3, new object[3]
            {
              (object) this.L,
              (object) 1,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance5, new object[1]
              {
                (object) 1
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) instance3, new object[3]
            {
              (object) this.L,
              (object) this.MK,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance5, new object[1]
              {
                (object) this.MK
              }, (string[]) null))
            }, (string[]) null);
            int mk3 = this.MK;
            int mk1_3 = this.MK1;
            for (this.M = 2; this.M <= mk1_3; ++this.M)
            {
              --mk3;
              double num10 = Conversions.ToDouble(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
              {
                (object) mk3
              }, (string[]) null), NewLateBinding.LateIndexGet((object) instance3, new object[2]
              {
                (object) this.L,
                (object) (mk3 + 1)
              }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance2, new object[1]
              {
                (object) mk3
              }, (string[]) null)));
              if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
              {
                Operators.DivideObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) instance3, new object[2]
                {
                  (object) this.L,
                  (object) mk3
                }, (string[]) null), (object) num10), (object) num10)
              }, (string[]) null, (Type[]) null, (bool[]) null), (object) 0.0001, false))
                num6 = 1;
              NewLateBinding.LateIndexSet((object) instance3, new object[3]
              {
                (object) this.L,
                (object) mk3,
                (object) num10
              }, (string[]) null);
            }
          }
        }
        while (num6 == 1 & num3 < 100);
        int mk1_4 = this.MK1;
        for (this.M = 2; this.M <= mk1_4; ++this.M)
        {
          int lk1 = this.LK1;
          for (this.L = 2; this.L <= lk1; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[3]
            {
              (object) this.L,
              (object) this.M,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance3, new object[2]
              {
                (object) this.L,
                (object) this.M
              }, (string[]) null))
            }, (string[]) null);
        }
        int mk4 = this.MK;
        for (this.M = 1; this.M <= mk4; ++this.M)
        {
          double Yin = this.Q0 + this.HY * (double) (this.M - 1);
          NewLateBinding.LateIndexSet((object) instance3, new object[3]
          {
            (object) 1,
            (object) this.M,
            (object) this.G0Nv2(this.T, Yin)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[3]
          {
            (object) 1,
            (object) this.M,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance3, new object[2]
            {
              (object) 1,
              (object) this.M
            }, (string[]) null))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) instance3, new object[3]
          {
            (object) this.LK,
            (object) this.M,
            (object) this.G1Nv2(this.T, Yin)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[3]
          {
            (object) this.LK,
            (object) this.M,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance3, new object[2]
            {
              (object) this.LK,
              (object) this.M
            }, (string[]) null))
          }, (string[]) null);
        }
        int lk1_4 = this.LK1;
        for (this.L = 2; this.L <= lk1_4; ++this.L)
        {
          double Xin = this.R0 + this.HX * (double) (this.L - 1);
          NewLateBinding.LateIndexSet((object) instance3, new object[3]
          {
            (object) this.L,
            (object) 1,
            (object) this.D0Nv2(this.T, Xin)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[3]
          {
            (object) this.L,
            (object) 1,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance3, new object[2]
            {
              (object) this.L,
              (object) 1
            }, (string[]) null))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) instance3, new object[3]
          {
            (object) this.L,
            (object) this.MK,
            (object) this.D1Nv2(this.T, Xin)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[3]
          {
            (object) this.L,
            (object) this.MK,
            RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance3, new object[2]
            {
              (object) this.L,
              (object) this.MK
            }, (string[]) null))
          }, (string[]) null);
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

    public double InitNv1(double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
          return Math.Pow(1.0 + Xin, 2.0) / 7.0;
        case 2:
          return (1.0 + Xin) / Math.Sqrt(5.0);
        case 3:
          return Math.Pow(1.0 + Xin, 4.0) / 121.0;
        case 4:
          return Math.Pow(1.0 + Xin, 4.0 / 3.0) / Math.Pow(5.0, 1.0 / 3.0);
        case 5:
          return Math.Pow(1.0 + Xin, 6.0) / 3375.0;
        case 6:
          return Math.Pow(Xin, 2.0) / 9.0;
        case 7:
          return Xin / Math.Sqrt(7.0);
        case 8:
          return Math.Pow(Xin, 4.0) / 196.0;
        case 9:
          return Math.Pow(Math.Pow(Xin, 2.0) / 6.0, 1.0 / 3.0);
        case 10:
          return Math.Pow(Xin, 6.0) / 4913.0;
        case 11:
          return Math.Pow(Xin, 2.0) / 11.0;
        case 12:
          return Xin / 3.0;
        case 13:
          return Math.Pow(Xin, 4.0) / 225.0;
        case 14:
          return Math.Pow(Xin, 6.0) / 6859.0;
        case 15:
          return Math.Pow(Xin, 4.0 / 3.0) / Math.Pow(81.0, 1.0 / 3.0);
        default:
          double num;
          return num;
      }
    }

    public double InitNv2(double Xin, double Yin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
          return Math.Pow(1.0 + Xin + Yin, 2.0) / 13.0;
        case 2:
          return (1.0 + Xin + Yin) / 3.0;
        case 3:
          return Math.Pow(1.0 + Xin + Yin, 4.0) / 441.0;
        case 4:
          return Math.Pow(1.0 + Xin + Yin, 4.0 / 3.0) / Math.Pow(100.0, 1.0 / 3.0);
        case 5:
          return Math.Pow(1.0 + Xin + Yin, 6.0) / 27000.0;
        case 6:
          return Math.Pow(Xin * Math.Cos(Yin), 2.0) / 7.0;
        case 7:
          return Math.Pow(Xin * Math.Sin(Yin), 2.0) / 7.0;
        case 8:
          return Xin * Math.Cos(Yin) / Math.Sqrt(5.0);
        case 9:
          return Xin * Math.Sin(Yin) / Math.Sqrt(5.0);
        case 10:
          return Math.Pow(Xin * Math.Cos(Yin), 4.0) / 121.0;
        case 11:
          return Math.Pow(Xin * Math.Cos(Yin), 2.0) / 7.0;
        case 12:
          return Math.Pow(Xin * Math.Sin(Yin), 2.0) / 9.0;
        case 13:
          return Xin * Math.Cos(Yin) / Math.Sqrt(5.0);
        case 14:
          return Xin * Math.Sin(Yin) / Math.Sqrt(7.0);
        case 15:
          return Math.Pow(Xin * Math.Sin(Yin), 4.0) / 196.0;
        default:
          double num;
          return num;
      }
    }

    public double FNv1(double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
        case 6:
        case 11:
          return Xin;
        case 2:
        case 7:
        case 12:
          return Xin * Xin;
        case 3:
        case 8:
        case 13:
          return Math.Sqrt(Xin);
        case 4:
        case 15:
          return Math.Exp(1.5 * Math.Log(Xin));
        case 5:
        case 10:
        case 14:
          return Math.Exp(1.0 / 3.0 * Math.Log(Xin));
        case 9:
          return Math.Pow(Xin, 3.0);
        default:
          double num;
          return num;
      }
    }

    public double FNv2(double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
        case 6:
        case 7:
        case 11:
        case 12:
          return Xin;
        case 2:
        case 8:
        case 9:
        case 13:
        case 14:
          return Math.Pow(Xin, 2.0);
        case 3:
        case 10:
        case 15:
          return Math.Sqrt(Xin);
        case 4:
          return Math.Pow(Xin, 1.5);
        case 5:
          return Math.Pow(Xin, 1.0 / 3.0);
        default:
          double num;
          return num;
      }
    }

    public double FANv1(double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
          return Math.Pow(1.0 + Xin, 2.0) / (7.0 - 6.0 * this.TK);
        case 2:
          return (1.0 + Xin) / Math.Sqrt(5.0 - 4.0 * this.TK);
        case 3:
          return Math.Pow(1.0 + Xin, 4.0) / Math.Pow(11.0 - 10.0 * this.TK, 2.0);
        case 4:
          return Math.Exp(4.0 / 3.0 * Math.Log(1.0 + Xin)) / Math.Exp(2.0 / 3.0 * Math.Log(5.0 - 14.0 * this.TK / 3.0));
        case 5:
          return Math.Pow(1.0 + Xin, 6.0) / Math.Pow(15.0 - 14.0 * this.TK, 3.0);
        case 6:
          return Math.Pow(Xin, 2.0) / (9.0 - 8.0 * this.TK);
        case 7:
          return Xin / Math.Sqrt(7.0 - 6.0 * this.TK);
        case 8:
          return Math.Pow(Xin, 4.0) / Math.Pow(14.0 - 12.0 * this.TK, 2.0);
        case 9:
          if (Xin == 0.0)
            return 0.0;
          return Math.Exp(2.0 / 3.0 * Math.Log(Xin)) / Math.Exp(1.0 / 3.0 * Math.Log(6.0 - 16.0 * this.TK / 3.0));
        case 10:
          return Math.Pow(Xin, 6.0) / Math.Pow(17.0 - 16.0 * this.TK, 3.0);
        case 11:
          return Math.Pow(Xin, 2.0) / (11.0 - 10.0 * this.TK);
        case 12:
          return Xin / Math.Sqrt(9.0 - 8.0 * this.TK);
        case 13:
          return Math.Pow(Xin, 4.0) / Math.Pow(15.0 - 14.0 * this.TK, 2.0);
        case 14:
          return Math.Pow(Xin, 6.0) / Math.Pow(19.0 - 18.0 * this.TK, 2.0);
        case 15:
          if (Xin == 0.0)
            return 0.0;
          return Math.Exp(4.0 / 3.0 * Math.Log(Xin)) / Math.Exp(2.0 / 3.0 * Math.Log(9.0 - 26.0 * this.TK / 3.0));
        default:
          double num;
          return num;
      }
    }

    public double FANv2(double Xin, double Yin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
          return Math.Pow(1.0 + Xin + Yin, 2.0) / (13.0 - 12.0 * this.TK);
        case 2:
          return (1.0 + Xin + Yin) / (9.0 - 8.0 * this.TK);
        case 3:
          return Math.Pow(1.0 + Xin + Yin, 4.0) / Math.Pow(21.0 - 20.0 * this.TK, 2.0);
        case 4:
          return Math.Pow(1.0 + Xin + Yin, 4.0 / 3.0) / Math.Pow(10.0 - 28.0 * this.TK / 3.0, 2.0 / 3.0);
        case 5:
          return Math.Pow(1.0 + Xin + Yin, 6.0) / Math.Pow(30.0 - 28.0 * this.TK, 3.0);
        case 6:
          return Math.Pow(Xin * Math.Cos(Yin), 2.0) / (7.0 - 6.0 * this.TK);
        case 7:
          return Math.Pow(Xin * Math.Sin(Yin), 2.0) / (7.0 - 6.0 * this.TK);
        case 8:
          return Xin * Math.Cos(Yin) / (5.0 - 4.0 * this.TK);
        case 9:
          return Xin * Math.Sin(Yin) / (5.0 - 4.0 * this.TK);
        case 10:
          return Math.Pow(Xin * Math.Cos(Yin), 4.0) / Math.Pow(11.0 - 10.0 * this.TK, 2.0);
        case 11:
          return Math.Pow(Xin * Math.Cos(Yin), 2.0) / (7.0 - 6.0 * this.TK);
        case 12:
          return Math.Pow(Xin * Math.Sin(Yin), 2.0) / (9.0 - 8.0 * this.TK);
        case 13:
          return Xin * Math.Cos(Yin) / (5.0 - 4.0 * this.TK);
        case 14:
          return Xin * Math.Sin(Yin) / (7.0 - 6.0 * this.TK);
        case 15:
          return Math.Pow(Xin * Math.Sin(Yin), 4.0) / Math.Pow(14.0 - 12.0 * this.TK, 2.0);
        default:
          double num;
          return num;
      }
    }

    public double HNv1(double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
          return 1.0;
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
          return Xin;
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
          return Math.Pow(Xin, 2.0);
        default:
          double num;
          return num;
      }
    }

    public double HNv2(double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
          return 1.0;
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
          return Xin;
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
          return Math.Pow(Xin, 2.0);
        default:
          double num;
          return num;
      }
    }

    public double H0Nv2(double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
          return 1.0;
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
          return Math.Sin(Xin);
        default:
          double num;
          return num;
      }
    }

    public double G0Nv1(double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
          return 1.0 / (7.0 - 6.0 * Xin);
        case 2:
          return 1.0 / Math.Sqrt(5.0 - 4.0 * Xin);
        case 3:
          return 1.0 / Math.Pow(11.0 - 10.0 * Xin, 2.0);
        case 4:
          return 1.0 / Math.Exp(2.0 / 3.0 * Math.Log(5.0 - 14.0 * Xin / 3.0));
        case 5:
          return 1.0 / Math.Pow(15.0 - 14.0 * Xin, 3.0);
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
          return 0.0;
        default:
          double num;
          return num;
      }
    }

    public double G0Nv2(double Tin, double Yin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
          return Math.Pow(1.0 + Yin, 2.0) / (13.0 - 12.0 * Tin);
        case 2:
          return (1.0 + Yin) / Math.Sqrt(9.0 - 8.0 * Tin);
        case 3:
          return Math.Pow(1.0 + Yin, 4.0) / Math.Pow(21.0 - 20.0 * Tin, 2.0);
        case 4:
          return Math.Pow(1.0 + Yin, 4.0 / 3.0) / Math.Pow(10.0 - 28.0 * Tin / 3.0, 2.0 / 3.0);
        case 5:
          return Math.Pow(1.0 + Yin, 6.0) / Math.Pow(30.0 - 28.0 * Tin, 3.0);
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
          return 0.0;
        default:
          double num;
          return num;
      }
    }

    public double G1Nv1(double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
          return 4.0 / (7.0 - 6.0 * Xin);
        case 2:
          return 2.0 / Math.Sqrt(5.0 - 4.0 * Xin);
        case 3:
          return 16.0 / Math.Pow(11.0 - 10.0 * Xin, 2.0);
        case 4:
          return Math.Exp(4.0 / 3.0 * Math.Log(2.0)) / Math.Exp(2.0 / 3.0 * Math.Log(5.0 - 14.0 * Xin / 3.0));
        case 5:
          return 64.0 / Math.Pow(15.0 - 14.0 * Xin, 3.0);
        case 6:
          return 1.0 / (9.0 - 8.0 * Xin);
        case 7:
          return 1.0 / Math.Sqrt(7.0 - 6.0 * Xin);
        case 8:
          return 1.0 / Math.Pow(14.0 - 12.0 * Xin, 2.0);
        case 9:
          return 1.0 / Math.Exp(1.0 / 3.0 * Math.Log(6.0 - 16.0 * Xin / 3.0));
        case 10:
          return 1.0 / Math.Pow(17.0 - 16.0 * Xin, 3.0);
        case 11:
          return 1.0 / (11.0 - 10.0 * Xin);
        case 12:
          return 1.0 / Math.Sqrt(9.0 - 8.0 * Xin);
        case 13:
          return 1.0 / Math.Pow(15.0 - 14.0 * Xin, 2.0);
        case 14:
          return 1.0 / Math.Pow(19.0 - 18.0 * Xin, 3.0);
        case 15:
          return 1.0 / Math.Exp(2.0 / 3.0 * Math.Log(9.0 - 26.0 * Xin / 3.0));
        default:
          double num;
          return num;
      }
    }

    public double G1Nv2(double Tin, double Yin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
          return Math.Pow(2.0 + Yin, 2.0) / (13.0 - 12.0 * Tin);
        case 2:
          return (2.0 + Yin) / Math.Sqrt(9.0 - 8.0 * Tin);
        case 3:
          return Math.Pow(2.0 + Yin, 4.0) / Math.Pow(21.0 - 20.0 * Tin, 2.0);
        case 4:
          return Math.Pow(2.0 + Yin, 4.0 / 3.0) / Math.Pow(10.0 - 28.0 * Tin / 3.0, 2.0 / 3.0);
        case 5:
          return Math.Pow(2.0 + Yin, 6.0) / Math.Pow(30.0 - 28.0 * Tin, 3.0);
        case 6:
          return Math.Pow(Math.Cos(Yin), 2.0) / (7.0 - 6.0 * Tin);
        case 7:
          return Math.Pow(Math.Sin(Yin), 2.0) / (7.0 - 6.0 * Tin);
        case 8:
          return Math.Cos(Yin) / Math.Sqrt(5.0 - 4.0 * Tin);
        case 9:
          return Math.Sin(Yin) / Math.Sqrt(5.0 - 4.0 * Tin);
        case 10:
          return Math.Pow(Math.Cos(Yin), 4.0) / Math.Pow(11.0 - 10.0 * Tin, 2.0);
        case 11:
          return Math.Pow(Math.Cos(Yin), 2.0) / (7.0 - 6.0 * Tin);
        case 12:
          return Math.Pow(Math.Sin(Yin), 2.0) / (9.0 - 8.0 * Tin);
        case 13:
          return Math.Cos(Yin) / Math.Sqrt(5.0 - 4.0 * Tin);
        case 14:
          return Math.Sin(Yin) / Math.Sqrt(7.0 - 6.0 * Tin);
        case 15:
          return Math.Pow(Math.Sin(Yin), 4.0) / Math.Pow(14.0 - 12.0 * Tin, 2.0);
        default:
          double num;
          return num;
      }
    }

    public double D0Nv2(double Tin, double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
          return Math.Pow(1.0 + Xin, 2.0) / (13.0 - 12.0 * Tin);
        case 2:
          return (1.0 + Xin) / Math.Sqrt(9.0 - 8.0 * Tin);
        case 3:
          return Math.Pow(1.0 + Xin, 4.0) / Math.Pow(21.0 - 20.0 * Tin, 2.0);
        case 4:
          return Math.Pow(1.0 + Xin, 4.0 / 3.0) / Math.Pow(10.0 - 28.0 * Tin / 3.0, 2.0 / 3.0);
        case 5:
          return Math.Pow(1.0 + Xin, 6.0) / Math.Pow(30.0 - 28.0 * Tin, 3.0);
        case 6:
          return Math.Pow(Xin, 2.0) / (7.0 - 6.0 * Tin);
        case 7:
        case 9:
        case 12:
          return 0.0;
        case 8:
          return Xin / Math.Sqrt(5.0 - 4.0 * Tin);
        case 10:
          return Math.Pow(Xin, 4.0) / Math.Pow(11.0 - 10.0 * Tin, 2.0);
        case 11:
          return Math.Pow(Xin, 2.0) / (7.0 - 6.0 * this.T);
        case 13:
          return Xin / Math.Sqrt(5.0 - 4.0 * Tin);
        case 14:
          return Xin / (7.0 - 6.0 * this.T);
        case 15:
          return Math.Pow(Xin, 4.0) / Math.Pow(14.0 - 12.0 * Tin, 2.0);
        default:
          double num;
          return num;
      }
    }

    public double D1Nv2(double Tin, double Xin)
    {
      switch (this.MyTaskNo)
      {
        case 1:
          return Math.Pow(2.0 + Xin, 2.0) / (13.0 - 12.0 * Tin);
        case 2:
          return (2.0 + Xin) / Math.Sqrt(9.0 - 8.0 * Tin);
        case 3:
          return Math.Pow(2.0 + Xin, 4.0) / Math.Pow(21.0 - 20.0 * Tin, 2.0);
        case 4:
          return Math.Pow(2.0 + Xin, 4.0 / 3.0) / Math.Pow(10.0 - 28.0 * Tin / 3.0, 2.0 / 3.0);
        case 5:
          return Math.Pow(2.0 + Xin, 6.0) / Math.Pow(30.0 - 28.0 * Tin, 3.0);
        case 6:
        case 8:
        case 10:
        case 11:
          return 0.0;
        case 7:
          return Math.Pow(Xin, 2.0) / (7.0 - 6.0 * Tin);
        case 9:
          return Xin / Math.Sqrt(5.0 - 4.0 * Tin);
        case 12:
          return Math.Pow(Xin, 2.0) / (9.0 - 8.0 * Tin);
        case 13:
          return Xin / Math.Sqrt(5.0 - 4.0 * Tin);
        case 14:
          return Xin / Math.Sqrt(7.0 - 6.0 * Tin);
        case 15:
          return Math.Pow(Xin, 4.0) / Math.Pow(14.0 - 12.0 * Tin, 2.0);
        default:
          double num;
          return num;
      }
    }
  }
}
