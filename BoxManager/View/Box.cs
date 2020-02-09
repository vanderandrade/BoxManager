using BoxManager.Controller.BoxController;
using BoxManager.Enum;
using System;
using System.Linq;
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
            else if (_screenBehaviour is ScreenBehaviour.Update)
            {
                Txt_Id.Text = _currentBox.Id.ToString();
                Txt_Label.Text = _currentBox.Label;
                Num_MaximumWeight.Text = _currentBox.Maximum_Weight is null ? "" : _currentBox.Maximum_Weight.ToString();

                RefreshGridItems();
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
            else if (_screenBehaviour is ScreenBehaviour.Update)
                _boxCtrl.Change(_currentBox);

            this.Dispose();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_AddItem_Click(object sender, EventArgs e)
        {
            var itemInsert = new View.Item(_currentBox.Id, _currentBox.ToString());
            itemInsert.ShowDialog();
        }

        private void RefreshGridItems()
        {
            var listOfItems = _boxCtrl.GetAllItems(_currentBox.Id);
            if (listOfItems.Count == 0) return;
            Dtg_Items.DataSource = listOfItems;
            Dtg_Items.DataSource = listOfItems.Select(i => new { Id = i.Id, Description = i.Description, Weight = i.Weight }).ToList();
        }
    }
}
