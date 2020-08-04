using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBankingSystem
{
    public partial class FundTransfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Transfer_Click(object sender, EventArgs e)
        {
            string account_number = txt_accountnumber.Text;
            Int32 amount = Convert.ToInt32(txt_amount.Text);
            DbClass dbClass = new DbClass();
            string temp = "";
            temp = amount + "  transferred to account  " + account_number;
            int r = dbClass.AddTransaction(amount, temp);

            if (r > 0)
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}