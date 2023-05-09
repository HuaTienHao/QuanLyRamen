namespace QLCuaHangRamen
{
    partial class fRemoveFood
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
            this.cbRemoveName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveFood = new System.Windows.Forms.Button();
            this.cbRemoveCategory = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbRemoveName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnRemoveFood);
            this.panel3.Controls.Add(this.cbRemoveCategory);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 77);
            this.panel3.TabIndex = 9;
            // 
            // cbRemoveName
            // 
            this.cbRemoveName.FormattingEnabled = true;
            this.cbRemoveName.Location = new System.Drawing.Point(85, 39);
            this.cbRemoveName.Name = "cbRemoveName";
            this.cbRemoveName.Size = new System.Drawing.Size(214, 23);
            this.cbRemoveName.TabIndex = 6;
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
            // btnRemoveFood
            // 
            this.btnRemoveFood.Location = new System.Drawing.Point(305, 10);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(62, 52);
            this.btnRemoveFood.TabIndex = 2;
            this.btnRemoveFood.Text = "Remove";
            this.btnRemoveFood.UseVisualStyleBackColor = true;
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);
            // 
            // cbRemoveCategory
            // 
            this.cbRemoveCategory.FormattingEnabled = true;
            this.cbRemoveCategory.Location = new System.Drawing.Point(85, 6);
            this.cbRemoveCategory.Name = "cbRemoveCategory";
            this.cbRemoveCategory.Size = new System.Drawing.Size(214, 23);
            this.cbRemoveCategory.TabIndex = 0;
            this.cbRemoveCategory.SelectedIndexChanged += new System.EventHandler(this.cbRemoveCategory_SelectedIndexChanged);
            // 
            // fRemoveFood
            // 
            this.AcceptButton = this.btnRemoveFood;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 100);
            this.Controls.Add(this.panel3);
            this.Name = "fRemoveFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Food";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Label label2;
        private Label label1;
        private Button btnRemoveFood;
        private ComboBox cbRemoveCategory;
        private ComboBox cbRemoveName;
    }
}