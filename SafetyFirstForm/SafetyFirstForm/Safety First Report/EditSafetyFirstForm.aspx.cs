using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.WebPartPages;
namespace SafetyFirstForm.Layouts.SafetyFirstForm
{
    public partial class EditSafetyFirstForm : WebPartPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string vid = Request.QueryString["vid"];
            //string ResolutionStatus = ResolutionStatusField.Value.ToString();
            //if (ResolutionStatusField.Value["Closed"])
            //if (ResolutionStatus == "Closed")
            //if (ResolutionStatusField.Value.ToString() = "Closed")
            if (ResolutionStatusField.Value.ToString() == "Closed")
            {
                pnlComplete.Visible = true;
            }

            if (!Page.IsPostBack)
            {
                switch (vid) {
                    case "Initiator":
                        ConditionalBreak.Visible = true;
                        break;
                    case "Supervisor":
                        //The following is my attempt to change control mode. Got it in 4 tries!
                        //SupervisorRecChangesField.ControlMode = Display;
                        //SupervisorRecChangesField.ControlMode = "Display";
                        //SupervisorRecChangesField.ControlMode.Equals["Display"];
                        ResolutionStatusField.ControlMode = SPControlMode.Edit;
                        SupervisorRecChangesField.ControlMode = SPControlMode.Edit;
                        InitialContactField.ControlMode = SPControlMode.Edit;
                        ConditionalBreak.Visible = false;
                        DelegatedResourceField.ControlMode = SPControlMode.Edit;
                        break;
                    case "Director":
                        ResolutionStatusField.ControlMode = SPControlMode.Edit;
                        ConditionalBreak.Visible = true;
                        DirectorRecChangesField.ControlMode = SPControlMode.Edit;
                        DelegatedResourceField.ControlMode = SPControlMode.Edit;
                        break;
                    case "AGM":
                        ResolutionStatusField.ControlMode = SPControlMode.Edit;
                        ConditionalBreak.Visible = true;
                        AGMRecChangesField.ControlMode = SPControlMode.Edit;
                        DelegatedResourceField.ControlMode = SPControlMode.Edit;
                        break;
                    case "Delegate":
                        ResolutionStatusField.ControlMode = SPControlMode.Edit;
                        ConditionalBreak.Visible = true;
                        DelegatedRecChangesField.ControlMode = SPControlMode.Edit;
                        break;
                    case "Admin":
                        //Make all fields editable - conversely, make editform with no vid uneditable
                        break;
                    
                }
            }
            
        }
        // This does not work. Need JS?
        protected void ResolutionStatusField_ValueChanged(object sender, EventArgs e)
        {

            //if (ResolutionStatusField.Value.ToString() == "Closed")
            //{
            //    pnlComplete.Visible = true;
            //}
        }
    }
}