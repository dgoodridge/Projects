﻿using System;
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

        public Guid workflowId = default(System.Guid);
        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            using (SPWeb oWeb = workflowProperties.Web)
            {
                SPListItem currentItem = workflowProperties.Item;

                string resolutionStatus = (string)currentItem["Resolution Status"];

            }
        }
    }
}
