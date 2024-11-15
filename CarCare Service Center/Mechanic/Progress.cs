

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
        private Dictionary<string, List<string>> serviceTypeOptions = new Dictionary<string, List<string>>()
        {
            { "a", new List<string> { "1", "2", "3" } },
            { "b", new List<string> { "4", "5", "6" } },
            { "c", new List<string> { "7", "8", "9" } }
        };

        private List<ComboBox> partTypeComboBoxes = new List<ComboBox>();
        private List<ComboBox> partNameComboBoxes = new List<ComboBox>();
        private List<TextBox> usedAmountTextBoxes = new List<TextBox>();
        private List<string> selectedPartNames = new List<string>();
        public Progress()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializePartTypeComboBox();
        }

        private void InitializePartTypeComboBox()
        {
            cmbPartTypeUsed.Items.Clear();
            cmbPartTypeUsed.Items.AddRange(new string[] { "a", "b", "c" });
            SetComboBoxToDefaultState(cmbPartTypeUsed, "Select Part Type");
            cmbPartTypeUsed.SelectedIndexChanged += cmbPartTypeUsed_SelectedIndexChanged;
            cmbPartNameUsed.Enabled = false;
            SetComboBoxToDefaultState(cmbPartNameUsed, "Select Part Name");
            cmbPartNameUsed.SelectedIndexChanged += cmbPartNameUsed_SelectedIndexChanged;
        }

        private void cmbPartTypeUsed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedIndex != -1)
            {
                string selectedPartType = cmb.SelectedItem.ToString();

                if (cmb == cmbPartTypeUsed)
                {
                    UpdatePartNameOptions(cmbPartNameUsed, selectedPartType);
                    cmbPartNameUsed.Enabled = true;
                }

                SetComboBoxToSelectedState(cmb);
                cmbPartNameUsed.Focus();
            }
            else
            {
                SetComboBoxToDefaultState(cmbPartNameUsed, "Select Part Name");
                cmbPartNameUsed.Enabled = false;
            }
        }

        private void cmbPartNameUsed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            if (cmb.SelectedIndex != -1)
            {
                SetComboBoxToSelectedState(cmb);
                txtUsedAmount.Focus();
                string selectedPartName = cmb.SelectedItem.ToString();
                selectedPartNames.Add(selectedPartName);

                foreach (ComboBox otherCmb in partNameComboBoxes)
                {
                    if (otherCmb != cmb && otherCmb.Items.Contains(selectedPartName))
                    {
                        otherCmb.Items.Remove(selectedPartName);
                    }
                }
            }

            else
            {
                SetComboBoxToDefaultState(cmb, "Select Part Name");
            }
        }

        private void UpdatePartNameOptions(ComboBox partNameComboBox, string partType)
        {
            partNameComboBox.Items.Clear();
            if (serviceTypeOptions.ContainsKey(partType))
            {
                List<string> partNames = serviceTypeOptions[partType];
                partNames.RemoveAll(name => selectedPartNames.Contains(name));
                partNameComboBox.Items.AddRange(partNames.ToArray());
            }
            else
            {
                partNameComboBox.Items.Add("No options available");
            }
        }

        private void SetComboBoxToDefaultState(ComboBox comboBox, string defaultText)
        {
            comboBox.Text = defaultText;
            comboBox.ForeColor = Color.Gray;
            comboBox.BackColor = Color.LightGray;
        }

        private void SetComboBoxToSelectedState(ComboBox comboBox)
        {
            comboBox.ForeColor = Color.Black;
            comboBox.BackColor = Color.White;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            int yOffset = currentRow * (lblPartTypeUsed.Height + newRowOffSet);


            Label newlblPartTypeUsed = new Label();
            newlblPartTypeUsed.Name = "labelPartTyprUsed" + index.ToString();
            newlblPartTypeUsed.Text = "Part Type Used :";
            newlblPartTypeUsed.Location = new Point(lblPartTypeUsed.Location.X, lblPartTypeUsed.Location.Y + yOffset);
            newlblPartTypeUsed.Size = lblPartTypeUsed.Size;
            newlblPartTypeUsed.Font = lblPartTypeUsed.Font;
            panelProgress.Controls.Add(newlblPartTypeUsed);

            ComboBox cmbPartTypeUsednew = new ComboBox();
            cmbPartTypeUsednew.Name = "cmbPartTypeUsed" + index.ToString();
            cmbPartTypeUsednew.Location = new Point(cmbPartTypeUsed.Location.X, cmbPartTypeUsed.Location.Y + yOffset);
            cmbPartTypeUsednew.Size = cmbPartTypeUsed.Size;
            cmbPartTypeUsednew.Font = cmbPartTypeUsed.Font;
            cmbPartTypeUsednew.Items.AddRange(new string[] { "a", "b", "c" });
            cmbPartTypeUsednew.SelectedIndex = -1;
            cmbPartTypeUsednew.Text = "Select Part Type";
            cmbPartTypeUsednew.ForeColor = Color.Gray;
            cmbPartTypeUsednew.BackColor = Color.LightGray;
            panelProgress.Controls.Add(cmbPartTypeUsednew);
            cmbPartTypeUsednew.SelectedIndexChanged += cmbPartTypeUsed_SelectedIndexChanged;
            partTypeComboBoxes.Add(cmbPartTypeUsednew);

            Label lblPartNameUsednew = new Label();
            lblPartNameUsednew.Name = "lblPartNameUsed" + index.ToString();
            lblPartNameUsednew.Text = "Part Name Used :";
            lblPartNameUsednew.Location = new Point(lblPartNameUsed.Location.X, lblPartNameUsed.Location.Y + yOffset);
            lblPartNameUsednew.Size = lblPartNameUsed.Size;
            lblPartNameUsednew.Font = lblPartNameUsed.Font;
            panelProgress.Controls.Add(lblPartNameUsednew);

            Label newlblUsedAmount = new Label();
            newlblUsedAmount.Name = "lblUsedAmount" + index.ToString();
            newlblUsedAmount.Text = "Used Amount :";
            newlblUsedAmount.Location = new Point(lblUsedAmount.Location.X, lblUsedAmount.Location.Y + yOffset);
            newlblUsedAmount.Size = lblUsedAmount.Size;
            newlblUsedAmount.Font = lblUsedAmount.Font;
            panelProgress.Controls.Add(newlblUsedAmount);


            TextBox newtxtUsedAmount = new TextBox();
            newtxtUsedAmount.Name = "txtUsedAmount" + index.ToString();
            newtxtUsedAmount.Location = new Point(txtUsedAmount.Location.X, txtUsedAmount.Location.Y + yOffset);
            newtxtUsedAmount.Size = txtUsedAmount.Size;
            newtxtUsedAmount.Font = txtUsedAmount.Font;
            panelProgress.Controls.Add(newtxtUsedAmount);
            usedAmountTextBoxes.Add(newtxtUsedAmount);

            ComboBox cmbPartNameUsednew = new ComboBox();
            cmbPartNameUsednew.Name = "cmbPartNameUsed" + index.ToString();
            cmbPartNameUsednew.Location = new Point(cmbPartNameUsed.Location.X, cmbPartNameUsed.Location.Y + yOffset);
            cmbPartNameUsednew.Size = cmbPartNameUsed.Size;
            cmbPartNameUsednew.Font = cmbPartNameUsed.Font;
            cmbPartNameUsednew.Enabled = false;
            cmbPartNameUsednew.Text = "Select Part Name";
            cmbPartNameUsednew.ForeColor = Color.Gray;
            cmbPartNameUsednew.BackColor = Color.LightGray;
            cmbPartNameUsednew.SelectedIndexChanged += cmbPartNameUsed_SelectedIndexChanged;
            panelProgress.Controls.Add(cmbPartNameUsednew);
            partNameComboBoxes.Add(cmbPartNameUsednew);

            cmbPartNameUsednew.SelectedIndexChanged += (s, ev) =>
            {
                if (cmbPartNameUsednew.SelectedIndex != -1)
                {
                    SetComboBoxToSelectedState(cmbPartNameUsednew);
                    cmbPartNameUsednew.ForeColor = Color.Black;
                    cmbPartNameUsednew.BackColor = Color.White;
                    newtxtUsedAmount.Focus();
                    string selectedPartName = cmbPartNameUsednew.SelectedItem.ToString();
                    selectedPartNames.Add(selectedPartName);

                    foreach (ComboBox otherCmb in partNameComboBoxes)
                    {
                        if (otherCmb != cmbPartNameUsednew && otherCmb.Items.Contains(selectedPartName))
                        {
                            otherCmb.Items.Remove(selectedPartName);
                        }
                    }
                }

                else
                {
                    SetComboBoxToDefaultState(cmbPartNameUsednew, "Select Part Name");
                    cmbPartNameUsednew.ForeColor = Color.Gray;
                    cmbPartNameUsednew.BackColor = Color.LightGray;
                }
            };

            cmbPartTypeUsednew.SelectedIndexChanged += (s, ev) =>
            {
                if (cmbPartTypeUsednew.SelectedIndex != -1)
                {
                    string selectedPartType = cmbPartTypeUsednew.SelectedItem.ToString();
                    UpdatePartNameOptions(cmbPartNameUsednew, selectedPartType);

                    cmbPartTypeUsednew.ForeColor = Color.Black;
                    cmbPartTypeUsednew.BackColor = Color.White;
                    cmbPartNameUsednew.Enabled = true;
                    cmbPartNameUsednew.Focus();
                }
                else
                {
                    cmbPartTypeUsednew.ForeColor = Color.Gray;
                    cmbPartTypeUsednew.BackColor = Color.LightGray;
                    cmbPartNameUsednew.Enabled = false;

                }
            };
            currentRow++;
            index++;
        }


        private void btnProgressDone_Click(object sender, EventArgs e)
        {
            bool allTextBoxesValid = true;

            foreach (TextBox textBox in usedAmountTextBoxes)
            {
                if (!string.IsNullOrEmpty(textBox.Text) && !decimal.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("All 'Used Amount' fields must contain only numbers or be left blank.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    allTextBoxesValid = false;
                    return;
                }
            }

            if (allTextBoxesValid)
            {
                List<string> collectedData = new List<string>();

                if (cmbPartTypeUsed.SelectedIndex != -1 && cmbPartNameUsed.SelectedIndex != -1 && !string.IsNullOrEmpty(txtUsedAmount.Text))
                {
                    collectedData.Add($"Part Type: {cmbPartTypeUsed.SelectedItem}");
                    collectedData.Add($"Part Name: {cmbPartNameUsed.SelectedItem}");
                    collectedData.Add($"Used Amount: {txtUsedAmount.Text}");
                }

                for (int i = 0; i < partTypeComboBoxes.Count; i++)
                {
                    ComboBox partTypeComboBox = partTypeComboBoxes[i];
                    ComboBox partNameComboBox = partNameComboBoxes[i];
                    TextBox usedAmountTextBox = usedAmountTextBoxes[i];

                    if (partTypeComboBox.SelectedIndex != -1 && partNameComboBox.SelectedIndex != -1 && !string.IsNullOrEmpty(usedAmountTextBox.Text))
                    {
                        collectedData.Add($"Part Type: {partTypeComboBox.SelectedItem}");
                        collectedData.Add($"Part Name: {partNameComboBox.SelectedItem}");
                        collectedData.Add($"Used Amount: {usedAmountTextBox.Text}");
                    }
                }

                MessageBox.Show(string.Join("\n", collectedData), "Collected Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

    }

}
