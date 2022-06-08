using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Import_Freight_BOI.Models.TSQL;
using OfficeOpenXml;
using ClosedXML.Excel;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Import_Freight_BOI.Controllers
{
    public class Manage_FreightController : Controller
    {
        public const string SessionID = "";
        private readonly IConfiguration _configuration;
        public Manage_FreightController(IConfiguration configuration)
        {

         
            _configuration = configuration;
           
        }
        public IActionResult Import_Freight()
        {
            String Strsql = "";
            var ObjRun = new mgrSQLConnect(_configuration);
            DataTable dt_Country = new DataTable();
            DataTable dt_Delivery = new DataTable();
            DataTable dt_Forwarder = new DataTable();
            DataTable dt_Purpose = new DataTable();
            DataTable dt_Supplier = new DataTable();


            Strsql = "Select * FROM vewCountry";
            ViewBag.Country = ObjRun.GetDatatables(Strsql);

            Strsql = "Select * FROM vewDelivery";
            ViewBag.Delivery = ObjRun.GetDatatables(Strsql);

            Strsql = "Select * FROM vewForwarder";
            ViewBag.Forwarder = ObjRun.GetDatatables(Strsql);

            Strsql = "Select * FROM vewPurpose";
            ViewBag.Purpose = ObjRun.GetDatatables(Strsql);

            Strsql = "Select * FROM vewSupplier";
            ViewBag.Supplier = ObjRun.GetDatatables(Strsql);

            Strsql = "Select * FROM vewTransportation";
            ViewBag.Transportation = ObjRun.GetDatatables(Strsql);

            ViewBag.SessionID =  HttpContext.Session.GetString(SessionID);

            return View();
        }
        public IActionResult Report_Section()
        {


            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = "authors.xlsx";
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    IXLWorksheet worksheet =
                    workbook.Worksheets.Add("Authors");
                    worksheet.Cell(1, 1).Value = "Id";
                    worksheet.Cell(1, 2).Value = "FirstName";
                    worksheet.Cell(1, 3).Value = "LastName";

                    workbook.Worksheets.Add("A");
                    worksheet.Cell(1, 1).Value = "Id";
                    worksheet.Cell(1, 2).Value = "FirstName";
                    worksheet.Cell(1, 3).Value = "LastName";

                    //required using System.IO;
                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        var content = stream.ToArray();
                        return File(content, contentType, fileName);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }



            return View();
        }

        public IActionResult Login()
        {

            return View();
        }


        public JsonResult GetValue_DropdowList()
        {
            String Strsql = "";
            var ObjRun = new mgrSQLConnect(_configuration);
            DataTable dt_Country = new DataTable();
            DataTable dt_Delivery = new DataTable();
            DataTable dt_Forwarder = new DataTable();
            DataTable dt_Purpose = new DataTable();
            DataTable dt_Supplier = new DataTable();


            Strsql = "Select * FROM vewCountry";
            dt_Country = ObjRun.GetDatatables(Strsql);

            Strsql = "Select * FROM vewDelivery";
            dt_Delivery = ObjRun.GetDatatables(Strsql);

            Strsql = "Select * FROM vewForwarder";
            dt_Forwarder = ObjRun.GetDatatables(Strsql);

            Strsql = "Select * FROM vewPurpose";
            dt_Purpose = ObjRun.GetDatatables(Strsql);

            Strsql = "Select * FROM vewSupplier";
            dt_Supplier = ObjRun.GetDatatables(Strsql);


            var JsonResult =  Json(new{ Country = dt_Country , Delivery = dt_Delivery , Forwarder = dt_Forwarder, Purpose = dt_Purpose, Supplier = dt_Supplier});
           return JsonResult;
        }

        public JsonResult CheckUser_Login(string OPID, string Password)
        {
            string status;
            var query = new mgrSQLConnect(_configuration);
            string strQuery = "select * from vewOperator where OperatorID = '" + OPID.Trim() + "' and Password = '" + Password.Trim() + "'";
            var checkUser = query.GetDatatables(strQuery);
            if (checkUser.Rows.Count != 0)
            {
                HttpContext.Session.SetString(SessionID, checkUser.Rows[0][0].ToString());
                status = "True";
                //return RedirectToPage(nameof(HomeController.Index), "Home");
            }
            else
            {
                status = "False";
            }

            return Json(status);
        }

    }
}
