namespace Kuis10
{
    partial class Form1
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textinput1 = new System.Windows.Forms.TextBox();
            this.textinput2 = new System.Windows.Forms.TextBox();
            this.texthasil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnkurang = new System.Windows.Forms.Button();
            this.btnkali = new System.Windows.Forms.Button();
            this.btnbagi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textinput1
            // 
            this.textinput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textinput1.Location = new System.Drawing.Point(152, 100);
            this.textinput1.Name = "textinput1";
            this.textinput1.Size = new System.Drawing.Size(222, 29);
            this.textinput1.TabIndex = 0;
            this.textinput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textinput1.TextChanged += new System.EventHandler(this.textinput1_TextChanged);
            // 
            // textinput2
            // 
            this.textinput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textinput2.Location = new System.Drawing.Point(152, 155);
            this.textinput2.Name = "textinput2";
            this.textinput2.Size = new System.Drawing.Size(222, 29);
            this.textinput2.TabIndex = 1;
            this.textinput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // texthasil
            // 
            this.texthasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texthasil.Location = new System.Drawing.Point(152, 211);
            this.texthasil.Name = "texthasil";
            this.texthasil.Size = new System.Drawing.Size(222, 29);
            this.texthasil.TabIndex = 2;
            this.texthasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.texthasil.TextChanged += new System.EventHandler(this.texthasil_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kalkulatore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "angka 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "hasil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "angka 2";
            // 
            // btntambah
            // 
            this.btntambah.ForeColor = System.Drawing.Color.Black;
            this.btntambah.Location = new System.Drawing.Point(135, 267);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(49, 23);
            this.btntambah.TabIndex = 10;
            this.btntambah.Text = "+";
            this.btntambah.UseVisualStyleBackColor = true;
            // 
            // btnkurang
            // 
            this.btnkurang.Location = new System.Drawing.Point(190, 267);
            this.btnkurang.Name = "btnkurang";
            this.btnkurang.Size = new System.Drawing.Size(48, 23);
            this.btnkurang.TabIndex = 11;
            this.btnkurang.Text = "-";
            this.btnkurang.UseVisualStyleBackColor = true;
            // 
            // btnkali
            // 
            this.btnkali.Location = new System.Drawing.Point(244, 267);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(59, 23);
            this.btnkali.TabIndex = 12;
            this.btnkali.Text = "X";
            this.btnkali.UseVisualStyleBackColor = true;
            // 
            // btnbagi
            // 
            this.btnbagi.Location = new System.Drawing.Point(309, 267);
            this.btnbagi.Name = "btnbagi";
            this.btnbagi.Size = new System.Drawing.Size(75, 23);
            this.btnbagi.TabIndex = 13;
            this.btnbagi.Text = ":";
            this.btnbagi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btnbagi);
            this.Controls.Add(this.btnkali);
            this.Controls.Add(this.btnkurang);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texthasil);
            this.Controls.Add(this.textinput2);
            this.Controls.Add(this.textinput1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Kuis10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textinput1;
        private System.Windows.Forms.TextBox textinput2;
        private System.Windows.Forms.TextBox texthasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnkurang;
        private System.Windows.Forms.Button btnkali;
        private System.Windows.Forms.Button btnbagi;
    }
}

