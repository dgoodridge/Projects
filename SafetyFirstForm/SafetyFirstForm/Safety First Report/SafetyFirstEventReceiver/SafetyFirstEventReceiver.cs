using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace SafetyFirstForm.Safety_First_Report.Safety_First_Report_Instance.SafetyFirstEventReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class SafetyFirstEventReceiver : SPItemEventReceiver
    {
        /// <summary>
        /// An item was added.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            base.ItemAdded(properties);
            string today = DateTime.Today.DayOfWeek.ToString().ToLower();

            

            SPListItem item = properties.ListItem;
            item["SupervisorResponseDate"] = GetBusinessDays(DateTime.Today, 3);
            item.Update();


        }

        /// <summary>
        /// An item was updated.
        /// </summary>
        public override void ItemUpdated(SPItemEventProperties properties)
        {
            base.ItemUpdated(properties);
        }

        private DateTime GetBusinessDays(DateTime fromDate, int numberOfBusinessDays)
        {
            if (numberOfBusinessDays == 3)
            {
                switch (fromDate.DayOfWeek.ToString().ToLower())
                {
                    case "sunday":
                    case "monday":
                    case "tuesday":
                        fromDate = DateTime.Today.AddDays(3).AddHours(17);
                        break;
                    case "wednesday":
                    case "thursday":
                    case "friday":
                    case "saturday":
                        fromDate = DateTime.Today.AddDays(5).AddHours(17);
                        break;
                }
            }
            else if (numberOfBusinessDays == 5)
            {
                switch (fromDate.DayOfWeek.ToString().ToLower())
                {
                    case "monday":
                    case "tuesday":
                    case "wednesday":
                    case "thursday":
                    case "friday":
                        fromDate = DateTime.Today.AddDays(7).AddHours(17);
                        break;
                    case "saturday":
                        fromDate = DateTime.Today.AddDays(6).AddHours(17);
                        break;
                    case "sunday":
                        fromDate = DateTime.Today.AddDays(5).AddHours(17);
                        break;
                }
            }
            return fromDate;
        }
    }
}