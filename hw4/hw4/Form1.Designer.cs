namespace hw4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPetrolPrice = new TextBox();
            comboBoxPetrolTypes = new ComboBox();
            radioPetrolAmount = new RadioButton();
            radioButtonPetrolPrice = new RadioButton();
            textBoxUserPetrolPrice = new TextBox();
            textBoxUserPetrolAmount = new TextBox();
            labelTotalPetrolPrice = new Label();
            buttonCalculate = new Button();
            groupBoxEnterPetrol = new GroupBox();
            checkBoxItem1 = new CheckBox();
            checkBoxItem2 = new CheckBox();
            checkBoxItem3 = new CheckBox();
            checkBoxItem4 = new CheckBox();
            textBoxPrice1 = new TextBox();
            textBoxPrice2 = new TextBox();
            textBoxPrice3 = new TextBox();
            textBoxPrice4 = new TextBox();
            textBoxAmount1 = new TextBox();
            textBoxAmount2 = new TextBox();
            textBoxAmount3 = new TextBox();
            textBoxAmount4 = new TextBox();
            labelTotalFoodPrice = new Label();
            labelTotalPrice = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBoxEnterPetrol.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPetrolPrice
            // 
            textBoxPetrolPrice.Location = new Point(96, 86);
            textBoxPetrolPrice.Name = "textBoxPetrolPrice";
            textBoxPetrolPrice.ReadOnly = true;
            textBoxPetrolPrice.Size = new Size(121, 23);
            textBoxPetrolPrice.TabIndex = 0;
            // 
            // comboBoxPetrolTypes
            // 
            comboBoxPetrolTypes.FormattingEnabled = true;
            comboBoxPetrolTypes.Location = new Point(96, 44);
            comboBoxPetrolTypes.Name = "comboBoxPetrolTypes";
            comboBoxPetrolTypes.Size = new Size(121, 23);
            comboBoxPetrolTypes.TabIndex = 1;
            comboBoxPetrolTypes.SelectedIndexChanged += comboBoxPetrolTypes_SelectedIndexChanged;
            // 
            // radioPetrolAmount
            // 
            radioPetrolAmount.AutoSize = true;
            radioPetrolAmount.Location = new Point(6, 19);
            radioPetrolAmount.Name = "radioPetrolAmount";
            radioPetrolAmount.Size = new Size(69, 19);
            radioPetrolAmount.TabIndex = 2;
            radioPetrolAmount.TabStop = true;
            radioPetrolAmount.Text = "Amount";
            radioPetrolAmount.UseVisualStyleBackColor = true;
            // 
            // radioButtonPetrolPrice
            // 
            radioButtonPetrolPrice.AutoSize = true;
            radioButtonPetrolPrice.Location = new Point(6, 56);
            radioButtonPetrolPrice.Name = "radioButtonPetrolPrice";
            radioButtonPetrolPrice.Size = new Size(51, 19);
            radioButtonPetrolPrice.TabIndex = 2;
            radioButtonPetrolPrice.TabStop = true;
            radioButtonPetrolPrice.Text = "Price";
            radioButtonPetrolPrice.UseVisualStyleBackColor = true;
            // 
            // textBoxUserPetrolPrice
            // 
            textBoxUserPetrolPrice.Location = new Point(160, 188);
            textBoxUserPetrolPrice.Name = "textBoxUserPetrolPrice";
            textBoxUserPetrolPrice.Size = new Size(90, 23);
            textBoxUserPetrolPrice.TabIndex = 0;
            textBoxUserPetrolPrice.TextChanged += textBoxUserPetrolPrice_TextChanged;
            // 
            // textBoxUserPetrolAmount
            // 
            textBoxUserPetrolAmount.Location = new Point(160, 151);
            textBoxUserPetrolAmount.Name = "textBoxUserPetrolAmount";
            textBoxUserPetrolAmount.Size = new Size(90, 23);
            textBoxUserPetrolAmount.TabIndex = 0;
            textBoxUserPetrolAmount.TextChanged += textBoxUserPetrolAmount_TextChanged;
            // 
            // labelTotalPetrolPrice
            // 
            labelTotalPetrolPrice.AutoSize = true;
            labelTotalPetrolPrice.Font = new Font("Segoe UI", 15F);
            labelTotalPetrolPrice.Location = new Point(109, 253);
            labelTotalPetrolPrice.Name = "labelTotalPetrolPrice";
            labelTotalPetrolPrice.Size = new Size(49, 28);
            labelTotalPetrolPrice.TabIndex = 3;
            labelTotalPetrolPrice.Text = "0.00";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(45, 332);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(98, 51);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Calculate: ";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // groupBoxEnterPetrol
            // 
            groupBoxEnterPetrol.Controls.Add(radioPetrolAmount);
            groupBoxEnterPetrol.Controls.Add(radioButtonPetrolPrice);
            groupBoxEnterPetrol.Location = new Point(39, 133);
            groupBoxEnterPetrol.Name = "groupBoxEnterPetrol";
            groupBoxEnterPetrol.Size = new Size(104, 92);
            groupBoxEnterPetrol.TabIndex = 5;
            groupBoxEnterPetrol.TabStop = false;
            // 
            // checkBoxItem1
            // 
            checkBoxItem1.AutoSize = true;
            checkBoxItem1.Location = new Point(322, 46);
            checkBoxItem1.Name = "checkBoxItem1";
            checkBoxItem1.Size = new Size(83, 19);
            checkBoxItem1.TabIndex = 6;
            checkBoxItem1.Text = "checkBox1";
            checkBoxItem1.UseVisualStyleBackColor = true;
            checkBoxItem1.CheckedChanged += checkBoxItem_CheckedChanged;
            // 
            // checkBoxItem2
            // 
            checkBoxItem2.AutoSize = true;
            checkBoxItem2.Location = new Point(322, 71);
            checkBoxItem2.Name = "checkBoxItem2";
            checkBoxItem2.Size = new Size(83, 19);
            checkBoxItem2.TabIndex = 6;
            checkBoxItem2.Text = "checkBox1";
            checkBoxItem2.UseVisualStyleBackColor = true;
            checkBoxItem2.CheckedChanged += checkBoxItem_CheckedChanged;
            // 
            // checkBoxItem3
            // 
            checkBoxItem3.AutoSize = true;
            checkBoxItem3.Location = new Point(322, 98);
            checkBoxItem3.Name = "checkBoxItem3";
            checkBoxItem3.Size = new Size(83, 19);
            checkBoxItem3.TabIndex = 6;
            checkBoxItem3.Text = "checkBox1";
            checkBoxItem3.UseVisualStyleBackColor = true;
            checkBoxItem3.CheckedChanged += checkBoxItem_CheckedChanged;
            // 
            // checkBoxItem4
            // 
            checkBoxItem4.AutoSize = true;
            checkBoxItem4.Location = new Point(322, 123);
            checkBoxItem4.Name = "checkBoxItem4";
            checkBoxItem4.Size = new Size(83, 19);
            checkBoxItem4.TabIndex = 6;
            checkBoxItem4.Text = "checkBox1";
            checkBoxItem4.UseVisualStyleBackColor = true;
            checkBoxItem4.CheckedChanged += checkBoxItem_CheckedChanged;
            // 
            // textBoxPrice1
            // 
            textBoxPrice1.Location = new Point(411, 38);
            textBoxPrice1.Name = "textBoxPrice1";
            textBoxPrice1.ReadOnly = true;
            textBoxPrice1.Size = new Size(80, 23);
            textBoxPrice1.TabIndex = 7;
            // 
            // textBoxPrice2
            // 
            textBoxPrice2.Location = new Point(411, 67);
            textBoxPrice2.Name = "textBoxPrice2";
            textBoxPrice2.ReadOnly = true;
            textBoxPrice2.Size = new Size(80, 23);
            textBoxPrice2.TabIndex = 7;
            // 
            // textBoxPrice3
            // 
            textBoxPrice3.Location = new Point(411, 96);
            textBoxPrice3.Name = "textBoxPrice3";
            textBoxPrice3.ReadOnly = true;
            textBoxPrice3.Size = new Size(80, 23);
            textBoxPrice3.TabIndex = 7;
            // 
            // textBoxPrice4
            // 
            textBoxPrice4.Location = new Point(411, 125);
            textBoxPrice4.Name = "textBoxPrice4";
            textBoxPrice4.ReadOnly = true;
            textBoxPrice4.Size = new Size(80, 23);
            textBoxPrice4.TabIndex = 7;
            // 
            // textBoxAmount1
            // 
            textBoxAmount1.Location = new Point(502, 38);
            textBoxAmount1.Name = "textBoxAmount1";
            textBoxAmount1.Size = new Size(100, 23);
            textBoxAmount1.TabIndex = 8;
            textBoxAmount1.TextChanged += textBoxAmount_TextChanged;
            // 
            // textBoxAmount2
            // 
            textBoxAmount2.Location = new Point(502, 67);
            textBoxAmount2.Name = "textBoxAmount2";
            textBoxAmount2.Size = new Size(100, 23);
            textBoxAmount2.TabIndex = 8;
            textBoxAmount2.TextChanged += textBoxAmount_TextChanged;
            // 
            // textBoxAmount3
            // 
            textBoxAmount3.Location = new Point(502, 96);
            textBoxAmount3.Name = "textBoxAmount3";
            textBoxAmount3.Size = new Size(100, 23);
            textBoxAmount3.TabIndex = 8;
            textBoxAmount3.TextChanged += textBoxAmount_TextChanged;
            // 
            // textBoxAmount4
            // 
            textBoxAmount4.Location = new Point(502, 123);
            textBoxAmount4.Name = "textBoxAmount4";
            textBoxAmount4.Size = new Size(100, 23);
            textBoxAmount4.TabIndex = 8;
            textBoxAmount4.TextChanged += textBoxAmount_TextChanged;
            // 
            // labelTotalFoodPrice
            // 
            labelTotalFoodPrice.AutoSize = true;
            labelTotalFoodPrice.Font = new Font("Segoe UI", 15F);
            labelTotalFoodPrice.Location = new Point(442, 253);
            labelTotalFoodPrice.Name = "labelTotalFoodPrice";
            labelTotalFoodPrice.Size = new Size(49, 28);
            labelTotalFoodPrice.TabIndex = 3;
            labelTotalFoodPrice.Text = "0.00";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 15F);
            labelTotalPrice.Location = new Point(168, 339);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(49, 28);
            labelTotalPrice.TabIndex = 3;
            labelTotalPrice.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 47);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 9;
            label1.Text = "Petrol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 89);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Price:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAmount4);
            Controls.Add(textBoxAmount3);
            Controls.Add(textBoxAmount2);
            Controls.Add(textBoxAmount1);
            Controls.Add(textBoxPrice4);
            Controls.Add(textBoxPrice3);
            Controls.Add(textBoxPrice2);
            Controls.Add(textBoxPrice1);
            Controls.Add(checkBoxItem4);
            Controls.Add(checkBoxItem3);
            Controls.Add(checkBoxItem2);
            Controls.Add(checkBoxItem1);
            Controls.Add(groupBoxEnterPetrol);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxUserPetrolPrice);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelTotalFoodPrice);
            Controls.Add(labelTotalPetrolPrice);
            Controls.Add(comboBoxPetrolTypes);
            Controls.Add(textBoxUserPetrolAmount);
            Controls.Add(textBoxPetrolPrice);
            Name = "Form1";
            Text = "Form1";
            groupBoxEnterPetrol.ResumeLayout(false);
            groupBoxEnterPetrol.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPetrolPrice;
        private ComboBox comboBoxPetrolTypes;

        private GroupBox groupBoxEnterPetrol;
        private RadioButton radioPetrolAmount;
        private RadioButton radioButtonPetrolPrice;
        private TextBox textBoxUserPetrolPrice;
        private TextBox textBoxUserPetrolAmount;

        private Label labelTotalPetrolPrice;
        private Button buttonCalculate;

        private CheckBox checkBoxItem1;
        private CheckBox checkBoxItem2;
        private CheckBox checkBoxItem3;
        private CheckBox checkBoxItem4;
        private TextBox textBoxPrice1;
        private TextBox textBoxPrice2;
        private TextBox textBoxPrice3;
        private TextBox textBoxPrice4;
        private TextBox textBoxAmount1;
        private TextBox textBoxAmount2;
        private TextBox textBoxAmount3;
        private TextBox textBoxAmount4;
        
        private Label labelTotalFoodPrice;
        private Label labelTotalPrice;
        private Label label1;
        private Label label2;
    }
}
