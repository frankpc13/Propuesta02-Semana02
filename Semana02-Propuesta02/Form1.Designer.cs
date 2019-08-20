namespace Semana02_Propuesta02
{
    partial class Form1
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
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalOrders = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridOrderDetail = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalProducts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de pedidos";
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.AllowUserToAddRows = false;
            this.dataGridOrders.AllowUserToDeleteRows = false;
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(12, 47);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.ReadOnly = true;
            this.dataGridOrders.RowTemplate.Height = 24;
            this.dataGridOrders.Size = new System.Drawing.Size(776, 189);
            this.dataGridOrders.TabIndex = 1;
            this.dataGridOrders.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridOrders_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(446, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(421, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total de pedidos";
            // 
            // labelTotalOrders
            // 
            this.labelTotalOrders.AutoSize = true;
            this.labelTotalOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalOrders.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold);
            this.labelTotalOrders.Location = new System.Drawing.Point(668, 239);
            this.labelTotalOrders.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelTotalOrders.Name = "labelTotalOrders";
            this.labelTotalOrders.Size = new System.Drawing.Size(120, 37);
            this.labelTotalOrders.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Detalle de pedido";
            // 
            // dataGridOrderDetail
            // 
            this.dataGridOrderDetail.AllowUserToAddRows = false;
            this.dataGridOrderDetail.AllowUserToDeleteRows = false;
            this.dataGridOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderDetail.Location = new System.Drawing.Point(12, 343);
            this.dataGridOrderDetail.Name = "dataGridOrderDetail";
            this.dataGridOrderDetail.ReadOnly = true;
            this.dataGridOrderDetail.RowTemplate.Height = 24;
            this.dataGridOrderDetail.Size = new System.Drawing.Size(776, 189);
            this.dataGridOrderDetail.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(421, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total de productos";
            // 
            // labelTotalProducts
            // 
            this.labelTotalProducts.AutoSize = true;
            this.labelTotalProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalProducts.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold);
            this.labelTotalProducts.Location = new System.Drawing.Point(668, 535);
            this.labelTotalProducts.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelTotalProducts.Name = "labelTotalProducts";
            this.labelTotalProducts.Size = new System.Drawing.Size(120, 37);
            this.labelTotalProducts.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.labelTotalProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridOrderDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotalOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridOrders);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridOrderDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalProducts;
    }
}

