﻿namespace Pokemon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(141, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 185);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "pokemon";
            // 
            // button1
            // 
            button1.Location = new Point(68, 227);
            button1.Name = "button1";
            button1.Size = new Size(217, 29);
            button1.TabIndex = 2;
            button1.Text = "Wigglytuff";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(69, 274);
            button2.Name = "button2";
            button2.Size = new Size(217, 29);
            button2.TabIndex = 3;
            button2.Text = "Snorlax";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(68, 323);
            button3.Name = "button3";
            button3.Size = new Size(217, 29);
            button3.TabIndex = 4;
            button3.Text = "pipi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(319, 227);
            button4.Name = "button4";
            button4.Size = new Size(217, 29);
            button4.TabIndex = 5;
            button4.Text = "Pachirisu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(319, 274);
            button5.Name = "button5";
            button5.Size = new Size(217, 29);
            button5.TabIndex = 6;
            button5.Text = "eevee";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(319, 323);
            button6.Name = "button6";
            button6.Size = new Size(217, 29);
            button6.TabIndex = 7;
            button6.Text = "Celebi";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Milotic;
            pictureBox2.Location = new Point(747, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(365, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(904, 231);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 9;
            label2.Text = "Milotic";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 534);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox2;
        private Label label2;
    }
}
