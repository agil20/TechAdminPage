#pragma checksum "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9f395bc87d02b42ec73fd9b6f7031a96ca5e213"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Dashboard_Calls), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Dashboard/Calls.cshtml")]
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
#line 3 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\_ViewImports.cshtml"
using WebApplication.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9f395bc87d02b42ec73fd9b6f7031a96ca5e213", @"/Areas/AdminPanel/Views/Dashboard/Calls.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"587379b4ae4b31cb58ccb94e6d94183de0c775f5", @"/Areas/AdminPanel/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminPanel_Views_Dashboard_Calls : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderStatusReportViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/images/arrow.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/AdminPanel/dashboard/Calls"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
  
    ViewData["Title"] = "Calls";
    Layout = "~/Areas/AdminPanel/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <div class=\"main-panel\">\r\n        <div class=\"content-wrapper\">\r\n          <div class=\"row\">\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9f395bc87d02b42ec73fd9b6f7031a96ca5e2135122", async() => {
                WriteLiteral(@"
    <label for=""start-date"">Başlangıç Tarihi:</label>
    <input type=""date"" id=""start-date"" name=""startTime"" />

    <label for=""end-date"">Bitiş Tarihi:</label>
    <input type=""date"" id=""end-date"" name=""endTime"" />
          
       <div class=""custom-combobox-container"">
            <div class=""custom-combobox"" onclick=""showOptions(this)"">
                <input type=""text"" id=""inputCheckbox"" readonly>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f9f395bc87d02b42ec73fd9b6f7031a96ca5e2135839", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"options-container\" id=\"divOptions\" onmouseleave=\"hideOptions(this)\">\r\n");
#nullable restore
#line 23 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
   foreach (object item in ViewBag.Users)
{

#line default
#line hidden
#nullable disable
                WriteLiteral("    <label for=\"one\"> <input type=\"checkbox\" name=\"userId\"");
                BeginWriteAttribute("id", " id=\"", 1002, "\"", 1062, 1);
#nullable restore
#line 25 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
WriteAttributeValue("", 1007, (int)item.GetType().GetProperty("Id").GetValue(item), 1007, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1063, "\"", 1126, 1);
#nullable restore
#line 25 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
WriteAttributeValue("", 1071, (int)item.GetType().GetProperty("Id").GetValue(item), 1071, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 25 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
                                                                                                                                                                                     Write((string)item.GetType().GetProperty("Name").GetValue(item));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n");
#nullable restore
#line 26 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n           \r\n        </div>\r\n    </div>\r\n     <button type=\"submit\">Filtrele</button>\r\n");
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
  
     

          </div>
       
          <div class=""row"">
          

            <div class=""col-md-12 grid-margin stretch-card"">
              <div class=""card"">
                <div class=""card-body"">
              <p class=""card-title"">Fabrik İrad Göstərisi</p>

                         <table class=""mytable"">
  <tr>
    <th>Operatorun adı</th>
    <th>Sifariş götürüldü</th>
    <th>Maraqlandı</th>
     <th>Öz götürmə</th>
     <th>İmtina</th>
           <th>Geri qaytarma</th>
              
  </tr>

");
#nullable restore
#line 57 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n    <td>");
#nullable restore
#line 60 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
   Write(item.OperatorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 61 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
   Write(item.OrderHasBeenTaken);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 62 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
   Write(item.WasInterested);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 63 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
   Write(item.TakeSelf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 64 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
   Write(item.Reject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 65 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"
   Write(item.ReturnBack);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n");
#nullable restore
#line 67 "C:\Users\asus\Desktop\XalchaAdmin\TechAdminPage\WebApplication\WebApplication\Areas\AdminPanel\Views\Dashboard\Calls.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \r\n \r\n</table>\r\n                </div>\r\n              </div>\r\n            </div>\r\n         \r\n            </div>\r\n            </div>\r\n             </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"     <script>
        function showOptions(e) {
            let divOptions = document.getElementById(""divOptions"");
            if (divOptions.style.display == ""none"" || divOptions.style.display == """") {
                divOptions.style.display = ""inline-block"";
            } else {
                divOptions.style.display = ""none"";
            }
        }
        function clickMe(e) {
            console.log('click me');
            e.stopPropagation();
        }
        function hideOptions(e) {
            let divOptions = document.getElementById(""divOptions"");

            if (divOptions.contains(e.target)) {
                divOptions.style.display = ""inline-block"";
            } else {
                divOptions.style.display = ""none"";
            }
        }
    </script>

       ");
            }
            );
            WriteLiteral("       \r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderStatusReportViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
