namespace PrimerParcial
{
    partial class FmResumen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCantVenGen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblCantVenSuc = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblImporteGen = new System.Windows.Forms.Label();
            this.lblImporteSuc = new System.Windows.Forms.Label();
            this.lblPromedioGen = new System.Windows.Forms.Label();
            this.lblPromedioSuc = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblSucMax = new System.Windows.Forms.Label();
            this.lblSucMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado Ventas General";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(811, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblCantVenGen
            // 
            this.lblCantVenGen.AutoSize = true;
            this.lblCantVenGen.Location = new System.Drawing.Point(524, 36);
            this.lblCantVenGen.Name = "lblCantVenGen";
            this.lblCantVenGen.Size = new System.Drawing.Size(46, 17);
            this.lblCantVenGen.TabIndex = 2;
            this.lblCantVenGen.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar Sucursal";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 425);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(811, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // lblCantVenSuc
            // 
            this.lblCantVenSuc.AutoSize = true;
            this.lblCantVenSuc.Location = new System.Drawing.Point(524, 401);
            this.lblCantVenSuc.Name = "lblCantVenSuc";
            this.lblCantVenSuc.Size = new System.Drawing.Size(46, 17);
            this.lblCantVenSuc.TabIndex = 5;
            this.lblCantVenSuc.Text = "label2";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(121, 394);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(88, 26);
            this.btnVer.TabIndex = 7;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(15, 396);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(15, 281);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(555, 106);
            this.dataGridView3.TabIndex = 9;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // lblImporteGen
            // 
            this.lblImporteGen.AutoSize = true;
            this.lblImporteGen.Location = new System.Drawing.Point(524, 209);
            this.lblImporteGen.Name = "lblImporteGen";
            this.lblImporteGen.Size = new System.Drawing.Size(46, 17);
            this.lblImporteGen.TabIndex = 10;
            this.lblImporteGen.Text = "label3";
            // 
            // lblImporteSuc
            // 
            this.lblImporteSuc.AutoSize = true;
            this.lblImporteSuc.Location = new System.Drawing.Point(524, 578);
            this.lblImporteSuc.Name = "lblImporteSuc";
            this.lblImporteSuc.Size = new System.Drawing.Size(46, 17);
            this.lblImporteSuc.TabIndex = 11;
            this.lblImporteSuc.Text = "label4";
            // 
            // lblPromedioGen
            // 
            this.lblPromedioGen.AutoSize = true;
            this.lblPromedioGen.Location = new System.Drawing.Point(524, 238);
            this.lblPromedioGen.Name = "lblPromedioGen";
            this.lblPromedioGen.Size = new System.Drawing.Size(46, 17);
            this.lblPromedioGen.TabIndex = 12;
            this.lblPromedioGen.Text = "label3";
            // 
            // lblPromedioSuc
            // 
            this.lblPromedioSuc.AutoSize = true;
            this.lblPromedioSuc.Location = new System.Drawing.Point(524, 613);
            this.lblPromedioSuc.Name = "lblPromedioSuc";
            this.lblPromedioSuc.Size = new System.Drawing.Size(46, 17);
            this.lblPromedioSuc.TabIndex = 13;
            this.lblPromedioSuc.Text = "label4";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(730, 6);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(96, 47);
            this.btnInicio.TabIndex = 14;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblSucMax
            // 
            this.lblSucMax.AutoSize = true;
            this.lblSucMax.Location = new System.Drawing.Point(28, 578);
            this.lblSucMax.Name = "lblSucMax";
            this.lblSucMax.Size = new System.Drawing.Size(46, 17);
            this.lblSucMax.TabIndex = 15;
            this.lblSucMax.Text = "label3";
            // 
            // lblSucMin
            // 
            this.lblSucMin.AutoSize = true;
            this.lblSucMin.Location = new System.Drawing.Point(28, 613);
            this.lblSucMin.Name = "lblSucMin";
            this.lblSucMin.Size = new System.Drawing.Size(46, 17);
            this.lblSucMin.TabIndex = 16;
            this.lblSucMin.Text = "label4";
            // 
            // FmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 639);
            this.Controls.Add(this.lblSucMin);
            this.Controls.Add(this.lblSucMax);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lblPromedioSuc);
            this.Controls.Add(this.lblPromedioGen);
            this.Controls.Add(this.lblImporteSuc);
            this.Controls.Add(this.lblImporteGen);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblCantVenSuc);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantVenGen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FmResumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmResumen";
            this.Load += new System.EventHandler(this.FmResumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCantVenGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblCantVenSuc;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblImporteGen;
        private System.Windows.Forms.Label lblImporteSuc;
        private System.Windows.Forms.Label lblPromedioGen;
        private System.Windows.Forms.Label lblPromedioSuc;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblSucMax;
        private System.Windows.Forms.Label lblSucMin;
    }
}