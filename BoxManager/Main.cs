﻿using BoxManager.Controller.BoxController;
using BoxManager.Repository.BoxRepository;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BoxManager
{
    public partial class Main : Form
    {
        IBoxController _boxCtrl;

        public Main()
        {
            _boxCtrl = new BoxController(new BoxRepository());

            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshGridBoxes();
        }

        private void Btn_Boxes_InsertBox_Click(object sender, EventArgs e)
        {
            var boxInsert = new View.Box(_boxCtrl);
            boxInsert.ShowDialog();

            RefreshGridBoxes();
        }
        private void Btn_Boxes_DeleteBox_Click(object sender, EventArgs e)
        {
            if (Dtg_Boxes.SelectedRows.Count < 1) return;

            var IdBox = (int)Dtg_Boxes.SelectedRows[0].Cells["Id"].Value;

            _boxCtrl.Delete(IdBox);

            RefreshGridBoxes();
        }

        private void Dtg_Boxes_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Boxes_DeleteBox.Enabled = false;
        }
        private void Dtg_Boxes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Boxes_DeleteBox.Enabled = true;
        }

        public void RefreshGridBoxes()
        {
            var listOfBoxes = _boxCtrl.GetAll();
            Dtg_Boxes.DataSource = listOfBoxes;
            Dtg_Boxes.DataSource = listOfBoxes.Select(b => new { Id = b.Id, Label = b.Label }).ToList();
        }
    }
}
