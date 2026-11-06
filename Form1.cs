namespace Lucky_Cafe_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void lblDrink_Click(object sender, EventArgs e)
        {

        }

        private void grpOrderList_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculateOrder_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            double drinkPrice = 0;
            string drinkName = "";

            if (rdoTea.Checked)
            {
                drinkPrice = 1;
                drinkName = "Tea";
            }
            else if (rdoCoffee.Checked)
            {
                drinkPrice = 2;
                drinkName = "Coffee";
            }
            else if (rdoJuice.Checked)
            {
                drinkPrice = 3;
                drinkName = "Juice";
            }
            else
            {
                MessageBox.Show("Please select a drink.");
                return;
            }

            lstOrderList.Items.Clear();

            Random random = new Random();
            bool gotLucky = false;

            for (int i = 1; i <= quantity; i++)
            {
                int luckyNumber = random.Next(1, 51);

                lstOrderList.Items.Add(
                    i + ") " + txtCustomerName.Text + " - " +
                    drinkName + " - Lucky: " + luckyNumber +
                    " - $" + drinkPrice.ToString("0.00"));

                if (luckyNumber == 7 || luckyNumber == 17)
                {
                    gotLucky = true;
                }
            }

            double total = drinkPrice * quantity;

            lblBeforeDiscount.Text =
                "Total Before Discount: $" + total.ToString("0.00");

            if (chkStudentMember.Checked)
            {
                total = total * 0.90;
                lblMemberDiscount.Text = "Member Discount: 10%";
            }
            else
            {
                lblMemberDiscount.Text = "Member Discount: 0%";
            }

            lblTotalPrice.Text =
                "Total After Discount: $" + total.ToString("0.00");

            lblFinalTotal.Text =
                "Total Price: $" + total.ToString("0.00");

            if (gotLucky)
            {
                lblFinalLucky.Text =
                    "Lucky Message: You got a Free Cookie!";

                lblLuckyMessage.Text =
                    "Lucky Message: You got a Free Cookie!";
            }
            else
            {
                lblFinalLucky.Text =
                    "Lucky Message: No prize this time.";

                lblLuckyMessage.Text =
                    "Lucky Message: No prize this time.";
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (lstOrderList.Items.Count == 0)
            {
                MessageBox.Show("No order to save.");
                return;
            }

            StreamWriter writer = File.AppendText("orders.txt");

            foreach (var item in lstOrderList.Items)
            {
                writer.WriteLine(item);
            }

            writer.WriteLine(lblFinalTotal.Text);
            writer.WriteLine(lblFinalLucky.Text);

            writer.Close();

            MessageBox.Show("Order saved.");
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("orders.txt"))
            {
                MessageBox.Show("No file found.");
                return;
            }

            lstOrderList.Items.Clear();

            StreamReader reader = File.OpenText("orders.txt");

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                lstOrderList.Items.Add(line);
            }

            reader.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtQuantity.Clear();
            lstOrderList.Items.Clear();

            lblFinalTotal.Text = "Total Price:";
            lblFinalLucky.Text = "Lucky Message:";

            lblMemberDiscount.Text = "Member Discount:";
            lblBeforeDiscount.Text = "Total Before Discount:";
            lblTotalPrice.Text = "Total After Discount:";
            lblLuckyMessage.Text = "Lucky Message:";

            chkStudentMember.Checked = false;
        }
    }
}