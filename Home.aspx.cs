using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace OnlineBankingSystem
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbClass dbClass = new DbClass();

            DataSet ds = new DataSet();

            txt_balance.Text = Convert.ToString(dbClass.GetCurrentBalance());

            ds = dbClass.viewTransactions();

            grdView.DataSource = ds;

            grdView.DataBind();
        }

        protected void btn_fundtransfer_Click(object sender, EventArgs e)
        {
            Response.Redirect("FundTransfer.aspx");
        }
    }
}