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
            int addBusinessDays = 0;
            DateTime startDate = DateTime.Now;
            DateTime dueDate;
            if (addBusinessDays == 3)
            {
                switch (startDate.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                    case DayOfWeek.Tuesday:
                        dueDate = startDate.AddDays(3);
                        break;
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Thursday:
                    case DayOfWeek.Friday:
                    case DayOfWeek.Saturday:
                        dueDate = startDate.AddDays(5);
                        break;
                    case DayOfWeek.Sunday:
                        dueDate = startDate.AddDays(4);
                        break;
                }
            }
            else if (addBusinessDays == 5)
                switch (startDate.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                    case DayOfWeek.Tuesday:
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Thursday:
                    case DayOfWeek.Friday:
                        dueDate = startDate.AddDays(7);
                        break;
                    case DayOfWeek.Saturday:
                        dueDate = startDate.AddDays(6);
                        break;
                    case DayOfWeek.Sunday:
                        dueDate = startDate.AddDays(5);
                        break;
                }
            else if (addBusinessDays == 20)
                switch (startDate.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                    case DayOfWeek.Tuesday:
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Thursday:
                    case DayOfWeek.Friday:
                        dueDate = startDate.AddDays(35);
                        break;
                    case DayOfWeek.Saturday:
                        dueDate = startDate.AddDays(37);
                        break;
                    case DayOfWeek.Sunday:
                        dueDate = startDate.AddDays(36);
                        break;

                }
            else if (addBusinessDays == 30)
                switch (startDate.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                    case DayOfWeek.Tuesday:
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Thursday:
                    case DayOfWeek.Friday:
                        dueDate = startDate.AddDays(42);
                        break;
                    case DayOfWeek.Saturday:
                        dueDate = startDate.AddDays(41);
                        break;
                    case DayOfWeek.Sunday:
                        dueDate = startDate.AddDays(40);
                        break;
                    
                }
        }

        /// <summary>
        /// An item was updated.
        /// </summary>
        public override void ItemUpdated(SPItemEventProperties properties)
        {
            base.ItemUpdated(properties);
        }


    }
}