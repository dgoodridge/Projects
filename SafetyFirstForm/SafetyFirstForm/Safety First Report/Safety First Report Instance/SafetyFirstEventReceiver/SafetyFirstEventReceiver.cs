using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace SafetyFirstForm.Safety_First_Report.Safety_First_Report_Instance.SafetyFirstEventReceiver
{
    //public class AddBusinessDays
    //{
    //    DateTime startDate = DateTime.Now;        
 
    //    public System.DateTime CalculateTenBusinessDaysFromInputDate(System.DateTime StartDate)
    //    {
    //        //This simply adds at least 2 full weeks to the start date.

    //        switch (StartDate.DayOfWeek)
    //        {
    //            case DayOfWeek.Sunday:
    //                //if the start date is not a sunday you need to add 
    //                //1 day to push it to a monday that is why the number is 15.
    //                return StartDate.AddDays(15);
    //                break;
    //            case DayOfWeek.Monday:
    //            case DayOfWeek.Tuesday:
    //            case DayOfWeek.Wednesday:
    //            case DayOfWeek.Thursday:
    //            case DayOfWeek.Friday:
    //                //if the start date is any other day then just add 14 days to the start date.
    //                return StartDate.AddDays(14);
    //                break;
    //            case DayOfWeek.Saturday:
    //                //if the start date is on a Saturday you need to add 
    //                //2 days to push it to a monday that is why the number is 16.
    //                return StartDate.AddDays(16);
    //                break;
    //            default:
    //                return StartDate;
    //        }
    //    }
    //}
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
                    case DayOfWeek.Sunday:
                    case DayOfWeek.Monday:
                    case DayOfWeek.Tuesday:
                        dueDate = startDate.AddDays(3);
                        break;
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Thursday:
                    case DayOfWeek.Friday:
                        dueDate = startDate.AddDays(5);
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