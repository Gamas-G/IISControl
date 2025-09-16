namespace IISControl.Vistas
{
    partial class Exportar
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
            this.gb_InfoIIS = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tv_destino = new System.Windows.Forms.TreeView();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.tv_datos = new System.Windows.Forms.TreeView();
            this.gb_Accion = new System.Windows.Forms.GroupBox();
            this.rd_todo = new System.Windows.Forms.RadioButton();
            this.rd_pools = new System.Windows.Forms.RadioButton();
            this.rd_apps = new System.Windows.Forms.RadioButton();
            this.rd_sites = new System.Windows.Forms.RadioButton();
            this.lbl_hostname = new System.Windows.Forms.Label();
            this.btn_ObtenerInformacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_detectar = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.gb_InfoIIS.SuspendLayout();
            this.gb_Accion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_InfoIIS
            // 
            this.gb_InfoIIS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_InfoIIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_InfoIIS.Controls.Add(this.label4);
            this.gb_InfoIIS.Controls.Add(this.label3);
            this.gb_InfoIIS.Controls.Add(this.tv_destino);
            this.gb_InfoIIS.Controls.Add(this.btn_seleccionar);
            this.gb_InfoIIS.Controls.Add(this.btn_exportar);
            this.gb_InfoIIS.Controls.Add(this.tv_datos);
            this.gb_InfoIIS.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_InfoIIS.Location = new System.Drawing.Point(29, 237);
            this.gb_InfoIIS.Name = "gb_InfoIIS";
            this.gb_InfoIIS.Size = new System.Drawing.Size(1070, 496);
            this.gb_InfoIIS.TabIndex = 9;
            this.gb_InfoIIS.TabStop = false;
            this.gb_InfoIIS.Text = "Datos IIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exportar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccionar";
            // 
            // tv_destino
            // 
            this.tv_destino.Location = new System.Drawing.Point(549, 37);
            this.tv_destino.Name = "tv_destino";
            this.tv_destino.Size = new System.Drawing.Size(500, 373);
            this.tv_destino.TabIndex = 3;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_seleccionar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.Location = new System.Drawing.Point(324, 447);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(197, 43);
            this.btn_seleccionar.TabIndex = 2;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.Location = new System.Drawing.Point(549, 447);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(197, 43);
            this.btn_exportar.TabIndex = 1;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // tv_datos
            // 
            this.tv_datos.CheckBoxes = true;
            this.tv_datos.Location = new System.Drawing.Point(21, 37);
            this.tv_datos.Name = "tv_datos";
            this.tv_datos.Size = new System.Drawing.Size(500, 373);
            this.tv_datos.TabIndex = 0;
            // 
            // gb_Accion
            // 
            this.gb_Accion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_Accion.Controls.Add(this.rd_todo);
            this.gb_Accion.Controls.Add(this.rd_pools);
            this.gb_Accion.Controls.Add(this.rd_apps);
            this.gb_Accion.Controls.Add(this.rd_sites);
            this.gb_Accion.Controls.Add(this.lbl_hostname);
            this.gb_Accion.Controls.Add(this.btn_ObtenerInformacion);
            this.gb_Accion.Controls.Add(this.label2);
            this.gb_Accion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Accion.Location = new System.Drawing.Point(29, 83);
            this.gb_Accion.Name = "gb_Accion";
            this.gb_Accion.Size = new System.Drawing.Size(521, 148);
            this.gb_Accion.TabIndex = 8;
            this.gb_Accion.TabStop = false;
            this.gb_Accion.Text = "Tipo";
            // 
            // rd_todo
            // 
            this.rd_todo.AutoSize = true;
            this.rd_todo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_todo.Location = new System.Drawing.Point(244, 55);
            this.rd_todo.Name = "rd_todo";
            this.rd_todo.Size = new System.Drawing.Size(43, 17);
            this.rd_todo.TabIndex = 12;
            this.rd_todo.TabStop = true;
            this.rd_todo.Text = "IIS";
            this.rd_todo.UseVisualStyleBackColor = true;
            this.rd_todo.CheckedChanged += new System.EventHandler(this.rd_todo_CheckedChanged);
            // 
            // rd_pools
            // 
            this.rd_pools.AutoSize = true;
            this.rd_pools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_pools.Location = new System.Drawing.Point(183, 55);
            this.rd_pools.Name = "rd_pools";
            this.rd_pools.Size = new System.Drawing.Size(55, 17);
            this.rd_pools.TabIndex = 11;
            this.rd_pools.TabStop = true;
            this.rd_pools.Text = "Pools";
            this.rd_pools.UseVisualStyleBackColor = true;
            this.rd_pools.CheckedChanged += new System.EventHandler(this.rd_pools_CheckedChanged);
            // 
            // rd_apps
            // 
            this.rd_apps.AutoSize = true;
            this.rd_apps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_apps.Location = new System.Drawing.Point(80, 55);
            this.rd_apps.Name = "rd_apps";
            this.rd_apps.Size = new System.Drawing.Size(97, 17);
            this.rd_apps.TabIndex = 10;
            this.rd_apps.TabStop = true;
            this.rd_apps.Text = "Applications";
            this.rd_apps.UseVisualStyleBackColor = true;
            this.rd_apps.CheckedChanged += new System.EventHandler(this.rd_apps_CheckedChanged);
            // 
            // rd_sites
            // 
            this.rd_sites.AutoSize = true;
            this.rd_sites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_sites.Location = new System.Drawing.Point(19, 56);
            this.rd_sites.Name = "rd_sites";
            this.rd_sites.Size = new System.Drawing.Size(55, 17);
            this.rd_sites.TabIndex = 9;
            this.rd_sites.TabStop = true;
            this.rd_sites.Text = "Sites";
            this.rd_sites.UseVisualStyleBackColor = true;
            this.rd_sites.CheckedChanged += new System.EventHandler(this.rd_sites_CheckedChanged);
            // 
            // lbl_hostname
            // 
            this.lbl_hostname.AutoSize = true;
            this.lbl_hostname.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hostname.Location = new System.Drawing.Point(101, 33);
            this.lbl_hostname.Name = "lbl_hostname";
            this.lbl_hostname.Size = new System.Drawing.Size(90, 19);
            this.lbl_hostname.TabIndex = 8;
            this.lbl_hostname.Text = "localhost";
            // 
            // btn_ObtenerInformacion
            // 
            this.btn_ObtenerInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ObtenerInformacion.Location = new System.Drawing.Point(19, 92);
            this.btn_ObtenerInformacion.Name = "btn_ObtenerInformacion";
            this.btn_ObtenerInformacion.Size = new System.Drawing.Size(147, 38);
            this.btn_ObtenerInformacion.TabIndex = 3;
            this.btn_ObtenerInformacion.Text = "Obtener Información";
            this.btn_ObtenerInformacion.UseVisualStyleBackColor = true;
            this.btn_ObtenerInformacion.Click += new System.EventHandler(this.btn_ObtenerInformacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servidor: ";
            // 
            // btn_detectar
            // 
            this.btn_detectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detectar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detectar.Location = new System.Drawing.Point(29, 37);
            this.btn_detectar.Name = "btn_detectar";
            this.btn_detectar.Size = new System.Drawing.Size(134, 40);
            this.btn_detectar.TabIndex = 7;
            this.btn_detectar.Text = "Detectar IIS";
            this.btn_detectar.UseVisualStyleBackColor = true;
            this.btn_detectar.Click += new System.EventHandler(this.btn_detectar_Click);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(479, 750);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(180, 19);
            this.lbl_mensaje.TabIndex = 10;
            this.lbl_mensaje.Text = "Exportanto archivos";
            // 
            // Exportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1128, 838);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.gb_InfoIIS);
            this.Controls.Add(this.gb_Accion);
            this.Controls.Add(this.btn_detectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar";
            this.gb_InfoIIS.ResumeLayout(false);
            this.gb_InfoIIS.PerformLayout();
            this.gb_Accion.ResumeLayout(false);
            this.gb_Accion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_InfoIIS;
        private System.Windows.Forms.TreeView tv_datos;
        private System.Windows.Forms.GroupBox gb_Accion;
        private System.Windows.Forms.RadioButton rd_todo;
        private System.Windows.Forms.RadioButton rd_pools;
        private System.Windows.Forms.RadioButton rd_apps;
        private System.Windows.Forms.RadioButton rd_sites;
        private System.Windows.Forms.Label lbl_hostname;
        private System.Windows.Forms.Button btn_ObtenerInformacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_detectar;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.TreeView tv_destino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mensaje;
    }
}