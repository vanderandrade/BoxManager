using BoxManager.Controller.ItemController;
using BoxManager.Enum;
using BoxManager.Repository.ItemRepository;
using System;
using System.Windows.Forms;

namespace BoxManager.View
{
    public partial class Item : Form
    {
        private ScreenBehaviour _screenBehaviour;
        private IItemController _itemCtrl;
        private Model.Item _currentItem;
        private int _boxId;

        public Item(int BoxId, string BoxDescription, Model.Item Item = null)
        {
            _boxId = BoxId;
            _itemCtrl = new ItemController(new ItemRepository());
            _currentItem = Item;
            _screenBehaviour = Item is null ? ScreenBehaviour.Insert : ScreenBehaviour.Update;

            InitializeComponent();

            Lbl_BoxDescription.Text = "*" + BoxDescription;
        }

        private void Item_Load(object sender, EventArgs e)
        {
            if (_screenBehaviour is ScreenBehaviour.Insert)
            {
                Lbl_Id.Visible = false;
                Txt_Id.Visible = false;

                _currentItem = new Model.Item();
            }
            else if (_screenBehaviour is ScreenBehaviour.Update)
            {
                Txt_Id.Text = _currentItem.Id.ToString();
                Txt_Description.Text = _currentItem.Description;
                Num_Weight.Text = _currentItem.Weight is null ? "" : _currentItem.Weight.ToString();
            }
        }

        private void LoadFieldsOnItem()
        {
            _currentItem.Box_Id = _boxId;
            _currentItem.Description = Txt_Description.Text;
            
            if (double.TryParse(Num_Weight.Text, out double weight) && weight > 0)
                _currentItem.Weight = weight;
            else
                _currentItem.Weight = null;
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            LoadFieldsOnItem();

            if (_screenBehaviour is ScreenBehaviour.Insert)
                _itemCtrl.Insert(_currentItem);
            else if (_screenBehaviour is ScreenBehaviour.Update)
                _itemCtrl.Change(_currentItem);

            this.Dispose();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
