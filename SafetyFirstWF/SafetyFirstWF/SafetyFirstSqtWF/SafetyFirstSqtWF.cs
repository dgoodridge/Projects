using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.WorkflowActions;

namespace SafetyFirstWF.SafetyFirstSqtWF
{
    public sealed partial class SafetyFirstSqtWF : SequentialWorkflowActivity
    {
        public SafetyFirstSqtWF()
        {
            InitializeComponent();
        }

        //private const string INCIDENT_REPORTING_DATE = "Incident Reporting Date";
        //private const string IS_APPEAL = "";
        //private const string LOGGED_BY_NAME = "Logged By";
        //private const string RESOLUTION_STATUS_CHOICE = "Resolution Status";
        //private const string SUPERVISOR_NAME = "Supervisor";
        //private const string INITIAL_CONTACT_BOOL = "";
        //private const string DIRECTOR_NAME = "Director";
        //private const string AGM_NAME = "AGM";
        //private const string DELEGATED_RESOURCE_NAME = "Delegated Resource";


        public Guid workflowId = default(System.Guid);
        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            using (SPWeb oWeb = workflowProperties.Web)
            {
                SPListItem currentItem = workflowProperties.Item;

                string resolutionStatus = (string)currentItem["Resolution Status"];
                string loggedBy = (string)currentItem["Logged By"];
                string supervisorName = (string)currentItem["Supervisor"];
                string directorName = (string)currentItem["Director"];
                string agmName = (string)currentItem["AGM"];
                string delegateName = (string)currentItem["Delegate Resource"];


            }
        }

        public string sendInitiationEmail_Subject = default(System.String);
        public string sendInitiationEmail_To = default(System.String);
        public string sendInitiationEmail_Body = default(System.String);

        private void sendInitiationEmail_MethodInvoking(object sender, EventArgs e)
        {
            sendInitiationEmail_Subject = string.Format("A new Safety First Report has been submitted");
            sendInitiationEmail_To = "danielgoodridge85@gmail.com";
            sendInitiationEmail_Body = string.Format("Testing");
        }

        private string GetInitiationEmails(string p)
        {
            throw new NotImplementedException();
        }
    }
}
