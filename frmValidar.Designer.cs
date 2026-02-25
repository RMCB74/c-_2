namespace CRUD_CSharp1
{
    partial class frmValidar
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
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPswrd = new System.Windows.Forms.TextBox();
            this.cmdValida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "User";
            // 
            // txtUsr
            // 
            this.txtUsr.Location = new System.Drawing.Point(111, 29);
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(100, 22);
            this.txtUsr.TabIndex = 23;
            this.txtUsr.Text = "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "PSWRD";
            // 
            // txtPswrd
            // 
            this.txtPswrd.Location = new System.Drawing.Point(111, 60);
            this.txtPswrd.Name = "txtPswrd";
            this.txtPswrd.Size = new System.Drawing.Size(100, 22);
            this.txtPswrd.TabIndex = 25;
            this.txtPswrd.Text = "\r\n";
            // 
            // cmdValida
            // 
            this.cmdValida.Location = new System.Drawing.Point(111, 100);
            this.cmdValida.Name = "cmdValida";
            this.cmdValida.Size = new System.Drawing.Size(75, 23);
            this.cmdValida.TabIndex = 27;
            this.cmdValida.Text = "Validar";
            this.cmdValida.UseVisualStyleBackColor = true;
            this.cmdValida.Click += new System.EventHandler(this.cmdValida_Click);
            // 
            // frmValidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 163);
            this.Controls.Add(this.cmdValida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPswrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsr);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmValidar";
            this.Text = "Validar";
            this.Load += new System.EventHandler(this.frmValidar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPswrd;
        private System.Windows.Forms.Button cmdValida;
    }
}