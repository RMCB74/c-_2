namespace CRUD_CSharp1
{
    partial class form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridViewEmp = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApat = new System.Windows.Forms.TextBox();
            this.txtAma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtimePkFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIdEmp_ = new System.Windows.Forms.TextBox();
            this.btnConulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado EMP";
            // 
            // dtGridViewEmp
            // 
            this.dtGridViewEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewEmp.Location = new System.Drawing.Point(9, 135);
            this.dtGridViewEmp.Margin = new System.Windows.Forms.Padding(2);
            this.dtGridViewEmp.MultiSelect = false;
            this.dtGridViewEmp.Name = "dtGridViewEmp";
            this.dtGridViewEmp.ReadOnly = true;
            this.dtGridViewEmp.RowHeadersWidth = 51;
            this.dtGridViewEmp.RowTemplate.Height = 24;
            this.dtGridViewEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewEmp.Size = new System.Drawing.Size(580, 220);
            this.dtGridViewEmp.TabIndex = 1;
            this.dtGridViewEmp.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGridViewEmp_CellMouseClick);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(62, 13);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(76, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtApat
            // 
            this.txtApat.Location = new System.Drawing.Point(62, 35);
            this.txtApat.Margin = new System.Windows.Forms.Padding(2);
            this.txtApat.Name = "txtApat";
            this.txtApat.Size = new System.Drawing.Size(76, 20);
            this.txtApat.TabIndex = 3;
            // 
            // txtAma
            // 
            this.txtAma.Location = new System.Drawing.Point(62, 59);
            this.txtAma.Margin = new System.Windows.Forms.Padding(2);
            this.txtAma.Name = "txtAma";
            this.txtAma.Size = new System.Drawing.Size(76, 20);
            this.txtAma.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "APat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "AMat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha";
            // 
            // dtimePkFecha
            // 
            this.dtimePkFecha.Location = new System.Drawing.Point(62, 82);
            this.dtimePkFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtimePkFecha.Name = "dtimePkFecha";
            this.dtimePkFecha.Size = new System.Drawing.Size(151, 20);
            this.dtimePkFecha.TabIndex = 10;
            // 
            // btnAgrega
            // 
            this.btnAgrega.Location = new System.Drawing.Point(406, 7);
            this.btnAgrega.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(70, 19);
            this.btnAgrega.TabIndex = 11;
            this.btnAgrega.Text = "Nuevo";
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(406, 54);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(2);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(70, 19);
            this.btnElimina.TabIndex = 12;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(406, 30);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(70, 19);
            this.btnModifica.TabIndex = 13;
            this.btnModifica.Text = "Modif";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(176, 13);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(196, 11);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 20);
            this.txtID.TabIndex = 14;
            // 
            // txtIdEmp_
            // 
            this.txtIdEmp_.Enabled = false;
            this.txtIdEmp_.Location = new System.Drawing.Point(178, 34);
            this.txtIdEmp_.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEmp_.Name = "txtIdEmp_";
            this.txtIdEmp_.Size = new System.Drawing.Size(207, 20);
            this.txtIdEmp_.TabIndex = 16;
            // 
            // btnConulta
            // 
            this.btnConulta.Location = new System.Drawing.Point(254, 11);
            this.btnConulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnConulta.Name = "btnConulta";
            this.btnConulta.Size = new System.Drawing.Size(70, 19);
            this.btnConulta.TabIndex = 17;
            this.btnConulta.Text = "Consulta";
            this.btnConulta.UseVisualStyleBackColor = true;
            this.btnConulta.Click += new System.EventHandler(this.btnConulta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnConulta);
            this.Controls.Add(this.txtIdEmp_);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.dtimePkFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAma);
            this.Controls.Add(this.txtApat);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dtGridViewEmp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridViewEmp;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtApat;
        private System.Windows.Forms.TextBox txtAma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtimePkFecha;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIdEmp_;
        private System.Windows.Forms.Button btnConulta;
    }
}

