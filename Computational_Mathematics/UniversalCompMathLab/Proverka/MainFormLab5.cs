// Decompiled with JetBrains decompiler
// Type: Proverka.MainFormLab5
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using Proverka.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Proverka
{
  [DesignerGenerated]
  public class MainFormLab5 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("NLabel")]
    private Label _NLabel;
    [AccessedThroughProperty("KLabel")]
    private Label _KLabel;
    [AccessedThroughProperty("UsloviePicBox")]
    private PictureBox _UsloviePicBox;
    [AccessedThroughProperty("ShemaPicBox")]
    private PictureBox _ShemaPicBox;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("ZadachaNo")]
    private NumericUpDown _ZadachaNo;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("BtnClear")]
    private Button _BtnClear;
    [AccessedThroughProperty("BtnFigure")]
    private Button _BtnFigure;
    [AccessedThroughProperty("BtnStart")]
    private Button _BtnStart;
    [AccessedThroughProperty("VariantNo")]
    private NumericUpDown _VariantNo;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Otvet")]
    private ListView _Otvet;
    [AccessedThroughProperty("Ntxt")]
    private TextBox _Ntxt;
    [AccessedThroughProperty("Ktxt")]
    private TextBox _Ktxt;
    [AccessedThroughProperty("NDecrBtn")]
    private Button _NDecrBtn;
    [AccessedThroughProperty("NIncrBtn")]
    private Button _NIncrBtn;
    [AccessedThroughProperty("GoBtn")]
    private Button _GoBtn;
    [AccessedThroughProperty("BtnExit")]
    private Button _BtnExit;
    private MyUtils ut;
    private NumericLab5 calc;
    private byte stage;
    private StreamReader fileReader;
    private string strReader;
    private int varNo;
    private int taskNo;
    private Graphics g;

    public MainFormLab5()
    {
      this.FormClosed += new FormClosedEventHandler(this.MainFormLab5_FormClosed);
      this.ut = new MyUtils();
      this.calc = new NumericLab5();
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.NLabel = new Label();
      this.KLabel = new Label();
      this.GoBtn = new Button();
      this.Ktxt = new TextBox();
      this.NDecrBtn = new Button();
      this.NIncrBtn = new Button();
      this.Ntxt = new TextBox();
      this.UsloviePicBox = new PictureBox();
      this.ShemaPicBox = new PictureBox();
      this.GroupBox2 = new GroupBox();
      this.BtnExit = new Button();
      this.ZadachaNo = new NumericUpDown();
      this.Label8 = new Label();
      this.BtnClear = new Button();
      this.BtnFigure = new Button();
      this.BtnStart = new Button();
      this.VariantNo = new NumericUpDown();
      this.Label7 = new Label();
      this.Otvet = new ListView();
      ((ISupportInitialize) this.UsloviePicBox).BeginInit();
      ((ISupportInitialize) this.ShemaPicBox).BeginInit();
      this.GroupBox2.SuspendLayout();
      this.ZadachaNo.BeginInit();
      this.VariantNo.BeginInit();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label1_1 = this.Label1;
      Point point1 = new Point(12, 9);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(93, 20);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "1. Задача";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label2_1 = this.Label2;
      point1 = new Point(492, 9);
      Point point3 = point1;
      label2_1.Location = point3;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(182, 20);
      Size size3 = size1;
      label2_2.Size = size3;
      this.Label2.TabIndex = 0;
      this.Label2.Text = "2. Разностная схема";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label3_1 = this.Label3;
      point1 = new Point(12, 245);
      Point point4 = point1;
      label3_1.Location = point4;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(351, 20);
      Size size4 = size1;
      label3_2.Size = size4;
      this.Label3.TabIndex = 0;
      this.Label3.Text = "3. Решение в конечный момент времени";
      this.NLabel.AutoSize = true;
      this.NLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label nlabel1 = this.NLabel;
      point1 = new Point(478, 240);
      Point point5 = point1;
      nlabel1.Location = point5;
      this.NLabel.Name = "NLabel";
      Label nlabel2 = this.NLabel;
      size1 = new Size(36, 20);
      Size size5 = size1;
      nlabel2.Size = size5;
      this.NLabel.TabIndex = 0;
      this.NLabel.Text = "N =";
      this.NLabel.Visible = false;
      this.KLabel.AutoSize = true;
      this.KLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label klabel1 = this.KLabel;
      point1 = new Point(647, 240);
      Point point6 = point1;
      klabel1.Location = point6;
      this.KLabel.Name = "KLabel";
      Label klabel2 = this.KLabel;
      size1 = new Size(35, 20);
      Size size6 = size1;
      klabel2.Size = size6;
      this.KLabel.TabIndex = 0;
      this.KLabel.Text = "K =";
      this.KLabel.Visible = false;
      this.GoBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button goBtn1 = this.GoBtn;
      point1 = new Point(768, 235);
      Point point7 = point1;
      goBtn1.Location = point7;
      this.GoBtn.Name = "GoBtn";
      Button goBtn2 = this.GoBtn;
      size1 = new Size(109, 30);
      Size size7 = size1;
      goBtn2.Size = size7;
      this.GoBtn.TabIndex = 18;
      this.GoBtn.Text = "РАСЧЕТ";
      this.GoBtn.UseVisualStyleBackColor = true;
      this.GoBtn.Visible = false;
      this.Ktxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox ktxt1 = this.Ktxt;
      point1 = new Point(687, 237);
      Point point8 = point1;
      ktxt1.Location = point8;
      this.Ktxt.MaxLength = 15;
      this.Ktxt.Name = "Ktxt";
      TextBox ktxt2 = this.Ktxt;
      size1 = new Size(69, 26);
      Size size8 = size1;
      ktxt2.Size = size8;
      this.Ktxt.TabIndex = 17;
      this.Ktxt.Visible = false;
      this.NDecrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button ndecrBtn1 = this.NDecrBtn;
      point1 = new Point(593, 235);
      Point point9 = point1;
      ndecrBtn1.Location = point9;
      this.NDecrBtn.Name = "NDecrBtn";
      Button ndecrBtn2 = this.NDecrBtn;
      size1 = new Size(20, 30);
      Size size9 = size1;
      ndecrBtn2.Size = size9;
      this.NDecrBtn.TabIndex = 16;
      this.NDecrBtn.Text = "-";
      this.NDecrBtn.UseVisualStyleBackColor = true;
      this.NDecrBtn.Visible = false;
      this.NIncrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button nincrBtn1 = this.NIncrBtn;
      point1 = new Point(616, 235);
      Point point10 = point1;
      nincrBtn1.Location = point10;
      this.NIncrBtn.Name = "NIncrBtn";
      Button nincrBtn2 = this.NIncrBtn;
      size1 = new Size(20, 30);
      Size size10 = size1;
      nincrBtn2.Size = size10;
      this.NIncrBtn.TabIndex = 15;
      this.NIncrBtn.Text = "+";
      this.NIncrBtn.UseVisualStyleBackColor = true;
      this.NIncrBtn.Visible = false;
      this.Ntxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox ntxt1 = this.Ntxt;
      point1 = new Point(520, 237);
      Point point11 = point1;
      ntxt1.Location = point11;
      this.Ntxt.MaxLength = 15;
      this.Ntxt.Name = "Ntxt";
      TextBox ntxt2 = this.Ntxt;
      size1 = new Size(69, 26);
      Size size11 = size1;
      ntxt2.Size = size11;
      this.Ntxt.TabIndex = 11;
      this.Ntxt.Visible = false;
      this.UsloviePicBox.BackColor = SystemColors.Control;
      PictureBox usloviePicBox1 = this.UsloviePicBox;
      point1 = new Point(10, 32);
      Point point12 = point1;
      usloviePicBox1.Location = point12;
      this.UsloviePicBox.Name = "UsloviePicBox";
      PictureBox usloviePicBox2 = this.UsloviePicBox;
      size1 = new Size(470, 190);
      Size size12 = size1;
      usloviePicBox2.Size = size12;
      this.UsloviePicBox.TabIndex = 2;
      this.UsloviePicBox.TabStop = false;
      this.UsloviePicBox.Visible = false;
      this.ShemaPicBox.BackColor = SystemColors.Control;
      PictureBox shemaPicBox1 = this.ShemaPicBox;
      point1 = new Point(496, 32);
      Point point13 = point1;
      shemaPicBox1.Location = point13;
      this.ShemaPicBox.Name = "ShemaPicBox";
      PictureBox shemaPicBox2 = this.ShemaPicBox;
      size1 = new Size(381, 190);
      Size size13 = size1;
      shemaPicBox2.Size = size13;
      this.ShemaPicBox.TabIndex = 3;
      this.ShemaPicBox.TabStop = false;
      this.ShemaPicBox.Visible = false;
      this.GroupBox2.Controls.Add((Control) this.BtnExit);
      this.GroupBox2.Controls.Add((Control) this.ZadachaNo);
      this.GroupBox2.Controls.Add((Control) this.Label8);
      this.GroupBox2.Controls.Add((Control) this.BtnClear);
      this.GroupBox2.Controls.Add((Control) this.BtnFigure);
      this.GroupBox2.Controls.Add((Control) this.BtnStart);
      this.GroupBox2.Controls.Add((Control) this.VariantNo);
      this.GroupBox2.Controls.Add((Control) this.Label7);
      this.GroupBox2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(12, 430);
      Point point14 = point1;
      groupBox2_1.Location = point14;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(865, 98);
      Size size14 = size1;
      groupBox2_2.Size = size14;
      this.GroupBox2.TabIndex = 16;
      this.GroupBox2.TabStop = false;
      this.BtnExit.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnExit1 = this.BtnExit;
      point1 = new Point(701, 37);
      Point point15 = point1;
      btnExit1.Location = point15;
      this.BtnExit.Name = "BtnExit";
      Button btnExit2 = this.BtnExit;
      size1 = new Size(138, 30);
      Size size15 = size1;
      btnExit2.Size = size15;
      this.BtnExit.TabIndex = 18;
      this.BtnExit.Text = "ВЫХОД";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.ZadachaNo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown zadachaNo1 = this.ZadachaNo;
      point1 = new Point(106, 57);
      Point point16 = point1;
      zadachaNo1.Location = point16;
      NumericUpDown zadachaNo2 = this.ZadachaNo;
      Decimal num1 = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      zadachaNo2.Maximum = num2;
      NumericUpDown zadachaNo3 = this.ZadachaNo;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num3 = num1;
      zadachaNo3.Minimum = num3;
      this.ZadachaNo.Name = "ZadachaNo";
      NumericUpDown zadachaNo4 = this.ZadachaNo;
      size1 = new Size(78, 26);
      Size size16 = size1;
      zadachaNo4.Size = size16;
      this.ZadachaNo.TabIndex = 7;
      NumericUpDown zadachaNo5 = this.ZadachaNo;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num4 = num1;
      zadachaNo5.Value = num4;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label8_1 = this.Label8;
      point1 = new Point(14, 59);
      Point point17 = point1;
      label8_1.Location = point17;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(78, 20);
      Size size17 = size1;
      label8_2.Size = size17;
      this.Label8.TabIndex = 6;
      this.Label8.Text = "Задача:";
      this.BtnClear.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnClear1 = this.BtnClear;
      point1 = new Point(536, 37);
      Point point18 = point1;
      btnClear1.Location = point18;
      this.BtnClear.Name = "BtnClear";
      Button btnClear2 = this.BtnClear;
      size1 = new Size(138, 30);
      Size size18 = size1;
      btnClear2.Size = size18;
      this.BtnClear.TabIndex = 4;
      this.BtnClear.Text = "ОЧИСТИТЬ";
      this.BtnClear.UseVisualStyleBackColor = true;
      this.BtnFigure.Enabled = false;
      this.BtnFigure.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnFigure1 = this.BtnFigure;
      point1 = new Point(384, 37);
      Point point19 = point1;
      btnFigure1.Location = point19;
      this.BtnFigure.Name = "BtnFigure";
      Button btnFigure2 = this.BtnFigure;
      size1 = new Size(125, 30);
      Size size19 = size1;
      btnFigure2.Size = size19;
      this.BtnFigure.TabIndex = 3;
      this.BtnFigure.Text = "ГРАФИК";
      this.BtnFigure.UseVisualStyleBackColor = true;
      this.BtnStart.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnStart1 = this.BtnStart;
      point1 = new Point(219, 37);
      Point point20 = point1;
      btnStart1.Location = point20;
      this.BtnStart.Name = "BtnStart";
      Button btnStart2 = this.BtnStart;
      size1 = new Size(138, 30);
      Size size20 = size1;
      btnStart2.Size = size20;
      this.BtnStart.TabIndex = 1;
      this.BtnStart.Text = "СТАРТ";
      this.BtnStart.UseVisualStyleBackColor = true;
      this.VariantNo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown variantNo1 = this.VariantNo;
      point1 = new Point(106, 20);
      Point point21 = point1;
      variantNo1.Location = point21;
      NumericUpDown variantNo2 = this.VariantNo;
      num1 = new Decimal(new int[4]{ 3, 0, 0, 0 });
      Decimal num5 = num1;
      variantNo2.Maximum = num5;
      NumericUpDown variantNo3 = this.VariantNo;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num6 = num1;
      variantNo3.Minimum = num6;
      this.VariantNo.Name = "VariantNo";
      NumericUpDown variantNo4 = this.VariantNo;
      size1 = new Size(78, 26);
      Size size21 = size1;
      variantNo4.Size = size21;
      this.VariantNo.TabIndex = 0;
      NumericUpDown variantNo5 = this.VariantNo;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num7 = num1;
      variantNo5.Value = num7;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label7_1 = this.Label7;
      point1 = new Point(14, 22);
      Point point22 = point1;
      label7_1.Location = point22;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(86, 20);
      Size size22 = size1;
      label7_2.Size = size22;
      this.Label7.TabIndex = 0;
      this.Label7.Text = "Вариант:";
      this.Otvet.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Otvet.FullRowSelect = true;
      this.Otvet.GridLines = true;
      ListView otvet1 = this.Otvet;
      point1 = new Point(10, 271);
      Point point23 = point1;
      otvet1.Location = point23;
      this.Otvet.MultiSelect = false;
      this.Otvet.Name = "Otvet";
      ListView otvet2 = this.Otvet;
      size1 = new Size(867, 157);
      Size size23 = size1;
      otvet2.Size = size23;
      this.Otvet.TabIndex = 17;
      this.Otvet.UseCompatibleStateImageBehavior = false;
      this.Otvet.View = View.Details;
      this.Otvet.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(889, 534);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.GoBtn);
      this.Controls.Add((Control) this.Otvet);
      this.Controls.Add((Control) this.Ktxt);
      this.Controls.Add((Control) this.KLabel);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.NDecrBtn);
      this.Controls.Add((Control) this.ShemaPicBox);
      this.Controls.Add((Control) this.NIncrBtn);
      this.Controls.Add((Control) this.UsloviePicBox);
      this.Controls.Add((Control) this.Ntxt);
      this.Controls.Add((Control) this.NLabel);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Name = nameof (MainFormLab5);
      this.ShowIcon = false;
      this.Text = "ПРОВЕРКА ЛАБОРАТОРНОЙ РАБОТЫ №5";
      ((ISupportInitialize) this.UsloviePicBox).EndInit();
      ((ISupportInitialize) this.ShemaPicBox).EndInit();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ZadachaNo.EndInit();
      this.VariantNo.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual Label Label2
    {
      get
      {
        return this._Label2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
      }
    }

    internal virtual Label Label3
    {
      get
      {
        return this._Label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    internal virtual Label NLabel
    {
      get
      {
        return this._NLabel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._NLabel = value;
      }
    }

    internal virtual Label KLabel
    {
      get
      {
        return this._KLabel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._KLabel = value;
      }
    }

    internal virtual PictureBox UsloviePicBox
    {
      get
      {
        return this._UsloviePicBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._UsloviePicBox = value;
      }
    }

    internal virtual PictureBox ShemaPicBox
    {
      get
      {
        return this._ShemaPicBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ShemaPicBox = value;
      }
    }

    internal virtual GroupBox GroupBox2
    {
      get
      {
        return this._GroupBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox2 = value;
      }
    }

    internal virtual NumericUpDown ZadachaNo
    {
      get
      {
        return this._ZadachaNo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ZadachaNo != null)
          this._ZadachaNo.KeyDown -= new KeyEventHandler(this.VariantNo_KeyDown);
        this._ZadachaNo = value;
        if (this._ZadachaNo == null)
          return;
        this._ZadachaNo.KeyDown += new KeyEventHandler(this.VariantNo_KeyDown);
      }
    }

    internal virtual Label Label8
    {
      get
      {
        return this._Label8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label8 = value;
      }
    }

    internal virtual Button BtnClear
    {
      get
      {
        return this._BtnClear;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BtnClear != null)
          this._BtnClear.Click -= new EventHandler(this.BtnClear_Click);
        this._BtnClear = value;
        if (this._BtnClear == null)
          return;
        this._BtnClear.Click += new EventHandler(this.BtnClear_Click);
      }
    }

    internal virtual Button BtnFigure
    {
      get
      {
        return this._BtnFigure;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BtnFigure != null)
          this._BtnFigure.Click -= new EventHandler(this.BtnFigure_Click);
        this._BtnFigure = value;
        if (this._BtnFigure == null)
          return;
        this._BtnFigure.Click += new EventHandler(this.BtnFigure_Click);
      }
    }

    internal virtual Button BtnStart
    {
      get
      {
        return this._BtnStart;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BtnStart != null)
          this._BtnStart.Click -= new EventHandler(this.BtnStart_Click);
        this._BtnStart = value;
        if (this._BtnStart == null)
          return;
        this._BtnStart.Click += new EventHandler(this.BtnStart_Click);
      }
    }

    internal virtual NumericUpDown VariantNo
    {
      get
      {
        return this._VariantNo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._VariantNo != null)
          this._VariantNo.KeyDown -= new KeyEventHandler(this.VariantNo_KeyDown);
        this._VariantNo = value;
        if (this._VariantNo == null)
          return;
        this._VariantNo.KeyDown += new KeyEventHandler(this.VariantNo_KeyDown);
      }
    }

    internal virtual Label Label7
    {
      get
      {
        return this._Label7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label7 = value;
      }
    }

    internal virtual ListView Otvet
    {
      get
      {
        return this._Otvet;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Otvet = value;
      }
    }

    internal virtual TextBox Ntxt
    {
      get
      {
        return this._Ntxt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Ntxt != null)
        {
          this._Ntxt.KeyPress -= new KeyPressEventHandler(this.Ntxt_KeyPress);
          this._Ntxt.KeyDown -= new KeyEventHandler(this.Ntxt_KeyDown);
        }
        this._Ntxt = value;
        if (this._Ntxt == null)
          return;
        this._Ntxt.KeyPress += new KeyPressEventHandler(this.Ntxt_KeyPress);
        this._Ntxt.KeyDown += new KeyEventHandler(this.Ntxt_KeyDown);
      }
    }

    internal virtual TextBox Ktxt
    {
      get
      {
        return this._Ktxt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Ktxt != null)
          this._Ktxt.KeyDown -= new KeyEventHandler(this.Ktxt_KeyDown);
        this._Ktxt = value;
        if (this._Ktxt == null)
          return;
        this._Ktxt.KeyDown += new KeyEventHandler(this.Ktxt_KeyDown);
      }
    }

    internal virtual Button NDecrBtn
    {
      get
      {
        return this._NDecrBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._NDecrBtn != null)
          this._NDecrBtn.Click -= new EventHandler(this.NDecrBtn_Click);
        this._NDecrBtn = value;
        if (this._NDecrBtn == null)
          return;
        this._NDecrBtn.Click += new EventHandler(this.NDecrBtn_Click);
      }
    }

    internal virtual Button NIncrBtn
    {
      get
      {
        return this._NIncrBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._NIncrBtn != null)
          this._NIncrBtn.Click -= new EventHandler(this.NIncrBtn_Click);
        this._NIncrBtn = value;
        if (this._NIncrBtn == null)
          return;
        this._NIncrBtn.Click += new EventHandler(this.NIncrBtn_Click);
      }
    }

    internal virtual Button GoBtn
    {
      get
      {
        return this._GoBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GoBtn != null)
          this._GoBtn.Click -= new EventHandler(this.GoBtn_Click);
        this._GoBtn = value;
        if (this._GoBtn == null)
          return;
        this._GoBtn.Click += new EventHandler(this.GoBtn_Click);
      }
    }

    internal virtual Button BtnExit
    {
      get
      {
        return this._BtnExit;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BtnExit != null)
          this._BtnExit.Click -= new EventHandler(this.BtnExit_Click);
        this._BtnExit = value;
        if (this._BtnExit == null)
          return;
        this._BtnExit.Click += new EventHandler(this.BtnExit_Click);
      }
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {
      switch (this.stage)
      {
        case 0:
          this.BtnStart.Text = "ОТВЕТ";
          this.varNo = int.Parse(Conversions.ToString(this.VariantNo.Value));
          this.taskNo = int.Parse(Conversions.ToString(this.ZadachaNo.Value));
          this.LoadUslovie();
          this.Ntxt.Visible = true;
          this.NLabel.Visible = true;
          this.Ktxt.Visible = true;
          this.KLabel.Visible = true;
          this.NIncrBtn.Visible = true;
          this.NDecrBtn.Visible = true;
          this.GoBtn.Visible = true;
          this.UsloviePicBox.Visible = true;
          this.ShemaPicBox.Visible = true;
          ++this.stage;
          this.VariantNo.Enabled = false;
          this.VariantNo.BackColor = Color.White;
          this.ZadachaNo.Enabled = false;
          this.ZadachaNo.BackColor = Color.White;
          break;
        case 1:
          ++this.stage;
          this.BtnFigure.Enabled = true;
          this.BtnStart.Text = "ЗАНОВО";
          MyUtils ut1 = this.ut;
          Form form1 = (Form) this;
          ref Form local1 = ref form1;
          ut1.SetWaitCursor(ref local1);
          this.Calculate();
          MyUtils ut2 = this.ut;
          Form form2 = (Form) this;
          ref Form local2 = ref form2;
          ut2.RestoreCursor(ref local2);
          break;
        default:
          this.ClearAllData();
          break;
      }
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
      this.ClearAllData();
    }

    private void GoBtn_Click(object sender, EventArgs e)
    {
      this.stage = (byte) 2;
      this.BtnFigure.Enabled = true;
      this.BtnStart.Text = "ЗАНОВО";
      this.Otvet.Items.Clear();
      this.Otvet.Clear();
      this.Calculate();
    }

    private void NDecrBtn_Click(object sender, EventArgs e)
    {
      int num = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ntxt.Text)));
      if (num <= 11)
        return;
      this.Ntxt.Text = ((int) Math.Round((double) (num - 1) / 2.0 + 1.0)).ToString();
    }

    private void NIncrBtn_Click(object sender, EventArgs e)
    {
      int num = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ntxt.Text)));
      if (num >= 6401)
        return;
      this.Ntxt.Text = (2 * (num - 1) + 1).ToString();
    }

    private void LoadUslovie()
    {
      string str1 = "11";
      string str2 = "0.1";
      if (this.varNo < 3)
      {
        str2 = "0.2";
      }
      else
      {
        switch (this.taskNo)
        {
          case 1:
          case 8:
          case 9:
          case 14:
            str2 = "0.75";
            break;
          case 2:
            str2 = "0.35";
            break;
          case 3:
            str2 = "0.25";
            break;
          case 4:
            str2 = "0.33";
            break;
          case 5:
            str2 = "0.35";
            break;
          case 6:
          case 7:
          case 10:
          case 15:
            str2 = "1.5";
            break;
          case 11:
          case 13:
            str2 = "1.0";
            break;
          case 12:
            str2 = "0.33333";
            break;
        }
      }
      this.Ntxt.Text = str1;
      this.Ktxt.Text = str2;
      this.UsloviePicBox.Image = this.GetUsloviePicture();
      this.ShemaPicBox.Image = this.GetShemaPicture();
      MyUtils ut1 = this.ut;
      PictureBox usloviePicBox = this.UsloviePicBox;
      ref PictureBox local1 = ref usloviePicBox;
      ut1.ResizePicBoxToImage(ref local1);
      this.UsloviePicBox = usloviePicBox;
      MyUtils ut2 = this.ut;
      PictureBox shemaPicBox = this.ShemaPicBox;
      ref PictureBox local2 = ref shemaPicBox;
      ut2.ResizePicBoxToImage(ref local2);
      this.ShemaPicBox = shemaPicBox;
    }

    private void ClearAllData()
    {
      this.stage = (byte) 0;
      this.BtnStart.Text = "СТАРТ";
      this.Ntxt.Visible = false;
      this.NLabel.Visible = false;
      this.Ktxt.Visible = false;
      this.KLabel.Visible = false;
      this.NIncrBtn.Visible = false;
      this.NDecrBtn.Visible = false;
      this.GoBtn.Visible = false;
      this.UsloviePicBox.Visible = false;
      this.ShemaPicBox.Visible = false;
      this.VariantNo.Enabled = true;
      this.ZadachaNo.Enabled = true;
      this.BtnFigure.Enabled = false;
      this.Otvet.Visible = false;
      this.Otvet.Items.Clear();
      this.Otvet.Clear();
    }

    private void BtnFigure_Click(object sender, EventArgs e)
    {
      object obj = (object) new Bitmap(MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      Array instance1 = Array.CreateInstance(typeof (double), 12);
      Array instance2 = Array.CreateInstance(typeof (double), 12);
      Array instance3 = Array.CreateInstance(typeof (double), 12);
      int num1 = 1;
      int num2 = 1;
      while (num2 <= this.calc.LK)
      {
        NewLateBinding.LateIndexSet((object) instance1, new object[2]
        {
          (object) num1,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) num2
          }, (string[]) null))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance2, new object[2]
        {
          (object) num1,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.calc.UA, new object[1]
          {
            (object) num2
          }, (string[]) null))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance3, new object[2]
        {
          (object) num1,
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.calc.UM, new object[1]
          {
            (object) num2
          }, (string[]) null))
        }, (string[]) null);
        num2 += this.calc.LJ;
        ++num1;
      }
      this.g = Graphics.FromImage((Image) obj);
      MyProject.Forms.Plot.PictureBox1.Image = (Image) obj;
      this.ut.MyDrawFigure2(ref instance1, ref instance2, ref instance3, ref this.g, MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      this.g.Dispose();
      MyProject.Forms.Plot.Text = "График решения";
      MyProject.Forms.Plot.HelpProvider1.SetHelpString((Control) MyProject.Forms.Plot.PictureBox1, "Синим цветом показано аналитическое решение. Красным цветом показано численнное решение задачи.");
      int num3 = (int) MyProject.Forms.Plot.ShowDialog((IWin32Window) this);
    }

    private void Calculate()
    {
      MyUtils ut = this.ut;
      TextBox ktxt = this.Ktxt;
      ref TextBox local1 = ref ktxt;
      int num1 = ut.MyCheckNumValue(ref local1) ? 1 : 0;
      this.Ktxt = ktxt;
      if (num1 == 0)
        return;
      this.calc.LK = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ntxt.Text)));
      this.calc.AK = double.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ktxt.Text)));
      this.calc.Calculate(this.varNo, this.taskNo);
      System.Type Type1 = typeof (Math);
      object[] objArray1 = new object[1];
      object[] objArray2 = objArray1;
      NumericLab5 calc1 = this.calc;
      Array uv = calc1.UV;
      object[] objArray3 = new object[1];
      object[] objArray4 = objArray3;
      int num2 = 1;
      // ISSUE: variable of a boxed type
      __Boxed<int> local2 = (ValueType) num2;
      objArray4[0] = (object) local2;
      object[] Arguments1 = objArray3;
      object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) uv, Arguments1, (string[]) null));
      objArray2[0] = objectValue1;
      object[] objArray5 = objArray1;
      object[] Arguments2 = objArray5;
      bool[] flagArray1 = new bool[1]{ true };
      bool[] CopyBack1 = flagArray1;
      object obj1 = NewLateBinding.LateGet((object) null, Type1, "Abs", Arguments2, (string[]) null, (System.Type[]) null, CopyBack1);
      if (flagArray1[0])
        NewLateBinding.LateIndexSetComplex((object) calc1.UV, new object[2]
        {
          (object) num2,
          RuntimeHelpers.GetObjectValue(objArray5[0])
        }, (string[]) null, true, false);
      double dbl_in = Conversions.ToDouble(obj1);
      int lk = this.calc.LK;
      for (int index = 2; index <= lk; ++index)
      {
        // ISSUE: variable of a boxed type
        __Boxed<double> local3 = (ValueType) dbl_in;
        System.Type Type2 = typeof (Math);
        object[] objArray6 = new object[1];
        object[] objArray7 = objArray6;
        NumericLab5 calc2 = this.calc;
        object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) calc2.UV, new object[1]
        {
          (object) index
        }, (string[]) null));
        objArray7[0] = objectValue2;
        object[] objArray8 = objArray6;
        object[] Arguments3 = objArray8;
        bool[] flagArray2 = new bool[1]{ true };
        bool[] CopyBack2 = flagArray2;
        object Right = NewLateBinding.LateGet((object) null, Type2, "Abs", Arguments3, (string[]) null, (System.Type[]) null, CopyBack2);
        if (flagArray2[0])
          NewLateBinding.LateIndexSetComplex((object) calc2.UV, new object[2]
          {
            (object) index,
            RuntimeHelpers.GetObjectValue(objArray8[0])
          }, (string[]) null, true, false);
        if (Operators.ConditionalCompareObjectLess((object) local3, Right, false))
        {
          System.Type Type3 = typeof (Math);
          object[] objArray9 = new object[1];
          object[] objArray10 = objArray9;
          NumericLab5 calc3 = this.calc;
          object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) calc3.UV, new object[1]
          {
            (object) index
          }, (string[]) null));
          objArray10[0] = objectValue3;
          object[] objArray11 = objArray9;
          object[] Arguments4 = objArray11;
          bool[] flagArray3 = new bool[1]{ true };
          bool[] CopyBack3 = flagArray3;
          object obj2 = NewLateBinding.LateGet((object) null, Type3, "Abs", Arguments4, (string[]) null, (System.Type[]) null, CopyBack3);
          if (flagArray3[0])
            NewLateBinding.LateIndexSetComplex((object) calc3.UV, new object[2]
            {
              (object) index,
              RuntimeHelpers.GetObjectValue(objArray11[0])
            }, (string[]) null, true, false);
          dbl_in = Conversions.ToDouble(obj2);
        }
      }
      ListViewItem listViewItem1 = new ListViewItem("X ");
      ListViewItem listViewItem2 = new ListViewItem("Analitic ");
      ListViewItem listViewItem3 = new ListViewItem("Numeric  ");
      ListViewItem listViewItem4 = new ListViewItem("Diff ");
      ListViewItem listViewItem5 = new ListViewItem("MaxDiff  ");
      this.Otvet.Columns.Add("", -2, HorizontalAlignment.Left);
      this.Otvet.GridLines = true;
      int num3 = 1;
      int num4 = 0;
      while (num3 <= this.calc.LK)
      {
        this.Otvet.Columns.Add(num4.ToString() + " ", -2, HorizontalAlignment.Left);
        listViewItem1.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
        {
          (object) num3
        }, (string[]) null))) + "   ");
        listViewItem2.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UA, new object[1]
        {
          (object) num3
        }, (string[]) null))) + " ");
        listViewItem3.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UM, new object[1]
        {
          (object) num3
        }, (string[]) null))) + " ");
        listViewItem4.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UV, new object[1]
        {
          (object) num3
        }, (string[]) null))) + " ");
        num3 += this.calc.LJ;
        ++num4;
      }
      listViewItem5.SubItems.Add(this.ut.MyDblToStr(dbl_in));
      listViewItem2.ForeColor = Color.Blue;
      listViewItem3.ForeColor = Color.Red;
      listViewItem5.ForeColor = Color.Green;
      this.Otvet.Items.Add(listViewItem1);
      this.Otvet.Items.Add(listViewItem2);
      this.Otvet.Items.Add(listViewItem3);
      this.Otvet.Items.Add(listViewItem4);
      this.Otvet.Items.Add(listViewItem5);
      this.Otvet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
      this.Otvet.Visible = true;
    }

    private Image GetUsloviePicture()
    {
      Image image = (Image) Proverka.My.Resources.Resources.L5u1_1;
      switch (this.varNo)
      {
        case 1:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L5u1_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L5u1_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L5u1_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L5u1_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L5u1_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L5u1_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L5u1_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L5u1_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L5u1_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L5u1_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L5u1_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L5u1_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L5u1_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L5u1_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L5u1_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L5u1_16;
              break;
          }
        case 2:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L5u2_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L5u2_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L5u2_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L5u2_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L5u2_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L5u2_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L5u2_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L5u2_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L5u2_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L5u2_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L5u2_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L5u2_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L5u2_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L5u2_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L5u2_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L5u2_16;
              break;
          }
        case 3:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L5u3_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L5u3_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L5u3_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L5u3_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L5u3_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L5u3_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L5u3_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L5u3_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L5u3_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L5u3_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L5u3_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L5u3_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L5u3_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L5u3_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L5u3_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L5u3_16;
              break;
          }
      }
      return image;
    }

    private Image GetShemaPicture()
    {
      Image image = (Image) Proverka.My.Resources.Resources.L5s1_1;
      switch (this.varNo)
      {
        case 1:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L5s1_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L5s1_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L5s1_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L5s1_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L5s1_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L5s1_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L5s1_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L5s1_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L5s1_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L5s1_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L5s1_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L5s1_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L5s1_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L5s1_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L5s1_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L5s1_16;
              break;
          }
        case 2:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L5s2_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L5s2_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L5s2_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L5s2_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L5s2_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L5s2_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L5s2_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L5s2_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L5s2_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L5s2_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L5s2_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L5s2_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L5s2_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L5s2_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L5s2_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L5s2_16;
              break;
          }
        case 3:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L5s3_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L5s3_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L5s3_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L5s3_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L5s3_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L5s3_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L5s3_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L5s3_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L5s3_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L5s3_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L5s3_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L5s3_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L5s3_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L5s3_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L5s3_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L5s3_16;
              break;
          }
      }
      return image;
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Ntxt_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
    }

    private void Ktxt_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
        this.GoBtn.PerformClick();
      else
        this.ut.MyCheckNumKeyDown(ref e);
    }

    private void VariantNo_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.BtnStart.PerformClick();
      this.BtnStart.Focus();
    }

    private void Ntxt_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.BtnStart.PerformClick();
    }

    private void MainFormLab5_FormClosed(object sender, FormClosedEventArgs e)
    {
      MyProject.Forms.Proverka.Show();
    }
  }
}
