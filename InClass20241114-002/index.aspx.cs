using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass20241114_002
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)    // Only run this code if it's not a PostBack
            {
                // How can we run this only one time?
                // This method runs when the page is loaded into a browser window
                // Add a pizza company to the list box 
                lbPizzaCompanies.Items.Add("LaRosa's");
                //Add a few more items to the list box
                lbPizzaCompanies.Items.Add("Grammas");
                lbPizzaCompanies.Items.Add("Godd Fellas");

                cblIngredients.Items.Add("Cheese");
                cblIngredients.Items.Add("Tomato");
                cblIngredients.Items.Add("Parsley");

            }
        }

        protected void cmdSelectPizzaCompany_Click(object sender, EventArgs e)
        {
            //We call this an "event handler"
            //This code runs when the cmdSelectPizzaCompany button is clicked
            //Write the currently selected pizza company in the list into the label
            // We are using the text property of the Label
            // we need to get the item from the list box
            lblSelectedPizzaCompany.Text = lbPizzaCompanies.Text;
        }
    }
}