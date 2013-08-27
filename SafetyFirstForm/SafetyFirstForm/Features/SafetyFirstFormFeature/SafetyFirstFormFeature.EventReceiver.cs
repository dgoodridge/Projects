using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Navigation;

namespace SafetyFirstForm.Features.SafetyFirstFormFeature
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("c94cd98f-771d-40c0-91ca-7f59f929c4c6")]
    public class SafetyFirstFormFeatureEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        //public override void FeatureActivated(SPFeatureReceiverProperties properties)
        //{
        //    SPSite siteCollection = properties.Feature.Parent as SPSite;
        //    if (siteCollection != null)
        //    {
        //        SPWeb site = siteCollection.RootWeb;
        //        //create menu item on top link bar for Safety First list
        //        SPNavigationNodeCollection topNav = site.Navigation.TopNavigationBar;
        //        topNav.AddAsLast(new SPNavigationNode("Safety First Form", "_layouts/15/start.aspx#/Lists/Safety%20First%20Report/AllItems.aspx"));
        //    }
        //}


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //    SPSite siteCollection = properties.Feature.Parent as SPSite;
        //    if (siteCollection != null)
        //    {
        //        SPWeb site = siteCollection.RootWeb;
        //        SPNavigationNodeCollection topNav = site.Navigation.TopNavigationBar;
        //        for (int i = topNav.Count - 1; i >= 0; i--)
        //        {
        //            if (topNav[i].Url.Contains("Safety%20First"))
        //            {
        //                topNav[i].Delete();
        //            }
        //        }
        //    }
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
