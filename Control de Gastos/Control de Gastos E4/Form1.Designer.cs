namespace Control_de_Gastos_E4
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Control = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mas = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Text_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.suma_total = new System.Windows.Forms.TextBox();
            this.Total_Buscado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_Control);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 71);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(401, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_Control
            // 
            this.label_Control.AutoSize = true;
            this.label_Control.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Control.ForeColor = System.Drawing.Color.White;
            this.label_Control.Location = new System.Drawing.Point(462, 21);
            this.label_Control.Name = "label_Control";
            this.label_Control.Size = new System.Drawing.Size(258, 34);
            this.label_Control.TabIndex = 0;
            this.label_Control.Text = "Control de Gastos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Location = new System.Drawing.Point(-5, 599);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 50);
            this.panel2.TabIndex = 1;
            // 
            // mas
            // 
            this.mas.Image = ((System.Drawing.Image)(resources.GetObject("mas.Image")));
            this.mas.Location = new System.Drawing.Point(1103, 485);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(70, 61);
            this.mas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mas.TabIndex = 2;
            this.mas.TabStop = false;
            this.mas.Click += new System.EventHandler(this.mas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(979, 365);
            this.dataGridView1.TabIndex = 3;
            // 
            // Text_Buscar
            // 
            this.Text_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Buscar.Location = new System.Drawing.Point(260, 99);
            this.Text_Buscar.Name = "Text_Buscar";
            this.Text_Buscar.Size = new System.Drawing.Size(472, 27);
            this.Text_Buscar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "BUSCAR:";
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.InitialImage = null;
            this.Buscar.Location = new System.Drawing.Point(750, 92);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(42, 38);
            this.Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Buscar.TabIndex = 3;
            this.Buscar.TabStop = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "SUMA TOTAL:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // suma_total
            // 
            this.suma_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma_total.Location = new System.Drawing.Point(216, 540);
            this.suma_total.Name = "suma_total";
            this.suma_total.Size = new System.Drawing.Size(186, 28);
            this.suma_total.TabIndex = 7;
            // 
            // Total_Buscado
            // 
            this.Total_Buscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Buscado.ForeColor = System.Drawing.SystemColors.Window;
            this.Total_Buscado.Location = new System.Drawing.Point(750, 540);
            this.Total_Buscado.Name = "Total_Buscado";
            this.Total_Buscado.Size = new System.Drawing.Size(186, 28);
            this.Total_Buscado.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOTAL BUSCADO:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 647);
            this.Controls.Add(this.Total_Buscado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.suma_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Gastos";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Control;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox mas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Text_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox suma_total;
        private System.Windows.Forms.TextBox Total_Buscado;
        private System.Windows.Forms.Label label3;
    }
}

