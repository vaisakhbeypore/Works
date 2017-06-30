// Type: GNetBillingSoft.frmquotation
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GNetBillingSoft
{
  partial class frmquotation 
  {
    private IContainer components = (IContainer) null;
    private DataGridViewTextBoxColumn stock;
    private TextBox textBox1;
    private VScrollBar vScrollBar1;
    private Label label2;
    private TextBox txtinvoice;
    private Label label1;
    private TextBox textBox2;
    private GroupBox groupBox2;
    private TextBox textBox5;
    private TextBox textBox4;
    private Label label3;
    private Label label6;
    private Label label4;
    private DataGridViewTextBoxColumn total;
    private DataGridViewTextBoxColumn price;
    private DataGridViewTextBoxColumn quantity;
    private DataGridViewTextBoxColumn unit;
    private DataGridViewTextBoxColumn description;
    private DataGridViewTextBoxColumn itemno;
    private DataGridView dataGridView1;
    private Label label7;
    private GroupBox groupBox3;
    private TextBox textBox8;
    private Label label10;
    private TextBox textBox7;
    private Label label8;
    private TextBox textBox6;
    private GroupBox groupBox1;

   

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.stock = new DataGridViewTextBoxColumn();
      this.textBox1 = new TextBox();
      this.vScrollBar1 = new VScrollBar();
      this.label2 = new Label();
      this.txtinvoice = new TextBox();
      this.label1 = new Label();
      this.textBox2 = new TextBox();
      this.groupBox2 = new GroupBox();
      this.textBox5 = new TextBox();
      this.textBox4 = new TextBox();
      this.label3 = new Label();
      this.label6 = new Label();
      this.label4 = new Label();
      this.total = new DataGridViewTextBoxColumn();
      this.price = new DataGridViewTextBoxColumn();
      this.quantity = new DataGridViewTextBoxColumn();
      this.unit = new DataGridViewTextBoxColumn();
      this.description = new DataGridViewTextBoxColumn();
      this.itemno = new DataGridViewTextBoxColumn();
      this.dataGridView1 = new DataGridView();
      this.label7 = new Label();
      this.groupBox3 = new GroupBox();
      this.textBox8 = new TextBox();
      this.label10 = new Label();
      this.textBox7 = new TextBox();
      this.label8 = new Label();
      this.textBox6 = new TextBox();
      this.groupBox1 = new GroupBox();
      this.groupBox2.SuspendLayout();
      //this.dataGridView1.BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.stock.HeaderText = "Stock";
      this.stock.Name = "stock";
      this.textBox1.Location = new Point(658, 13);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 15;
      this.textBox1.Text = "11/07/2012";
      this.vScrollBar1.Location = new Point(260, 14);
      this.vScrollBar1.Name = "vScrollBar1";
      this.vScrollBar1.Size = new Size(12, 19);
      this.vScrollBar1.TabIndex = 14;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(578, 16);
      this.label2.Name = "label2";
      this.label2.Size = new Size(30, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Date";
      this.txtinvoice.Location = new Point(104, 13);
      this.txtinvoice.Name = "txtinvoice";
      this.txtinvoice.Size = new Size(153, 20);
      this.txtinvoice.TabIndex = 12;
      this.txtinvoice.Text = "1001";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(19, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(70, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Quotation No";
      this.label1.TextAlign = ContentAlignment.MiddleRight;
      this.textBox2.Location = new Point(104, 17);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(168, 20);
      this.textBox2.TabIndex = 13;
      this.groupBox2.Controls.Add((Control) this.textBox5);
      this.groupBox2.Controls.Add((Control) this.textBox4);
      this.groupBox2.Controls.Add((Control) this.textBox2);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Controls.Add((Control) this.label6);
      this.groupBox2.Controls.Add((Control) this.label4);
      this.groupBox2.Location = new Point(8, 59);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(853, 99);
      this.groupBox2.TabIndex = 37;
      this.groupBox2.TabStop = false;
      this.textBox5.Location = new Point(413, 10);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(100, 20);
      this.textBox5.TabIndex = 16;
      this.textBox5.Text = "9995629984";
      this.textBox4.Location = new Point(658, 13);
      this.textBox4.Multiline = true;
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(191, 63);
      this.textBox4.TabIndex = 15;
      this.textBox4.Text = "Mullungal House Kaloth 1'st mile kondotty malappuram";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(7, 20);
      this.label3.Name = "label3";
      this.label3.Size = new Size(82, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Customer Name";
      this.label3.TextAlign = ContentAlignment.MiddleRight;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(320, 13);
      this.label6.Name = "label6";
      this.label6.Size = new Size(78, 13);
      this.label6.TabIndex = 7;
      this.label6.Text = "Phone Number";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(563, 13);
      this.label4.Name = "label4";
      this.label4.Size = new Size(45, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Address";
      this.total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.total.HeaderText = "Total";
      this.total.Name = "total";
      this.price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.price.HeaderText = "Price";
      this.price.Name = "price";
      this.quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.quantity.HeaderText = "Quantity";
      this.quantity.Name = "quantity";
      this.unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.unit.HeaderText = "Unit";
      this.unit.Name = "unit";
      this.description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.description.HeaderText = "Description";
      this.description.Name = "description";
      this.itemno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.itemno.HeaderText = "Item No";
      this.itemno.Name = "itemno";
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.itemno, (DataGridViewColumn) this.description, (DataGridViewColumn) this.unit, (DataGridViewColumn) this.quantity, (DataGridViewColumn) this.price, (DataGridViewColumn) this.total, (DataGridViewColumn) this.stock);
      this.dataGridView1.Location = new Point(8, 178);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new Size(850, 150);
      this.dataGridView1.TabIndex = 39;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(8, 13);
      this.label7.Name = "label7";
      this.label7.Size = new Size(54, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Total Item";
      this.groupBox3.Controls.Add((Control) this.textBox8);
      this.groupBox3.Controls.Add((Control) this.label10);
      this.groupBox3.Controls.Add((Control) this.textBox7);
      this.groupBox3.Controls.Add((Control) this.label8);
      this.groupBox3.Controls.Add((Control) this.textBox6);
      this.groupBox3.Controls.Add((Control) this.label7);
      this.groupBox3.Location = new Point(8, 350);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(853, 46);
      this.groupBox3.TabIndex = 38;
      this.groupBox3.TabStop = false;
      this.textBox8.BackColor = Color.White;
      this.textBox8.Location = new Point(734, 10);
      this.textBox8.Name = "textBox8";
      this.textBox8.ReadOnly = true;
      this.textBox8.Size = new Size(112, 20);
      this.textBox8.TabIndex = 17;
      this.textBox8.Text = "2000.00";
      this.textBox8.TextAlign = HorizontalAlignment.Right;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(665, 13);
      this.label10.Name = "label10";
      this.label10.Size = new Size(63, 13);
      this.label10.TabIndex = 16;
      this.label10.Text = "Net Amount";
      this.textBox7.BackColor = Color.White;
      this.textBox7.Location = new Point(265, 10);
      this.textBox7.Name = "textBox7";
      this.textBox7.ReadOnly = true;
      this.textBox7.Size = new Size(107, 20);
      this.textBox7.TabIndex = 15;
      this.textBox7.Text = "20";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(199, 13);
      this.label8.Name = "label8";
      this.label8.Size = new Size(60, 13);
      this.label8.TabIndex = 14;
      this.label8.Text = "Discount %";
      this.textBox6.BackColor = Color.White;
      this.textBox6.Location = new Point(69, 10);
      this.textBox6.Name = "textBox6";
      this.textBox6.ReadOnly = true;
      this.textBox6.Size = new Size(107, 20);
      this.textBox6.TabIndex = 13;
      this.textBox6.Text = "20";
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.vScrollBar1);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.txtinvoice);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(8, 1);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(853, 52);
      this.groupBox1.TabIndex = 36;
      this.groupBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
     // this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(869, 543);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = "frmquotation";
      this.Text = "Quotation";
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
     // this.dataGridView1.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
