// Decompiled with JetBrains decompiler
// Type: Proverka.Proverka
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
  public class Proverka : Form
  {
    private IContainer components;
    [AccessedThroughProperty("GoLab1Btn")]
    private Button _GoLab1Btn;
    [AccessedThroughProperty("GoLab2Btn")]
    private Button _GoLab2Btn;
    [AccessedThroughProperty("GoLab3Btn")]
    private Button _GoLab3Btn;
    [AccessedThroughProperty("GoLab4Btn")]
    private Button _GoLab4Btn;
    [AccessedThroughProperty("GoLab5Btn")]
    private Button _GoLab5Btn;
    [AccessedThroughProperty("GoLab6Btn")]
    private Button _GoLab6Btn;
    [AccessedThroughProperty("BtnExit")]
    private Button _BtnExit;

    public Proverka()
    {
      this.HandleCreated += new EventHandler(this.Proverka_Load);
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
      this.GoLab1Btn = new Button();
      this.GoLab2Btn = new Button();
      this.GoLab3Btn = new Button();
      this.GoLab4Btn = new Button();
      this.GoLab5Btn = new Button();
      this.GoLab6Btn = new Button();
      this.BtnExit = new Button();
      this.SuspendLayout();
      this.GoLab1Btn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button goLab1Btn1 = this.GoLab1Btn;
      Point point1 = new Point(16, 13);
      Point point2 = point1;
      goLab1Btn1.Location = point2;
      this.GoLab1Btn.Name = "GoLab1Btn";
      Button goLab1Btn2 = this.GoLab1Btn;
      Size size1 = new Size(172, 30);
      Size size2 = size1;
      goLab1Btn2.Size = size2;
      this.GoLab1Btn.TabIndex = 0;
      this.GoLab1Btn.Text = "РАБОТА №1";
      this.GoLab1Btn.UseVisualStyleBackColor = true;
      this.GoLab2Btn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button goLab2Btn1 = this.GoLab2Btn;
      point1 = new Point(16, 59);
      Point point3 = point1;
      goLab2Btn1.Location = point3;
      this.GoLab2Btn.Name = "GoLab2Btn";
      Button goLab2Btn2 = this.GoLab2Btn;
      size1 = new Size(172, 30);
      Size size3 = size1;
      goLab2Btn2.Size = size3;
      this.GoLab2Btn.TabIndex = 1;
      this.GoLab2Btn.Text = "РАБОТА №2";
      this.GoLab2Btn.UseVisualStyleBackColor = true;
      this.GoLab3Btn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button goLab3Btn1 = this.GoLab3Btn;
      point1 = new Point(16, 105);
      Point point4 = point1;
      goLab3Btn1.Location = point4;
      this.GoLab3Btn.Name = "GoLab3Btn";
      Button goLab3Btn2 = this.GoLab3Btn;
      size1 = new Size(172, 30);
      Size size4 = size1;
      goLab3Btn2.Size = size4;
      this.GoLab3Btn.TabIndex = 2;
      this.GoLab3Btn.Text = "РАБОТА №3";
      this.GoLab3Btn.UseVisualStyleBackColor = true;
      this.GoLab4Btn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button goLab4Btn1 = this.GoLab4Btn;
      point1 = new Point(16, 151);
      Point point5 = point1;
      goLab4Btn1.Location = point5;
      this.GoLab4Btn.Name = "GoLab4Btn";
      Button goLab4Btn2 = this.GoLab4Btn;
      size1 = new Size(172, 30);
      Size size5 = size1;
      goLab4Btn2.Size = size5;
      this.GoLab4Btn.TabIndex = 3;
      this.GoLab4Btn.Text = "РАБОТА №4";
      this.GoLab4Btn.UseVisualStyleBackColor = true;
      this.GoLab5Btn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button goLab5Btn1 = this.GoLab5Btn;
      point1 = new Point(16, 197);
      Point point6 = point1;
      goLab5Btn1.Location = point6;
      this.GoLab5Btn.Name = "GoLab5Btn";
      Button goLab5Btn2 = this.GoLab5Btn;
      size1 = new Size(172, 30);
      Size size6 = size1;
      goLab5Btn2.Size = size6;
      this.GoLab5Btn.TabIndex = 4;
      this.GoLab5Btn.Text = "РАБОТА №5";
      this.GoLab5Btn.UseVisualStyleBackColor = true;
      this.GoLab6Btn.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button goLab6Btn1 = this.GoLab6Btn;
      point1 = new Point(16, 243);
      Point point7 = point1;
      goLab6Btn1.Location = point7;
      this.GoLab6Btn.Name = "GoLab6Btn";
      Button goLab6Btn2 = this.GoLab6Btn;
      size1 = new Size(172, 30);
      Size size7 = size1;
      goLab6Btn2.Size = size7;
      this.GoLab6Btn.TabIndex = 5;
      this.GoLab6Btn.Text = "РАБОТА №6";
      this.GoLab6Btn.UseVisualStyleBackColor = true;
      this.BtnExit.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button btnExit1 = this.BtnExit;
      point1 = new Point(16, 289);
      Point point8 = point1;
      btnExit1.Location = point8;
      this.BtnExit.Name = "BtnExit";
      Button btnExit2 = this.BtnExit;
      size1 = new Size(172, 30);
      Size size8 = size1;
      btnExit2.Size = size8;
      this.BtnExit.TabIndex = 6;
      this.BtnExit.Text = "ВЫХОД";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(204, 334);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.BtnExit);
      this.Controls.Add((Control) this.GoLab6Btn);
      this.Controls.Add((Control) this.GoLab5Btn);
      this.Controls.Add((Control) this.GoLab4Btn);
      this.Controls.Add((Control) this.GoLab3Btn);
      this.Controls.Add((Control) this.GoLab2Btn);
      this.Controls.Add((Control) this.GoLab1Btn);
      this.MaximizeBox = false;
      this.Name = nameof (Proverka);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ПРОВЕРКА";
      this.ResumeLayout(false);
    }

    internal virtual Button GoLab1Btn
    {
      get
      {
        return this._GoLab1Btn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GoLab1Btn != null)
          this._GoLab1Btn.Click -= new EventHandler(this.GoLab1Btn_Click);
        this._GoLab1Btn = value;
        if (this._GoLab1Btn == null)
          return;
        this._GoLab1Btn.Click += new EventHandler(this.GoLab1Btn_Click);
      }
    }

    internal virtual Button GoLab2Btn
    {
      get
      {
        return this._GoLab2Btn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GoLab2Btn != null)
          this._GoLab2Btn.Click -= new EventHandler(this.GoLab2Btn_Click);
        this._GoLab2Btn = value;
        if (this._GoLab2Btn == null)
          return;
        this._GoLab2Btn.Click += new EventHandler(this.GoLab2Btn_Click);
      }
    }

    internal virtual Button GoLab3Btn
    {
      get
      {
        return this._GoLab3Btn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GoLab3Btn != null)
          this._GoLab3Btn.Click -= new EventHandler(this.GoLab3Btn_Click);
        this._GoLab3Btn = value;
        if (this._GoLab3Btn == null)
          return;
        this._GoLab3Btn.Click += new EventHandler(this.GoLab3Btn_Click);
      }
    }

    internal virtual Button GoLab4Btn
    {
      get
      {
        return this._GoLab4Btn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GoLab4Btn != null)
          this._GoLab4Btn.Click -= new EventHandler(this.GoLab4Btn_Click);
        this._GoLab4Btn = value;
        if (this._GoLab4Btn == null)
          return;
        this._GoLab4Btn.Click += new EventHandler(this.GoLab4Btn_Click);
      }
    }

    internal virtual Button GoLab5Btn
    {
      get
      {
        return this._GoLab5Btn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GoLab5Btn != null)
          this._GoLab5Btn.Click -= new EventHandler(this.GoLab5Btn_Click);
        this._GoLab5Btn = value;
        if (this._GoLab5Btn == null)
          return;
        this._GoLab5Btn.Click += new EventHandler(this.GoLab5Btn_Click);
      }
    }

    internal virtual Button GoLab6Btn
    {
      get
      {
        return this._GoLab6Btn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._GoLab6Btn != null)
          this._GoLab6Btn.Click -= new EventHandler(this.GoLab6Btn_Click);
        this._GoLab6Btn = value;
        if (this._GoLab6Btn == null)
          return;
        this._GoLab6Btn.Click += new EventHandler(this.GoLab6Btn_Click);
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

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void GoLab1Btn_Click(object sender, EventArgs e)
    {
      MyProject.Forms.MainFormLab1.Show();
      this.Close();
    }

    private void GoLab2Btn_Click(object sender, EventArgs e)
    {
      MyProject.Forms.MainFormLab2.Show();
      this.Close();
    }

    private void GoLab3Btn_Click(object sender, EventArgs e)
    {
      MyProject.Forms.MainFormLab3.Show();
      this.Close();
    }

    private void GoLab4Btn_Click(object sender, EventArgs e)
    {
      MyProject.Forms.MainFormLab4.Show();
      this.Close();
    }

    private void GoLab5Btn_Click(object sender, EventArgs e)
    {
      MyProject.Forms.MainFormLab5.Show();
      this.Close();
    }

    private void GoLab6Btn_Click(object sender, EventArgs e)
    {
      MyProject.Forms.MainFormLab6.Show();
      this.Close();
    }

    private void Proverka_Load(object sender, EventArgs e)
    {
      this.SetTopLevel(true);
    }
  }
}
