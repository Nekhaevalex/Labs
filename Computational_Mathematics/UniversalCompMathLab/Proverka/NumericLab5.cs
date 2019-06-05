// Decompiled with JetBrains decompiler
// Type: Proverka.NumericLab5
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace Proverka
{
  public class NumericLab5
  {
    public int N;
    public int L;
    public int LK;
    public int LK1;
    public int LJ;
    public double X0;
    public double XN;
    public double Y0;
    public double EPS;
    public double AK;
    public double H;
    public double T;
    public double DT;
    public double DTX;
    public Array X;
    public Array UA;
    public Array UM;
    public Array UV;
    private int MyTaskNo;

    public NumericLab5()
    {
      this.X = Array.CreateInstance(typeof (double), 100001);
      this.UA = Array.CreateInstance(typeof (double), 100001);
      this.UM = Array.CreateInstance(typeof (double), 100001);
      this.UV = Array.CreateInstance(typeof (double), 100001);
    }

    public void Calculate(int varNo, int taskNo)
    {
      this.MyTaskNo = taskNo;
      this.LK1 = this.LK - 1;
      this.H = 1.0 / (double) this.LK1;
      this.LJ = (int) Math.Round((double) this.LK1 / 10.0);
      int lk1 = this.LK;
      for (this.L = 1; this.L <= lk1; ++this.L)
        NewLateBinding.LateIndexSet((object) this.X, new object[2]
        {
          (object) this.L,
          (object) ((double) (this.L - 1) * this.H)
        }, (string[]) null);
      this.DT = this.AK * this.H;
      this.DTX = this.DT / this.H;
      this.N = (int) Math.Round(1.0 / this.DT);
      this.T = 0.0;
      switch (varNo)
      {
        case 1:
          this.CalculateVar1();
          break;
        case 2:
          this.CalculateVar2();
          break;
        case 3:
          this.CalculateVar3();
          break;
      }
      int lk2 = this.LK;
      for (this.L = 1; this.L <= lk2; ++this.L)
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

    private void CalculateVar1()
    {
      switch (this.MyTaskNo)
      {
        case 1:
          int lk1 = this.LK;
          for (this.L = 1; this.L <= lk1; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) (Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) 2)))) + Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) (Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)))) + Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          int n1 = this.N;
          for (int index1 = 1; index1 <= n1; ++index1)
          {
            int num = this.LK - 1;
            for (int index2 = 1; index2 <= num; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null)))), (object) (this.DT * Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) Math.Log(1.0 + Math.Pow(this.T, 2.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num1 = this.LK - 1;
          for (int index = 1; index <= num1; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null)))), (object) (this.DT * Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) Math.Log(1.0 + Math.Pow(this.T, 2.0))
          }, (string[]) null);
          break;
        case 2:
          int lk2 = this.LK;
          for (this.L = 1; this.L <= lk2; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) 2), (object) Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2), (object) Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          int n2 = this.N;
          for (int index = 1; index <= n2; ++index)
          {
            int num2 = this.LK - 1;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) (this.DT * Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Pow(1.0 + this.T, 2.0) + Math.Cos(1.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num3 = this.LK - 1;
          for (this.L = 1; this.L <= num3; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) (this.DT * Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Pow(1.0 + this.T, 2.0) + Math.Cos(1.0))
          }, (string[]) null);
          break;
        case 3:
          int lk3 = this.LK;
          for (this.L = 1; this.L <= lk3; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) Math.Cos(Conversions.ToDouble(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2.0)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))
            }, (string[]) null);
          }
          int n3 = this.N;
          for (int index = 1; index <= n3; ++index)
          {
            int num2 = this.LK - 1;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) (2.0 * this.DTX), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) Math.Cos(1.0 + 2.0 * this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num4 = this.LK - 1;
          for (this.L = 1; this.L <= num4; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) (2.0 * this.DTX), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) Math.Cos(1.0 + 2.0 * this.T)
          }, (string[]) null);
          break;
        case 4:
          int lk4 = this.LK;
          for (this.L = 1; this.L <= lk4; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2))))
            }, (string[]) null);
          }
          int n4 = this.N;
          for (int index = 1; index <= n4; ++index)
          {
            int num2 = this.LK - 1;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * (2.0 * this.T + 3.0)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) Math.Log(1.0 + Math.Pow(1.0 + 3.0 * this.T + Math.Pow(this.T, 2.0), 2.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num5 = this.LK - 1;
          for (this.L = 1; this.L <= num5; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * (2.0 * this.T + 3.0)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) Math.Log(1.0 + Math.Pow(1.0 + 3.0 * this.T + Math.Pow(this.T, 2.0), 2.0))
          }, (string[]) null);
          break;
        case 5:
          int lk5 = this.LK;
          for (this.L = 1; this.L <= lk5; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 6.5)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))
            }, (string[]) null);
          }
          int n5 = this.N;
          for (int index1 = 1; index1 <= n5; ++index1)
          {
            int num2 = this.LK - 1;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * (this.T + 6.0)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (-Math.Pow(this.T, 2.0) / 2.0 - 6.0 * this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num6 = this.LK - 1;
          for (int index = 1; index <= num6; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * (this.T + 6.0)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (-Math.Pow(this.T, 2.0) / 2.0 - 6.0 * this.T)
          }, (string[]) null);
          break;
        case 6:
          int lk6 = this.LK;
          for (this.L = 1; this.L <= lk6; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.MultiplyObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2), (object) Math.Exp(-2.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2)
            }, (string[]) null);
          }
          int n6 = this.N;
          for (int index1 = 1; index1 <= n6; ++index1)
          {
            int num2 = this.LK - 1;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (16.0 * Math.Exp(-2.0 * this.T))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num7 = this.LK - 1;
          for (int index = 1; index <= num7; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (16.0 * Math.Exp(-2.0 * this.T))
          }, (string[]) null);
          break;
        case 7:
          int lk7 = this.LK;
          for (this.L = 1; this.L <= lk7; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) Math.Sin(Conversions.ToDouble(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0))), Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 8.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 8.0))
            }, (string[]) null);
          }
          int n7 = this.N;
          for (int index1 = 1; index1 <= n7; ++index1)
          {
            int num2 = this.LK - 1;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) (4.0 * this.DTX), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) -Math.Sin(4.0 * this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num8 = this.LK - 1;
          for (int index = 1; index <= num8; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) (4.0 * this.DTX), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) -Math.Sin(4.0 * this.T)
          }, (string[]) null);
          break;
        case 8:
          int lk8 = this.LK;
          for (this.L = 1; this.L <= lk8; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(1.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0)
            }, (string[]) null);
          }
          int n8 = this.N;
          for (int index1 = 1; index1 <= n8; ++index1)
          {
            int num2 = this.LK - 1;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null)))), (object) (this.DT * Math.Exp(this.T)))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (Math.Exp(this.T) - this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num9 = this.LK - 1;
          for (int index = 1; index <= num9; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null)))), (object) (this.DT * Math.Exp(this.T)))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (Math.Exp(this.T) - this.T)
          }, (string[]) null);
          break;
        case 9:
          int lk9 = this.LK;
          for (this.L = 1; this.L <= lk9; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(Operators.AddObject(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 2.0), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(-1.0))), (object) 1.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.AddObject((object) 1.0, Operators.MultiplyObject((object) 0.5, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          int n9 = this.N;
          for (int index1 = 1; index1 <= n9; ++index1)
          {
            int num2 = this.LK - 1;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(this.T))), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null)))), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(this.T))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) -this.T
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num10 = this.LK - 1;
          for (int index = 1; index <= num10; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(this.T))), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null)))), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(this.T))))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) -this.T
          }, (string[]) null);
          break;
        case 10:
          int lk10 = this.LK;
          for (this.L = 1; this.L <= lk10; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) 0.5, Operators.ExponentObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(1.0)), (object) 2))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) 2)
            }, (string[]) null);
          }
          int n10 = this.N;
          for (int index1 = 1; index1 <= n10; ++index1)
          {
            int num2 = this.LK - 1;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * Math.Exp(this.T)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null)))), (object) (this.DT * this.T))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (Math.Exp(2.0 * this.T) + Math.Pow(this.T, 2.0) / 2.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num11 = this.LK - 1;
          for (int index = 1; index <= num11; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * Math.Exp(this.T)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null)))), (object) (this.DT * this.T))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (Math.Exp(2.0 * this.T) + Math.Pow(this.T, 2.0) / 2.0)
          }, (string[]) null);
          break;
        case 11:
          int lk11 = this.LK;
          for (this.L = 1; this.L <= lk11; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.MultiplyObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) Math.Pow(1.0 - Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), 2.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) Math.Exp(Conversions.ToDouble(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.MultiplyObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          }
          int n11 = this.N;
          for (int index1 = 1; index1 <= n11; ++index1)
          {
            int num2 = this.LK - 1;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (Math.Pow(this.T - 1.0, 2.0) - 1.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num12 = this.LK - 1;
          for (int index = 1; index <= num12; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (Math.Pow(this.T - 1.0, 2.0) - 1.0)
          }, (string[]) null);
          break;
        case 12:
          int lk12 = this.LK;
          for (this.L = 1; this.L <= lk12; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject((object) Math.Pow(1.0 + Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), 2.0), Operators.MultiplyObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject((object) Math.Exp(Conversions.ToDouble(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.MultiplyObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          }
          int n12 = this.N;
          for (int index = 1; index <= n12; ++index)
          {
            int num2 = this.LK - 1;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) Math.Pow(Math.E + this.T, 2.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num13 = this.LK - 1;
          for (this.L = 1; this.L <= num13; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) Math.Pow(Math.E + this.T, 2.0)
          }, (string[]) null);
          break;
        case 13:
          int lk13 = this.LK;
          for (this.L = 1; this.L <= lk13; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) (Math.Exp(1.0) + 1.0), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0)
            }, (string[]) null);
          }
          int n13 = this.N;
          for (int index = 1; index <= n13; ++index)
          {
            int num2 = this.LK - 1;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) (this.DT * Math.Exp(this.T)))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Exp(this.T) + this.T + 1.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num14 = this.LK - 1;
          for (this.L = 1; this.L <= num14; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) (this.DT * Math.Exp(this.T)))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Exp(this.T) + this.T + 1.0)
          }, (string[]) null);
          break;
        case 14:
          int lk14 = this.LK;
          for (this.L = 1; this.L <= lk14; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(1.0)), (object) 1.0), Operators.MultiplyObject((object) 0.5, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2), (object) 2.0))
            }, (string[]) null);
          }
          int n14 = this.N;
          for (int index = 1; index <= n14; ++index)
          {
            int num2 = this.LK - 1;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(-this.T))), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(-this.T))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Exp(this.T) + this.T - 0.5)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num15 = this.LK - 1;
          for (this.L = 1; this.L <= num15; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(-this.T))), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(-this.T))))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Exp(this.T) + this.T - 0.5)
          }, (string[]) null);
          break;
        case 15:
          int lk15 = this.LK;
          for (this.L = 1; this.L <= lk15; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.MultiplyObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2), (object) Math.Exp(2.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2)
            }, (string[]) null);
          }
          int n15 = this.N;
          for (int index = 1; index <= n15; ++index)
          {
            int num2 = this.LK - 1;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (25.0 * Math.Exp(2.0 * this.T))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num16 = this.LK - 1;
          for (this.L = 1; this.L <= num16; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (25.0 * Math.Exp(2.0 * this.T))
          }, (string[]) null);
          break;
        case 16:
          int lk16 = this.LK;
          for (this.L = 1; this.L <= lk16; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(1.0)), (object) 2), (object) 0.5)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) 2)
            }, (string[]) null);
          }
          int n16 = this.N;
          for (int index = 1; index <= n16; ++index)
          {
            int num2 = this.LK - 1;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * Math.Exp(this.T)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) (this.DT * this.T))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Pow(Math.Exp(this.T) + 1.0, 2.0) + Math.Pow(this.T, 2.0) / 2.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num17 = this.LK - 1;
          for (this.L = 1; this.L <= num17; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) (this.DTX * Math.Exp(this.T)), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) (this.DT * this.T))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Pow(Math.Exp(this.T) + 1.0, 2.0) + Math.Pow(this.T, 2.0) / 2.0)
          }, (string[]) null);
          break;
      }
    }

    private void CalculateVar2()
    {
      switch (this.MyTaskNo)
      {
        case 1:
          int lk1 = this.LK;
          for (this.L = 1; this.L <= lk1; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) 2), (object) Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2), (object) Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          int n1 = this.N;
          for (int index = 1; index <= n1; ++index)
          {
            int num = this.LK - 1;
            for (this.L = 1; this.L <= num; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), (object) (this.DT * Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), (object) (0.5 * Math.Pow(this.DT, 2.0) * Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Pow(this.T + 1.0, 2.0) + Math.Cos(1.0) - this.H * (2.0 * (this.T + 1.0) - Math.Sin(1.0)) + Math.Pow(this.H, 2.0) * (1.0 - 0.5 * Math.Cos(1.0)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Pow(this.T + 1.0, 2.0) + Math.Cos(1.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num1 = this.LK - 2;
          for (this.L = 1; this.L <= num1; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), (object) (this.DT * Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), (object) (0.5 * Math.Pow(this.DT, 2.0) * Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Pow(this.T + 1.0, 2.0) + Math.Cos(1.0) - this.H * (2.0 * (this.T + 1.0) - Math.Sin(1.0)) + Math.Pow(this.H, 2.0) * (1.0 - 0.5 * Math.Cos(1.0)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Pow(this.T + 1.0, 2.0) + Math.Cos(1.0))
          }, (string[]) null);
          break;
        case 2:
          int lk2 = this.LK;
          for (this.L = 1; this.L <= lk2; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) Math.Cos(Conversions.ToDouble(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2.0)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))
            }, (string[]) null);
          }
          int n2 = this.N;
          for (int index = 1; index <= n2; ++index)
          {
            int num2 = this.LK - 2;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (2.0 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Cos(1.0 + 2.0 * this.T) * (1.0 - this.H * this.H / 2.0) + (this.H - Math.Pow(this.H, 3.0) / 6.0) * Math.Sin(1.0 + 2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) Math.Cos(1.0 + 2.0 * this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num3 = this.LK - 2;
          for (this.L = 1; this.L <= num3; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (2.0 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Cos(1.0 + 2.0 * this.T) * (1.0 - this.H * this.H / 2.0) + (this.H - Math.Pow(this.H, 3.0) / 6.0) * Math.Sin(1.0 + 2.0 * this.T))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) Math.Cos(1.0 + 2.0 * this.T)
          }, (string[]) null);
          break;
        case 3:
          int lk3 = this.LK;
          for (this.L = 1; this.L <= lk3; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) Math.Sin(Conversions.ToDouble(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0))), Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 8.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 8.0))
            }, (string[]) null);
          }
          int n3 = this.N;
          for (int index1 = 1; index1 <= n3; ++index1)
          {
            int num2 = this.LK - 2;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (2.0 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (8.0 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), (object) (2.0 * Math.Pow(this.DT, 2.0)))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (-Math.Sin(4.0 * this.T) + this.H * Math.Cos(4.0 * this.T) - Math.Pow(this.H, 2.0) / 8.0 * Math.Sin(4.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) -Math.Sin(4.0 * this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num4 = this.LK - 2;
          for (int index = 1; index <= num4; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (2.0 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (8.0 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), (object) (2.0 * Math.Pow(this.DT, 2.0)))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (-Math.Sin(4.0 * this.T) + this.H * Math.Cos(4.0 * this.T) - Math.Pow(this.H, 2.0) / 8.0 * Math.Sin(4.0 * this.T))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) -Math.Sin(4.0 * this.T)
          }, (string[]) null);
          break;
        case 4:
          int lk4 = this.LK;
          for (this.L = 1; this.L <= lk4; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 6.5)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))
            }, (string[]) null);
          }
          int n4 = this.N;
          for (int index1 = 1; index1 <= n4; ++index1)
          {
            int num2 = this.LK - 2;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) ((0.5 * this.DT + this.T + 6.0) * 0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.T + 6.0, 2.0) * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (this.H - 6.0 * this.T - this.T * this.T / 2.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (-this.T * (6.0 + this.T / 2.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num5 = this.LK - 2;
          for (int index = 1; index <= num5; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) ((0.5 * this.DT + this.T + 6.0) * 0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.T + 6.0, 2.0) * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (this.H - 6.0 * this.T - this.T * this.T / 2.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (-this.T * (6.0 + this.T / 2.0))
          }, (string[]) null);
          break;
        case 5:
          int lk5 = this.LK;
          for (this.L = 1; this.L <= lk5; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.MultiplyObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2), (object) Math.Exp(-2.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2)
            }, (string[]) null);
          }
          int n5 = this.N;
          for (int index1 = 1; index1 <= n5; ++index1)
          {
            int num2 = this.LK - 2;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0), (object) (1.0 - 0.5 * this.DT)), (object) 0.5), (object) this.DTX), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0), (object) 2), (object) 0.5), (object) Math.Pow(this.DTX, 2.0)), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (Math.Pow(this.H + 4.0, 2.0) * Math.Exp(-2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (16.0 * Math.Exp(-2.0 * this.T))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num6 = this.LK - 2;
          for (int index = 1; index <= num6; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) (1.0 - 0.5 * this.DT)), (object) 0.5), (object) this.DTX), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2), (object) 0.5), (object) Math.Pow(this.DTX, 2.0)), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Pow(this.H + 4.0, 2.0) * Math.Exp(-2.0 * this.T))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (16.0 * Math.Exp(-2.0 * this.T))
          }, (string[]) null);
          break;
        case 6:
          int lk6 = this.LK;
          for (this.L = 1; this.L <= lk6; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2))))
            }, (string[]) null);
          }
          int n6 = this.N;
          for (int index = 1; index <= n6; ++index)
          {
            int num2 = this.LK - 2;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (0.5 * this.DTX * (2.0 * this.T + 3.0 + this.DT) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Math.Pow(2.0 * this.T + 3.0, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Log(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) - 2.0 * this.H * (1.0 + 3.0 * this.T + this.T * this.T) / (1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) + this.H * this.H * (1.0 - Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) / Math.Pow(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0), 2.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) Math.Log(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num7 = this.LK - 2;
          for (this.L = 1; this.L <= num7; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (0.5 * this.DTX * (2.0 * this.T + 3.0 + this.DT) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Math.Pow(2.0 * this.T + 3.0, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Log(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) - 2.0 * this.H * (1.0 + 3.0 * this.T + this.T * this.T) / (1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) + this.H * this.H * (1.0 - Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) / Math.Pow(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0), 2.0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) Math.Log(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0))
          }, (string[]) null);
          break;
        case 7:
          int lk7 = this.LK;
          for (this.L = 1; this.L <= lk7; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) (Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))) + Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(Operators.SubtractObject((object) 1.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 2)))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) (Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)))) + Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          int n7 = this.N;
          for (int index1 = 1; index1 <= n7; ++index1)
          {
            int num2 = this.LK - 2;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), (object) (this.DT * Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), (object) (0.5 * Math.Pow(this.DT, 2.0) * Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (Math.Log(1.0 + Math.Pow(this.T, 2.0)) + this.H * (1.0 - 2.0 * this.T / (1.0 + Math.Pow(this.T, 2.0))) + Math.Pow(this.H, 2.0) * (1.0 - Math.Pow(this.T, 2.0)) / Math.Pow(1.0 + Math.Pow(this.T, 2.0), 2.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) Math.Log(1.0 + Math.Pow(this.T, 2.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num8 = this.LK - 2;
          for (int index = 1; index <= num8; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), (object) (this.DT * Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), (object) (0.5 * Math.Pow(this.DT, 2.0) * Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Log(1.0 + Math.Pow(this.T, 2.0)) + this.H * (1.0 - 2.0 * this.T / (1.0 + Math.Pow(this.T, 2.0))) + Math.Pow(this.H, 2.0) * (1.0 - 2.0 * Math.Pow(this.T, 2.0) / (1.0 + Math.Pow(this.T, 2.0))) / (1.0 + Math.Pow(this.T, 2.0)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) Math.Log(1.0 + Math.Pow(this.T, 2.0))
          }, (string[]) null);
          break;
        case 8:
          int lk8 = this.LK;
          for (this.L = 1; this.L <= lk8; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.MultiplyObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) Math.Pow(1.0 - Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), 2.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) Math.Exp(Conversions.ToDouble(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.MultiplyObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          }
          int n8 = this.N;
          for (int index1 = 1; index1 <= n8; ++index1)
          {
            int num2 = this.LK - 2;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))) * (1.0 + 0.5 * this.DT * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))) * 0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (Math.Exp(Conversions.ToDouble(Operators.MultiplyObject((object) -2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))) * 0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) this.DT, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (0.5 * this.DT * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (Math.Pow(this.T - 1.0, 2.0) - 1.0 + 2.0 * this.H * (1.0 - this.T) + 0.5 * Math.Pow(this.H, 2.0) * (5.0 - 2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (Math.Pow(this.T - 1.0, 2.0) - 1.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num9 = this.LK - 2;
          for (int index = 1; index <= num9; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))) * (1.0 + 0.5 * this.DT * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))) * 0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (Math.Exp(Conversions.ToDouble(Operators.MultiplyObject((object) -2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))) * 0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) this.DT, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (0.5 * this.DT * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))))))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Pow(this.T - 1.0, 2.0) - 1.0 + 2.0 * this.H * (1.0 - this.T) + 0.5 * Math.Pow(this.H, 2.0) * (5.0 - 2.0 * this.T))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (Math.Pow(this.T - 1.0, 2.0) - 1.0)
          }, (string[]) null);
          break;
        case 9:
          int lk9 = this.LK;
          for (this.L = 1; this.L <= lk9; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(1.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0)
            }, (string[]) null);
          }
          int n9 = this.N;
          for (int index1 = 1; index1 <= n9; ++index1)
          {
            int num2 = this.LK - 2;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), (object) (this.DT * Math.Exp(this.T) * (1.0 + 0.5 * this.DT)))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (Math.Exp(this.T) - this.T + this.H)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (Math.Exp(this.T) - this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num10 = this.LK - 2;
          for (int index = 1; index <= num10; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), (object) (this.DT * Math.Exp(this.T) * (1.0 + 0.5 * this.DT)))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Exp(this.T) - this.T + this.H)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (Math.Exp(this.T) - this.T)
          }, (string[]) null);
          break;
        case 10:
          int lk10 = this.LK;
          for (this.L = 1; this.L <= lk10; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(Operators.AddObject(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 2.0), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(-1.0))), (object) 1.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.AddObject((object) 1.0, Operators.MultiplyObject((object) 0.5, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          int n10 = this.N;
          for (int index1 = 1; index1 <= n10; ++index1)
          {
            int num2 = this.LK - 2;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.AddObject(Operators.SubtractObject((object) Math.Exp(this.T), Operators.MultiplyObject((object) (0.5 * this.DT), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)), (object) 0.5), (object) this.DTX), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(this.T)), (object) 2), (object) 0.5), (object) Math.Pow(this.DTX, 2.0)), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) this.DT, Operators.SubtractObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(this.T))), Operators.MultiplyObject((object) (0.5 * this.DT), Operators.AddObject(Operators.MultiplyObject(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(this.T))), (object) Math.Exp(2.0 * this.T))))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (-this.T + Math.Exp(-this.T) * this.H + this.H * this.H / 2.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) -this.T
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num11 = this.LK - 2;
          for (int index = 1; index <= num11; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.AddObject(Operators.SubtractObject((object) Math.Exp(this.T), Operators.MultiplyObject((object) (0.5 * this.DT), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 0.5), (object) this.DTX), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(this.T)), (object) 2), (object) 0.5), (object) Math.Pow(this.DTX, 2.0)), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) this.DT, Operators.SubtractObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(this.T))), Operators.MultiplyObject((object) (0.5 * this.DT), Operators.AddObject(Operators.MultiplyObject(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(this.T))), (object) Math.Exp(2.0 * this.T))))))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (-this.T + Math.Exp(-this.T) * this.H + this.H * this.H / 2.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) -this.T
          }, (string[]) null);
          break;
        case 11:
          int lk11 = this.LK;
          for (this.L = 1; this.L <= lk11; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) 0.5, Operators.ExponentObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(1.0)), (object) 2))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) 2)
            }, (string[]) null);
          }
          int n11 = this.N;
          for (int index1 = 1; index1 <= n11; ++index1)
          {
            int num2 = this.LK - 2;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (Math.Exp(this.T) * (1.0 + 0.5 * this.DT) * 0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (Math.Exp(2.0 * this.T) * 0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), (object) (this.DT * (this.T + 0.5 * this.DT)))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (Math.Exp(2.0 * this.T) + 0.5 * Math.Pow(this.T, 2.0) - this.H * 2.0 * Math.Exp(this.T) + Math.Pow(this.H, 2.0) * 3.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (Math.Exp(2.0 * this.T) + 0.5 * Math.Pow(this.T, 2.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num12 = this.LK - 2;
          for (int index = 1; index <= num12; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (Math.Exp(this.T) * (1.0 + 0.5 * this.DT) * 0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (Math.Exp(2.0 * this.T) * 0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), (object) (this.DT * (this.T + 0.5 * this.DT)))
            }, (string[]) null);
          }
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Exp(2.0 * this.T) + 0.5 * Math.Pow(this.T, 2.0) - this.H * 2.0 * Math.Exp(this.T) + Math.Pow(this.H, 2.0) * 3.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (Math.Exp(2.0 * this.T) + 0.5 * Math.Pow(this.T, 2.0))
          }, (string[]) null);
          break;
        case 12:
          int lk12 = this.LK;
          for (this.L = 1; this.L <= lk12; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(1.0)), (object) 2), (object) 0.5)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) 2)
            }, (string[]) null);
          }
          int n12 = this.N;
          for (int index = 1; index <= n12; ++index)
          {
            int num2 = this.LK - 2;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (0.5 * this.DTX * (1.0 + 0.5 * this.DT) * Math.Exp(this.T) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Math.Exp(2.0 * this.T) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), (object) (this.DT * (this.T + 0.5 * this.DT)))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Pow(1.0 + Math.Exp(this.T), 2.0) + this.T * this.T / 2.0 - 2.0 * (1.0 + Math.Exp(this.T)) * this.H + this.H * this.H)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Pow(1.0 + Math.Exp(this.T), 2.0) + this.T * this.T / 2.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num13 = this.LK - 2;
          for (this.L = 1; this.L <= num13; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (0.5 * this.DTX * (1.0 + 0.5 * this.DT) * Math.Exp(this.T) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Math.Exp(2.0 * this.T) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), (object) (this.DT * (this.T + 0.5 * this.DT)))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Pow(1.0 + Math.Exp(this.T), 2.0) + this.T * this.T / 2.0 - 2.0 * (1.0 + Math.Exp(this.T)) * this.H + this.H * this.H)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Pow(1.0 + Math.Exp(this.T), 2.0) + this.T * this.T / 2.0)
          }, (string[]) null);
          break;
        case 13:
          int lk13 = this.LK;
          for (this.L = 1; this.L <= lk13; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject((object) Math.Pow(1.0 + Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), 2.0), Operators.MultiplyObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject((object) Math.Exp(Conversions.ToDouble(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.MultiplyObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          }
          int n13 = this.N;
          for (int index = 1; index <= n13; ++index)
          {
            int num2 = this.LK - 2;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (0.5 * this.DTX * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))) * (1.0 - 0.5 * this.DT * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Math.Exp(Conversions.ToDouble(Operators.MultiplyObject((object) -2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) this.DT, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (0.5 * this.DT * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Pow(Math.E + this.T, 2.0) - this.H * Math.E * (2.0 * this.T + 2.0 * Math.E - 1.0) + 0.5 * Math.Pow(this.H, 2.0) * Math.E * (1.0 + 2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) Math.Pow(Math.E + this.T, 2.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num14 = this.LK - 2;
          for (this.L = 1; this.L <= num14; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (0.5 * this.DTX * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))) * (1.0 - 0.5 * this.DT * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Math.Exp(Conversions.ToDouble(Operators.MultiplyObject((object) -2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) this.DT, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (0.5 * this.DT * Math.Exp(Conversions.ToDouble(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))))))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Pow(Math.E + this.T, 2.0) - this.H * Math.E * (2.0 * this.T + 2.0 * Math.E - 1.0) + 0.5 * Math.Pow(this.H, 2.0) * Math.E * (1.0 + 2.0 * this.T))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) Math.Pow(Math.E + this.T, 2.0)
          }, (string[]) null);
          break;
        case 14:
          int lk14 = this.LK;
          for (this.L = 1; this.L <= lk14; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) (Math.Exp(1.0) + 1.0), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0)
            }, (string[]) null);
          }
          int n14 = this.N;
          for (int index = 1; index <= n14; ++index)
          {
            int num2 = this.LK - 2;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) (0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), (object) (this.DT * (1.0 + 0.5 * this.DT) * Math.Exp(this.T)))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Exp(this.T) + this.T + 1.0 - this.H * (Math.Exp(this.T) - this.T + 1.0) + 0.5 * Math.Pow(this.H, 2.0) * (Math.Exp(this.T) - 1.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Exp(this.T) + this.T + 1.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num15 = this.LK - 2;
          for (this.L = 1; this.L <= num15; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) (0.5 * this.DTX * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), (object) (0.5 * Math.Pow(this.DTX, 2.0) * Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), (object) (this.DT * (1.0 + 0.5 * this.DT) * Math.Exp(this.T)))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Exp(this.T) + this.T + 1.0 - this.H * (Math.Exp(this.T) - this.T + 1.0) + 0.5 * Math.Pow(this.H, 2.0) * (Math.Exp(this.T) - 1.0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Exp(this.T) + this.T + 1.0)
          }, (string[]) null);
          break;
        case 15:
          int lk15 = this.LK;
          for (this.L = 1; this.L <= lk15; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(1.0)), (object) 1.0), Operators.MultiplyObject((object) 0.5, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) 0.5, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)))
            }, (string[]) null);
          }
          int n15 = this.N;
          for (int index = 1; index <= n15; ++index)
          {
            int num2 = this.LK - 2;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) (0.5 * this.DTX), Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(-this.T)), Operators.MultiplyObject((object) (0.5 * this.DT), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), Operators.MultiplyObject(Operators.MultiplyObject((object) (0.5 * Math.Pow(this.DTX, 2.0)), Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(-this.T)), (object) 2)), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) this.DT, Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(-this.T))), Operators.MultiplyObject((object) (0.5 * this.DT), Operators.AddObject(Operators.AddObject(Operators.MultiplyObject((object) 2.0, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 2)), Operators.MultiplyObject(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)), (object) Math.Exp(-this.T))), (object) Math.Exp(-2.0 * this.T))))))
              }, (string[]) null);
            this.T += this.DT;
            double num16 = (Math.Exp(this.T) - Math.Exp(-this.T)) / (1.0 + Math.Exp(-this.T));
            double num17 = (Math.Exp(this.T) + Math.Exp(-this.T) + Math.Exp(-this.T) * num16) / Math.Pow(1.0 + Math.Exp(-this.T), 2.0) - (2.0 + Math.Exp(-this.T) + num16) / (1.0 + Math.Exp(-this.T));
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.LK
              }, (string[]) null), (object) (this.H * num16)), (object) (0.5 * Math.Pow(this.H, 2.0) * num17))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Exp(this.T) + this.T - 0.5)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num18 = this.LK - 1;
          for (this.L = 1; this.L <= num18; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) (0.5 * this.DTX), Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(-this.T)), Operators.MultiplyObject((object) (0.5 * this.DT), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), Operators.MultiplyObject(Operators.MultiplyObject((object) (0.5 * Math.Pow(this.DTX, 2.0)), Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(-this.T)), (object) 2)), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) this.DT, Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(-this.T))), Operators.MultiplyObject((object) (0.5 * this.DT), Operators.AddObject(Operators.AddObject(Operators.MultiplyObject((object) 2.0, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)), Operators.MultiplyObject(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) Math.Exp(-this.T))), (object) Math.Exp(-2.0 * this.T))))))
            }, (string[]) null);
          this.T += this.DT;
          double num19 = (Math.Exp(this.T) - Math.Exp(-this.T)) / (1.0 + Math.Exp(-this.T));
          double num20 = (Math.Exp(this.T) + Math.Exp(-this.T) + Math.Exp(-this.T) * num19) / Math.Pow(1.0 + Math.Exp(-this.T), 2.0) - (2.0 + Math.Exp(-this.T) + num19) / (1.0 + Math.Exp(-this.T));
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
            {
              (object) this.LK
            }, (string[]) null), (object) (this.H * num19)), (object) (0.5 * Math.Pow(this.H, 2.0) * num20))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Exp(this.T) + this.T - 0.5)
          }, (string[]) null);
          break;
        case 16:
          int lk16 = this.LK;
          for (this.L = 1; this.L <= lk16; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.MultiplyObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2), (object) Math.Exp(2.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2)
            }, (string[]) null);
          }
          int n16 = this.N;
          for (int index = 1; index <= n16; ++index)
          {
            int num2 = this.LK - 2;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) (0.5 * this.DTX * (1.0 + 0.5 * this.DT)), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0)), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))), Operators.MultiplyObject(Operators.MultiplyObject((object) (0.5 * Math.Pow(this.DTX, 2.0)), Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4), (object) 2)), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) ((25.0 - 10.0 * this.H + this.H * this.H) * Math.Exp(2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (25.0 * Math.Exp(2.0 * this.T))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num21 = this.LK - 1;
          for (this.L = 1; this.L <= num21; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject((object) (0.5 * this.DTX * (1.0 + 0.5 * this.DT)), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0)), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 3.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))), Operators.MultiplyObject(Operators.MultiplyObject((object) (0.5 * Math.Pow(this.DTX, 2.0)), Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4), (object) 2)), (object) Conversions.ToDouble(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null), Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          this.T += this.DT;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) ((25.0 - 10.0 * this.H + this.H * this.H) * Math.Exp(2.0 * this.T))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (25.0 * Math.Exp(2.0 * this.T))
          }, (string[]) null);
          break;
      }
    }

    private void CalculateVar3()
    {
      switch (this.MyTaskNo)
      {
        case 1:
          int lk1 = this.LK;
          for (this.L = 1; this.L <= lk1; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) Math.Cos(Conversions.ToDouble(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2.0)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))
            }, (string[]) null);
          }
          int n1 = this.N;
          for (int index = 1; index <= n1; ++index)
          {
            int num = this.LK - 3;
            for (this.L = 1; this.L <= num; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 3)), Operators.MultiplyObject((object) (2.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) (4.0 * Math.Pow(this.DTX, 3.0) / 3.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) (this.LK - 2),
              (object) (Math.Cos(1.0 + 2.0 * this.T) * (1.0 - 2.0 * this.H * this.H) + (2.0 * this.H - 4.0 * Math.Pow(this.H, 3.0) / 3.0) * Math.Sin(1.0 + 2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Cos(1.0 + 2.0 * this.T) * (1.0 - this.H * this.H / 2.0) + (this.H - Math.Pow(this.H, 3.0) / 6.0) * Math.Sin(1.0 + 2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) Math.Cos(1.0 + 2.0 * this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num1 = this.LK - 3;
          for (this.L = 1; this.L <= num1; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 3)), Operators.MultiplyObject((object) (2.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) (4.0 * Math.Pow(this.DTX, 3.0) / 3.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) (this.LK - 2),
            (object) (Math.Cos(3.0) * (1.0 - 2.0 * this.H * this.H) + (2.0 * this.H - 4.0 * Math.Pow(this.H, 3.0) / 3.0) * Math.Sin(3.0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Cos(3.0) * (1.0 - this.H * this.H / 2.0) + (this.H - Math.Pow(this.H, 3.0) / 6.0) * Math.Sin(3.0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) Math.Cos(3.0)
          }, (string[]) null);
          break;
        case 2:
          int lk2 = this.LK;
          for (this.L = 1; this.L <= lk2; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) Math.Sin(Conversions.ToDouble(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0))), Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 8.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject((object) Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 8.0))
            }, (string[]) null);
          }
          int n2 = this.N;
          for (int index1 = 1; index1 <= n2; ++index1)
          {
            int num2 = this.LK - 3;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) (2.0 * this.DTX), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 3.0)), Operators.MultiplyObject((object) (8.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) (32.0 * Math.Pow(this.DTX, 3.0) / 3.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), (object) (2.0 * this.DT * this.DT))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 3,
              (object) (-Math.Sin(4.0 * this.T) + (2.0 * this.H - 4.0 * Math.Pow(this.H, 3.0) / 3.0) * Math.Cos(4.0 * this.T) + this.H * this.H / 2.0 * (1.0 + 4.0 * Math.Sin(4.0 * this.T)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (-Math.Sin(4.0 * this.T) + (this.H - Math.Pow(this.H, 3.0) / 6.0) * Math.Cos(4.0 * this.T) + this.H * this.H / 8.0 * (1.0 + 4.0 * Math.Sin(4.0 * this.T)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) -Math.Sin(4.0 * this.T)
            }, (string[]) null);
          }
          int num3 = this.LK - 3;
          for (int index = 1; index <= num3; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) (2.0 * this.DTX), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 3.0)), Operators.MultiplyObject((object) (8.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) (32.0 * Math.Pow(this.DTX, 3.0) / 3.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), (object) (2.0 * this.DT * this.DT))
            }, (string[]) null);
          }
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 3,
            (object) (-Math.Sin(4.0) + (2.0 * this.H - 4.0 * Math.Pow(this.H, 3.0) / 3.0) * Math.Cos(4.0) + this.H * this.H / 2.0 * (1.0 + 4.0 * Math.Sin(4.0)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (-Math.Sin(4.0) + (this.H - Math.Pow(this.H, 3.0) / 6.0) * Math.Cos(4.0) + this.H * this.H / 8.0 * (1.0 + 4.0 * Math.Sin(4.0)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) -Math.Sin(4.0)
          }, (string[]) null);
          break;
        case 3:
          int lk3 = this.LK;
          for (this.L = 1; this.L <= lk3; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 6.5)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))
            }, (string[]) null);
          }
          int n3 = this.N;
          for (int index1 = 1; index1 <= n3; ++index1)
          {
            int num2 = this.LK - 3;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 6.0), (object) (this.DT / 2.0 + this.T + 6.0))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) (this.T + 6.0)), (object) (this.T + 6.0 + this.DT)), (object) 2.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX * (this.T + 6.0), 3.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), (object) 6))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 3,
              (object) (2.0 * this.H - 6.0 * this.T - this.T * this.T / 2.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (this.H - 6.0 * this.T - this.T * this.T / 2.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (-this.T * (6.0 + this.T / 2.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num4 = this.LK - 3;
          for (int index = 1; index <= num4; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 6.0), (object) (this.DT / 2.0 + 7.0))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 7.0), (object) (7.0 + this.DT)), (object) 2.0)), Operators.MultiplyObject((object) (Math.Pow(this.DTX, 3.0) / 6.0 * 343.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 3,
            (object) (2.0 * this.H - 6.5)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (this.H - 6.5)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) -6.5
          }, (string[]) null);
          break;
        case 4:
          int lk4 = this.LK;
          for (this.L = 1; this.L <= lk4; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.MultiplyObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2), (object) Math.Exp(-2.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2)
            }, (string[]) null);
          }
          int n4 = this.N;
          for (int index1 = 1; index1 <= n4; ++index1)
          {
            int num2 = this.LK - 3;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0)), (object) (1.0 - this.DT / 2.0 + this.DT * this.DT / 6.0)), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 6)), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.ExponentObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0)), (object) 2), (object) (1.0 - this.DT)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 2.0)), Operators.MultiplyObject(Operators.DivideObject(Operators.ExponentObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0)), (object) 3), (object) 6), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 3,
              (object) (4.0 * Math.Pow(this.H + 2.0, 2.0) * Math.Exp(-2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (Math.Pow(this.H + 4.0, 2.0) * Math.Exp(-2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (16.0 * Math.Exp(-2.0 * this.T))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num5 = this.LK - 3;
          for (int index = 1; index <= num5; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0)), (object) (1.0 - this.DT / 2.0 + this.DT * this.DT / 6.0)), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 6)), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.ExponentObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0)), (object) 2), (object) (1.0 - this.DT)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 2.0)), Operators.MultiplyObject(Operators.DivideObject(Operators.ExponentObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0)), (object) 3), (object) 6), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 3,
            (object) (4.0 * Math.Pow(this.H + 2.0, 2.0) * Math.Exp(-2.0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Pow(this.H + 4.0, 2.0) * Math.Exp(-2.0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (16.0 * Math.Exp(-2.0))
          }, (string[]) null);
          break;
        case 5:
          int lk5 = this.LK;
          for (this.L = 1; this.L <= lk5; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2))))
            }, (string[]) null);
          }
          int n5 = this.N;
          for (int index = 1; index <= n5; ++index)
          {
            int num2 = this.LK - 3;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 6), (object) (2.0 * this.T + 3.0 + this.DT))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) (2.0 * this.T + 3.0)), (object) (2.0 * this.T + 3.0 + 2.0 * this.DT)), (object) 2)), Operators.MultiplyObject((object) (Math.Pow(this.DTX * (2.0 * this.T + 3.0), 3.0) / 6.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) (this.LK - 2),
              (object) (Math.Log(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) - 4.0 * this.H * (1.0 + 3.0 * this.T + this.T * this.T) / (1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) + 4.0 * this.H * this.H * (1.0 - Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) / Math.Pow(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0), 2.0) + 16.0 * Math.Pow(this.H, 3.0) * (1.0 + 3.0 * this.T + this.T * this.T) * (3.0 - Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) / (3.0 * Math.Pow(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0), 3.0)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Log(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) - 2.0 * this.H * (1.0 + 3.0 * this.T + this.T * this.T) / (1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) + this.H * this.H * (1.0 - Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) / Math.Pow(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0), 2.0) + 2.0 * Math.Pow(this.H, 3.0) * (1.0 + 3.0 * this.T + this.T * this.T) * (3.0 - Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0)) / (3.0 * Math.Pow(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0), 3.0)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) Math.Log(1.0 + Math.Pow(1.0 + 3.0 * this.T + this.T * this.T, 2.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num6 = this.LK - 3;
          for (this.L = 1; this.L <= num6; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 6), (object) (2.0 * this.T + 3.0 + this.DT))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) (2.0 * this.T + 3.0)), (object) (2.0 * this.T + 3.0 + 2.0 * this.DT)), (object) 2)), Operators.MultiplyObject((object) (Math.Pow(this.DTX * (2.0 * this.T + 3.0), 3.0) / 6.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) (this.LK - 2),
            (object) (Math.Log(26.0) - 4.0 * this.H * 5.0 / 26.0 + 4.0 * this.H * this.H * -24.0 / 676.0 + 16.0 * Math.Pow(this.H, 3.0) * 5.0 * -22.0 / 52728.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Log(26.0) - 2.0 * this.H * 5.0 / 26.0 + this.H * this.H * -24.0 / 676.0 + 2.0 * Math.Pow(this.H, 3.0) * 5.0 * -22.0 / 52728.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) Math.Log(26.0)
          }, (string[]) null);
          break;
        case 6:
          int lk6 = this.LK;
          for (this.L = 1; this.L <= lk6; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) (Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) 2)))) + Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) (Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2)))) + Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          int n6 = this.N;
          for (int index1 = 1; index1 <= n6; ++index1)
          {
            int num2 = this.LK - 3;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 6.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 2.0)), Operators.MultiplyObject((object) (Math.Pow(this.DTX, 3.0) / 6.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) (this.DT * (1.0 - this.DT * this.DT / 6.0) * Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), (object) (this.DT * this.DT / 2.0 * Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 3,
              (object) (Math.Log(1.0 + this.T * this.T) + 2.0 * Math.Pow(this.T - 1.0, 2.0) * this.H / (1.0 + this.T * this.T) - 4.0 * (this.T * this.T - 1.0) * this.H * this.H / Math.Pow(1.0 + this.T * this.T, 2.0) + 16.0 * this.T * (this.T * this.T - 3.0) * Math.Pow(this.H, 3.0) / (3.0 * Math.Pow(1.0 + this.T * this.T, 3.0)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (Math.Log(1.0 + this.T * this.T) + Math.Pow(this.T - 1.0, 2.0) * this.H / (1.0 + this.T * this.T) - (this.T * this.T - 1.0) * this.H * this.H / Math.Pow(1.0 + this.T * this.T, 2.0) + 4.0 * this.T * (this.T * this.T - 3.0) * Math.Pow(this.H, 3.0) / (6.0 * Math.Pow(1.0 + this.T * this.T, 3.0)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) Math.Log(1.0 + this.T * this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num7 = this.LK - 3;
          for (int index = 1; index <= num7; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 6.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 2.0)), Operators.MultiplyObject((object) (Math.Pow(this.DTX, 3.0) / 6.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) (this.DT * (1.0 - this.DT * this.DT / 6.0) * Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), (object) (this.DT * this.DT / 2.0 * Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))))
            }, (string[]) null);
          }
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 3,
            (object) (Math.Log(2.0) - 4.0 * Math.Pow(this.H, 3.0) / 3.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Log(2.0) - Math.Pow(this.H, 3.0) / 6.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) Math.Log(2.0)
          }, (string[]) null);
          break;
        case 7:
          int lk7 = this.LK;
          for (this.L = 1; this.L <= lk7; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) 2), (object) Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2), (object) Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          int n7 = this.N;
          for (int index = 1; index <= n7; ++index)
          {
            int num2 = this.LK - 3;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 6.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 2.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 3.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), (object) 6.0)), (object) (this.DT * (1.0 - this.DT * this.DT / 6.0) * Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), (object) (this.DT * this.DT * Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))) / 2.0))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) (this.LK - 2),
              (object) (Math.Pow(1.0 + this.T, 2.0) + Math.Cos(1.0) - 2.0 * this.H * (2.0 * (1.0 + this.T) - Math.Sin(1.0)) + 2.0 * (2.0 - Math.Cos(1.0)) * this.H * this.H - 4.0 * Math.Sin(1.0) * Math.Pow(this.H, 3.0) / 3.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Pow(1.0 + this.T, 2.0) + Math.Cos(1.0) - this.H * (2.0 * (1.0 + this.T) - Math.Sin(1.0)) + (2.0 - Math.Cos(1.0)) * this.H * this.H / 2.0 - Math.Sin(1.0) * Math.Pow(this.H, 3.0) / 6.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Cos(1.0) + Math.Pow(1.0 + this.T, 2.0))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num8 = this.LK - 3;
          for (this.L = 1; this.L <= num8; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 6.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 2.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 3.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))), (object) 6.0)), (object) (this.DT * (1.0 - this.DT * this.DT / 6.0) * Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), (object) (this.DT * this.DT * Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))) / 2.0))
            }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) (this.LK - 2),
            (object) (4.0 + Math.Cos(1.0) + 2.0 * this.H * (Math.Sin(1.0) - 4.0) + 2.0 * (2.0 - Math.Cos(1.0)) * this.H * this.H - 4.0 * Math.Sin(1.0) * Math.Pow(this.H, 3.0) / 3.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (4.0 + Math.Cos(1.0) + this.H * (Math.Sin(1.0) - 4.0) + (2.0 - Math.Cos(1.0)) * this.H * this.H / 2.0 - Math.Sin(1.0) * Math.Pow(this.H, 3.0) / 6.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Cos(1.0) + 4.0)
          }, (string[]) null);
          break;
        case 8:
          int lk8 = this.LK;
          for (this.L = 1; this.L <= lk8; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) Math.Cos(Conversions.ToDouble(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 2.0)))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) Math.Cos(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))
            }, (string[]) null);
          }
          do
          {
            int num2 = this.LK - 3;
            for (int index = 1; index <= num2; ++index)
            {
              this.L = this.LK + 1 - index;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 3.0)), Operators.MultiplyObject((object) (2.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) (4.0 * Math.Pow(this.DTX, 3.0) / 3.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 3,
              (object) (Math.Cos(2.0 * this.T) * (1.0 - 2.0 * this.H * this.H) + 2.0 * Math.Sin(2.0 * this.T) * this.H * (1.0 + 2.0 * this.H * this.H / 3.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (Math.Cos(2.0 * this.T) * (1.0 - this.H * this.H / 2.0) + Math.Sin(2.0 * this.T) * this.H * (1.0 + this.H * this.H / 6.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) Math.Cos(2.0 * this.T)
            }, (string[]) null);
            this.DT = 2.0 * this.AK * this.H;
            this.DTX = this.DT / this.H;
          }
          while (this.T + this.DT < 1.0);
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num9 = this.LK - 3;
          for (int index = 1; index <= num9; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 3.0)), Operators.MultiplyObject((object) (2.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) (4.0 * Math.Pow(this.DTX, 3.0) / 3.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 3,
            (object) (Math.Cos(2.0) * (1.0 - 2.0 * this.H * this.H) + 2.0 * Math.Sin(2.0) * this.H * (1.0 + 2.0 * this.H * this.H / 3.0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Cos(2.0) * (1.0 - this.H * this.H / 2.0) + Math.Sin(2.0) * this.H * (1.0 + this.H * this.H / 6.0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) Math.Cos(2.0)
          }, (string[]) null);
          break;
        case 9:
          int lk9 = this.LK;
          for (this.L = 1; this.L <= lk9; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject((object) Math.Sin(Conversions.ToDouble(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0))), Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 8))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject((object) Math.Sin(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 8))
            }, (string[]) null);
          }
          this.DT = this.AK * this.H / 2.0;
          this.DTX = this.DT / this.H;
          this.N = (int) Math.Round(1.0 / this.DT);
          int n8 = this.N;
          for (int index = 1; index <= n8; ++index)
          {
            int num2 = this.LK - 3;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) (2.0 * this.DTX), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 3)), Operators.MultiplyObject((object) (8.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) (32.0 * Math.Pow(this.DTX, 3.0) / 3.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), (object) (2.0 * this.DT * this.DT))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) (this.LK - 2),
              (object) (Math.Sin(1.0 + 4.0 * this.T) * (1.0 - 2.0 * this.H * this.H) + 2.0 * this.H * Math.Cos(1.0 + 4.0 * this.T) * (2.0 * this.H * this.H / 3.0 - 1.0) - 0.125 + this.H / 2.0 - this.H * this.H / 2.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Sin(1.0 + 4.0 * this.T) * (1.0 - this.H * this.H / 2.0) + this.H * Math.Cos(1.0 + 4.0 * this.T) * (this.H * this.H / 6.0 - 1.0) - 0.125 + this.H / 4.0 - this.H * this.H / 8.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Sin(1.0 + 4.0 * this.T) - 0.125)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num10 = this.LK - 3;
          for (this.L = 1; this.L <= num10; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) (2.0 * this.DTX), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 3)), Operators.MultiplyObject((object) (8.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) (32.0 * Math.Pow(this.DTX, 3.0) / 3.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), (object) (2.0 * this.DT * this.DT))
            }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) (this.LK - 2),
            (object) (Math.Sin(5.0) * (1.0 - 2.0 * this.H * this.H) + 2.0 * this.H * Math.Cos(5.0) * (2.0 * this.H * this.H / 3.0 - 1.0) - 0.125 + this.H / 2.0 - this.H * this.H / 2.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Sin(5.0) * (1.0 - this.H * this.H / 2.0) + this.H * Math.Cos(5.0) * (this.H * this.H / 6.0 - 1.0) - 0.125 + this.H / 4.0 - this.H * this.H / 8.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Sin(5.0) - 0.125)
          }, (string[]) null);
          break;
        case 10:
          int lk10 = this.LK;
          for (this.L = 1; this.L <= lk10; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(1.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0)
            }, (string[]) null);
          }
          int n9 = this.N;
          for (int index1 = 1; index1 <= n9; ++index1)
          {
            int num2 = this.LK - 3;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 6.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 2.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 3.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), (object) 6.0)), (object) (this.DT * Math.Exp(this.T) * (1.0 + this.DT / 2.0 + this.DT * this.DT / 6.0)))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 3,
              (object) (Math.Exp(this.T) - this.T + 2.0 * this.H)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (Math.Exp(this.T) - this.T + this.H)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (Math.Exp(this.T) - this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num11 = this.LK - 3;
          for (int index = 1; index <= num11; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 6.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 2.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 3.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))), (object) 6.0)), (object) (this.DT * Math.Exp(this.T) * (1.0 + this.DT / 2.0 + this.DT * this.DT / 6.0)))
            }, (string[]) null);
          }
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 3,
            (object) (Math.Exp(1.0) - 1.0 + 2.0 * this.H)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Exp(1.0) - 1.0 + this.H)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (Math.Exp(1.0) - 1.0)
          }, (string[]) null);
          break;
        case 11:
          int lk11 = this.LK;
          for (this.L = 1; this.L <= lk11; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.SubtractObject(Operators.AddObject(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) 2.0), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(-1.0))), (object) 1.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.AddObject((object) 1.0, Operators.MultiplyObject((object) 0.5, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          do
          {
            int num2 = this.LK - 3;
            for (int index = 1; index <= num2; ++index)
            {
              this.L = this.LK + 1 - index;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 6.0), Operators.AddObject(Operators.SubtractObject((object) Math.Exp(this.T), Operators.MultiplyObject((object) (this.DT * (1.0 - this.DT / 3.0) / 2.0), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(this.T)), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), (object) Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(this.T))), (object) 2.0)), Operators.MultiplyObject(Operators.DivideObject(Operators.ExponentObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(this.T))), (object) 3), (object) 6.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) Math.Exp(this.T))), Operators.MultiplyObject((object) (this.DT / 2.0), Operators.AddObject(Operators.AddObject((object) Math.Exp(2.0 * this.T), Operators.MultiplyObject(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)), (object) Math.Exp(this.T))), Operators.MultiplyObject(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject((object) (this.DT * this.DT), NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)), Operators.AddObject(Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null)), (object) (3.0 * Math.Exp(this.T)))), (object) 6.0))))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 3,
              (object) (-this.T + 2.0 * Math.Exp(-this.T) * this.H + 2.0 * this.H * this.H)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (-this.T + Math.Exp(-this.T) * this.H + this.H * this.H / 2.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) -this.T
            }, (string[]) null);
            this.DT = this.AK * this.H / Math.Exp(this.T);
            this.DTX = this.DT / this.H;
          }
          while (this.T + this.DT < 1.0);
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num12 = this.LK - 3;
          for (int index = 1; index <= num12; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 6.0), Operators.AddObject(Operators.SubtractObject((object) Math.Exp(this.T), Operators.MultiplyObject((object) (this.DT * (1.0 - this.DT / 3.0) / 2.0), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(this.T)), Operators.MultiplyObject((object) this.DT, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))), (object) Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(this.T))), (object) 2.0)), Operators.MultiplyObject(Operators.DivideObject(Operators.ExponentObject(Operators.MultiplyObject((object) this.DTX, Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(this.T))), (object) 3), (object) 6.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), Operators.MultiplyObject((object) this.DT, Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(this.T))), Operators.MultiplyObject((object) (this.DT / 2.0), Operators.AddObject(Operators.AddObject((object) Math.Exp(2.0 * this.T), Operators.MultiplyObject(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) Math.Exp(this.T))), Operators.MultiplyObject(Operators.MultiplyObject((object) 2.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject((object) (this.DT * this.DT), NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), Operators.AddObject(Operators.MultiplyObject((object) 4.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)), (object) (3.0 * Math.Exp(this.T)))), (object) 6.0))))
            }, (string[]) null);
          }
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 3,
            (object) (2.0 * Math.Exp(-1.0) * this.H - 1.0 + 2.0 * this.H * this.H)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Exp(-1.0) * this.H - 1.0 + this.H * this.H / 2.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) -1.0
          }, (string[]) null);
          break;
        case 12:
          int lk12 = this.LK;
          for (this.L = 1; this.L <= lk12; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.MultiplyObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2), (object) Math.Exp(2.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2)
            }, (string[]) null);
          }
          int n10 = this.N;
          for (int index = 1; index <= n10; ++index)
          {
            int num2 = this.LK - 3;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 6.0), (object) (1.0 + this.DT / 2.0 * (1.0 + this.DT / 3.0))), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) (1.0 + this.DT), Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0), (object) 2)), (object) Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 2.0)), Operators.MultiplyObject(Operators.MultiplyObject((object) (Math.Pow(this.DTX, 3.0) / 6.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
                {
                  (object) this.L
                }, (string[]) null), (object) 4.0), (object) 3)))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) (this.LK - 2),
              (object) ((25.0 - 20.0 * this.H + 4.0 * this.H * this.H) * Math.Exp(2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) ((25.0 - 10.0 * this.H + this.H * this.H) * Math.Exp(2.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (25.0 * Math.Exp(2.0 * this.T))
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num13 = this.LK - 3;
          for (this.L = 1; this.L <= num13; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 6.0), (object) (1.0 + this.DT / 2.0 * (1.0 + this.DT / 3.0))), Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) (1.0 + this.DT), Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 2)), (object) Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 2.0)), Operators.MultiplyObject(Operators.MultiplyObject((object) (Math.Pow(this.DTX, 3.0) / 6.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))), Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 4.0), (object) 3)))
            }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) (this.LK - 2),
            (object) ((25.0 - 20.0 * this.H + 4.0 * this.H * this.H) * Math.Exp(2.0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) ((25.0 - 10.0 * this.H + this.H * this.H) * Math.Exp(2.0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (25.0 * Math.Exp(2.0))
          }, (string[]) null);
          break;
        case 13:
          int lk13 = this.LK;
          for (this.L = 1; this.L <= lk13; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) Math.Exp(1.0)), (object) 2), (object) 0.5)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.ExponentObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) 2)
            }, (string[]) null);
          }
          do
          {
            int num2 = this.LK - 3;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 6.0), (object) Math.Exp(this.T)), (object) (1.0 + this.DT / 2.0 * (1.0 + this.DT / 3.0)))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) Math.Exp(2.0 * this.T)), (object) (1.0 + this.DT)), (object) 2.0)), Operators.MultiplyObject(Operators.MultiplyObject((object) (Math.Pow(this.DTX, 3.0) / 6.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), (object) Math.Exp(3.0 * this.T))), (object) (this.DT * (this.T + this.DT / 2.0)))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) (this.LK - 2),
              (object) (Math.Pow(1.0 + Math.Exp(this.T), 2.0) + this.T * this.T / 2.0 - 4.0 * (1.0 + Math.Exp(this.T)) * this.H + 4.0 * this.H * this.H)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Pow(1.0 + Math.Exp(this.T), 2.0) + this.T * this.T / 2.0 - 2.0 * (1.0 + Math.Exp(this.T)) * this.H + this.H * this.H)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Pow(1.0 + Math.Exp(this.T), 2.0) + this.T * this.T / 2.0)
            }, (string[]) null);
            this.DT = this.AK * this.H / Math.Exp(this.T);
            this.DTX = this.DT / this.H;
          }
          while (this.T + this.DT < 1.0);
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num14 = this.LK - 3;
          for (this.L = 1; this.L <= num14; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject(Operators.MultiplyObject(Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 6.0), (object) Math.Exp(this.T)), (object) (1.0 + this.DT / 2.0 * (1.0 + this.DT / 3.0)))), Operators.DivideObject(Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) Math.Exp(2.0 * this.T)), (object) (1.0 + this.DT)), (object) 2.0)), Operators.MultiplyObject(Operators.MultiplyObject((object) (Math.Pow(this.DTX, 3.0) / 6.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))), (object) Math.Exp(3.0 * this.T))), (object) (this.DT * (this.T + this.DT / 2.0)))
            }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) (this.LK - 2),
            (object) (Math.Pow(1.0 + Math.Exp(1.0), 2.0) + 0.5 - 4.0 * (1.0 + Math.Exp(1.0)) * this.H + 4.0 * this.H * this.H)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Pow(1.0 + Math.Exp(1.0), 2.0) + 0.5 - 2.0 * (1.0 + Math.Exp(1.0)) * this.H + this.H * this.H)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Pow(1.0 + Math.Exp(1.0), 2.0) + 0.5)
          }, (string[]) null);
          break;
        case 14:
          int lk14 = this.LK;
          for (this.L = 1; this.L <= lk14; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) (Math.Exp(Conversions.ToDouble(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 8.0))) + 0.5)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) Math.Exp(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null)))
            }, (string[]) null);
          }
          this.DT = this.AK * this.H / 4.0;
          this.DTX = this.DT / this.H;
          this.N = (int) Math.Round(1.0 / this.DT);
          int n11 = this.N;
          for (int index1 = 1; index1 <= n11; ++index1)
          {
            int num2 = this.LK - 3;
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              this.L = this.LK + 1 - index2;
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) (4.0 * this.DTX), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 3.0)), Operators.MultiplyObject((object) (32.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) (256.0 * Math.Pow(this.DTX, 3.0) / 3.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L - 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) (this.DT * this.T)), (object) (this.DT * this.DT / 2.0))
              }, (string[]) null);
            }
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 3,
              (object) (Math.Exp(-8.0 * this.T) * (1.0 + 2.0 * this.H + 2.0 * this.H * this.H + 4.0 * this.H * this.H * this.H / 3.0) + this.T * this.T / 2.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 2,
              (object) (Math.Exp(-8.0 * this.T) * (1.0 + this.H + this.H * this.H / 2.0 + this.H * this.H * this.H / 6.0) + this.T * this.T / 2.0)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) 1,
              (object) (Math.Exp(-8.0 * this.T) + this.T * this.T / 2.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num15 = this.LK - 3;
          for (int index = 1; index <= num15; ++index)
          {
            this.L = this.LK + 1 - index;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) (4.0 * this.DTX), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 3.0)), Operators.MultiplyObject((object) (32.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) (256.0 * Math.Pow(this.DTX, 3.0) / 3.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L - 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) (this.DT * this.T)), (object) (this.DT * this.DT / 2.0))
            }, (string[]) null);
          }
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 3,
            (object) (Math.Exp(-8.0) * (1.0 + 2.0 * this.H + 2.0 * this.H * this.H + 4.0 * this.H * this.H * this.H / 3.0) + 0.5)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 2,
            (object) (Math.Exp(-8.0) * (1.0 + this.H + this.H * this.H / 2.0 + this.H * this.H * this.H / 6.0) + 0.5)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) 1,
            (object) (Math.Exp(-8.0) + 0.5)
          }, (string[]) null);
          break;
        case 15:
          int lk15 = this.LK;
          for (this.L = 1; this.L <= lk15; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0), (object) Math.Exp(1.0))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null), (object) 1.0)
            }, (string[]) null);
          }
          int n12 = this.N;
          for (int index = 1; index <= n12; ++index)
          {
            int num2 = this.LK - 3;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 6.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null)))), (object) 2.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 3.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))), (object) 6.0)), (object) (this.DT * Math.Exp(this.T) * (1.0 + this.DT / 2.0 + this.DT * this.DT / 6.0)))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) (this.LK - 2),
              (object) (Math.Exp(this.T) + this.T + 1.0 - 2.0 * this.H)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Exp(this.T) + this.T + 1.0 - this.H)
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) (Math.Exp(this.T) + this.T + 1.0)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num16 = this.LK - 3;
          for (this.L = 1; this.L <= num16; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 6.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 2.0), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null)))), (object) 2.0)), Operators.DivideObject(Operators.MultiplyObject((object) Math.Pow(this.DTX, 3.0), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))), (object) 6.0)), (object) (this.DT * Math.Exp(this.T) * (1.0 + this.DT / 2.0 + this.DT * this.DT / 6.0)))
            }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) (this.LK - 2),
            (object) (Math.Exp(1.0) + 2.0 - 2.0 * this.H)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Exp(1.0) + 2.0 - this.H)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) (Math.Exp(1.0) + 2.0)
          }, (string[]) null);
          break;
        case 16:
          int lk16 = this.LK;
          for (this.L = 1; this.L <= lk16; ++this.L)
          {
            NewLateBinding.LateIndexSet((object) this.UA, new object[2]
            {
              (object) this.L,
              (object) Math.Log(Conversions.ToDouble(Operators.AddObject((object) 7.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              (object) Math.Log(Conversions.ToDouble(Operators.AddObject((object) 1.0, NewLateBinding.LateIndexGet((object) this.X, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          }
          this.DT = this.AK * this.H / 3.0;
          this.DTX = this.DT / this.H;
          this.N = (int) Math.Round(1.0 / this.DT);
          int n13 = this.N;
          for (int index = 1; index <= n13; ++index)
          {
            int num2 = this.LK - 3;
            for (this.L = 1; this.L <= num2; ++this.L)
              NewLateBinding.LateIndexSet((object) this.UM, new object[2]
              {
                (object) this.L,
                Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null), Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) (18.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))), Operators.MultiplyObject((object) (36.0 * Math.Pow(this.DTX, 3.0)), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 3)
                }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 2)
                }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) (this.L + 1)
                }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
                {
                  (object) this.L
                }, (string[]) null))))
              }, (string[]) null);
            this.T += this.DT;
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) (this.LK - 2),
              (object) (Math.Log(2.0 + 6.0 * this.T) - 2.0 * this.H * (1.0 + this.H / (2.0 + 6.0 * this.T) + 4.0 * this.H * this.H / (3.0 * Math.Pow(2.0 + 6.0 * this.T, 2.0))) / (2.0 + 6.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK1,
              (object) (Math.Log(2.0 + 6.0 * this.T) - this.H * (1.0 + this.H / (2.0 * (2.0 + 6.0 * this.T)) + this.H * this.H / (3.0 * Math.Pow(2.0 + 6.0 * this.T, 2.0))) / (2.0 + 6.0 * this.T))
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.LK,
              (object) Math.Log(2.0 + 6.0 * this.T)
            }, (string[]) null);
          }
          this.DT = 1.0 - this.T;
          this.DTX = this.DT / this.H;
          int num17 = this.LK - 3;
          for (this.L = 1; this.L <= num17; ++this.L)
            NewLateBinding.LateIndexSet((object) this.UM, new object[2]
            {
              (object) this.L,
              Operators.AddObject(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null), Operators.MultiplyObject((object) this.DTX, Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 9, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 18, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 11, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) (18.0 * Math.Pow(this.DTX, 2.0)), Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null)), Operators.MultiplyObject((object) 4, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 5, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), Operators.MultiplyObject((object) 2, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))), Operators.MultiplyObject((object) (36.0 * Math.Pow(this.DTX, 3.0)), Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 3)
              }, (string[]) null), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 2)
              }, (string[]) null))), Operators.MultiplyObject((object) 3, NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) (this.L + 1)
              }, (string[]) null))), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
              {
                (object) this.L
              }, (string[]) null))))
            }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) (this.LK - 2),
            (object) (Math.Log(8.0) - this.H * (2.0 + this.H / 4.0 + this.H * this.H / 24.0) / 8.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK1,
            (object) (Math.Log(8.0) - this.H * (1.0 + this.H / 16.0 + this.H * this.H / 192.0) / 8.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) this.LK,
            (object) Math.Log(8.0)
          }, (string[]) null);
          break;
      }
    }
  }
}
