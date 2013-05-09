using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using System.Collections.Generic;

namespace MMPlanningWebTemplate.Features.Web_EnsureSiteScopedFeatures
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("3db1c4ca-a4c9-4770-97f1-bdf6f238415b")]
    public class Web_EnsureSiteScopedFeaturesEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {

            SPWeb web = properties.Feature.Parent as SPWeb;
            //Activate Site Collection Features

            if (web != null)
            {
                List<Guid> siteFeatures = new List<Guid>();
                siteFeatures.Add(new Guid("c85e5759-f323-4efb-b548-443d2216efb5"));
                siteFeatures.Add(new Guid("3bae86a2-776d-499d-9db8-fa4cdc7884f8"));
                siteFeatures.Add(new Guid("063c26fa-3ccc-4180-8a84-b6f98e991df3"));
                siteFeatures.Add(new Guid("7094bd89-2cfe-490a-8c7e-fbace37b4a34"));
                siteFeatures.Add(new Guid("8581a8a7-cf16-4770-ac54-260265ddb0b2"));
                siteFeatures.Add(new Guid("b21b090c-c796-4b0f-ac0f-7ef1659c20ae"));
                siteFeatures.Add(new Guid("fde5d850-671e-4143-950a-87b473922dc7"));
                siteFeatures.Add(new Guid("6e1e5426-2ebd-4871-8027-c5ca86371ead"));
                siteFeatures.Add(new Guid("744b5fd3-3b09-4da6-9bd1-de18315b045d"));
                siteFeatures.Add(new Guid("4bcccd62-dcaf-46dc-a7d4-e38277ef33f4"));
                siteFeatures.Add(new Guid("00bfea71-1c5e-4a24-b310-ba51c3eb7a57"));
                siteFeatures.Add(new Guid("43f41342-1a37-4372-8ca0-b44d881e4434"));
                siteFeatures.Add(new Guid("5a979115-6b71-45a5-9881-cdc872051a69"));
                siteFeatures.Add(new Guid("4248e21f-a816-4c88-8cab-79d82201da7b"));
                siteFeatures.Add(new Guid("695b6570-a48b-4a8e-8ea5-26ea7fc1d162"));
                siteFeatures.Add(new Guid("0c8a9a47-22a9-4798-82f1-00e62a96006e"));
                siteFeatures.Add(new Guid("068bc832-4951-11dc-8314-0800200c9a66"));
                siteFeatures.Add(new Guid("3cb475e7-4e87-45eb-a1f3-db96ad7cf313"));
                siteFeatures.Add(new Guid("4c42ab64-55af-4c7c-986a-ac216a6e0c0e"));
                siteFeatures.Add(new Guid("6e8f2b8d-d765-4e69-84ea-5702574c11d6"));
                siteFeatures.Add(new Guid("ca7bd552-10b1-4563-85b9-5ed1d39c962a"));
                siteFeatures.Add(new Guid("c88c4ff1-dbf5-4649-ad9f-c6c426ebcbf5"));
                siteFeatures.Add(new Guid("39d18bbf-6e0f-4321-8f16-4e3b51212393"));
                siteFeatures.Add(new Guid("14aafd3a-fcb9-4bb7-9ad7-d8e36b663bbd"));
                siteFeatures.Add(new Guid("5b79b49a-2da6-4161-95bd-7375c1995ef9"));
                siteFeatures.Add(new Guid("e995e28b-9ba8-4668-9933-cf5c146d7a9f"));
                siteFeatures.Add(new Guid("875d1044-c0cf-4244-8865-d2a0039c2a49"));
                siteFeatures.Add(new Guid("c9c9515d-e4e2-4001-9050-74f980f93160"));
                siteFeatures.Add(new Guid("5f3b0127-2f1d-4cfd-8dd2-85ad1fb00bfc"));
                siteFeatures.Add(new Guid("2fcd5f8a-26b7-4a6a-9755-918566dba90a"));
                siteFeatures.Add(new Guid("915c240e-a6cc-49b8-8b2c-0bff8b553ed3"));
                siteFeatures.Add(new Guid("5bccb9a4-b903-4fd1-8620-b795fa33c9ba"));
                siteFeatures.Add(new Guid("592ccb4a-9304-49ab-aab1-66638198bb58"));
                siteFeatures.Add(new Guid("5eac763d-fbf5-4d6f-a76b-eded7dd7b0a5"));
                siteFeatures.Add(new Guid("8b2c6bcb-c47f-4f17-8127-f8eae47a44dd"));
                siteFeatures.Add(new Guid("eaf6a128-0482-4f71-9a2f-b1c650680e77"));
                siteFeatures.Add(new Guid("10f73b29-5779-46b3-85a8-4817a6e9a6c2"));
                siteFeatures.Add(new Guid("4326e7fc-f35a-4b0f-927c-36264b0a4cf0"));
                siteFeatures.Add(new Guid("73ef14b1-13a9-416b-a9b5-ececa2b0604c"));
                siteFeatures.Add(new Guid("9fec40ea-a949-407d-be09-6cba26470a0c"));
                siteFeatures.Add(new Guid("2ed1c45e-a73b-4779-ae81-1524e4de467a"));

                siteFeatures.Add(new Guid("f6924d36-2fa8-4f0b-b16d-06b7250180fa"));
                siteFeatures.Add(new Guid("a392da98-270b-4e85-9769-04c0fde267aa"));
                siteFeatures.Add(new Guid("aebc918d-b20f-4a11-a1db-9ed84d79c87e"));
                siteFeatures.Add(new Guid("d3f51be2-38a8-4e44-ba84-940d35be1566"));
                siteFeatures.Add(new Guid("4bcccd62-dcaf-46dc-a7d4-e38277ef33f4"));
                siteFeatures.Add(new Guid("068bc832-4951-11dc-8314-0800200c9a66"));
                siteFeatures.Add(new Guid("915c240e-a6cc-49b8-8b2c-0bff8b553ed3"));
                siteFeatures.Add(new Guid("89e0306d-453b-4ec5-8d68-42067cdbf98e"));

                foreach (Guid featureID in siteFeatures)
                {
                    if (web.Site.Features[featureID] == null)
                    {
                        web.Site.Features.Add(featureID);
                    }
                }

                web.Update();
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
