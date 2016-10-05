namespace prjMicaDiy
{
    partial class FrmMicaDIY
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
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(79, 51);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(132, 39);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(79, 112);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(132, 42);
            this.btnSalesReport.TabIndex = 1;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // FrmMicaDIY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 217);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnProducts);
            this.Name = "FrmMicaDIY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mica DIY";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSalesReport;
    }
}