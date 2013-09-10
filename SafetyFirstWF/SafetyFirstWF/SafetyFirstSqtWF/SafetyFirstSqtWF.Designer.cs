using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace SafetyFirstWF.SafetyFirstSqtWF
{
    public sealed partial class SafetyFirstSqtWF
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            this.sendInitiationEmail = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logVariablesSet = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeGetVariables = new System.Workflow.Activities.CodeActivity();
            this.logWorkflowInitiated = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            // 
            // sendInitiationEmail
            // 
            this.sendInitiationEmail.BCC = null;
            activitybind1.Name = "SafetyFirstSqtWF";
            activitybind1.Path = "sendInitiationEmail_Body";
            this.sendInitiationEmail.CC = null;
            correlationtoken1.Name = "workflowToken";
            correlationtoken1.OwnerActivityName = "SafetyFirstSqtWF";
            this.sendInitiationEmail.CorrelationToken = correlationtoken1;
            this.sendInitiationEmail.From = null;
            this.sendInitiationEmail.Headers = null;
            this.sendInitiationEmail.IncludeStatus = false;
            this.sendInitiationEmail.Name = "sendInitiationEmail";
            activitybind2.Name = "SafetyFirstSqtWF";
            activitybind2.Path = "sendInitiationEmail_Subject";
            activitybind3.Name = "SafetyFirstSqtWF";
            activitybind3.Path = "sendInitiationEmail_To";
            this.sendInitiationEmail.MethodInvoking += new System.EventHandler(this.sendInitiationEmail_MethodInvoking);
            this.sendInitiationEmail.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.sendInitiationEmail.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.sendInitiationEmail.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            // 
            // logVariablesSet
            // 
            this.logVariablesSet.Description = "Variables Set";
            this.logVariablesSet.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logVariablesSet.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logVariablesSet.HistoryDescription = "";
            this.logVariablesSet.HistoryOutcome = "";
            this.logVariablesSet.Name = "logVariablesSet";
            this.logVariablesSet.OtherData = "";
            this.logVariablesSet.UserId = -1;
            // 
            // codeGetVariables
            // 
            this.codeGetVariables.Name = "codeGetVariables";
            this.codeGetVariables.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode);
            // 
            // logWorkflowInitiated
            // 
            this.logWorkflowInitiated.Description = "Workflow Initiated";
            this.logWorkflowInitiated.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logWorkflowInitiated.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logWorkflowInitiated.HistoryDescription = "";
            this.logWorkflowInitiated.HistoryOutcome = "";
            this.logWorkflowInitiated.Name = "logWorkflowInitiated";
            this.logWorkflowInitiated.OtherData = "";
            this.logWorkflowInitiated.UserId = -1;
            activitybind5.Name = "SafetyFirstSqtWF";
            activitybind5.Path = "workflowId";
            // 
            // onWorkflowActivated1
            // 
            this.onWorkflowActivated1.CorrelationToken = correlationtoken1;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind4.Name = "SafetyFirstSqtWF";
            activitybind4.Path = "workflowProperties";
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            // 
            // SafetyFirstSqtWF
            // 
            this.Activities.Add(this.onWorkflowActivated1);
            this.Activities.Add(this.logWorkflowInitiated);
            this.Activities.Add(this.codeGetVariables);
            this.Activities.Add(this.logVariablesSet);
            this.Activities.Add(this.sendInitiationEmail);
            this.Name = "SafetyFirstSqtWF";
            this.CanModifyActivities = false;

        }

        #endregion

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendInitiationEmail;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logVariablesSet;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logWorkflowInitiated;

        private CodeActivity codeGetVariables;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;




    }
}
