#pragma checksum "E:\Github\Freight_BOI\Freight_BOI\Import_Freight_BOI\Import_Freight_BOI\Views\Resign\Frm_Resign.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49b7a83b99e742747fcd2c45a965eee7025964fd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49b7a83b99e742747fcd2c45a965eee7025964fd", @"/Views/Resign/Frm_Resign.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3227ef76ccca694c120d9032a688aa75c02a1c4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Resign_Frm_Resign : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49b7a83b99e742747fcd2c45a965eee7025964fd4337", async() => {
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
                WriteLiteral("          </div>\r\n                    </div>\r\n                </div>\r\n\r\n");
                WriteLiteral("\r\n\r\n            </div>\r\n\r\n");
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script>
            var fileContent;

            $(document).ready(function () {
                /*window.location.href = 'C:\Users\010724\Desktop\Resignation_ 202207.xlsx';*/
            })
            var paths = """";

        /* $(""#FileUpload1"").on(""change"", function () {*/

        $(""#Test"").on(""change"", function () {

                //var fileUpload = $(""#FileUpload1"").get(0);
                //var files = fileUpload.files;
                //var fileData = new FormData();
                //for (var i = 0; i < files.length; i++) {
                //    fileData.append(files[i].name, files[i]);
                //}
                //console.log(fileData);
                var file = document.getElementById(""FileUpload1"")
                var formData = new FormData();
                var filess = file.files[0];
                formData.append('File', filess);

                $.ajax({
                    url: 'GetfileExcel',
                    type: ""POST"",
              ");
            WriteLiteral(@"      contentType: false,
                    processData: false,
                    data: formData,
                    success: function(data) {
                        console.log(data);
                        window.location = data;
                    }
                });

                //var formData = new FormData(); //file_Emp

                ///*    var files = $(""#file_Emp"").get(0).files[0];*/
                ////var file = document.getElementById(""file_Emp"").files[0];
                ////formData.append(""MyFile"", file);

                //formData.append(""file_Emp"", $(""#file_Emp"").prop('files'));


                //$.ajax({
                //    url: 'Get_data_file_Excel',
                //    type: 'POST',
                //    contentType: 'multipart/form-data',
                //    dataType: 'Json',
                //    data: formData,
                //    processData: false,
                //    contentType: false,
                //    success: function (d");
            WriteLiteral(@"ata) {
                //        console.log(data);
                //    }

                //})


            });
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
#line 156 "E:\Github\Freight_BOI\Freight_BOI\Import_Freight_BOI\Import_Freight_BOI\Views\Resign\Frm_Resign.cshtml"
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