﻿using System;
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
    public partial class DisplayQuote : Form
    {
        private DeskQuote DeskQuote;
        public DisplayQuote(DeskQuote deskQuote)
        {
            DeskQuote = deskQuote;
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            CustomerText.Text = DeskQuote.customerName;
            QuoteDateText.Text = DeskQuote.orderDate;
            string width = Convert.ToString(DeskQuote.desk.Width);
            string depth = Convert.ToString(DeskQuote.desk.Depth);
            string drawers = Convert.ToString(DeskQuote.desk.DrawerNumber);
            string shippingDays = Convert.ToString(DeskQuote.desk.ShippingDays);
            string material = DeskQuote.desk.Material;
            int SurfaceTotal = DeskQuote.desk.Width * DeskQuote.desk.Depth;

            string total = Convert.ToString(SurfaceTotal); 

            WidthText.Text = width;
            DepthText.Text = depth;
            DrawersText.Text = drawers + " drawers";
            MaterialTypeText.Text = material;
            DeliveryTimeText.Text = shippingDays + " days";
            TotalSizeText.Text = total + " in^2";
        }
    }
}
