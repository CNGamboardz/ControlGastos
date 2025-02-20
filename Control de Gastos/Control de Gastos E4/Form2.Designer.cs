namespace Control_de_Gastos_E4
{
    partial class Eliminar_transacciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.costo_B1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Fecha1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mostrar_Datos = new System.Windows.Forms.DataGridView();
            this.regresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id_importe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 99);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Transacciones";
            // 
            // costo_B1
            // 
            this.costo_B1.ForeColor = System.Drawing.Color.Black;
            this.costo_B1.Location = new System.Drawing.Point(130, 232);
            this.costo_B1.Margin = new System.Windows.Forms.Padding(4);
            this.costo_B1.Name = "costo_B1";
            this.costo_B1.Size = new System.Drawing.Size(148, 22);
            this.costo_B1.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 389);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // Fecha1
            // 
            this.Fecha1.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.Fecha1.Location = new System.Drawing.Point(116, 305);
            this.Fecha1.Margin = new System.Windows.Forms.Padding(4);
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.Size = new System.Drawing.Size(298, 22);
            this.Fecha1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Costo:";
            // 
            // Mostrar_Datos
            // 
            this.Mostrar_Datos.BackgroundColor = System.Drawing.Color.White;
            this.Mostrar_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mostrar_Datos.Location = new System.Drawing.Point(444, 133);
            this.Mostrar_Datos.Name = "Mostrar_Datos";
            this.Mostrar_Datos.RowHeadersWidth = 51;
            this.Mostrar_Datos.RowTemplate.Height = 24;
            this.Mostrar_Datos.Size = new System.Drawing.Size(746, 509);
            this.Mostrar_Datos.TabIndex = 16;
            this.Mostrar_Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mostrar_Datos_CellClick);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ForeColor = System.Drawing.Color.White;
            this.regresar.Location = new System.Drawing.Point(12, 479);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(140, 42);
            this.regresar.TabIndex = 17;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(249, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_importe
            // 
            this.id_importe.ForeColor = System.Drawing.Color.Black;
            this.id_importe.Location = new System.Drawing.Point(160, 174);
            this.id_importe.Margin = new System.Windows.Forms.Padding(4);
            this.id_importe.Name = "id_importe";
            this.id_importe.Size = new System.Drawing.Size(101, 22);
            this.id_importe.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id_Importe:";
            // 
            // Eliminar_transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 677);
            this.Controls.Add(this.id_importe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.Mostrar_Datos);
            this.Controls.Add(this.costo_B1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Fecha1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Eliminar_transacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Transacciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costo_B1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker Fecha1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Mostrar_Datos;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id_importe;
        private System.Windows.Forms.Label label2;
    }
}