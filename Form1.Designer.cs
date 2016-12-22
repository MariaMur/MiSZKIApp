namespace MiSZKI
{
    partial class MiSZKI
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRSA = new System.Windows.Forms.TextBox();
            this.textBoxSHA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEGD = new System.Windows.Forms.TextBox();
            this.textBoxEGE = new System.Windows.Forms.TextBox();
            this.textBoxDESD = new System.Windows.Forms.TextBox();
            this.textBoxDESE = new System.Windows.Forms.TextBox();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRSA
            // 
            this.textBoxRSA.Location = new System.Drawing.Point(15, 233);
            this.textBoxRSA.Name = "textBoxRSA";
            this.textBoxRSA.ReadOnly = true;
            this.textBoxRSA.Size = new System.Drawing.Size(176, 20);
            this.textBoxRSA.TabIndex = 24;
            // 
            // textBoxSHA
            // 
            this.textBoxSHA.Location = new System.Drawing.Point(15, 187);
            this.textBoxSHA.Name = "textBoxSHA";
            this.textBoxSHA.ReadOnly = true;
            this.textBoxSHA.Size = new System.Drawing.Size(176, 20);
            this.textBoxSHA.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Цифровая подпись алгоритмом RSA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Результат хеширования алгоритмом SHA-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Результат ассиметричного шифрофания алгоритмом ELGamal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Результат симметричного шифрования алгоритмом DES";
            // 
            // textBoxEGD
            // 
            this.textBoxEGD.Location = new System.Drawing.Point(210, 139);
            this.textBoxEGD.Name = "textBoxEGD";
            this.textBoxEGD.ReadOnly = true;
            this.textBoxEGD.Size = new System.Drawing.Size(171, 20);
            this.textBoxEGD.TabIndex = 18;
            // 
            // textBoxEGE
            // 
            this.textBoxEGE.Location = new System.Drawing.Point(15, 139);
            this.textBoxEGE.Name = "textBoxEGE";
            this.textBoxEGE.ReadOnly = true;
            this.textBoxEGE.Size = new System.Drawing.Size(176, 20);
            this.textBoxEGE.TabIndex = 17;
            // 
            // textBoxDESD
            // 
            this.textBoxDESD.Location = new System.Drawing.Point(210, 90);
            this.textBoxDESD.Name = "textBoxDESD";
            this.textBoxDESD.ReadOnly = true;
            this.textBoxDESD.Size = new System.Drawing.Size(171, 20);
            this.textBoxDESD.TabIndex = 16;
            // 
            // textBoxDESE
            // 
            this.textBoxDESE.Location = new System.Drawing.Point(15, 90);
            this.textBoxDESE.Name = "textBoxDESE";
            this.textBoxDESE.ReadOnly = true;
            this.textBoxDESE.Size = new System.Drawing.Size(176, 20);
            this.textBoxDESE.TabIndex = 15;
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(15, 36);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(100, 20);
            this.textBoxString.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите строку";
            // 
            // MiSZKI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRSA);
            this.Controls.Add(this.textBoxSHA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEGD);
            this.Controls.Add(this.textBoxEGE);
            this.Controls.Add(this.textBoxDESD);
            this.Controls.Add(this.textBoxDESE);
            this.Controls.Add(this.textBoxString);
            this.Controls.Add(this.label1);
            this.Name = "MiSZKI";
            this.Text = "MiSZKI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRSA;
        private System.Windows.Forms.TextBox textBoxSHA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEGD;
        private System.Windows.Forms.TextBox textBoxEGE;
        private System.Windows.Forms.TextBox textBoxDESD;
        private System.Windows.Forms.TextBox textBoxDESE;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label label1;
    }
}

