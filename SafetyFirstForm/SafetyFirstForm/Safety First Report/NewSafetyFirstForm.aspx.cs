using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.WebPartPages;

namespace SafetyFirstForm.Layouts.SafetyFirstForm
{
    public partial class NewSafetyFirstForm : WebPartPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void AnonymousReportingField_ValueChanged(object sender, EventArgs e)
        {
            savebutton.Visible = false;
            printbutton.Visible = true;
        }

        protected void printbutton_Click(object sender, EventArgs e)
        {
            
            
        }

    }
}
