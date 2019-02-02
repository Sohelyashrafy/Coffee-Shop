using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1st_Assignment
{
    public partial class CoffeeShopUi : Form
    {
        public CoffeeShopUi()
        {
            InitializeComponent();
        }

        private void SaveUi_Click(object sender, EventArgs e)
        {
            string customerName = CustomerName.Text;
            int contactNo = Convert.ToInt32(ContactNo.Text);
            string address = Address.Text;
            string order = comboBox1.Text;
            int quantity = Convert.ToInt32(Quantity.Text);

            int Black = 120;
            int Cold = 100;
            int Hot = 90;
            int Reguler = 80;
            int TotalPrice = 0;

            if (order == "Black")
            {
               TotalPrice=  quantity * Black ; }
                else if ( order == "Cold")
            {
                TotalPrice = quantity * Cold; }
                else if (order == "Hot")
            {
                TotalPrice = quantity * Hot; }
                else if (order == "Regular")
            {
                TotalPrice = quantity * Reguler; }
                else 
            {
                MessageBox.Show ( "Select Your Order") ; }
            PaymentInformation.Text = ( "===PaymentInformation===" +"\n"+"\n"+"Customer Name:"+ customerName + "\n"+"Contact No:"+ contactNo + "\n"+"Address:"+ address + "\n"+"Order:" + order + "\n"+"Quantity:" + quantity + "\n"+"\n"+"Totatl Price:" + TotalPrice );

        }

    }
}
