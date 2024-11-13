using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSetting
{
    public class Draw_Item
    {
        public static void tabControlAdjustment(Object sender, DrawItemEventArgs e)
        {
            TabControl tab = sender as TabControl;
            if (tab == null) return;

            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tab.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tab.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Blue);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                _textBrush = new SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
    }
    public class Place_Holder
    {
        public static void SetPlaceHolder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            // Event handlers for placeholder behavior
            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.ControlText;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
    }
    public class ComboBoxSetting
    {
        public static void Set(ComboBox comboBox)
        {
            // Attach event to change color when an item is selected
            comboBox.SelectedIndexChanged += (s, e) =>
            {
                if (comboBox.SelectedIndex >= 0)
                {
                    comboBox.ForeColor = SystemColors.WindowText;
                }
            };

            comboBox.DropDown += (s, e) =>
            {
                comboBox.ForeColor = SystemColors.WindowText;
            };

            // Attach event to reset the placeholder text if no selection is made
            comboBox.DropDownClosed += (s, e) =>
            {
                if (comboBox.SelectedIndex == -1)
                {
                    comboBox.ForeColor = Color.Gray;
                }
            };
        }
        public static void SetupYearMonthDayComboBoxes(ComboBox yearComboBox, ComboBox monthComboBox, ComboBox dayComboBox)
        {
            DateTime today = DateTime.Today;
            DateTime rangeEnd = today.AddDays(90);

            // Populate the year and month ComboBox within a 90 days range from today
            int startYear = today.Year;
            int endYear = rangeEnd.Year;

            for (int year = startYear; year <= endYear; year++)
            {
                yearComboBox.Items.Add(year);
            }

            // Attach event handlers to year and month ComboBoxes 
            yearComboBox.SelectedIndexChanged += (s, e) =>
            {
                UpdateMonthComboBox();
                UpdateDaysComboBox();
            };
            monthComboBox.SelectedIndexChanged += (s, e) => UpdateDaysComboBox();

            void UpdateMonthComboBox()
            {
                monthComboBox.Items.Clear();
                monthComboBox.Text = "Month";
                monthComboBox.ForeColor = Color.Gray;

                int selectedYear = (int)yearComboBox.SelectedItem;
                int startMonth = (selectedYear == startYear) ? today.Month : 1; // Start from current month if same year
                int endMonth = (selectedYear == endYear) ? rangeEnd.Month : 12; // End at the range end month if it's the end year

                for (int month = startMonth; month <= endMonth; month++)
                {
                    monthComboBox.Items.Add(month);
                }
            }

            void UpdateDaysComboBox()
            {
                // Clear existing items in the day ComboBox
                dayComboBox.Items.Clear();
                dayComboBox.Text = "Day";
                dayComboBox.ForeColor = Color.Gray;

                // Check if both year and month are selected
                if (yearComboBox.SelectedItem != null && monthComboBox.SelectedItem != null)
                {
                    int selectedYear = (int)yearComboBox.SelectedItem;
                    int selectedMonth = (int)monthComboBox.SelectedItem;

                    // Determine the number of days in the selected month and year
                    int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);

                    // Populate the day ComboBox based on the days in the selected month
                    int startDay = today.Month == selectedMonth ? today.Day + 1 : 1;
                    for(int day = startDay; day <= daysInMonth; day++)
                    {
                        dayComboBox.Items.Add(day);
                    }
                }
            }
        }
        public static void SetupHourMinuteComboBoxes(ComboBox hourComboBox, ComboBox minuteComboBox)
        {
            for (int hour = 8; hour < 19;  hour++)
            {
                hourComboBox.Items.Add(hour);
            }
            for (int minute = 0; minute <= 60; minute += 5)
            {
                minuteComboBox.Items.Add(minute.ToString("D2"));
            }
        }
        public static void SetUpDependentComboBox<T>(ComboBox primaryComboBox, ComboBox dependentComboBox,
            List<T> list, PropertyInfo primaryProperty, PropertyInfo dependentProperty)
        {
            primaryComboBox.SelectedIndexChanged += (sender, e) =>
            {
                // Clear previous items in the dependent ComboBox
                dependentComboBox.Items.Clear();

                foreach (var item in list)
                {
                    // Get the value of the primary property for the current item
                    var primaryValue = primaryProperty.GetValue(item)?.ToString();

                    // Check if this primary property value matches the selected item in the primary ComboBox
                    if (primaryValue == primaryComboBox.Text)
                    {
                        // If it matches, get the dependent property value and add it to the dependent ComboBox
                        var dependentValue = dependentProperty.GetValue(item)?.ToString();
                        dependentComboBox.Items.Add(dependentValue);
                    }
                }
            };
        }
    }
} 
