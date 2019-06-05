// Decompiled with JetBrains decompiler
// Type: Proverka.MainFormLab2
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
  public class MainFormLab2 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Uslovie")]
    private ListView _Uslovie;
    [AccessedThroughProperty("InterpKoeff")]
    private ListView _InterpKoeff;
    [AccessedThroughProperty("SplinesKoeff")]
    private ListView _SplinesKoeff;
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
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("Fout")]
    private Label _Fout;
    [AccessedThroughProperty("Sout")]
    private Label _Sout;
    [AccessedThroughProperty("XinLabel")]
    private Label _XinLabel;
    [AccessedThroughProperty("BtnCalcY")]
    private Button _BtnCalcY;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Xin")]
    private TextBox _Xin;
    [AccessedThroughProperty("BtnExit")]
    private Button _BtnExit;
    private MyUtils ut;
    private NumericLab2 calc;
    private byte stage;
    private ListViewItem itemX;
    private ListViewItem itemY;
    private int varNo;
    private Graphics g;

    public MainFormLab2()
    {
      this.Load += new EventHandler(this.MainFormLab2_Load);
      this.FormClosed += new FormClosedEventHandler(this.MainFormLab2_FormClosed);
      this.ut = new MyUtils();
      this.calc = new NumericLab2();
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
      this.Uslovie = new ListView();
      this.InterpKoeff = new ListView();
      this.SplinesKoeff = new ListView();
      this.GroupBox1 = new GroupBox();
      this.BtnExit = new Button();
      this.BtnClear = new Button();
      this.BtnFigure = new Button();
      this.BtnStart = new Button();
      this.Varianty = new NumericUpDown();
      this.Label1 = new Label();
      this.GroupBox2 = new GroupBox();
      this.Xin = new TextBox();
      this.Fout = new Label();
      this.Sout = new Label();
      this.XinLabel = new Label();
      this.BtnCalcY = new Button();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.GroupBox1.SuspendLayout();
      this.Varianty.BeginInit();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      this.Uslovie.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Uslovie.FullRowSelect = true;
      this.Uslovie.GridLines = true;
      ListView uslovie1 = this.Uslovie;
      Point point1 = new Point(13, 30);
      Point point2 = point1;
      uslovie1.Location = point2;
      this.Uslovie.MultiSelect = false;
      this.Uslovie.Name = "Uslovie";
      ListView uslovie2 = this.Uslovie;
      Size size1 = new Size(894, 63);
      Size size2 = size1;
      uslovie2.Size = size2;
      this.Uslovie.TabIndex = 2;
      this.Uslovie.UseCompatibleStateImageBehavior = false;
      this.Uslovie.View = View.Details;
      this.Uslovie.Visible = false;
      this.InterpKoeff.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.InterpKoeff.GridLines = true;
      ListView interpKoeff1 = this.InterpKoeff;
      point1 = new Point(13, 123);
      Point point3 = point1;
      interpKoeff1.Location = point3;
      this.InterpKoeff.Name = "InterpKoeff";
      ListView interpKoeff2 = this.InterpKoeff;
      size1 = new Size(894, 83);
      Size size3 = size1;
      interpKoeff2.Size = size3;
      this.InterpKoeff.TabIndex = 3;
      this.InterpKoeff.UseCompatibleStateImageBehavior = false;
      this.InterpKoeff.View = View.Details;
      this.InterpKoeff.Visible = false;
      this.SplinesKoeff.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.SplinesKoeff.GridLines = true;
      ListView splinesKoeff1 = this.SplinesKoeff;
      point1 = new Point(13, 234);
      Point point4 = point1;
      splinesKoeff1.Location = point4;
      this.SplinesKoeff.Name = "SplinesKoeff";
      ListView splinesKoeff2 = this.SplinesKoeff;
      size1 = new Size(651, 195);
      Size size4 = size1;
      splinesKoeff2.Size = size4;
      this.SplinesKoeff.TabIndex = 4;
      this.SplinesKoeff.UseCompatibleStateImageBehavior = false;
      this.SplinesKoeff.View = View.Details;
      this.SplinesKoeff.Visible = false;
      this.GroupBox1.Controls.Add((Control) this.BtnExit);
      this.GroupBox1.Controls.Add((Control) this.BtnClear);
      this.GroupBox1.Controls.Add((Control) this.BtnFigure);
      this.GroupBox1.Controls.Add((Control) this.BtnStart);
      this.GroupBox1.Controls.Add((Control) this.Varianty);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(14, 434);
      Point point5 = point1;
      groupBox1_1.Location = point5;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(893, 55);
      Size size5 = size1;
      groupBox1_2.Size = size5;
      this.GroupBox1.TabIndex = 3;
      this.GroupBox1.TabStop = false;
      this.BtnExit.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnExit1 = this.BtnExit;
      point1 = new Point(718, 16);
      Point point6 = point1;
      btnExit1.Location = point6;
      this.BtnExit.Name = "BtnExit";
      Button btnExit2 = this.BtnExit;
      size1 = new Size(138, 30);
      Size size6 = size1;
      btnExit2.Size = size6;
      this.BtnExit.TabIndex = 9;
      this.BtnExit.Text = "ВЫХОД";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnClear.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnClear1 = this.BtnClear;
      point1 = new Point(554, 17);
      Point point7 = point1;
      btnClear1.Location = point7;
      this.BtnClear.Name = "BtnClear";
      Button btnClear2 = this.BtnClear;
      size1 = new Size(138, 30);
      Size size7 = size1;
      btnClear2.Size = size7;
      this.BtnClear.TabIndex = 8;
      this.BtnClear.Text = "ОЧИСТИТЬ";
      this.BtnClear.UseVisualStyleBackColor = true;
      this.BtnFigure.Enabled = false;
      this.BtnFigure.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnFigure1 = this.BtnFigure;
      point1 = new Point(390, 17);
      Point point8 = point1;
      btnFigure1.Location = point8;
      this.BtnFigure.Name = "BtnFigure";
      Button btnFigure2 = this.BtnFigure;
      size1 = new Size(138, 30);
      Size size8 = size1;
      btnFigure2.Size = size8;
      this.BtnFigure.TabIndex = 7;
      this.BtnFigure.Text = "ГРАФИК";
      this.BtnFigure.UseVisualStyleBackColor = true;
      this.BtnStart.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnStart1 = this.BtnStart;
      point1 = new Point(226, 17);
      Point point9 = point1;
      btnStart1.Location = point9;
      this.BtnStart.Name = "BtnStart";
      Button btnStart2 = this.BtnStart;
      size1 = new Size(138, 30);
      Size size9 = size1;
      btnStart2.Size = size9;
      this.BtnStart.TabIndex = 1;
      this.BtnStart.Text = "СТАРТ";
      this.BtnStart.UseVisualStyleBackColor = true;
      this.Varianty.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown varianty1 = this.Varianty;
      point1 = new Point(104, 20);
      Point point10 = point1;
      varianty1.Location = point10;
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
      Size size10 = size1;
      varianty4.Size = size10;
      this.Varianty.TabIndex = 0;
      NumericUpDown varianty5 = this.Varianty;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num4 = num1;
      varianty5.Value = num4;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label1_1 = this.Label1;
      point1 = new Point(12, 22);
      Point point11 = point1;
      label1_1.Location = point11;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(86, 20);
      Size size11 = size1;
      label1_2.Size = size11;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Вариант:";
      this.GroupBox2.Controls.Add((Control) this.Xin);
      this.GroupBox2.Controls.Add((Control) this.Fout);
      this.GroupBox2.Controls.Add((Control) this.Sout);
      this.GroupBox2.Controls.Add((Control) this.XinLabel);
      this.GroupBox2.Controls.Add((Control) this.BtnCalcY);
      this.GroupBox2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(681, 234);
      Point point12 = point1;
      groupBox2_1.Location = point12;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(226, 195);
      Size size12 = size1;
      groupBox2_2.Size = size12;
      this.GroupBox2.TabIndex = 4;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "4. Вычислить значение";
      this.Xin.Enabled = false;
      TextBox xin1 = this.Xin;
      point1 = new Point(56, 35);
      Point point13 = point1;
      xin1.Location = point13;
      this.Xin.MaxLength = 15;
      this.Xin.Name = "Xin";
      TextBox xin2 = this.Xin;
      size1 = new Size(154, 26);
      Size size13 = size1;
      xin2.Size = size13;
      this.Xin.TabIndex = 5;
      this.Xin.Text = "0.0";
      this.Fout.AutoSize = true;
      this.Fout.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label fout1 = this.Fout;
      point1 = new Point(19, 152);
      Point point14 = point1;
      fout1.Location = point14;
      this.Fout.Name = "Fout";
      Label fout2 = this.Fout;
      size1 = new Size(44, 20);
      Size size14 = size1;
      fout2.Size = size14;
      this.Fout.TabIndex = 10;
      this.Fout.Text = "F(X)";
      this.Fout.Visible = false;
      this.Sout.AutoSize = true;
      this.Sout.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label sout1 = this.Sout;
      point1 = new Point(19, 123);
      Point point15 = point1;
      sout1.Location = point15;
      this.Sout.Name = "Sout";
      Label sout2 = this.Sout;
      size1 = new Size(55, 20);
      Size size15 = size1;
      sout2.Size = size15;
      this.Sout.TabIndex = 9;
      this.Sout.Text = "Sn(X)";
      this.Sout.Visible = false;
      this.XinLabel.AutoSize = true;
      this.XinLabel.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label xinLabel1 = this.XinLabel;
      point1 = new Point(19, 37);
      Point point16 = point1;
      xinLabel1.Location = point16;
      this.XinLabel.Name = "XinLabel";
      Label xinLabel2 = this.XinLabel;
      size1 = new Size(31, 20);
      Size size16 = size1;
      xinLabel2.Size = size16;
      this.XinLabel.TabIndex = 8;
      this.XinLabel.Text = "X=";
      this.BtnCalcY.Enabled = false;
      this.BtnCalcY.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnCalcY1 = this.BtnCalcY;
      point1 = new Point(23, 77);
      Point point17 = point1;
      btnCalcY1.Location = point17;
      this.BtnCalcY.Name = "BtnCalcY";
      Button btnCalcY2 = this.BtnCalcY;
      size1 = new Size(187, 30);
      Size size17 = size1;
      btnCalcY2.Size = size17;
      this.BtnCalcY.TabIndex = 6;
      this.BtnCalcY.Text = "ВЫЧИСЛИТЬ F(X)";
      this.BtnCalcY.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label2_1 = this.Label2;
      point1 = new Point(10, 4);
      Point point18 = point1;
      label2_1.Location = point18;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(192, 20);
      Size size18 = size1;
      label2_2.Size = size18;
      this.Label2.TabIndex = 5;
      this.Label2.Text = "1. Параметры задачи";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label3_1 = this.Label3;
      point1 = new Point(10, 96);
      Point point19 = point1;
      label3_1.Location = point19;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(290, 20);
      Size size19 = size1;
      label3_2.Size = size19;
      this.Label3.TabIndex = 6;
      this.Label3.Text = "2. Интерполяционный многочлен";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label4_1 = this.Label4;
      point1 = new Point(10, 209);
      Point point20 = point1;
      label4_1.Location = point20;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(249, 20);
      Size size20 = size1;
      label4_2.Size = size20;
      this.Label4.TabIndex = 7;
      this.Label4.Text = "3. Коэффициенты сплайнов";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(917, 497);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.SplinesKoeff);
      this.Controls.Add((Control) this.InterpKoeff);
      this.Controls.Add((Control) this.Uslovie);
      this.Name = nameof (MainFormLab2);
      this.ShowIcon = false;
      this.Text = "ПРОВЕРКА ЛАБОРАТОРНОЙ РАБОТЫ №2";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.Varianty.EndInit();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual ListView Uslovie
    {
      get
      {
        return this._Uslovie;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Uslovie = value;
      }
    }

    internal virtual ListView InterpKoeff
    {
      get
      {
        return this._InterpKoeff;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._InterpKoeff = value;
      }
    }

    internal virtual ListView SplinesKoeff
    {
      get
      {
        return this._SplinesKoeff;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._SplinesKoeff = value;
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
          this._BtnStart.Click -= new EventHandler(this.Start_Click);
        this._BtnStart = value;
        if (this._BtnStart == null)
          return;
        this._BtnStart.Click += new EventHandler(this.Start_Click);
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

    internal virtual Label Fout
    {
      get
      {
        return this._Fout;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Fout = value;
      }
    }

    internal virtual Label Sout
    {
      get
      {
        return this._Sout;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Sout = value;
      }
    }

    internal virtual Label XinLabel
    {
      get
      {
        return this._XinLabel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._XinLabel = value;
      }
    }

    internal virtual Button BtnCalcY
    {
      get
      {
        return this._BtnCalcY;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._BtnCalcY != null)
          this._BtnCalcY.Click -= new EventHandler(this.btnCalcY_Click);
        this._BtnCalcY = value;
        if (this._BtnCalcY == null)
          return;
        this._BtnCalcY.Click += new EventHandler(this.btnCalcY_Click);
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

    internal virtual TextBox Xin
    {
      get
      {
        return this._Xin;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Xin != null)
          this._Xin.KeyDown -= new KeyEventHandler(this.Xin_KeyDown);
        this._Xin = value;
        if (this._Xin == null)
          return;
        this._Xin.KeyDown += new KeyEventHandler(this.Xin_KeyDown);
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

    private void Start_Click(object sender, EventArgs e)
    {
      switch (this.stage)
      {
        case 0:
          this.BtnStart.Text = "МНОГОЧЛЕН";
          this.varNo = int.Parse(Conversions.ToString(this.Varianty.Value));
          MyUtils ut1 = this.ut;
          Form form1 = (Form) this;
          ref Form local1 = ref form1;
          ut1.SetWaitCursor(ref local1);
          this.LoadUslovie();
          this.calc.BuildInterpolation();
          MyUtils ut2 = this.ut;
          Form form2 = (Form) this;
          ref Form local2 = ref form2;
          ut2.RestoreCursor(ref local2);
          this.Uslovie.Visible = true;
          ++this.stage;
          this.Varianty.Enabled = false;
          this.Varianty.BackColor = Color.White;
          break;
        case 1:
          this.BtnStart.Text = "СПЛАЙНЫ";
          this.LoadKoeff();
          ++this.stage;
          break;
        case 2:
          this.BtnStart.Text = "ЗАНОВО";
          this.LoadSplines();
          this.SplinesKoeff.Visible = true;
          this.Xin.Enabled = true;
          this.BtnCalcY.Enabled = true;
          this.BtnFigure.Enabled = true;
          ++this.stage;
          break;
        default:
          this.ClearAllData();
          break;
      }
    }

    private void LoadUslovie()
    {
      this.Uslovie.GridLines = true;
      this.itemX = new ListViewItem(" X ");
      this.itemY = new ListViewItem(" Y ");
      this.Uslovie.HeaderStyle = ColumnHeaderStyle.None;
      this.Uslovie.Columns.Add("", -2, HorizontalAlignment.Left);
      this.Uslovie.Items.Add(this.itemX);
      this.Uslovie.Items.Add(this.itemY);
      this.InitTaskData();
      this.Uslovie.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
    }

    private void LoadKoeff()
    {
      string str1 = "";
      string str2 = " - ";
      int nk1 = this.calc.NK;
      for (int index = 1; index <= nk1; ++index)
      {
        string str3 = index <= 1 ? "" : " + ";
        string str4;
        switch (index)
        {
          case 1:
            str4 = "";
            break;
          case 2:
            str4 = "X";
            break;
          default:
            str4 = "*X^" + Conversions.ToString(index - 1);
            break;
        }
        if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
        {
          (object) index
        }, (string[]) null), (object) 0.0, false))
          str1 = str1 + str3 + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
          {
            (object) index
          }, (string[]) null))) + str4;
        if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
        {
          (object) index
        }, (string[]) null), (object) 0.0, false))
        {
          string str5 = str1 + str2;
          MyUtils ut = this.ut;
          System.Type Type = typeof (Math);
          object[] objArray1 = new object[1];
          object[] objArray2 = objArray1;
          NumericLab2 calc = this.calc;
          object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object) calc.A, new object[1]
          {
            (object) index
          }, (string[]) null));
          objArray2[0] = objectValue;
          object[] objArray3 = objArray1;
          object[] Arguments = objArray3;
          bool[] flagArray = new bool[1]{ true };
          bool[] CopyBack = flagArray;
          object obj = NewLateBinding.LateGet((object) null, Type, "Abs", Arguments, (string[]) null, (System.Type[]) null, CopyBack);
          if (flagArray[0])
            NewLateBinding.LateIndexSetComplex((object) calc.A, new object[2]
            {
              (object) index,
              RuntimeHelpers.GetObjectValue(objArray3[0])
            }, (string[]) null, true, false);
          double dbl_in = Conversions.ToDouble(obj);
          string str6 = ut.MyDblToStr(dbl_in);
          string str7 = str4;
          str1 = str5 + str6 + str7;
        }
      }
      ListViewItem listViewItem = new ListViewItem(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
      {
        (object) 1
      }, (string[]) null))));
      this.InterpKoeff.GridLines = true;
      int nk2 = this.calc.NK;
      for (int index = 1; index <= nk2; ++index)
      {
        this.InterpKoeff.Columns.Add("X^" + Conversions.ToString(index - 1), -2, HorizontalAlignment.Left);
        if (index > 1)
          listViewItem.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
          {
            (object) index
          }, (string[]) null))));
      }
      this.InterpKoeff.Items.Add(listViewItem);
      this.InterpKoeff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
      this.InterpKoeff.Visible = true;
    }

    private void LoadSplines()
    {
      this.SplinesKoeff.Columns.Add("i", -2, HorizontalAlignment.Left);
      this.SplinesKoeff.Columns.Add("A0", -2, HorizontalAlignment.Left);
      this.SplinesKoeff.Columns.Add("A1", -2, HorizontalAlignment.Left);
      this.SplinesKoeff.Columns.Add("A2", -2, HorizontalAlignment.Left);
      this.SplinesKoeff.Columns.Add("A3", -2, HorizontalAlignment.Left);
      this.SplinesKoeff.GridLines = true;
      int num1 = this.calc.NK - 1;
      for (int index = 1; index <= num1; ++index)
      {
        string str = "";
        ListViewItem listViewItem = new ListViewItem(index.ToString() + " ");
        int num2 = 1;
        do
        {
          str = str + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.B, new object[2]
          {
            (object) num2,
            (object) index
          }, (string[]) null))) + " ";
          listViewItem.SubItems.Add(this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.B, new object[2]
          {
            (object) num2,
            (object) index
          }, (string[]) null))) + " ");
          ++num2;
        }
        while (num2 <= 4);
        this.SplinesKoeff.Items.Add(listViewItem);
      }
      this.SplinesKoeff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
    }

    private void ClearAllData()
    {
      this.stage = (byte) -((int) this.stage + 1 == 0 ? 1 : 0);
      this.BtnStart.Text = "СТАРТ";
      this.Uslovie.Visible = false;
      this.Uslovie.Columns.Clear();
      this.SplinesKoeff.Visible = false;
      this.Varianty.Enabled = true;
      this.Uslovie.Items.Clear();
      this.SplinesKoeff.Clear();
      this.Xin.Enabled = false;
      this.Xin.Text = "0.0";
      this.BtnCalcY.Enabled = false;
      this.BtnFigure.Enabled = false;
      this.Sout.Visible = false;
      this.Fout.Visible = false;
      this.InterpKoeff.Visible = false;
      this.InterpKoeff.Clear();
    }

    private void BtnFigure_Click(object sender, EventArgs e)
    {
      object obj = (object) new Bitmap(MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      Array instance1 = Array.CreateInstance(typeof (double), 101);
      Array instance2 = Array.CreateInstance(typeof (double), 101);
      Array instance3 = Array.CreateInstance(typeof (double), 101);
      this.g = Graphics.FromImage((Image) obj);
      MyProject.Forms.Plot.PictureBox1.Image = (Image) obj;
      int num1 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) instance1, new object[2]
        {
          (object) num1,
          Operators.AddObject(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) 1
          }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) (num1 - 1), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) this.calc.NK
          }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) 1
          }, (string[]) null))), (object) 99))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance2, new object[2]
        {
          (object) num1,
          (object) 0
        }, (string[]) null);
        int nk = this.calc.NK;
        for (int index = 1; index <= nk; ++index)
          NewLateBinding.LateIndexSet((object) instance2, new object[2]
          {
            (object) num1,
            Operators.AddObject(NewLateBinding.LateIndexGet((object) instance2, new object[1]
            {
              (object) num1
            }, (string[]) null), Operators.MultiplyObject(NewLateBinding.LateIndexGet((object) this.calc.A, new object[1]
            {
              (object) index
            }, (string[]) null), Operators.ExponentObject(NewLateBinding.LateIndexGet((object) instance1, new object[1]
            {
              (object) num1
            }, (string[]) null), (object) (index - 1))))
          }, (string[]) null);
        ++num1;
      }
      while (num1 <= 100);
      int num2 = 1;
      do
      {
        NewLateBinding.LateIndexSet((object) instance1, new object[2]
        {
          (object) num2,
          Operators.AddObject(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) 1
          }, (string[]) null), Operators.DivideObject(Operators.MultiplyObject((object) (num2 - 1), Operators.SubtractObject(NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) this.calc.NK
          }, (string[]) null), NewLateBinding.LateIndexGet((object) this.calc.X, new object[1]
          {
            (object) 1
          }, (string[]) null))), (object) 99))
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) instance3, new object[2]
        {
          (object) num2,
          (object) this.calc.GetValBySpline(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) instance1, new object[1]
          {
            (object) num2
          }, (string[]) null)))
        }, (string[]) null);
        ++num2;
      }
      while (num2 <= 100);
      this.ut.MyDrawFigure2(ref instance1, ref instance2, ref instance3, ref this.g, MyProject.Forms.Plot.PictureBox1.Width, MyProject.Forms.Plot.PictureBox1.Height);
      this.g.Dispose();
      MyProject.Forms.Plot.Text = "График решения";
      MyProject.Forms.Plot.HelpProvider1.SetHelpString((Control) MyProject.Forms.Plot.PictureBox1, "Синим цветом показано приближение интерполяционным полиномом. Красным цветом показано приближение сплайнами.");
      int num3 = (int) MyProject.Forms.Plot.ShowDialog((IWin32Window) this);
    }

    private void InitTaskData()
    {
      int num1;
      double[] numArray1;
      double[] numArray2;
      double[] numArray3;
      double[] numArray4;
      switch (this.varNo)
      {
        case 1:
          num1 = 7;
          MyUtils ut1 = this.ut;
          Array array1 = (Array) numArray1;
          ref Array local1 = ref array1;
          ut1.FillArray(ref local1, 0.17453, 0.5236, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893);
          numArray2 = (double[]) array1;
          MyUtils ut2 = this.ut;
          Array array2 = (Array) numArray3;
          ref Array local2 = ref array2;
          ut2.FillArray(ref local2, 0.00162, 0.00252, 0.00498, 0.0129, 0.03964, 0.1207, 0.34097);
          numArray4 = (double[]) array2;
          break;
        case 2:
          num1 = 7;
          MyUtils ut3 = this.ut;
          Array array3 = (Array) numArray1;
          ref Array local3 = ref array3;
          ut3.FillArray(ref local3, 0.17453, 0.5236, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893);
          numArray2 = (double[]) array3;
          MyUtils ut4 = this.ut;
          Array array4 = (Array) numArray3;
          ref Array local4 = ref array4;
          ut4.FillArray(ref local4, 0.00025, 0.00116, 0.00361, 0.01162, 0.03827, 0.11933, 0.3396);
          numArray4 = (double[]) array4;
          break;
        case 3:
          num1 = 6;
          MyUtils ut5 = this.ut;
          Array array5 = (Array) numArray1;
          ref Array local5 = ref array5;
          ut5.FillArray(ref local5, 0.17453, 0.5236, 0.87267, 1.22173, 1.5708, 1.91986);
          numArray2 = (double[]) array5;
          MyUtils ut6 = this.ut;
          Array array6 = (Array) numArray3;
          ref Array local6 = ref array6;
          ut6.FillArray(ref local6, 3.8E-05, 0.00052, 0.00254, 0.01013, 0.03636, 0.11699);
          numArray4 = (double[]) array6;
          break;
        case 4:
          num1 = 5;
          MyUtils ut7 = this.ut;
          Array array7 = (Array) numArray1;
          ref Array local7 = ref array7;
          ut7.FillArray(ref local7, 0.17453, 0.5236, 0.87267, 1.22173, 1.5708);
          numArray2 = (double[]) array7;
          MyUtils ut8 = this.ut;
          Array array8 = (Array) numArray3;
          ref Array local8 = ref array8;
          ut8.FillArray(ref local8, 6E-06, 0.00023, 0.00173, 0.00854, 0.03373);
          numArray4 = (double[]) array8;
          break;
        case 5:
          num1 = 7;
          MyUtils ut9 = this.ut;
          Array array9 = (Array) numArray1;
          ref Array local9 = ref array9;
          ut9.FillArray(ref local9, 0.5236, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893, 2.61799);
          numArray2 = (double[]) array9;
          MyUtils ut10 = this.ut;
          Array array10 = (Array) numArray3;
          ref Array local10 = ref array10;
          ut10.FillArray(ref local10, 0.0001, 0.00112, 0.00687, 0.03018, 0.10659, 0.3207, 0.85128);
          numArray4 = (double[]) array10;
          break;
        case 6:
          num1 = 7;
          MyUtils ut11 = this.ut;
          Array array11 = (Array) numArray1;
          ref Array local11 = ref array11;
          ut11.FillArray(ref local11, 0.5236, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893, 2.61799);
          numArray2 = (double[]) array11;
          MyUtils ut12 = this.ut;
          Array array12 = (Array) numArray3;
          ref Array local12 = ref array12;
          ut12.FillArray(ref local12, 4E-05, 0.00068, 0.00518, 0.02554, 0.09624, 0.30046, 0.81548);
          numArray4 = (double[]) array12;
          break;
        case 7:
          num1 = 6;
          MyUtils ut13 = this.ut;
          Array array13 = (Array) numArray1;
          ref Array local13 = ref array13;
          ut13.FillArray(ref local13, 0.5236, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893);
          numArray2 = (double[]) array13;
          MyUtils ut14 = this.ut;
          Array array14 = (Array) numArray3;
          ref Array local14 = ref array14;
          ut14.FillArray(ref local14, 1.4E-05, 0.00037, 0.00352, 0.01971, 0.08033, 0.2638);
          numArray4 = (double[]) array14;
          break;
        case 8:
          num1 = 5;
          MyUtils ut15 = this.ut;
          Array array15 = (Array) numArray1;
          ref Array local15 = ref array15;
          ut15.FillArray(ref local15, 0.5236, 0.87267, 1.22173, 1.5708, 1.91986);
          numArray2 = (double[]) array15;
          MyUtils ut16 = this.ut;
          Array array16 = (Array) numArray3;
          ref Array local16 = ref array16;
          ut16.FillArray(ref local16, 0.0, 0.00017, 0.00199, 0.01282, 0.05744);
          numArray4 = (double[]) array16;
          break;
        case 9:
          num1 = 7;
          MyUtils ut17 = this.ut;
          Array array17 = (Array) numArray1;
          ref Array local17 = ref array17;
          ut17.FillArray(ref local17, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893, 2.61799, 2.967);
          numArray2 = (double[]) array17;
          MyUtils ut18 = this.ut;
          Array array18 = (Array) numArray3;
          ref Array local18 = ref array18;
          ut18.FillArray(ref local18, 0.00082, 0.01039, 0.07037, 0.32762, 1.18669, 3.59003, 9.4835);
          numArray4 = (double[]) array18;
          break;
        case 10:
          num1 = 7;
          MyUtils ut19 = this.ut;
          Array array19 = (Array) numArray1;
          ref Array local19 = ref array19;
          ut19.FillArray(ref local19, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893, 2.61799, 2.96706);
          numArray2 = (double[]) array19;
          MyUtils ut20 = this.ut;
          Array array20 = (Array) numArray3;
          ref Array local20 = ref array20;
          ut20.FillArray(ref local20, 0.00123, 0.01343, 0.08411, 0.37341, 1.31146, 3.88447, 10.10742);
          numArray4 = (double[]) array20;
          break;
        case 11:
          num1 = 6;
          MyUtils ut21 = this.ut;
          Array array21 = (Array) numArray1;
          ref Array local21 = ref array21;
          ut21.FillArray(ref local21, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893, 2.61799);
          numArray2 = (double[]) array21;
          MyUtils ut22 = this.ut;
          Array array22 = (Array) numArray3;
          ref Array local22 = ref array22;
          ut22.FillArray(ref local22, 0.00161, 0.0155, 0.09139, 0.39329, 1.35729, 3.97819);
          numArray4 = (double[]) array22;
          break;
        case 12:
          num1 = 5;
          MyUtils ut23 = this.ut;
          Array array23 = (Array) numArray1;
          ref Array local23 = ref array23;
          ut23.FillArray(ref local23, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893);
          numArray2 = (double[]) array23;
          MyUtils ut24 = this.ut;
          Array array24 = (Array) numArray3;
          ref Array local24 = ref array24;
          ut24.FillArray(ref local24, 0.00196, 0.01686, 0.09511, 0.40157, 1.37344);
          numArray4 = (double[]) array24;
          break;
        case 13:
          num1 = 7;
          MyUtils ut25 = this.ut;
          Array array25 = (Array) numArray1;
          ref Array local25 = ref array25;
          ut25.FillArray(ref local25, 0.17453, 0.5236, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893);
          numArray2 = (double[]) array25;
          MyUtils ut26 = this.ut;
          Array array26 = (Array) numArray3;
          ref Array local26 = ref array26;
          ut26.FillArray(ref local26, 3E-06, 0.00018, 0.00227, 0.0177, 0.09688, 0.40481, 1.37878);
          numArray4 = (double[]) array26;
          break;
        case 14:
          num1 = 7;
          MyUtils ut27 = this.ut;
          Array array27 = (Array) numArray1;
          ref Array local27 = ref array27;
          ut27.FillArray(ref local27, 0.17453, 0.5236, 0.87267, 1.22173, 1.5708, 1.91986, 2.26893);
          numArray2 = (double[]) array27;
          MyUtils ut28 = this.ut;
          Array array28 = (Array) numArray3;
          ref Array local28 = ref array28;
          ut28.FillArray(ref local28, 1.2E-05, 0.00026, 1.0 / 400.0, 0.01815, 0.09763, 0.40593, 1.38035);
          numArray4 = (double[]) array28;
          break;
        case 15:
          num1 = 6;
          MyUtils ut29 = this.ut;
          Array array29 = (Array) numArray1;
          ref Array local29 = ref array29;
          ut29.FillArray(ref local29, 1.22173, 1.5708, 1.91986, 2.26893, 2.61799, 2.96706);
          numArray2 = (double[]) array29;
          MyUtils ut30 = this.ut;
          Array array30 = (Array) numArray3;
          ref Array local30 = ref array30;
          ut30.FillArray(ref local30, 0.01834, 0.09787, 0.40623, 1.3807, 4.01752, 10.345);
          numArray4 = (double[]) array30;
          break;
        case 16:
          num1 = 5;
          MyUtils ut31 = this.ut;
          Array array31 = (Array) numArray1;
          ref Array local31 = ref array31;
          ut31.FillArray(ref local31, 1.22173, 1.5708, 1.91986, 2.26893, 2.61799);
          numArray2 = (double[]) array31;
          MyUtils ut32 = this.ut;
          Array array32 = (Array) numArray3;
          ref Array local32 = ref array32;
          ut32.FillArray(ref local32, 0.01849, 0.09802, 0.40638, 1.38085, 4.01768);
          numArray4 = (double[]) array32;
          break;
      }
      int num2 = num1 - 1;
      for (int index = 0; index <= num2; ++index)
      {
        this.Uslovie.Columns.Add("", -2, HorizontalAlignment.Left);
        this.itemX.SubItems.Add(this.ut.MyDblToStr(numArray2[index]) + " ");
        this.itemY.SubItems.Add(this.ut.MyDblToStr(numArray4[index]) + " ");
        NewLateBinding.LateIndexSet((object) this.calc.X, new object[2]
        {
          (object) (index + 1),
          (object) numArray2[index]
        }, (string[]) null);
        NewLateBinding.LateIndexSet((object) this.calc.F, new object[3]
        {
          (object) 1,
          (object) (index + 1),
          (object) numArray4[index]
        }, (string[]) null);
      }
      this.calc.NK = num1;
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
      this.ClearAllData();
    }

    private void btnCalcY_Click(object sender, EventArgs e)
    {
      this.CalculateY();
    }

    private void Xin_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Return)
        this.CalculateY();
      else
        this.ut.MyCheckNumKeyDown(ref e);
    }

    private void CalculateY()
    {
      bool bres = false;
      MyUtils ut = this.ut;
      TextBox xin = this.Xin;
      ref TextBox local = ref xin;
      int num = ut.MyCheckNumValue(ref local) ? 1 : 0;
      this.Xin = xin;
      if (num == 0)
        return;
      double Sval;
      int Snum;
      double Fval;
      this.calc.CalculateY(this.ut.MyStrToDbl(this.Xin.Text), ref Sval, ref Snum, ref Fval, ref bres);
      if (bres)
      {
        this.Sout.Text = "S" + Conversions.ToString(Snum) + "(X) = " + this.ut.MyDblToStr(Sval);
        this.Fout.Text = "P(X) = " + this.ut.MyDblToStr(Fval);
      }
      else
      {
        this.Sout.Text = "Ошибка!";
        this.Fout.Text = "Ошибка!";
      }
      this.Sout.Visible = true;
      this.Fout.Visible = true;
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void MainFormLab2_Load(object sender, EventArgs e)
    {
      MyProject.Forms.Plot.HelpProvider1.SetHelpString((Control) MyProject.Forms.Plot.PictureBox1, "Синим цветом показаны значения, вычисленные с помощью интерполяционного полинома.Красным цветом показаны значения, вычисленные с помощью сплайнов.");
    }

    private void Varianty_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.BtnStart.PerformClick();
    }

    private void MainFormLab2_FormClosed(object sender, FormClosedEventArgs e)
    {
      MyProject.Forms.Proverka.Show();
    }
  }
}
