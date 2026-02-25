namespace CRUD_CSharp1
{
    partial class frmJsonv1
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
            this.dgViewJson = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnguardaJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewJson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewJson
            // 
            this.dgViewJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgViewJson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewJson.Location = new System.Drawing.Point(12, 41);
            this.dgViewJson.Name = "dgViewJson";
            this.dgViewJson.Size = new System.Drawing.Size(1036, 397);
            this.dgViewJson.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Json file Abre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnguardaJson
            // 
            this.btnguardaJson.Location = new System.Drawing.Point(116, 12);
            this.btnguardaJson.Name = "btnguardaJson";
            this.btnguardaJson.Size = new System.Drawing.Size(132, 23);
            this.btnguardaJson.TabIndex = 2;
            this.btnguardaJson.Text = "Json file Guarda";
            this.btnguardaJson.UseVisualStyleBackColor = true;
            this.btnguardaJson.Click += new System.EventHandler(this.btnguardaJson_Click);
            // 
            // frmJsonv1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.btnguardaJson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgViewJson);
            this.Name = "frmJsonv1";
            this.Text = "Jsonv1";
            this.Load += new System.EventHandler(this.frmJsonv1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewJson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewJson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnguardaJson;
    }
}