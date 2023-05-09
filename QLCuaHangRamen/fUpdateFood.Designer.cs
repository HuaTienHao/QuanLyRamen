namespace QLCuaHangRamen
{
    partial class fUpdateFood
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbSelectName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmUpdatePrice = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUpdateCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbUpdateName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpdatePrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbSelectName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbSelectCategory);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 121);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chose item you want to edit";
            // 
            // cbSelectName
            // 
            this.cbSelectName.FormattingEnabled = true;
            this.cbSelectName.Location = new System.Drawing.Point(84, 86);
            this.cbSelectName.Name = "cbSelectName";
            this.cbSelectName.Size = new System.Drawing.Size(214, 23);
            this.cbSelectName.TabIndex = 7;
            this.cbSelectName.SelectedIndexChanged += new System.EventHandler(this.cbSelectName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Location = new System.Drawing.Point(84, 53);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(214, 23);
            this.cbSelectCategory.TabIndex = 0;
            this.cbSelectCategory.SelectedIndexChanged += new System.EventHandler(this.cbSelectCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // nmUpdatePrice
            // 
            this.nmUpdatePrice.Location = new System.Drawing.Point(84, 136);
            this.nmUpdatePrice.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nmUpdatePrice.Name = "nmUpdatePrice";
            this.nmUpdatePrice.Size = new System.Drawing.Size(214, 23);
            this.nmUpdatePrice.TabIndex = 3;
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Location = new System.Drawing.Point(117, 3);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(85, 40);
            this.btnUpdateFood.TabIndex = 2;
            this.btnUpdateFood.Text = "Update";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbUpdateCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbUpdateName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nmUpdatePrice);
            this.panel1.Controls.Add(this.txbFoodID);
            this.panel1.Controls.Add(this.btnUpdateFood);
            this.panel1.Location = new System.Drawing.Point(12, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 172);
            this.panel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Category";
            // 
            // cbUpdateCategory
            // 
            this.cbUpdateCategory.FormattingEnabled = true;
            this.cbUpdateCategory.Location = new System.Drawing.Point(84, 78);
            this.cbUpdateCategory.Name = "cbUpdateCategory";
            this.cbUpdateCategory.Size = new System.Drawing.Size(214, 23);
            this.cbUpdateCategory.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // txbUpdateName
            // 
            this.txbUpdateName.Location = new System.Drawing.Point(84, 107);
            this.txbUpdateName.Name = "txbUpdateName";
            this.txbUpdateName.Size = new System.Drawing.Size(214, 23);
            this.txbUpdateName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID";
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(84, 49);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(214, 23);
            this.txbFoodID.TabIndex = 3;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // fUpdateFood
            // 
            this.AcceptButton = this.btnUpdateFood;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "fUpdateFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Food";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpdatePrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private ComboBox cbSelectName;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown nmUpdatePrice;
        private ComboBox cbSelectCategory;
        private Button btnUpdateFood;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private TextBox txbFoodID;
        private Label label7;
        private ComboBox cbUpdateCategory;
        private Label label6;
        private TextBox txbUpdateName;
    }
}