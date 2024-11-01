namespace Borrador_1.Formularios
{
    partial class FrmCustomer
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
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCostumer = new System.Windows.Forms.Button();
            this.btnDeleteCostumer = new System.Windows.Forms.Button();
            this.dgvCostumer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackCustomerToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Location = new System.Drawing.Point(36, 21);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(166, 46);
            this.BtnAddCustomer.TabIndex = 0;
            this.BtnAddCustomer.Text = "Agregar";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnEditCostumer
            // 
            this.btnEditCostumer.Location = new System.Drawing.Point(36, 101);
            this.btnEditCostumer.Name = "btnEditCostumer";
            this.btnEditCostumer.Size = new System.Drawing.Size(166, 46);
            this.btnEditCostumer.TabIndex = 1;
            this.btnEditCostumer.Text = "Editar";
            this.btnEditCostumer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCostumer
            // 
            this.btnDeleteCostumer.Location = new System.Drawing.Point(36, 181);
            this.btnDeleteCostumer.Name = "btnDeleteCostumer";
            this.btnDeleteCostumer.Size = new System.Drawing.Size(166, 46);
            this.btnDeleteCostumer.TabIndex = 2;
            this.btnDeleteCostumer.Text = "Eliminar";
            this.btnDeleteCostumer.UseVisualStyleBackColor = true;
            // 
            // dgvCostumer
            // 
            this.dgvCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostumer.Location = new System.Drawing.Point(371, 102);
            this.dgvCostumer.Name = "dgvCostumer";
            this.dgvCostumer.RowHeadersWidth = 51;
            this.dgvCostumer.RowTemplate.Height = 24;
            this.dgvCostumer.Size = new System.Drawing.Size(415, 310);
            this.dgvCostumer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestion de clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddCustomer);
            this.groupBox1.Controls.Add(this.btnDeleteCostumer);
            this.groupBox1.Controls.Add(this.btnEditCostumer);
            this.groupBox1.Location = new System.Drawing.Point(100, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(239, 310);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opcion";
            // 
            // btnBackCustomerToMain
            // 
            this.btnBackCustomerToMain.Location = new System.Drawing.Point(679, 18);
            this.btnBackCustomerToMain.Name = "btnBackCustomerToMain";
            this.btnBackCustomerToMain.Size = new System.Drawing.Size(107, 45);
            this.btnBackCustomerToMain.TabIndex = 6;
            this.btnBackCustomerToMain.Text = "Regresar al menu principal";
            this.btnBackCustomerToMain.UseVisualStyleBackColor = true;
            this.btnBackCustomerToMain.Click += new System.EventHandler(this.btnBackCustomerToMain_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 477);
            this.Controls.Add(this.btnBackCustomerToMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCostumer);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostumer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Button btnEditCostumer;
        private System.Windows.Forms.Button btnDeleteCostumer;
        private System.Windows.Forms.DataGridView dgvCostumer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackCustomerToMain;
    }
}