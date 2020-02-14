using System;
using System.Windows.Forms;
using System.Drawing;

namespace dot_windows
{
    public class  frm_counter: Form
    {
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        public Button button1;

        public frm_counter()

        {
            InitializeComponent();
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1     = new Label();
            this.label2     = new Label();
            this.textBox1   = new TextBox();
            this.textBox2   = new TextBox();
            this.button1    = new Button();
            this.button2    = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(40, 48);
            this.label1.Margin = new Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count To :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(40, 107);
            this.label2.Margin = new Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(188, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reach this Number :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(337, 41);
            this.textBox1.Margin = new Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(186, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new Point(337, 100);
            this.textBox2.Margin = new Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(184, 29);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new Point(171, 227);
            this.button1.Margin = new Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new Size(196, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new Point(202, 175);
            this.button2.Margin = new Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new Size(138, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmCounter1
            // 
            this.AutoScaleDimensions = new SizeF(11F, 24F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(556, 380);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new Padding(4, 4, 4, 4);
            this.Name = "frmCounter1";
            this.Text = "Event Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}