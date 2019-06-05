// Decompiled with JetBrains decompiler
// Type: Proverka.MainFormLab4
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
  public class MainFormLab4 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("UsloviePicBox")]
    private PictureBox _UsloviePicBox;
    [AccessedThroughProperty("BoundaryPicBox")]
    private PictureBox _BoundaryPicBox;
    [AccessedThroughProperty("KoeffsPicBox")]
    private PictureBox _KoeffsPicBox;
    [AccessedThroughProperty("ModelKoeffsPicBox")]
    private PictureBox _ModelKoeffsPicBox;
    [AccessedThroughProperty("NLabel")]
    private Label _NLabel;
    [AccessedThroughProperty("Ntxt")]
    private TextBox _Ntxt;
    [AccessedThroughProperty("GoBtn")]
    private Button _GoBtn;
    [AccessedThroughProperty("Otvet")]
    private ListView _Otvet;
    [AccessedThroughProperty("NIncrBtn")]
    private Button _NIncrBtn;
    [AccessedThroughProperty("NDecrBtn")]
    private Button _NDecrBtn;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
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
    [AccessedThroughProperty("ShowSolutionBtn")]
    private Button _ShowSolutionBtn;
    [AccessedThroughProperty("ZadachaNo")]
    private NumericUpDown _ZadachaNo;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("BtnExit")]
    private Button _BtnExit;
    private MyUtils ut;
    private NumericLab4 calc;
    private byte stage;
    private StreamReader fileReader;
    private string strReader;
    private int varNo;
    private int taskNo;
    private Graphics g;
    private double DAM;

    public MainFormLab4()
    {
      this.FormClosed += new FormClosedEventHandler(this.MainFormLab4_FormClosed);
      this.ut = new MyUtils();
      this.calc = new NumericLab4();
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
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.UsloviePicBox = new PictureBox();
      this.BoundaryPicBox = new PictureBox();
      this.KoeffsPicBox = new PictureBox();
      this.ModelKoeffsPicBox = new PictureBox();
      this.NLabel = new Label();
      this.Ntxt = new TextBox();
      this.GoBtn = new Button();
      this.Otvet = new ListView();
      this.NIncrBtn = new Button();
      this.NDecrBtn = new Button();
      this.GroupBox1 = new GroupBox();
      this.BtnExit = new Button();
      this.ZadachaNo = new NumericUpDown();
      this.Label8 = new Label();
      this.ShowSolutionBtn = new Button();
      this.BtnClear = new Button();
      this.BtnFigure = new Button();
      this.BtnStart = new Button();
      this.VariantNo = new NumericUpDown();
      this.Label7 = new Label();
      ((ISupportInitialize) this.UsloviePicBox).BeginInit();
      ((ISupportInitialize) this.BoundaryPicBox).BeginInit();
      ((ISupportInitialize) this.KoeffsPicBox).BeginInit();
      ((ISupportInitialize) this.ModelKoeffsPicBox).BeginInit();
      this.GroupBox1.SuspendLayout();
      this.ZadachaNo.BeginInit();
      this.VariantNo.BeginInit();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label1_1 = this.Label1;
      Point point1 = new Point(8, 5);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(120, 20);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "1. Уравнение";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label2_1 = this.Label2;
      point1 = new Point(486, 5);
      Point point3 = point1;
      label2_1.Location = point3;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(175, 20);
      Size size3 = size1;
      label2_2.Size = size3;
      this.Label2.TabIndex = 1;
      this.Label2.Text = "2. Краевые условия";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label3_1 = this.Label3;
      point1 = new Point(8, 105);
      Point point4 = point1;
      label3_1.Location = point4;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(164, 20);
      Size size4 = size1;
      label3_2.Size = size4;
      this.Label3.TabIndex = 2;
      this.Label3.Text = "3. Коэффициенты";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label4_1 = this.Label4;
      point1 = new Point(486, 105);
      Point point5 = point1;
      label4_1.Location = point5;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(330, 20);
      Size size5 = size1;
      label4_2.Size = size5;
      this.Label4.TabIndex = 3;
      this.Label4.Text = "4. Коэффициенты модельной задачи";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label5_1 = this.Label5;
      point1 = new Point(8, 215);
      Point point6 = point1;
      label5_1.Location = point6;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(262, 20);
      Size size6 = size1;
      label5_2.Size = size6;
      this.Label5.TabIndex = 4;
      this.Label5.Text = "5. Таблица значений функции";
      this.UsloviePicBox.BackColor = Color.White;
      PictureBox usloviePicBox1 = this.UsloviePicBox;
      point1 = new Point(12, 26);
      Point point7 = point1;
      usloviePicBox1.Location = point7;
      this.UsloviePicBox.Name = "UsloviePicBox";
      PictureBox usloviePicBox2 = this.UsloviePicBox;
      size1 = new Size((int) byte.MaxValue, 57);
      Size size7 = size1;
      usloviePicBox2.Size = size7;
      this.UsloviePicBox.TabIndex = 5;
      this.UsloviePicBox.TabStop = false;
      this.UsloviePicBox.Visible = false;
      this.BoundaryPicBox.BackColor = Color.White;
      PictureBox boundaryPicBox1 = this.BoundaryPicBox;
      point1 = new Point(490, 26);
      Point point8 = point1;
      boundaryPicBox1.Location = point8;
      this.BoundaryPicBox.Name = "BoundaryPicBox";
      PictureBox boundaryPicBox2 = this.BoundaryPicBox;
      size1 = new Size(305, 70);
      Size size8 = size1;
      boundaryPicBox2.Size = size8;
      this.BoundaryPicBox.TabIndex = 6;
      this.BoundaryPicBox.TabStop = false;
      this.BoundaryPicBox.Visible = false;
      this.KoeffsPicBox.BackColor = Color.White;
      PictureBox koeffsPicBox1 = this.KoeffsPicBox;
      point1 = new Point(12, 128);
      Point point9 = point1;
      koeffsPicBox1.Location = point9;
      this.KoeffsPicBox.Name = "KoeffsPicBox";
      PictureBox koeffsPicBox2 = this.KoeffsPicBox;
      size1 = new Size(470, 75);
      Size size9 = size1;
      koeffsPicBox2.Size = size9;
      this.KoeffsPicBox.TabIndex = 7;
      this.KoeffsPicBox.TabStop = false;
      this.KoeffsPicBox.Visible = false;
      this.ModelKoeffsPicBox.BackColor = Color.White;
      PictureBox modelKoeffsPicBox1 = this.ModelKoeffsPicBox;
      point1 = new Point(490, 128);
      Point point10 = point1;
      modelKoeffsPicBox1.Location = point10;
      this.ModelKoeffsPicBox.Name = "ModelKoeffsPicBox";
      PictureBox modelKoeffsPicBox2 = this.ModelKoeffsPicBox;
      size1 = new Size(396, 45);
      Size size10 = size1;
      modelKoeffsPicBox2.Size = size10;
      this.ModelKoeffsPicBox.TabIndex = 8;
      this.ModelKoeffsPicBox.TabStop = false;
      this.ModelKoeffsPicBox.Visible = false;
      this.NLabel.AutoSize = true;
      this.NLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label nlabel1 = this.NLabel;
      point1 = new Point(572, 215);
      Point point11 = point1;
      nlabel1.Location = point11;
      this.NLabel.Name = "NLabel";
      Label nlabel2 = this.NLabel;
      size1 = new Size(36, 20);
      Size size11 = size1;
      nlabel2.Size = size11;
      this.NLabel.TabIndex = 5;
      this.NLabel.Text = "N =";
      this.NLabel.Visible = false;
      this.Ntxt.BackColor = Color.White;
      this.Ntxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TextBox ntxt1 = this.Ntxt;
      point1 = new Point(614, 212);
      Point point12 = point1;
      ntxt1.Location = point12;
      this.Ntxt.MaxLength = 15;
      this.Ntxt.Name = "Ntxt";
      TextBox ntxt2 = this.Ntxt;
      size1 = new Size(89, 26);
      Size size12 = size1;
      ntxt2.Size = size12;
      this.Ntxt.TabIndex = 6;
      this.Ntxt.Visible = false;
      this.GoBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button goBtn1 = this.GoBtn;
      point1 = new Point(768, 210);
      Point point13 = point1;
      goBtn1.Location = point13;
      this.GoBtn.Name = "GoBtn";
      Button goBtn2 = this.GoBtn;
      size1 = new Size(109, 30);
      Size size13 = size1;
      goBtn2.Size = size13;
      this.GoBtn.TabIndex = 9;
      this.GoBtn.Text = "Расчет";
      this.GoBtn.UseVisualStyleBackColor = true;
      this.GoBtn.Visible = false;
      this.Otvet.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Otvet.FullRowSelect = true;
      this.Otvet.GridLines = true;
      ListView otvet1 = this.Otvet;
      point1 = new Point(12, 246);
      Point point14 = point1;
      otvet1.Location = point14;
      this.Otvet.MultiSelect = false;
      this.Otvet.Name = "Otvet";
      ListView otvet2 = this.Otvet;
      size1 = new Size(865, 175);
      Size size14 = size1;
      otvet2.Size = size14;
      this.Otvet.TabIndex = 10;
      this.Otvet.UseCompatibleStateImageBehavior = false;
      this.Otvet.View = View.Details;
      this.Otvet.Visible = false;
      this.NIncrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button nincrBtn1 = this.NIncrBtn;
      point1 = new Point(730, 210);
      Point point15 = point1;
      nincrBtn1.Location = point15;
      this.NIncrBtn.Name = "NIncrBtn";
      Button nincrBtn2 = this.NIncrBtn;
      size1 = new Size(20, 30);
      Size size15 = size1;
      nincrBtn2.Size = size15;
      this.NIncrBtn.TabIndex = 8;
      this.NIncrBtn.Text = "+";
      this.NIncrBtn.UseVisualStyleBackColor = true;
      this.NIncrBtn.Visible = false;
      this.NDecrBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button ndecrBtn1 = this.NDecrBtn;
      point1 = new Point(707, 210);
      Point point16 = point1;
      ndecrBtn1.Location = point16;
      this.NDecrBtn.Name = "NDecrBtn";
      Button ndecrBtn2 = this.NDecrBtn;
      size1 = new Size(20, 30);
      Size size16 = size1;
      ndecrBtn2.Size = size16;
      this.NDecrBtn.TabIndex = 7;
      this.NDecrBtn.Text = "-";
      this.NDecrBtn.UseVisualStyleBackColor = true;
      this.NDecrBtn.Visible = false;
      this.GroupBox1.Controls.Add((Control) this.BtnExit);
      this.GroupBox1.Controls.Add((Control) this.ZadachaNo);
      this.GroupBox1.Controls.Add((Control) this.Label8);
      this.GroupBox1.Controls.Add((Control) this.ShowSolutionBtn);
      this.GroupBox1.Controls.Add((Control) this.BtnClear);
      this.GroupBox1.Controls.Add((Control) this.BtnFigure);
      this.GroupBox1.Controls.Add((Control) this.BtnStart);
      this.GroupBox1.Controls.Add((Control) this.VariantNo);
      this.GroupBox1.Controls.Add((Control) this.Label7);
      this.GroupBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(12, 427);
      Point point17 = point1;
      groupBox1_1.Location = point17;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(865, 98);
      Size size17 = size1;
      groupBox1_2.Size = size17;
      this.GroupBox1.TabIndex = 0;
      this.GroupBox1.TabStop = false;
      this.BtnExit.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnExit1 = this.BtnExit;
      point1 = new Point(687, 55);
      Point point18 = point1;
      btnExit1.Location = point18;
      this.BtnExit.Name = "BtnExit";
      Button btnExit2 = this.BtnExit;
      size1 = new Size(138, 30);
      Size size18 = size1;
      btnExit2.Size = size18;
      this.BtnExit.TabIndex = 8;
      this.BtnExit.Text = "ВЫХОД";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.ZadachaNo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown zadachaNo1 = this.ZadachaNo;
      point1 = new Point(125, 58);
      Point point19 = point1;
      zadachaNo1.Location = point19;
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
      Size size19 = size1;
      zadachaNo4.Size = size19;
      this.ZadachaNo.TabIndex = 3;
      NumericUpDown zadachaNo5 = this.ZadachaNo;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num4 = num1;
      zadachaNo5.Value = num4;
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label8_1 = this.Label8;
      point1 = new Point(33, 60);
      Point point20 = point1;
      label8_1.Location = point20;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(78, 20);
      Size size20 = size1;
      label8_2.Size = size20;
      this.Label8.TabIndex = 2;
      this.Label8.Text = "Задача:";
      this.ShowSolutionBtn.Enabled = false;
      this.ShowSolutionBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button showSolutionBtn1 = this.ShowSolutionBtn;
      point1 = new Point(435, 55);
      Point point21 = point1;
      showSolutionBtn1.Location = point21;
      this.ShowSolutionBtn.Name = "ShowSolutionBtn";
      Button showSolutionBtn2 = this.ShowSolutionBtn;
      size1 = new Size(209, 30);
      Size size21 = size1;
      showSolutionBtn2.Size = size21;
      this.ShowSolutionBtn.TabIndex = 6;
      this.ShowSolutionBtn.Text = "ГРАФИК: РЕШЕНИЕ";
      this.ShowSolutionBtn.UseVisualStyleBackColor = true;
      this.BtnClear.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnClear1 = this.BtnClear;
      point1 = new Point(687, 17);
      Point point22 = point1;
      btnClear1.Location = point22;
      this.BtnClear.Name = "BtnClear";
      Button btnClear2 = this.BtnClear;
      size1 = new Size(138, 30);
      Size size22 = size1;
      btnClear2.Size = size22;
      this.BtnClear.TabIndex = 7;
      this.BtnClear.Text = "ОЧИСТИТЬ";
      this.BtnClear.UseVisualStyleBackColor = true;
      this.BtnFigure.Enabled = false;
      this.BtnFigure.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnFigure1 = this.BtnFigure;
      point1 = new Point(435, 17);
      Point point23 = point1;
      btnFigure1.Location = point23;
      this.BtnFigure.Name = "BtnFigure";
      Button btnFigure2 = this.BtnFigure;
      size1 = new Size(209, 30);
      Size size23 = size1;
      btnFigure2.Size = size23;
      this.BtnFigure.TabIndex = 5;
      this.BtnFigure.Text = "ГРАФИК: МОДЕЛЬ";
      this.BtnFigure.UseVisualStyleBackColor = true;
      this.BtnStart.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnStart1 = this.BtnStart;
      point1 = new Point(254, 37);
      Point point24 = point1;
      btnStart1.Location = point24;
      this.BtnStart.Name = "BtnStart";
      Button btnStart2 = this.BtnStart;
      size1 = new Size(138, 30);
      Size size24 = size1;
      btnStart2.Size = size24;
      this.BtnStart.TabIndex = 4;
      this.BtnStart.Text = "СТАРТ";
      this.BtnStart.UseVisualStyleBackColor = true;
      this.VariantNo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown variantNo1 = this.VariantNo;
      point1 = new Point(125, 20);
      Point point25 = point1;
      variantNo1.Location = point25;
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
      Size size25 = size1;
      variantNo4.Size = size25;
      this.VariantNo.TabIndex = 1;
      NumericUpDown variantNo5 = this.VariantNo;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num7 = num1;
      variantNo5.Value = num7;
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label7_1 = this.Label7;
      point1 = new Point(33, 22);
      Point point26 = point1;
      label7_1.Location = point26;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(86, 20);
      Size size26 = size1;
      label7_2.Size = size26;
      this.Label7.TabIndex = 0;
      this.Label7.Text = "Вариант:";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(889, 534);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.NDecrBtn);
      this.Controls.Add((Control) this.NIncrBtn);
      this.Controls.Add((Control) this.Otvet);
      this.Controls.Add((Control) this.GoBtn);
      this.Controls.Add((Control) this.Ntxt);
      this.Controls.Add((Control) this.NLabel);
      this.Controls.Add((Control) this.ModelKoeffsPicBox);
      this.Controls.Add((Control) this.KoeffsPicBox);
      this.Controls.Add((Control) this.BoundaryPicBox);
      this.Controls.Add((Control) this.UsloviePicBox);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Name = nameof (MainFormLab4);
      this.ShowIcon = false;
      this.Text = "ПРОВЕРКА ЛАБОРАТОРНОЙ РАБОТЫ №4";
      ((ISupportInitialize) this.UsloviePicBox).EndInit();
      ((ISupportInitialize) this.BoundaryPicBox).EndInit();
      ((ISupportInitialize) this.KoeffsPicBox).EndInit();
      ((ISupportInitialize) this.ModelKoeffsPicBox).EndInit();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
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

    internal virtual Label Label4
    {
      get
      {
        return this._Label4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label4 = value;
      }
    }

    internal virtual Label Label5
    {
      get
      {
        return this._Label5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label5 = value;
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

    internal virtual PictureBox BoundaryPicBox
    {
      get
      {
        return this._BoundaryPicBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._BoundaryPicBox = value;
      }
    }

    internal virtual PictureBox KoeffsPicBox
    {
      get
      {
        return this._KoeffsPicBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._KoeffsPicBox = value;
      }
    }

    internal virtual PictureBox ModelKoeffsPicBox
    {
      get
      {
        return this._ModelKoeffsPicBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ModelKoeffsPicBox = value;
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

    internal virtual Button ShowSolutionBtn
    {
      get
      {
        return this._ShowSolutionBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ShowSolutionBtn != null)
          this._ShowSolutionBtn.Click -= new EventHandler(this.ShowSolutionBtn_Click);
        this._ShowSolutionBtn = value;
        if (this._ShowSolutionBtn == null)
          return;
        this._ShowSolutionBtn.Click += new EventHandler(this.ShowSolutionBtn_Click);
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
          this.NIncrBtn.Visible = true;
          this.NDecrBtn.Visible = true;
          this.GoBtn.Visible = true;
          this.UsloviePicBox.Visible = true;
          this.BoundaryPicBox.Visible = true;
          this.KoeffsPicBox.Visible = true;
          this.ModelKoeffsPicBox.Visible = true;
          ++this.stage;
          this.VariantNo.Enabled = false;
          this.VariantNo.BackColor = Color.White;
          this.ZadachaNo.Enabled = false;
          this.ZadachaNo.BackColor = Color.White;
          break;
        case 1:
          ++this.stage;
          this.BtnFigure.Enabled = true;
          this.ShowSolutionBtn.Enabled = true;
          this.BtnStart.Text = "ЗАНОВО";
          MyUtils ut1 = this.ut;
          Form form = (Form) this;
          ref Form local1 = ref form;
          ut1.SetWaitCursor(ref local1);
          this.Calculate();
          MyUtils ut2 = this.ut;
          form = (Form) this;
          ref Form local2 = ref form;
          ut2.RestoreCursor(ref local2);
          break;
        default:
          this.ClearAllData();
          break;
      }
    }

    private void GoBtn_Click(object sender, EventArgs e)
    {
      this.stage = (byte) 2;
      this.BtnFigure.Enabled = true;
      this.ShowSolutionBtn.Enabled = true;
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
      if (num >= 81921)
        return;
      this.Ntxt.Text = (2 * (num - 1) + 1).ToString();
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
      this.ClearAllData();
    }

    private void LoadUslovie()
    {
      this.Ntxt.Text = "11";
      this.UsloviePicBox.Image = this.GetUsloviePicture();
      this.BoundaryPicBox.Image = this.GetBoundaryPicture();
      this.KoeffsPicBox.Image = this.GetKoeffsPicture();
      this.ModelKoeffsPicBox.Image = this.GetModelKoeffsPicture();
      MyUtils ut1 = this.ut;
      PictureBox usloviePicBox = this.UsloviePicBox;
      ref PictureBox local1 = ref usloviePicBox;
      ut1.ResizePicBoxToImage(ref local1);
      this.UsloviePicBox = usloviePicBox;
      MyUtils ut2 = this.ut;
      PictureBox boundaryPicBox = this.BoundaryPicBox;
      ref PictureBox local2 = ref boundaryPicBox;
      ut2.ResizePicBoxToImage(ref local2);
      this.BoundaryPicBox = boundaryPicBox;
      MyUtils ut3 = this.ut;
      PictureBox koeffsPicBox = this.KoeffsPicBox;
      ref PictureBox local3 = ref koeffsPicBox;
      ut3.ResizePicBoxToImage(ref local3);
      this.KoeffsPicBox = koeffsPicBox;
      MyUtils ut4 = this.ut;
      PictureBox modelKoeffsPicBox = this.ModelKoeffsPicBox;
      ref PictureBox local4 = ref modelKoeffsPicBox;
      ut4.ResizePicBoxToImage(ref local4);
      this.ModelKoeffsPicBox = modelKoeffsPicBox;
    }

    private void ClearAllData()
    {
      this.stage = (byte) 0;
      this.BtnStart.Text = "СТАРТ";
      this.Ntxt.Visible = false;
      this.NLabel.Visible = false;
      this.NIncrBtn.Visible = false;
      this.NDecrBtn.Visible = false;
      this.GoBtn.Visible = false;
      this.UsloviePicBox.Visible = false;
      this.BoundaryPicBox.Visible = false;
      this.KoeffsPicBox.Visible = false;
      this.ModelKoeffsPicBox.Visible = false;
      this.VariantNo.Enabled = true;
      this.ZadachaNo.Enabled = true;
      this.BtnFigure.Enabled = false;
      this.ShowSolutionBtn.Enabled = false;
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
        num2 = (int) Math.Round((double) num2 + this.calc.LJ);
        ++num1;
      }
      this.g = Graphics.FromImage((Image) obj);
      MyProject.Forms.Plot.PictureBox1.Image = (Image) obj;
      this.ut.MyDrawFigure2(ref instance1, ref instance2, ref instance3, ref this.g, MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      this.g.Dispose();
      MyProject.Forms.Plot.Text = "Модельная задача";
      MyProject.Forms.Plot.HelpProvider1.SetHelpString((Control) MyProject.Forms.Plot.PictureBox1, "Синим цветом показано аналитическое решение модельной задачи. Красным цветом показано численнное решение модельной задачи.");
      int num3 = (int) MyProject.Forms.Plot.ShowDialog((IWin32Window) this);
    }

    private void ShowSolutionBtn_Click(object sender, EventArgs e)
    {
      object obj = (object) new Bitmap(MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      Array instance1 = Array.CreateInstance(typeof (double), 102);
      Array instance2 = Array.CreateInstance(typeof (double), 102);
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
          RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) this.calc.UV, new object[1]
          {
            (object) num2
          }, (string[]) null))
        }, (string[]) null);
        num2 = (int) Math.Round((double) num2 + this.calc.LJ);
        ++num1;
      }
      this.g = Graphics.FromImage((Image) obj);
      MyProject.Forms.Plot.PictureBox1.Image = (Image) obj;
      this.ut.MyDrawFigure1(instance1, instance2, num1 - 1, ref this.g, MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      this.g.Dispose();
      MyProject.Forms.Plot.Text = "Задача с переменными коэффициентами";
      MyProject.Forms.Plot.HelpProvider1.SetHelpString((Control) MyProject.Forms.Plot.PictureBox1, "Численное решение заданной краевой задачи с переменными коэффициентами.");
      int num3 = (int) MyProject.Forms.Plot.ShowDialog((IWin32Window) this);
    }

    private void Calculate()
    {
      this.calc.LK = int.Parse(Conversions.ToString(this.ut.MyStrToDbl(this.Ntxt.Text)));
      switch (this.varNo)
      {
        case 1:
          this.calc.N = this.calc.LK;
          this.calc.Calculate1(this.taskNo);
          break;
        case 2:
          this.calc.N = this.calc.LK;
          this.calc.Calculate2(this.taskNo);
          break;
        case 3:
          this.calc.Calculate3(this.taskNo);
          break;
      }
      int lk1 = this.calc.LK;
      for (int index = 1; index <= lk1; ++index)
        NewLateBinding.LateIndexSet((object) this.calc.X, new object[2]
        {
          (object) index,
          (object) (((double) index - 1.0) * this.calc.H)
        }, (string[]) null);
      double dbl_in = Conversions.ToDouble(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.UM, new object[1]
        {
          (object) 1
        }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.UA, new object[1]
        {
          (object) 1
        }, (string[]) null))
      }, (string[]) null, (System.Type[]) null, (bool[]) null));
      int lk2 = this.calc.LK;
      for (int index = 2; index <= lk2; ++index)
      {
        if (Operators.ConditionalCompareObjectLess((object) dbl_in, NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
        {
          Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.UM, new object[1]
          {
            (object) index
          }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.UA, new object[1]
          {
            (object) index
          }, (string[]) null))
        }, (string[]) null, (System.Type[]) null, (bool[]) null), false))
          dbl_in = Conversions.ToDouble(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
          {
            Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.UM, new object[1]
            {
              (object) index
            }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.UA, new object[1]
            {
              (object) index
            }, (string[]) null))
          }, (string[]) null, (System.Type[]) null, (bool[]) null));
      }
      ListViewItem listViewItem1 = new ListViewItem("X ");
      ListViewItem listViewItem2 = new ListViewItem("ModA ");
      ListViewItem listViewItem3 = new ListViewItem("ModN ");
      ListViewItem listViewItem4 = new ListViewItem("Diff ");
      ListViewItem listViewItem5 = new ListViewItem("MaxDiff ");
      ListViewItem listViewItem6 = new ListViewItem("Answ ");
      this.Otvet.Columns.Add("", -2, HorizontalAlignment.Left);
      this.Otvet.GridLines = true;
      int num1 = 1;
      int num2 = 0;
      while (num1 <= this.calc.LK)
      {
        this.DAM = Conversions.ToDouble(Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.UA, new object[1]
        {
          (object) num1
        }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.UM, new object[1]
        {
          (object) num1
        }, (string[]) null)));
        this.Otvet.Columns.Add(num2.ToString() + " ", -2, HorizontalAlignment.Left);
        listViewItem1.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
        {
          (object) num1
        }, (string[]) null))) + "   ");
        listViewItem2.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UA, new object[1]
        {
          (object) num1
        }, (string[]) null))) + " ");
        listViewItem3.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UM, new object[1]
        {
          (object) num1
        }, (string[]) null))) + " ");
        listViewItem4.SubItems.Add(this.ut.MyDblToStr(this.DAM) + " ");
        listViewItem6.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.UV, new object[1]
        {
          (object) num1
        }, (string[]) null))) + " ");
        num1 = (int) Math.Round((double) num1 + this.calc.LJ);
        ++num2;
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
      this.Otvet.Items.Add(listViewItem6);
      this.Otvet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
      this.Otvet.Visible = true;
    }

    private Image GetUsloviePicture()
    {
      return (Image) Proverka.My.Resources.Resources.L4uslovie;
    }

    private Image GetBoundaryPicture()
    {
      Image image = (Image) Proverka.My.Resources.Resources.L4b1_1;
      switch (this.varNo)
      {
        case 1:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L4b1_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L4b1_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L4b1_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L4b1_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L4b1_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L4b1_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L4b1_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L4b1_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L4b1_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L4b1_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L4b1_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L4b1_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L4b1_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L4b1_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L4b1_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L4b1_16;
              break;
          }
        case 2:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L4b2_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L4b2_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L4b2_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L4b2_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L4b2_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L4b2_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L4b2_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L4b2_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L4b2_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L4b2_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L4b2_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L4b2_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L4b2_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L4b2_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L4b2_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L4b2_16;
              break;
          }
        case 3:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L4b3_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L4b3_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L4b3_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L4b3_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L4b3_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L4b3_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L4b3_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L4b3_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L4b3_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L4b3_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L4b3_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L4b3_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L4b3_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L4b3_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L4b3_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L4b3_16;
              break;
          }
      }
      return image;
    }

    private Image GetKoeffsPicture()
    {
      Image image = (Image) Proverka.My.Resources.Resources.L4k1_1;
      switch (this.varNo)
      {
        case 1:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L4k1_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L4k1_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L4k1_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L4k1_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L4k1_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L4k1_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L4k1_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L4k1_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L4k1_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L4k1_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L4k1_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L4k1_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L4k1_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L4k1_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L4k1_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L4k1_16;
              break;
          }
        case 2:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L4k2_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L4k2_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L4k2_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L4k2_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L4k2_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L4k2_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L4k2_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L4k2_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L4k2_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L4k2_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L4k2_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L4k2_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L4k2_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L4k2_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L4k2_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L4k2_16;
              break;
          }
        case 3:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L4k3_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L4k3_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L4k3_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L4k3_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L4k3_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L4k3_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L4k3_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L4k3_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L4k3_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L4k3_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L4k3_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L4k3_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L4k3_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L4k3_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L4k3_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L4k3_16;
              break;
          }
      }
      return image;
    }

    private Image GetModelKoeffsPicture()
    {
      Image image = (Image) Proverka.My.Resources.Resources.L4km1_1;
      switch (this.varNo)
      {
        case 1:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L4km1_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L4km1_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L4km1_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L4km1_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L4km1_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L4km1_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L4km1_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L4km1_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L4km1_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L4km1_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L4km1_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L4km1_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L4km1_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L4km1_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L4km1_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L4km1_16;
              break;
          }
        case 2:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L4km2_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L4km2_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L4km2_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L4km2_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L4km2_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L4km2_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L4km2_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L4km2_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L4km2_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L4km2_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L4km2_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L4km2_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L4km2_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L4km2_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L4km2_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L4km2_16;
              break;
          }
        case 3:
          switch (this.taskNo)
          {
            case 1:
              image = (Image) Proverka.My.Resources.Resources.L4km3_1;
              break;
            case 2:
              image = (Image) Proverka.My.Resources.Resources.L4km3_2;
              break;
            case 3:
              image = (Image) Proverka.My.Resources.Resources.L4km3_3;
              break;
            case 4:
              image = (Image) Proverka.My.Resources.Resources.L4km3_4;
              break;
            case 5:
              image = (Image) Proverka.My.Resources.Resources.L4km3_5;
              break;
            case 6:
              image = (Image) Proverka.My.Resources.Resources.L4km3_6;
              break;
            case 7:
              image = (Image) Proverka.My.Resources.Resources.L4km3_7;
              break;
            case 8:
              image = (Image) Proverka.My.Resources.Resources.L4km3_8;
              break;
            case 9:
              image = (Image) Proverka.My.Resources.Resources.L4km3_9;
              break;
            case 10:
              image = (Image) Proverka.My.Resources.Resources.L4km3_10;
              break;
            case 11:
              image = (Image) Proverka.My.Resources.Resources.L4km3_11;
              break;
            case 12:
              image = (Image) Proverka.My.Resources.Resources.L4km3_12;
              break;
            case 13:
              image = (Image) Proverka.My.Resources.Resources.L4km3_13;
              break;
            case 14:
              image = (Image) Proverka.My.Resources.Resources.L4km3_14;
              break;
            case 15:
              image = (Image) Proverka.My.Resources.Resources.L4km3_15;
              break;
            case 16:
              image = (Image) Proverka.My.Resources.Resources.L4km3_16;
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

    private void MainFormLab4_FormClosed(object sender, FormClosedEventArgs e)
    {
      MyProject.Forms.Proverka.Show();
    }
  }
}
