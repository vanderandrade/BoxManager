namespace BoxManager.View
{
    partial class Box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Box));
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.Grp_Box_Basics = new System.Windows.Forms.GroupBox();
            this.Txt_Label = new System.Windows.Forms.TextBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Lbl_MaximumWeight = new System.Windows.Forms.Label();
            this.Lbl_Label = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Lbl_MaximumWeight_Unit = new System.Windows.Forms.Label();
            this.Num_MaximumWeight = new System.Windows.Forms.NumericUpDown();
            this.Grp_Box_Basics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_MaximumWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(395, 124);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 29);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(501, 124);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(100, 29);
            this.Btn_Confirm.TabIndex = 6;
            this.Btn_Confirm.Text = "Confirm";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Grp_Box_Basics
            // 
            this.Grp_Box_Basics.Controls.Add(this.Num_MaximumWeight);
            this.Grp_Box_Basics.Controls.Add(this.Lbl_MaximumWeight_Unit);
            this.Grp_Box_Basics.Controls.Add(this.Txt_Label);
            this.Grp_Box_Basics.Controls.Add(this.Txt_Id);
            this.Grp_Box_Basics.Controls.Add(this.Lbl_MaximumWeight);
            this.Grp_Box_Basics.Controls.Add(this.Lbl_Label);
            this.Grp_Box_Basics.Controls.Add(this.Lbl_Id);
            this.Grp_Box_Basics.Location = new System.Drawing.Point(12, 12);
            this.Grp_Box_Basics.Name = "Grp_Box_Basics";
            this.Grp_Box_Basics.Size = new System.Drawing.Size(589, 106);
            this.Grp_Box_Basics.TabIndex = 13;
            this.Grp_Box_Basics.TabStop = false;
            this.Grp_Box_Basics.Text = "Basic";
            // 
            // Txt_Label
            // 
            this.Txt_Label.Location = new System.Drawing.Point(141, 44);
            this.Txt_Label.MaxLength = 25;
            this.Txt_Label.Name = "Txt_Label";
            this.Txt_Label.Size = new System.Drawing.Size(269, 20);
            this.Txt_Label.TabIndex = 14;
            // 
            // Txt_Id
            // 
            this.Txt_Id.Enabled = false;
            this.Txt_Id.Location = new System.Drawing.Point(141, 18);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(53, 20);
            this.Txt_Id.TabIndex = 13;
            // 
            // Lbl_MaximumWeight
            // 
            this.Lbl_MaximumWeight.Location = new System.Drawing.Point(6, 68);
            this.Lbl_MaximumWeight.Name = "Lbl_MaximumWeight";
            this.Lbl_MaximumWeight.Size = new System.Drawing.Size(129, 22);
            this.Lbl_MaximumWeight.TabIndex = 12;
            this.Lbl_MaximumWeight.Text = "Maximum Weight:";
            this.Lbl_MaximumWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Label
            // 
            this.Lbl_Label.Location = new System.Drawing.Point(6, 42);
            this.Lbl_Label.Name = "Lbl_Label";
            this.Lbl_Label.Size = new System.Drawing.Size(129, 22);
            this.Lbl_Label.TabIndex = 11;
            this.Lbl_Label.Text = "Label:";
            this.Lbl_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.Location = new System.Drawing.Point(6, 16);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(129, 22);
            this.Lbl_Id.TabIndex = 10;
            this.Lbl_Id.Text = "Id:";
            this.Lbl_Id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_MaximumWeight_Unit
            // 
            this.Lbl_MaximumWeight_Unit.Location = new System.Drawing.Point(233, 68);
            this.Lbl_MaximumWeight_Unit.Name = "Lbl_MaximumWeight_Unit";
            this.Lbl_MaximumWeight_Unit.Size = new System.Drawing.Size(129, 22);
            this.Lbl_MaximumWeight_Unit.TabIndex = 16;
            this.Lbl_MaximumWeight_Unit.Text = "Unit(s)";
            this.Lbl_MaximumWeight_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_MaximumWeight
            // 
            this.Num_MaximumWeight.DecimalPlaces = 2;
            this.Num_MaximumWeight.Location = new System.Drawing.Point(141, 71);
            this.Num_MaximumWeight.Name = "Num_MaximumWeight";
            this.Num_MaximumWeight.Size = new System.Drawing.Size(86, 20);
            this.Num_MaximumWeight.TabIndex = 17;
            // 
            // Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 161);
            this.Controls.Add(this.Grp_Box_Basics);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Box";
            this.Load += new System.EventHandler(this.Box_Load);
            this.Grp_Box_Basics.ResumeLayout(false);
            this.Grp_Box_Basics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_MaximumWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.GroupBox Grp_Box_Basics;
        private System.Windows.Forms.Label Lbl_MaximumWeight_Unit;
        private System.Windows.Forms.TextBox Txt_Label;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label Lbl_MaximumWeight;
        private System.Windows.Forms.Label Lbl_Label;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.NumericUpDown Num_MaximumWeight;
    }
}