#pragma checksum "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56a98e30c7fa7b6c1326d6ec54e2143a49c3ff6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Faqs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Faqs/Index.cshtml")]
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
#line 2 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using BigOn.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
using BigOn.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a98e30c7fa7b6c1326d6ec54e2143a49c3ff6e", @"/Areas/Admin/Views/Faqs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8188a39c3bbd2c9d0ba5a5d69fb4140991e10218", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Faqs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Faq>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/toastr.js/toastr.customize.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral("\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56a98e30c7fa7b6c1326d6ec54e2143a49c3ff6e8079", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <style>\r\n   \r\n    \r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"

   






                                    <!-- Page-header start -->
                                        <div class=""page-header"">
                                        <div class=""row align-items-end"">
                                            <div class=""col-lg-8"">
                                                <div class=""page-header-title"">
                                                    <div class=""d-inline"">
                                                        <h4>Bootstrap Border Sizes</h4>
                                                        <span>lorem ipsum dolor sit amet, consectetur adipisicing
                                                            elit</span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-lg-4"">
                                                <div class=");
            WriteLiteral(@"""page-header-breadcrumb"">
                                                    <ul class=""breadcrumb-title"">
                                                        <li class=""breadcrumb-item"" style=""float: left;"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a98e30c7fa7b6c1326d6ec54e2143a49c3ff6e10711", async() => {
                WriteLiteral("\r\n                                                                <i class=\"feather icon-home\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        
                                                        <li class=""breadcrumb-item"" style=""float: left;"">
                                                            <span>Faqs</span>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Page-header end -->

                                    <!-- Page-body start -->
                                    <div class=""page-body"">
                                        <!-- Horizontal-border table start -->
                                        <div class=""card"">
                                            <div class=""card-header"">
                                                <h5>Horizo");
            WriteLiteral(@"ntal Borders</h5>
                                                <span>Example of <code>horizontal</code> table borders. This is a
                                                    default table border style attached to <code>.table</code> class.
                                                    All borders have the same grey color and style, table itself doesn't
                                                    have a border, but you can add this border using
                                                    <code>.table-framed</code> class added to the table with
                                                    <code>.table</code> class.</span>
                                                    ");
#nullable restore
#line 65 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
                                               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                            <div class=""card-block table-border-style"">
                                                <div class=""table-responsive"">
                                                   <table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 73 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Question));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n                 <th>\r\n                ");
#nullable restore
#line 76 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 79 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n          \r\n            <th class=\"operations\">\r\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a98e30c7fa7b6c1326d6ec54e2143a49c3ff6e15585", async() => {
                WriteLiteral("<i class=\"fa fa-plus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 88 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n             <td>\r\n                 \r\n                ");
#nullable restore
#line 92 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
           Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n                 <td>\r\n                ");
#nullable restore
#line 95 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
           Write(item.Answer.ToPlainText().ToEllipse(40));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td class=\"operations\">\r\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a98e30c7fa7b6c1326d6ec54e2143a49c3ff6e18167", async() => {
                WriteLiteral("<i class=\"fa fa-pencil\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a98e30c7fa7b6c1326d6ec54e2143a49c3ff6e20442", async() => {
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                   <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5007, "\"", 5056, 5);
            WriteAttributeValue("", 5017, "removeEntity(", 5017, 13, true);
#nullable restore
#line 104 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
WriteAttributeValue("", 5030, item.Id, 5030, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5038, ",\'", 5038, 2, true);
#nullable restore
#line 104 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
WriteAttributeValue("", 5040, item.Question, 5040, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5054, "\')", 5054, 2, true);
            EndWriteAttribute();
            WriteLiteral(" ><i class=\"fa fa-trash\"></i></a>\r\n            \r\n                \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 109 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- Horizontal-border table end -->
                                        <!-- Vertical borders table start -->
                                       
                                    </div>
                                    







");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a98e30c7fa7b6c1326d6ec54e2143a49c3ff6e24467", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a98e30c7fa7b6c1326d6ec54e2143a49c3ff6e25608", async() => {
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a98e30c7fa7b6c1326d6ec54e2143a49c3ff6e26789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            <script class= ""removeable"">

                                                function removeEntity(id,name){
                                                    swal(`eminsinizki ${name} silinsin?`, {
                                                       buttons: [""Xeyr"", ""Beli""],

                                                 }) 
                                                 .then((value)=>{
                                                     if(value==true){
                                                         let vToken = $('[name=__RequestVerificationToken]').val();
                                                       let formData = new FormData();
                                                       formData.set('__RequestVerificationToken',vToken);
                                                       formData.set('id',id)

                                                         $.ajax({
                                     ");
                WriteLiteral("                    url:`");
#nullable restore
#line 146 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Areas\Admin\Views\Faqs\Index.cshtml"
                                                         Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/${id}`,
                                                         data:formData,
                                                         contentType:false,
                                                         processData:false,
                                                         type:'POST',
                                                         success:function (response){
                                                             console.log(response);
                                                             if(response.error==true){
                                                                 toastr.error(response.message,""xeta!"")
                                                             }

                                                             location.reload();
                                                         },
                                                         error:function(errorResponse){
                                                      ");
                WriteLiteral(@"       console.log(errorResponse);
                                                         }
                                                         
                                                         });
                                                     }
                                                 });
                                                   
                                                }
                                            </script>
                                        ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Faq>> Html { get; private set; }
    }
}
#pragma warning restore 1591
