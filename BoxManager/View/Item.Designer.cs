namespace BoxManager.View
{
    partial class Item
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
            this.Grp_Box_Basics = new System.Windows.Forms.GroupBox();
            this.Num_Weight = new System.Windows.Forms.NumericUpDown();
            this.Lbl_MaximumWeight_Unit = new System.Windows.Forms.Label();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Lbl_Weight = new System.Windows.Forms.Label();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Lbl_BoxDescription = new System.Windows.Forms.Label();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Grp_Box_Basics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Weight)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_Box_Basics
            // 
            this.Grp_Box_Basics.Controls.Add(this.Lbl_BoxDescription);
            this.Grp_Box_Basics.Controls.Add(this.Num_Weight);
            this.Grp_Box_Basics.Controls.Add(this.Lbl_MaximumWeight_Unit);
            this.Grp_Box_Basics.Controls.Add(this.Txt_Description);
            this.Grp_Box_Basics.Controls.Add(this.Txt_Id);
            this.Grp_Box_Basics.Controls.Add(this.Lbl_Weight);
            this.Grp_Box_Basics.Controls.Add(this.Lbl_Description);
            this.Grp_Box_Basics.Controls.Add(this.Lbl_Id);
            this.Grp_Box_Basics.Location = new System.Drawing.Point(8, 13);
            this.Grp_Box_Basics.Margin = new System.Windows.Forms.Padding(4);
            this.Grp_Box_Basics.Name = "Grp_Box_Basics";
            this.Grp_Box_Basics.Padding = new System.Windows.Forms.Padding(4);
            this.Grp_Box_Basics.Size = new System.Drawing.Size(785, 149);
            this.Grp_Box_Basics.TabIndex = 14;
            this.Grp_Box_Basics.TabStop = false;
            // 
            // Num_Weight
            // 
            this.Num_Weight.DecimalPlaces = 2;
            this.Num_Weight.Location = new System.Drawing.Point(188, 87);
            this.Num_Weight.Margin = new System.Windows.Forms.Padding(4);
            this.Num_Weight.Name = "Num_Weight";
            this.Num_Weight.Size = new System.Drawing.Size(115, 22);
            this.Num_Weight.TabIndex = 17;
            // 
            // Lbl_MaximumWeight_Unit
            // 
            this.Lbl_MaximumWeight_Unit.Location = new System.Drawing.Point(311, 84);
            this.Lbl_MaximumWeight_Unit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_MaximumWeight_Unit.Name = "Lbl_MaximumWeight_Unit";
            this.Lbl_MaximumWeight_Unit.Size = new System.Drawing.Size(172, 27);
            this.Lbl_MaximumWeight_Unit.TabIndex = 16;
            this.Lbl_MaximumWeight_Unit.Text = "Unit(s)";
            this.Lbl_MaximumWeight_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Description
            // 
            this.Txt_Description.Location = new System.Drawing.Point(188, 54);
            this.Txt_Description.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Description.MaxLength = 40;
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new System.Drawing.Size(302, 22);
            this.Txt_Description.TabIndex = 14;
            // 
            // Txt_Id
            // 
            this.Txt_Id.Enabled = false;
            this.Txt_Id.Location = new System.Drawing.Point(188, 22);
            this.Txt_Id.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(69, 22);
            this.Txt_Id.TabIndex = 13;
            // 
            // Lbl_Weight
            // 
            this.Lbl_Weight.Location = new System.Drawing.Point(8, 84);
            this.Lbl_Weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Weight.Name = "Lbl_Weight";
            this.Lbl_Weight.Size = new System.Drawing.Size(172, 27);
            this.Lbl_Weight.TabIndex = 12;
            this.Lbl_Weight.Text = "Weight:";
            this.Lbl_Weight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.Location = new System.Drawing.Point(8, 52);
            this.Lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(172, 27);
            this.Lbl_Description.TabIndex = 11;
            this.Lbl_Description.Text = "Description:";
            this.Lbl_Description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.Location = new System.Drawing.Point(8, 20);
            this.Lbl_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(172, 27);
            this.Lbl_Id.TabIndex = 10;
            this.Lbl_Id.Text = "Id:";
            this.Lbl_Id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_BoxDescription
            // 
            this.Lbl_BoxDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_BoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BoxDescription.ForeColor = System.Drawing.Color.Gray;
            this.Lbl_BoxDescription.Location = new System.Drawing.Point(4, 125);
            this.Lbl_BoxDescription.Name = "Lbl_BoxDescription";
            this.Lbl_BoxDescription.Size = new System.Drawing.Size(777, 20);
            this.Lbl_BoxDescription.TabIndex = 19;
            this.Lbl_BoxDescription.Text = "*Box";
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(660, 170);
            this.Btn_Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(133, 36);
            this.Btn_Confirm.TabIndex = 16;
            this.Btn_Confirm.Text = "Confirm";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(519, 170);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(133, 36);
            this.Btn_Cancel.TabIndex = 15;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 215);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Grp_Box_Basics);
            this.Name = "Item";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.Grp_Box_Basics.ResumeLayout(false);
            this.Grp_Box_Basics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Weight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_Box_Basics;
        private System.Windows.Forms.NumericUpDown Num_Weight;
        private System.Windows.Forms.Label Lbl_MaximumWeight_Unit;
        private System.Windows.Forms.TextBox Txt_Description;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label Lbl_Weight;
        private System.Windows.Forms.Label Lbl_Description;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label Lbl_BoxDescription;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}