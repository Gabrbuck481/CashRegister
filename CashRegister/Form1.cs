using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double slicePrice = 1.50;
        double drinkPrice = 1.75;
        double garlicPrice = 2.00;
        double wingsPrice = 3.00;
        double familyPrice = 13.75;

        int numOfSlices = 0;
        int numOfDrink = 0;
        int numOfGarlic = 0;
        int numOfWings = 0;
        int numOfFamily = 0;

        double subTotal = 0;
        double taxAmount = 0;
        double total = 0;

        double taxRate = 0.13;


        public Form1()
        {
            InitializeComponent();
            titleLabel.Parent = flagImageBox;
            titleLabel2.Parent = flagImageBox;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            numOfSlices = Convert.ToInt16(slicesInput.Text);
            numOfDrink = Convert.ToInt16(drinkInput.Text);
            numOfGarlic = Convert.ToInt16(garlicInput.Text);
            numOfWings = Convert.ToInt16(wingsInput.Text);
            numOfFamily = Convert.ToInt16(familyInput.Text);

            subTotal = numOfSlices * slicePrice + numOfDrink * drinkPrice + numOfGarlic * garlicPrice + numOfWings * wingsPrice + numOfFamily * familyPrice;
            taxAmount = subTotal * taxRate;
            total = subTotal + taxAmount;

            subTotalOutputLabel.Text = subTotal.ToString("C");
            taxOutput.Text = taxAmount.ToString("C");
            totalOutputLabel.Text = total.ToString("C");

            SoundPlayer player = new SoundPlayer(Properties.Resources.Cash_Register_sound);

            player.Play();

        }




        private void confirmOrderButton_Click(object sender, EventArgs e)
        {

            SoundPlayer player = new SoundPlayer(Properties.Resources.Print_Sound);

            player.Play();

            

            receiptLabel.Text = $"    FREDRICK FAZBEARINGTON'S    \n\n\n";
            receiptLabel.Refresh();
            Thread.Sleep(1000);


            receiptLabel.Text += $"    October 21, 1987, 3:42 p.m.    \n\n";
            receiptLabel.Refresh();
            Thread.Sleep(1000);

            player.Play();
           
            receiptLabel.Text += $"Slices  {numOfSlices}  @{slicePrice.ToString("C")} \n\n";
            receiptLabel.Refresh();
            Thread.Sleep(1000);
            
            receiptLabel.Text += $"Drink  {numOfDrink}  @{drinkPrice.ToString("C")} \n\n";
            receiptLabel.Refresh();
            Thread.Sleep(1000);
            
            player.Play();
           
            receiptLabel.Text += $"Garlic Bread  {numOfGarlic}  @{garlicPrice.ToString("C")} \n\n";
            receiptLabel.Refresh();
            Thread.Sleep(1000);

            receiptLabel.Text += $"Chicken Wings  {numOfWings}  @{wingsPrice.ToString("C")} \n\n";
            receiptLabel.Refresh();
            Thread.Sleep(1000);
            
            player.Play();
            
            receiptLabel.Text += $"Family Combo {numOfFamily}  @{familyPrice.ToString("C")} \n\n";
            receiptLabel.Refresh();
            Thread.Sleep(1000);

            receiptLabel.Text += $"Subtotal {subTotal}  @{subTotal.ToString("C")} \n\n";
            receiptLabel.Refresh();
            Thread.Sleep(1000);
            
            player.Play();
           
            receiptLabel.Text += $"Tax {taxRate}  @{taxAmount.ToString("C")} \n\n";
            receiptLabel.Refresh();
            Thread.Sleep(1000);
           
            receiptLabel.Text += $"Total {total}  @{total.ToString("C")} \n\n";
            receiptLabel.Refresh();
            Thread.Sleep(1000);
           
            player.Play();
           
            receiptLabel.Text += $"HAVE A NICE DAY!";



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
