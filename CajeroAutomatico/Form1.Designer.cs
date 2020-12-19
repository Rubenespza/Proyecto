namespace CajeroAutomatico
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbllast = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.lblbalance = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 20);
            this.txtName.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Location = new System.Drawing.Point(12, 82);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(47, 13);
            this.lbllast.TabIndex = 2;
            this.lbllast.Text = "Apellido:";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(12, 104);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(257, 20);
            this.txtlastname.TabIndex = 5;
            // 
            // txtPIN
            // 
            this.txtPIN.AutoSize = true;
            this.txtPIN.Location = new System.Drawing.Point(12, 146);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(28, 13);
            this.txtPIN.TabIndex = 4;
            this.txtPIN.Text = "PIN:";
            // 
            // txtbalance
            // 
            this.txtbalance.Location = new System.Drawing.Point(12, 244);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(257, 20);
            this.txtbalance.TabIndex = 7;
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Location = new System.Drawing.Point(12, 215);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(92, 13);
            this.lblbalance.TabIndex = 6;
            this.lblbalance.Text = "Balance / Capital:";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(3, 270);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(299, 43);
            this.btnAplicar.TabIndex = 8;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 325);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbllast);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label txtPIN;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Button btnAplicar;
    }
}