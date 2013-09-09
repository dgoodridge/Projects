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
                if (vid == null)
                {
                    field_AGM.ControlMode = SPControlMode.Display;
                    field_AGMRecChanges.ControlMode = SPControlMode.Display;
                    field_BusGarage.ControlMode = SPControlMode.Display;
                    field_BusNumber.ControlMode = SPControlMode.Display;
                    field_BusRouteNumber.ControlMode = SPControlMode.Display;
                    field_CellPhone.ControlMode = SPControlMode.Display;
                    field_DelegatedRecChanges.ControlMode = SPControlMode.Display;
                    field_DelegatedResource.ControlMode = SPControlMode.Display;
                    field_Department.ControlMode = SPControlMode.Display;
                    field_Director.ControlMode = SPControlMode.Display;
                    field_DirectorRecChanges.ControlMode = SPControlMode.Display;
                    field_Division.ControlMode = SPControlMode.Display;
                    field_EMail.ControlMode = SPControlMode.Display;
                    field_EmployeeRecChanges.ControlMode = SPControlMode.Display;
                    field_HazardDescription.ControlMode = SPControlMode.Display;
                    field_IncidentDate.ControlMode = SPControlMode.Display;
                    field_IncidentReportingDate.ControlMode = SPControlMode.Display;
                    field_InitialContact.ControlMode = SPControlMode.Display;
                    field_JobTitle.ControlMode = SPControlMode.Display;
                    field_LoggedBy.ControlMode = SPControlMode.Display;
                    field_LVEReferenced.ControlMode = SPControlMode.Display;
                    field_PostHIRACode.ControlMode = SPControlMode.Display;
                    field_PreHIRACode.ControlMode = SPControlMode.Display;
                    field_PrimaryNumber.ControlMode = SPControlMode.Display;
                    field_ResolutionCompleteDiscussion.ControlMode = SPControlMode.Display;
                    field_ResolutionStatus.ControlMode = SPControlMode.Display;
                    field_Supervisor.ControlMode = SPControlMode.Display;
                    field_SupervisorRecChanges.ControlMode = SPControlMode.Display;
                    conditionalBreak.Visible = true;
                }
                else
                {
                    switch (vid)
                    {
                        //case "":
                        //field_AGM.ControlMode = SPControlMode.Display;
                        //field_AGMRecChanges.ControlMode = SPControlMode.Display;
                        //field_DelegatedRecChanges.ControlMode = SPControlMode.Display;
                        //field_DelegatedResource.ControlMode = SPControlMode.Display;
                        //field_Director.ControlMode = SPControlMode.Display;
                        //field_DirectorRecChanges.ControlMode = SPControlMode.Display;
                        //field_IncidentDate.ControlMode = SPControlMode.Display;
                        //field_IncidentReportingDate.ControlMode = SPControlMode.Display;
                        //field_InitialContact.ControlMode = SPControlMode.Display;
                        //field_LVEReferenced.ControlMode = SPControlMode.Display;
                        //field_PostHIRACode.ControlMode = SPControlMode.Display;
                        //field_PreHIRACode.ControlMode = SPControlMode.Display;
                        //field_ResolutionCompleteDiscussion.ControlMode = SPControlMode.Display;
                        //field_ResolutionStatus.ControlMode = SPControlMode.Display;
                        //field_Supervisor.ControlMode = SPControlMode.Display;
                        //field_SupervisorRecChanges.ControlMode = SPControlMode.Display;
                        //conditionalBreak.Visible = true;
                        //    break;
                        case "Supervisor":
                            field_AGM.ControlMode = SPControlMode.Display;
                            field_AGMRecChanges.ControlMode = SPControlMode.Display;
                            field_DelegatedRecChanges.ControlMode = SPControlMode.Display;
                            field_Director.ControlMode = SPControlMode.Display;
                            field_DirectorRecChanges.ControlMode = SPControlMode.Display;
                            field_IncidentDate.ControlMode = SPControlMode.Display;
                            field_IncidentReportingDate.ControlMode = SPControlMode.Display;
                            field_LVEReferenced.ControlMode = SPControlMode.Display;
                            field_PostHIRACode.ControlMode = SPControlMode.Display;
                            field_PreHIRACode.ControlMode = SPControlMode.Display;
                            field_PrimaryNumber.ControlMode = SPControlMode.Display;
                            field_ResolutionCompleteDiscussion.ControlMode = SPControlMode.Display;
                            field_Supervisor.ControlMode = SPControlMode.Display;
                            // Allow Supervisor to edit relevant fields
                            //field_ResolutionStatus.ControlMode = SPControlMode.Edit;
                            //field_SupervisorRecChanges.ControlMode = SPControlMode.Edit;
                            //field_InitialContact.ControlMode = SPControlMode.Edit;
                            //conditionalBreak.Visible = false;
                            //field_DelegatedResource.ControlMode = SPControlMode.Edit;
                            break;
                        case "Director":
                            field_AGM.ControlMode = SPControlMode.Display;
                            field_AGMRecChanges.ControlMode = SPControlMode.Display;
                            field_DelegatedRecChanges.ControlMode = SPControlMode.Display;
                            field_Director.ControlMode = SPControlMode.Display;
                            field_IncidentDate.ControlMode = SPControlMode.Display;
                            field_IncidentReportingDate.ControlMode = SPControlMode.Display;
                            field_InitialContact.ControlMode = SPControlMode.Display;
                            field_LVEReferenced.ControlMode = SPControlMode.Display;
                            field_PostHIRACode.ControlMode = SPControlMode.Display;
                            field_PreHIRACode.ControlMode = SPControlMode.Display;
                            field_PrimaryNumber.ControlMode = SPControlMode.Display;
                            field_ResolutionCompleteDiscussion.ControlMode = SPControlMode.Display;
                            field_Supervisor.ControlMode = SPControlMode.Display;
                            field_SupervisorRecChanges.ControlMode = SPControlMode.Display;
                            conditionalBreak.Visible = true;
                            // Allow Director to edit relevant fields
                            //field_ResolutionStatus.ControlMode = SPControlMode.Edit;
                            //field_DirectorRecChanges.ControlMode = SPControlMode.Edit;
                            //field_DelegatedResource.ControlMode = SPControlMode.Edit;
                            break;
                        case "AGM":
                            field_AGM.ControlMode = SPControlMode.Display;
                            field_DelegatedRecChanges.ControlMode = SPControlMode.Display;
                            field_Director.ControlMode = SPControlMode.Display;
                            field_DirectorRecChanges.ControlMode = SPControlMode.Display;
                            field_IncidentDate.ControlMode = SPControlMode.Display;
                            field_IncidentReportingDate.ControlMode = SPControlMode.Display;
                            field_InitialContact.ControlMode = SPControlMode.Display;
                            field_LVEReferenced.ControlMode = SPControlMode.Display;
                            field_PostHIRACode.ControlMode = SPControlMode.Display;
                            field_PreHIRACode.ControlMode = SPControlMode.Display;
                            field_PrimaryNumber.ControlMode = SPControlMode.Display;
                            field_ResolutionCompleteDiscussion.ControlMode = SPControlMode.Display;
                            field_Supervisor.ControlMode = SPControlMode.Display;
                            field_SupervisorRecChanges.ControlMode = SPControlMode.Display;
                            conditionalBreak.Visible = true;
                            // Allow AGM to edit relevant fields
                            //field_ResolutionStatus.ControlMode = SPControlMode.Edit;
                            //field_AGMRecChanges.ControlMode = SPControlMode.Edit;
                            //field_DelegatedResource.ControlMode = SPControlMode.Edit;
                            break;
                        case "Delegate":
                            field_AGM.ControlMode = SPControlMode.Display;
                            field_AGMRecChanges.ControlMode = SPControlMode.Display;
                            field_DelegatedResource.ControlMode = SPControlMode.Display;
                            field_Director.ControlMode = SPControlMode.Display;
                            field_DirectorRecChanges.ControlMode = SPControlMode.Display;
                            field_IncidentDate.ControlMode = SPControlMode.Display;
                            field_IncidentReportingDate.ControlMode = SPControlMode.Display;
                            field_InitialContact.ControlMode = SPControlMode.Display;
                            field_LVEReferenced.ControlMode = SPControlMode.Display;
                            field_PostHIRACode.ControlMode = SPControlMode.Display;
                            field_PreHIRACode.ControlMode = SPControlMode.Display;
                            field_ResolutionCompleteDiscussion.ControlMode = SPControlMode.Display;
                            field_Supervisor.ControlMode = SPControlMode.Display;
                            field_SupervisorRecChanges.ControlMode = SPControlMode.Display;
                            conditionalBreak.Visible = true;
                            // Allow delegate to edit relevant fields                
                            //field_ResolutionStatus.ControlMode = SPControlMode.Edit;
                            //field_DelegatedRecChanges.ControlMode = SPControlMode.Edit;
                            break;
                        case "Safety":
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
                    }
                }
            }
        }
    }
}