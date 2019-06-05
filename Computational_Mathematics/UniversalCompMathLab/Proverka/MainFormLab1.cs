// Decompiled with JetBrains decompiler
// Type: Proverka.MainFormLab1
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
  public class MainFormLab1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Koeff")]
    private ListBox _Koeff;
    [AccessedThroughProperty("Otrezki")]
    private ListBox _Otrezki;
    [AccessedThroughProperty("Korni")]
    private ListBox _Korni;
    [AccessedThroughProperty("Uslovie")]
    private ListBox _Uslovie;
    [AccessedThroughProperty("VariantNum")]
    private NumericUpDown _VariantNum;
    [AccessedThroughProperty("ZadachaNum")]
    private NumericUpDown _ZadachaNum;
    [AccessedThroughProperty("BtnStart")]
    private Button _BtnStart;
    [AccessedThroughProperty("ClearAllBtn")]
    private Button _ClearAllBtn;
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
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("TabOtveti")]
    private TabControl _TabOtveti;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("BtnExit")]
    private Button _BtnExit;
    private MyUtils ut;
    private NumericLab1 calc;
    private byte istage;
    private StreamReader fileReader;
    private string strReader;
    public int varNo;
    public int taskNo;
    private Array ParamName;
    private Array ParamNameRes;
    private Array RazmerName;
    private Array RazmerNameRes;

    public MainFormLab1()
    {
      this.FormClosed += new FormClosedEventHandler(this.MainFormLab1_FormClosed);
      this.ut = new MyUtils();
      this.calc = new NumericLab1();
      this.ParamName = Array.CreateInstance(typeof (string), 11);
      this.ParamNameRes = Array.CreateInstance(typeof (string), 13);
      this.RazmerName = Array.CreateInstance(typeof (string), 11);
      this.RazmerNameRes = Array.CreateInstance(typeof (string), 13);
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
      this.Koeff = new ListBox();
      this.Otrezki = new ListBox();
      this.Korni = new ListBox();
      this.Uslovie = new ListBox();
      this.VariantNum = new NumericUpDown();
      this.ZadachaNum = new NumericUpDown();
      this.BtnStart = new Button();
      this.ClearAllBtn = new Button();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.GroupBox1 = new GroupBox();
      this.TabOtveti = new TabControl();
      this.Panel1 = new Panel();
      this.BtnExit = new Button();
      this.VariantNum.BeginInit();
      this.ZadachaNum.BeginInit();
      this.GroupBox1.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.Koeff.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Koeff.FormattingEnabled = true;
      this.Koeff.ItemHeight = 20;
      ListBox koeff1 = this.Koeff;
      Point point1 = new Point(12, 31);
      Point point2 = point1;
      koeff1.Location = point2;
      this.Koeff.Name = "Koeff";
      ListBox koeff2 = this.Koeff;
      Size size1 = new Size(345, 144);
      Size size2 = size1;
      koeff2.Size = size2;
      this.Koeff.TabIndex = 5;
      this.Otrezki.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Otrezki.FormattingEnabled = true;
      this.Otrezki.ItemHeight = 20;
      ListBox otrezki1 = this.Otrezki;
      point1 = new Point(12, 217);
      Point point3 = point1;
      otrezki1.Location = point3;
      this.Otrezki.Name = "Otrezki";
      ListBox otrezki2 = this.Otrezki;
      size1 = new Size(345, 104);
      Size size3 = size1;
      otrezki2.Size = size3;
      this.Otrezki.TabIndex = 6;
      this.Korni.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Korni.FormattingEnabled = true;
      this.Korni.ItemHeight = 20;
      ListBox korni1 = this.Korni;
      point1 = new Point(12, 357);
      Point point4 = point1;
      korni1.Location = point4;
      this.Korni.Name = "Korni";
      ListBox korni2 = this.Korni;
      size1 = new Size(345, 84);
      Size size4 = size1;
      korni2.Size = size4;
      this.Korni.TabIndex = 7;
      this.Uslovie.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.Uslovie.FormattingEnabled = true;
      this.Uslovie.ItemHeight = 20;
      ListBox uslovie1 = this.Uslovie;
      point1 = new Point(4, 24);
      Point point5 = point1;
      uslovie1.Location = point5;
      this.Uslovie.Name = "Uslovie";
      ListBox uslovie2 = this.Uslovie;
      size1 = new Size(238, 244);
      Size size5 = size1;
      uslovie2.Size = size5;
      this.Uslovie.TabIndex = 4;
      this.VariantNum.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown variantNum1 = this.VariantNum;
      point1 = new Point(28, 300);
      Point point6 = point1;
      variantNum1.Location = point6;
      NumericUpDown variantNum2 = this.VariantNum;
      Decimal num1 = new Decimal(new int[4]
      {
        4,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      variantNum2.Maximum = num2;
      NumericUpDown variantNum3 = this.VariantNum;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num3 = num1;
      variantNum3.Minimum = num3;
      this.VariantNum.Name = "VariantNum";
      NumericUpDown variantNum4 = this.VariantNum;
      size1 = new Size(73, 26);
      Size size6 = size1;
      variantNum4.Size = size6;
      this.VariantNum.TabIndex = 0;
      NumericUpDown variantNum5 = this.VariantNum;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num4 = num1;
      variantNum5.Value = num4;
      this.ZadachaNum.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      NumericUpDown zadachaNum1 = this.ZadachaNum;
      point1 = new Point(160, 300);
      Point point7 = point1;
      zadachaNum1.Location = point7;
      NumericUpDown zadachaNum2 = this.ZadachaNum;
      num1 = new Decimal(new int[4]{ 8, 0, 0, 0 });
      Decimal num5 = num1;
      zadachaNum2.Maximum = num5;
      NumericUpDown zadachaNum3 = this.ZadachaNum;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num6 = num1;
      zadachaNum3.Minimum = num6;
      this.ZadachaNum.Name = "ZadachaNum";
      NumericUpDown zadachaNum4 = this.ZadachaNum;
      size1 = new Size(73, 26);
      Size size7 = size1;
      zadachaNum4.Size = size7;
      this.ZadachaNum.TabIndex = 1;
      NumericUpDown zadachaNum5 = this.ZadachaNum;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num7 = num1;
      zadachaNum5.Value = num7;
      this.BtnStart.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnStart1 = this.BtnStart;
      point1 = new Point(27, 331);
      Point point8 = point1;
      btnStart1.Location = point8;
      this.BtnStart.Name = "BtnStart";
      Button btnStart2 = this.BtnStart;
      size1 = new Size(205, 29);
      Size size8 = size1;
      btnStart2.Size = size8;
      this.BtnStart.TabIndex = 2;
      this.BtnStart.Text = "СТАРТ";
      this.BtnStart.UseVisualStyleBackColor = true;
      this.ClearAllBtn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button clearAllBtn1 = this.ClearAllBtn;
      point1 = new Point(27, 364);
      Point point9 = point1;
      clearAllBtn1.Location = point9;
      this.ClearAllBtn.Name = "ClearAllBtn";
      Button clearAllBtn2 = this.ClearAllBtn;
      size1 = new Size(205, 29);
      Size size9 = size1;
      clearAllBtn2.Size = size9;
      this.ClearAllBtn.TabIndex = 3;
      this.ClearAllBtn.Text = "ОЧИСТИТЬ";
      this.ClearAllBtn.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label1_1 = this.Label1;
      point1 = new Point(12, 7);
      Point point10 = point1;
      label1_1.Location = point10;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(252, 20);
      Size size10 = size1;
      label1_2.Size = size10;
      this.Label1.TabIndex = 9;
      this.Label1.Text = "1. Коэффициенты полинома";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label2_1 = this.Label2;
      point1 = new Point(12, 191);
      Point point11 = point1;
      label2_1.Location = point11;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(215, 20);
      Size size11 = size1;
      label2_2.Size = size11;
      this.Label2.TabIndex = 10;
      this.Label2.Text = "2. Отрезки локализации";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label3_1 = this.Label3;
      point1 = new Point(12, 332);
      Point point12 = point1;
      label3_1.Location = point12;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(80, 20);
      Size size12 = size1;
      label3_2.Size = size12;
      this.Label3.TabIndex = 11;
      this.Label3.Text = "3. Корни";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label4_1 = this.Label4;
      point1 = new Point(31, 1);
      Point point13 = point1;
      label4_1.Location = point13;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(172, 20);
      Size size13 = size1;
      label4_2.Size = size13;
      this.Label4.TabIndex = 12;
      this.Label4.Text = "Параметры задачи";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label5_1 = this.Label5;
      point1 = new Point(24, 277);
      Point point14 = point1;
      label5_1.Location = point14;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(81, 20);
      Size size14 = size1;
      label5_2.Size = size14;
      this.Label5.TabIndex = 13;
      this.Label5.Text = "Вариант";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Label label6_1 = this.Label6;
      point1 = new Point(156, 277);
      Point point15 = point1;
      label6_1.Location = point15;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(73, 20);
      Size size15 = size1;
      label6_2.Size = size15;
      this.Label6.TabIndex = 14;
      this.Label6.Text = "Задача";
      this.GroupBox1.Controls.Add((Control) this.TabOtveti);
      this.GroupBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(363, 12);
      Point point16 = point1;
      groupBox1_1.Location = point16;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(298, 430);
      Size size16 = size1;
      groupBox1_2.Size = size16;
      this.GroupBox1.TabIndex = 15;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "4. Ответ";
      this.TabOtveti.Appearance = TabAppearance.FlatButtons;
      this.TabOtveti.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      TabControl tabOtveti1 = this.TabOtveti;
      point1 = new Point(6, 19);
      Point point17 = point1;
      tabOtveti1.Location = point17;
      this.TabOtveti.Name = "TabOtveti";
      this.TabOtveti.SelectedIndex = 0;
      TabControl tabOtveti2 = this.TabOtveti;
      size1 = new Size(286, 396);
      Size size17 = size1;
      tabOtveti2.Size = size17;
      this.TabOtveti.TabIndex = 8;
      this.Panel1.BorderStyle = BorderStyle.Fixed3D;
      this.Panel1.Controls.Add((Control) this.BtnExit);
      this.Panel1.Controls.Add((Control) this.Label5);
      this.Panel1.Controls.Add((Control) this.VariantNum);
      this.Panel1.Controls.Add((Control) this.BtnStart);
      this.Panel1.Controls.Add((Control) this.ZadachaNum);
      this.Panel1.Controls.Add((Control) this.ClearAllBtn);
      this.Panel1.Controls.Add((Control) this.Label6);
      this.Panel1.Controls.Add((Control) this.Label4);
      this.Panel1.Controls.Add((Control) this.Uslovie);
      Panel panel1_1 = this.Panel1;
      point1 = new Point(677, 12);
      Point point18 = point1;
      panel1_1.Location = point18;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(250, 430);
      Size size18 = size1;
      panel1_2.Size = size18;
      this.Panel1.TabIndex = 17;
      this.BtnExit.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnExit1 = this.BtnExit;
      point1 = new Point(27, 397);
      Point point19 = point1;
      btnExit1.Location = point19;
      this.BtnExit.Name = "BtnExit";
      Button btnExit2 = this.BtnExit;
      size1 = new Size(205, 29);
      Size size19 = size1;
      btnExit2.Size = size19;
      this.BtnExit.TabIndex = 15;
      this.BtnExit.Text = "ВЫХОД";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      size1 = new Size(936, 452);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Korni);
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.Otrezki);
      this.Controls.Add((Control) this.Koeff);
      this.Controls.Add((Control) this.Label1);
      this.MinimizeBox = false;
      this.Name = nameof (MainFormLab1);
      this.ShowIcon = false;
      this.Text = "ПРОВЕРКА ЛАБОРАТОРНОЙ РАБОТЫ №1";
      this.VariantNum.EndInit();
      this.ZadachaNum.EndInit();
      this.GroupBox1.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual ListBox Koeff
    {
      get
      {
        return this._Koeff;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Koeff = value;
      }
    }

    internal virtual ListBox Otrezki
    {
      get
      {
        return this._Otrezki;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Otrezki = value;
      }
    }

    internal virtual ListBox Korni
    {
      get
      {
        return this._Korni;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Korni = value;
      }
    }

    internal virtual ListBox Uslovie
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

    internal virtual NumericUpDown VariantNum
    {
      get
      {
        return this._VariantNum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._VariantNum != null)
          this._VariantNum.KeyDown -= new KeyEventHandler(this.VariantNum_KeyDown);
        this._VariantNum = value;
        if (this._VariantNum == null)
          return;
        this._VariantNum.KeyDown += new KeyEventHandler(this.VariantNum_KeyDown);
      }
    }

    internal virtual NumericUpDown ZadachaNum
    {
      get
      {
        return this._ZadachaNum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ZadachaNum != null)
          this._ZadachaNum.KeyDown -= new KeyEventHandler(this.ZadachaNum_KeyDown);
        this._ZadachaNum = value;
        if (this._ZadachaNum == null)
          return;
        this._ZadachaNum.KeyDown += new KeyEventHandler(this.ZadachaNum_KeyDown);
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

    internal virtual Button ClearAllBtn
    {
      get
      {
        return this._ClearAllBtn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._ClearAllBtn != null)
          this._ClearAllBtn.Click -= new EventHandler(this.ClearAllBtn_Click);
        this._ClearAllBtn = value;
        if (this._ClearAllBtn == null)
          return;
        this._ClearAllBtn.Click += new EventHandler(this.ClearAllBtn_Click);
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

    internal virtual Label Label6
    {
      get
      {
        return this._Label6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label6 = value;
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

    internal virtual TabControl TabOtveti
    {
      get
      {
        return this._TabOtveti;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TabOtveti = value;
      }
    }

    internal virtual Panel Panel1
    {
      get
      {
        return this._Panel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel1 = value;
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
      switch (this.istage)
      {
        case 0:
          this.BtnStart.Text = "КОЭФФИЦИЕНТЫ";
          this.varNo = int.Parse(Conversions.ToString(this.VariantNum.Value));
          this.taskNo = int.Parse(Conversions.ToString(this.ZadachaNum.Value));
          this.LoadUslovie();
          this.Uslovie.Visible = true;
          ++this.istage;
          this.VariantNum.Enabled = false;
          this.VariantNum.BackColor = Color.White;
          this.ZadachaNum.Enabled = false;
          this.ZadachaNum.BackColor = Color.White;
          break;
        case 1:
          this.BtnStart.Text = "ОТРЕЗКИ";
          MyUtils ut1 = this.ut;
          Form form1 = (Form) this;
          ref Form local1 = ref form1;
          ut1.SetWaitCursor(ref local1);
          NumericLab1 calc = this.calc;
          MainFormLab1 mainFormLab1 = this;
          ref MainFormLab1 local2 = ref mainFormLab1;
          calc.Calculate(ref local2);
          MyUtils ut2 = this.ut;
          Form form2 = (Form) this;
          ref Form local3 = ref form2;
          ut2.RestoreCursor(ref local3);
          this.LoadKoeff();
          this.Koeff.Visible = true;
          ++this.istage;
          break;
        case 2:
          this.BtnStart.Text = "КОРНИ";
          this.LoadOtrezki();
          this.Otrezki.Visible = true;
          ++this.istage;
          break;
        case 3:
          this.BtnStart.Text = "ОТВЕТ";
          this.LoadKorni();
          this.Korni.Visible = true;
          ++this.istage;
          break;
        case 4:
          this.BtnStart.Text = "ЗАНОВО";
          this.TabOtveti.Visible = true;
          this.LoadOtvet();
          this.VariantNum.Enabled = true;
          this.ZadachaNum.Enabled = true;
          ++this.istage;
          break;
        default:
          this.ClearAllData();
          break;
      }
    }

    private void ClearAllBtn_Click(object sender, EventArgs e)
    {
      this.ClearAllData();
    }

    private void LoadUslovie()
    {
      this.InitParamNames();
      this.InitTaskData();
    }

    private void LoadKoeff()
    {
      int num = 1;
      do
      {
        this.Koeff.Items.Add((object) ("a" + (num - 1).ToString() + " = " + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.Z, new object[1]
        {
          (object) num
        }, (string[]) null)))));
        ++num;
      }
      while (num <= 7);
    }

    private void LoadOtrezki()
    {
      int nk = this.calc.NK;
      for (int index = 1; index <= nk; ++index)
        this.Otrezki.Items.Add((object) ("[ " + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.V, new object[2]
        {
          (object) 1,
          (object) index
        }, (string[]) null))) + ", " + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.V, new object[2]
        {
          (object) 2,
          (object) index
        }, (string[]) null))) + " ]"));
    }

    private void LoadKorni()
    {
      int nk = this.calc.NK;
      for (int index = 1; index <= nk; ++index)
        this.Korni.Items.Add((object) ("x" + index.ToString() + " = " + this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.roots, new object[1]
        {
          (object) index
        }, (string[]) null)))));
    }

    private void LoadOtvet()
    {
      int num1 = 12;
      this.InitParamNames();
      int nk = this.calc.NK;
      for (int index = 1; index <= nk; ++index)
      {
        ListBox listBox = new ListBox();
        TabPage tabPage = new TabPage(Conversions.ToString(index));
        int num2 = num1;
        for (int paramNo = 1; paramNo <= num2; ++paramNo)
        {
          if (!(this.varNo == 2 & paramNo == 10))
            listBox.Items.Add((object) this.ParamNamesRes(paramNo, this.ut.MyDblToStr(Conversions.ToDouble(NewLateBinding.LateIndexGet((object) this.calc.solution, new object[2]
            {
              (object) index,
              (object) paramNo
            }, (string[]) null)))));
        }
        this.TabOtveti.Controls.Add((Control) tabPage);
        tabPage.Controls.Add((Control) listBox);
        listBox.Width = tabPage.Width;
        listBox.Height = tabPage.Height;
      }
    }

    public string ParamNames(int paramNo, string txt)
    {
      return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object) this.ParamName, new object[1]
      {
        (object) paramNo
      }, (string[]) null), (object) " = "), (object) txt), (object) " "), NewLateBinding.LateIndexGet((object) this.RazmerName, new object[1]
      {
        (object) paramNo
      }, (string[]) null)));
    }

    public string ParamNamesRes(int paramNo, string txt)
    {
      return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object) this.ParamNameRes, new object[1]
      {
        (object) paramNo
      }, (string[]) null), (object) " = "), (object) txt), (object) " "), NewLateBinding.LateIndexGet((object) this.RazmerNameRes, new object[1]
      {
        (object) paramNo
      }, (string[]) null)));
    }

    private void InitParamNames()
    {
      this.ParamName.SetValue((object) "G0", 1);
      this.ParamName.SetValue((object) "Ro0", 2);
      this.ParamName.SetValue((object) "U0", 3);
      this.ParamName.SetValue((object) "P0", 4);
      this.ParamName.SetValue((object) "G3", 5);
      this.ParamName.SetValue((object) "Ro3", 6);
      this.ParamName.SetValue((object) "U3", 7);
      this.ParamName.SetValue((object) "P3", 8);
      switch (this.varNo)
      {
        case 1:
          this.ParamNameRes.SetValue((object) "P2", 1);
          this.ParamNameRes.SetValue((object) "Ro2", 2);
          this.ParamNameRes.SetValue((object) "U2", 3);
          this.ParamNameRes.SetValue((object) "C2", 4);
          this.ParamNameRes.SetValue((object) "P3", 5);
          this.ParamNameRes.SetValue((object) "Ro3", 6);
          this.ParamNameRes.SetValue((object) "U3", 7);
          this.ParamNameRes.SetValue((object) "C3", 8);
          break;
        case 2:
          this.ParamNameRes.SetValue((object) "P3", 1);
          this.ParamNameRes.SetValue((object) "Ro3", 2);
          this.ParamNameRes.SetValue((object) "U3", 3);
          this.ParamNameRes.SetValue((object) "C3", 4);
          this.ParamNameRes.SetValue((object) "P2", 5);
          this.ParamNameRes.SetValue((object) "Ro2", 6);
          this.ParamNameRes.SetValue((object) "U2", 7);
          this.ParamNameRes.SetValue((object) "C2", 8);
          break;
        case 3:
        case 4:
          this.ParamNameRes.SetValue((object) "P2", 1);
          this.ParamNameRes.SetValue((object) "Ro2", 2);
          this.ParamNameRes.SetValue((object) "U2", 3);
          this.ParamNameRes.SetValue((object) "C2", 4);
          this.ParamNameRes.SetValue((object) "P1", 5);
          this.ParamNameRes.SetValue((object) "Ro1", 6);
          this.ParamNameRes.SetValue((object) "U1", 7);
          this.ParamNameRes.SetValue((object) "C1", 8);
          break;
      }
      this.ParamNameRes.SetValue((object) "D0", 9);
      this.ParamNameRes.SetValue((object) "D1", 10);
      this.ParamNameRes.SetValue((object) "Z0", 11);
      this.ParamNameRes.SetValue((object) "Z1", 12);
      this.RazmerName.SetValue((object) "", 1);
      this.RazmerName.SetValue((object) "г/см^3", 2);
      this.RazmerName.SetValue((object) "см/c", 3);
      this.RazmerName.SetValue((object) "дин/см^2", 4);
      this.RazmerName.SetValue((object) "", 5);
      this.RazmerName.SetValue((object) "г/см^3", 6);
      this.RazmerName.SetValue((object) "см/c", 7);
      this.RazmerName.SetValue((object) "дин/см^2", 8);
      this.RazmerNameRes.SetValue((object) "дин/см^2", 1);
      this.RazmerNameRes.SetValue((object) "г/см^3", 2);
      this.RazmerNameRes.SetValue((object) "см/c", 3);
      this.RazmerNameRes.SetValue((object) "см/c", 4);
      this.RazmerNameRes.SetValue((object) "дин/см^2", 5);
      this.RazmerNameRes.SetValue((object) "г/см^3", 6);
      this.RazmerNameRes.SetValue((object) "см/c", 7);
      this.RazmerNameRes.SetValue((object) "см/c", 8);
      this.RazmerNameRes.SetValue((object) "см/c", 9);
      this.RazmerNameRes.SetValue((object) "см/c", 10);
      this.RazmerNameRes.SetValue((object) "", 11);
      this.RazmerNameRes.SetValue((object) "", 12);
      if (this.varNo == 2)
      {
        this.ParamName.SetValue((object) "P0", 3);
        this.ParamName.SetValue((object) "U0", 4);
        this.ParamName.SetValue((object) "C3", 6);
        this.ParamName.SetValue((object) "P3", 7);
        this.ParamName.SetValue((object) "U3", 8);
        this.RazmerName.SetValue((object) "дин/см^2", 3);
        this.RazmerName.SetValue((object) "см/c", 4);
        this.RazmerName.SetValue((object) "см/c", 6);
        this.RazmerName.SetValue((object) "дин/см^2", 7);
        this.RazmerName.SetValue((object) "см/c", 8);
      }
      if (this.varNo <= 2)
        return;
      this.ParamName.SetValue((object) "C0", 5);
      this.ParamName.SetValue((object) "G3", 6);
      this.ParamName.SetValue((object) "Ro3", 7);
      this.ParamName.SetValue((object) "U3", 8);
      this.ParamName.SetValue((object) "P3", 9);
      this.ParamName.SetValue((object) "C3", 10);
      this.RazmerName.SetValue((object) "см/с", 5);
      this.RazmerName.SetValue((object) "", 6);
      this.RazmerName.SetValue((object) "г/см^3", 7);
      this.RazmerName.SetValue((object) "см/c", 8);
      this.RazmerName.SetValue((object) "дин/см^2", 9);
      this.RazmerName.SetValue((object) "см/с", 10);
    }

    private void ClearAllData()
    {
      this.istage = (byte) 0;
      this.BtnStart.Text = "СТАРТ";
      this.Uslovie.Visible = false;
      this.Koeff.Visible = false;
      this.Otrezki.Visible = false;
      this.Korni.Visible = false;
      this.TabOtveti.Visible = false;
      this.VariantNum.Enabled = true;
      this.ZadachaNum.Enabled = true;
      this.Uslovie.Items.Clear();
      this.Koeff.Items.Clear();
      this.Otrezki.Items.Clear();
      this.Korni.Items.Clear();
      this.TabOtveti.Controls.Clear();
    }

    private void InitTaskData()
    {
      int num1;
      double[] numArray1;
      double[] numArray2;
      switch (this.varNo)
      {
        case 1:
          num1 = 8;
          switch (this.taskNo)
          {
            case 1:
              MyUtils ut1 = this.ut;
              Array array1 = (Array) numArray1;
              ref Array local1 = ref array1;
              ut1.FillArray(ref local1, 1.66666667, 0.0002219, -158700.0, 3781200.0, 1.66666667, 0.00271, 10.0, 500000.0);
              numArray2 = (double[]) array1;
              break;
            case 2:
              MyUtils ut2 = this.ut;
              Array array2 = (Array) numArray1;
              ref Array local2 = ref array2;
              ut2.FillArray(ref local2, 1.66666667, 7.9, 0.0, 3040000000.0, 1.66666667, 11.37, 50000.0, 1179280000.0);
              numArray2 = (double[]) array2;
              break;
            case 3:
              MyUtils ut3 = this.ut;
              Array array3 = (Array) numArray1;
              ref Array local3 = ref array3;
              ut3.FillArray(ref local3, 1.66666667, 0.00271, 0.0, 500000.0, 1.4, 0.0002219, 158700.0, 1000000.0);
              numArray2 = (double[]) array3;
              break;
            case 4:
              MyUtils ut4 = this.ut;
              Array array4 = (Array) numArray1;
              ref Array local4 = ref array4;
              ut4.FillArray(ref local4, 1.66666667, 7.9, 0.0, 3040000000.0, 1.4, 11.37, 50000.0, 1179280000.0);
              numArray2 = (double[]) array4;
              break;
            case 5:
              MyUtils ut5 = this.ut;
              Array array5 = (Array) numArray1;
              ref Array local5 = ref array5;
              ut5.FillArray(ref local5, 1.4, 7.9, 0.0, 3040000000.0, 1.4, 11.37, 50000.0, 1179280000.0);
              numArray2 = (double[]) array5;
              break;
            case 6:
              MyUtils ut6 = this.ut;
              Array array6 = (Array) numArray1;
              ref Array local6 = ref array6;
              ut6.FillArray(ref local6, 1.66666667, 11.37, -22800.0, 1179280000.0, 1.66666667, 7.9, 27200.0, 3040000000.0);
              numArray2 = (double[]) array6;
              break;
            case 7:
              MyUtils ut7 = this.ut;
              Array array7 = (Array) numArray1;
              ref Array local7 = ref array7;
              ut7.FillArray(ref local7, 1.66666667, 7.9, -27200.0, 3040000000.0, 1.4, 11.37, 22800.0, 1179280000.0);
              numArray2 = (double[]) array7;
              break;
            case 8:
              MyUtils ut8 = this.ut;
              Array array8 = (Array) numArray1;
              ref Array local8 = ref array8;
              ut8.FillArray(ref local8, 1.4, 11.37, -22800.0, 1179280000.0, 1.4, 7.9, 27200.0, 3040000000.0);
              numArray2 = (double[]) array8;
              break;
          }
        case 2:
          num1 = 8;
          switch (this.taskNo)
          {
            case 1:
              MyUtils ut9 = this.ut;
              Array array9 = (Array) numArray1;
              ref Array local9 = ref array9;
              ut9.FillArray(ref local9, 1.66666667, 0.0001694, 1013000.0, 0.0, 1.4, 36537.0, 1676800.0, 0.0);
              numArray2 = (double[]) array9;
              break;
            case 2:
              MyUtils ut10 = this.ut;
              Array array10 = (Array) numArray1;
              ref Array local10 = ref array10;
              ut10.FillArray(ref local10, 1.66666667, 0.0001694, 1013000.0, 0.0, 1.4, 36537.0, 1676800.0, 12290.0);
              numArray2 = (double[]) array10;
              break;
            case 3:
              MyUtils ut11 = this.ut;
              Array array11 = (Array) numArray1;
              ref Array local11 = ref array11;
              ut11.FillArray(ref local11, 1.66666667, 1E-05, 3848.0, 0.0, 1.66666667, 13147.8, 1179280000.0, 50000.0);
              numArray2 = (double[]) array11;
              break;
            case 4:
              MyUtils ut12 = this.ut;
              Array array12 = (Array) numArray1;
              ref Array local12 = ref array12;
              ut12.FillArray(ref local12, 1.4, 0.0001694, 1013000.0, 0.001, 1.4, 36537.0, 1676800.0, 12290.0);
              numArray2 = (double[]) array12;
              break;
            case 5:
              MyUtils ut13 = this.ut;
              Array array13 = (Array) numArray1;
              ref Array local13 = ref array13;
              ut13.FillArray(ref local13, 1.4, 1E-05, 3848.0, 0.0, 1.66666667, 13147.8, 1179280000.0, 50000.0);
              numArray2 = (double[]) array13;
              break;
            case 6:
              MyUtils ut14 = this.ut;
              Array array14 = (Array) numArray1;
              ref Array local14 = ref array14;
              ut14.FillArray(ref local14, 1.66666667, 0.0001694, 1013000.0, -0.1, 1.66666667, 36537.0, 1676800.0, 0.0);
              numArray2 = (double[]) array14;
              break;
            case 7:
              MyUtils ut15 = this.ut;
              Array array15 = (Array) numArray1;
              ref Array local15 = ref array15;
              ut15.FillArray(ref local15, 1.66666667, 1E-05, 3848.0, 0.0, 1.66666667, 25324.8, 3040000000.0, 0.0);
              numArray2 = (double[]) array15;
              break;
            case 8:
              MyUtils ut16 = this.ut;
              Array array16 = (Array) numArray1;
              ref Array local16 = ref array16;
              ut16.FillArray(ref local16, 1.66666667, 1E-05, 3848.0, 0.0, 1.4, 25324.8, 3040000000.0, 0.0);
              numArray2 = (double[]) array16;
              break;
          }
        case 3:
          num1 = 10;
          switch (this.taskNo)
          {
            case 1:
              MyUtils ut17 = this.ut;
              Array array17 = (Array) numArray1;
              ref Array local17 = ref array17;
              ut17.FillArray(ref local17, 3.0, 13.76163, -532238.9, 5176613000000.0, 465000.0, 3.0, 100.0, 0.0, 0.0, 465000.0);
              numArray2 = (double[]) array17;
              break;
            case 2:
              MyUtils ut18 = this.ut;
              Array array18 = (Array) numArray1;
              ref Array local18 = ref array18;
              ut18.FillArray(ref local18, 3.0, 100.0, -1000000.0, 0.0, 197200.0, 3.0, 21.80089, -532238.9, 5176613000000.0, 197200.0);
              numArray2 = (double[]) array18;
              break;
            case 3:
              MyUtils ut19 = this.ut;
              Array array19 = (Array) numArray1;
              ref Array local19 = ref array19;
              ut19.FillArray(ref local19, 3.0, 13.76163, 0.0, 5176613000000.0, 465000.0, 3.0, 100.0, 532238.9, 0.0, 465000.0);
              numArray2 = (double[]) array19;
              break;
            case 4:
              MyUtils ut20 = this.ut;
              Array array20 = (Array) numArray1;
              ref Array local20 = ref array20;
              ut20.FillArray(ref local20, 3.0, 100.0, -467761.1, 0.0, 197200.0, 3.0, 21.80089, 0.0, 5176613000000.0, 197200.0);
              numArray2 = (double[]) array20;
              break;
            case 5:
              MyUtils ut21 = this.ut;
              Array array21 = (Array) numArray1;
              ref Array local21 = ref array21;
              ut21.FillArray(ref local21, 3.0, 100.0, 0.0, 0.0, 465000.0, 3.0, 13.76163, 532238.9, 5176613000000.0, 465000.0);
              numArray2 = (double[]) array21;
              break;
            case 6:
              MyUtils ut22 = this.ut;
              Array array22 = (Array) numArray1;
              ref Array local22 = ref array22;
              ut22.FillArray(ref local22, 3.0, 21.80089, 532238.9, 5176613000000.0, 197200.0, 3.0, 100.0, 1000000.0, 0.0, 197200.0);
              numArray2 = (double[]) array22;
              break;
            case 7:
              MyUtils ut23 = this.ut;
              Array array23 = (Array) numArray1;
              ref Array local23 = ref array23;
              ut23.FillArray(ref local23, 3.0, 100.0, -532238.9, 0.0, 465000.0, 3.0, 13.76163, 0.0, 5176613000000.0, 465000.0);
              numArray2 = (double[]) array23;
              break;
            case 8:
              MyUtils ut24 = this.ut;
              Array array24 = (Array) numArray1;
              ref Array local24 = ref array24;
              ut24.FillArray(ref local24, 3.0, 21.80089, 0.0, 5176613000000.0, 197200.0, 3.0, 100.0, 467761.1, 0.0, 197200.0);
              numArray2 = (double[]) array24;
              break;
          }
        case 4:
          num1 = 10;
          switch (this.taskNo)
          {
            case 1:
              MyUtils ut25 = this.ut;
              Array array25 = (Array) numArray1;
              ref Array local25 = ref array25;
              ut25.FillArray(ref local25, 3.0, 11.346, 1000000.0, 0.0, 197200.0, 3.0, 7.85, 0.0, 0.0, 465000.0);
              numArray2 = (double[]) array25;
              break;
            case 2:
              MyUtils ut26 = this.ut;
              Array array26 = (Array) numArray1;
              ref Array local26 = ref array26;
              ut26.FillArray(ref local26, 3.0, 11.346, -467761.1, 0.0, 197200.0, 3.0, 7.85, 532238.9, 0.0, 465000.0);
              numArray2 = (double[]) array26;
              break;
            case 3:
              MyUtils ut27 = this.ut;
              Array array27 = (Array) numArray1;
              ref Array local27 = ref array27;
              ut27.FillArray(ref local27, 3.0, 7.85, 0.0, 0.0, 465000.0, 3.0, 11.346, 1000000.0, 0.0, 197200.0);
              numArray2 = (double[]) array27;
              break;
            case 4:
              MyUtils ut28 = this.ut;
              Array array28 = (Array) numArray1;
              ref Array local28 = ref array28;
              ut28.FillArray(ref local28, 3.0, 7.85, -532238.9, 0.0, 465000.0, 3.0, 11.346, 467761.1, 0.0, 197200.0);
              numArray2 = (double[]) array28;
              break;
            case 5:
              MyUtils ut29 = this.ut;
              Array array29 = (Array) numArray1;
              ref Array local29 = ref array29;
              ut29.FillArray(ref local29, 3.0, 7.85, -1000000.0, 0.0, 465000.0, 3.0, 11.346, 0.0, 0.0, 197200.0);
              numArray2 = (double[]) array29;
              break;
            case 6:
              MyUtils ut30 = this.ut;
              Array array30 = (Array) numArray1;
              ref Array local30 = ref array30;
              ut30.FillArray(ref local30, 3.0, 11.346, 0.0, 0.0, 197200.0, 3.0, 7.85, 1000000.0, 0.0, 465000.0);
              numArray2 = (double[]) array30;
              break;
            case 7:
              MyUtils ut31 = this.ut;
              Array array31 = (Array) numArray1;
              ref Array local31 = ref array31;
              ut31.FillArray(ref local31, 3.0, 7.85, 532238.9, 0.0, 465000.0, 3.0, 11.346, -467761.1, 0.0, 197200.0);
              numArray2 = (double[]) array31;
              break;
            case 8:
              MyUtils ut32 = this.ut;
              Array array32 = (Array) numArray1;
              ref Array local32 = ref array32;
              ut32.FillArray(ref local32, 3.0, 11.346, 467761.1, 0.0, 1972.0, 3.0, 7.85, -532238.9, 0.0, 4650.0);
              numArray2 = (double[]) array32;
              break;
          }
      }
      int num2 = num1 - 1;
      for (int index = 0; index <= num2; ++index)
      {
        this.Uslovie.Items.Add((object) this.ParamNames(index + 1, this.ut.MyDblToStr(numArray2[index])));
        NumericLab1 calc = this.calc;
        int paramNo = index + 1;
        string str = this.ut.MyDblToStr(numArray2[index]);
        MainFormLab1 mainFormLab1 = this;
        ref MainFormLab1 local33 = ref mainFormLab1;
        calc.InitParam(paramNo, str, ref local33);
      }
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void VariantNum_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.BtnStart.PerformClick();
    }

    private void ZadachaNum_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue != 13)
        return;
      this.BtnStart.PerformClick();
    }

    private void MainFormLab1_FormClosed(object sender, FormClosedEventArgs e)
    {
      MyProject.Forms.Proverka.Show();
    }
  }
}
