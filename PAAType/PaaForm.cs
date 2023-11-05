using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PAAType
{
  public class PaaForm : Form
  {
    private bool isOne = false;
    private IContainer components = (IContainer) null;
    private Label lbl_size;
    private GroupBox gr_author;
    private Label lbl_help;
    private Label lbl_dev;
    public NumericUpDown sp_size;
    private Button btn_OK;

    public PaaForm() => this.InitializeComponent();

    private void sp_size_ValueChanged(object sender, EventArgs e)
    {
    }

    private void sp_size_Click(object sender, EventArgs e)
    {
      if ((int) this.sp_size.Value != 0)
        return;
      this.isOne = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PaaForm));
      this.lbl_size = new Label();
      this.sp_size = new NumericUpDown();
      this.gr_author = new GroupBox();
      this.lbl_help = new Label();
      this.lbl_dev = new Label();
      this.btn_OK = new Button();
      this.sp_size.BeginInit();
      this.gr_author.SuspendLayout();
      this.SuspendLayout();
      this.lbl_size.AutoSize = true;
      this.lbl_size.Location = new Point(12, 9);
      this.lbl_size.Name = "lbl_size";
      this.lbl_size.Size = new Size(62, 13);
      this.lbl_size.TabIndex = 0;
      this.lbl_size.Text = "Размер (*):";
      this.sp_size.BorderStyle = BorderStyle.None;
      this.sp_size.Increment = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      this.sp_size.Location = new Point(128, 9);
      this.sp_size.Maximum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.sp_size.Name = "sp_size";
      this.sp_size.Size = new Size(74, 16);
      this.sp_size.TabIndex = 1;
      this.sp_size.Value = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      this.sp_size.ValueChanged += new EventHandler(this.sp_size_ValueChanged);
      this.sp_size.Click += new EventHandler(this.sp_size_Click);
      this.gr_author.Controls.Add((Control) this.lbl_help);
      this.gr_author.Controls.Add((Control) this.lbl_dev);
      this.gr_author.Location = new Point(12, 60);
      this.gr_author.Name = "gr_author";
      this.gr_author.Size = new Size(202, 60);
      this.gr_author.TabIndex = 2;
      this.gr_author.TabStop = false;
      this.gr_author.Text = "Авторы";
      this.lbl_help.AutoSize = true;
      this.lbl_help.Location = new Point(6, 38);
      this.lbl_help.Name = "lbl_help";
      this.lbl_help.Size = new Size(191, 13);
      this.lbl_help.TabIndex = 1;
      this.lbl_help.Text = "Бибилеотека PAA и PAC от:  Braini01";
      this.lbl_dev.AutoSize = true;
      this.lbl_dev.Location = new Point(6, 16);
      this.lbl_dev.Name = "lbl_dev";
      this.lbl_dev.Size = new Size(117, 13);
      this.lbl_dev.TabIndex = 0;
      this.lbl_dev.Text = "Разработчик: Man232";
      this.btn_OK.Location = new Point((int) sbyte.MaxValue, 31);
      this.btn_OK.Name = "btn_OK";
      this.btn_OK.Size = new Size(75, 23);
      this.btn_OK.TabIndex = 3;
      this.btn_OK.Text = "ОК";
      this.btn_OK.DialogResult = DialogResult.OK;
      this.btn_OK.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(221, 125);
      this.Controls.Add((Control) this.btn_OK);
      this.Controls.Add((Control) this.gr_author);
      this.Controls.Add((Control) this.sp_size);
      this.Controls.Add((Control) this.lbl_size);
      this.AcceptButton = (IButtonControl) this.btn_OK;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (PaaForm);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Настройка";
      this.TopMost = true;
      this.sp_size.EndInit();
      this.gr_author.ResumeLayout(false);
      this.gr_author.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
