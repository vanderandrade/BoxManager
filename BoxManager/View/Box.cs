using BoxManager.Controller.BoxController;
using BoxManager.Enum;
using BoxManager.Repository.BoxRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxManager.View
{
    public partial class Box : Form
    {
        private ScreenBehaviour _screenBehaviour;
        private IBoxController _boxCtrl;
        private Model.Box _currentBox;

        public Box(IBoxController boxController, Model.Box box = null)
        {
            _boxCtrl = boxController;
            _currentBox = box;
            _screenBehaviour = box is null ? ScreenBehaviour.Insert : ScreenBehaviour.Update;

            InitializeComponent();
        }

        private void Box_Load(object sender, EventArgs e)
        {
            if (_screenBehaviour is ScreenBehaviour.Insert)
            {
                Lbl_Id.Visible = false;
                Txt_Id.Visible = false;

                _currentBox = new Model.Box();
            }
            else
            {
                Txt_Id.Text = _currentBox.Id.ToString();
                Txt_Label.Text = _currentBox.Label;
                Num_MaximumWeight.Text = _currentBox.Maximum_Weight is null ? "" : _currentBox.Maximum_Weight.ToString();
            }
        }

        private void LoadFieldsOnBox()
        {
            _currentBox.Label = Txt_Label.Text;

            if (double.TryParse(Num_MaximumWeight.Text, out double maximumWeight) && maximumWeight > 0)
                _currentBox.Maximum_Weight = maximumWeight;
            else
                _currentBox.Maximum_Weight = null;

        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            LoadFieldsOnBox();

            if (_screenBehaviour is ScreenBehaviour.Insert)
                _boxCtrl.Insert(_currentBox);
            else
                _boxCtrl.Change(_currentBox);

            this.Dispose();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
