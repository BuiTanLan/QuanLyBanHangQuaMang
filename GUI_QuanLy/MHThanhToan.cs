using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class MHThanhToan : Form
    {
        String selectedYear;
        int numberOfYears = 20;

        public MHThanhToan()
        {
            InitializeComponent();

            //monthCB.Items.AddRange(new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            //monthCB.SelectedIndex = 0;
            setYears();
            setMonth();
        }

        private void setYears()
        {
            int currentYearInt = DateTime.Now.Year;
            for (int i = 0; i <= numberOfYears; i++)
            {
                yearCB.Items.Add((currentYearInt + i).ToString());
            }
            yearCB.SelectedIndex = 0;
            selectedYear = yearCB.Items[0].ToString();
        }

        private void setMonth()
        {
            monthCB.Items.Clear();
            int currentMonth = selectedYear == DateTime.Now.Year.ToString() ? DateTime.Now.Month : 1;
            for (int i = currentMonth; i <= 12; i++)
            {
                monthCB.Items.Add(i.ToString());
            }
            monthCB.SelectedIndex = 0;
        }

        private void setPaymentDisplay(bool cashPayment)
        {
            paymentInfoGroupBox.Enabled = !cashPayment;
        }

        // Event functions
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setPaymentDisplay(false);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            setPaymentDisplay(false);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            setPaymentDisplay(false);
        }

        // radioButton4 = cash option
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            setPaymentDisplay(true);
        }

        private void continueShoppingButton_Click(object sender, EventArgs e)
        {

        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {

        }

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedYear = yearCB.SelectedItem.ToString();
            setMonth();
        }
    }
}
