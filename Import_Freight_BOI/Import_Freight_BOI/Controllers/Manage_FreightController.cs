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

namespace Import_Freight_BOI.Controllers
{
    public class Manage_FreightController : Controller
    {
        private readonly IConfiguration _configuration;
        public Manage_FreightController(IConfiguration configuration)
        {

         
            _configuration = configuration;
           
        }
        public IActionResult Import_Freight()
        {
            
            return View();
        }
        public IActionResult Report_Section()
        {
            using(ExcelPackage excel = new ExcelPackage())
            {
                ExcelWorksheet sheet = excel.Workbook.Worksheets.Add("Test1");
                sheet.Cells[1, 1].Value = "1";
                sheet.Cells[1, 2].Value = "2";
                sheet.Cells[1, 3].Value = "3";
            }
           
            DataTable dt = new DataTable();
            String Strsql = "Select * FROM Operator_backup where OperatorID = '001933' ";
            var ObjRun = new mgrSQLConnect(_configuration);
            dt = ObjRun.GetDatatables(Strsql);
            return View();
        }

    }
}
