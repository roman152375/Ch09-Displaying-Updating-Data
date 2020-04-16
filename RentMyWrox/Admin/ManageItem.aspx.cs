using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RentMyWrox;

namespace RentMyWrox.Admin
{
    public partial class ManageItem : WebFormsBaseClass
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void SavedItem_Clicked(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string description = tbDescription.Text;
            string itemnumber = tbItemNumber.Text;
            double cost = double.Parse(tbCost.Text);
            DateTime acquiredDate = DateTime.Parse(tbAcquiredDate.Text);
            byte[] uploadedFileContent = fuPicture.FileBytes;
        }
    }
}