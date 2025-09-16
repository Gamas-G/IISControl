namespace IISControl
{
    partial class IISControlForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_Importar = new System.Windows.Forms.RadioButton();
            this.rd_exportar = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_Importar);
            this.panel1.Controls.Add(this.rd_exportar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 40);
            this.panel1.TabIndex = 4;
            // 
            // rd_Importar
            // 
            this.rd_Importar.AutoSize = true;
            this.rd_Importar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_Importar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Importar.ForeColor = System.Drawing.Color.White;
            this.rd_Importar.Location = new System.Drawing.Point(146, 12);
            this.rd_Importar.Name = "rd_Importar";
            this.rd_Importar.Size = new System.Drawing.Size(81, 19);
            this.rd_Importar.TabIndex = 5;
            this.rd_Importar.TabStop = true;
            this.rd_Importar.Text = "Importar";
            this.rd_Importar.UseVisualStyleBackColor = true;
            this.rd_Importar.CheckedChanged += new System.EventHandler(this.rd_Importar_CheckedChanged);
            // 
            // rd_exportar
            // 
            this.rd_exportar.AutoSize = true;
            this.rd_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_exportar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_exportar.ForeColor = System.Drawing.Color.White;
            this.rd_exportar.Location = new System.Drawing.Point(26, 12);
            this.rd_exportar.Name = "rd_exportar";
            this.rd_exportar.Size = new System.Drawing.Size(81, 19);
            this.rd_exportar.TabIndex = 4;
            this.rd_exportar.TabStop = true;
            this.rd_exportar.Text = "Exportar";
            this.rd_exportar.UseVisualStyleBackColor = true;
            this.rd_exportar.CheckedChanged += new System.EventHandler(this.rd_exportar_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnl_contenedor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 871);
            this.panel3.TabIndex = 6;
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenedor.Location = new System.Drawing.Point(0, 0);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(1128, 871);
            this.pnl_contenedor.TabIndex = 6;
            // 
            // IISControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1128, 911);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IISControlForm";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rd_Importar;
        private System.Windows.Forms.RadioButton rd_exportar;
        private System.Windows.Forms.Panel pnl_contenedor;
    }
}

