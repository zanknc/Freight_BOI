#pragma checksum "E:\Github\Freight_BOI\Freight_BOI\Import_Freight_BOI\Import_Freight_BOI\Views\Resign\Frm_Resign.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d0b614ba45d9d3ffe25c5bd27bbf04d4e075f00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resign_Frm_Resign), @"mvc.1.0.view", @"/Views/Resign/Frm_Resign.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Github\Freight_BOI\Freight_BOI\Import_Freight_BOI\Import_Freight_BOI\Views\_ViewImports.cshtml"
using Import_Freight_BOI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Github\Freight_BOI\Freight_BOI\Import_Freight_BOI\Import_Freight_BOI\Views\_ViewImports.cshtml"
using Import_Freight_BOI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0b614ba45d9d3ffe25c5bd27bbf04d4e075f00", @"/Views/Resign/Frm_Resign.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3227ef76ccca694c120d9032a688aa75c02a1c4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Resign_Frm_Resign : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Github\Freight_BOI\Freight_BOI\Import_Freight_BOI\Import_Freight_BOI\Views\Resign\Frm_Resign.cshtml"
  
    ViewData["Title"] = "Employee Resign";
    Layout = "~/Layout/_MainMenu.cshtml";
    ViewData["SessionID"] = ViewBag.SessionID;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n\r\n    div.dataTables_wrapper {\r\n        width: 800px;\r\n        margin: 0 auto;\r\n    }\r\n</style>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0b614ba45d9d3ffe25c5bd27bbf04d4e075f004875", async() => {
                WriteLiteral(@"

        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <i class=""mr-2 fa fa-align-justify""></i>
                            <strong class=""card-title"" v-if=""headerText"">Resign System</strong>
                        </div>
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-md-10"">  <input type=""file"" id=""FileUpload1"" multiple class=""form-control"" /></div>
                                <div class=""col-md-2"">   <button type=""button"" style=""background: #4272d7; border: solid 1px #4272d7; "" name=""btn_upload"" id=""btn_upload"" class=""btn btn-success"">UPLOAD</button>   <button type=""button"" name=""btn_DownloadTemplate"" id=""btn_DownloadTemplate"" class=""btn btn-info"">TEMPLATE</button></div>
                            </div>



              ");
                WriteLiteral(@"          </div>

                 

                    </div>
                </div>
            </div>




            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <i class=""mr-2 fa fa-align-justify""></i>
                            <strong class=""card-title"" v-if=""headerText"">Charts System</strong>
                        </div>


                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <h3 class=""title-2 m-b-40"">Doughut Chart</h3>
                                    <canvas id=""doughutChart""></canvas>
                                </div>


                            </div>

                        </div>

                    </div>
                        <div class=""card"">
                            <div class=""c");
                WriteLiteral(@"ard-header"">
                                <i class=""mr-2 fa fa-align-justify""></i>
                                <strong class=""card-title"" v-if=""headerText"">Resign System</strong>
                            </div>

                            <div class=""card-body"">
                                <div class=""row"">

                                    <div class=""col-md-2"">Resign Date :   </div>
                                    <div class=""col-md-4"">   <select");
                BeginWriteAttribute("id", " id=\"", 2837, "\"", 2842, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0b614ba45d9d3ffe25c5bd27bbf04d4e075f007995", async() => {
                    WriteLiteral("07/2022");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</select></div>
                                    <div class=""col-md-4"">   <button type=""button"" style=""background: #4272d7; border: solid 1px #4272d7; "" name=""btn_Download"" id=""btn_Download"" class=""btn btn-success"">Download Report</button> </div>

                                    <div class=""col-md-2"">  </div>




                                </div>
                            </div>






                        </div>
                    </div>

                <div class=""col-md-6"">
                    <div class=""card"">

                        <div class=""card-header"">
                            <i class=""mr-2 fa fa-align-justify""></i>
                            <strong class=""card-title"" v-if=""headerText"">Resign System</strong>
                        </div>

                        <div class=""card-body"" style=""padding:50px;"">
                            <div class=""row"">

                                <table id=""datatables"" class=""table table-striped table-bo");
                WriteLiteral(@"rdered""  style=""width:100%"">
                                    <thead>
                                        <tr>
                                            <th>NO</th>
                                            <th>OPID</th>
                                            <th>Name</th>
                                            <th>SurName</th>
                                            <th>Position</th>
                                            <th>Level</th>
                                            <th>Sect.</th>
                                            <th>Dept.</th>
                                            <th>Hq.</th>
                                            <th>ResignDate</th>
                                            <th>ResignDateMaking</th>
                                            <th>OPIDMaking</th>

                                          
                                        </tr>
                                    </thead>
                         ");
                WriteLiteral("        \r\n                                  \r\n                                </table>\r\n\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n");
                WriteLiteral("        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script>
           
        $(document).ready(function () {

            $.ajax({
                url: ""GetOperetorResign"",
                method: ""POST"",
                dataType: ""Json"",
                success: function (data) {
                    $(""#datatables"").DataTable({
                        data: data,
                        columns: [
                    { data: ""no"" },
                    { data: ""opid"" },
                    { data: ""OPName"" },
                    { data: ""opSurName"" },
                    { data: ""opPosition"" },
                    { data: ""opLevel"" },
                    { data: ""opSect"" },
                    { data: ""opDept"" },
                    { data: ""opDiv"" },
                    { data: ""opHq"" },
                    { data: ""resignDate"" },
                    { data: ""resignDateMaking"" },
                    { data: ""opidMaking"" }
                ]
                    })
                }
            })
            //$('#datatab");
            WriteLiteral(@"les').DataTable({
            //    scrollX: true,
            //  //ajax: ""GetOperetorResign""
                
            //  //  ,
            //    bLengthChange: true,
            //   /* lengthMenu: [[5, 10, -1], [5, 10, ""All""]],*/
            //    bFilter: true,
            //    bSort: true,
            //    bPaginate: true,
            //    ajax: ""GetOperetorResign"",
            //    dataSrc: '',
            //    columns: [
            //        { data: ""no"" },
            //        { data: ""opid"" },
            //        { data: ""OPName"" },
            //        { data: ""opSurName"" },
            //        { data: ""opPosition"" },
            //        { data: ""opLevel"" },
            //        { data: ""opSect"" },
            //        { data: ""opDept"" },
            //        { data: ""opDiv"" },
            //        { data: ""opHq"" },
            //        { data: ""resignDate"" },
            //        { data: ""resignDateMaking"" },
            //        { data: ""opidMakin");
            WriteLiteral(@"g"" }
            //    ]

            //    //ajax: {
            //    //    url: ""GetOperetorResign"",
            //    //    dataSrc: 'data'
            //    //},
            //    //columns: [
            //    // { data: ""no"" },
            //    //{ data: ""opid"" },
            //    //{ data: ""opName"" },
            //    //{ data: ""OPSurName"" },
            //    //{ data: ""OPPosition"" },
            //    //{ data: ""OPLevel"" },
            //    //{ data: ""OPSect"" },
            //    //{ data: ""OPDept"" },
            //    //{ data: ""OPHq"" },
            //    //{ data: ""ResignDate"" },
            //    //{ data: ""ResignDateMaking"" },
            //    //{ data: ""OPIDMaking"" }
            //    // ]
            //});

            //ajax: {
            //    url: 'https://localhost:44317/api/GetOperatorsResign',
            //    method: ""GET"",
            //    xhrFields: {
            //        withCredentials: true
            //    }
            //},
            //co");
            WriteLiteral(@"lumns: [
            //    { data: ""NO"" },
            //    { data: ""OPID"" },
            //    { data: ""OPName"" },
            //    { data: ""OPSurName"" },
            //    { data: ""OPPosition"" },
            //    { data: ""OPLevel"" },
            //    { data: ""OPSect"" },
            //    { data: ""OPDept"" },
            //    { data: ""OPHq"" },
            //    { data: ""ResignDate"" },
            //    { data: ""ResignDateMaking"" },
            //    { data: ""OPIDMaking"" }
            //]


            /*window.location.href = 'C:\Users\010724\Desktop\Resignation_ 202207.xlsx';*/
        });

                                            //<th>NO</th>
                                            //<th>OPID</th>
                                            //<th>OPName</th>
                                            //<th>OPSurName</th>
                                            //<th>OPPosition</th>
                                            //<th>OPLevel</th>
                     ");
            WriteLiteral(@"                       //<th>OPSect</th>
                                            //<th>OPDept</th>
                                            //<th>OPDiv</th>
                                            //<th>OPHq</th>
                                            //<th>ResignDate</th>
                                            //<th>ResignDateMaking</th>
                                            //<th>OPIDMaking</th>

          



       
        $(""#btn_DownloadTemplate"").on(""click"", function () {
            window.location.href = 'C:\Users\010724\Desktop\Resignation_ 202207.xlsx';
        });


            $(""#btn_upload"").on(""click"", function () {
                var file = document.getElementById(""FileUpload1"")
                var formData = new FormData();
                var filess = file.files[0];
                formData.append('File', filess);

                $.ajax({
                    url: '");
#nullable restore
#line 313 "E:\Github\Freight_BOI\Freight_BOI\Import_Freight_BOI\Import_Freight_BOI\Views\Resign\Frm_Resign.cshtml"
                     Write(Url.Action("GetfileExcel"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    type: ""POST"",
                    contentType: false,
                    processData: false,
                    data: formData,
                    success: function (data) {
                        console.log(data);
                        window.location.href = data;
                    }
                });

            });


    </script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
