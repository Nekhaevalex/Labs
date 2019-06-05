// Decompiled with JetBrains decompiler
// Type: Proverka.NumericLab4
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace Proverka
{
  public class NumericLab4
  {
    public int N;
    public int LK;
    public int LK1;
    public double X0;
    public double XN;
    public double Y0;
    public double YN;
    public double EPS;
    public double FA;
    public double QA;
    public double XL;
    public double A1;
    public double A2;
    public double B1;
    public double B2;
    public double C1;
    public double C2;
    public double D1;
    public double D2;
    public double G1;
    public double G2;
    public double BM1;
    public double BM2;
    public double FFA;
    public double AA;
    public double CC;
    public double FC;
    public double LJ;
    public double H;
    public double L0;
    public Array X;
    public Array UA;
    public Array UM;
    public Array UV;
    private int MyTaskNo;

    public NumericLab4()
    {
      this.X = Array.CreateInstance(typeof (double), 100001);
      this.UA = Array.CreateInstance(typeof (double), 100001);
      this.UM = Array.CreateInstance(typeof (double), 100001);
      this.UV = Array.CreateInstance(typeof (double), 100001);
    }

    public void Calculate1(int tno)
    {
      this.MyTaskNo = tno;
      this.LJ = (double) this.LK / 10.0;
      this.Y0 = 0.0;
      this.YN = 1.0;
      switch (this.MyTaskNo)
      {
        case 1:
          this.B1 = 0.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 0.0;
          this.FA = Math.Exp(0.5);
          this.QA = Math.Exp(0.5);
          this.FFA = Math.Sin(0.5);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num1 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num1;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num1;
          break;
        case 2:
          this.B1 = 1.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 1.0;
          this.FA = Math.Sqrt(Math.Exp(1.0));
          this.QA = Math.Sqrt(Math.Exp(1.0));
          this.FFA = Math.Cos(0.5);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num2 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num2;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num2;
          break;
        case 3:
          this.B1 = 100.0;
          this.BM1 = 0.0;
          this.B2 = 0.0;
          this.BM2 = 0.0;
          this.FA = 1.25;
          this.QA = 2.5;
          this.FFA = Math.Cos(0.5);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num3 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num3;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num3;
          break;
        case 4:
          this.B1 = 1.0;
          this.BM1 = 1.0;
          this.B2 = 1.0;
          this.BM2 = 1.0;
          this.FA = Math.Pow(Math.Sin(0.5), 2.0) + 1.0;
          this.QA = Math.Sin(0.5);
          this.FFA = Math.Sqrt(Math.Exp(1.0));
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num4 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num4;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num4;
          break;
        case 5:
          this.B1 = 0.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 0.0;
          this.FA = 1.25;
          this.QA = 0.5;
          this.FFA = 1.0 / Math.Sqrt(Math.Exp(1.0));
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num5 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num5;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num5;
          break;
        case 6:
          this.B1 = 1.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 1.0;
          this.FA = Math.Pow(Math.Cos(0.5), 2.0) + 1.0;
          this.QA = 1.0;
          this.FFA = Math.Pow(Math.Sin(0.5), 2.0);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num6 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num6;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num6;
          break;
        case 7:
          this.B1 = 1.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 0.0;
          this.FA = Math.Exp(Math.Sin(0.5));
          this.QA = Math.Exp(Math.Cos(0.5));
          this.FFA = 1.0;
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num7 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num7;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num7;
          break;
        case 8:
          this.B1 = 1.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 0.0;
          this.FA = Math.Exp(Math.Cos(0.5));
          this.QA = Math.Exp(Math.Sin(0.5));
          this.FFA = 1.0;
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num8 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num8;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num8;
          break;
        case 9:
          this.B1 = 0.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 0.0;
          this.FA = 1.5;
          this.QA = Math.Exp(0.5);
          this.FFA = Math.Exp(-0.25);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num9 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num9;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num9;
          break;
        case 10:
          this.B1 = 1.0;
          this.BM1 = 1.0;
          this.B2 = 1.0;
          this.BM2 = 1.0;
          this.FA = Math.Pow(Math.Sin(0.5), 2.0) + 1.0;
          this.QA = Math.Cos(0.5);
          this.FFA = Math.Exp(0.5);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num10 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num10;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num10;
          break;
        case 11:
          this.B1 = 0.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 0.0;
          this.FA = Math.Exp(0.5);
          this.QA = 1.125;
          this.FFA = 1.0 / Math.Exp(0.5);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num11 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num11;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num11;
          break;
        case 12:
          this.B1 = 1.0;
          this.BM1 = 1.0;
          this.B2 = 1.0;
          this.BM2 = 0.0;
          this.FA = Math.Exp(0.5);
          this.QA = Math.Exp(0.5);
          this.FFA = Math.Cos(0.5);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num12 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num12;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num12;
          break;
        case 13:
          this.B1 = 1.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 0.0;
          this.FA = Math.Exp(0.5);
          this.QA = Math.Exp(0.5);
          this.FFA = Math.Exp(-0.5);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num13 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num13;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num13;
          break;
        case 14:
          this.B1 = 0.1;
          this.BM1 = 100.0;
          this.B2 = 0.1;
          this.BM2 = 100.0;
          this.FA = 1.5;
          this.QA = 0.5;
          this.FFA = 1.0 / Math.Exp(0.25);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num14 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num14;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num14;
          break;
        case 15:
          this.B1 = 1.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 0.0;
          this.FA = Math.Sqrt(Math.Exp(1.0));
          this.QA = Math.Sqrt(Math.Exp(1.0));
          this.FFA = Math.Sin(0.5);
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num15 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num15;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num15;
          break;
        case 16:
          this.B1 = 0.0;
          this.BM1 = 0.0;
          this.B2 = 1.0;
          this.BM2 = 0.0;
          this.FA = 1.5;
          this.QA = 1.25;
          this.FFA = 1.0 / Math.Sqrt(Math.Exp(1.0));
          this.CC = Math.Sqrt(this.QA / this.FA);
          this.FC = this.FFA / this.QA;
          this.AA = Math.Sqrt(this.QA * this.FA);
          this.A1 = this.AA - this.B1;
          this.A2 = this.AA * Math.Exp(this.CC) + this.B2 * Math.Exp(this.CC);
          this.D1 = this.AA + this.B1;
          this.D2 = -this.AA * Math.Exp(-this.CC) + this.B2 * Math.Exp(-this.CC);
          this.G1 = this.B1 * this.FC - this.BM1;
          this.G2 = -this.BM2 + this.B2 * this.FC;
          double num16 = this.A1 * this.D2 + this.A2 * this.D1;
          this.C1 = (this.G1 * this.D2 - this.G2 * this.D1) / num16;
          this.C2 = -(this.A1 * this.G2 + this.A2 * this.G1) / num16;
          break;
      }
      this.AnaliticSolver1();
      this.NumSolver1();
    }

    public void Calculate2(int tno)
    {
      this.MyTaskNo = tno;
      this.LJ = (double) this.LK / 10.0;
      this.Y0 = 0.0;
      this.YN = 1.0;
      switch (this.MyTaskNo)
      {
        case 1:
          this.FA = 1.5;
          this.QA = 1.0;
          break;
        case 2:
        case 13:
          this.FA = 2.0;
          this.QA = 1.0;
          break;
        case 3:
          this.FA = 2.0;
          this.QA = 1.5;
          break;
        case 4:
        case 5:
        case 6:
        case 11:
        case 12:
          this.FA = 1.0;
          this.QA = 1.0;
          break;
        case 7:
          this.FA = 3.0;
          this.QA = 1.0;
          break;
        case 8:
          this.FA = Math.Log(2.0);
          this.QA = 1.0;
          break;
        case 9:
          this.FA = 2.0;
          this.QA = Math.Log(2.0);
          break;
        case 10:
          this.FA = 1.0;
          this.QA = 3.0;
          break;
        case 14:
          this.FA = 3.0;
          this.QA = 1.5;
          break;
        case 15:
          this.FA = 1.0;
          this.QA = Math.Log(2.0);
          break;
        case 16:
          this.FA = 1.5;
          this.QA = 3.0;
          break;
      }
      this.AnaliticSolver2();
      this.NumSolver2(1);
      this.NumSolver2(2);
    }

    public void Calculate3(int tno)
    {
      this.MyTaskNo = tno;
      this.LK1 = this.LK - 1;
      this.H = 1.0 / (double) this.LK1;
      this.LJ = (double) this.LK1 / 10.0;
      this.L0 = this.X0 / this.H + 2.0;
      switch (this.MyTaskNo)
      {
        case 1:
        case 6:
        case 13:
        case 14:
          this.X0 = 0.525;
          break;
        case 2:
        case 4:
        case 5:
        case 7:
        case 10:
          this.X0 = 1.0 / Math.Sqrt(2.0);
          break;
        case 3:
          this.X0 = 1.0 / Math.Sqrt(5.0);
          break;
        case 8:
          this.X0 = 1.0 / Math.Sqrt(10.0);
          break;
        case 9:
        case 12:
        case 16:
          this.X0 = 1.0 / Math.Sqrt(3.0);
          break;
        case 11:
        case 15:
          this.X0 = 0.125;
          break;
      }
      switch (this.MyTaskNo)
      {
        case 1:
        case 6:
        case 7:
        case 9:
        case 10:
        case 13:
        case 14:
          this.Y0 = 0.0;
          this.YN = 1.0;
          break;
        case 2:
        case 4:
        case 5:
        case 8:
        case 11:
          this.Y0 = 1.0;
          this.YN = 0.0;
          break;
        case 3:
          this.Y0 = 1.0;
          this.YN = 2.0;
          break;
        case 12:
          this.Y0 = 1.0;
          this.YN = 1.0;
          break;
        case 15:
          this.Y0 = 0.0;
          this.YN = 0.0;
          break;
        case 16:
          this.Y0 = 2.0;
          this.YN = 1.0;
          break;
      }
      this.AnaliticSolver3();
      this.NumSolver3(1);
      this.NumSolver3(2);
    }

    private void AnaliticSolver1()
    {
      this.H = 1.0 / (double) (this.LK - 1);
      this.XL = 0.0;
      int lk = this.LK;
      for (int index = 1; index <= lk; ++index)
      {
        NewLateBinding.LateIndexSet((object) this.UA, new object[2]
        {
          (object) index,
          (object) this.L1FEN(this.XL)
        }, (string[]) null);
        this.XL += this.H;
      }
    }

    private void AnaliticSolver2()
    {
      this.H = 1.0 / (double) (this.N - 1);
      this.XL = 0.0;
      int n = this.N;
      for (int index = 1; index <= n; ++index)
      {
        NewLateBinding.LateIndexSet((object) this.UA, new object[2]
        {
          (object) index,
          (object) this.L2FEN(this.XL)
        }, (string[]) null);
        this.XL += this.H;
      }
    }

    private void AnaliticSolver3()
    {
      double num1 = Math.Sqrt(this.FQN(1, this.X0) / this.FKN(1, this.X0));
      double num2 = this.FFN(1, this.X0) / this.FQN(1, this.X0);
      double num3 = Math.Sqrt(this.FQN2(1, this.X0) / this.FKN2(1, this.X0));
      double num4 = this.FFN2(1, this.X0) / this.FQN2(1, this.X0);
      double num5 = Math.Exp(-num1 * this.X0) - Math.Exp(num1 * this.X0);
      double num6 = Math.Exp(num3 * (2.0 - this.X0)) - Math.Exp(num3 * this.X0);
      double num7 = this.FKN(1, this.X0) * num1 * (Math.Exp(num1 * this.X0) + Math.Exp(-num1 * this.X0));
      double num8 = this.FKN2(1, this.X0) * num3 * (Math.Exp((2.0 - this.X0) * num3) + Math.Exp(num3 * this.X0));
      double num9 = num4 - num2 + (num2 - this.Y0) * Math.Exp(num1 * this.X0) - (num4 - this.YN) * Math.Exp(num3 * (1.0 - this.X0));
      double num10 = num1 * this.FKN(1, this.X0) * (this.Y0 - num2) * Math.Exp(num1 * this.X0) + num3 * this.FKN2(1, this.X0) * (this.YN - num4) * Math.Exp(num3 * (1.0 - this.X0));
      double num11 = num5 * num8 - num6 * num7;
      double num12 = (num9 * num8 - num10 * num6) / num11;
      double num13 = this.Y0 - num2 - num12;
      double num14 = (num10 * num5 - num9 * num7) / num11;
      double num15 = (this.YN - num4) * Math.Exp(num3 * 1.0) - num14 * Math.Exp(2.0 * num3);
      int lk = this.LK;
      for (int index = 1; index <= lk; ++index)
      {
        double num16 = (double) (index - 1) * this.H;
        if (num16 - this.X0 <= 0.0)
          NewLateBinding.LateIndexSet((object) this.UA, new object[2]
          {
            (object) index,
            (object) (num13 * Math.Exp(num1 * num16) + num12 * Math.Exp(-num1 * num16) + num2)
          }, (string[]) null);
        else
          NewLateBinding.LateIndexSet((object) this.UA, new object[2]
          {
            (object) index,
            (object) (num14 * Math.Exp(num3 * num16) + num15 * Math.Exp(-num3 * num16) + num4)
          }, (string[]) null);
      }
    }

    private void NumSolver1()
    {
      Array instance1 = Array.CreateInstance(typeof (double), 100001);
      Array instance2 = Array.CreateInstance(typeof (double), 100001);
      Array instance3 = Array.CreateInstance(typeof (double), 100001);
      Array instance4 = Array.CreateInstance(typeof (double), 100001);
      Array.CreateInstance(typeof (double), 100001);
      Array.CreateInstance(typeof (double), 100001);
      int num1 = this.N - 1;
      int num2 = this.N - 2;
      this.H = 1.0 / (double) num1;
      this.XL = 0.0;
      int n1 = this.N;
      for (int index = 1; index <= n1; ++index)
      {
        NewLateBinding.LateIndexSet((object) this.X, new object[2]
        {
          (object) index,
          (object) this.XL
        }, (string[]) null);
        this.XL += this.H;
      }
      double Xin1 = 0.0;
      double Xin2 = 0.0;
      double num3 = this.H * this.H;
      double Xin3 = Xin1 + this.H / 2.0;
      double num4 = this.L1FKN(Xin2);
      double num5 = this.L1FKN(Xin2);
      double num6 = this.L1FKN2(Xin2);
      double num7 = this.L1FKN2(Xin2);
      double num8 = num5 + this.B1 * this.H;
      NewLateBinding.LateIndexSet((object) instance1, new object[2]
      {
        (object) 2,
        (object) (num5 / num8)
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance2, new object[2]
      {
        (object) 2,
        (object) (this.BM1 * this.H / num8)
      }, (string[]) null);
      double num9 = num7 + this.B1 * this.H;
      NewLateBinding.LateIndexSet((object) instance3, new object[2]
      {
        (object) 2,
        (object) (num7 / num9)
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance4, new object[2]
      {
        (object) 2,
        (object) (this.BM1 * this.H / num9)
      }, (string[]) null);
      int n2 = this.N;
      for (int index = 3; index <= n2; ++index)
      {
        Xin1 += this.H;
        Xin3 += this.H;
        double num10 = num4;
        num4 = this.L1FKN(Xin3);
        double num11 = Conversions.ToDouble(Operators.SubtractObject((object) (num4 + num10 + this.L1FQN(Xin1) * num3), Operators.MultiplyObject((object) num10, NewLateBinding.LateIndexGet((object) instance1, new object[1]
        {
          (object) (index - 1)
        }, (string[]) null))));
        NewLateBinding.LateIndexSet((object) instance1, new object[2]
        {
          (object) index,
          (object) (num4 / num11)
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance2, new object[2]
        {
          (object) index,
          Operators.DivideObject(Operators.AddObject((object) (this.L1FN(Xin1) * num3), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance2, new object[1]
          {
            (object) (index - 1)
          }, (string[]) null), (object) num10)), (object) num11)
        }, (string[]) null);
        double num12 = num6;
        num6 = this.L1FKN2(Xin3);
        double num13 = Conversions.ToDouble(Operators.SubtractObject((object) (num6 + num12 + this.L1FQN2(Xin1) * num3), Operators.MultiplyObject((object) num12, NewLateBinding.LateIndexGet((object) instance3, new object[1]
        {
          (object) (index - 1)
        }, (string[]) null))));
        NewLateBinding.LateIndexSet((object) instance3, new object[2]
        {
          (object) index,
          (object) (num6 / num13)
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance4, new object[2]
        {
          (object) index,
          Operators.DivideObject(Operators.AddObject((object) (this.L1FN2(Xin1) * num3), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance4, new object[1]
          {
            (object) (index - 1)
          }, (string[]) null), (object) num12)), (object) num13)
        }, (string[]) null);
      }
      NewLateBinding.LateIndexSet((object) this.X, new object[2]
      {
        (object) this.N,
        (object) 1.0
      }, (string[]) null);
      double num14 = this.L1FKN(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
      {
        (object) this.N
      }, (string[]) null)));
      NewLateBinding.LateIndexSet((object) this.UV, new object[2]
      {
        (object) this.N,
        Operators.DivideObject(Operators.AddObject(Operators.MultiplyObject((object) num14, NewLateBinding.LateIndexGet((object) instance2, new object[1]
        {
          (object) this.N
        }, (string[]) null)), (object) (this.BM2 * this.H)), Operators.AddObject(Operators.MultiplyObject((object) num14, Operators.SubtractObject((object) 1, NewLateBinding.LateIndexGet((object) instance1, new object[1]
        {
          (object) this.N
        }, (string[]) null))), (object) (this.B2 * this.H)))
      }, (string[]) null);
      double num15 = this.L1FKN2(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.X, new object[1]
      {
        (object) this.N
      }, (string[]) null)));
      NewLateBinding.LateIndexSet((object) this.UM, new object[2]
      {
        (object) this.N,
        Operators.DivideObject(Operators.AddObject(Operators.MultiplyObject((object) num15, NewLateBinding.LateIndexGet((object) instance4, new object[1]
        {
          (object) this.N
        }, (string[]) null)), (object) (this.BM2 * this.H)), Operators.AddObject(Operators.MultiplyObject((object) num15, Operators.SubtractObject((object) 1, NewLateBinding.LateIndexGet((object) instance3, new object[1]
        {
          (object) this.N
        }, (string[]) null))), (object) (this.B2 * this.H)))
      }, (string[]) null);
      int num16 = num1;
      for (int index = 1; index <= num16; ++index)
      {
        int num10 = this.N - index + 1;
        NewLateBinding.LateIndexSet((object) this.UV, new object[2]
        {
          (object) (num10 - 1),
          Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.UV, new object[1]
          {
            (object) num10
          }, (string[]) null), NewLateBinding.LateIndexGet((object) instance1, new object[1]
          {
            (object) num10
          }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance2, new object[1]
          {
            (object) num10
          }, (string[]) null))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) this.UM, new object[2]
        {
          (object) (num10 - 1),
          Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.UM, new object[1]
          {
            (object) num10
          }, (string[]) null), NewLateBinding.LateIndexGet((object) instance3, new object[1]
          {
            (object) num10
          }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance4, new object[1]
          {
            (object) num10
          }, (string[]) null))
        }, (string[]) null);
      }
    }

    private void NumSolver2(int Mode)
    {
      Array instance1 = Array.CreateInstance(typeof (double), 100001);
      Array instance2 = Array.CreateInstance(typeof (double), 100001);
      Array instance3 = Array.CreateInstance(typeof (double), 100001);
      Array instance4 = Array.CreateInstance(typeof (double), 100001);
      Array instance5 = Array.CreateInstance(typeof (double), 100001);
      Array instance6 = Array.CreateInstance(typeof (double), 100001);
      int num1 = this.N - 1;
      int num2 = this.N - 2;
      this.H = 1.0 / (double) num1;
      double h = this.H;
      double Xin1 = 0.0;
      double num3 = this.H * this.H;
      NewLateBinding.LateIndexSet((object) instance5, new object[2]
      {
        (object) 1,
        (object) 1.0
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance6, new object[2]
      {
        (object) 1,
        (object) 0.0
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance5, new object[2]
      {
        (object) this.N,
        (object) 1.0
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance6, new object[2]
      {
        (object) this.N,
        (object) 0.0
      }, (string[]) null);
      double Xin2 = h + this.H / 2.0;
      double num4 = this.L2FKN(Mode, Xin2);
      double num5 = this.L2FKN(Mode, Xin2 - this.H);
      double num6 = num4 + num5 + this.L2FQN(Mode, h) * num3;
      NewLateBinding.LateIndexSet((object) instance1, new object[2]
      {
        (object) 3,
        (object) (num4 / num6)
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance3, new object[2]
      {
        (object) 3,
        RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance1, new object[1]
        {
          (object) 3
        }, (string[]) null))
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance2, new object[2]
      {
        (object) 3,
        (object) (num5 / num6)
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance4, new object[2]
      {
        (object) 3,
        (object) (this.L2FN(Mode, h) * num3 / num6)
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) this.X, new object[2]
      {
        (object) 2,
        (object) h
      }, (string[]) null);
      int n1 = this.N;
      for (int index = 4; index <= n1; ++index)
      {
        h += this.H;
        NewLateBinding.LateIndexSet((object) this.X, new object[2]
        {
          (object) (index - 1),
          (object) h
        }, (string[]) null);
        Xin2 += this.H;
        double num7 = num4;
        num4 = this.L2FKN(Mode, Xin2);
        double num8 = Conversions.ToDouble(Operators.SubtractObject((object) (num4 + num7 + this.L2FQN(Mode, h) * num3), Operators.MultiplyObject((object) num7, NewLateBinding.LateIndexGet((object) instance1, new object[1]
        {
          (object) (index - 1)
        }, (string[]) null))));
        NewLateBinding.LateIndexSet((object) instance1, new object[2]
        {
          (object) index,
          (object) (num4 / num8)
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance2, new object[2]
        {
          (object) index,
          Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance2, new object[1]
          {
            (object) (index - 1)
          }, (string[]) null), (object) num7), (object) num8)
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance3, new object[2]
        {
          (object) index,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) instance1, new object[1]
          {
            (object) index
          }, (string[]) null))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance4, new object[2]
        {
          (object) index,
          Operators.DivideObject(Operators.AddObject((object) (this.L2FN(Mode, h) * num3), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance4, new object[1]
          {
            (object) (index - 1)
          }, (string[]) null), (object) num7)), (object) num8)
        }, (string[]) null);
      }
      NewLateBinding.LateIndexSet((object) this.X, new object[2]
      {
        (object) this.N,
        (object) 1.0
      }, (string[]) null);
      int num9 = num2;
      for (int index = 1; index <= num9; ++index)
      {
        int num7 = this.N - index + 1;
        NewLateBinding.LateIndexSet((object) instance5, new object[2]
        {
          (object) (num7 - 1),
          Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance5, new object[1]
          {
            (object) num7
          }, (string[]) null), NewLateBinding.LateIndexGet((object) instance1, new object[1]
          {
            (object) num7
          }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance2, new object[1]
          {
            (object) num7
          }, (string[]) null))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance6, new object[2]
        {
          (object) (num7 - 1),
          Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance6, new object[1]
          {
            (object) num7
          }, (string[]) null), NewLateBinding.LateIndexGet((object) instance3, new object[1]
          {
            (object) num7
          }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance4, new object[1]
          {
            (object) num7
          }, (string[]) null))
        }, (string[]) null);
      }
      double num10 = this.L2FKN(Mode, Conversions.ToDouble(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
      {
        (object) num1
      }, (string[]) null), (object) (this.H / 2.0))));
      double num11 = this.L2FKN(Mode, Conversions.ToDouble(Operators.AddObject(NewLateBinding.LateIndexGet((object) this.X, new object[1]
      {
        (object) 1
      }, (string[]) null), (object) (this.H / 2.0))));
      double num12 = Conversions.ToDouble(Operators.DivideObject(Operators.AddObject(Operators.AddObject((object) (this.L2FN(Mode, Xin1) * num3), Operators.MultiplyObject((object) num10, NewLateBinding.LateIndexGet((object) instance6, new object[1]
      {
        (object) num1
      }, (string[]) null))), Operators.MultiplyObject((object) num11, NewLateBinding.LateIndexGet((object) instance6, new object[1]
      {
        (object) 2
      }, (string[]) null))), Operators.SubtractObject(Operators.SubtractObject((object) (num11 + num10 + this.L2FQN(Mode, Xin1) * num3), Operators.MultiplyObject((object) num10, NewLateBinding.LateIndexGet((object) instance5, new object[1]
      {
        (object) num1
      }, (string[]) null))), Operators.MultiplyObject((object) num11, NewLateBinding.LateIndexGet((object) instance5, new object[1]
      {
        (object) 2
      }, (string[]) null)))));
      if (Mode == 1)
      {
        NewLateBinding.LateIndexSet((object) this.UV, new object[2]
        {
          (object) 1,
          (object) num12
        }, (string[]) null);
        int n2 = this.N;
        for (int index = 2; index <= n2; ++index)
          NewLateBinding.LateIndexSet((object) this.UV, new object[2]
          {
            (object) index,
            Operators.AddObject(Operators.MultiplyObject((object) num12, NewLateBinding.LateIndexGet((object) instance5, new object[1]
            {
              (object) index
            }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance6, new object[1]
            {
              (object) index
            }, (string[]) null))
          }, (string[]) null);
      }
      if (Mode != 2)
        return;
      NewLateBinding.LateIndexSet((object) this.UM, new object[2]
      {
        (object) 1,
        (object) num12
      }, (string[]) null);
      int n3 = this.N;
      for (int index = 2; index <= n3; ++index)
        NewLateBinding.LateIndexSet((object) this.UM, new object[2]
        {
          (object) index,
          Operators.AddObject(Operators.MultiplyObject((object) num12, NewLateBinding.LateIndexGet((object) instance5, new object[1]
          {
            (object) index
          }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance6, new object[1]
          {
            (object) index
          }, (string[]) null))
        }, (string[]) null);
    }

    private void NumSolver3(int Mode)
    {
      Array instance1 = Array.CreateInstance(typeof (double), 100001);
      Array instance2 = Array.CreateInstance(typeof (double), 100001);
      double num1 = this.H / 2.0;
      double num2 = this.H * this.H;
      int num3 = (int) Math.Round(this.L0 - 2.0);
      int num4 = (int) Math.Round(this.L0 - 1.0);
      NewLateBinding.LateIndexSet((object) instance1, new object[2]
      {
        (object) 1,
        (object) 0.0
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance2, new object[2]
      {
        (object) 1,
        (object) this.Y0
      }, (string[]) null);
      double Xin1 = 0.0;
      double Xin2 = num1;
      double num5 = this.FKN(Mode, Xin2);
      int num6 = num3;
      for (int index = 2; index <= num6; ++index)
      {
        int num7 = index - 1;
        Xin1 += this.H;
        double Xin3 = Xin1 + num1;
        double num8 = num5;
        num5 = this.FKN(Mode, Xin3);
        double num9 = Conversions.ToDouble(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.MultiplyObject(Operators.NegateObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
        {
          (object) num7
        }, (string[]) null)), (object) num8), (object) num5), (object) num8), (object) (this.FQN(Mode, Xin1) * num2)));
        NewLateBinding.LateIndexSet((object) instance1, new object[2]
        {
          (object) index,
          (object) (num5 / num9)
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance2, new object[2]
        {
          (object) index,
          Operators.DivideObject(Operators.AddObject((object) (this.FFN(Mode, Xin1) * num2), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance2, new object[1]
          {
            (object) num7
          }, (string[]) null), (object) num8)), (object) num9)
        }, (string[]) null);
      }
      NewLateBinding.LateIndexSet((object) instance1, new object[2]
      {
        (object) num4,
        (object) 1.0
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance2, new object[2]
      {
        (object) num4,
        (object) 0.0
      }, (string[]) null);
      double num10 = this.FKN(Mode, this.X0);
      double num11 = this.FKN2(Mode, this.X0);
      double num12 = Conversions.ToDouble(Operators.AddObject((object) num11, Operators.MultiplyObject((object) num10, Operators.SubtractObject((object) 1.0, NewLateBinding.LateIndexGet((object) instance1, new object[1]
      {
        (object) num3
      }, (string[]) null)))));
      NewLateBinding.LateIndexSet((object) instance1, new object[2]
      {
        (object) this.L0,
        (object) (num11 / num12)
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) instance2, new object[2]
      {
        (object) this.L0,
        Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance2, new object[1]
        {
          (object) num3
        }, (string[]) null), (object) num10), (object) num12)
      }, (string[]) null);
      double Xin4 = (double) num4 * this.H;
      double Xin5 = Xin4 + num1;
      double num13 = this.FKN2(Mode, Xin5);
      int num14 = (int) Math.Round(this.L0 + 1.0);
      this.LK1 = this.LK - 1;
      int num15 = num14;
      int lk1_1 = this.LK1;
      for (int index = num15; index <= lk1_1; ++index)
      {
        int num7 = index - 1;
        Xin4 += this.H;
        double Xin3 = Xin4 + num1;
        double num8 = num13;
        num13 = this.FKN2(Mode, Xin3);
        double num9 = Conversions.ToDouble(Operators.SubtractObject((object) (num13 + num8 + this.FQN2(Mode, Xin4) * num2), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
        {
          (object) num7
        }, (string[]) null), (object) num8)));
        NewLateBinding.LateIndexSet((object) instance1, new object[2]
        {
          (object) index,
          (object) (num13 / num9)
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance2, new object[2]
        {
          (object) index,
          Operators.DivideObject(Operators.AddObject((object) (this.FFN2(Mode, Xin4) * num2), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance2, new object[1]
          {
            (object) num7
          }, (string[]) null), (object) num8)), (object) num9)
        }, (string[]) null);
      }
      if (Mode == 1)
      {
        NewLateBinding.LateIndexSet((object) this.UM, new object[2]
        {
          (object) this.LK,
          (object) this.YN
        }, (string[]) null);
        int lk1_2 = this.LK1;
        for (int index = 1; index <= lk1_2; ++index)
        {
          int num7 = this.LK - index;
          int num8 = num7 + 1;
          NewLateBinding.LateIndexSet((object) this.UM, new object[2]
          {
            (object) num7,
            Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
            {
              (object) num7
            }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UM, new object[1]
            {
              (object) num8
            }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance2, new object[1]
            {
              (object) num7
            }, (string[]) null))
          }, (string[]) null);
        }
      }
      if (Mode != 2)
        return;
      NewLateBinding.LateIndexSet((object) this.UV, new object[2]
      {
        (object) this.LK,
        (object) this.YN
      }, (string[]) null);
      int lk1_3 = this.LK1;
      for (int index = 1; index <= lk1_3; ++index)
      {
        int num7 = this.LK - index;
        int num8 = num7 + 1;
        NewLateBinding.LateIndexSet((object) this.UV, new object[2]
        {
          (object) num7,
          Operators.AddObject(Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
          {
            (object) num7
          }, (string[]) null), NewLateBinding.LateIndexGet((object) this.UV, new object[1]
          {
            (object) num8
          }, (string[]) null)), NewLateBinding.LateIndexGet((object) instance2, new object[1]
          {
            (object) num7
          }, (string[]) null))
        }, (string[]) null);
      }
    }

    public double L1FKN(double Xin)
    {
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
        case 2:
        case 11:
        case 12:
        case 13:
        case 15:
          num = Math.Exp(Xin);
          break;
        case 3:
        case 5:
          num = Math.Pow(Xin, 2.0) + 1.0;
          break;
        case 4:
        case 10:
          num = Math.Pow(Math.Sin(Xin), 2.0) + 1.0;
          break;
        case 6:
          num = Math.Pow(Math.Cos(Xin), 2.0) + 1.0;
          break;
        case 7:
          num = Math.Exp(Math.Sin(Xin));
          break;
        case 8:
          num = Math.Exp(Math.Cos(Xin));
          break;
        case 9:
        case 14:
        case 16:
          num = Xin + 1.0;
          break;
      }
      return num;
    }

    public double L1FQN(double Xin)
    {
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
        case 2:
        case 9:
        case 12:
        case 13:
        case 15:
          num = Math.Exp(Xin);
          break;
        case 3:
          num = Xin + 2.0;
          break;
        case 4:
          num = Math.Sin(Xin);
          break;
        case 5:
          num = Xin;
          break;
        case 6:
          num = 1.0;
          break;
        case 7:
          num = Math.Exp(Math.Cos(Xin));
          break;
        case 8:
          num = Math.Exp(Math.Sin(Xin));
          break;
        case 10:
          num = Math.Cos(Xin);
          break;
        case 11:
          num = Math.Pow(Xin, 3.0) + 1.0;
          break;
        case 14:
          num = Xin;
          break;
        case 16:
          num = Math.Pow(Xin, 2.0) + 1.0;
          break;
      }
      return num;
    }

    public double L1FN(double Xin)
    {
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
        case 15:
          num = Math.Sin(Xin);
          break;
        case 2:
        case 3:
        case 12:
          num = Math.Cos(Xin);
          break;
        case 4:
        case 10:
          num = Math.Exp(Xin);
          break;
        case 5:
        case 11:
        case 13:
        case 16:
          num = Math.Exp(-Xin);
          break;
        case 6:
          num = Math.Pow(Math.Sin(Xin), 2.0);
          break;
        case 7:
        case 8:
          num = 1.0;
          break;
        case 9:
        case 14:
          num = Math.Exp(-Math.Pow(Xin, 2.0));
          break;
      }
      return num;
    }

    public double L1FKN2(double Xin)
    {
      return this.FA;
    }

    public double L1FQN2(double Xin)
    {
      return this.QA;
    }

    public double L1FN2(double Xin)
    {
      return this.FFA;
    }

    public double L1FEN(double Xin)
    {
      return this.C1 * Math.Exp(this.CC * Xin) + this.C2 * Math.Exp(-this.CC * Xin) + this.FC;
    }

    public double L2FKN(int Mode, double Xin)
    {
      double num;
      if (Mode == 1)
      {
        switch (this.MyTaskNo)
        {
          case 1:
            num = Math.Sin(2.0 * Math.PI * Xin) + 1.5;
            break;
          case 2:
          case 3:
          case 9:
          case 13:
            num = Math.Pow(Math.Cos(2.0 * Math.PI * Xin), 2.0) + 1.0;
            break;
          case 4:
          case 11:
            num = Math.Exp(Math.Sin(2.0 * Math.PI * Xin));
            break;
          case 5:
          case 15:
            num = 1.0;
            break;
          case 6:
            num = Math.Exp(-Math.Pow(Math.Sin(2.0 * Math.PI * Xin), 2.0));
            break;
          case 7:
          case 14:
            num = Math.Pow(Math.Cos(2.0 * Math.PI * Xin), 3.0) + 2.0;
            break;
          case 8:
            num = Math.Log(Math.Sin(2.0 * Math.PI * Xin) + 2.0);
            break;
          case 10:
            num = Math.Pow(Math.Sin(2.0 * Math.PI * Xin), 4.0) + 1.0;
            break;
          case 12:
            num = Math.Exp(-Math.Sin(2.0 * Math.PI * Xin));
            break;
          case 16:
            num = Math.Sin(2.0 * Math.PI * Xin) + 1.0;
            break;
        }
      }
      if (Mode == 2)
        num = this.L2FKN2(Mode, Xin);
      return num;
    }

    public double L2FQN(int Mode, double Xin)
    {
      double num;
      if (Mode == 1)
      {
        switch (this.MyTaskNo)
        {
          case 1:
          case 2:
          case 4:
          case 6:
          case 8:
          case 11:
          case 12:
            num = 1.0;
            break;
          case 3:
            num = Math.Sin(2.0 * Math.PI * Xin) + 1.5;
            break;
          case 5:
            num = Math.Exp(Math.Sin(2.0 * Math.PI * Xin));
            break;
          case 7:
            num = Math.Exp(Math.Sin(2.0 * Math.PI * Xin));
            break;
          case 9:
            num = Math.Log(2.0 + Math.Sin(2.0 * Math.PI * Xin));
            break;
          case 10:
          case 16:
            num = Math.Pow(Math.Cos(2.0 * Math.PI * Xin), 3.0) + 2.0;
            break;
          case 13:
            num = Math.Exp(Math.Sin(2.0 * Math.PI * Xin));
            break;
          case 14:
            num = Math.Sin(2.0 * Math.PI * Xin) + 1.5;
            break;
          case 15:
            num = Math.Log(2.0);
            break;
        }
      }
      if (Mode == 2)
        num = this.L2FQN2(Mode, Xin);
      return num;
    }

    public double L2FN(int Mode, double Xin)
    {
      double num;
      if (Mode == 1)
      {
        switch (this.MyTaskNo)
        {
          case 1:
          case 6:
          case 9:
          case 12:
          case 15:
            num = Math.Cos(2.0 * Math.PI * Xin);
            break;
          case 2:
          case 3:
          case 14:
            num = Math.Sin(2.0 * Math.PI * Xin);
            break;
          case 4:
            num = Math.Exp(Math.Sin(2.0 * Math.PI * Xin));
            break;
          case 5:
          case 10:
          case 11:
          case 13:
            num = Math.Exp(Math.Cos(2.0 * Math.PI * Xin));
            break;
          case 7:
          case 8:
          case 16:
            num = 1.0;
            break;
        }
      }
      if (Mode == 2)
        num = this.L2FN2(Mode, Xin);
      return num;
    }

    public double L2FKN2(int Mode, double Xin)
    {
      return this.FA;
    }

    public double L2FQN2(int Mode, double Xin)
    {
      return this.QA;
    }

    public double L2FN2(int Mode, double Xin)
    {
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
        case 6:
        case 7:
        case 9:
        case 11:
        case 13:
        case 15:
          num = Math.Cos(2.0 * Math.PI * Xin);
          break;
        case 2:
        case 3:
        case 8:
          num = Math.Sin(2.0 * Math.PI * Xin);
          break;
        case 4:
        case 14:
          num = 1.0 + Math.Sin(2.0 * Math.PI * Xin);
          break;
        case 5:
        case 10:
        case 12:
        case 16:
          num = 1.0 + Math.Cos(2.0 * Math.PI * Xin);
          break;
      }
      return num;
    }

    public double L2FEN(double Xin)
    {
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
        case 6:
        case 7:
        case 9:
        case 11:
        case 13:
        case 15:
          num = Math.Cos(2.0 * Math.PI * Xin) / (39.4784176043574 * this.FA + this.QA);
          break;
        case 2:
        case 3:
        case 8:
          num = Math.Sin(2.0 * Math.PI * Xin) / (39.4784176043574 * this.FA + this.QA);
          break;
        case 4:
          num = Math.Sin(2.0 * Math.PI * Xin) / (39.4784176043574 * this.FA + this.QA) + 1.0;
          break;
        case 5:
        case 12:
          num = Math.Cos(2.0 * Math.PI * Xin) / (39.4784176043574 * this.FA + this.QA) + 1.0;
          break;
        case 10:
        case 16:
          num = Math.Cos(2.0 * Math.PI * Xin) / (39.4784176043574 * this.FA + this.QA) + 1.0 / 3.0;
          break;
        case 14:
          num = Math.Sin(2.0 * Math.PI * Xin) / (39.4784176043574 * this.FA + this.QA) + 2.0 / 3.0;
          break;
      }
      return num;
    }

    public double FKN(int Mode, double Xin)
    {
      if (Mode == 1)
        Xin = this.X0;
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
          num = Xin * Xin + 1.0;
          break;
        case 2:
          num = Xin * Xin + 0.5;
          break;
        case 3:
          num = Math.Pow(Math.Sin(Xin), 2.0) + 1.0;
          break;
        case 4:
          num = Math.Exp(-Xin);
          break;
        case 5:
          num = 1.0;
          break;
        case 6:
          num = Math.Exp(-Xin * Xin);
          break;
        case 7:
          num = Math.Exp(Math.Sin(Xin));
          break;
        case 8:
          num = Math.Cos(Xin) + 2.0;
          break;
        case 9:
          num = 1.0;
          break;
        case 10:
          num = Xin * Xin + 0.5;
          break;
        case 11:
          num = Xin + 1.0;
          break;
        case 12:
          num = 1.0;
          break;
        case 13:
          num = Xin + 1.0;
          break;
        case 14:
          num = Xin;
          break;
        case 15:
          num = Xin + 1.0;
          break;
        case 16:
          num = Math.Exp(-Xin);
          break;
      }
      return num;
    }

    public double FQN(int Mode, double Xin)
    {
      if (Mode == 1)
        Xin = this.X0;
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
          num = Math.Exp(-Xin);
          break;
        case 2:
          num = 1.0;
          break;
        case 3:
          num = Xin;
          break;
        case 4:
          num = Math.Pow(Xin, 2.0);
          break;
        case 5:
          num = 1.0;
          break;
        case 6:
          num = Math.Pow(Xin, 2.0);
          break;
        case 7:
          num = 2.0;
          break;
        case 8:
          num = 1.0;
          break;
        case 9:
          num = Math.Pow(Xin, 2.0);
          break;
        case 10:
          num = Math.Exp(-Math.Pow(Xin, 2.0));
          break;
        case 11:
          num = Math.Pow(Xin, 2.0);
          break;
        case 12:
          num = Math.Pow(Xin, 2.0);
          break;
        case 13:
          num = Math.Exp(-Xin);
          break;
        case 14:
          num = Math.Exp(-Xin);
          break;
        case 15:
          num = Math.Exp(-Xin);
          break;
        case 16:
          num = Math.Pow(Xin, 3.0);
          break;
      }
      return num;
    }

    public double FFN(int Mode, double Xin)
    {
      if (Mode == 1)
        Xin = this.X0;
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
          num = 1.0;
          break;
        case 2:
          num = 1.0;
          break;
        case 3:
          num = 1.0;
          break;
        case 4:
          num = 1.0;
          break;
        case 5:
          num = Math.Exp(Xin);
          break;
        case 6:
          num = Math.Sin(Xin);
          break;
        case 7:
          num = Math.Exp(Xin);
          break;
        case 8:
          num = 2.0 * Xin;
          break;
        case 9:
          num = Math.Pow(Xin, 2.0) - 1.0;
          break;
        case 10:
          num = Math.Cos(Xin);
          break;
        case 11:
          num = Math.Cos(Xin);
          break;
        case 12:
          num = Math.Sin(Xin);
          break;
        case 13:
          num = 1.0;
          break;
        case 14:
          num = Math.Pow(Xin, 3.0);
          break;
        case 15:
          num = Math.Cos(Xin);
          break;
        case 16:
          num = Math.Pow(Xin, 2.0) - 1.0;
          break;
      }
      return num;
    }

    public double FKN2(int Mode, double Xin)
    {
      if (Mode == 1)
        Xin = this.X0;
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
          num = Xin;
          break;
        case 2:
          num = Math.Pow(Xin, 2.0) + 0.5;
          break;
        case 3:
          num = Math.Sin(Math.Pow(Xin, 2.0)) + 1.0;
          break;
        case 4:
          num = 1.0;
          break;
        case 5:
          num = Math.Exp(Math.Sin(Xin));
          break;
        case 6:
          num = Xin;
          break;
        case 7:
          num = 1.0;
          break;
        case 8:
          num = Math.Sin(Xin) + 2.0;
          break;
        case 9:
          num = Math.Exp(-Xin);
          break;
        case 10:
          num = Math.Pow(Xin, 2.0) + 0.5;
          break;
        case 11:
          num = Math.Pow(Xin, 2.0);
          break;
        case 12:
          num = Math.Exp(Math.Cos(Xin));
          break;
        case 13:
          num = Xin;
          break;
        case 14:
          num = Math.Pow(Xin, 2.0) + 1.0;
          break;
        case 15:
          num = Math.Pow(Xin, 2.0);
          break;
        case 16:
          num = Math.Exp(-Xin);
          break;
      }
      return num;
    }

    public double FQN2(int Mode, double Xin)
    {
      if (Mode == 1)
        Xin = this.X0;
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
          num = Math.Exp(-Xin);
          break;
        case 2:
          num = Math.Exp(-Math.Pow(Xin, 2.0));
          break;
        case 3:
          num = Math.Pow(Xin, 3.0);
          break;
        case 4:
          num = Math.Exp(-Math.Pow(Xin, 2.0));
          break;
        case 5:
          num = 2.0;
          break;
        case 6:
          num = Math.Pow(Xin, 2.0);
          break;
        case 7:
          num = 1.0;
          break;
        case 8:
          num = 1.0;
          break;
        case 9:
          num = Xin;
          break;
        case 10:
          num = 1.0;
          break;
        case 11:
          num = Math.Pow(Xin, 2.0);
          break;
        case 12:
          num = Math.Pow(Xin, 2.0);
          break;
        case 13:
          num = Math.Exp(-Xin);
          break;
        case 14:
          num = Math.Exp(-Xin);
          break;
        case 15:
          num = Math.Exp(-Xin);
          break;
        case 16:
          num = Xin;
          break;
      }
      return num;
    }

    public double FFN2(int Mode, double Xin)
    {
      if (Mode == 1)
        Xin = this.X0;
      double num;
      switch (this.MyTaskNo)
      {
        case 1:
          num = Math.Pow(Xin, 3.0);
          break;
        case 2:
          num = Math.Cos(Xin);
          break;
        case 3:
          num = Math.Pow(Xin, 2.0) - 1.0;
          break;
        case 4:
          num = Math.Cos(Xin);
          break;
        case 5:
          num = Math.Exp(Xin);
          break;
        case 6:
          num = Math.Sin(Xin);
          break;
        case 7:
          num = Math.Exp(Xin);
          break;
        case 8:
          num = 0.0;
          break;
        case 9:
          num = 1.0;
          break;
        case 10:
          num = 1.0;
          break;
        case 11:
          num = Math.Cos(Xin);
          break;
        case 12:
          num = Math.Sin(Xin);
          break;
        case 13:
          num = Math.Pow(Xin, 3.0);
          break;
        case 14:
          num = 1.0;
          break;
        case 15:
          num = 1.0;
          break;
        case 16:
          num = 1.0;
          break;
      }
      return num;
    }
  }
}
