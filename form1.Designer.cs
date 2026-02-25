namespace CRUD_CSharp1
{
    partial class Form1
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
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.lblPermiso = new System.Windows.Forms.Label();
            this.txtPermiso = new System.Windows.Forms.TextBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 120);
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
            this.dtGridViewEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridViewEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewEmp.Location = new System.Drawing.Point(9, 135);
            this.dtGridViewEmp.Margin = new System.Windows.Forms.Padding(2);
            this.dtGridViewEmp.MultiSelect = false;
            this.dtGridViewEmp.Name = "dtGridViewEmp";
            this.dtGridViewEmp.ReadOnly = true;
            this.dtGridViewEmp.RowHeadersWidth = 51;
            this.dtGridViewEmp.RowTemplate.Height = 24;
            this.dtGridViewEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewEmp.Size = new System.Drawing.Size(770, 338);
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
            this.txtApat.Location = new System.Drawing.Point(62, 38);
            this.txtApat.Margin = new System.Windows.Forms.Padding(2);
            this.txtApat.Name = "txtApat";
            this.txtApat.Size = new System.Drawing.Size(76, 20);
            this.txtApat.TabIndex = 3;
            // 
            // txtAma
            // 
            this.txtAma.Location = new System.Drawing.Point(62, 64);
            this.txtAma.Margin = new System.Windows.Forms.Padding(2);
            this.txtAma.Name = "txtAma";
            this.txtAma.Size = new System.Drawing.Size(76, 20);
            this.txtAma.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "APat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "AMat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha";
            // 
            // dtimePkFecha
            // 
            this.dtimePkFecha.Location = new System.Drawing.Point(62, 88);
            this.dtimePkFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtimePkFecha.Name = "dtimePkFecha";
            this.dtimePkFecha.Size = new System.Drawing.Size(151, 20);
            this.dtimePkFecha.TabIndex = 10;
            // 
            // btnAgrega
            // 
            this.btnAgrega.Location = new System.Drawing.Point(698, 51);
            this.btnAgrega.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(70, 24);
            this.btnAgrega.TabIndex = 11;
            this.btnAgrega.Text = "Nuevo";
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(698, 101);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(2);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(70, 22);
            this.btnElimina.TabIndex = 12;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(698, 78);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(70, 21);
            this.btnModifica.TabIndex = 13;
            this.btnModifica.Text = "Modif";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(297, 23);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(352, 16);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 20);
            this.txtID.TabIndex = 14;
            // 
            // txtIdEmp_
            // 
            this.txtIdEmp_.Enabled = false;
            this.txtIdEmp_.Location = new System.Drawing.Point(400, 16);
            this.txtIdEmp_.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEmp_.Name = "txtIdEmp_";
            this.txtIdEmp_.Size = new System.Drawing.Size(264, 20);
            this.txtIdEmp_.TabIndex = 16;
            // 
            // btnConulta
            // 
            this.btnConulta.Location = new System.Drawing.Point(698, 23);
            this.btnConulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnConulta.Name = "btnConulta";
            this.btnConulta.Size = new System.Drawing.Size(70, 24);
            this.btnConulta.TabIndex = 17;
            this.btnConulta.Text = "Consulta";
            this.btnConulta.UseVisualStyleBackColor = true;
            this.btnConulta.Click += new System.EventHandler(this.btnConulta_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(297, 71);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(37, 13);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = "USER";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(352, 70);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(76, 20);
            this.txtUser.TabIndex = 18;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(297, 96);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(33, 13);
            this.lblPwd.TabIndex = 21;
            this.lblPwd.Text = "PWD";
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(352, 93);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(2);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(76, 20);
            this.txtPWD.TabIndex = 20;
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.Location = new System.Drawing.Point(297, 51);
            this.lblPermiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(44, 13);
            this.lblPermiso.TabIndex = 23;
            this.lblPermiso.Text = "Permiso";
            this.lblPermiso.Click += new System.EventHandler(this.lblPermiso_Click);
            // 
            // txtPermiso
            // 
            this.txtPermiso.Location = new System.Drawing.Point(352, 40);
            this.txtPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPermiso.Name = "txtPermiso";
            this.txtPermiso.Size = new System.Drawing.Size(312, 20);
            this.txtPermiso.TabIndex = 22;
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(218, 93);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(54, 17);
            this.chkFecha.TabIndex = 24;
            this.chkFecha.Text = "Incluir";
            this.chkFecha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 484);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.lblPermiso);
            this.Controls.Add(this.txtPermiso);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empleados";
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
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Label lblPermiso;
        private System.Windows.Forms.TextBox txtPermiso;
        private System.Windows.Forms.CheckBox chkFecha;
    }
}

