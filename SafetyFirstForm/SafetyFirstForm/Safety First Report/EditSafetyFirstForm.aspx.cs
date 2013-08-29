using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.WebPartPages;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SafetyFirstForm.Layouts.SafetyFirstForm
{
    public partial class EditSafetyFirstForm : WebPartPage
    {
        //protected SPContext _context = SPContext.Current;
        //protected SPFormContext _formContext = SPContext.Current.FormContext;
            
        protected void Page_Load(object sender, EventArgs e)
        {
            string vid = Request.QueryString["vid"];
            //string ResolutionStatus = ResolutionStatusField.Value.ToString();
            //if (ResolutionStatusField.Value["Closed"])
            //if (ResolutionStatus == "Closed")
            //if (ResolutionStatusField.Value.ToString() = "Closed")
            if (field_ResolutionStatus.Value.ToString() == "Closed")
            {
                pnlComplete.Visible = true;
            }

            if (!Page.IsPostBack)
            {
                switch (vid) {
                    case "Initiator":
                        conditionalBreak.Visible = true;
                        break;
                    case "Supervisor":
                        field_ResolutionStatus.ControlMode = SPControlMode.Edit;
                        field_SupervisorRecChanges.ControlMode = SPControlMode.Edit;
                        field_InitialContact.ControlMode = SPControlMode.Edit;
                        conditionalBreak.Visible = false;
                        field_DelegatedResource.ControlMode = SPControlMode.Edit;
                        break;
                    case "Director":
                        field_ResolutionStatus.ControlMode = SPControlMode.Edit;
                        conditionalBreak.Visible = true;
                        field_DirectorRecChanges.ControlMode = SPControlMode.Edit;
                        field_DelegatedResource.ControlMode = SPControlMode.Edit;
                        break;
                    case "AGM":
                        field_ResolutionStatus.ControlMode = SPControlMode.Edit;
                        conditionalBreak.Visible = true;
                        field_AGMRecChanges.ControlMode = SPControlMode.Edit;
                        field_DelegatedResource.ControlMode = SPControlMode.Edit;
                        break;
                    case "Delegate":
                        field_ResolutionStatus.ControlMode = SPControlMode.Edit;
                        conditionalBreak.Visible = true;
                        field_DelegatedRecChanges.ControlMode = SPControlMode.Edit;
                        break;
                    case "Admin":
                        //Make all fields editable
                        field_AGM.ControlMode = SPControlMode.Edit;
                        field_AGMRecChanges.ControlMode = SPControlMode.Edit;
                        field_BusGarage.ControlMode = SPControlMode.Edit;
                        field_BusNumber.ControlMode = SPControlMode.Edit;
                        field_BusRouteNumber.ControlMode = SPControlMode.Edit;
                        field_CellPhone.ControlMode = SPControlMode.Edit;
                        field_DelegatedRecChanges.ControlMode = SPControlMode.Edit;
                        field_DelegatedResource.ControlMode = SPControlMode.Edit;
                        field_Department.ControlMode = SPControlMode.Edit;
                        field_Director.ControlMode = SPControlMode.Edit;
                        field_DirectorRecChanges.ControlMode = SPControlMode.Edit;
                        field_Division.ControlMode = SPControlMode.Edit;
                        field_EMail.ControlMode = SPControlMode.Edit;
                        field_EmployeeRecChanges.ControlMode = SPControlMode.Edit;
                        field_HazardDescription.ControlMode = SPControlMode.Edit;
                        field_IncidentDate.ControlMode = SPControlMode.Edit;
                        field_IncidentReportingDate.ControlMode = SPControlMode.Edit;
                        field_InitialContact.ControlMode = SPControlMode.Edit;
                        field_JobTitle.ControlMode = SPControlMode.Edit;
                        field_LoggedBy.ControlMode = SPControlMode.Edit;
                        field_LVEReferenced.ControlMode = SPControlMode.Edit;
                        field_PostHIRACode.ControlMode = SPControlMode.Edit;
                        field_PreHIRACode.ControlMode = SPControlMode.Edit;
                        field_PrimaryNumber.ControlMode = SPControlMode.Edit;
                        field_ResolutionCompleteDiscussion.ControlMode = SPControlMode.Edit;
                        field_ResolutionStatus.ControlMode = SPControlMode.Edit;
                        field_Supervisor.ControlMode = SPControlMode.Edit;
                        field_SupervisorRecChanges.ControlMode = SPControlMode.Edit;
                        break;
                        //foreach (Control control in formContext.FieldControlCollection)
                        //foreach (SPControlMode control in SPContext.Current.FormContext.FieldControlCollection)
                        //foreach (Control control in SPContext.Current.FormContext.FieldControlCollection)
                        //{
                        //    if (control is BaseFieldControl)
                        //    {
                        //        BaseFieldControl baseField = (BaseFieldControl)control;
                        //        baseField.ControlMode = SPControlMode.Edit;
                        //    }
                        //}

                        //SPSite site = SPContext.Current.Site;
                        //SPWeb oWeb = site.OpenWeb();
                        //SPFormContext formContext = SPContext.Current.FormContext;
                        //SPList oList = oWeb.Lists["Safety First Report"];
                        //SPListItemCollection listItems = oList.Items;
                        //SPFieldCollection fieldCollection = oList.Fields;
                        //var mode = SPControlMode.Edit;
                        //foreach (SPField field in fieldCollection)
                        //{
                        //    SPContext renderContext = SPContext.GetContext(HttpContext.Current, itemId,)
                        //    BaseFieldControl bfc = field.FieldRenderingControl;
                        //    //string fieldID = field.Id.ToString();
                        //    if (field.FieldRenderingControl.ToString() == "Display")
                        //    {
                        //        bfc.Value = "Edit";
                        //    }
                        //}
                }
            }
        }
    }
}