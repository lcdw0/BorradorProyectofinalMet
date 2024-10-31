namespace Borrador_1.Formularios
{
    partial class FrmOrder
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
            this.dgvCostumer = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCostumer = new System.Windows.Forms.Button();
            this.btnEditCostumer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCostumer
            // 
            this.dgvCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostumer.Location = new System.Drawing.Point(417, 128);
            this.dgvCostumer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCostumer.Name = "dgvCostumer";
            this.dgvCostumer.RowHeadersWidth = 51;
            this.dgvCostumer.RowTemplate.Height = 24;
            this.dgvCostumer.Size = new System.Drawing.Size(467, 387);
            this.dgvCostumer.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddCustomer);
            this.groupBox1.Controls.Add(this.btnDeleteCostumer);
            this.groupBox1.Controls.Add(this.btnEditCostumer);
            this.groupBox1.Location = new System.Drawing.Point(112, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 387);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Location = new System.Drawing.Point(40, 26);
            this.BtnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(187, 58);
            this.BtnAddCustomer.TabIndex = 0;
            this.BtnAddCustomer.Text = "Agregar";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCostumer
            // 
            this.btnDeleteCostumer.Location = new System.Drawing.Point(40, 226);
            this.btnDeleteCostumer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteCostumer.Name = "btnDeleteCostumer";
            this.btnDeleteCostumer.Size = new System.Drawing.Size(187, 58);
            this.btnDeleteCostumer.TabIndex = 2;
            this.btnDeleteCostumer.Text = "Eliminar";
            this.btnDeleteCostumer.UseVisualStyleBackColor = true;
            // 
            // btnEditCostumer
            // 
            this.btnEditCostumer.Location = new System.Drawing.Point(40, 126);
            this.btnEditCostumer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditCostumer.Name = "btnEditCostumer";
            this.btnEditCostumer.Size = new System.Drawing.Size(187, 58);
            this.btnEditCostumer.TabIndex = 1;
            this.btnEditCostumer.Text = "Editar";
            this.btnEditCostumer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestion de ordenes";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCostumer);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCostumer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCostumer;
        private System.Windows.Forms.Button btnEditCostumer;
        private System.Windows.Forms.Label label1;
    }
}