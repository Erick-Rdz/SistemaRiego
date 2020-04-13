namespace Sistema_de_riego
{
    partial class Hectareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hectareas));
            this.dgvHectareas = new System.Windows.Forms.DataGridView();
            this.cantcos_txt = new System.Windows.Forms.TextBox();
            this.cantarbo_txt = new System.Windows.Forms.TextBox();
            this.tipocult_txt = new System.Windows.Forms.TextBox();
            this.numhect_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insert_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHectareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHectareas
            // 
            this.dgvHectareas.AllowUserToAddRows = false;
            this.dgvHectareas.AllowUserToDeleteRows = false;
            this.dgvHectareas.AllowUserToOrderColumns = true;
            this.dgvHectareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHectareas.Location = new System.Drawing.Point(217, 95);
            this.dgvHectareas.Name = "dgvHectareas";
            this.dgvHectareas.ReadOnly = true;
            this.dgvHectareas.Size = new System.Drawing.Size(547, 281);
            this.dgvHectareas.TabIndex = 0;
            this.dgvHectareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHectareas_CellContentClick);
            // 
            // cantcos_txt
            // 
            this.cantcos_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantcos_txt.Location = new System.Drawing.Point(27, 337);
            this.cantcos_txt.Name = "cantcos_txt";
            this.cantcos_txt.Size = new System.Drawing.Size(141, 22);
            this.cantcos_txt.TabIndex = 22;
            // 
            // cantarbo_txt
            // 
            this.cantarbo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantarbo_txt.Location = new System.Drawing.Point(27, 267);
            this.cantarbo_txt.Name = "cantarbo_txt";
            this.cantarbo_txt.Size = new System.Drawing.Size(141, 22);
            this.cantarbo_txt.TabIndex = 21;
            // 
            // tipocult_txt
            // 
            this.tipocult_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipocult_txt.Location = new System.Drawing.Point(27, 186);
            this.tipocult_txt.Name = "tipocult_txt";
            this.tipocult_txt.Size = new System.Drawing.Size(141, 22);
            this.tipocult_txt.TabIndex = 20;
            // 
            // numhect_txt
            // 
            this.numhect_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numhect_txt.Location = new System.Drawing.Point(27, 113);
            this.numhect_txt.Name = "numhect_txt";
            this.numhect_txt.Size = new System.Drawing.Size(141, 22);
            this.numhect_txt.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cantidad de cosecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad de arboles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo de cultivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Numero de hectarea:";
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(478, 400);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(91, 24);
            this.insert_btn.TabIndex = 26;
            this.insert_btn.Text = "INSERT";
            this.insert_btn.UseVisualStyleBackColor = false;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(347, 401);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(95, 24);
            this.delete_btn.TabIndex = 25;
            this.delete_btn.Text = "ELIMINAR";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(227, 399);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(89, 26);
            this.update_btn.TabIndex = 24;
            this.update_btn.Text = "ACTUALIZAR";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Buscar:";
            // 
            // buscar_txt
            // 
            this.buscar_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_txt.Location = new System.Drawing.Point(277, 52);
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(413, 22);
            this.buscar_txt.TabIndex = 29;
            this.buscar_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buscar_txt_KeyUp);
            // 
            // Hectareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.buscar_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.cantcos_txt);
            this.Controls.Add(this.cantarbo_txt);
            this.Controls.Add(this.tipocult_txt);
            this.Controls.Add(this.numhect_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHectareas);
            this.Name = "Hectareas";
            this.Text = "Hectareas";
            this.Load += new System.EventHandler(this.Hectareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHectareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHectareas;
        private System.Windows.Forms.TextBox cantcos_txt;
        private System.Windows.Forms.TextBox cantarbo_txt;
        private System.Windows.Forms.TextBox tipocult_txt;
        private System.Windows.Forms.TextBox numhect_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscar_txt;
    }
}