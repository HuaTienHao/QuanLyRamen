namespace QLCuaHangRamen
{
    partial class fAddFood
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbAddName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmAddPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbAddCategory = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbAddName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.nmAddPrice);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Controls.Add(this.cbAddCategory);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 96);
            this.panel3.TabIndex = 8;
            // 
            // txbAddName
            // 
            this.txbAddName.Location = new System.Drawing.Point(85, 39);
            this.txbAddName.Name = "txbAddName";
            this.txbAddName.Size = new System.Drawing.Size(214, 23);
            this.txbAddName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // nmAddPrice
            // 
            this.nmAddPrice.Location = new System.Drawing.Point(85, 68);
            this.nmAddPrice.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nmAddPrice.Name = "nmAddPrice";
            this.nmAddPrice.Size = new System.Drawing.Size(214, 23);
            this.nmAddPrice.TabIndex = 3;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(305, 23);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(62, 52);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Add";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbAddCategory
            // 
            this.cbAddCategory.FormattingEnabled = true;
            this.cbAddCategory.Location = new System.Drawing.Point(85, 6);
            this.cbAddCategory.Name = "cbAddCategory";
            this.cbAddCategory.Size = new System.Drawing.Size(214, 23);
            this.cbAddCategory.TabIndex = 0;
            // 
            // fAddFood
            // 
            this.AcceptButton = this.btnAddFood;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 120);
            this.Controls.Add(this.panel3);
            this.Name = "fAddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Food";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private NumericUpDown nmAddPrice;
        private Button btnAddFood;
        private ComboBox cbAddCategory;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txbAddName;
    }
}