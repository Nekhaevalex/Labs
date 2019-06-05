// Decompiled with JetBrains decompiler
// Type: Proverka.MainFormLab3
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using Proverka.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Proverka
{
  [DesignerGenerated]
  public class MainFormLab3 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("UsloviePicBox")]
    private PictureBox _UsloviePicBox;
    [AccessedThroughProperty("MethodPicBox")]
    private PictureBox _MethodPicBox;
    [AccessedThroughProperty("Ntxt")]
    private TextBox _Ntxt;
    [AccessedThroughProperty("X0txt")]
    private TextBox _X0txt;
    [AccessedThroughProperty("XNtxt")]
    private TextBox _XNtxt;
    [AccessedThroughProperty("Y0txt")]
    private TextBox _Y0txt;
    [AccessedThroughProperty("EPStxt")]
    private TextBox _EPStxt;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("BtnClear")]
    private Button _BtnClear;
    [AccessedThroughProperty("BtnFigure")]
    private Button _BtnFigure;
    [AccessedThroughProperty("BtnStart")]
    private Button _BtnStart;
    [AccessedThroughProperty("Varianty")]
    private NumericUpDown _Varianty;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Otvet")]
    private ListView _Otvet;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("NLabel")]
    private Label _NLabel;
    [AccessedThroughProperty("X0Label")]
    private Label _X0Label;
    [AccessedThroughProperty("XNLabel")]
    private Label _XNLabel;
    [AccessedThroughProperty("Y0Label")]
    private Label _Y0Label;
    [AccessedThroughProperty("EPSLabel")]
    private Label _EPSLabel;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("GoBtn")]
    private Button _GoBtn;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("BtnExit")]
    private Button _BtnExit;
    [AccessedThroughProperty("NDecrBtn")]
    private Button _NDecrBtn;
    [AccessedThroughProperty("NIncrBtn")]
    private Button _NIncrBtn;
    private MyUtils ut;
    private NumericLab3 calc;
    private byte stage;
    private int varNo;
    private Graphics g;

    public MainFormLab3()
    {
      this.FormClosed += new FormClosedEventHandler(this.MainFormLab3_FormClosed);
      this.ut = new MyUtils();
      this.calc = new NumericLab3();
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
      this.UsloviePicBox = new PictureBox();
      this.MethodPicBox = new PictureBox();
      this.Ntxt = new TextBox();
      this.X0txt = new TextBox();
      this.XNtxt = new TextBox();
      this.Y0txt = new TextBox();
      this.EPStxt = new TextBox();
      this.GroupBox1 = new GroupBox();
      this.BtnExit = new Button();
      this.BtnClear = new Button();
      this.BtnFigure = new Button();
      this.BtnStart = new Button();
      this.Varianty = new NumericUpDown();
      this.Label1 = new Label();
      this.Otvet = new ListView();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.NLabel = new Label();
      this.X0Label = new Label();
      this.XNLabel = new Label();
      this.Y0Label = new Label();
      this.EPSLabel = new Label();
      this.Label9 = new Label();
      this.GoBtn = new Button();
      this.GroupBox2 = new GroupBox();
      this.NDecrBtn = new Button();
      this.NIncrBtn = new Button();
      ((ISupportInitialize) this.UsloviePicBox).BeginInit();
      ((ISupportInitialize) this.MethodPicBox).BeginInit();
      this.GroupBox1.SuspendLayout();
      this.Varianty.BeginInit();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      this.UsloviePicBox.BackColor = Color.White;
      PictureBox usloviePicBox1 = this.UsloviePicBox;
      Point point1 = new Point(135, 9);
      Point point2 = point1;
      usloviePicBox1.Location = point2;
      this.UsloviePicBox.Name = "UsloviePicBox";
      PictureBox usloviePicBox2 = this.UsloviePicBox;
      Size size1 = new Size(485, 55);
      Size size2 = size1;
      usloviePicBox2.Size = size2;
      this.UsloviePicBox.TabIndex = 0;
      this.UsloviePicBox.TabStop = false;
      this.UsloviePicBox.Visible = false;
      this.MethodPicBox.BackColor = Color.White;
      PictureBox methodPicBox1 = this.MethodPicBox;
      point1 = new Point(9, 95);
      Point point3 = point1;
      methodPicBox1.Location = point3;
      this.MethodPicBox.Name = "MethodPicBox";
      PictureBox methodPicBox2 = this.MethodPicBox;
      size1 = new Size(500, 218);
      Size size3 = size1;
      methodPicBox2.Size = size3;
      this.MethodPicBox.TabIndex = 1;
      this.MethodPicBox.TabStop = false;
      this.MethodPicBox.Visible = false;
      this.Ntxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox ntxt1 = this.Ntxt;
      point1 = new Point(98, 28);
      Point point4 = point1;
      ntxt1.Location = point4;
      this.Ntxt.MaxLength = 15;
      this.Ntxt.Name = "Ntxt";
      TextBox ntxt2 = this.Ntxt;
      size1 = new Size(54, 26);
      Size size4 = size1;
      ntxt2.Size = size4;
      this.Ntxt.TabIndex = 5;
      this.Ntxt.Visible = false;
      this.X0txt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox x0txt1 = this.X0txt;
      point1 = new Point(98, 68);
      Point point5 = point1;
      x0txt1.Location = point5;
      this.X0txt.MaxLength = 15;
      this.X0txt.Name = "X0txt";
      TextBox x0txt2 = this.X0txt;
      size1 = new Size(103, 26);
      Size size5 = size1;
      x0txt2.Size = size5;
      this.X0txt.TabIndex = 6;
      this.X0txt.Visible = false;
      this.XNtxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox xntxt1 = this.XNtxt;
      point1 = new Point(98, 108);
      Point point6 = point1;
      xntxt1.Location = point6;
      this.XNtxt.MaxLength = 15;
      this.XNtxt.Name = "XNtxt";
      TextBox xntxt2 = this.XNtxt;
      size1 = new Size(103, 26);
      Size size6 = size1;
      xntxt2.Size = size6;
      this.XNtxt.TabIndex = 7;
      this.XNtxt.Visible = false;
      this.Y0txt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox y0txt1 = this.Y0txt;
      point1 = new Point(98, 148);
      Point point7 = point1;
      y0txt1.Location = point7;
      this.Y0txt.MaxLength = 15;
      this.Y0txt.Name = "Y0txt";
      TextBox y0txt2 = this.Y0txt;
      size1 = new Size(103, 26);
      Size size7 = size1;
      y0txt2.Size = size7;
      this.Y0txt.TabIndex = 8;
      this.Y0txt.Visible = false;
      this.EPStxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox epStxt1 = this.EPStxt;
      point1 = new Point(688, 38);
      Point point8 = point1;
      epStxt1.Location = point8;
      this.EPStxt.MaxLength = 15;
      this.EPStxt.Name = "EPStxt";
      TextBox epStxt2 = this.EPStxt;
      size1 = new Size(103, 26);
      Size size8 = size1;
      epStxt2.Size = size8;
      this.EPStxt.TabIndex = 10;
      this.EPStxt.Visible = false;
      this.GroupBox1.Controls.Add((Control) this.BtnExit);
      this.GroupBox1.Controls.Add((Control) this.BtnClear);
      this.GroupBox1.Controls.Add((Control) this.BtnFigure);
      this.GroupBox1.Controls.Add((Control) this.BtnStart);
      this.GroupBox1.Controls.Add((Control) this.Varianty);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(9, 486);
      Point point9 = point1;
      groupBox1_1.Location = point9;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(782, 55);
      Size size9 = size1;
      groupBox1_2.Size = size9;
      this.GroupBox1.TabIndex = 4;
      this.GroupBox1.TabStop = false;
      this.BtnExit.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnExit1 = this.BtnExit;
      point1 = new Point(636, 16);
      Point point10 = point1;
      btnExit1.Location = point10;
      this.BtnExit.Name = "BtnExit";
      Button btnExit2 = this.BtnExit;
      size1 = new Size(138, 30);
      Size size10 = size1;
      btnExit2.Size = size10;
      this.BtnExit.TabIndex = 10;
      this.BtnExit.Text = "ВЫХОД";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnClear.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnClear1 = this.BtnClear;
      point1 = new Point(484, 16);
      Point point11 = point1;
      btnClear1.Location = point11;
      this.BtnClear.Name = "BtnClear";
      Button btnClear2 = this.BtnClear;
      size1 = new Size(138, 30);
      Size size11 = size1;
      btnClear2.Size = size11;
      this.BtnClear.TabIndex = 4;
      this.BtnClear.Text = "ОЧИСТИТЬ";
      this.BtnClear.UseVisualStyleBackColor = true;
      this.BtnFigure.Enabled = false;
      this.BtnFigure.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnFigure1 = this.BtnFigure;
      point1 = new Point(332, 16);
      Point point12 = point1;
      btnFigure1.Location = point12;
      this.BtnFigure.Name = "BtnFigure";
      Button btnFigure2 = this.BtnFigure;
      size1 = new Size(138, 30);
      Size size12 = size1;
      btnFigure2.Size = size12;
      this.BtnFigure.TabIndex = 3;
      this.BtnFigure.Text = "ГРАФИК";
      this.BtnFigure.UseVisualStyleBackColor = true;
      this.BtnStart.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnStart1 = this.BtnStart;
      point1 = new Point(180, 16);
      Point point13 = point1;
      btnStart1.Location = point13;
      this.BtnStart.Name = "BtnStart";
      Button btnStart2 = this.BtnStart;
      size1 = new Size(138, 30);
      Size size13 = size1;
      btnStart2.Size = size13;
      this.BtnStart.TabIndex = 1;
      this.BtnStart.Text = "СТАРТ";
      this.BtnStart.UseVisualStyleBackColor = true;
      this.Varianty.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown varianty1 = this.Varianty;
      point1 = new Point(91, 18);
      Point point14 = point1;
      varianty1.Location = point14;
      NumericUpDown varianty2 = this.Varianty;
      Decimal num1 = new Decimal(new int[4]
      {
        16,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      varianty2.Maximum = num2;
      NumericUpDown varianty3 = this.Varianty;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num3 = num1;
      varianty3.Minimum = num3;
      this.Varianty.Name = "Varianty";
      NumericUpDown varianty4 = this.Varianty;
      size1 = new Size(78, 26);
      Size size14 = size1;
      varianty4.Size = size14;
      this.Varianty.TabIndex = 0;
      NumericUpDown varianty5 = this.Varianty;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num4 = num1;
      varianty5.Value = num4;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label1_1 = this.Label1;
      point1 = new Point(3, 21);
      Point point15 = point1;
      label1_1.Location = point15;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(86, 20);
      Size size15 = size1;
      label1_2.Size = size15;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Вариант:";
      this.Otvet.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Otvet.FullRowSelect = true;
      this.Otvet.GridLines = true;
      ListView otvet1 = this.Otvet;
      point1 = new Point(9, 342);
      Point point16 = point1;
      otvet1.Location = point16;
      this.Otvet.MultiSelect = false;
      this.Otvet.Name = "Otvet";
      ListView otvet2 = this.Otvet;
      size1 = new Size(782, 138);
      Size size16 = size1;
      otvet2.Size = size16;
      this.Otvet.TabIndex = 2;
      this.Otvet.UseCompatibleStateImageBehavior = false;
      this.Otvet.View = View.Details;
      this.Otvet.Visible = false;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label2_1 = this.Label2;
      point1 = new Point(9, 72);
      Point point17 = point1;
      label2_1.Location = point17;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(235, 20);
      Size size17 = size1;
      label2_2.Size = size17;
      this.Label2.TabIndex = 2;
      this.Label2.Text = "3. Вычислительный метод";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label3_1 = this.Label3;
      point1 = new Point(9, 19);
      Point point18 = point1;
      label3_1.Location = point18;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(120, 20);
      Size size18 = size1;
      label3_2.Size = size18;
      this.Label3.TabIndex = 12;
      this.Label3.Text = "1. Уравнение";
      this.NLabel.AutoSize = true;
      this.NLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label nlabel1 = this.NLabel;
      point1 = new Point(42, 32);
      Point point19 = point1;
      nlabel1.Location = point19;
      this.NLabel.Name = "NLabel";
      Label nlabel2 = this.NLabel;
      size1 = new Size(36, 20);
      Size size19 = size1;
      nlabel2.Size = size19;
      this.NLabel.TabIndex = 13;
      this.NLabel.Text = "N =";
      this.NLabel.Visible = false;
      this.X0Label.AutoSize = true;
      this.X0Label.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label x0Label1 = this.X0Label;
      point1 = new Point(32, 71);
      Point point20 = point1;
      x0Label1.Location = point20;
      this.X0Label.Name = "X0Label";
      Label x0Label2 = this.X0Label;
      size1 = new Size(46, 20);
      Size size20 = size1;
      x0Label2.Size = size20;
      this.X0Label.TabIndex = 14;
      this.X0Label.Text = "X0 =";
      this.X0Label.Visible = false;
      this.XNLabel.AutoSize = true;
      this.XNLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label xnLabel1 = this.XNLabel;
      point1 = new Point(30, 110);
      Point point21 = point1;
      xnLabel1.Location = point21;
      this.XNLabel.Name = "XNLabel";
      Label xnLabel2 = this.XNLabel;
      size1 = new Size(48, 20);
      Size size21 = size1;
      xnLabel2.Size = size21;
      this.XNLabel.TabIndex = 15;
      this.XNLabel.Text = "XN =";
      this.XNLabel.Visible = false;
      this.Y0Label.AutoSize = true;
      this.Y0Label.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label y0Label1 = this.Y0Label;
      point1 = new Point(32, 149);
      Point point22 = point1;
      y0Label1.Location = point22;
      this.Y0Label.Name = "Y0Label";
      Label y0Label2 = this.Y0Label;
      size1 = new Size(46, 20);
      Size size22 = size1;
      y0Label2.Size = size22;
      this.Y0Label.TabIndex = 0;
      this.Y0Label.Text = "Y0 =";
      this.Y0Label.Visible = false;
      this.EPSLabel.AutoSize = true;
      this.EPSLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label epsLabel1 = this.EPSLabel;
      point1 = new Point(684, 9);
      Point point23 = point1;
      epsLabel1.Location = point23;
      this.EPSLabel.Name = "EPSLabel";
      Label epsLabel2 = this.EPSLabel;
      size1 = new Size(59, 20);
      Size size23 = size1;
      epsLabel2.Size = size23;
      this.EPSLabel.TabIndex = 1;
      this.EPSLabel.Text = "EPS =";
      this.EPSLabel.Visible = false;
      this.Label9.AutoSize = true;
      this.Label9.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label9_1 = this.Label9;
      point1 = new Point(9, 319);
      Point point24 = point1;
      label9_1.Location = point24;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(262, 20);
      Size size24 = size1;
      label9_2.Size = size24;
      this.Label9.TabIndex = 3;
      this.Label9.Text = "4. Таблица значений функции";
      this.GoBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button goBtn1 = this.GoBtn;
      point1 = new Point(40, 193);
      Point point25 = point1;
      goBtn1.Location = point25;
      this.GoBtn.Name = "GoBtn";
      Button goBtn2 = this.GoBtn;
      size1 = new Size(140, 30);
      Size size25 = size1;
      goBtn2.Size = size25;
      this.GoBtn.TabIndex = 11;
      this.GoBtn.Text = "РАСЧЕТ";
      this.GoBtn.UseVisualStyleBackColor = true;
      this.GoBtn.Visible = false;
      this.GroupBox2.Controls.Add((Control) this.NDecrBtn);
      this.GroupBox2.Controls.Add((Control) this.NLabel);
      this.GroupBox2.Controls.Add((Control) this.NIncrBtn);
      this.GroupBox2.Controls.Add((Control) this.Ntxt);
      this.GroupBox2.Controls.Add((Control) this.GoBtn);
      this.GroupBox2.Controls.Add((Control) this.X0txt);
      this.GroupBox2.Controls.Add((Control) this.XNtxt);
      this.GroupBox2.Controls.Add((Control) this.Y0txt);
      this.GroupBox2.Controls.Add((Control) this.Y0Label);
      this.GroupBox2.Controls.Add((Control) this.XNLabel);
      this.GroupBox2.Controls.Add((Control) this.X0Label);
      this.GroupBox2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(570, 74);
      Point point26 = point1;
      groupBox2_1.Location = point26;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(221, 239);
      Size size26 = size1;
      groupBox2_2.Size = size26;
      this.GroupBox2.TabIndex = 17;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "2. Параметры задачи";
      this.NDecrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button ndecrBtn1 = this.NDecrBtn;
      point1 = new Point(158, 26);
      Point point27 = point1;
      ndecrBtn1.Location = point27;
      this.NDecrBtn.Name = "NDecrBtn";
      Button ndecrBtn2 = this.NDecrBtn;
      size1 = new Size(20, 30);
      Size size27 = size1;
      ndecrBtn2.Size = size27;
      this.NDecrBtn.TabIndex = 18;
      this.NDecrBtn.Text = "-";
      this.NDecrBtn.UseVisualStyleBackColor = true;
      this.NDecrBtn.Visible = false;
      this.NIncrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button nincrBtn1 = this.NIncrBtn;
      point1 = new Point(181, 26);
      Point point28 = point1;
      nincrBtn1.Location = point28;
      this.NIncrBtn.Name = "NIncrBtn";
      Button nincrBtn2 = this.NIncrBtn;
      size1 = new Size(20, 30);
      Size size28 = size1;
      nincrBtn2.Size = size28;
      this.NIncrBtn.TabIndex = 19;
      this.NIncrBtn.Text = "+";
      this.NIncrBtn.UseVisualStyleBackColor = true;
      this.NIncrBtn.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(803, 544);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Otvet);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.MethodPicBox);
      this.Controls.Add((Control) this.EPSLabel);
      this.Controls.Add((Control) this.UsloviePicBox);
      this.Controls.Add((Control) this.EPStxt);
      this.Name = nameof (MainFormLab3);
      this.ShowIcon = false;
      this.Text = "ПРОВЕРКА ЛАБОРАТОРНОЙ РАБОТЫ №3";
      ((ISupportInitialize) this.UsloviePicBox).EndInit();
      ((ISupportInitialize) this.MethodPicBox).EndInit();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.Varianty.EndInit();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual PictureBox MethodPicBox
    {
      get
      {
        return this._MethodPicBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MethodPicBox = value;
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

    internal virtual TextBox X0txt
    {
      get
      {
        return this._X0txt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._X0txt != null)
          this._X0txt.KeyDown -= new KeyEventHandler(this.NumFieldEdit_KeyDown);
        this._X0txt = value;
        if (this._X0txt == null)
          return;
        this._X0txt.KeyDown += new KeyEventHandler(this.NumFieldEdit_KeyDown);
      }
    }

    internal virtual TextBox XNtxt
    {
      get
      {
        return this._XNtxt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._XNtxt != null)
          this._XNtxt.KeyDown -= new KeyEventHandler(this.NumFieldEdit_KeyDown);
        this._XNtxt = value;
        if (this._XNtxt == null)
          return;
        this._XNtxt.KeyDown += new KeyEventHandler(this.NumFieldEdit_KeyDown);
      }
    }

    internal virtual TextBox Y0txt
    {
      get
      {
        return this._Y0txt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Y0txt != null)
          this._Y0txt.KeyDown -= new KeyEventHandler(this.NumFieldEdit_KeyDown);
        this._Y0txt = value;
        if (this._Y0txt == null)
          return;
        this._Y0txt.KeyDown += new KeyEventHandler(this.NumFieldEdit_KeyDown);
      }
    }

    internal virtual TextBox EPStxt
    {
      get
      {
        return this._EPStxt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._EPStxt != null)
          this._EPStxt.KeyDown -= new KeyEventHandler(this.NumFieldEdit_KeyDown);
        this._EPStxt = value;
        if (this._EPStxt == null)
          return;
        this._EPStxt.KeyDown += new KeyEventHandler(this.NumFieldEdit_KeyDown);
      }
    }

    internal virtual GroupBox GroupBox1
    {
      get
      {
        return this._GroupBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox1 = value;
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

    internal virtual NumericUpDown Varianty
    {
      get
      {
        return this._Varianty;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Varianty != null)
          this._Varianty.KeyDown -= new KeyEventHandler(this.Varianty_KeyDown);
        this._Varianty = value;
        if (this._Varianty == null)
          return;
        this._Varianty.KeyDown += new KeyEventHandler(this.Varianty_KeyDown);
      }
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

    internal virtual Label X0Label
    {
      get
      {
        return this._X0Label;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._X0Label = value;
      }
    }

    internal virtual Label XNLabel
    {
      get
      {
        return this._XNLabel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._XNLabel = value;
      }
    }

    internal virtual Label Y0Label
    {
      get
      {
        return this._Y0Label;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Y0Label = value;
      }
    }

    internal virtual Label EPSLabel
    {
      get
      {
        return this._EPSLabel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._EPSLabel = value;
      }
    }

    internal virtual Label Label9
    {
      get
      {
        return this._Label9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label9 = value;
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

    private void BtnStart_Click(object sender, EventArgs e)
    {
      switch (this.stage)
      {
        case 0:
          this.BtnStart.Text = "ОТВЕТ";
          this.varNo = int.Parse(Conversions.ToString(this.Varianty.Value));
          this.LoadUslovie();
          this.Ntxt.Visible = true;
          this.NDecrBtn.Visible = true;
          this.NIncrBtn.Visible = true;
          this.X0txt.Visible = true;
          this.XNtxt.Visible = true;
          this.Y0txt.Visible = true;
          this.NLabel.Visible = true;
          this.X0Label.Visible = true;
          this.XNLabel.Visible = true;
          this.Y0Label.Visible = true;
          this.GoBtn.Visible = true;
          this.UsloviePicBox.Visible = true;
          this.MethodPicBox.Visible = true;
          ++this.stage;
          this.Varianty.Enabled = false;
          this.Varianty.BackColor = Color.White;
          break;
        case 1:
          ++this.stage;
          this.BtnFigure.Enabled = true;
          this.BtnStart.Text = "ЗАНОВО";
          MyUtils ut1 = this.ut;
          Form form1 = (Form) this;
          ref Form local1 = ref form1;
          ut1.SetWaitCursor(ref local1);
          this.Calculate(this.varNo);
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

    private void LoadUslovie()
    {
      string str1 = "10";
      string str2 = "1.0E-4";
      this.InitTaskData();
      this.Ntxt.Text = str1;
      this.EPStxt.Text = str2;
      this.UsloviePicBox.Image = this.GetUsloviePicture();
      switch (this.varNo)
      {
        case 1:
        case 8:
        case 10:
        case 13:
          this.MethodPicBox.Image = this.GetRK4Picture();
          break;
        case 2:
        case 7:
        case 9:
        case 14:
          this.MethodPicBox.Image = this.GetRK3Picture();
          break;
        case 3:
        case 5:
        case 12:
        case 16:
          this.MethodPicBox.Image = this.GetRecalcEilerPicture();
          break;
        case 4:
        case 6:
        case 11:
        case 15:
          this.MethodPicBox.Image = this.GetModifEilerPicture();
          break;
      }
      MyUtils ut1 = this.ut;
      PictureBox pictureBox = this.UsloviePicBox;
      ref PictureBox local1 = ref pictureBox;
      ut1.ResizePicBoxToImage(ref local1);
      this.UsloviePicBox = pictureBox;
      MyUtils ut2 = this.ut;
      pictureBox = this.MethodPicBox;
      ref PictureBox local2 = ref pictureBox;
      ut2.ResizePicBoxToImage(ref local2);
      this.MethodPicBox = pictureBox;
    }

    private void ClearAllData()
    {
      this.stage = (byte) 0;
      this.BtnStart.Text = "СТАРТ";
      this.Ntxt.Visible = false;
      this.NDecrBtn.Visible = false;
      this.NIncrBtn.Visible = false;
      this.X0txt.Visible = false;
      this.XNtxt.Visible = false;
      this.Y0txt.Visible = false;
      this.NLabel.Visible = false;
      this.X0Label.Visible = false;
      this.XNLabel.Visible = false;
      this.Y0Label.Visible = false;
      this.GoBtn.Visible = false;
      this.UsloviePicBox.Visible = false;
      this.MethodPicBox.Visible = false;
      this.Varianty.Enabled = true;
      this.BtnFigure.Enabled = false;
      this.Otvet.Visible = false;
      this.Otvet.Items.Clear();
      this.Otvet.Clear();
    }

    private void GoBtn_Click(object sender, EventArgs e)
    {
      this.stage = (byte) 2;
      this.BtnFigure.Enabled = true;
      this.BtnFigure.Enabled = true;
      this.BtnStart.Text = "ЗАНОВО";
      this.Otvet.Items.Clear();
      this.Otvet.Clear();
      this.Calculate(this.varNo);
    }

    private void BtnFigure_Click(object sender, EventArgs e)
    {
      object obj = (object) new Bitmap(MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      this.g = Graphics.FromImage((Image) obj);
      MyProject.Forms.Plot.PictureBox1.Image = (Image) obj;
      this.ut.MyDrawFigure2(ref this.calc.X, ref this.calc.Y, ref this.calc.Z, ref this.g, MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      this.g.Dispose();
      MyProject.Forms.Plot.Text = "График решения";
      MyProject.Forms.Plot.HelpProvider1.SetHelpString((Control) MyProject.Forms.Plot.PictureBox1, "Синим цветом показано аналитическое решение. Красным цветом показано численнное решение задачи.");
      int num = (int) MyProject.Forms.Plot.ShowDialog((IWin32Window) this);
    }

    private void Calculate(int No)
    {
      MyUtils ut1 = this.ut;
      TextBox x0txt = this.X0txt;
      ref TextBox local1 = ref x0txt;
      int num1 = ut1.MyCheckNumValue(ref local1) ? 1 : 0;
      this.X0txt = x0txt;
      MyUtils ut2 = this.ut;
      TextBox xntxt = this.XNtxt;
      ref TextBox local2 = ref xntxt;
      int num2 = ut2.MyCheckNumValue(ref local2) ? 1 : 0;
      this.XNtxt = xntxt;
      int num3 = num1 & num2;
      MyUtils ut3 = this.ut;
      TextBox y0txt = this.Y0txt;
      ref TextBox local3 = ref y0txt;
      int num4 = ut3.MyCheckNumValue(ref local3) ? 1 : 0;
      this.Y0txt = y0txt;
      int num5 = num3 & num4;
      MyUtils ut4 = this.ut;
      TextBox ntxt = this.Ntxt;
      ref TextBox local4 = ref ntxt;
      int num6 = ut4.MyCheckNumValue(ref local4) ? 1 : 0;
      this.Ntxt = ntxt;
      int num7 = num5 & num6;
      MyUtils ut5 = this.ut;
      TextBox epStxt = this.EPStxt;
      ref TextBox local5 = ref epStxt;
      int num8 = ut5.MyCheckNumValue(ref local5) ? 1 : 0;
      this.EPStxt = epStxt;
      if ((num7 & num8) == 0)
        return;
      this.calc.X0 = double.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.X0txt.Text)));
      this.calc.XN = double.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.XNtxt.Text)));
      this.calc.Y0 = double.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Y0txt.Text)));
      this.calc.N = (int) Math.Round(double.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ntxt.Text))));
      this.calc.EPS = double.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.EPStxt.Text)));
      this.calc.Calculate(No);
      ListViewItem listViewItem1 = new ListViewItem("X    ");
      ListViewItem listViewItem2 = new ListViewItem("Y    ");
      ListViewItem listViewItem3 = new ListViewItem("Z    ");
      ListViewItem listViewItem4 = new ListViewItem("Diff ");
      this.Otvet.Columns.Add("", -2, HorizontalAlignment.Left);
      this.Otvet.GridLines = true;
      double dbl_in = Conversions.ToDouble(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.Y, new object[1]
        {
          (object) 1
        }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.Z, new object[1]
        {
          (object) 1
        }, (string[]) null))
      }, (string[]) null, (System.Type[]) null, (bool[]) null));
      int num9 = 1;
      do
      {
        this.Otvet.Columns.Add(num9.ToString(), -2, HorizontalAlignment.Left);
        listViewItem1.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
        {
          (object) num9
        }, (string[]) null))));
        listViewItem2.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.Y, new object[1]
        {
          (object) num9
        }, (string[]) null))));
        listViewItem3.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.Z, new object[1]
        {
          (object) num9
        }, (string[]) null))));
        if (Operators.ConditionalCompareObjectLess((object) dbl_in, NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
        {
          Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.Y, new object[1]
          {
            (object) num9
          }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.Z, new object[1]
          {
            (object) num9
          }, (string[]) null))
        }, (string[]) null, (System.Type[]) null, (bool[]) null), false))
          dbl_in = Conversions.ToDouble(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
          {
            Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.Y, new object[1]
            {
              (object) num9
            }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.Z, new object[1]
            {
              (object) num9
            }, (string[]) null))
          }, (string[]) null, (System.Type[]) null, (bool[]) null));
        ++num9;
      }
      while (num9 <= 11);
      listViewItem4.SubItems.Add(this.ut.MyDblToStr(dbl_in));
      listViewItem2.ForeColor = Color.Blue;
      listViewItem3.ForeColor = Color.Red;
      listViewItem4.ForeColor = Color.Green;
      this.Otvet.Items.Add(listViewItem1);
      this.Otvet.Items.Add(listViewItem2);
      this.Otvet.Items.Add(listViewItem3);
      this.Otvet.Items.Add(listViewItem4);
      this.Otvet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
      this.Otvet.Visible = true;
    }

    private void InitTaskData()
    {
      switch (this.varNo)
      {
        case 1:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "2.0";
          this.Y0txt.Text = "1.0";
          break;
        case 2:
          this.X0txt.Text = "0.0";
          this.XNtxt.Text = "1.0";
          this.Y0txt.Text = "0.0";
          break;
        case 3:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "1.1";
          this.Y0txt.Text = "-1.0";
          break;
        case 4:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "2.0";
          this.Y0txt.Text = this.ut.MyDblToStr(1.0 + Math.Sqrt(2.0));
          break;
        case 5:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "1.2";
          this.Y0txt.Text = "1.0";
          break;
        case 6:
          this.X0txt.Text = "0.0";
          this.XNtxt.Text = "1.0";
          this.Y0txt.Text = "-3.0";
          break;
        case 7:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "1.2";
          this.Y0txt.Text = "1.0";
          break;
        case 8:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "2.0";
          this.Y0txt.Text = "2.0";
          break;
        case 9:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "2.0";
          this.Y0txt.Text = "2.0";
          break;
        case 10:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "2.0";
          this.Y0txt.Text = "0.5";
          break;
        case 11:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "2.0";
          this.Y0txt.Text = "-3.0";
          break;
        case 12:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "2.0";
          this.Y0txt.Text = "-1.0";
          break;
        case 13:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "2.0";
          this.Y0txt.Text = "1.5";
          break;
        case 14:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "2.0";
          this.Y0txt.Text = "12.0";
          break;
        case 15:
          this.X0txt.Text = "1.0";
          this.XNtxt.Text = "2.0";
          this.Y0txt.Text = "4.0";
          break;
        case 16:
          this.X0txt.Text = "2.0";
          this.XNtxt.Text = "3.0";
          this.Y0txt.Text = "4.0";
          break;
      }
    }

    private Image GetUsloviePicture()
    {
      Image image = (Image) Proverka.My.Resources.Resources.L3u1;
      switch (this.varNo)
      {
        case 1:
          image = (Image) Proverka.My.Resources.Resources.L3u1;
          break;
        case 2:
          image = (Image) Proverka.My.Resources.Resources.L3u2;
          break;
        case 3:
          image = (Image) Proverka.My.Resources.Resources.L3u3;
          break;
        case 4:
          image = (Image) Proverka.My.Resources.Resources.L3u4;
          break;
        case 5:
          image = (Image) Proverka.My.Resources.Resources.L3u5;
          break;
        case 6:
          image = (Image) Proverka.My.Resources.Resources.L3u6;
          break;
        case 7:
          image = (Image) Proverka.My.Resources.Resources.L3u7;
          break;
        case 8:
          image = (Image) Proverka.My.Resources.Resources.L3u8;
          break;
        case 9:
          image = (Image) Proverka.My.Resources.Resources.L3u9;
          break;
        case 10:
          image = (Image) Proverka.My.Resources.Resources.L3u10;
          break;
        case 11:
          image = (Image) Proverka.My.Resources.Resources.L3u11;
          break;
        case 12:
          image = (Image) Proverka.My.Resources.Resources.L3u12;
          break;
        case 13:
          image = (Image) Proverka.My.Resources.Resources.L3u13;
          break;
        case 14:
          image = (Image) Proverka.My.Resources.Resources.L3u14;
          break;
        case 15:
          image = (Image) Proverka.My.Resources.Resources.L3u15;
          break;
        case 16:
          image = (Image) Proverka.My.Resources.Resources.L3u16;
          break;
      }
      return image;
    }

    private Image GetModifEilerPicture()
    {
      return (Image) Proverka.My.Resources.Resources.L3m1;
    }

    private Image GetRecalcEilerPicture()
    {
      return (Image) Proverka.My.Resources.Resources.L3m2;
    }

    private Image GetRK3Picture()
    {
      return (Image) Proverka.My.Resources.Resources.L3m5;
    }

    private Image GetRK4Picture()
    {
      return (Image) Proverka.My.Resources.Resources.L3m6;
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Varianty_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.BtnStart.PerformClick();
    }

    private void Ntxt_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
        this.GoBtn.PerformClick();
      else
        this.ut.MyCheckIsDigitKeyDown(ref e);
    }

    private void NumFieldEdit_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 13)
        this.GoBtn.PerformClick();
      else
        this.ut.MyCheckNumKeyDown(ref e);
    }

    private void NDecrBtn_Click(object sender, EventArgs e)
    {
      int num = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ntxt.Text)));
      if (num <= 10)
        return;
      this.Ntxt.Text = (num - 10).ToString();
    }

    private void NIncrBtn_Click(object sender, EventArgs e)
    {
      int num = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ntxt.Text)));
      if (num >= 100)
        return;
      this.Ntxt.Text = (num + 10).ToString();
    }

    private void Ntxt_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
    }

    private void MainFormLab3_FormClosed(object sender, FormClosedEventArgs e)
    {
      MyProject.Forms.Proverka.Show();
    }
  }
}
