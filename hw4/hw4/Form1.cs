namespace hw4
{
    public partial class Form1 : Form
    {
        List<Item> menuItems = new List<Item>();

        Dictionary<string, double> petrolTypes = new Dictionary<string, double>()
        {
            { "Regular Unleaded", 3.49 },
            { "Premium Unleaded", 3.99 },
            { "Diesel", 4.29 },
            { "E85 Ethanol", 2.89 },
            { "Compressed Natural Gas (CNG)", 2.49 }
        };
        public Form1()
        {
            InitializeComponent();
            PopulatePetrolTypes();
            InitializeMenuItems();
            PopulateMenuItems();
            radioButtonPetrolPrice.CheckedChanged += RadioButtons_CheckedChanged;
            radioPetrolAmount.CheckedChanged += RadioButtons_CheckedChanged;

            textBoxUserPetrolPrice.Enabled = false;
            textBoxUserPetrolAmount.Enabled = false;
        }
        private void InitializeMenuItems()
        {
            menuItems.Add(new Item { Name = "Hot-dog", Price = 2.5, CheckBox = checkBoxItem1, PriceTextBox = textBoxPrice1, AmountTextBox = textBoxAmount1 });
            menuItems.Add(new Item { Name = "Hamburger", Price = 3.29, CheckBox = checkBoxItem2, PriceTextBox = textBoxPrice2, AmountTextBox = textBoxAmount2 });
            menuItems.Add(new Item { Name = "Coca-cola", Price = 2.5, CheckBox = checkBoxItem3, PriceTextBox = textBoxPrice3, AmountTextBox = textBoxAmount3 });
            menuItems.Add(new Item { Name = "Fries", Price = 1.99, CheckBox = checkBoxItem4, PriceTextBox = textBoxPrice4, AmountTextBox = textBoxAmount4 });
        }
        private void PopulateMenuItems()
        {
            for (int i = 0; i < menuItems.Count; i++)
            {
                var item = menuItems[i];
                item.CheckBox.Text = item.Name;
                item.PriceTextBox.Text = item.Price.ToString();
                item.PriceTextBox.Enabled = false;
                item.AmountTextBox.Enabled = false;
            }
        }
        public void PopulatePetrolTypes()
        {
            foreach (var item in petrolTypes)
                comboBoxPetrolTypes.Items.Add(item.Key);
        }

        private void comboBoxPetrolTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPetrolTypes.SelectedItem is string type &&
                petrolTypes.TryGetValue(type, out double price))
            {
                textBoxPetrolPrice.Text = price.ToString("F2");
                textBoxUserPetrolPrice.Clear();
                textBoxUserPetrolAmount.Clear();
            }
        }
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUserPetrolPrice.Enabled = radioButtonPetrolPrice.Checked;
            textBoxUserPetrolAmount.Enabled = radioPetrolAmount.Checked;
        }

        private void textBoxUserPetrolPrice_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonPetrolPrice.Checked &&
                double.TryParse(textBoxUserPetrolPrice.Text, out double money) &&
                comboBoxPetrolTypes.SelectedItem is string type &&
                petrolTypes.TryGetValue(type, out double pricePerGallon))
            {
                double gallons = money / pricePerGallon;
                textBoxUserPetrolAmount.Text = gallons.ToString("F2");
            }

            labelTotalPetrolPrice.Text = textBoxUserPetrolPrice.Text;
        }

        private void textBoxUserPetrolAmount_TextChanged(object sender, EventArgs e)
        {
            if (radioPetrolAmount.Checked &&
                double.TryParse(textBoxUserPetrolAmount.Text, out double gallons) &&
                comboBoxPetrolTypes.SelectedItem is string type &&
                petrolTypes.TryGetValue(type, out double pricePerGallon))
            {
                double totalCost = gallons * pricePerGallon;
                textBoxUserPetrolPrice.Text = totalCost.ToString("F2");
            }

            labelTotalPetrolPrice.Text = textBoxUserPetrolPrice.Text;
        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(labelTotalPetrolPrice.Text, out double petrolPrice) &&
                double.TryParse(labelTotalFoodPrice.Text, out double foodPrice))
            {
                double totalPrice = petrolPrice + foodPrice;
                labelTotalPrice.Text = totalPrice.ToString("F2");
            }
            else
            {
                labelTotalPrice.Text = "Error";
            }
        }

        private void checkBoxItem_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = sender as CheckBox;
            Item item = menuItems.FirstOrDefault(i => i.CheckBox == clickedCheckBox);

            if (item != null)
            {
                if (clickedCheckBox.Checked)
                {
                    item.AmountTextBox.Enabled = true;
                    item.AmountTextBox.Text = "1";
                }
                else
                {
                    item.AmountTextBox.Enabled = false;
                    item.AmountTextBox.Clear();
                }

                UpdateTotalPrice();
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            TextBox amtTextBox = sender as TextBox;
            Item item = menuItems.FirstOrDefault(i => i.AmountTextBox == amtTextBox);

            if (item != null)
            {
                if (double.TryParse(amtTextBox.Text, out double amt))
                {
                    if (amt == 0)
                    {
                        amt = 1;
                        amtTextBox.Text = amt.ToString();

                        amtTextBox.SelectionStart = amtTextBox.Text.Length;
                    }

                    double totalPrice = item.Price * amt;
                    item.PriceTextBox.Text = totalPrice.ToString("F2");
                }
                else
                {
                    item.PriceTextBox.Text = "0.00";
                }
            }
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            double total = 0;
            foreach (var item in menuItems)
            {
                if (double.TryParse(item.AmountTextBox.Text, out double amount) && amount > 0)
                {
                    total += item.Price * amount;
                }
            }

            labelTotalFoodPrice.Text = total.ToString("F2");
        }
    }
}
