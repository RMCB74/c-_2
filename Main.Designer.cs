namespace CRUD_CSharp1
{
    partial class Main
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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.empledosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empSkilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empledosToolStripMenuItem,
            this.skillsToolStripMenuItem,
            this.relacionToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuStrip.Size = new System.Drawing.Size(800, 24);
            this.mnuStrip.TabIndex = 19;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // empledosToolStripMenuItem
            // 
            this.empledosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem});
            this.empledosToolStripMenuItem.Name = "empledosToolStripMenuItem";
            this.empledosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.empledosToolStripMenuItem.Text = "Empledos";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // skillsToolStripMenuItem
            // 
            this.skillsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skillToolStripMenuItem1});
            this.skillsToolStripMenuItem.Name = "skillsToolStripMenuItem";
            this.skillsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.skillsToolStripMenuItem.Text = "Skills";
            // 
            // skillToolStripMenuItem1
            // 
            this.skillToolStripMenuItem1.Name = "skillToolStripMenuItem1";
            this.skillToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.skillToolStripMenuItem1.Text = "Skill";
            this.skillToolStripMenuItem1.Click += new System.EventHandler(this.skillToolStripMenuItem1_Click);
            // 
            // relacionToolStripMenuItem
            // 
            this.relacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empSkilToolStripMenuItem});
            this.relacionToolStripMenuItem.Name = "relacionToolStripMenuItem";
            this.relacionToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.relacionToolStripMenuItem.Text = "Relacion";
            // 
            // empSkilToolStripMenuItem
            // 
            this.empSkilToolStripMenuItem.Name = "empSkilToolStripMenuItem";
            this.empSkilToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.empSkilToolStripMenuItem.Text = "Emp_Skill";
            this.empSkilToolStripMenuItem.Click += new System.EventHandler(this.empSkilToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.validarToolStripMenuItem,
            this.jsonToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // validarToolStripMenuItem
            // 
            this.validarToolStripMenuItem.Name = "validarToolStripMenuItem";
            this.validarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validarToolStripMenuItem.Text = "Validar";
            this.validarToolStripMenuItem.Click += new System.EventHandler(this.validarToolStripMenuItem_Click);
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jsonToolStripMenuItem.Text = "Json";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuStrip);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "CRUD #1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem empledosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empSkilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
    }
}