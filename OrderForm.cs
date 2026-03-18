using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class OrderForm : Form
    {

        private float _TotalPrice;
        public OrderForm()
        {
            InitializeComponent();
        }

     

    
     

       
        private void UpdateDiningOption()
        {
            if (rdTakeout.Checked)
            {
                labForWhereToEat.Text = rdTakeout.Text;
            }
            else 
            {
                labForWhereToEat.Text = rdEatIn.Text;

            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

            UpdateOrderSummary(null, null);
        }


        private float GetToppingsPrice()
        {
        
            float totalPrice = 0;
            string toppings = "";

            foreach (Control ctrl in gbToppings.Controls)
            {
                if (ctrl is CheckBox chk && chk.Checked)
                {
                    toppings += chk.Text + ", ";
                    totalPrice += Convert.ToSingle(chk.Tag);
                }
            }

            labForToppings.Text = toppings.TrimEnd(',', ' ');
            return totalPrice;
        }
        private float GetCrustPrice()
        {
            float totalPrice = 0;
            // crust
            if (rdThick.Checked)
            {
                totalPrice = Convert.ToSingle(rdThick.Tag);
                labForCrustType.Text = rdThick.Text;

            }
            else 
            {
                totalPrice = Convert.ToSingle(rdThin.Tag);
                labForCrustType.Text = rdThin.Text;


            }
            return totalPrice;
        }
        private float GetSizePrice()
        {
            float totalPrice = 0;
            if (rdLarg.Checked)
            {
                labForSize.Text = rdLarg.Text;

                totalPrice = Convert.ToSingle(rdLarg.Tag);

            }
            else if (rdMedium.Checked)
            {
                labForSize.Text = rdMedium.Text;

                totalPrice = Convert.ToSingle(rdMedium.Tag);

            }
            else 
            {
                labForSize.Text = rdSmall.Text;

                totalPrice = Convert.ToSingle(rdSmall.Tag);

            }
            return (float)totalPrice;
        }
        private void UpdateOrderSummary(object sender, EventArgs e)
        {
           
            _TotalPrice = GetToppingsPrice() + GetCrustPrice() + GetSizePrice();
            UpdateDiningOption();

            labForTotalPrice.Text = _TotalPrice.ToString("C") ;
        }
        private void ResetAllControls()
        {
            foreach (Control ctrl in gbToppings.Controls)
            {
                if (ctrl is CheckBox chk)
                {
                    chk.Checked = false;
                }
            }
            rdSmall.Checked = true;
            rdThin.Checked = true;
            rdEatIn.Checked = true;
            UpdateOrderSummary(null, null);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAllControls();
        }

        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            string toppingsSummary = string.IsNullOrWhiteSpace(labForToppings.Text)
                               ? "No Toppings"
                               : labForToppings.Text;


            string OrderMessage =
                $@"Are you sure you want to place this order?

                Dining: {labForWhereToEat.Text}
                Toppings: {toppingsSummary}
                Crust Type: {labForCrustType.Text}
                Size: {labForSize.Text}
                Price: {labForTotalPrice.Text}";
           
            DialogResult result= MessageBox.Show(OrderMessage, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Your Order has been placed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ResetAllControls();
            }
        }
    }

}
