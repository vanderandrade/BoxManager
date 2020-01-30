namespace BoxManager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Pnl_Boxes = new System.Windows.Forms.Panel();
            this.Pnl_Boxes_Actions = new System.Windows.Forms.Panel();
            this.Btn_Boxes_DeleteBox = new System.Windows.Forms.Button();
            this.Btn_Boxes_InsertBox = new System.Windows.Forms.Button();
            this.Dtg_Boxes = new System.Windows.Forms.DataGridView();
            this.Lbl_Boxes = new System.Windows.Forms.Label();
            this.Pnl_Boxes.SuspendLayout();
            this.Pnl_Boxes_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Boxes)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Boxes
            // 
            this.Pnl_Boxes.Controls.Add(this.Pnl_Boxes_Actions);
            this.Pnl_Boxes.Controls.Add(this.Dtg_Boxes);
            this.Pnl_Boxes.Controls.Add(this.Lbl_Boxes);
            this.Pnl_Boxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Boxes.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Boxes.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_Boxes.Name = "Pnl_Boxes";
            this.Pnl_Boxes.Size = new System.Drawing.Size(513, 554);
            this.Pnl_Boxes.TabIndex = 0;
            // 
            // Pnl_Boxes_Actions
            // 
            this.Pnl_Boxes_Actions.Controls.Add(this.Btn_Boxes_DeleteBox);
            this.Pnl_Boxes_Actions.Controls.Add(this.Btn_Boxes_InsertBox);
            this.Pnl_Boxes_Actions.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Boxes_Actions.Location = new System.Drawing.Point(0, 510);
            this.Pnl_Boxes_Actions.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_Boxes_Actions.Name = "Pnl_Boxes_Actions";
            this.Pnl_Boxes_Actions.Size = new System.Drawing.Size(513, 43);
            this.Pnl_Boxes_Actions.TabIndex = 4;
            // 
            // Btn_Boxes_DeleteBox
            // 
            this.Btn_Boxes_DeleteBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Boxes_DeleteBox.Enabled = false;
            this.Btn_Boxes_DeleteBox.Location = new System.Drawing.Point(446, 0);
            this.Btn_Boxes_DeleteBox.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Boxes_DeleteBox.Name = "Btn_Boxes_DeleteBox";
            this.Btn_Boxes_DeleteBox.Size = new System.Drawing.Size(67, 43);
            this.Btn_Boxes_DeleteBox.TabIndex = 1;
            this.Btn_Boxes_DeleteBox.Text = "Delete Box";
            this.Btn_Boxes_DeleteBox.UseVisualStyleBackColor = true;
            this.Btn_Boxes_DeleteBox.Click += new System.EventHandler(this.Btn_Boxes_DeleteBox_Click);
            // 
            // Btn_Boxes_InsertBox
            // 
            this.Btn_Boxes_InsertBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Boxes_InsertBox.Location = new System.Drawing.Point(0, 0);
            this.Btn_Boxes_InsertBox.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Boxes_InsertBox.Name = "Btn_Boxes_InsertBox";
            this.Btn_Boxes_InsertBox.Size = new System.Drawing.Size(67, 43);
            this.Btn_Boxes_InsertBox.TabIndex = 0;
            this.Btn_Boxes_InsertBox.Text = "Insert Box";
            this.Btn_Boxes_InsertBox.UseVisualStyleBackColor = true;
            this.Btn_Boxes_InsertBox.Click += new System.EventHandler(this.Btn_Boxes_InsertBox_Click);
            // 
            // Dtg_Boxes
            // 
            this.Dtg_Boxes.AllowUserToAddRows = false;
            this.Dtg_Boxes.AllowUserToDeleteRows = false;
            this.Dtg_Boxes.AllowUserToResizeColumns = false;
            this.Dtg_Boxes.AllowUserToResizeRows = false;
            this.Dtg_Boxes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtg_Boxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Boxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dtg_Boxes.Location = new System.Drawing.Point(0, 37);
            this.Dtg_Boxes.Margin = new System.Windows.Forms.Padding(4);
            this.Dtg_Boxes.MultiSelect = false;
            this.Dtg_Boxes.Name = "Dtg_Boxes";
            this.Dtg_Boxes.ReadOnly = true;
            this.Dtg_Boxes.RowHeadersVisible = false;
            this.Dtg_Boxes.RowHeadersWidth = 51;
            this.Dtg_Boxes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Boxes.Size = new System.Drawing.Size(513, 473);
            this.Dtg_Boxes.TabIndex = 3;
            this.Dtg_Boxes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Boxes_RowEnter);
            this.Dtg_Boxes.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Boxes_RowLeave);
            // 
            // Lbl_Boxes
            // 
            this.Lbl_Boxes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Boxes.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Boxes.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Boxes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Boxes.Name = "Lbl_Boxes";
            this.Lbl_Boxes.Size = new System.Drawing.Size(513, 37);
            this.Lbl_Boxes.TabIndex = 2;
            this.Lbl_Boxes.Text = "Boxes";
            this.Lbl_Boxes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 554);
            this.Controls.Add(this.Pnl_Boxes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Box Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Pnl_Boxes.ResumeLayout(false);
            this.Pnl_Boxes_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Boxes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Boxes;
        private System.Windows.Forms.Panel Pnl_Boxes_Actions;
        private System.Windows.Forms.Button Btn_Boxes_DeleteBox;
        private System.Windows.Forms.Button Btn_Boxes_InsertBox;
        private System.Windows.Forms.DataGridView Dtg_Boxes;
        private System.Windows.Forms.Label Lbl_Boxes;
    }
}

