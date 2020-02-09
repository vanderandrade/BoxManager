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
            this.Num_MaximumWeight = new System.Windows.Forms.NumericUpDown();
            this.Lbl_MaximumWeight_Unit = new System.Windows.Forms.Label();
            this.Txt_Label = new System.Windows.Forms.TextBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Lbl_MaximumWeight = new System.Windows.Forms.Label();
            this.Lbl_Label = new System.Windows.Forms.Label();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Grp_Items = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_DeleteItem = new System.Windows.Forms.Button();
            this.Btn_AddItem = new System.Windows.Forms.Button();
            this.Dtg_Items = new System.Windows.Forms.DataGridView();
            this.Grp_Box_Basics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_MaximumWeight)).BeginInit();
            this.Grp_Items.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(530, 496);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(133, 36);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(671, 496);
            this.Btn_Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(133, 36);
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
            this.Grp_Box_Basics.Location = new System.Drawing.Point(16, 15);
            this.Grp_Box_Basics.Margin = new System.Windows.Forms.Padding(4);
            this.Grp_Box_Basics.Name = "Grp_Box_Basics";
            this.Grp_Box_Basics.Padding = new System.Windows.Forms.Padding(4);
            this.Grp_Box_Basics.Size = new System.Drawing.Size(785, 130);
            this.Grp_Box_Basics.TabIndex = 13;
            this.Grp_Box_Basics.TabStop = false;
            this.Grp_Box_Basics.Text = "Basic";
            // 
            // Num_MaximumWeight
            // 
            this.Num_MaximumWeight.DecimalPlaces = 2;
            this.Num_MaximumWeight.Location = new System.Drawing.Point(188, 87);
            this.Num_MaximumWeight.Margin = new System.Windows.Forms.Padding(4);
            this.Num_MaximumWeight.Name = "Num_MaximumWeight";
            this.Num_MaximumWeight.Size = new System.Drawing.Size(115, 22);
            this.Num_MaximumWeight.TabIndex = 17;
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
            // Txt_Label
            // 
            this.Txt_Label.Location = new System.Drawing.Point(188, 54);
            this.Txt_Label.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Label.MaxLength = 25;
            this.Txt_Label.Name = "Txt_Label";
            this.Txt_Label.Size = new System.Drawing.Size(357, 22);
            this.Txt_Label.TabIndex = 14;
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
            // Lbl_MaximumWeight
            // 
            this.Lbl_MaximumWeight.Location = new System.Drawing.Point(8, 84);
            this.Lbl_MaximumWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_MaximumWeight.Name = "Lbl_MaximumWeight";
            this.Lbl_MaximumWeight.Size = new System.Drawing.Size(172, 27);
            this.Lbl_MaximumWeight.TabIndex = 12;
            this.Lbl_MaximumWeight.Text = "Maximum Weight:";
            this.Lbl_MaximumWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Label
            // 
            this.Lbl_Label.Location = new System.Drawing.Point(8, 52);
            this.Lbl_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Label.Name = "Lbl_Label";
            this.Lbl_Label.Size = new System.Drawing.Size(172, 27);
            this.Lbl_Label.TabIndex = 11;
            this.Lbl_Label.Text = "Label:";
            this.Lbl_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // Grp_Items
            // 
            this.Grp_Items.Controls.Add(this.panel1);
            this.Grp_Items.Controls.Add(this.Dtg_Items);
            this.Grp_Items.Location = new System.Drawing.Point(16, 152);
            this.Grp_Items.Name = "Grp_Items";
            this.Grp_Items.Size = new System.Drawing.Size(785, 249);
            this.Grp_Items.TabIndex = 14;
            this.Grp_Items.TabStop = false;
            this.Grp_Items.Text = "Items";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_DeleteItem);
            this.panel1.Controls.Add(this.Btn_AddItem);
            this.panel1.Location = new System.Drawing.Point(6, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 43);
            this.panel1.TabIndex = 1;
            // 
            // Btn_DeleteItem
            // 
            this.Btn_DeleteItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_DeleteItem.Location = new System.Drawing.Point(647, 0);
            this.Btn_DeleteItem.Name = "Btn_DeleteItem";
            this.Btn_DeleteItem.Size = new System.Drawing.Size(63, 43);
            this.Btn_DeleteItem.TabIndex = 1;
            this.Btn_DeleteItem.Text = "Delete Item";
            this.Btn_DeleteItem.UseVisualStyleBackColor = true;
            // 
            // Btn_AddItem
            // 
            this.Btn_AddItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_AddItem.Location = new System.Drawing.Point(710, 0);
            this.Btn_AddItem.Name = "Btn_AddItem";
            this.Btn_AddItem.Size = new System.Drawing.Size(63, 43);
            this.Btn_AddItem.TabIndex = 0;
            this.Btn_AddItem.Text = "Add Item";
            this.Btn_AddItem.UseVisualStyleBackColor = true;
            this.Btn_AddItem.Click += new System.EventHandler(this.Btn_AddItem_Click);
            // 
            // Dtg_Items
            // 
            this.Dtg_Items.AllowUserToAddRows = false;
            this.Dtg_Items.AllowUserToDeleteRows = false;
            this.Dtg_Items.AllowUserToResizeColumns = false;
            this.Dtg_Items.AllowUserToResizeRows = false;
            this.Dtg_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtg_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Items.Location = new System.Drawing.Point(6, 21);
            this.Dtg_Items.MultiSelect = false;
            this.Dtg_Items.Name = "Dtg_Items";
            this.Dtg_Items.ReadOnly = true;
            this.Dtg_Items.RowHeadersVisible = false;
            this.Dtg_Items.RowHeadersWidth = 51;
            this.Dtg_Items.RowTemplate.Height = 24;
            this.Dtg_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Items.Size = new System.Drawing.Size(773, 146);
            this.Dtg_Items.TabIndex = 0;
            // 
            // Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 545);
            this.Controls.Add(this.Grp_Items);
            this.Controls.Add(this.Grp_Box_Basics);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Box";
            this.Load += new System.EventHandler(this.Box_Load);
            this.Grp_Box_Basics.ResumeLayout(false);
            this.Grp_Box_Basics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_MaximumWeight)).EndInit();
            this.Grp_Items.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Items)).EndInit();
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
        private System.Windows.Forms.GroupBox Grp_Items;
        private System.Windows.Forms.DataGridView Dtg_Items;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_DeleteItem;
        private System.Windows.Forms.Button Btn_AddItem;
    }
}