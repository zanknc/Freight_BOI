using System.Web;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.Text;
using System.Data;
using ClosedXML.Excel.Drawings;
namespace Import_Freight_BOI.Controllers
{
   
    public class ExcelViewModel
    {
        public string EnrollmentNo { get; set; }
        public string Semester { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
    }
    
        public class ResignController : Controller
         {
       
            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Frm_Resign()
            {
                return View();
            }

            private System.Data.DataTable datatb;

        [HttpPost]
        public IActionResult GetfileExcel(IFormFile File)
        {
            var pathFile = "";
            if (File != null) {
                DataTable dt = new DataTable();
                using var workbook = new XLWorkbook(File.OpenReadStream());
                var ws = workbook.Worksheet(1);

                bool firstRow = true;
                foreach (IXLRow row in ws.Rows())
                {


                    int i = 0;
                    dt.Rows.Add();
                    foreach (IXLCell cell in row.Cells())
                    {

                        if (Convert.ToInt32(cell.Address.RowNumber) == 2)
                        {
                            dt.Columns.Add(cell.Value.ToString());

                        } else if (Convert.ToInt32(cell.Address.RowNumber) >= 4)
                        {

                            if (i <= 10)
                            {
                                if (i == 10) {
                                    var test = cell.GetDateTime().ToString("d-MMM-yy");

                                    dt.Rows[dt.Rows.Count - 4][i] = cell.GetDateTime().ToString("d-MMM-yy");
                                    i++;
                                } else {
                                    dt.Rows[dt.Rows.Count - 4][i] = cell.Value.ToString();
                                    i++;
                                }

                            }
                            else
                            {

                            }

                        }

                    }


                }
                datatb = new DataTable();
                datatb = dt;
                pathFile =  Export_To_Excel(datatb);


            }

            return Json(pathFile);

        }

            public string Export_To_Excel(DataTable datatb)
            {
         
            
                string fileName = "Test2.xlsx";
                string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            int lastRow = 0;
                string month = DateTime.Now.ToString("MMMM");
                string year = DateTime.Now.ToString("yyyy");
            //string imagePathDomain = Server.MapPath(@"Content\img\DomainHeadPic.png"), imagePathSystem = Server.MapPath(@"Content\img\SystemHeadPic.png");
            string imagePathDomain = System.IO.Directory.GetCurrentDirectory() + "\\wwwroot\\Content\\img\\DomainHeadPic.png", imagePathSystem = System.IO.Directory.GetCurrentDirectory() + "\\wwwroot\\Content\\img\\SystemHeadPic.png";

            try
                {
                    using (var Workbook = new XLWorkbook())
                    {
                        IXLWorksheet worksheet =
                        Workbook.Worksheets.Add("Original");
                        //--------------------header sheet original----------------------------------
                        worksheet.Cell(1, 1).Value = "No.";
                        worksheet.Cell(1, 2).Value = "CODE";
                        worksheet.Cell(1, 3).Value = "NAME";
                        worksheet.Cell(1, 4).Value = "Sname";
                        worksheet.Cell(1, 4).Style.Alignment.SetTextRotation(90);
                        worksheet.Cell(1, 5).Value = "POSITION";
                        worksheet.Cell(1, 6).Value = "LEVEL";
                        worksheet.Cell(1, 6).Style.Alignment.SetTextRotation(90);
                        worksheet.Cell(1, 7).Value = "SECT.";
                        worksheet.Cell(1, 8).Value = "DEPT.";
                        worksheet.Cell(1, 9).Value = "DIV.";
                        worksheet.Cell(1, 10).Value = "HQ.";
                        worksheet.Cell(1, 11).Value = "RESIGNED DATE";
                        worksheet.Range("A1:K1").Style.Fill.BackgroundColor = XLColor.FromArgb(204, 255, 204);
                        worksheet.Range("A1:K1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet.Range("A1:K1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        worksheet.Column("A").Width = 2.86;
                        worksheet.Column("B").Width = 5.43;
                        worksheet.Column("B").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                        worksheet.Column("B").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        worksheet.Column("C").Width = 18.43;
                        worksheet.Column("C").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                        worksheet.Column("C").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        worksheet.Column("D").Width = 2.29;
                        worksheet.Column("E").Width = 13.71;
                        worksheet.Column("F").Width = 2.29;
                        worksheet.Column("G").Width = 38.29;
                        worksheet.Column("H").Width = 17.71;
                        worksheet.Column("I").Width = 29.86;
                        worksheet.Column("J").Width = 10;
                        worksheet.Column("K").Width = 11.71;
                       
                        worksheet.Row(1).Height = 30;
                   
                        worksheet.Style.Font.FontSize = 8;
                        worksheet.Style.Font.FontName = "Arial";
                        worksheet.Range("A1:K1").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheet.Range("A1:K1").Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        worksheet.Column(2).Style.NumberFormat.Format = "000000";

                    //--------------------header sheet System----------------------------------
                    IXLWorksheet worksheet2 =
                        Workbook.Worksheets.Add("System");
                   
                        worksheet2.Cell(9, 1).Value = "No.";
                        worksheet2.Cell(9, 2).Value = "DIV.";
                        worksheet2.Cell(9, 3).Value = "CODE";
                        worksheet2.Range("D9:E9").Merge().Value = "NAME";
                        worksheet2.Cell(9, 5).Value = "";
                        worksheet2.Cell(9, 6).Value = "POSITION";
                        worksheet2.Style.Font.FontSize = 14;
                        //----------IXLColumn TRDI ------------
                        //------------Header------------------------------------    
                        worksheet2.RowHeight = 25.50;
                        worksheet2.Row(2).Height = 25.50; worksheet2.Row(3).Height = 25.50; worksheet2.Row(4).Height = 25.50; worksheet2.Row(5).Height = 25.50;
                        worksheet2.Row(6).Height = 46.50;
                        worksheet2.Row(7).Height = 25.50; worksheet2.Row(8).Height = 25.50; worksheet2.Row(9).Height = 25.50;

                         worksheet2.RowHeight = 25.50;

                          worksheet2.Range("A2:I5").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheet2.Range("A7:AH9").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheet2.Range("A2:I5").Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        worksheet2.Range("A7:AH9").Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                        worksheet2.Range("A2:I5").Style.Font.FontName = "Tahoma";
                        worksheet2.Range("A2:I5").Style.Font.FontSize = 20;
                        worksheet2.Range("A2:I5").Merge().Value = "Resigned Person of " + month + " " + year + Environment.NewLine + "(System User)";
                        worksheet2.Range("A2:I5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet2.Range("A2:I5").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        worksheet2.Range("A2:I5").Style.Font.Bold = true;
                        worksheet2.Range("A6:F6").Merge();
                        worksheet2.Range("A7:F8").Merge().Value = "Resigned Person";
                        worksheet2.Range("A7:AH9").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet2.Range("A7:AH9").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet2.Style.Font.FontName = "Arial";

                        worksheet2.Range("A7:F7").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheet2.Range("A7:F7").Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        worksheet2.Column("A").Width = 6; worksheet2.Column("B").Width = 23.86; worksheet2.Column("C").Width = 12.86; worksheet2.Column("D").Width = 32.57; worksheet2.Column("E").Width = 4; worksheet2.Column("F").Width = 35.46;
                        worksheet2.Column("G").Width = 16; worksheet2.Column("H").Width = 14.75; worksheet2.Column("I").Width = 11.14; worksheet2.Column("J").Width = 15.43; worksheet2.Column("K").Width = 12.43; worksheet2.Column("L").Width = 18.86;
                        worksheet2.Column("M").Width = 11.14; worksheet2.Column("N").Width = 7.43; worksheet2.Column("O").Width = 11.14; worksheet2.Column("P").Width = 11.43; worksheet2.Column("Q").Width = 18.86; worksheet2.Column("R").Width = 15.43;
                        worksheet2.Column("S").Width = 11.14; worksheet2.Column("T").Width = 9.57; worksheet2.Column("U").Width = 10.29; worksheet2.Column("V").Width = 10.29; worksheet2.Column("W").Width = 10; worksheet2.Column("X").Width = 9.57;
                        worksheet2.Column("Y").Width = 11.14; worksheet2.Column("Z").Width = 9.57; worksheet2.Column("AA").Width = 11.14; worksheet2.Column("AB").Width = 10.71; worksheet2.Column("AC").Width = 11.71; worksheet2.Column("AD").Width = 15.43;
                        worksheet2.Column("AE").Width = 10.71; worksheet2.Column("AF").Width = 7.86; worksheet2.Column("AG").Width = 7.86; worksheet2.Column("AH").Width = 8.29;
                        worksheet2.RowHeight = 25.50;



                        worksheet2.Range("A7:F9").Style.Font.Bold = true;

                        //worksheet2.Range("R1:AG5").Style.Font.Bold = true;
                        //worksheet2.Range("R1:AG5").Style.Font.FontSize = 16;
                        //worksheet2.Range("R1:AG5").Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        //worksheet2.Range("R1:AG5").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        //worksheet2.Range("R1:AG5").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        //worksheet2.Range("R1:AG5").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        //worksheet2.Range("R1:AG5").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheet2.Style.Font.FontName = "Tahoma";
                        worksheet2.Range("R8:AH9").Style.Font.Bold = false;

                        //worksheet2.Range("R1:S1").Merge().Value = "TRDI";
                        //worksheet2.Range("R2:S4").Merge();
                        //worksheet2.Range("R6:S6").Merge();


                        //worksheet2.Range("T1:U1").Merge().Value = "TC";
                        //worksheet2.Range("T2:U4").Merge();
                        //worksheet2.Range("T6:U6").Merge();

                        //worksheet2.Range("V1:W1").Merge().Value = "MCR";
                        //worksheet2.Range("V2:W4").Merge();
                        //worksheet2.Range("V6:W6").Merge();

                        //worksheet2.Range("X1:Y1").Merge().Value = "LSI";
                        //worksheet2.Range("X2:Y4").Merge();
                        //worksheet2.Range("X6:Y6").Merge();

                        //worksheet2.Range("Z1:AA1").Merge().Value = "ADMIN";
                        //worksheet2.Range("Z2:AA4").Merge();
                        //worksheet2.Range("Z6:AA6").Merge();

                        //worksheet2.Range("AB1:AC1").Merge().Value = "IS Sect.Mgr.";
                        //worksheet2.Range("AB2:AC4").Merge();
                        //worksheet2.Range("AB6:AC6").Merge();

                        //worksheet2.Range("AD1:AE1").Merge().Value = "IS Dept.Mgr.";
                        //worksheet2.Range("AD2:AE4").Merge();
                        //worksheet2.Range("AD6:AE6").Merge();

                        //worksheet2.Range("AF1:AG1").Merge().Value = "IS Div.Mgr.";
                        //worksheet2.Range("AF2:AG4").Merge();
                        //worksheet2.Range("AF6:AG6").Merge();

                        //------------Header------------------------------------
                        worksheet2.Range("G7:N7").Merge().Value = "TRDI";
                        worksheet2.Range("G7:N7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet2.Range("G7:N7").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet2.Range("G7:N7").Style.Font.Bold = true;
                        worksheet2.Range("G7:N9").Style.Fill.BackgroundColor = XLColor.FromArgb(204, 255, 204);


                        worksheet2.Cell(8, 7).Value = "OEM";
                        worksheet2.Cell(8, 8).Value = "Stagnation";
                        worksheet2.Cell(8, 9).Value = "LotTraceability";
                        worksheet2.Cell(8, 10).Value = "Alarm";
                        worksheet2.Cell(8, 11).Value = "Non-conformance";
                        worksheet2.Cell(8, 12).Value = "SpareParts";
                        worksheet2.Cell(8, 13).Value = "Platin";
                        worksheet2.Cell(8, 14).Value = "NCIM";

                        worksheet2.Cell(9, 7).Value = "OEMOperator";
                        worksheet2.Cell(9, 8).Value = "Operator";
                        worksheet2.Cell(9, 9).Value = "Operator";
                        worksheet2.Cell(9, 10).Value = "T_Operator";
                        worksheet2.Cell(9, 11).Value = "Operator";
                        worksheet2.Cell(9, 12).Value = "Operator";
                        worksheet2.Cell(9, 13).Value = "OP";
                        worksheet2.Cell(9, 14).Value = "Operator";

                        //----------IXLColumn TC ------------
                        worksheet2.Range("O7:P7").Merge().Value = "TC";
                        worksheet2.Range("O7:P7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet2.Range("O7:P7").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet2.Range("O7:P7").Style.Font.Bold = true;
                        worksheet2.Range("O7:P9").Style.Fill.BackgroundColor = XLColor.FromArgb(255, 204, 153);

                        worksheet2.Cell(8, 15).Value = "TC System";
                        worksheet2.Cell(8, 16).Value = "Non-conformance";
                        worksheet2.Cell(9, 15).Value = "Operator";
                        worksheet2.Cell(9, 16).Value = "Operator";

                        //----------IXLColumn MCR ------------
                        worksheet2.Range("Q7:Y7").Merge().Value = "MCR";
                        worksheet2.Range("Q7:Y7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet2.Range("Q7:Y7").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet2.Range("Q7:Y7").Style.Font.Bold = true;
                        worksheet2.Range("Q7:Y9").Style.Fill.BackgroundColor = XLColor.FromArgb(204, 255, 255);
                        worksheet2.Range("Q8:R9").Style.Fill.BackgroundColor = XLColor.FromArgb(216, 228, 188);


                        worksheet2.Cell(8, 17).Value = "LotTraceability";
                        worksheet2.Cell(8, 18).Value = "SpareParts";
                        worksheet2.Cell(8, 19).Value = "PI";
                        worksheet2.Cell(8, 20).Value = "B-Kanban";
                        worksheet2.Cell(8, 21).Value = "Shipment";
                        worksheet2.Cell(8, 22).Value = "Substrate";
                        worksheet2.Cell(8, 23).Value = "Paste";
                        worksheet2.Cell(8, 24).Value = "Screen";
                        worksheet2.Cell(8, 25).Value = "NCIM";


                        worksheet2.Cell(9, 17).Value = "Operator";
                        worksheet2.Cell(9, 18).Value = "Operator";
                        worksheet2.Cell(9, 19).Value = "Operator";
                        worksheet2.Cell(9, 20).Value = "Operator";
                        worksheet2.Cell(9, 21).Value = "Operator";
                        worksheet2.Cell(9, 22).Value = "Operator";
                        worksheet2.Cell(9, 23).Value = "Operator";
                        worksheet2.Cell(9, 24).Value = "Operator";
                        worksheet2.Cell(9, 25).Value = "Operator";
                        //----------IXLColumn OPM ------------

                        worksheet2.Range("Z7:AA7").Merge().Value = "OPM&WLM";
                        worksheet2.Range("Z7:AA7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet2.Range("Z7:AA7").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet2.Range("Z7:AA7").Style.Font.Bold = true;
                        worksheet2.Range("Z7:AA9").Style.Fill.BackgroundColor = XLColor.FromArgb(204, 192, 218);

                        worksheet2.Cell(8, 26).Value = "spareParts";
                        worksheet2.Cell(8, 27).Value = "NCIM";

                        worksheet2.Cell(9, 26).Value = "Operator";
                        worksheet2.Cell(9, 27).Value = "Operator";

                        //----------IXLColumn LSI ------------
                        worksheet2.Range("AB7:AC7").Merge().Value = "LSI";
                        worksheet2.Range("AB7:AC7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet2.Range("AB7:AC7").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet2.Range("AB7:AC7").Style.Font.Bold = true;
                        worksheet2.Range("AB7:AC9").Style.Fill.BackgroundColor = XLColor.FromArgb(255, 255, 153);

                        worksheet2.Cell(8, 28).Value = "Ukebarai : FT";
                        worksheet2.Cell(8, 29).Value = "Web : FYI";

                        worksheet2.Cell(9, 28).Value = "OP";
                        worksheet2.Cell(9, 29).Value = "OP";


                        //worksheet2.AddPicture(imagePathDomain)
                        //  .MoveTo(worksheet2.Cell("B3"))
                        //  .Scale(0.5);
                        //----------IXLColumn Admin ------------
                        worksheet2.Range("AD7:AH7").Merge().Value = "Admin";
                        worksheet2.Range("AD7:AH7").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet2.Range("AD7:AH7").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet2.Range("AD7:AH7").Style.Font.Bold = true;
                        worksheet2.Range("AD7:AH9").Style.Fill.BackgroundColor = XLColor.FromArgb(255, 153, 204);

                        worksheet2.Cell(8, 30).Value = "GFDReport";
                        worksheet2.Cell(8, 31).Value = "MaterialLedger";
                        worksheet2.Cell(8, 32).Value = "OneWorld";
                        worksheet2.Cell(8, 33).Value = "TCCost";
                        worksheet2.Cell(8, 34).Value = "TRCost";

                        worksheet2.Cell(9, 30).Value = "Operator";
                        worksheet2.Cell(9, 31).Value = "Operator";
                        worksheet2.Cell(9, 32).Value = "Operator";
                        worksheet2.Cell(9, 33).Value = "OP";
                        worksheet2.Cell(9, 34).Value = "OP";
                    //worksheet2.AddPicture(imagePathSystem).MoveTo(worksheet2.Cell("R1").Address).Scale(1.4);
                    IXLPicture iXLPicture = worksheet2.AddPicture(imagePathSystem).MoveTo(worksheet2.Cell("R1")).Scale(1.4);
                    worksheet2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        worksheet2.Column("F").Style.Protection.SetLocked(true);
                        worksheet2.Column(3).Style.NumberFormat.Format = "000000";
                   


                    IXLWorksheet worksheet3 =
                         Workbook.Worksheets.Add("Domain");
                        //---------------header-------------
                        worksheet3.Range("A3:C6").Merge().Value = "Resigned Person of " + month + " " + year + Environment.NewLine + "(System User)";
                        worksheet3.Range("A3:C6").Style.Font.FontName = "Tahoma";
                        worksheet3.Range("A3:C6").Style.Font.FontSize = 12;
                        worksheet3.Style.Font.FontSize = 8;
                        worksheet3.Style.Font.FontName = "Tahoma";
                        worksheet3.Range("A3:C6").Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        worksheet3.Range("A3:C6").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheet3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet3.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet3.Range("A3:C6").Style.Font.FontName = "Tahoma";

                        worksheet3.Column("A").Width = 7.71;
                        worksheet3.Column("B").Width = 20.29;
                        worksheet3.Column("C").Width = 12.57;
                        worksheet3.Column("D").Width = 21;
                        worksheet3.Column("E").Width = 3.29;
                        worksheet3.Column("F").Width = 23.57;
                        worksheet3.Column("G").Width = 11.71;

                        worksheet3.RowHeight = 12.75;

                        worksheet3.Range("A3:C6").Merge().Value = "Resigned Person of " + month + " " + year + Environment.NewLine + "(System User)";
                        //worksheet3.Range("D2").Value = "In Charge"; worksheet3.Range("E2").Value = "IS Sect.Mgr."; worksheet3.Range("F2").Value = "IS Dept.Mgr."; worksheet3.Range("G2").Value = "Admin Div.Mgr.";
                        //worksheet3.Range("D2:G7").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        //worksheet3.Range("D2:G7").Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        //worksheet3.Range("D2:G7").Style.Font.Bold = true;
                        //worksheet3.Range("D3:D7").Merge();
                        //worksheet3.Range("E3:E7").Merge();
                        //worksheet3.Range("F3:F7").Merge();
                        //worksheet3.Range("G3:G7").Merge();


                        worksheet3.Cell(9, 1).Value = "NO.";
                        worksheet3.Cell(9, 2).Value = "DIV.";
                        worksheet3.Cell(9, 3).Value = "CODE";
                        worksheet3.Cell(9, 4).Value = "NAME";
                        worksheet3.Cell(9, 5).Value = "";
                        worksheet3.Cell(9, 6).Value = "POSITION";
                        worksheet3.Cell(9, 7).Value = "Domain User";
                        worksheet3.Range("A9:G9").Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        worksheet3.Range("A9:G9").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                        worksheet3.Range("A3:C6").Style.Font.FontName = "Arial";
                        worksheet3.Range("A3:C6").Style.Font.FontSize = 12;
                        worksheet3.Range("A9:G9").Style.Font.FontName = "Arial";
                        worksheet3.Range("A9:G9").Style.Font.FontSize = 10;
                        worksheet3.Range("A9:G9").Style.Font.Bold = true;
                        worksheet3.Range("A3:C6").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet3.Range("A3:C6").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet3.Range("A3:C6").Style.Font.Bold = true;


                        worksheet3.Range("A9:G9").Style.Fill.BackgroundColor = XLColor.LightGray;
                        worksheet3.Range("D2:G7").Merge();

                    //worksheet3.AddPicture(imagePathDomain).MoveTo(worksheet3.Cell("D2").Address).Scale(1.1);
                    IXLPicture iXLPicture3 = worksheet3.AddPicture(imagePathDomain).MoveTo(worksheet3.Cell("D2")).Scale(1.1);

                    worksheet3.Column(3).Style.NumberFormat.Format = "000000";

                        IXLWorksheet worksheet4 =
                           Workbook.Worksheets.Add("Mail");
                        //---------------header-------------
                        worksheet4.Column("A").Width = 3.71;
                        worksheet4.Column("B").Width = 20.71;
                        worksheet4.Column("C").Width = 12.57;
                        worksheet4.Column("D").Width = 21;
                        worksheet4.Column("E").Width = 3.29;
                        worksheet4.Column("F").Width = 23.57;
                        worksheet4.Column("G").Width = 11.86;
                        worksheet4.Column("H").Width = 12.43;
                        worksheet4.RowHeight = 12.75;


                        worksheet4.Range("A3:C6").Merge().Value = "Resigned Person of " + month + " " + year + Environment.NewLine + "(System User)";
                        worksheet4.Range("A3:C6").Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        worksheet4.Range("A3:C6").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                        worksheet4.Range("A3:C6").Style.Font.Bold = true;
                        worksheet4.Range("A3:C6").Style.Font.FontSize = 12;
                        worksheet4.Range("A3:C6").Style.Font.FontName = "Tahoma";

                        //worksheet4.Range("D2").Value = "In Charge"; worksheet4.Range("E2").Value = "IS Sect.Mgr."; worksheet4.Range("F2").Value = "IS Dept.Mgr."; worksheet4.Range("G2").Value = "Admin Div.Mgr.";
                        //worksheet4.Range("D3:D7").Merge();
                        //worksheet4.Range("E3:E7").Merge();
                        //worksheet4.Range("F3:F7").Merge();
                        //worksheet4.Range("G3:G7").Merge();
                        //worksheet4.Range("G3:G7").Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        //worksheet4.Range("E3:E7").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        //worksheet4.Range("E3:E7").Style.Font.Bold = true;

                        worksheet4.Cell(9, 1).Value = "NO.";
                        worksheet4.Cell(9, 2).Value = "DIV.";
                        worksheet4.Cell(9, 3).Value = "CODE";
                        worksheet4.Cell(9, 4).Value = "NAME";
                        worksheet4.Cell(9, 5).Value = "";
                        worksheet4.Cell(9, 6).Value = "POSITION";
                        worksheet4.Cell(9, 7).Value = "internal Mail";
                        worksheet4.Cell(9, 8).Value = "internet Mail";
                        worksheet4.Range("A9:H9").Style.Fill.BackgroundColor = XLColor.LightGray;
                        worksheet4.Range("A9:H9").Style.Font.Bold = true;
                        worksheet4.Range("A9:H9").Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        worksheet4.Range("A9:H9").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;


                        worksheet4.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet4.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                         worksheet4.Column(3).Style.NumberFormat.Format = "000000";
                    IXLPicture iXLPicture4 = worksheet4.AddPicture(imagePathDomain).MoveTo(worksheet4.Cell("E2")).Scale(1.05);

                    for (int nrow = 2; nrow < datatb.Rows.Count - 2; nrow++)
                    {
                        for (int ncol = 1; ncol < datatb.Columns.Count + 1; ncol++)
                        {

                            var test = datatb.Rows[nrow - 2][ncol - 1].ToString();
                            worksheet.Cell(nrow, ncol).Value = datatb.Rows[nrow - 2][ncol - 1].ToString();
                            if (datatb.Rows[nrow - 2][1].ToString() != "")
                            {
                                worksheet.Cell(nrow, ncol).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                                worksheet.Cell(nrow, ncol).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                worksheet.Row(nrow).Height = 12.75;
                            }
                            

                        }
                        worksheet2.Cell(nrow + 8, 1).Value = datatb.Rows[nrow - 2][0].ToString();
                        worksheet2.Cell(nrow + 8, 2).Value = datatb.Rows[nrow - 2][8].ToString();
                        worksheet2.Cell(nrow + 8, 3).Value = datatb.Rows[nrow - 2][1].ToString();
                        worksheet2.Cell(nrow + 8, 4).Value = datatb.Rows[nrow - 2][2].ToString();
                        worksheet2.Cell(nrow + 8, 5).Value = datatb.Rows[nrow - 2][3].ToString();
                        worksheet2.Cell(nrow + 8, 6).Value = datatb.Rows[nrow - 2][4].ToString();

                        worksheet3.Cell(nrow + 8, 1).Value = datatb.Rows[nrow - 2][0].ToString();
                        worksheet3.Cell(nrow + 8, 2).Value = datatb.Rows[nrow - 2][8].ToString();
                        worksheet3.Cell(nrow + 8, 3).Value = datatb.Rows[nrow - 2][1].ToString();
                        worksheet3.Cell(nrow + 8, 4).Value = datatb.Rows[nrow - 2][2].ToString();
                        worksheet3.Cell(nrow + 8, 5).Value = datatb.Rows[nrow - 2][3].ToString();
                        worksheet3.Cell(nrow + 8, 6).Value = datatb.Rows[nrow - 2][4].ToString();


                        worksheet4.Cell(nrow + 8, 1).Value = datatb.Rows[nrow - 2][0].ToString();
                        worksheet4.Cell(nrow + 8, 2).Value = datatb.Rows[nrow - 2][8].ToString();
                        worksheet4.Cell(nrow + 8, 3).Value = datatb.Rows[nrow - 2][1].ToString();
                        worksheet4.Cell(nrow + 8, 4).Value = datatb.Rows[nrow - 2][2].ToString();
                        worksheet4.Cell(nrow + 8, 5).Value = datatb.Rows[nrow - 2][3].ToString();
                        worksheet4.Cell(nrow + 8, 6).Value = datatb.Rows[nrow - 2][4].ToString();
                        if(datatb.Rows[nrow - 2][4].ToString() != "")
                        {
                            worksheet2.Cell(nrow + 8, 1).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet2.Cell(nrow + 8, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet2.Cell(nrow + 8, 2).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet2.Cell(nrow + 8, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet2.Cell(nrow + 8, 3).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet2.Cell(nrow + 8, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet2.Cell(nrow + 8, 4).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet2.Cell(nrow + 8, 4).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet2.Cell(nrow + 8, 5).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet2.Cell(nrow + 8, 5).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet2.Cell(nrow + 8, 6).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet2.Cell(nrow + 8, 6).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                         


                            worksheet3.Cell(nrow + 8, 1).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet3.Cell(nrow + 8, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet3.Cell(nrow + 8, 2).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet3.Cell(nrow + 8, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet3.Cell(nrow + 8, 3).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet3.Cell(nrow + 8, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet3.Cell(nrow + 8, 4).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet3.Cell(nrow + 8, 4).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet3.Cell(nrow + 8, 5).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet3.Cell(nrow + 8, 5).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet3.Cell(nrow + 8, 6).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet3.Cell(nrow + 8, 6).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet3.Cell(nrow + 8, 7).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet3.Cell(nrow + 8, 7).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                            worksheet4.Cell(nrow + 8, 1).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet4.Cell(nrow + 8, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet4.Cell(nrow + 8, 2).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet4.Cell(nrow + 8, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet4.Cell(nrow + 8, 3).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet4.Cell(nrow + 8, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet4.Cell(nrow + 8, 4).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet4.Cell(nrow + 8, 4).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet4.Cell(nrow + 8, 5).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet4.Cell(nrow + 8, 5).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet4.Cell(nrow + 8, 6).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet4.Cell(nrow + 8, 6).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet4.Cell(nrow + 8, 7).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet4.Cell(nrow + 8, 7).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet4.Cell(nrow + 8, 8).Style.Border.InsideBorder = XLBorderStyleValues.Thin; worksheet4.Cell(nrow + 8, 8).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            lastRow = nrow + 8;
                        }
                      
                    }

                    worksheet2.Range("G10:AH" + lastRow).Style.Border.BottomBorder = XLBorderStyleValues.Dotted;
                    worksheet2.Range("G10:AH" + lastRow).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                    worksheet2.Range("G"+ lastRow + ":AH" + lastRow).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileName;
                    using (var stream = new MemoryStream())
                        {
                        Workbook.SaveAs(stream);
                        Workbook.SaveAs(path);
                        var content = stream.ToArray();
                            return path;
                        }

                   

                    }

            }catch (Exception ex)
                {
                    throw ex;
                }

           
            }
        
    }
}
