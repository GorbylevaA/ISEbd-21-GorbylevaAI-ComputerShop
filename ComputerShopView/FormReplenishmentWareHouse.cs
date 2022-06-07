using ComputerShopContracts.BindingModels;
using ComputerShopContracts.BusinessLogicsContracts;
using ComputerShopContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;


namespace ComputerShopView
{
    public partial class FormReplenishmentWareHouse : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IWareHouseLogic _logicW;

        private readonly IComponentLogic _logicC;

        public FormReplenishmentWareHouse(IComponentLogic logicC, IWareHouseLogic logicW)
        {
            InitializeComponent();
            _logicW = logicW;
            _logicC = logicC;
        }

        private void FormReplenishmentWareHouse_Load(object sender, EventArgs e)
        {
            try
            {
                List<WareHouseViewModel> listW = _logicW.Read(null);
                if (listW != null)
                {
                    comboBoxWareHouse.DisplayMember = "WareHouseName";
                    comboBoxWareHouse.ValueMember = "Id";
                    comboBoxWareHouse.DataSource = listW;
                    comboBoxWareHouse.SelectedItem = null;
                }
                else
                {
                    throw new Exception("Не удалось загрузить список складов");
                }

                List<ComponentViewModel> listС = _logicC.Read(null);
                if (listС != null)
                {
                    comboBoxComponent.DisplayMember = "ComponentName";
                    comboBoxComponent.ValueMember = "Id";
                    comboBoxComponent.DataSource = listС;
                    comboBoxComponent.SelectedItem = null;
                }
                else
                {
                    throw new Exception("Не удалось загрузить список компонентов");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxComponent.SelectedValue == null)
            {
                MessageBox.Show("Выберите продукт", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            if (comboBoxWareHouse.SelectedValue == null)
            {
                MessageBox.Show("Выберите склад", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<ComponentViewModel> listС = _logicC.Read(null);
                _logicW.ReplenishByComponent(new WareHouseReplenishmentBindingModel
                {
                    WareHouseId = Convert.ToInt32(comboBoxWareHouse.SelectedValue),
                    ComponentId = listС[comboBoxComponent.SelectedIndex].Id,
                    Count = Convert.ToInt32(textBoxCount.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
