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
            this.dgvHectareas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHectareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHectareas
            // 
            this.dgvHectareas.AllowUserToAddRows = false;
            this.dgvHectareas.AllowUserToDeleteRows = false;
            this.dgvHectareas.AllowUserToOrderColumns = true;
            this.dgvHectareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHectareas.Location = new System.Drawing.Point(12, 24);
            this.dgvHectareas.Name = "dgvHectareas";
            this.dgvHectareas.ReadOnly = true;
            this.dgvHectareas.Size = new System.Drawing.Size(763, 390);
            this.dgvHectareas.TabIndex = 0;
            // 
            // Hectareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHectareas);
            this.Name = "Hectareas";
            this.Text = "Hectareas";
            this.Load += new System.EventHandler(this.Hectareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHectareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHectareas;
    }
}