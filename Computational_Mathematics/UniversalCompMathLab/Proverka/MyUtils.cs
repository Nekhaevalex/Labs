// Decompiled with JetBrains decompiler
// Type: Proverka.MyUtils
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Proverka
{
  internal class MyUtils
  {
    private Cursor MyOldCursor;
    private bool MyWaitCursorSet;

    public MyUtils()
    {
      this.MyWaitCursorSet = false;
    }

    public string MyDblToStr(double dbl_in)
    {
      return Strings.Replace(dbl_in.ToString("0.0000##E+00"), ",", ".", 1, -1, CompareMethod.Binary);
    }

    public double MyStrToDbl(string str_in)
    {
      return double.Parse(Strings.Replace(str_in, ".", ",", 1, -1, CompareMethod.Binary));
    }

    public double MyRound2(double val)
    {
      return Math.Truncate(Math.Round(val * 100.0)) / 100.0;
    }

    public double MyRound4(double val)
    {
      return Math.Truncate(Math.Round(val * 10000000.0)) / 10000000.0;
    }

    public void MyCheckNumKeyDown(ref KeyEventArgs e)
    {
      if (!(e.KeyCode != Keys.D0 & e.KeyCode != Keys.D1 & e.KeyCode != Keys.D2 & e.KeyCode != Keys.D3 & e.KeyCode != Keys.D4 & e.KeyCode != Keys.D5 & e.KeyCode != Keys.D6 & e.KeyCode != Keys.D6 & e.KeyCode != Keys.D7 & e.KeyCode != Keys.D8 & e.KeyCode != Keys.D9 & e.KeyCode != Keys.NumPad0 & e.KeyCode != Keys.NumPad1 & e.KeyCode != Keys.NumPad2 & e.KeyCode != Keys.NumPad3 & e.KeyCode != Keys.NumPad4 & e.KeyCode != Keys.NumPad5 & e.KeyCode != Keys.NumPad6 & e.KeyCode != Keys.NumPad7 & e.KeyCode != Keys.NumPad8 & e.KeyCode != Keys.NumPad9 & e.KeyCode != Keys.OemMinus & e.KeyCode != Keys.Oemplus & e.KeyCode != Keys.OemPeriod & e.KeyCode != Keys.Left & e.KeyCode != Keys.Right & e.KeyCode != Keys.E & e.KeyCode != Keys.Delete & e.KeyCode != Keys.Back & e.KeyCode != Keys.Home & e.KeyCode != Keys.End & e.KeyCode != Keys.Escape & e.KeyCode != Keys.Decimal & e.KeyCode != Keys.Add & e.KeyCode != Keys.Subtract | e.Shift & e.KeyValue != 187 | e.Alt | e.Control))
        return;
      e.Handled = true;
      e.SuppressKeyPress = true;
    }

    public void MyCheckIsDigitKeyDown(ref KeyEventArgs e)
    {
      if (!(e.KeyCode != Keys.D0 & e.KeyCode != Keys.D1 & e.KeyCode != Keys.D2 & e.KeyCode != Keys.D3 & e.KeyCode != Keys.D4 & e.KeyCode != Keys.D5 & e.KeyCode != Keys.D6 & e.KeyCode != Keys.D7 & e.KeyCode != Keys.D8 & e.KeyCode != Keys.D9 & e.KeyCode != Keys.NumPad0 & e.KeyCode != Keys.NumPad1 & e.KeyCode != Keys.NumPad2 & e.KeyCode != Keys.NumPad3 & e.KeyCode != Keys.NumPad4 & e.KeyCode != Keys.NumPad5 & e.KeyCode != Keys.NumPad6 & e.KeyCode != Keys.NumPad7 & e.KeyCode != Keys.NumPad8 & e.KeyCode != Keys.NumPad9 & e.KeyCode != Keys.OemMinus & e.KeyCode != Keys.Left & e.KeyCode != Keys.Right & e.KeyCode != Keys.Delete & e.KeyCode != Keys.Back & e.KeyCode != Keys.Home & e.KeyCode != Keys.End & e.KeyCode != Keys.Escape & e.KeyCode != Keys.Subtract | e.Shift | e.Alt | e.Control))
        return;
      e.Handled = true;
      e.SuppressKeyPress = true;
    }

    public bool MyCheckNumValue(ref TextBox txtBox)
    {
      string text = txtBox.Text;
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = text.Length - 1;
      bool flag;
      for (int index = 0; index <= num5; ++index)
      {
        flag = false;
        if (!char.IsDigit(text[index]))
        {
          char lower = text[index];
          if (lower.Equals('.'))
          {
            ++num1;
            flag = true;
          }
          lower = text[index];
          if (lower.Equals('+'))
          {
            ++num2;
            flag = true;
          }
          lower = text[index];
          if (lower.Equals('-'))
          {
            ++num3;
            flag = true;
          }
          lower = char.ToLower(text[index]);
          if (lower.Equals('e'))
          {
            ++num4;
            flag = true;
          }
        }
        else
          flag = true;
        if (!flag)
          break;
      }
      if (flag & (num1 > 1 | num2 > 2 | num3 > 2 | num4 > 1))
        flag = false;
      if (flag)
      {
        if (text.Contains("--"))
          flag = false;
        if (flag & text.Contains("++"))
          flag = false;
        if (flag & text.EndsWith("-"))
          flag = false;
        if (flag & text.EndsWith("+"))
          flag = false;
        if (flag & text.EndsWith("."))
          flag = false;
        if (flag & text.EndsWith("e"))
          flag = false;
        if (flag & num4 > 0)
        {
          if (!text.ToLower().Contains("e-") & !text.ToLower().Contains("e+"))
            flag = false;
          if ((uint) (-(flag & text.ToLower().IndexOf("e") < -(flag ? 1 : 0) ? 1 : 0) & text.ToLower().IndexOf(".")) > 0U)
            flag = false;
          if (flag & text.ToLower().StartsWith("e"))
            flag = false;
        }
        if (flag & num4 == 0 && num3 == 2 | num2 == 2 | text.IndexOf("-") > 0 | text.IndexOf("+") > 0)
          flag = false;
        if (flag & num2 == 2 & !text.StartsWith("+"))
          flag = false;
        if (flag & num3 == 2 & !text.StartsWith("-"))
          flag = false;
        if (flag & num3 + num2 == 2 & (!text.StartsWith("-") & !text.StartsWith("+")))
          flag = false;
      }
      if (!flag)
      {
        int num6 = (int) Interaction.MsgBox((object) ("Значение " + text + " не является числом!"), MsgBoxStyle.Exclamation, (object) "Ошибка ввода");
      }
      return flag;
    }

    public void MyDrawFigure(Array datX, Array datY, ref Graphics g, int w, int h)
    {
      double num1 = 0.2;
      double num2 = 0.1;
      Font font = new Font("Arial", 12f);
      SolidBrush solidBrush = new SolidBrush(Color.Black);
      StringFormat format = new StringFormat();
      Pen pen = new Pen(Color.Black);
      pen.DashStyle = DashStyle.Dot;
      double val1 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datX, new object[1]
      {
        (object) 1
      }, (string[]) null));
      double val2 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datX, new object[1]
      {
        (object) 1
      }, (string[]) null));
      double val3 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datY, new object[1]
      {
        (object) 1
      }, (string[]) null));
      double val4 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datY, new object[1]
      {
        (object) 1
      }, (string[]) null));
      int num3 = datX.GetLength(0) - 1;
      int num4 = num3;
      for (int index = 2; index <= num4; ++index)
      {
        double num5 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) index
        }, (string[]) null));
        if (num5 > val1)
          val1 = num5;
        if (num5 < val2)
          val2 = num5;
      }
      int num6 = num3;
      for (int index = 2; index <= num6; ++index)
      {
        double num5 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datY, new object[1]
        {
          (object) index
        }, (string[]) null));
        if (num5 > val3)
          val3 = num5;
        if (num5 < val4)
          val4 = num5;
      }
      string str1 = this.MyRound4(val1).ToString();
      string str2 = this.MyRound4(val2).ToString();
      double num7 = this.MyRound4(val3);
      string str3 = num7.ToString();
      num7 = this.MyRound4(val4);
      string str4 = num7.ToString();
      int num8 = (int) Math.Round((1.0 + 2.0 * num2) * (double) g.MeasureString(str4, font).Width);
      int num9 = (int) Math.Round((1.0 + 2.0 * num2) * (double) g.MeasureString(str3, font).Width);
      int x1 = num8;
      if (x1 < num9)
        x1 = num9;
      int num10 = (int) Math.Round(0.5 * (double) x1);
      int width1 = w - x1 - num10;
      int num11 = (int) Math.Round((1.0 + 2.0 * num1) * (double) g.MeasureString(str1, font).Height);
      int y1 = num11;
      int height1 = h - y1 - num11;
      if (width1 <= 0 | height1 <= 0)
      {
        width1 = (int) Math.Round(0.8 * (double) w);
        height1 = (int) Math.Round(0.8 * (double) h);
      }
      int num12 = num3 - 1;
      for (int index = 1; index <= num12; ++index)
      {
        int integer1 = Conversions.ToInteger(Operators.AddObject((object) x1, Operators.DivideObject(Operators.MultiplyObject((object) width1, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) index
        }, (string[]) null), (object) val2)), (object) (val1 - val2))));
        int integer2 = Conversions.ToInteger(Operators.AddObject((object) y1, Operators.DivideObject(Operators.MultiplyObject((object) height1, Operators.SubtractObject((object) val3, NewLateBinding.LateIndexGet((object) datY, new object[1]
        {
          (object) index
        }, (string[]) null))), (object) (val3 - val4))));
        int integer3 = Conversions.ToInteger(Operators.AddObject((object) x1, Operators.DivideObject(Operators.MultiplyObject((object) width1, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null), (object) val2)), (object) (val1 - val2))));
        int integer4 = Conversions.ToInteger(Operators.AddObject((object) y1, Operators.DivideObject(Operators.MultiplyObject((object) height1, Operators.SubtractObject((object) val3, NewLateBinding.LateIndexGet((object) datY, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null))), (object) (val3 - val4))));
        g.DrawLine(Pens.Blue, integer1, integer2, integer3, integer4);
      }
      Graphics graphics1 = g;
      Pen black1 = Pens.Black;
      Rectangle rectangle = new Rectangle(0, 0, w - 1, h - 1);
      Rectangle rect1 = rectangle;
      graphics1.DrawRectangle(black1, rect1);
      Graphics graphics2 = g;
      Pen black2 = Pens.Black;
      rectangle = new Rectangle(x1, y1, width1, height1);
      Rectangle rect2 = rectangle;
      graphics2.DrawRectangle(black2, rect2);
      float x2 = (float) (x1 + (int) Math.Round(num2 * (double) g.MeasureString(str2, font).Width));
      float y2 = (float) (y1 + height1 + (int) Math.Round(num1 * (double) g.MeasureString(str2, font).Height));
      g.DrawString(str2, font, (Brush) solidBrush, x2, y2, format);
      float x3 = (float) (x1 + width1 - (int) Math.Round((1.0 + num2) * (double) g.MeasureString(str1, font).Width));
      g.DrawString(str1, font, (Brush) solidBrush, x3, y2, format);
      float x4 = (float) (int) Math.Round((double) x1 + 0.5 * (double) width1 - 0.5 * (double) g.MeasureString("X", font).Width);
      g.DrawString("X", font, (Brush) solidBrush, x4, y2, format);
      double num13 = num2;
      SizeF sizeF = g.MeasureString(str3, font);
      double width2 = (double) sizeF.Width;
      float x5 = (float) (int) Math.Round(num13 * width2);
      double num14 = (double) y1;
      double num15 = num1;
      sizeF = g.MeasureString(str3, font);
      double height2 = (double) sizeF.Height;
      double num16 = num15 * height2;
      float y3 = (float) (int) Math.Round(num14 + num16);
      g.DrawString(str3, font, (Brush) solidBrush, x5, y3, format);
      int num17 = y1 + height1;
      double num18 = 1.0 + num1;
      sizeF = g.MeasureString(str4, font);
      double height3 = (double) sizeF.Height;
      int num19 = (int) Math.Round(num18 * height3);
      float y4 = (float) (num17 - num19);
      g.DrawString(str4, font, (Brush) solidBrush, x5, y4, format);
      double num20 = 0.5 * (double) x1;
      sizeF = g.MeasureString("Y", font);
      double num21 = 0.5 * (double) sizeF.Width;
      float x6 = (float) (int) Math.Round(num20 - num21);
      double num22 = (double) y1 + 0.5 * (double) height1;
      sizeF = g.MeasureString("Y", font);
      double num23 = 0.5 * (double) sizeF.Height;
      float y5 = (float) (int) Math.Round(num22 - num23);
      g.DrawString("Y", font, (Brush) solidBrush, x6, y5, format);
      int y1_1 = y1;
      int y2_1 = y1 + height1;
      int num24 = 1;
      do
      {
        int x1_1 = (int) Math.Round((double) x1 + (double) (num24 * width1) / 6.0);
        int x2_1 = x1_1;
        g.DrawLine(pen, x1_1, y1_1, x2_1, y2_1);
        ++num24;
      }
      while (num24 <= 5);
      int x1_2 = x1;
      int x2_2 = x1 + width1;
      int num25 = 1;
      do
      {
        int y1_2 = (int) Math.Round((double) y1 + (double) (num25 * height1) / 6.0);
        int y2_2 = y1_2;
        g.DrawLine(pen, x1_2, y1_2, x2_2, y2_2);
        ++num25;
      }
      while (num25 <= 5);
      pen.Dispose();
      font.Dispose();
      solidBrush.Dispose();
    }

    public void MyDrawFigure2(
      ref Array datX,
      ref Array datY1,
      ref Array datY2,
      ref Graphics g,
      int w,
      int h)
    {
      double num1 = 0.2;
      double num2 = 0.1;
      Font font = new Font("Arial", 12f);
      SolidBrush solidBrush = new SolidBrush(Color.Black);
      StringFormat format = new StringFormat();
      Pen pen = new Pen(Color.Black);
      pen.DashStyle = DashStyle.Dot;
      double val1 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datX, new object[1]
      {
        (object) 1
      }, (string[]) null));
      double val2 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datX, new object[1]
      {
        (object) 1
      }, (string[]) null));
      double val3 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datY1, new object[1]
      {
        (object) 1
      }, (string[]) null));
      double val4 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datY1, new object[1]
      {
        (object) 1
      }, (string[]) null));
      int num3 = datX.GetLength(0) - 1;
      int num4 = num3;
      for (int index = 2; index <= num4; ++index)
      {
        double num5 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) index
        }, (string[]) null));
        if (num5 > val1)
          val1 = num5;
        if (num5 < val2)
          val2 = num5;
      }
      int num6 = num3;
      for (int index = 2; index <= num6; ++index)
      {
        double num5 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datY1, new object[1]
        {
          (object) index
        }, (string[]) null));
        if (num5 > val3)
          val3 = num5;
        if (num5 < val4)
          val4 = num5;
      }
      int num7 = num3;
      for (int index = 1; index <= num7; ++index)
      {
        double num5 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datY2, new object[1]
        {
          (object) index
        }, (string[]) null));
        if (num5 > val3)
          val3 = num5;
        if (num5 < val4)
          val4 = num5;
      }
      string str1 = this.MyRound4(val1).ToString();
      string str2 = this.MyRound4(val2).ToString();
      double num8 = this.MyRound4(val3);
      string str3 = num8.ToString();
      num8 = this.MyRound4(val4);
      string str4 = num8.ToString();
      int num9 = (int) Math.Round((1.0 + 2.0 * num2) * (double) g.MeasureString(str4, font).Width);
      int num10 = (int) Math.Round((1.0 + 2.0 * num2) * (double) g.MeasureString(str3, font).Width);
      int x1 = num9;
      if (x1 < num10)
        x1 = num10;
      int num11 = (int) Math.Round(0.5 * (double) x1);
      int width1 = w - x1 - num11;
      int num12 = (int) Math.Round((1.0 + 2.0 * num1) * (double) g.MeasureString(str1, font).Height);
      int y1 = num12;
      int height1 = h - y1 - num12;
      if (width1 <= 0 | height1 <= 0)
      {
        width1 = (int) Math.Round(0.8 * (double) w);
        height1 = (int) Math.Round(0.8 * (double) h);
      }
      int num13 = num3 - 1;
      for (int index = 1; index <= num13; ++index)
      {
        int integer1 = Conversions.ToInteger(Operators.AddObject((object) x1, Operators.DivideObject(Operators.MultiplyObject((object) width1, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) index
        }, (string[]) null), (object) val2)), (object) (val1 - val2))));
        int integer2 = Conversions.ToInteger(Operators.AddObject((object) y1, Operators.DivideObject(Operators.MultiplyObject((object) height1, Operators.SubtractObject((object) val3, NewLateBinding.LateIndexGet((object) datY1, new object[1]
        {
          (object) index
        }, (string[]) null))), (object) (val3 - val4))));
        int integer3 = Conversions.ToInteger(Operators.AddObject((object) x1, Operators.DivideObject(Operators.MultiplyObject((object) width1, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null), (object) val2)), (object) (val1 - val2))));
        int integer4 = Conversions.ToInteger(Operators.AddObject((object) y1, Operators.DivideObject(Operators.MultiplyObject((object) height1, Operators.SubtractObject((object) val3, NewLateBinding.LateIndexGet((object) datY1, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null))), (object) (val3 - val4))));
        g.DrawLine(Pens.Blue, integer1, integer2, integer3, integer4);
      }
      int num14 = num3 - 1;
      for (int index = 1; index <= num14; ++index)
      {
        int integer1 = Conversions.ToInteger(Operators.AddObject((object) x1, Operators.DivideObject(Operators.MultiplyObject((object) width1, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) index
        }, (string[]) null), (object) val2)), (object) (val1 - val2))));
        int integer2 = Conversions.ToInteger(Operators.AddObject((object) y1, Operators.DivideObject(Operators.MultiplyObject((object) height1, Operators.SubtractObject((object) val3, NewLateBinding.LateIndexGet((object) datY2, new object[1]
        {
          (object) index
        }, (string[]) null))), (object) (val3 - val4))));
        int integer3 = Conversions.ToInteger(Operators.AddObject((object) x1, Operators.DivideObject(Operators.MultiplyObject((object) width1, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null), (object) val2)), (object) (val1 - val2))));
        int integer4 = Conversions.ToInteger(Operators.AddObject((object) y1, Operators.DivideObject(Operators.MultiplyObject((object) height1, Operators.SubtractObject((object) val3, NewLateBinding.LateIndexGet((object) datY2, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null))), (object) (val3 - val4))));
        g.DrawLine(Pens.Red, integer1, integer2, integer3, integer4);
      }
      Graphics graphics1 = g;
      Pen black1 = Pens.Black;
      Rectangle rectangle = new Rectangle(0, 0, w - 1, h - 1);
      Rectangle rect1 = rectangle;
      graphics1.DrawRectangle(black1, rect1);
      Graphics graphics2 = g;
      Pen black2 = Pens.Black;
      rectangle = new Rectangle(x1, y1, width1, height1);
      Rectangle rect2 = rectangle;
      graphics2.DrawRectangle(black2, rect2);
      float x2 = (float) (x1 + (int) Math.Round(num2 * (double) g.MeasureString(str2, font).Width));
      float y2 = (float) (y1 + height1 + (int) Math.Round(num1 * (double) g.MeasureString(str2, font).Height));
      g.DrawString(str2, font, (Brush) solidBrush, x2, y2, format);
      float x3 = (float) (x1 + width1 - (int) Math.Round((1.0 + num2) * (double) g.MeasureString(str1, font).Width));
      g.DrawString(str1, font, (Brush) solidBrush, x3, y2, format);
      double num15 = (double) x1 + 0.5 * (double) width1;
      SizeF sizeF = g.MeasureString("X", font);
      double num16 = 0.5 * (double) sizeF.Width;
      float x4 = (float) (int) Math.Round(num15 - num16);
      g.DrawString("X", font, (Brush) solidBrush, x4, y2, format);
      double num17 = num2;
      sizeF = g.MeasureString(str3, font);
      double width2 = (double) sizeF.Width;
      float x5 = (float) (int) Math.Round(num17 * width2);
      double num18 = (double) y1;
      double num19 = num1;
      sizeF = g.MeasureString(str3, font);
      double height2 = (double) sizeF.Height;
      double num20 = num19 * height2;
      float y3 = (float) (int) Math.Round(num18 + num20);
      g.DrawString(str3, font, (Brush) solidBrush, x5, y3, format);
      int num21 = y1 + height1;
      double num22 = 1.0 + num1;
      sizeF = g.MeasureString(str4, font);
      double height3 = (double) sizeF.Height;
      int num23 = (int) Math.Round(num22 * height3);
      float y4 = (float) (num21 - num23);
      g.DrawString(str4, font, (Brush) solidBrush, x5, y4, format);
      double num24 = 0.5 * (double) x1;
      sizeF = g.MeasureString("Y", font);
      double num25 = 0.5 * (double) sizeF.Width;
      float x6 = (float) (int) Math.Round(num24 - num25);
      double num26 = (double) y1 + 0.5 * (double) height1;
      sizeF = g.MeasureString("Y", font);
      double num27 = 0.5 * (double) sizeF.Height;
      float y5 = (float) (int) Math.Round(num26 - num27);
      g.DrawString("Y", font, (Brush) solidBrush, x6, y5, format);
      int y1_1 = y1;
      int y2_1 = y1 + height1;
      int num28 = 1;
      do
      {
        int x1_1 = (int) Math.Round((double) x1 + (double) (num28 * width1) / 6.0);
        int x2_1 = x1_1;
        g.DrawLine(pen, x1_1, y1_1, x2_1, y2_1);
        ++num28;
      }
      while (num28 <= 5);
      int x1_2 = x1;
      int x2_2 = x1 + width1;
      int num29 = 1;
      do
      {
        int y1_2 = (int) Math.Round((double) y1 + (double) (num29 * height1) / 6.0);
        int y2_2 = y1_2;
        g.DrawLine(pen, x1_2, y1_2, x2_2, y2_2);
        ++num29;
      }
      while (num29 <= 5);
      pen.Dispose();
      font.Dispose();
      solidBrush.Dispose();
    }

    public void MyDrawFigure1(Array datX, Array datY, int Nsz, ref Graphics g, int w, int h)
    {
      double num1 = 0.2;
      double num2 = 0.1;
      Font font = new Font("Arial", 12f);
      SolidBrush solidBrush = new SolidBrush(Color.Black);
      StringFormat format = new StringFormat();
      Pen pen = new Pen(Color.Black);
      pen.DashStyle = DashStyle.Dot;
      double val1 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datX, new object[1]
      {
        (object) 1
      }, (string[]) null));
      double val2 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datX, new object[1]
      {
        (object) 1
      }, (string[]) null));
      double val3 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datY, new object[1]
      {
        (object) 1
      }, (string[]) null));
      double val4 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datY, new object[1]
      {
        (object) 1
      }, (string[]) null));
      int num3 = datX.GetLength(0) - 1;
      int num4 = Nsz;
      for (int index = 2; index <= num4; ++index)
      {
        double num5 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) index
        }, (string[]) null));
        if (num5 > val1)
          val1 = num5;
        if (num5 < val2)
          val2 = num5;
      }
      int num6 = Nsz;
      for (int index = 2; index <= num6; ++index)
      {
        double num5 = Conversions.ToDouble(NewLateBinding.LateIndexGet((object) datY, new object[1]
        {
          (object) index
        }, (string[]) null));
        if (num5 > val3)
          val3 = num5;
        if (num5 < val4)
          val4 = num5;
      }
      string str1 = this.MyRound4(val1).ToString();
      string str2 = this.MyRound4(val2).ToString();
      double num7 = this.MyRound4(val3);
      string str3 = num7.ToString();
      num7 = this.MyRound4(val4);
      string str4 = num7.ToString();
      int num8 = (int) Math.Round((1.0 + 2.0 * num2) * (double) g.MeasureString(str4, font).Width);
      int num9 = (int) Math.Round((1.0 + 2.0 * num2) * (double) g.MeasureString(str3, font).Width);
      int x1 = num8;
      if (x1 < num9)
        x1 = num9;
      int num10 = (int) Math.Round(0.5 * (double) x1);
      int width1 = w - x1 - num10;
      int num11 = (int) Math.Round((1.0 + 2.0 * num1) * (double) g.MeasureString(str1, font).Height);
      int y1 = num11;
      int height1 = h - y1 - num11;
      if (width1 <= 0 | height1 <= 0)
      {
        width1 = (int) Math.Round(0.8 * (double) w);
        height1 = (int) Math.Round(0.8 * (double) h);
      }
      int num12 = Nsz - 1;
      for (int index = 1; index <= num12; ++index)
      {
        int integer1 = Conversions.ToInteger(Operators.AddObject((object) x1, Operators.DivideObject(Operators.MultiplyObject((object) width1, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) index
        }, (string[]) null), (object) val2)), (object) (val1 - val2))));
        int integer2 = Conversions.ToInteger(Operators.AddObject((object) y1, Operators.DivideObject(Operators.MultiplyObject((object) height1, Operators.SubtractObject((object) val3, NewLateBinding.LateIndexGet((object) datY, new object[1]
        {
          (object) index
        }, (string[]) null))), (object) (val3 - val4))));
        int integer3 = Conversions.ToInteger(Operators.AddObject((object) x1, Operators.DivideObject(Operators.MultiplyObject((object) width1, Operators.SubtractObject(NewLateBinding.LateIndexGet((object) datX, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null), (object) val2)), (object) (val1 - val2))));
        int integer4 = Conversions.ToInteger(Operators.AddObject((object) y1, Operators.DivideObject(Operators.MultiplyObject((object) height1, Operators.SubtractObject((object) val3, NewLateBinding.LateIndexGet((object) datY, new object[1]
        {
          (object) (index + 1)
        }, (string[]) null))), (object) (val3 - val4))));
        g.DrawLine(Pens.Green, integer1, integer2, integer3, integer4);
      }
      Graphics graphics1 = g;
      Pen black1 = Pens.Black;
      Rectangle rectangle = new Rectangle(0, 0, w - 1, h - 1);
      Rectangle rect1 = rectangle;
      graphics1.DrawRectangle(black1, rect1);
      Graphics graphics2 = g;
      Pen black2 = Pens.Black;
      rectangle = new Rectangle(x1, y1, width1, height1);
      Rectangle rect2 = rectangle;
      graphics2.DrawRectangle(black2, rect2);
      float x2 = (float) (x1 + (int) Math.Round(num2 * (double) g.MeasureString(str2, font).Width));
      float y2 = (float) (y1 + height1 + (int) Math.Round(num1 * (double) g.MeasureString(str2, font).Height));
      g.DrawString(str2, font, (Brush) solidBrush, x2, y2, format);
      float x3 = (float) (x1 + width1 - (int) Math.Round((1.0 + num2) * (double) g.MeasureString(str1, font).Width));
      g.DrawString(str1, font, (Brush) solidBrush, x3, y2, format);
      float x4 = (float) (int) Math.Round((double) x1 + 0.5 * (double) width1 - 0.5 * (double) g.MeasureString("X", font).Width);
      g.DrawString("X", font, (Brush) solidBrush, x4, y2, format);
      double num13 = num2;
      SizeF sizeF = g.MeasureString(str3, font);
      double width2 = (double) sizeF.Width;
      float x5 = (float) (int) Math.Round(num13 * width2);
      double num14 = (double) y1;
      double num15 = num1;
      sizeF = g.MeasureString(str3, font);
      double height2 = (double) sizeF.Height;
      double num16 = num15 * height2;
      float y3 = (float) (int) Math.Round(num14 + num16);
      g.DrawString(str3, font, (Brush) solidBrush, x5, y3, format);
      int num17 = y1 + height1;
      double num18 = 1.0 + num1;
      sizeF = g.MeasureString(str4, font);
      double height3 = (double) sizeF.Height;
      int num19 = (int) Math.Round(num18 * height3);
      float y4 = (float) (num17 - num19);
      g.DrawString(str4, font, (Brush) solidBrush, x5, y4, format);
      double num20 = 0.5 * (double) x1;
      sizeF = g.MeasureString("Y", font);
      double num21 = 0.5 * (double) sizeF.Width;
      float x6 = (float) (int) Math.Round(num20 - num21);
      double num22 = (double) y1 + 0.5 * (double) height1;
      sizeF = g.MeasureString("Y", font);
      double num23 = 0.5 * (double) sizeF.Height;
      float y5 = (float) (int) Math.Round(num22 - num23);
      g.DrawString("Y", font, (Brush) solidBrush, x6, y5, format);
      int y1_1 = y1;
      int y2_1 = y1 + height1;
      int num24 = 1;
      do
      {
        int x1_1 = (int) Math.Round((double) x1 + (double) (num24 * width1) / 6.0);
        int x2_1 = x1_1;
        g.DrawLine(pen, x1_1, y1_1, x2_1, y2_1);
        ++num24;
      }
      while (num24 <= 5);
      int x1_2 = x1;
      int x2_2 = x1 + width1;
      int num25 = 1;
      do
      {
        int y1_2 = (int) Math.Round((double) y1 + (double) (num25 * height1) / 6.0);
        int y2_2 = y1_2;
        g.DrawLine(pen, x1_2, y1_2, x2_2, y2_2);
        ++num25;
      }
      while (num25 <= 5);
      pen.Dispose();
      font.Dispose();
      solidBrush.Dispose();
    }

    public void SetWaitCursor(ref Form frm)
    {
      if (this.MyWaitCursorSet)
        return;
      this.MyOldCursor = frm.Cursor;
      frm.Cursor = Cursors.WaitCursor;
      this.MyWaitCursorSet = true;
    }

    public void RestoreCursor(ref Form frm)
    {
      if (!this.MyWaitCursorSet)
        return;
      frm.Cursor = this.MyOldCursor;
      this.MyWaitCursorSet = false;
    }

    public void ResizePicBoxToImage(ref PictureBox pb)
    {
      pb.Width = pb.Image.Width;
      pb.Height = pb.Image.Height;
    }

    public void FillArray(
      ref Array arr,
      double x1,
      double x2,
      double x3,
      double x4,
      double x5,
      double x6,
      double x7,
      double x8,
      double x9,
      double x10)
    {
      arr = Array.CreateInstance(typeof (double), 10);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 0,
        (object) x1
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 1,
        (object) x2
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 2,
        (object) x3
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 3,
        (object) x4
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 4,
        (object) x5
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 5,
        (object) x6
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 6,
        (object) x7
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 7,
        (object) x8
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 8,
        (object) x9
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 9,
        (object) x10
      }, (string[]) null);
    }

    public void FillArray(
      ref Array arr,
      double x1,
      double x2,
      double x3,
      double x4,
      double x5,
      double x6,
      double x7,
      double x8)
    {
      arr = Array.CreateInstance(typeof (double), 8);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 0,
        (object) x1
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 1,
        (object) x2
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 2,
        (object) x3
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 3,
        (object) x4
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 4,
        (object) x5
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 5,
        (object) x6
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 6,
        (object) x7
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 7,
        (object) x8
      }, (string[]) null);
    }

    public void FillArray(
      ref Array arr,
      double x1,
      double x2,
      double x3,
      double x4,
      double x5,
      double x6,
      double x7)
    {
      arr = Array.CreateInstance(typeof (double), 7);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 0,
        (object) x1
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 1,
        (object) x2
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 2,
        (object) x3
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 3,
        (object) x4
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 4,
        (object) x5
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 5,
        (object) x6
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 6,
        (object) x7
      }, (string[]) null);
    }

    public void FillArray(
      ref Array arr,
      double x1,
      double x2,
      double x3,
      double x4,
      double x5,
      double x6)
    {
      arr = Array.CreateInstance(typeof (double), 6);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 0,
        (object) x1
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 1,
        (object) x2
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 2,
        (object) x3
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 3,
        (object) x4
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 4,
        (object) x5
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 5,
        (object) x6
      }, (string[]) null);
    }

    public void FillArray(ref Array arr, double x1, double x2, double x3, double x4, double x5)
    {
      arr = Array.CreateInstance(typeof (double), 5);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 0,
        (object) x1
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 1,
        (object) x2
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 2,
        (object) x3
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 3,
        (object) x4
      }, (string[]) null);
      NewLateBinding.LateIndexSet((object) arr, new object[2]
      {
        (object) 4,
        (object) x5
      }, (string[]) null);
    }
  }
}
