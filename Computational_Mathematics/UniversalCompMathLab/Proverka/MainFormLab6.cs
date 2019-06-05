// Decompiled with JetBrains decompiler
// Type: Proverka.MainFormLab6
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
  public class MainFormLab6 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("GoGrpBox")]
    private GroupBox _GoGrpBox;
    [AccessedThroughProperty("GoBtn")]
    private Button _GoBtn;
    [AccessedThroughProperty("Ktxt")]
    private TextBox _Ktxt;
    [AccessedThroughProperty("NDecrBtn")]
    private Button _NDecrBtn;
    [AccessedThroughProperty("NIncrBtn")]
    private Button _NIncrBtn;
    [AccessedThroughProperty("Ntxt")]
    private TextBox _Ntxt;
    [AccessedThroughProperty("NLabel")]
    private Label _NLabel;
    [AccessedThroughProperty("KLabel")]
    private Label _KLabel;
    [AccessedThroughProperty("Otvet")]
    private ListView _Otvet;
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
    [AccessedThroughProperty("UsloviePicBox")]
    private PictureBox _UsloviePicBox;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("KDecrBtn")]
    private Button _KDecrBtn;
    [AccessedThroughProperty("KIncrBtn")]
    private Button _KIncrBtn;
    [AccessedThroughProperty("BtnExit")]
    private Button _BtnExit;
    [AccessedThroughProperty("LDecrBtn")]
    private Button _LDecrBtn;
    [AccessedThroughProperty("LIncrBtn")]
    private Button _LIncrBtn;
    [AccessedThroughProperty("Ltxt")]
    private TextBox _Ltxt;
    [AccessedThroughProperty("LLabel")]
    private Label _LLabel;
    private MyUtils ut;
    private NumericLab6 calc;
    private byte stage;
    private StreamReader fileReader;
    private string strReader;
    private int varNo;
    private int taskNo;
    private double Nmin;
    private double Kmin;
    private double Lmin;
    private double Nmax;
    private double Kmax;
    private double Lmax;
    private Graphics g;

    public MainFormLab6()
    {
      this.FormClosed += new FormClosedEventHandler(this.MainFormLab6_FormClosed);
      this.ut = new MyUtils();
      this.calc = new NumericLab6();
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
      this.GoGrpBox = new GroupBox();
      this.LDecrBtn = new Button();
      this.LIncrBtn = new Button();
      this.Ltxt = new TextBox();
      this.LLabel = new Label();
      this.KDecrBtn = new Button();
      this.KIncrBtn = new Button();
      this.GoBtn = new Button();
      this.Ktxt = new TextBox();
      this.NDecrBtn = new Button();
      this.NIncrBtn = new Button();
      this.Ntxt = new TextBox();
      this.NLabel = new Label();
      this.KLabel = new Label();
      this.Otvet = new ListView();
      this.GroupBox2 = new GroupBox();
      this.BtnExit = new Button();
      this.ZadachaNo = new NumericUpDown();
      this.Label8 = new Label();
      this.BtnClear = new Button();
      this.BtnFigure = new Button();
      this.BtnStart = new Button();
      this.VariantNo = new NumericUpDown();
      this.Label7 = new Label();
      this.UsloviePicBox = new PictureBox();
      this.Label3 = new Label();
      this.Label1 = new Label();
      this.GoGrpBox.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.ZadachaNo.BeginInit();
      this.VariantNo.BeginInit();
      ((ISupportInitialize) this.UsloviePicBox).BeginInit();
      this.SuspendLayout();
      this.GoGrpBox.Controls.Add((Control) this.LDecrBtn);
      this.GoGrpBox.Controls.Add((Control) this.LIncrBtn);
      this.GoGrpBox.Controls.Add((Control) this.Ltxt);
      this.GoGrpBox.Controls.Add((Control) this.LLabel);
      this.GoGrpBox.Controls.Add((Control) this.KDecrBtn);
      this.GoGrpBox.Controls.Add((Control) this.KIncrBtn);
      this.GoGrpBox.Controls.Add((Control) this.GoBtn);
      this.GoGrpBox.Controls.Add((Control) this.Ktxt);
      this.GoGrpBox.Controls.Add((Control) this.NDecrBtn);
      this.GoGrpBox.Controls.Add((Control) this.NIncrBtn);
      this.GoGrpBox.Controls.Add((Control) this.Ntxt);
      this.GoGrpBox.Controls.Add((Control) this.NLabel);
      this.GoGrpBox.Controls.Add((Control) this.KLabel);
      this.GoGrpBox.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox goGrpBox1 = this.GoGrpBox;
      Point point1 = new Point(627, 47);
      Point point2 = point1;
      goGrpBox1.Location = point2;
      this.GoGrpBox.Name = "GoGrpBox";
      GroupBox goGrpBox2 = this.GoGrpBox;
      Size size1 = new Size(177, 177);
      Size size2 = size1;
      goGrpBox2.Size = size2;
      this.GoGrpBox.TabIndex = 2;
      this.GoGrpBox.TabStop = false;
      this.GoGrpBox.Visible = false;
      this.LDecrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button ldecrBtn1 = this.LDecrBtn;
      point1 = new Point(124, 92);
      Point point3 = point1;
      ldecrBtn1.Location = point3;
      this.LDecrBtn.Name = "LDecrBtn";
      Button ldecrBtn2 = this.LDecrBtn;
      size1 = new Size(20, 30);
      Size size3 = size1;
      ldecrBtn2.Size = size3;
      this.LDecrBtn.TabIndex = 24;
      this.LDecrBtn.Text = "-";
      this.LDecrBtn.UseVisualStyleBackColor = true;
      this.LDecrBtn.Visible = false;
      this.LIncrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button lincrBtn1 = this.LIncrBtn;
      point1 = new Point(147, 92);
      Point point4 = point1;
      lincrBtn1.Location = point4;
      this.LIncrBtn.Name = "LIncrBtn";
      Button lincrBtn2 = this.LIncrBtn;
      size1 = new Size(20, 30);
      Size size4 = size1;
      lincrBtn2.Size = size4;
      this.LIncrBtn.TabIndex = 23;
      this.LIncrBtn.Text = "+";
      this.LIncrBtn.UseVisualStyleBackColor = true;
      this.LIncrBtn.Visible = false;
      this.Ltxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox ltxt1 = this.Ltxt;
      point1 = new Point(51, 95);
      Point point5 = point1;
      ltxt1.Location = point5;
      this.Ltxt.MaxLength = 15;
      this.Ltxt.Name = "Ltxt";
      TextBox ltxt2 = this.Ltxt;
      size1 = new Size(69, 26);
      Size size5 = size1;
      ltxt2.Size = size5;
      this.Ltxt.TabIndex = 22;
      this.Ltxt.Visible = false;
      this.LLabel.AutoSize = true;
      this.LLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label llabel1 = this.LLabel;
      point1 = new Point(9, 98);
      Point point6 = point1;
      llabel1.Location = point6;
      this.LLabel.Name = "LLabel";
      Label llabel2 = this.LLabel;
      size1 = new Size(34, 20);
      Size size6 = size1;
      llabel2.Size = size6;
      this.LLabel.TabIndex = 21;
      this.LLabel.Text = "L =";
      this.LLabel.Visible = false;
      this.KDecrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button kdecrBtn1 = this.KDecrBtn;
      point1 = new Point(124, 55);
      Point point7 = point1;
      kdecrBtn1.Location = point7;
      this.KDecrBtn.Name = "KDecrBtn";
      Button kdecrBtn2 = this.KDecrBtn;
      size1 = new Size(20, 30);
      Size size7 = size1;
      kdecrBtn2.Size = size7;
      this.KDecrBtn.TabIndex = 20;
      this.KDecrBtn.Text = "-";
      this.KDecrBtn.UseVisualStyleBackColor = true;
      this.KIncrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button kincrBtn1 = this.KIncrBtn;
      point1 = new Point(147, 55);
      Point point8 = point1;
      kincrBtn1.Location = point8;
      this.KIncrBtn.Name = "KIncrBtn";
      Button kincrBtn2 = this.KIncrBtn;
      size1 = new Size(20, 30);
      Size size8 = size1;
      kincrBtn2.Size = size8;
      this.KIncrBtn.TabIndex = 19;
      this.KIncrBtn.Text = "+";
      this.KIncrBtn.UseVisualStyleBackColor = true;
      this.GoBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button goBtn1 = this.GoBtn;
      point1 = new Point(35, 132);
      Point point9 = point1;
      goBtn1.Location = point9;
      this.GoBtn.Name = "GoBtn";
      Button goBtn2 = this.GoBtn;
      size1 = new Size(109, 30);
      Size size9 = size1;
      goBtn2.Size = size9;
      this.GoBtn.TabIndex = 18;
      this.GoBtn.Text = "Расчет";
      this.GoBtn.UseVisualStyleBackColor = true;
      this.Ktxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox ktxt1 = this.Ktxt;
      point1 = new Point(51, 58);
      Point point10 = point1;
      ktxt1.Location = point10;
      this.Ktxt.MaxLength = 15;
      this.Ktxt.Name = "Ktxt";
      TextBox ktxt2 = this.Ktxt;
      size1 = new Size(69, 26);
      Size size10 = size1;
      ktxt2.Size = size10;
      this.Ktxt.TabIndex = 17;
      this.NDecrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button ndecrBtn1 = this.NDecrBtn;
      point1 = new Point(124, 18);
      Point point11 = point1;
      ndecrBtn1.Location = point11;
      this.NDecrBtn.Name = "NDecrBtn";
      Button ndecrBtn2 = this.NDecrBtn;
      size1 = new Size(20, 30);
      Size size11 = size1;
      ndecrBtn2.Size = size11;
      this.NDecrBtn.TabIndex = 16;
      this.NDecrBtn.Text = "-";
      this.NDecrBtn.UseVisualStyleBackColor = true;
      this.NIncrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button nincrBtn1 = this.NIncrBtn;
      point1 = new Point(147, 18);
      Point point12 = point1;
      nincrBtn1.Location = point12;
      this.NIncrBtn.Name = "NIncrBtn";
      Button nincrBtn2 = this.NIncrBtn;
      size1 = new Size(20, 30);
      Size size12 = size1;
      nincrBtn2.Size = size12;
      this.NIncrBtn.TabIndex = 15;
      this.NIncrBtn.Text = "+";
      this.NIncrBtn.UseVisualStyleBackColor = true;
      this.Ntxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox ntxt1 = this.Ntxt;
      point1 = new Point(51, 21);
      Point point13 = point1;
      ntxt1.Location = point13;
      this.Ntxt.MaxLength = 15;
      this.Ntxt.Name = "Ntxt";
      TextBox ntxt2 = this.Ntxt;
      size1 = new Size(69, 26);
      Size size13 = size1;
      ntxt2.Size = size13;
      this.Ntxt.TabIndex = 11;
      this.NLabel.AutoSize = true;
      this.NLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label nlabel1 = this.NLabel;
      point1 = new Point(9, 24);
      Point point14 = point1;
      nlabel1.Location = point14;
      this.NLabel.Name = "NLabel";
      Label nlabel2 = this.NLabel;
      size1 = new Size(36, 20);
      Size size14 = size1;
      nlabel2.Size = size14;
      this.NLabel.TabIndex = 0;
      this.NLabel.Text = "N =";
      this.KLabel.AutoSize = true;
      this.KLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label klabel1 = this.KLabel;
      point1 = new Point(9, 61);
      Point point15 = point1;
      klabel1.Location = point15;
      this.KLabel.Name = "KLabel";
      Label klabel2 = this.KLabel;
      size1 = new Size(35, 20);
      Size size15 = size1;
      klabel2.Size = size15;
      this.KLabel.TabIndex = 0;
      this.KLabel.Text = "K =";
      this.Otvet.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Otvet.FullRowSelect = true;
      this.Otvet.GridLines = true;
      ListView otvet1 = this.Otvet;
      point1 = new Point(12, 278);
      Point point16 = point1;
      otvet1.Location = point16;
      this.Otvet.MultiSelect = false;
      this.Otvet.Name = "Otvet";
      ListView otvet2 = this.Otvet;
      size1 = new Size(868, 169);
      Size size16 = size1;
      otvet2.Size = size16;
      this.Otvet.TabIndex = 22;
      this.Otvet.UseCompatibleStateImageBehavior = false;
      this.Otvet.View = View.Details;
      this.Otvet.Visible = false;
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
      point1 = new Point(12, 453);
      Point point17 = point1;
      groupBox2_1.Location = point17;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(868, 98);
      Size size17 = size1;
      groupBox2_2.Size = size17;
      this.GroupBox2.TabIndex = 21;
      this.GroupBox2.TabStop = false;
      this.BtnExit.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnExit1 = this.BtnExit;
      point1 = new Point(707, 37);
      Point point18 = point1;
      btnExit1.Location = point18;
      this.BtnExit.Name = "BtnExit";
      Button btnExit2 = this.BtnExit;
      size1 = new Size(138, 30);
      Size size18 = size1;
      btnExit2.Size = size18;
      this.BtnExit.TabIndex = 19;
      this.BtnExit.Text = "ВЫХОД";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.ZadachaNo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown zadachaNo1 = this.ZadachaNo;
      point1 = new Point(106, 57);
      Point point19 = point1;
      zadachaNo1.Location = point19;
      NumericUpDown zadachaNo2 = this.ZadachaNo;
      Decimal num1 = new Decimal(new int[4]
      {
        15,
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
      Size size19 = size1;
      zadachaNo4.Size = size19;
      this.ZadachaNo.TabIndex = 7;
      NumericUpDown zadachaNo5 = this.ZadachaNo;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num4 = num1;
      zadachaNo5.Value = num4;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label8_1 = this.Label8;
      point1 = new Point(14, 59);
      Point point20 = point1;
      label8_1.Location = point20;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(78, 20);
      Size size20 = size1;
      label8_2.Size = size20;
      this.Label8.TabIndex = 6;
      this.Label8.Text = "Задача:";
      this.BtnClear.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnClear1 = this.BtnClear;
      point1 = new Point(540, 37);
      Point point21 = point1;
      btnClear1.Location = point21;
      this.BtnClear.Name = "BtnClear";
      Button btnClear2 = this.BtnClear;
      size1 = new Size(138, 30);
      Size size21 = size1;
      btnClear2.Size = size21;
      this.BtnClear.TabIndex = 4;
      this.BtnClear.Text = "ОЧИСТИТЬ";
      this.BtnClear.UseVisualStyleBackColor = true;
      this.BtnFigure.Enabled = false;
      this.BtnFigure.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnFigure1 = this.BtnFigure;
      point1 = new Point(386, 37);
      Point point22 = point1;
      btnFigure1.Location = point22;
      this.BtnFigure.Name = "BtnFigure";
      Button btnFigure2 = this.BtnFigure;
      size1 = new Size(125, 30);
      Size size22 = size1;
      btnFigure2.Size = size22;
      this.BtnFigure.TabIndex = 3;
      this.BtnFigure.Text = "ГРАФИК";
      this.BtnFigure.UseVisualStyleBackColor = true;
      this.BtnStart.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnStart1 = this.BtnStart;
      point1 = new Point(219, 37);
      Point point23 = point1;
      btnStart1.Location = point23;
      this.BtnStart.Name = "BtnStart";
      Button btnStart2 = this.BtnStart;
      size1 = new Size(138, 30);
      Size size23 = size1;
      btnStart2.Size = size23;
      this.BtnStart.TabIndex = 1;
      this.BtnStart.Text = "СТАРТ";
      this.BtnStart.UseVisualStyleBackColor = true;
      this.VariantNo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown variantNo1 = this.VariantNo;
      point1 = new Point(106, 20);
      Point point24 = point1;
      variantNo1.Location = point24;
      NumericUpDown variantNo2 = this.VariantNo;
      num1 = new Decimal(new int[4]{ 2, 0, 0, 0 });
      Decimal num5 = num1;
      variantNo2.Maximum = num5;
      NumericUpDown variantNo3 = this.VariantNo;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num6 = num1;
      variantNo3.Minimum = num6;
      this.VariantNo.Name = "VariantNo";
      NumericUpDown variantNo4 = this.VariantNo;
      size1 = new Size(78, 26);
      Size size24 = size1;
      variantNo4.Size = size24;
      this.VariantNo.TabIndex = 0;
      NumericUpDown variantNo5 = this.VariantNo;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num7 = num1;
      variantNo5.Value = num7;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label7_1 = this.Label7;
      point1 = new Point(14, 22);
      Point point25 = point1;
      label7_1.Location = point25;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(86, 20);
      Size size25 = size1;
      label7_2.Size = size25;
      this.Label7.TabIndex = 0;
      this.Label7.Text = "Вариант:";
      this.UsloviePicBox.BackColor = Color.White;
      PictureBox usloviePicBox1 = this.UsloviePicBox;
      point1 = new Point(12, 30);
      Point point26 = point1;
      usloviePicBox1.Location = point26;
      this.UsloviePicBox.Name = "UsloviePicBox";
      PictureBox usloviePicBox2 = this.UsloviePicBox;
      size1 = new Size(480, 215);
      Size size26 = size1;
      usloviePicBox2.Size = size26;
      this.UsloviePicBox.TabIndex = 20;
      this.UsloviePicBox.TabStop = false;
      this.UsloviePicBox.Visible = false;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label3_1 = this.Label3;
      point1 = new Point(8, (int) byte.MaxValue);
      Point point27 = point1;
      label3_1.Location = point27;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(351, 20);
      Size size27 = size1;
      label3_2.Size = size27;
      this.Label3.TabIndex = 18;
      this.Label3.Text = "3. Решение в конечный момент времени";
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label1_1 = this.Label1;
      point1 = new Point(8, 9);
      Point point28 = point1;
      label1_1.Location = point28;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(93, 20);
      Size size28 = size1;
      label1_2.Size = size28;
      this.Label1.TabIndex = 19;
      this.Label1.Text = "1. Задача";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(889, 563);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Otvet);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.UsloviePicBox);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.GoGrpBox);
      this.Name = nameof (MainFormLab6);
      this.ShowIcon = false;
      this.Text = "ПРОВЕРКА ЛАБОРАТОРНОЙ РАБОТЫ №6";
      this.GoGrpBox.ResumeLayout(false);
      this.GoGrpBox.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ZadachaNo.EndInit();
      this.VariantNo.EndInit();
      ((ISupportInitialize) this.UsloviePicBox).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual GroupBox GoGrpBox
    {
      get
      {
        return this._GoGrpBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GoGrpBox = value;
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

    internal virtual TextBox Ktxt
    {
      get
      {
        return this._Ktxt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Ktxt = value;
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

    internal virtual TextBox Ntxt
    {
      get
      {
        return this._Ntxt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Ntxt = value;
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
        this._ZadachaNo = value;
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
          this._BtnFigure.Click -= new EventHandler(this.btnFigure_Click);
        this._BtnFigure = value;
        if (this._BtnFigure == null)
          return;
        this._BtnFigure.Click += new EventHandler(this.btnFigure_Click);
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
        this._VariantNo = value;
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

    internal virtual Button KDecrBtn
    {
      get
      {
        return this._KDecrBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._KDecrBtn != null)
          this._KDecrBtn.Click -= new EventHandler(this.KDecrBtn_Click);
        this._KDecrBtn = value;
        if (this._KDecrBtn == null)
          return;
        this._KDecrBtn.Click += new EventHandler(this.KDecrBtn_Click);
      }
    }

    internal virtual Button KIncrBtn
    {
      get
      {
        return this._KIncrBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._KIncrBtn != null)
          this._KIncrBtn.Click -= new EventHandler(this.KIncrBtn_Click);
        this._KIncrBtn = value;
        if (this._KIncrBtn == null)
          return;
        this._KIncrBtn.Click += new EventHandler(this.KIncrBtn_Click);
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

    internal virtual Button LDecrBtn
    {
      get
      {
        return this._LDecrBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LDecrBtn != null)
          this._LDecrBtn.Click -= new EventHandler(this.LDecrBtn_Click);
        this._LDecrBtn = value;
        if (this._LDecrBtn == null)
          return;
        this._LDecrBtn.Click += new EventHandler(this.LDecrBtn_Click);
      }
    }

    internal virtual Button LIncrBtn
    {
      get
      {
        return this._LIncrBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._LIncrBtn != null)
          this._LIncrBtn.Click -= new EventHandler(this.LIncrBtn_Click);
        this._LIncrBtn = value;
        if (this._LIncrBtn == null)
          return;
        this._LIncrBtn.Click += new EventHandler(this.LIncrBtn_Click);
      }
    }

    internal virtual TextBox Ltxt
    {
      get
      {
        return this._Ltxt;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Ltxt = value;
      }
    }

    internal virtual Label LLabel
    {
      get
      {
        return this._LLabel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._LLabel = value;
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
          if (this.varNo == 2)
          {
            this.Ltxt.Visible = true;
            this.LLabel.Visible = true;
          }
          this.NIncrBtn.Visible = true;
          this.NDecrBtn.Visible = true;
          this.KIncrBtn.Visible = true;
          this.KDecrBtn.Visible = true;
          if (this.varNo == 2)
          {
            this.LIncrBtn.Visible = true;
            this.LDecrBtn.Visible = true;
          }
          this.GoBtn.Visible = true;
          this.GoGrpBox.Visible = true;
          this.UsloviePicBox.Visible = true;
          ++this.stage;
          this.VariantNo.Enabled = false;
          this.VariantNo.BackColor = Color.White;
          this.ZadachaNo.Enabled = false;
          this.ZadachaNo.BackColor = Color.White;
          break;
        case 1:
          ++this.stage;
          if (this.varNo == 1)
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
      if (this.varNo == 1)
        this.BtnFigure.Enabled = true;
      this.BtnStart.Text = "ЗАНОВО";
      this.Otvet.Items.Clear();
      this.Otvet.Clear();
      this.Calculate();
    }

    private void NDecrBtn_Click(object sender, EventArgs e)
    {
      int num = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ntxt.Text)));
      if ((double) num <= this.Nmin)
        return;
      this.Ntxt.Text = (num - 1).ToString();
    }

    private void NIncrBtn_Click(object sender, EventArgs e)
    {
      int num = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ntxt.Text)));
      if ((double) num >= this.Nmax)
        return;
      this.Ntxt.Text = (num + 1).ToString();
    }

    private void KDecrBtn_Click(object sender, EventArgs e)
    {
      int num = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ktxt.Text)));
      if ((double) num <= this.Kmin)
        return;
      this.Ktxt.Text = ((int) Math.Round((double) (num - 1) / 2.0 + 1.0)).ToString();
    }

    private void KIncrBtn_Click(object sender, EventArgs e)
    {
      int num = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ktxt.Text)));
      if ((double) num >= this.Kmax)
        return;
      this.Ktxt.Text = (2 * (num - 1) + 1).ToString();
    }

    private void LDecrBtn_Click(object sender, EventArgs e)
    {
      int num = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ltxt.Text)));
      if ((double) num <= this.Lmin)
        return;
      this.Ltxt.Text = ((int) Math.Round((double) (num - 1) / 2.0 + 1.0)).ToString();
    }

    private void LIncrBtn_Click(object sender, EventArgs e)
    {
      int num = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ltxt.Text)));
      if ((double) num >= this.Lmax)
        return;
      this.Ltxt.Text = (2 * (num - 1) + 1).ToString();
    }

    private void LoadUslovie()
    {
      switch (this.varNo)
      {
        case 1:
          this.Ntxt.Text = "11";
          this.Ktxt.Text = "11";
          this.Kmin = 11.0;
          this.Nmin = 11.0;
          this.Nmax = 100001.0;
          this.Kmax = 100001.0;
          this.Lmax = 100001.0;
          break;
        case 2:
          this.Ntxt.Text = "6";
          this.Ktxt.Text = "6";
          this.Ltxt.Text = "6";
          this.Kmin = 6.0;
          this.Lmin = 6.0;
          this.Nmin = 6.0;
          this.Nmax = 801.0;
          this.Kmax = 801.0;
          this.Lmax = 801.0;
          break;
      }
      this.UsloviePicBox.Image = this.GetUsloviePicture();
      MyUtils ut = this.ut;
      PictureBox usloviePicBox = this.UsloviePicBox;
      ref PictureBox local = ref usloviePicBox;
      ut.ResizePicBoxToImage(ref local);
      this.UsloviePicBox = usloviePicBox;
    }

    private void ClearAllData()
    {
      this.stage = (byte) 0;
      this.BtnStart.Text = "СТАРТ";
      this.Ntxt.Visible = false;
      this.NLabel.Visible = false;
      this.Ktxt.Visible = false;
      this.KLabel.Visible = false;
      this.Ltxt.Visible = false;
      this.LLabel.Visible = false;
      this.NIncrBtn.Visible = false;
      this.NDecrBtn.Visible = false;
      this.KIncrBtn.Visible = false;
      this.KDecrBtn.Visible = false;
      this.LIncrBtn.Visible = false;
      this.LDecrBtn.Visible = false;
      this.GoBtn.Visible = false;
      this.GoGrpBox.Visible = false;
      this.UsloviePicBox.Visible = false;
      this.VariantNo.Enabled = true;
      this.ZadachaNo.Enabled = true;
      this.BtnFigure.Enabled = false;
      this.Otvet.Visible = false;
      this.Otvet.Items.Clear();
      this.Otvet.Clear();
    }

    private void btnFigure_Click(object sender, EventArgs e)
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
      this.calc.N = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ntxt.Text)));
      this.calc.LK = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ktxt.Text)));
      if (this.varNo == 2)
        this.calc.MK = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ltxt.Text)));
      this.calc.Calculate(this.varNo, this.taskNo);
      switch (this.varNo)
      {
        case 1:
          System.Type Type1 = typeof (Math);
          object[] objArray1 = new object[1];
          object[] objArray2 = objArray1;
          NumericLab6 calc1 = this.calc;
          Array uv1 = calc1.UV;
          object[] objArray3 = new object[1];
          object[] objArray4 = objArray3;
          int num1 = 1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) num1;
          objArray4[0] = (object) local1;
          object[] Arguments1 = objArray3;
          object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) uv1, Arguments1, (string[]) null));
          objArray2[0] = objectValue1;
          object[] objArray5 = objArray1;
          object[] Arguments2 = objArray5;
          bool[] flagArray1 = new bool[1]{ true };
          bool[] CopyBack1 = flagArray1;
          object obj1 = NewLateBinding.LateGet((object) null, Type1, "Abs", Arguments2, (string[]) null, (System.Type[]) null, CopyBack1);
          if (flagArray1[0])
            NewLateBinding.LateIndexSetComplex((object) calc1.UV, new object[2]
            {
              (object) num1,
              RuntimeHelpers.GetObjectValue(objArray5[0])
            }, (string[]) null, true, false);
          double dbl_in1 = Conversions.ToDouble(obj1);
          int lk1 = this.calc.LK;
          for (int index = 2; index <= lk1; ++index)
          {
            // ISSUE: variable of a boxed type
            __Boxed<double> local2 = (ValueType) dbl_in1;
            System.Type Type2 = typeof (Math);
            object[] objArray6 = new object[1];
            object[] objArray7 = objArray6;
            NumericLab6 calc2 = this.calc;
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
            if (Operators.ConditionalCompareObjectLess((object) local2, Right, false))
            {
              System.Type Type3 = typeof (Math);
              object[] objArray9 = new object[1];
              object[] objArray10 = objArray9;
              NumericLab6 calc3 = this.calc;
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
              dbl_in1 = Conversions.ToDouble(obj2);
            }
          }
          ListViewItem listViewItem1 = new ListViewItem("X ");
          ListViewItem listViewItem2 = new ListViewItem("Analitic ");
          ListViewItem listViewItem3 = new ListViewItem("Numeric  ");
          ListViewItem listViewItem4 = new ListViewItem("Diff ");
          ListViewItem listViewItem5 = new ListViewItem("MaxDiff ");
          this.Otvet.Columns.Add("", -2, HorizontalAlignment.Left);
          int num2 = 1;
          int num3 = 0;
          while (num2 <= this.calc.LK)
          {
            this.Otvet.Columns.Add(num3.ToString() + " ", -2, HorizontalAlignment.Left);
            listViewItem1.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
            {
              (object) num2
            }, (string[]) null))) + "   ");
            listViewItem2.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UA, new object[1]
            {
              (object) num2
            }, (string[]) null))) + " ");
            listViewItem3.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UM, new object[1]
            {
              (object) num2
            }, (string[]) null))) + " ");
            listViewItem4.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UV, new object[1]
            {
              (object) num2
            }, (string[]) null))) + " ");
            num2 += this.calc.LJ;
            ++num3;
          }
          listViewItem5.SubItems.Add(this.ut.MyDblToStr(dbl_in1));
          listViewItem2.ForeColor = Color.Blue;
          listViewItem3.ForeColor = Color.Red;
          listViewItem5.ForeColor = Color.Green;
          this.Otvet.Items.Add(listViewItem1);
          this.Otvet.Items.Add(listViewItem2);
          this.Otvet.Items.Add(listViewItem3);
          this.Otvet.Items.Add(listViewItem4);
          this.Otvet.Items.Add(listViewItem5);
          break;
        case 2:
          System.Type Type4 = typeof (Math);
          object[] objArray12 = new object[1];
          object[] objArray13 = objArray12;
          NumericLab6 calc4 = this.calc;
          Array uv2 = calc4.UV;
          object[] objArray14 = new object[2];
          object[] objArray15 = objArray14;
          int num4 = 1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) num4;
          objArray15[0] = (object) local3;
          object[] objArray16 = objArray14;
          int num5 = 1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) num5;
          objArray16[1] = (object) local4;
          object[] Arguments5 = objArray14;
          object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) uv2, Arguments5, (string[]) null));
          objArray13[0] = objectValue4;
          object[] objArray17 = objArray12;
          object[] Arguments6 = objArray17;
          bool[] flagArray4 = new bool[1]{ true };
          bool[] CopyBack4 = flagArray4;
          object obj3 = NewLateBinding.LateGet((object) null, Type4, "Abs", Arguments6, (string[]) null, (System.Type[]) null, CopyBack4);
          if (flagArray4[0])
            NewLateBinding.LateIndexSetComplex((object) calc4.UV, new object[3]
            {
              (object) num4,
              (object) num5,
              RuntimeHelpers.GetObjectValue(objArray17[0])
            }, (string[]) null, true, false);
          double dbl_in2 = Conversions.ToDouble(obj3);
          int mk1 = this.calc.MK;
          for (int index1 = 1; index1 <= mk1; ++index1)
          {
            int lk2 = this.calc.LK;
            for (int index2 = 1; index2 <= lk2; ++index2)
            {
              // ISSUE: variable of a boxed type
              __Boxed<double> local2 = (ValueType) dbl_in2;
              System.Type Type2 = typeof (Math);
              object[] objArray6 = new object[1];
              object[] objArray7 = objArray6;
              NumericLab6 calc2 = this.calc;
              object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) calc2.UV, new object[2]
              {
                (object) index2,
                (object) index1
              }, (string[]) null));
              objArray7[0] = objectValue2;
              object[] objArray8 = objArray6;
              object[] Arguments3 = objArray8;
              bool[] flagArray2 = new bool[1]{ true };
              bool[] CopyBack2 = flagArray2;
              object Right = NewLateBinding.LateGet((object) null, Type2, "Abs", Arguments3, (string[]) null, (System.Type[]) null, CopyBack2);
              if (flagArray2[0])
                NewLateBinding.LateIndexSetComplex((object) calc2.UV, new object[3]
                {
                  (object) index2,
                  (object) index1,
                  RuntimeHelpers.GetObjectValue(objArray8[0])
                }, (string[]) null, true, false);
              if (Operators.ConditionalCompareObjectLess((object) local2, Right, false))
              {
                System.Type Type3 = typeof (Math);
                object[] objArray9 = new object[1];
                object[] objArray10 = objArray9;
                NumericLab6 calc3 = this.calc;
                object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) calc3.UV, new object[2]
                {
                  (object) index2,
                  (object) index1
                }, (string[]) null));
                objArray10[0] = objectValue3;
                object[] objArray11 = objArray9;
                object[] Arguments4 = objArray11;
                bool[] flagArray3 = new bool[1]{ true };
                bool[] CopyBack3 = flagArray3;
                object obj2 = NewLateBinding.LateGet((object) null, Type3, "Abs", Arguments4, (string[]) null, (System.Type[]) null, CopyBack3);
                if (flagArray3[0])
                  NewLateBinding.LateIndexSetComplex((object) calc3.UV, new object[3]
                  {
                    (object) index2,
                    (object) index1,
                    RuntimeHelpers.GetObjectValue(objArray11[0])
                  }, (string[]) null, true, false);
                dbl_in2 = Conversions.ToDouble(obj2);
              }
            }
          }
          this.Otvet.Items.Add(new ListViewItem("Analitic")
          {
            ForeColor = Color.Blue
          });
          ListViewItem listViewItem6 = new ListViewItem(" ");
          int num6 = this.calc.LK + 1;
          int lj1 = this.calc.LJ;
          int num7 = num6;
          for (int index = 1; (lj1 >> 31 ^ index) <= (lj1 >> 31 ^ num7); index += lj1)
          {
            this.Otvet.Columns.Add("", -2, HorizontalAlignment.Left);
            listViewItem6.SubItems.Add(this.ut.MyDblToStr(this.calc.R0 + this.calc.HX * (double) (index - 1)));
          }
          listViewItem6.ForeColor = Color.Blue;
          this.Otvet.Items.Add(listViewItem6);
          int mk2 = this.calc.MK;
          int lj2 = this.calc.LJ;
          int num8 = mk2;
          for (int index1 = 1; (lj2 >> 31 ^ index1) <= (lj2 >> 31 ^ num8); index1 += lj2)
          {
            ListViewItem listViewItem7 = new ListViewItem(this.ut.MyDblToStr(this.calc.Q0 + this.calc.HY * (double) (index1 - 1)));
            int lk2 = this.calc.LK;
            int lj3 = this.calc.LJ;
            int num9 = lk2;
            for (int index2 = 1; (lj3 >> 31 ^ index2) <= (lj3 >> 31 ^ num9); index2 += lj3)
              listViewItem7.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UA, new object[2]
              {
                (object) index2,
                (object) index1
              }, (string[]) null))));
            listViewItem7.ForeColor = Color.Blue;
            this.Otvet.Items.Add(listViewItem7);
          }
          this.Otvet.Items.Add(new ListViewItem("Numeric")
          {
            ForeColor = Color.Red
          });
          ListViewItem listViewItem8 = new ListViewItem(" ");
          int lk3 = this.calc.LK;
          int lj4 = this.calc.LJ;
          int num10 = lk3;
          for (int index = 1; (lj4 >> 31 ^ index) <= (lj4 >> 31 ^ num10); index += lj4)
            listViewItem8.SubItems.Add(this.ut.MyDblToStr(this.calc.R0 + this.calc.HX * (double) (index - 1)));
          listViewItem8.ForeColor = Color.Red;
          this.Otvet.Items.Add(listViewItem8);
          int mk3 = this.calc.MK;
          int lj5 = this.calc.LJ;
          int num11 = mk3;
          for (int index1 = 1; (lj5 >> 31 ^ index1) <= (lj5 >> 31 ^ num11); index1 += lj5)
          {
            ListViewItem listViewItem7 = new ListViewItem(this.ut.MyDblToStr(this.calc.Q0 + this.calc.HY * (double) (index1 - 1)));
            int lk2 = this.calc.LK;
            int lj3 = this.calc.LJ;
            int num9 = lk2;
            for (int index2 = 1; (lj3 >> 31 ^ index2) <= (lj3 >> 31 ^ num9); index2 += lj3)
              listViewItem7.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UM, new object[2]
              {
                (object) index2,
                (object) index1
              }, (string[]) null))));
            listViewItem7.ForeColor = Color.Red;
            this.Otvet.Items.Add(listViewItem7);
          }
          this.Otvet.Items.Add(new ListViewItem("MaxDiff")
          {
            SubItems = {
              this.ut.MyDblToStr(dbl_in2)
            },
            ForeColor = Color.Green
          });
          this.Otvet.Items.Add(new ListViewItem("Diff"));
          ListViewItem listViewItem9 = new ListViewItem(" ");
          int lk4 = this.calc.LK;
          int lj6 = this.calc.LJ;
          int num12 = lk4;
          for (int index = 1; (lj6 >> 31 ^ index) <= (lj6 >> 31 ^ num12); index += lj6)
            listViewItem9.SubItems.Add(this.ut.MyDblToStr(this.calc.R0 + this.calc.HX * (double) (index - 1)));
          this.Otvet.Items.Add(listViewItem9);
          int mk4 = this.calc.MK;
          int lj7 = this.calc.LJ;
          int num13 = mk4;
          for (int index1 = 1; (lj7 >> 31 ^ index1) <= (lj7 >> 31 ^ num13); index1 += lj7)
          {
            ListViewItem listViewItem7 = new ListViewItem(this.ut.MyDblToStr(this.calc.Q0 + this.calc.HY * (double) (index1 - 1)));
            int lk2 = this.calc.LK;
            int lj3 = this.calc.LJ;
            int num9 = lk2;
            for (int index2 = 1; (lj3 >> 31 ^ index2) <= (lj3 >> 31 ^ num9); index2 += lj3)
              listViewItem7.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UV, new object[2]
              {
                (object) index2,
                (object) index1
              }, (string[]) null))));
            this.Otvet.Items.Add(listViewItem7);
          }
          break;
      }
      this.Otvet.GridLines = true;
      this.Otvet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
      this.Otvet.Visible = true;
    }

    private Image GetUsloviePicture()
    {
      Image image = (Image) Proverka.My.Resources.Resources.L6u11;
      switch (this.varNo)
      {
        case 1:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L6u11;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L6u12;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L6u13;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L6u14;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L6u15;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L6u16;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L6u17;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L6u18;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L6u19;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L6u110;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L6u111;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L6u112;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L6u113;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L6u114;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L6u115;
              break;
          }
        case 2:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L6u21;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L6u22;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L6u23;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L6u24;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L6u25;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L6u26;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L6u27;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L6u28;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L6u29;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L6u210;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L6u211;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L6u212;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L6u213;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L6u214;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L6u215;
              break;
          }
      }
      return image;
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void MainFormLab6_FormClosed(object sender, FormClosedEventArgs e)
    {
      MyProject.Forms.Proverka.Show();
    }
  }
}
