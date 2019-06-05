// Decompiled with JetBrains decompiler
// Type: Proverka.Plot
// Assembly: Proverka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CEE704FC-3D12-4FFC-8D1B-D1F47A457B1E
// Assembly location: C:\Users\nekha\OneDrive\Рабочий стол\Proverka.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Proverka
{
  [DesignerGenerated]
  public class Plot : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("HelpProvider1")]
    private HelpProvider _HelpProvider1;

    public Plot()
    {
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
      this.Cancel_Button = new Button();
      this.PictureBox1 = new PictureBox();
      this.HelpProvider1 = new HelpProvider();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.Cancel_Button.Anchor = AnchorStyles.None;
      this.Cancel_Button.DialogResult = DialogResult.Cancel;
      this.Cancel_Button.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      Button cancelButton1 = this.Cancel_Button;
      Point point1 = new Point(200, 356);
      Point point2 = point1;
      cancelButton1.Location = point2;
      this.Cancel_Button.Name = "Cancel_Button";
      Button cancelButton2 = this.Cancel_Button;
      Size size1 = new Size(108, 29);
      Size size2 = size1;
      cancelButton2.Size = size2;
      this.Cancel_Button.TabIndex = 1;
      this.Cancel_Button.Text = "Закрыть";
      this.PictureBox1.BackColor = Color.White;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(13, 13);
      Point point3 = point1;
      pictureBox1_1.Location = point3;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(483, 337);
      Size size3 = size1;
      pictureBox1_2.Size = size3;
      this.PictureBox1.TabIndex = 2;
      this.PictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(508, 394);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Cancel_Button);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.HelpButton = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Plot);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = nameof (Plot);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
    }

    internal virtual Button Cancel_Button
    {
      get
      {
        return this._Cancel_Button;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (this._Cancel_Button != null)
          this._Cancel_Button.Click -= new EventHandler(this.Cancel_Button_Click);
        this._Cancel_Button = value;
        if (this._Cancel_Button == null)
          return;
        this._Cancel_Button.Click += new EventHandler(this.Cancel_Button_Click);
      }
    }

    internal virtual PictureBox PictureBox1
    {
      get
      {
        return this._PictureBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox1 = value;
      }
    }

    internal virtual HelpProvider HelpProvider1
    {
      get
      {
        return this._HelpProvider1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._HelpProvider1 = value;
      }
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
