using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare_Service_Center
{
    public partial class ServiceInsertion : Form
    {
        public ServiceInsertion()
        {
            InitializeComponent();
        }

        private void btnNewType_Click(object sender, EventArgs e)
        {
            TextBox txtNewType = new TextBox
            {
                Name = "txtNewType",
                Location = new Point(cmbServiceType.Location.X, cmbServiceType.Location.Y + 40),
                Multiline = true,
                AutoSize = true,
                Size = new Size(cmbServiceType.Width, cmbServiceType.Height),
            };
            panel1.Controls.Add(txtNewType);

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Top > txtNewType.Top)
                {
                    ctrl.Top += 40;
                }
            }

            btnNewType.Visible = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
        int rowCount = 2; // 记录当前行数，从1开始，因为第一行已经存在
        int targetRow = 1; // 假设你想在第二行上方添加新行

        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            // 增加行数
            rowCount++;
            int rowIndex = rowCount - 1;
            int rowCopy = rowCount - 2;

            // 添加一行到 TableLayoutPanel
            tlpPrice.RowCount = rowCount;
            tlpPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f)); // 插入新行样式


            // 移动目标行
            tlpPrice.Controls.Remove(btnAddPrice);
            tlpPrice.Controls.Add(btnAddPrice, 0, targetRow + 1); // 移动到下一行

            // 创建控件并添加到新行
            Label lblPriceCurrency = new Label
            {
                Name = "lblPriceCurrency" + rowIndex,
                Text = "RM",
                AutoSize = true,
            };
            tlpPrice.Controls.Add(lblPriceCurrency, 0, rowCopy);
            lblPriceCurrency.Dock = DockStyle.Fill;
            lblPriceCurrency.TextAlign = ContentAlignment.MiddleLeft;

            TextBox txtPriceAmount = new TextBox
            {
                Name = "txtPriceAmount" + rowIndex,
                AutoSize = true
            };
            tlpPrice.Controls.Add(txtPriceAmount, 1, rowCopy);
            txtPriceAmount.Dock = DockStyle.Fill;

            TextBox txtMode = new TextBox
            {
                Name = "txtMode" + rowIndex,
                AutoSize = true
            };
            tlpPrice.Controls.Add(txtMode, 2, rowCopy);
            txtMode.Dock = DockStyle.Fill;

            Button btnRemovePrice = new Button
            {
                Name = "btnRemovePrice" + rowIndex,
                AutoSize = true,
                Text = "Remove"
            };
            tlpPrice.Controls.Add(btnRemovePrice, 3, rowCopy);
            btnRemovePrice.Dock = DockStyle.Fill;
            btnRemovePrice.Click += Button_Click;

            targetRow++;

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Top > tlpPrice.Bottom)
                {
                    ctrl.Top += tlpPrice.GetRowHeights()[0];
                }
            }
        }


        // Shared event handler for all buttons
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Cast the sender to a Button
            if (clickedButton != null)
            {
                var btnSelected = tlpPrice.GetPositionFromControl(clickedButton);
                int removeRow = btnSelected.Row;
                for (int i = 0; i < tlpPrice.ColumnCount; i++)
                {
                    Control toRemoveControl = tlpPrice.GetControlFromPosition(i, removeRow);
                    if (toRemoveControl != null)
                    {
                        tlpPrice.Controls.Remove(toRemoveControl);
                    }
                }
                for (int i = rowCount; i > removeRow; i--)
                {
                    for (int j = 0; j < tlpPrice.ColumnCount; j++)
                    {
                        Control toRemoveControl = tlpPrice.GetControlFromPosition(j, i);
                        if (toRemoveControl != null)
                        {
                            tlpPrice.Controls.Remove(toRemoveControl);
                            tlpPrice.Controls.Add(toRemoveControl, j, i - 1); // 移动到下一行
                        }
                    }
                }

                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl.Top > tlpPrice.Bottom)
                    {
                        ctrl.Top -= tlpPrice.GetRowHeights()[0];
                    }
                }
                rowCount--;
                targetRow--;
                tlpPrice.RowCount--;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            // Show the dialog and check if the user selected a file
            if (fileImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    picService.Image = System.Drawing.Image.FromFile(fileImage.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}