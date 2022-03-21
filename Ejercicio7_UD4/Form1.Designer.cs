
namespace Ejercicio7_UD4
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
            this.Joe_saldo = new System.Windows.Forms.Label();
            this.Bob_saldo = new System.Windows.Forms.Label();
            this.banca = new System.Windows.Forms.Label();
            this.aJoe10e = new System.Windows.Forms.Button();
            this.deBob5e = new System.Windows.Forms.Button();
            this.JoeABob = new System.Windows.Forms.Button();
            this.BobAJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Joe_saldo
            // 
            this.Joe_saldo.AutoSize = true;
            this.Joe_saldo.Location = new System.Drawing.Point(110, 131);
            this.Joe_saldo.Name = "Joe_saldo";
            this.Joe_saldo.Size = new System.Drawing.Size(109, 20);
            this.Joe_saldo.TabIndex = 0;
            this.Joe_saldo.Text = "Joe tiene 50eur";
            // 
            // Bob_saldo
            // 
            this.Bob_saldo.AutoSize = true;
            this.Bob_saldo.Location = new System.Drawing.Point(110, 72);
            this.Bob_saldo.Name = "Bob_saldo";
            this.Bob_saldo.Size = new System.Drawing.Size(122, 20);
            this.Bob_saldo.TabIndex = 1;
            this.Bob_saldo.Text = "Bob tiene 100eur";
            // 
            // banca
            // 
            this.banca.AutoSize = true;
            this.banca.ForeColor = System.Drawing.Color.Red;
            this.banca.Location = new System.Drawing.Point(110, 189);
            this.banca.Name = "banca";
            this.banca.Size = new System.Drawing.Size(154, 20);
            this.banca.TabIndex = 2;
            this.banca.Text = "La banca tiene 100eur";
            // 
            // aJoe10e
            // 
            this.aJoe10e.Location = new System.Drawing.Point(265, 251);
            this.aJoe10e.Name = "aJoe10e";
            this.aJoe10e.Size = new System.Drawing.Size(94, 71);
            this.aJoe10e.TabIndex = 3;
            this.aJoe10e.Text = "Dar 10e E Joe";
            this.aJoe10e.UseVisualStyleBackColor = true;
            this.aJoe10e.Click += new System.EventHandler(this.aJoe10e_Click);
            // 
            // deBob5e
            // 
            this.deBob5e.Location = new System.Drawing.Point(442, 251);
            this.deBob5e.Name = "deBob5e";
            this.deBob5e.Size = new System.Drawing.Size(94, 71);
            this.deBob5e.TabIndex = 4;
            this.deBob5e.Text = "Recibir 5e de Bob";
            this.deBob5e.UseVisualStyleBackColor = true;
            this.deBob5e.Click += new System.EventHandler(this.aBob5e_Click);
            // 
            // JoeABob
            // 
            this.JoeABob.Location = new System.Drawing.Point(265, 359);
            this.JoeABob.Name = "JoeABob";
            this.JoeABob.Size = new System.Drawing.Size(94, 71);
            this.JoeABob.TabIndex = 5;
            this.JoeABob.Text = "Joe da 10E a Bob";
            this.JoeABob.UseVisualStyleBackColor = true;
            this.JoeABob.Click += new System.EventHandler(this.JoeABob_Click);
            // 
            // BobAJoe
            // 
            this.BobAJoe.Location = new System.Drawing.Point(442, 359);
            this.BobAJoe.Name = "BobAJoe";
            this.BobAJoe.Size = new System.Drawing.Size(94, 71);
            this.BobAJoe.TabIndex = 6;
            this.BobAJoe.Text = "Bob da 5e a Joe";
            this.BobAJoe.UseVisualStyleBackColor = true;
            this.BobAJoe.Click += new System.EventHandler(this.BobAJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.BobAJoe);
            this.Controls.Add(this.JoeABob);
            this.Controls.Add(this.deBob5e);
            this.Controls.Add(this.aJoe10e);
            this.Controls.Add(this.banca);
            this.Controls.Add(this.Bob_saldo);
            this.Controls.Add(this.Joe_saldo);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Joe_saldo;
        private System.Windows.Forms.Label Bob_saldo;
        private System.Windows.Forms.Label banca;
        private System.Windows.Forms.Button aJoe10e;
        private System.Windows.Forms.Button deBob5e;
        private System.Windows.Forms.Button JoeABob;
        private System.Windows.Forms.Button BobAJoe;
    }
}

