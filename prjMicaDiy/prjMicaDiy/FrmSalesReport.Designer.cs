namespace prjMicaDiy
{
    partial class FrmSalesReport
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
            this.btnShowSales = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnShowSales
            // 
            this.btnShowSales.Location = new System.Drawing.Point(149, 306);
            this.btnShowSales.Name = "btnShowSales";
            this.btnShowSales.Size = new System.Drawing.Size(84, 31);
            this.btnShowSales.TabIndex = 1;
            this.btnShowSales.Text = "Show Sales";
            this.btnShowSales.UseVisualStyleBackColor = true;
            this.btnShowSales.Click += new System.EventHandler(this.btnShowSales_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(359, 288);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listViewSales_SelectedIndexChanged_1);
            // 
            // FrmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 385);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnShowSales);
            this.Name = "FrmSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowSales;
        private System.Windows.Forms.ListView listView1;
    }
}