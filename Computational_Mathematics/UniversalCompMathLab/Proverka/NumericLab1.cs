// Decompiled with JetBrains decompiler
// Type: Proverka.NumericLab1
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using Proverka.My;
using System;
using System.Runtime.CompilerServices;

namespace Proverka
{
  public class NumericLab1
  {
    private MyUtils ut;
    public MainFormLab1 MyForm;
    private double G0;
    private double R0;
    private double U0;
    private double P0;
    private double C0;
    private double D0;
    private double G1;
    private double R1;
    private double U1;
    private double P1;
    private double C1;
    private double D1;
    private double G3;
    private double R3;
    private double U3;
    private double P3;
    private double C3;
    private double D3;
    private double H;
    private double NW;
    private double Y;
    private double Z0;
    private double Z1;
    private double SG0;
    private double SG3;
    private double H0;
    private double H3;
    private double A0;
    private double A1;
    private double A3;
    private double VV;
    private double DE;
    private double P2;
    private double R2;
    private double U2;
    private double C2;
    private double E1;
    private double E0;
    private double X;
    private double B0;
    private double B3;
    private double DE0;
    private double DE3;
    private double H01;
    private double H31;
    public int NK;
    public int varNo;
    public Array Z;
    public Array roots;
    public Array V;
    public Array solution;

    public NumericLab1()
    {
      this.ut = new MyUtils();
      this.Z = Array.CreateInstance(typeof (double), 8);
      this.roots = Array.CreateInstance(typeof (double), 7);
      this.V = Array.CreateInstance(typeof (double), 3, 7);
      this.solution = Array.CreateInstance(typeof (double), 7, 15);
    }

    public void Calculate(ref MainFormLab1 sender)
    {
      this.MyForm = MyProject.Forms.MainFormLab1;
      this.varNo = this.MyForm.varNo;
      this.NK = 0;
      this.H = 0.01;
      if (this.varNo == 1 & this.MyForm.taskNo == 1)
        this.H = 1E-05;
      switch (this.varNo)
      {
        case 1:
          this.C0 = Math.Sqrt(this.G0 * this.P0 / this.R0);
          this.C1 = Math.Sqrt(this.G1 * this.P1 / this.R1);
          break;
        case 2:
          this.C0 = Math.Sqrt(this.G0 * this.P0 / this.R0);
          this.R1 = this.G1 * this.P1 / (this.C1 * this.C1);
          break;
      }
      this.CalculateCoeffs();
      this.Localization();
      this.CalculateRoots(1E-07);
      this.FinalSolution();
    }

    public void InitParam(int paramNo, string val, ref MainFormLab1 sender)
    {
      switch (sender.varNo)
      {
        case 1:
          switch (paramNo)
          {
            case 1:
              this.G0 = this.ut.MyStrToDbl(val);
              return;
            case 2:
              this.R0 = this.ut.MyStrToDbl(val);
              return;
            case 3:
              this.U0 = this.ut.MyStrToDbl(val);
              return;
            case 4:
              this.P0 = this.ut.MyStrToDbl(val);
              return;
            case 5:
              this.G1 = this.ut.MyStrToDbl(val);
              return;
            case 6:
              this.R1 = this.ut.MyStrToDbl(val);
              return;
            case 7:
              this.U1 = this.ut.MyStrToDbl(val);
              return;
            case 8:
              this.P1 = this.ut.MyStrToDbl(val);
              return;
            default:
              return;
          }
        case 2:
          switch (paramNo)
          {
            case 1:
              this.G0 = this.ut.MyStrToDbl(val);
              return;
            case 2:
              this.R0 = this.ut.MyStrToDbl(val);
              return;
            case 3:
              this.P0 = this.ut.MyStrToDbl(val);
              return;
            case 4:
              this.U0 = this.ut.MyStrToDbl(val);
              return;
            case 5:
              this.G1 = this.ut.MyStrToDbl(val);
              return;
            case 6:
              this.C1 = this.ut.MyStrToDbl(val);
              return;
            case 7:
              this.P1 = this.ut.MyStrToDbl(val);
              return;
            case 8:
              this.U1 = this.ut.MyStrToDbl(val);
              return;
            default:
              return;
          }
        case 3:
        case 4:
          switch (paramNo)
          {
            case 1:
              this.G0 = this.ut.MyStrToDbl(val);
              return;
            case 2:
              this.R0 = this.ut.MyStrToDbl(val);
              return;
            case 3:
              this.U0 = this.ut.MyStrToDbl(val);
              return;
            case 4:
              this.P0 = this.ut.MyStrToDbl(val);
              return;
            case 5:
              this.C0 = this.ut.MyStrToDbl(val);
              return;
            case 6:
              this.G3 = this.ut.MyStrToDbl(val);
              return;
            case 7:
              this.R3 = this.ut.MyStrToDbl(val);
              return;
            case 8:
              this.U3 = this.ut.MyStrToDbl(val);
              return;
            case 9:
              this.P3 = this.ut.MyStrToDbl(val);
              return;
            case 10:
              this.C3 = this.ut.MyStrToDbl(val);
              return;
            default:
              return;
          }
      }
    }

    public void CalculateCoeffs()
    {
      switch (this.varNo)
      {
        case 1:
          this.DE = Math.Pow(this.U1 - this.U0, 2.0) / 2.0;
          this.E0 = this.P0 / ((this.G0 - 1.0) * this.R0 * this.DE);
          this.E1 = this.P1 / ((this.G1 - 1.0) * this.R1 * this.DE);
          this.A0 = (this.G0 + 1.0) / (this.G0 - 1.0);
          this.A1 = (this.G1 + 1.0) / (this.G1 - 1.0);
          this.X = this.P1 / this.P0;
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 1,
            (object) Math.Pow(this.A0 * this.E1 - this.A1 * this.E0 * this.X, 2.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 2,
            (object) (2.0 * ((this.E1 * this.A0 - this.E0 * this.A1 * this.X) * (this.E1 * (1.0 - 2.0 * this.A0 * this.X) - this.E0 * this.X * (this.X - 2.0 * this.A1)) - this.A0 * this.A1 * this.X * (this.E1 * this.A0 + this.E0 * this.A1 * this.X)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 3,
            (object) (Math.Pow(this.E1, 2.0) * (6.0 * Math.Pow(this.A0, 2.0) * Math.Pow(this.X, 2.0) - 8.0 * this.A0 * this.X + 1.0) - 2.0 * this.E0 * this.E1 * this.X * (this.A0 * this.A1 * (Math.Pow(this.X, 2.0) + 4.0 * this.X + 1.0) - 2.0 * (this.X + 1.0) * (this.A1 + this.A0 * this.X) + this.X) + this.E0 * this.E0 * Math.Pow(this.X, 2.0) * (6.0 * Math.Pow(this.A1, 2.0) - 8.0 * this.A1 * this.X + Math.Pow(this.X, 2.0)) + Math.Pow(this.A0, 2.0) * this.A1 * this.A1 * Math.Pow(this.X, 2.0) - 2.0 * this.E1 * this.X * this.A0 * (this.A0 * this.X - 2.0 * this.A0 * this.A1 * this.X + 2.0 * this.A1) - 2.0 * this.E0 * this.A1 * Math.Pow(this.X, 2.0) * (this.A1 + 2.0 * this.A0 * this.X - 2.0 * this.A0 * this.A1))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 4,
            (object) (-2.0 * this.X * (2.0 * Math.Pow(this.E1, 2.0) * (Math.Pow(this.A0, 2.0) * Math.Pow(this.X, 2.0) - 3.0 * this.A0 * this.X + 1.0) + this.E0 * this.E1 * ((this.A1 + this.A0 * this.X) * (Math.Pow(this.X, 2.0) + 4.0 * this.X + 1.0) - 2.0 * this.A0 * this.A1 * this.X * (this.X + 1.0) - 2.0 * this.X * (this.X + 1.0)) + 2.0 * this.E0 * this.E0 * this.X * (Math.Pow(this.X, 2.0) - 3.0 * this.A1 * this.X + this.A1 * this.A1) - this.A0 * this.A1 * this.X * (this.A0 * this.X + this.A1) + this.E1 * (Math.Pow(this.A0, 2.0) * this.A1 * this.X * this.X - 2.0 * this.X * (2.0 * this.A0 * this.A1 + Math.Pow(this.A0, 2.0) * this.X) + 2.0 * this.A0 * this.X + this.A1) + this.E0 * this.X * (this.A0 * this.A1 * this.A1 - 2.0 * this.A1 * (this.A1 + 2.0 * this.A0 * this.X) + 2.0 * this.A1 * this.X + this.A0 * Math.Pow(this.X, 2.0))))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 5,
            (object) (Math.Pow(this.X, 2.0) * (Math.Pow(this.E1, 2.0) * (Math.Pow(this.A0, 2.0) * Math.Pow(this.X, 2.0) - 8.0 * this.A0 * this.X + 6.0) - 2.0 * this.E0 * this.E1 * (this.A0 * this.A1 * this.X - 2.0 * (this.X + 1.0) * (this.A1 + this.A0 * this.X) + Math.Pow(this.X, 2.0) + 4.0 * this.X + 1.0) + Math.Pow(this.E0, 2.0) * (this.A1 * this.A1 - 8.0 * this.A1 * this.X + 6.0 * Math.Pow(this.X, 2.0)) + Math.Pow(this.A1, 2.0) + 4.0 * this.A0 * this.A1 * this.X + Math.Pow(this.A0, 2.0) * Math.Pow(this.X, 2.0) - 2.0 * this.E1 * (this.X * (Math.Pow(this.A0, 2.0) * this.X + 2.0 * this.A0 * this.A1) - 2.0 * (2.0 * this.A0 * this.X + this.A1) + 1.0) - 2.0 * this.E0 * (this.A1 * (this.A1 + 2.0 * this.A0 * this.X) - 2.0 * this.X * (2.0 * this.A1 + this.A0 * this.X) + Math.Pow(this.X, 2.0))))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 6,
            (object) (2.0 * Math.Pow(this.X, 3.0) * (Math.Pow(this.E1, 2.0) * (this.A0 * this.X - 2.0) - this.E0 * this.E1 * (this.A0 * this.X - 2.0 + this.A1 - 2.0 * this.X) + Math.Pow(this.E0, 2.0) * (this.A1 - 2.0 * this.X) + this.A1 + this.A0 * this.X - this.E1 * (2.0 * this.A0 * this.X + this.A1 - 2.0) - this.E0 * (2.0 * this.A1 + this.A0 * this.X - 2.0 * this.X)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 7,
            (object) (Math.Pow(this.X, 4.0) * (Math.Pow(this.E1 - this.E0, 2.0) - 2.0 * (this.E1 + this.E0) + 1.0))
          }, (string[]) null);
          break;
        case 2:
          this.NW = 2.0 * this.G1 / (this.G1 - 1.0);
          this.A0 = (this.G0 + 1.0) / (this.G0 - 1.0);
          this.B0 = (this.G0 - 1.0) / 2.0;
          this.DE = (this.U1 - this.U0) * Math.Sqrt(this.B0 * this.R0 / this.P0);
          this.E0 = 2.0 * Math.Sqrt(this.G1 * this.B0 * this.P1 * this.R0 / (this.R1 * this.P0)) / (this.G1 - 1.0);
          this.X = this.P1 / this.P0;
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 1,
            (object) (this.X * this.X)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 2,
            (object) (-this.A0 * this.E0 * this.E0 * this.X)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 3,
            (object) (2.0 * this.A0 * this.E0 * this.X * (this.DE + this.E0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 4,
            (object) (-(2.0 + this.A0 * Math.Pow(this.DE + this.E0, 2.0)) * this.X)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 5,
            (object) (-this.E0 * this.E0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 6,
            (object) (2.0 * this.E0 * (this.DE + this.E0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 7,
            (object) (1.0 - Math.Pow(this.DE + this.E0, 2.0))
          }, (string[]) null);
          break;
        case 3:
          this.VV = this.R0 * this.R3 * (this.U0 - this.U3) * (this.U0 - this.U3);
          this.DE = this.P0 / this.VV;
          this.H0 = (this.G0 + 1.0) / (this.G0 - 1.0);
          this.DE0 = (this.H0 - 1.0) * this.R3;
          this.A0 = this.R0 * this.C0 * this.C0 * (this.H0 - 1.0);
          this.B0 = this.A0 / this.VV;
          this.H3 = (this.G3 + 1.0) / (this.G3 - 1.0);
          this.DE3 = (this.H3 - 1.0) * this.R0;
          this.A3 = this.R3 * this.C3 * this.C3 * (this.H3 - 1.0);
          this.B3 = this.A3 / this.VV;
          this.X = this.P3 / this.VV;
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 1,
            (object) Math.Pow(this.DE0 * this.H3 - this.DE3 * this.H0, 2.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 2,
            (object) (2.0 * (this.H3 * Math.Pow(this.DE0, 2.0) * (this.B3 - this.DE * this.H3) + this.H0 * Math.Pow(this.DE3, 2.0) * (this.B0 - this.X * this.H0) - this.H0 * this.H3 * (this.DE0 * this.H3 + this.DE3 * this.H0) - this.DE0 * this.DE3 * (this.H0 * this.B3 + this.H3 * this.B0) + this.DE0 * this.DE3 * this.H0 * this.H3 * (this.X + this.DE)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 3,
            (object) (Math.Pow(this.H0 * this.H3, 2.0) + Math.Pow(this.DE0, 2.0) * (Math.Pow(this.H3 * this.DE, 2.0) + this.B3 * this.B3 - 4.0 * this.B3 * this.H3 * this.DE) + Math.Pow(this.DE3, 2.0) * (this.B0 * this.B0 + Math.Pow(this.H0 * this.X, 2.0) - 4.0 * this.B0 * this.X * this.H0) - 2.0 * this.DE0 * this.H3 * (2.0 * this.B3 * this.H0 + this.H3 * this.B0 - this.DE * this.H0 * this.H3) - 2.0 * this.DE3 * this.H0 * (2.0 * this.B0 * this.H3 + this.H0 * this.B3 - this.H0 * this.H3 * this.X) - 2.0 * this.DE0 * this.DE3 * (this.X * this.DE * this.H0 * this.H3 + this.B0 * this.B3) + 2.0 * this.DE0 * this.DE3 * (this.X + this.DE) * (this.B3 * this.H0 + this.H3 * this.B0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 4,
            (object) (2.0 * (this.H0 * this.H3 * (this.B0 * this.H3 + this.B3 * this.H0) + Math.Pow(this.DE0, 2.0) * this.DE * this.B3 * (this.H3 * this.DE - this.B3) + Math.Pow(this.DE3, 2.0) * this.B0 * this.X * (this.X * this.H0 - this.B0) - this.DE0 * (this.H0 * this.B3 * this.B3 - this.DE * this.B0 * Math.Pow(this.H3, 2.0)) - 2.0 * this.DE0 * this.H3 * this.B3 * (this.B0 - this.DE * this.H0) - this.DE3 * (this.H3 * this.B0 * this.B0 - this.X * this.B3 * Math.Pow(this.H0, 2.0)) - 2.0 * this.DE3 * this.B0 * this.H0 * (this.B3 - this.X * this.H3) - this.DE * this.DE0 * this.DE3 * this.X * (this.H0 * this.B3 + this.H3 * this.B0) + this.DE0 * this.DE3 * this.B0 * this.B3 * (this.X + this.DE)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 5,
            (object) (Math.Pow(this.B0 * this.H3, 2.0) + Math.Pow(this.B3 * this.H0, 2.0) + 4.0 * this.B0 * this.B3 * this.H0 * this.H3 + Math.Pow(this.DE0 * this.B3 * this.DE, 2.0) + Math.Pow(this.DE3 * this.B0 * this.X, 2.0) - 2.0 * this.DE0 * (this.B0 * Math.Pow(this.B3, 2.0) - this.DE * Math.Pow(this.B3, 2.0) * this.H0 - 2.0 * this.DE * this.H3 * this.B0 * this.B3) - 2.0 * this.DE3 * this.B0 * (this.B0 * (this.B3 - this.X * this.H3) - 2.0 * this.B3 * this.X * this.H0) - 2.0 * this.DE * this.DE0 * this.DE3 * this.B0 * this.B3 * this.X)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 6,
            (object) (2.0 * (this.B0 * this.B3 * (this.B0 * this.H3 + this.B3 * this.H0) + this.B0 * this.B3 * (this.DE0 * this.DE * this.B3 + this.DE3 * this.X * this.B0)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 7,
            (object) Math.Pow(this.B0 * this.B3, 2.0)
          }, (string[]) null);
          break;
        case 4:
          this.DE = this.R0 * Math.Pow(this.U0 - this.U3, 2.0);
          this.H0 = (this.G0 + 1.0) / (this.G0 - 1.0);
          this.H01 = this.H0 - 1.0;
          this.A0 = this.R0 * this.C0 * this.C0 * this.H01;
          this.B0 = this.A0 / this.DE;
          this.H3 = (this.G3 + 1.0) / (this.G3 - 1.0);
          this.H31 = this.H3 - 1.0;
          this.A3 = this.R3 * this.C3 * this.C3 * this.H31;
          this.B3 = this.A3 / this.DE;
          this.X = this.R3 / this.R0;
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 1,
            (object) Math.Pow(this.H01 * this.H3 * this.X - this.H31 * this.H0, 2.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 2,
            (object) (2.0 * (Math.Pow(this.H01 * this.X, 2.0) * this.H3 * this.B3 + Math.Pow(this.H31, 2.0) * this.H0 * this.B0 - this.H01 * this.H0 * Math.Pow(this.H3 * this.X, 2.0) - this.H31 * this.H3 * this.X * Math.Pow(this.H0, 2.0) - this.H01 * this.H31 * this.X * (this.B0 * this.H3 + this.H0 * this.B3)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 3,
            (object) (Math.Pow(this.H0 * this.H3 * this.X, 2.0) + Math.Pow(this.H01 * this.B3 * this.X, 2.0) + Math.Pow(this.H31 * this.B0, 2.0) - 2.0 * this.H01 * this.H3 * Math.Pow(this.X, 2.0) * (this.H3 * this.B0 + 2.0 * this.H0 * this.B3) - 2.0 * this.H31 * this.H0 * this.X * (this.H0 * this.B3 + 2.0 * this.H3 * this.B0) - 2.0 * this.H01 * this.H31 * this.X * this.B0 * this.B3)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 4,
            (object) (2.0 * (this.H0 * this.H3 * Math.Pow(this.X, 2.0) * (this.H3 * this.B0 + this.H0 * this.B3) - this.H01 * Math.Pow(this.X, 2.0) * this.B3 * (this.H0 * this.B3 + 2.0 * this.H3 * this.B0) - this.H31 * this.X * this.B0 * (this.H3 * this.B0 + 2.0 * this.H0 * this.B3)))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 5,
            (object) (Math.Pow(this.X, 2.0) * (Math.Pow(this.B0 * this.H3, 2.0) + Math.Pow(this.H0 * this.B3, 2.0) + 4.0 * this.H0 * this.H3 * this.B0 * this.B3) - 2.0 * (this.H01 * this.B0 * Math.Pow(this.X * this.B3, 2.0) + this.H31 * this.X * this.B3 * this.B0 * this.B0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 6,
            (object) (2.0 * Math.Pow(this.X, 2.0) * this.B0 * this.B3 * (this.H0 * this.B3 + this.H3 * this.B0))
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.Z, new object[2]
          {
            (object) 7,
            (object) Math.Pow(this.X * this.B0 * this.B3, 2.0)
          }, (string[]) null);
          break;
      }
    }

    private void Localization()
    {
      int num1 = 0;
      Type Type1 = typeof (Math);
      object[] objArray1 = new object[1];
      object[] objArray2 = objArray1;
      Array z1 = this.Z;
      object[] objArray3 = new object[1];
      object[] objArray4 = objArray3;
      int num2 = 1;
      // ISSUE: variable of a boxed type
      __Boxed<int> local1 = (ValueType) num2;
      objArray4[0] = (object) local1;
      object[] Arguments1 = objArray3;
      object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) z1, Arguments1, (string[]) null));
      objArray2[0] = objectValue1;
      object[] objArray5 = objArray1;
      object[] Arguments2 = objArray5;
      bool[] flagArray1 = new bool[1]{ true };
      bool[] CopyBack1 = flagArray1;
      object obj1 = NewLateBinding.LateGet((object) null, Type1, "Sign", Arguments2, (string[]) null, (Type[]) null, CopyBack1);
      if (flagArray1[0])
        NewLateBinding.LateIndexSetComplex((object) this.Z, new object[2]
        {
          (object) num2,
          RuntimeHelpers.GetObjectValue(objArray5[0])
        }, (string[]) null, true, false);
      int num3 = Conversions.ToInteger(obj1);
      int num4 = 2;
      do
      {
        // ISSUE: variable of a boxed type
        __Boxed<int> local2 = (ValueType) num3;
        Type Type2 = typeof (Math);
        object[] objArray6 = new object[1]
        {
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) num4
          }, (string[]) null))
        };
        object[] Arguments3 = objArray6;
        bool[] flagArray2 = new bool[1]{ true };
        bool[] CopyBack2 = flagArray2;
        object Right = NewLateBinding.LateGet((object) null, Type2, "Sign", Arguments3, (string[]) null, (Type[]) null, CopyBack2);
        if (flagArray2[0])
          NewLateBinding.LateIndexSetComplex((object) this.Z, new object[2]
          {
            (object) num4,
            RuntimeHelpers.GetObjectValue(objArray6[0])
          }, (string[]) null, true, false);
        if (Operators.ConditionalCompareObjectLess(Operators.MultiplyObject((object) local2, Right), (object) 0, false))
        {
          num3 = -num3;
          ++num1;
        }
        ++num4;
      }
      while (num4 <= 7);
      int num5 = 1;
      int num6;
      do
      {
        Type Type2 = typeof (Math);
        object[] objArray6 = new object[1]
        {
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) num5
          }, (string[]) null))
        };
        object[] Arguments3 = objArray6;
        bool[] flagArray2 = new bool[1]{ true };
        bool[] CopyBack2 = flagArray2;
        object Left = NewLateBinding.LateGet((object) null, Type2, "Abs", Arguments3, (string[]) null, (Type[]) null, CopyBack2);
        if (flagArray2[0])
          NewLateBinding.LateIndexSetComplex((object) this.Z, new object[2]
          {
            (object) num5,
            RuntimeHelpers.GetObjectValue(objArray6[0])
          }, (string[]) null, true, false);
        // ISSUE: variable of a boxed type
        __Boxed<double> local2 = (ValueType) 0.0;
        if (Operators.ConditionalCompareObjectGreater(Left, (object) local2, false))
        {
          num6 = num5;
          break;
        }
        ++num5;
      }
      while (num5 <= 7);
      Type Type3 = typeof (Math);
      object[] objArray7 = new object[1];
      object[] objArray8 = objArray7;
      Array z2 = this.Z;
      object[] objArray9 = new object[1];
      object[] objArray10 = objArray9;
      int num7 = 7;
      // ISSUE: variable of a boxed type
      __Boxed<int> local3 = (ValueType) num7;
      objArray10[0] = (object) local3;
      object[] Arguments4 = objArray9;
      object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) z2, Arguments4, (string[]) null));
      objArray8[0] = objectValue2;
      object[] objArray11 = objArray7;
      object[] Arguments5 = objArray11;
      bool[] flagArray3 = new bool[1]{ true };
      bool[] CopyBack3 = flagArray3;
      object obj2 = NewLateBinding.LateGet((object) null, Type3, "Abs", Arguments5, (string[]) null, (Type[]) null, CopyBack3);
      if (flagArray3[0])
        NewLateBinding.LateIndexSetComplex((object) this.Z, new object[2]
        {
          (object) num7,
          RuntimeHelpers.GetObjectValue(objArray11[0])
        }, (string[]) null, true, false);
      double num8 = Conversions.ToDouble(obj2);
      double num9 = num8;
      for (int index = num6 + 1; index <= 6; ++index)
      {
        Type Type2 = typeof (Math);
        object[] objArray6 = new object[1]
        {
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) index
          }, (string[]) null))
        };
        object[] Arguments3 = objArray6;
        bool[] flagArray2 = new bool[1]{ true };
        bool[] CopyBack2 = flagArray2;
        object obj3 = NewLateBinding.LateGet((object) null, Type2, "Abs", Arguments3, (string[]) null, (Type[]) null, CopyBack2);
        if (flagArray2[0])
          NewLateBinding.LateIndexSetComplex((object) this.Z, new object[2]
          {
            (object) index,
            RuntimeHelpers.GetObjectValue(objArray6[0])
          }, (string[]) null, true, false);
        double num10 = Conversions.ToDouble(obj3);
        if (num8 < num10)
          num8 = num10;
      }
      Type Type4 = typeof (Math);
      object[] objArray12 = new object[1]
      {
        RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
        {
          (object) num6
        }, (string[]) null))
      };
      object[] Arguments6 = objArray12;
      bool[] flagArray4 = new bool[1]{ true };
      bool[] CopyBack4 = flagArray4;
      object obj4 = NewLateBinding.LateGet((object) null, Type4, "Abs", Arguments6, (string[]) null, (Type[]) null, CopyBack4);
      if (flagArray4[0])
        NewLateBinding.LateIndexSetComplex((object) this.Z, new object[2]
        {
          (object) num6,
          RuntimeHelpers.GetObjectValue(objArray12[0])
        }, (string[]) null, true, false);
      double num11 = Conversions.ToDouble(obj4);
      double num12 = num11;
      for (int index = num6 + 1; index <= 6; ++index)
      {
        Type Type2 = typeof (Math);
        object[] objArray6 = new object[1]
        {
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) index
          }, (string[]) null))
        };
        object[] Arguments3 = objArray6;
        bool[] flagArray2 = new bool[1]{ true };
        bool[] CopyBack2 = flagArray2;
        object obj3 = NewLateBinding.LateGet((object) null, Type2, "Abs", Arguments3, (string[]) null, (Type[]) null, CopyBack2);
        if (flagArray2[0])
          NewLateBinding.LateIndexSetComplex((object) this.Z, new object[2]
          {
            (object) index,
            RuntimeHelpers.GetObjectValue(objArray6[0])
          }, (string[]) null, true, false);
        double num10 = Conversions.ToDouble(obj3);
        if (num11 < num10)
          num11 = num10;
      }
      double num13 = num9 / (num9 + num11);
      double num14 = 1.0 + num8 / num12;
      this.NK = 0;
      double X = num13;
      double num15 = Conversions.ToDouble(this.func(X));
      while (X <= num14 & this.NK < num1)
      {
        double num10 = X;
        double num16 = num15;
        X += this.H;
        num15 = Conversions.ToDouble(this.func(X));
        if (Math.Sign(num15) * Math.Sign(num16) < 0)
        {
          ++this.NK;
          NewLateBinding.LateIndexSet((object) this.V, new object[3]
          {
            (object) 1,
            (object) this.NK,
            (object) num10
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.V, new object[3]
          {
            (object) 2,
            (object) this.NK,
            (object) X
          }, (string[]) null);
        }
        else if (num16 == 0.0)
        {
          ++this.NK;
          NewLateBinding.LateIndexSet((object) this.V, new object[3]
          {
            (object) 1,
            (object) this.NK,
            (object) (num10 - this.H / 2.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.V, new object[3]
          {
            (object) 2,
            (object) this.NK,
            (object) (num10 + this.H / 2.0)
          }, (string[]) null);
        }
        else if (num15 == 0.0)
        {
          ++this.NK;
          NewLateBinding.LateIndexSet((object) this.V, new object[3]
          {
            (object) 1,
            (object) this.NK,
            (object) (X - this.H / 2.0)
          }, (string[]) null);
          NewLateBinding.LateIndexSet((object) this.V, new object[3]
          {
            (object) 2,
            (object) this.NK,
            (object) (X + this.H / 2.0)
          }, (string[]) null);
        }
      }
    }

    private void CalculateRoots(double eps)
    {
      int nk = this.NK;
      for (int index = 1; index <= nk; ++index)
        NewLateBinding.LateIndexSet((object) this.roots, new object[2]
        {
          (object) index,
          (object) this.GetRoot(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.V, new object[2]
          {
            (object) 1,
            (object) index
          }, (string[]) null)), Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.V, new object[2]
          {
            (object) 2,
            (object) index
          }, (string[]) null)), eps)
        }, (string[]) null);
    }

    private double GetRoot(double XL, double XR, double eps)
    {
      double X1 = XL;
      double num1 = XR;
      do
      {
        double X2 = X1;
        X1 = num1;
        double num2 = Conversions.ToDouble(this.func(X2));
        double num3 = Conversions.ToDouble(this.func(X1));
        num1 = X1 - (X1 - X2) / (1.0 - num2 / num3);
      }
      while (Math.Abs(num1 - X1) > eps);
      return num1;
    }

    private void FinalSolution()
    {
      switch (this.varNo)
      {
        case 1:
          int nk1 = this.NK;
          for (int index = 1; index <= nk1; ++index)
          {
            this.Y = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.roots, new object[1]
            {
              (object) index
            }, (string[]) null));
            this.P3 = this.Y * this.P0;
            this.P2 = this.P3;
            this.R3 = this.R0 * (this.G0 - 1.0 + (this.G0 + 1.0) * this.Y) / (this.G0 + 1.0 + (this.G0 - 1.0) * this.Y);
            this.U3 = this.U0 + Math.Sqrt((this.P3 - this.P0) * (this.R3 - this.R0) / (this.R3 * this.R0));
            this.R2 = this.R1 * ((this.G1 + 1.0) * this.P2 + (this.G1 - 1.0) * this.P1) / ((this.G1 - 1.0) * this.P2 + (this.G1 + 1.0) * this.P1);
            this.U2 = this.U1 - Math.Sqrt((this.P2 - this.P1) * (this.R2 - this.R1) / (this.R2 * this.R1));
            this.D0 = (this.R3 * this.U3 - this.R0 * this.U0) / (this.R3 - this.R0);
            this.D1 = (this.R2 * this.U2 - this.R1 * this.U1) / (this.R2 - this.R1);
            this.C2 = Math.Sqrt(this.G1 * this.P2 / this.R2);
            this.C3 = Math.Sqrt(this.G0 * this.P3 / this.R3);
            this.Z0 = (this.P3 - this.P0) / Math.Abs(this.U3 - this.U0);
            this.Z1 = (this.P2 - this.P1) / Math.Abs(this.U2 - this.U1);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 1,
              (object) this.P2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 2,
              (object) this.R2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 3,
              (object) this.U2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 4,
              (object) this.C2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 5,
              (object) this.P3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 6,
              (object) this.R3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 7,
              (object) this.U3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 8,
              (object) this.C3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 9,
              (object) this.D0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 10,
              (object) this.D1
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 11,
              (object) this.Z0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 12,
              (object) this.Z1
            }, (string[]) null);
          }
          break;
        case 2:
          int nk2 = this.NK;
          for (int index = 1; index <= nk2; ++index)
          {
            this.Y = Conversions.ToDouble(Operators.ExponentObject(NewLateBinding.LateIndexGet((object) this.roots, new object[1]
            {
              (object) index
            }, (string[]) null), (object) this.NW));
            this.P3 = this.Y * this.P1;
            this.Y = this.P1 / this.P0;
            this.U3 = Conversions.ToDouble(Operators.AddObject((object) this.U1, Operators.DivideObject(Operators.MultiplyObject((object) (2.0 * this.C1), Operators.SubtractObject((object) 1.0, NewLateBinding.LateIndexGet((object) this.roots, new object[1]
            {
              (object) index
            }, (string[]) null))), (object) (this.G1 - 1.0))));
            this.D0 = this.U0 + (this.P3 - this.P0) / (this.R0 * (this.U3 - this.U0));
            this.R3 = this.R0 * (this.U0 - this.D0) / (this.U3 - this.D0);
            this.C3 = Math.Sqrt(this.G0 * this.P3 / this.R3);
            this.P2 = this.P3;
            this.U2 = this.U3;
            this.C2 = Conversions.ToDouble(Operators.MultiplyObject((object) this.C1, NewLateBinding.LateIndexGet((object) this.roots, new object[1]
            {
              (object) index
            }, (string[]) null)));
            this.R2 = this.G1 * this.P2 / (this.C2 * this.C2);
            this.Z0 = (this.P3 - this.P0) / Math.Abs(this.U3 - this.U0);
            this.Z1 = (this.P2 - this.P1) / Math.Abs(this.U2 - this.U1);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 1,
              (object) this.P2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 2,
              (object) this.R2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 3,
              (object) this.U2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 4,
              (object) this.C2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 5,
              (object) this.P3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 6,
              (object) this.R3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 7,
              (object) this.U3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 8,
              (object) this.C3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 9,
              (object) this.D0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 10,
              (object) this.D1
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 11,
              (object) this.Z0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 12,
              (object) this.Z1
            }, (string[]) null);
          }
          break;
        case 3:
          int nk3 = this.NK;
          for (int index = 1; index <= nk3; ++index)
          {
            this.Y = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.roots, new object[1]
            {
              (object) index
            }, (string[]) null));
            this.VV = this.R0 * this.R3 * (this.U0 - this.U3) * (this.U0 - this.U3);
            this.P1 = this.Y * this.VV;
            this.P2 = this.P1;
            this.R1 = this.R0 * (this.P1 * this.H0 + this.A0) / (this.P1 + this.A0);
            this.U1 = this.U0 + Math.Sqrt((this.P1 - this.P0) * (this.R1 - this.R0) / (this.R0 * this.R1));
            this.R2 = this.R3 * (this.P1 * this.H3 + this.A3) / (this.P1 + this.A3);
            this.U2 = this.U3 - Math.Sqrt((this.P2 - this.P3) * (this.R2 - this.R3) / (this.R2 * this.R3));
            this.D0 = (this.R1 * this.U1 - this.R0 * this.U0) / (this.R1 - this.R0);
            this.D1 = (this.R2 * this.U2 - this.R3 * this.U3) / (this.R2 - this.R3);
            this.SG0 = this.R1 / this.R0;
            this.SG3 = this.R2 / this.R3;
            this.C2 = Math.Sqrt(this.C3 * this.C3 * (2.0 * this.SG3 - 1.0) / (this.SG3 * (2.0 - this.SG3)));
            this.C1 = Math.Sqrt(this.C0 * this.C0 * (2.0 * this.SG0 - 1.0) / (this.SG0 * (2.0 - this.SG0)));
            this.Z0 = (this.P1 - this.P0) / Math.Abs(this.U1 - this.U0);
            this.Z1 = (this.P2 - this.P3) / Math.Abs(this.U2 - this.U3);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 1,
              (object) this.P2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 2,
              (object) this.R2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 3,
              (object) this.U2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 4,
              (object) this.C2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 5,
              (object) this.P3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 6,
              (object) this.R3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 7,
              (object) this.U3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 8,
              (object) this.C3
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 9,
              (object) this.D0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 10,
              (object) this.D1
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 11,
              (object) this.Z0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 12,
              (object) this.Z1
            }, (string[]) null);
          }
          break;
        case 4:
          int taskNo = this.MyForm.taskNo;
          int nk4 = this.NK;
          for (int index = 1; index <= nk4; ++index)
          {
            this.Y = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.roots, new object[1]
            {
              (object) index
            }, (string[]) null));
            this.P1 = this.Y * this.DE;
            this.P2 = this.P1;
            this.R1 = this.R0 * (this.P1 * this.H0 + this.A0) / (this.P1 + this.A0);
            this.U1 = this.U0 + Math.Sqrt((this.R1 - this.R0) / (this.R0 * this.R1) * this.P1);
            if (taskNo == 1 | taskNo == 7 | taskNo == 8)
              this.U1 = -this.U0 + Math.Sqrt(this.P1 * (this.R1 - this.R0) / (this.R0 * this.R1));
            this.R2 = this.R3 * (this.P1 * this.H3 + this.A3) / (this.P1 + this.A3);
            this.U2 = this.U3 - Math.Sqrt(this.P2 * (this.R2 - this.R3) / (this.R2 * this.R3));
            if (taskNo == 1 | taskNo == 7 | taskNo == 8)
              this.U2 = -this.U3 - Math.Sqrt(this.P2 * (this.R2 - this.R3) / (this.R2 * this.R3));
            this.D0 = (this.R1 * this.U1 - this.R0 * this.U0) / (this.R1 - this.R0);
            if (taskNo == 1 | taskNo == 7 | taskNo == 8)
              this.D0 = (this.R0 * this.U0 + this.R1 * this.U1) / (this.R1 - this.R0);
            this.D1 = (this.R2 * this.U2 - this.R3 * this.U3) / (this.R2 - this.R3);
            if (taskNo == 1 | taskNo == 7 | taskNo == 8)
              this.D1 = (this.R3 * this.U3 - this.R2 * this.U2) / (this.R2 - this.R3);
            this.SG0 = this.R1 / this.R0;
            this.SG3 = this.R2 / this.R3;
            this.C2 = Math.Sqrt(this.C3 * this.C3 * (2.0 * this.SG3 - 1.0) / (this.SG3 * (2.0 - this.SG3)));
            this.C1 = Math.Sqrt(this.C0 * this.C0 * (2.0 * this.SG0 - 1.0) / (this.SG0 * (2.0 - this.SG0)));
            this.Z0 = (this.P1 - this.P0) / Math.Abs(this.U1 - this.U0);
            this.Z1 = (this.P2 - this.P3) / Math.Abs(this.U2 - this.U3);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 1,
              (object) this.P2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 2,
              (object) this.R2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 3,
              (object) this.U2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 4,
              (object) this.C2
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 5,
              (object) this.P1
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 6,
              (object) this.R1
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 7,
              (object) this.U1
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 8,
              (object) this.C1
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 9,
              (object) this.D0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 10,
              (object) this.D1
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 11,
              (object) this.Z0
            }, (string[]) null);
            NewLateBinding.LateIndexSet((object) this.solution, new object[3]
            {
              (object) index,
              (object) 12,
              (object) this.Z1
            }, (string[]) null);
          }
          break;
      }
    }

    private object func(double X)
    {
      object Left = (object) 0.0;
      switch (this.varNo)
      {
        case 1:
        case 3:
        case 4:
          double num1 = 1.0;
          int num2 = 7;
          do
          {
            Left = Operators.AddObject(Left, Operators.MultiplyObject((object) num1, NewLateBinding.LateIndexGet((object) this.Z, new object[1]
            {
              (object) num2
            }, (string[]) null)));
            num1 *= X;
            num2 += -1;
          }
          while (num2 >= 1);
          break;
        case 2:
          Left = Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) 1
          }, (string[]) null), (object) Math.Pow(X, 2.0 * this.NW)), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) 2
          }, (string[]) null), (object) Math.Pow(X, this.NW + 2.0))), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) 3
          }, (string[]) null), (object) Math.Pow(X, this.NW + 1.0))), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) 4
          }, (string[]) null), (object) Math.Pow(X, this.NW))), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) 5
          }, (string[]) null), (object) Math.Pow(X, 2.0))), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) 6
          }, (string[]) null), (object) X)), NewLateBinding.LateIndexGet((object) this.Z, new object[1]
          {
            (object) 7
          }, (string[]) null));
          break;
      }
      return Left;
    }
  }
}
