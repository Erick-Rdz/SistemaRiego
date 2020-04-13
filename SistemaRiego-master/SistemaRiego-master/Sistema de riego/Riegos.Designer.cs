namespace Sistema_de_riego
{
    partial class Riegos
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
            this.dgvRiegos = new System.Windows.Forms.DataGridView();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hora_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpCargo_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Fert_txt = new System.Windows.Forms.TextBox();
            this.NumHect_txt = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiegos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRiegos
            // 
            this.dgvRiegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiegos.Location = new System.Drawing.Point(183, 90);
            this.dgvRiegos.Name = "dgvRiegos";
            this.dgvRiegos.Size = new System.Drawing.Size(589, 342);
            this.dgvRiegos.TabIndex = 0;
            // 
            // buscar_txt
            // 
            this.buscar_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_txt.Location = new System.Drawing.Point(340, 53);
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(357, 22);
            this.buscar_txt.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Buscar :";
            // 
            // Fecha_txt
            // 
            this.Fecha_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_txt.Location = new System.Drawing.Point(15, 150);
            this.Fecha_txt.Name = "Fecha_txt";
            this.Fecha_txt.Size = new System.Drawing.Size(141, 22);
            this.Fecha_txt.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Hora:";
            // 
            // Hora_txt
            // 
            this.Hora_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_txt.Location = new System.Drawing.Point(12, 205);
            this.Hora_txt.Name = "Hora_txt";
            this.Hora_txt.Size = new System.Drawing.Size(141, 22);
            this.Hora_txt.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Empleado a Cargo:";
            // 
            // EmpCargo_txt
            // 
            this.EmpCargo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpCargo_txt.Location = new System.Drawing.Point(12, 264);
            this.EmpCargo_txt.Name = "EmpCargo_txt";
            this.EmpCargo_txt.Size = new System.Drawing.Size(141, 22);
            this.EmpCargo_txt.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Fertilizante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Numero de Hectaria:";
            // 
            // Fert_txt
            // 
            this.Fert_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fert_txt.Location = new System.Drawing.Point(12, 323);
            this.Fert_txt.Name = "Fert_txt";
            this.Fert_txt.Size = new System.Drawing.Size(141, 22);
            this.Fert_txt.TabIndex = 42;
            // 
            // NumHect_txt
            // 
            this.NumHect_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumHect_txt.Location = new System.Drawing.Point(12, 375);
            this.NumHect_txt.Name = "NumHect_txt";
            this.NumHect_txt.Size = new System.Drawing.Size(141, 22);
            this.NumHect_txt.TabIndex = 43;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(248, 461);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(101, 26);
            this.update_btn.TabIndex = 44;
            this.update_btn.Text = "ACTUALIZAR";
            this.update_btn.UseVisualStyleBackColor = false;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(402, 463);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(95, 24);
            this.delete_btn.TabIndex = 45;
            this.delete_btn.Text = "ELIMINAR";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(557, 463);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(106, 24);
            this.insert_btn.TabIndex = 46;
            this.insert_btn.Text = "INSERTAR";
            this.insert_btn.UseVisualStyleBackColor = false;
            // 
            // Riegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 513);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.NumHect_txt);
            this.Controls.Add(this.Fert_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmpCargo_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hora_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fecha_txt);
            this.Controls.Add(this.buscar_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRiegos);
            this.Name = "Riegos";
            this.Text = "Riegos";
            this.Load += new System.EventHandler(this.Riegos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRiegos;
        private System.Windows.Forms.TextBox buscar_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fecha_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Hora_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmpCargo_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Fert_txt;
        private System.Windows.Forms.TextBox NumHect_txt;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button insert_btn;
    }
}