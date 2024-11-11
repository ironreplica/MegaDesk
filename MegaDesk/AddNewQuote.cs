using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddNewQuote : Form
    {
        private DeskQuote deskQuote = new DeskQuote();
        public AddNewQuote()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainMenu = (Form1)Tag;
            mainMenu.Show();
            Close();
        }

        private void WidthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newWidth;
                bool isNum = Int32.TryParse(input.Text, out newWidth);
                if (isNum)
                {
                    deskQuote.desk.Width = newWidth;
                    WidthErrorProvider.SetError(this.deskWidthTxt, "");
                }
                else
                {
                    WidthErrorProvider.SetError(this.deskWidthTxt, "Enter a number.");
                }
            }
            catch (Exception ex)
            {
                WidthErrorProvider.SetError(this.deskWidthTxt, "Input must be between 24 and 96 inches.");
            }
        }

        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                Type strType = typeof(string);
                // Checking if its a string
                bool isStr = input.Text is string str && str.Length > 3;
                if (isStr)
                {
                    deskQuote.customerName = input.Text;
                    NameErrorProvider.SetError(this.nameTxtBox, "");
                }
                else
                {
                    NameErrorProvider.SetError(this.nameTxtBox, "Input must be between a string at least 3 chars long");
                }
            }
            catch (Exception ex) {

                NameErrorProvider.SetError(this.nameTxtBox, "Input must be between a string");
            }
            
        }
        private void DepthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newDepth;
                bool isNum = Int32.TryParse(input.Text, out newDepth);
                if (isNum)
                {
                    deskQuote.desk.Depth = newDepth;
                    DepthErrorProvider.SetError(this.deskDepthTxt, "");
                }
                else
                {
                    DepthErrorProvider.SetError(this.deskDepthTxt, "Enter a number.");
                }
            }
            catch (Exception ex)
            {
                DepthErrorProvider.SetError(this.deskDepthTxt, "Input must be between 24 and 96 inches.");
            }
        }
        private void DeskDrawerAmount_Validating(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            try
            {
                string selection = input.Text.ToString();
                if (!string.IsNullOrEmpty(selection))
                {
                    deskQuote.desk.DrawerNumber = Int32.Parse(selection);
                    DeskDrawerAmountErrorProvider.SetError(this.deskDrawerAmountBox, "");
                }
                else
                {
                    DeskDrawerAmountErrorProvider.SetError(this.deskDrawerAmountBox, "Please select one of the options");
                }
            }
            catch (Exception ex) {
                DeskDrawerAmountErrorProvider.SetError(this.deskDrawerAmountBox, "Please select one of the options");
            }
        }
        private void ShippingTimeframe_Validating(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            try
            {
                string selection = input.Text.ToString();
                if (!string.IsNullOrEmpty(selection))
                {
                    deskQuote.shippingDays = selection;
                    ShippingTimeFrameErrorProvider.SetError(this.shippingTimeFrameBox, "");
                }
                else
                {
                    ShippingTimeFrameErrorProvider.SetError(this.shippingTimeFrameBox, "Please select one of the options");
                }
            }
            catch(Exception ex)
            {
                ShippingTimeFrameErrorProvider.SetError(this.shippingTimeFrameBox, "");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (deskWidthTxt.Text.Length == 0 || deskDepthTxt.Text.Length == 0 || deskDrawerAmountBox.Text.Length == 0) return;
            int surfaceArea = deskQuote.desk.getSurfaceArea();
            string orderDate = DateTime.Now.ToString();
            int shipping = deskQuote.desk.ShippingDays;
            DisplayQuote frm = new DisplayQuote(deskQuote);
            frm.Show();
            Close();
        }
    }
    
}
