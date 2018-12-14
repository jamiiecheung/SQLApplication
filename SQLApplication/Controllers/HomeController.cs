using SQLApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SQLApplication.Controllers
{
    public class HomeController : Controller
    {
        private SJAMsSynchTestEntities db = new SJAMsSynchTestEntities();
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ActionItems(string Status, string Sales)

           
        {
            tblActionItem actionitems = new tblActionItem();
            if (Status == null)
            {
                // var incc = (SELECT * FROM tblActionItem
                //             INNER JOIN tblTripReport ON tblTripReport.tripreportID = tblActionItem.TripReportID
                //             INNER JOIN tblCustomers ON tblCustomers.CustomerID = tblTripReport.[Customer ID]
                //             INNER JOIN tblEmployees ON tblEmployees.EmployeeID = tblCustomers.EmployeeID
                //             WHERE Sales = 'MW');

                //var incc = (from sa in db.tblActionItems
                //                //join trid in db.tblTripReports on sa.TripReportID equals trid.tripreportID
                //                //join cust in db.tblCustomers on trid.Customer_ID equals cust.CustomerID
                //                //join emp in db.tblEmployees on cust.EmployeeID equals emp.EmployeeID
                //            select new 
                //             {
                //                 Status = sa.Status,
                //                 Action_Item = sa.Action_Item,
                //                 Owners = sa.Owners,
                //                 Due_Date = sa.Due_Date,
                //                 Updated = sa.Updated,
                //                 CreateDate = sa.CreateDate,
                //                 //    Principal = trid.PrinName
                //                 //    Sales = emp.Sales
                //             }).ToList();



                //var incc = (from sa in db.tblActionItems
                //           // join trid in db.tblTripReports on sa.TripReportID equals trid.tripreportID
                //        //    join cust in db.tblCustomers on trid.Customer_ID equals cust.CustomerID
                //        //    join emp in db.tblEmployees on cust.EmployeeID equals emp.EmployeeID
                //            select new
                //            {
                //                Status = sa.Status,
                //                Action_Item = sa.Action_Item,
                //                Owners = sa.Owners,
                //                Due_Date = sa.Due_Date,
                //                Updated = sa.Updated,
                //                CreateDate = sa.CreateDate,
                //            //    Sales = emp.Sales
                //            }).ToList().Select(i => new tblActionItem
                //            {
                //                Status = Status,
                //                Action_Item = Action_Item,
                //                Owners = Owners,
                //                Due_Date = Due_Date,
                //                Updated = Updated,
                //                CreateDate = CreateDate,
                //           //     Sales = Sales
                //            }).ToList();





                //return View(incc.ToList());

                return View(db.tblActionItems.ToList());
                
            }
            else
            {
                // var sales = from sa in db.tblActionItems
                //             join trid in db.tblTripReports on sa.TripReportID equals trid.tripreportID
                //             join cust in db.tblCustomers on trid.Customer_ID equals cust.CustomerID
                //             join emp in db.tblEmployees on cust.EmployeeID equals emp.EmployeeID
                //             select emp;

                //sales = sales.Where(employee => employee.Sales.Contains(S);

                //if(sales.)

                var s = from st in db.tblActionItems
                        select st;

                s = s.Where(status => status.Status.Contains(Status));

                //actionitems = db.tblActionItems.Where(x => x.Status == Status);
                return View(s.ToList());


            }

        }

        public ActionResult btnOpen()
        {
            tblActionItem actionitems = new tblActionItem();
            return RedirectToAction("ActionItems", "Home", new { Status = "Open" });
        }

        public ActionResult btnPending()
        {
            tblActionItem actionitems = new tblActionItem();
            return RedirectToAction("ActionItems", "Home", new { Status = "Pending" });
        }

        public ActionResult btnClosed()
        {
            tblActionItem actionitems = new tblActionItem();
            return RedirectToAction("ActionItems", "Home", new { Status = "Closed" });
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}