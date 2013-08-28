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
            string vid = Request.QueryString["vid"];
            if (!Page.IsPostBack)
            {
                switch (vid)
                {
                    case null:
                        hideMe.Visible = false;
                        break;
                }
            }
        }

        //protected void AnonymousReportingField_ValueChanged(object sender, EventArgs e)
        //{
        //    savebutton.Visible = false;
        //    printbutton.Visible = true;
        //}

        protected void printbutton_Click(object sender, EventArgs e)
        {
            
            
        }

    }
}
