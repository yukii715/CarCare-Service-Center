
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare_Service_Center
{
    public partial class Progress : Form
    {
        int newRowOffSet = 10;
        int currentRow = 1;
        int index = 2;
        public Progress()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            for (int i = 1; i < index; i++)
            {
                string comboBoxName = "cmbInventoryUsed" + i.ToString();
                string textBoxName = "txtUsedAmount" + i.ToString();

                ComboBox cmbInventoryUsed = panelProgress.Controls.Find(comboBoxName, true).First() as ComboBox;
                TextBox txtUsedAmount = panelProgress.Controls.Find(textBoxName, true).First() as TextBox;

                if (cmbInventoryUsed != null && txtUsedAmount != null)
                {
                    bool isComboBoxSelected = cmbInventoryUsed.SelectedItem != null;
                    bool isTextBoxFilled = !string.IsNullOrWhiteSpace(txtUsedAmount.Text);

                    if (isTextBoxFilled && !int.TryParse(txtUsedAmount.Text, out _))
                    {
                        MessageBox.Show("Error: 'Used Amount' must be a numeric value. Please correct it before proceeding.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (isComboBoxSelected && !isTextBoxFilled)
                    {
                        var result = MessageBox.Show("You selected an Inventory but did not fill in the Used Amount. Do you want to submit?", "Incomplete Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            this.Close();
                            return;
                        }

                    }
                    else if (!isComboBoxSelected && isTextBoxFilled)
                    {
                        var result = MessageBox.Show("You filled in the Used Amount but did not select an Inventory. Do you want to submit?", "Incomplete Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            this.Close();
                            return;
                        }
                    }
                    else if (isComboBoxSelected && isTextBoxFilled)
                    {
                        msg += $"Inventory Used: {cmbInventoryUsed.SelectedItem}, Used Amount: {txtUsedAmount.Text}\n";

                    }
                }
                else
                {
                    MessageBox.Show("Error: Required controls not found. Please check control names and try again.");
                    return;

                }
            }


            if (!string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show(msg);
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int yOffset = currentRow * (lblInventoryUsed.Height + newRowOffSet);


            Label labelInventory = new Label();
            labelInventory.Name = "lblInventoryUsed" + index.ToString();
            labelInventory.Text = "Inventory Used :";
            labelInventory.Location = new Point(lblInventoryUsed.Location.X, 14 + yOffset);
            labelInventory.Size = lblInventoryUsed.Size;
            labelInventory.Font = lblInventoryUsed.Font;
            panelProgress.Controls.Add(labelInventory);

            ComboBox comboBox = new ComboBox();
            comboBox.Name = "cmbInventoryUsed" + index.ToString();
            comboBox.Location = new Point(cmbInventoryUsed1.Location.X, 13 + yOffset);
            comboBox.Size = cmbInventoryUsed1.Size;
            comboBox.Font = cmbInventoryUsed1.Font;
            foreach (var item in cmbInventoryUsed1.Items)
            {
                comboBox.Items.Add(item);
            }
            panelProgress.Controls.Add(comboBox);

            Label labelUsedAmount = new Label();
            labelUsedAmount.Name = "lblUsedAmount" + index.ToString();
            labelUsedAmount.Text = "Used Amount :";
            labelUsedAmount.Location = new Point(lblUsedAmount.Location.X, 14 + yOffset);
            labelUsedAmount.Size = lblUsedAmount.Size;
            labelUsedAmount.Font = lblUsedAmount.Font;
            panelProgress.Controls.Add(labelUsedAmount);

            TextBox textBox = new TextBox();
            textBox.Name = "txtUsedAmount" + index.ToString();
            textBox.Location = new Point(txtUsedAmount1.Location.X, 16 + yOffset);
            textBox.Size = txtUsedAmount1.Size;
            textBox.Font = txtUsedAmount1.Font;
            panelProgress.Controls.Add(textBox);

            currentRow++;
            index++;
        }
    }
}
