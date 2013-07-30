using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;

namespace MyMARTATask.Features.MARTATaskReceiver
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("ae71d241-c1c8-4d3f-ad90-e198c4bc5f5c")]
    public class MARTATaskReceiverEventReceiver : SPFeatureReceiver
        {
        // Uncomment the method below to handle the event raised after a feature has been activated.
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPSite site = properties.Feature.Parent as SPSite;
            if (site != null)
            {
                SPContentType martaTaskContentType = site.RootWeb.ContentTypes["MARTATask"];
                if (martaTaskContentType != null)
                {
                    string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
                    string className = "MARTATask.TaskAddedReceiver";
                    SPEventReceiverDefinition eventReceiver = martaTaskContentType.EventReceivers.Add();
                    eventReceiver.Synchronization = SPEventReceiverSynchronization.Synchronous;
                    eventReceiver.Type = SPEventReceiverType.ItemAdding;
                    eventReceiver.Assembly = assemblyName;
                    eventReceiver.Class = className;
                    eventReceiver.Update();

                    martaTaskContentType.Update(true);
                }

            }
            
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
