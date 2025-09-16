namespace IISControl.Vistas
{
    partial class lbl_statusApps
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
            this.txt_pathDirectory = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_fileDialog = new System.Windows.Forms.Button();
            this.btn_importar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_Pools = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_Sites = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox_Apps = new System.Windows.Forms.ListBox();
            this.lbl_statusPools = new System.Windows.Forms.Label();
            this.lbl_statusSites = new System.Windows.Forms.Label();
            this.lbl_apps = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMPORTAR";
            // 
            // txt_pathDirectory
            // 
            this.txt_pathDirectory.Location = new System.Drawing.Point(20, 51);
            this.txt_pathDirectory.Name = "txt_pathDirectory";
            this.txt_pathDirectory.Size = new System.Drawing.Size(223, 20);
            this.txt_pathDirectory.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lbl.Location = new System.Drawing.Point(17, 26);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(45, 19);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Ruta";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_fileDialog
            // 
            this.btn_fileDialog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btn_fileDialog.Location = new System.Drawing.Point(261, 45);
            this.btn_fileDialog.Name = "btn_fileDialog";
            this.btn_fileDialog.Size = new System.Drawing.Size(77, 31);
            this.btn_fileDialog.TabIndex = 3;
            this.btn_fileDialog.Text = "Buscar";
            this.btn_fileDialog.UseVisualStyleBackColor = true;
            this.btn_fileDialog.Click += new System.EventHandler(this.btn_fileDialog_Click);
            // 
            // btn_importar
            // 
            this.btn_importar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btn_importar.Location = new System.Drawing.Point(20, 93);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(147, 41);
            this.btn_importar.TabIndex = 4;
            this.btn_importar.Text = "Importar";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btn_importar);
            this.groupBox1.Controls.Add(this.btn_fileDialog);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.txt_pathDirectory);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(55, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 158);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dato";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.listBox_Pools);
            this.groupBox2.Location = new System.Drawing.Point(56, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 148);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "POOLS";
            // 
            // listBox_Pools
            // 
            this.listBox_Pools.BackColor = System.Drawing.Color.Silver;
            this.listBox_Pools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Pools.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Pools.FormattingEnabled = true;
            this.listBox_Pools.ItemHeight = 15;
            this.listBox_Pools.Location = new System.Drawing.Point(3, 16);
            this.listBox_Pools.Name = "listBox_Pools";
            this.listBox_Pools.Size = new System.Drawing.Size(651, 129);
            this.listBox_Pools.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.listBox_Sites);
            this.groupBox3.Location = new System.Drawing.Point(55, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 148);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SITES";
            // 
            // listBox_Sites
            // 
            this.listBox_Sites.BackColor = System.Drawing.Color.Silver;
            this.listBox_Sites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Sites.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox_Sites.FormattingEnabled = true;
            this.listBox_Sites.ItemHeight = 15;
            this.listBox_Sites.Location = new System.Drawing.Point(3, 16);
            this.listBox_Sites.Name = "listBox_Sites";
            this.listBox_Sites.Size = new System.Drawing.Size(651, 129);
            this.listBox_Sites.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Controls.Add(this.listBox_Apps);
            this.groupBox4.Location = new System.Drawing.Point(55, 614);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(657, 148);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "APPS";
            // 
            // listBox_Apps
            // 
            this.listBox_Apps.BackColor = System.Drawing.Color.Silver;
            this.listBox_Apps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Apps.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox_Apps.FormattingEnabled = true;
            this.listBox_Apps.ItemHeight = 15;
            this.listBox_Apps.Location = new System.Drawing.Point(3, 16);
            this.listBox_Apps.Name = "listBox_Apps";
            this.listBox_Apps.Size = new System.Drawing.Size(651, 129);
            this.listBox_Apps.TabIndex = 0;
            // 
            // lbl_statusPools
            // 
            this.lbl_statusPools.AutoSize = true;
            this.lbl_statusPools.Location = new System.Drawing.Point(720, 279);
            this.lbl_statusPools.Name = "lbl_statusPools";
            this.lbl_statusPools.Size = new System.Drawing.Size(35, 13);
            this.lbl_statusPools.TabIndex = 9;
            this.lbl_statusPools.Text = "label2";
            // 
            // lbl_statusSites
            // 
            this.lbl_statusSites.AutoSize = true;
            this.lbl_statusSites.Location = new System.Drawing.Point(720, 455);
            this.lbl_statusSites.Name = "lbl_statusSites";
            this.lbl_statusSites.Size = new System.Drawing.Size(35, 13);
            this.lbl_statusSites.TabIndex = 10;
            this.lbl_statusSites.Text = "label3";
            // 
            // lbl_apps
            // 
            this.lbl_apps.AutoSize = true;
            this.lbl_apps.Location = new System.Drawing.Point(720, 656);
            this.lbl_apps.Name = "lbl_apps";
            this.lbl_apps.Size = new System.Drawing.Size(35, 13);
            this.lbl_apps.TabIndex = 11;
            this.lbl_apps.Text = "label4";
            // 
            // lbl_statusApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 838);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_apps);
            this.Controls.Add(this.lbl_statusSites);
            this.Controls.Add(this.lbl_statusPools);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lbl_statusApps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Importar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pathDirectory;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_fileDialog;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox_Pools;
        private System.Windows.Forms.ListBox listBox_Sites;
        private System.Windows.Forms.ListBox listBox_Apps;
        private System.Windows.Forms.Label lbl_statusPools;
        private System.Windows.Forms.Label lbl_statusSites;
        private System.Windows.Forms.Label lbl_apps;
    }
}