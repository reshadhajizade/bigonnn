#pragma checksum "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d99f284ac26d77a93d2f415b720e5520f3ca117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
#line 2 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\_ViewImports.cshtml"
using BigOn.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\_ViewImports.cshtml"
using BigOn.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\_ViewImports.cshtml"
using BigOn.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\_ViewImports.cshtml"
using BigOn.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d99f284ac26d77a93d2f415b720e5520f3ca117", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"873358ee1d26b7bfce743c8ee8a72560d16a595d", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogPost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://htmldemo.net/bigon/bigon/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Newsletter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Breadcrumb Start -->\r\n<div class=\"breadcrumb-area ptb-50\">\r\n    <div class=\"container\">\r\n        <div class=\"breadcrumb\">\r\n            <ul>\r\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d99f284ac26d77a93d2f415b720e5520f3ca1177055", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                 <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d99f284ac26d77a93d2f415b720e5520f3ca1178440", async() => {
                WriteLiteral("Blogs");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""active"">Blog Details</li>
            </ul>
        </div>
    </div>
    <!-- Container End -->
</div>
<!-- Breadcrumb End -->
<!-- Blog Area Start -->
<div class=""blog-area pb-50"">
    <div class=""container"">
        <div class=""row"">
            <!-- Main Blog Start -->
            <div class=""col-lg-8 col-12"">
                <!-- Blog Details Start -->
                <div class=""blog-details"">
                    <div class=""blog-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d99f284ac26d77a93d2f415b720e5520f3ca11710125", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 873, "~/uploads/images/", 873, 17, true);
#nullable restore
#line 30 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 890, Model.ImagePath, 890, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"post-info\">\r\n                        <div class=\"post-info-left\">\r\n                            <div class=\"post-date\">\r\n                                <span>");
#nullable restore
#line 35 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
                                 Write(Model.PublishedDate?.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 35 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
                                                                             Write(Model.PublishedDate?.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <a href=""#"" class=""post-author"">
                                <i class=""fa fa-user""></i> By Jillur
                            </a>
                        </div>
                        <div class=""post-info-right"">
                            <a href=""#"" class=""post-like"">
                                <i class=""fa fa-heart""></i> 100
                            </a>
                            <a href=""#"" class=""post-comment"">
                                <i class=""fa fa-comment""></i> ");
#nullable restore
#line 46 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
                                                         Write(Model.Comments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                    <h3 class=\"semi-title\">");
#nullable restore
#line 50 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
                                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    ");
#nullable restore
#line 51 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
               Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <!--  Blog-Share Start  -->
                    <div class=""blog-share mtb-50"">
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-5 col-sm-6"">
                                <span class=""pull-left"">Category:</span>
                                <ul class=""list-inline"">
                                    <li><a href=""#"">");
#nullable restore
#line 58 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
                                               Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?</a></li>
                                </ul>
                            </div>
                            <div class=""col-lg-8 col-md-7 col-sm-6"">
                                <div class=""social-links text-right"">
                                    <ul class=""social-link-list"">
                                        <li>Share:</li>
                                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-instagram""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-reddit""></i></a></li>
                                    </ul>
                                </div>
      ");
            WriteLiteral(@"                      </div>
                        </div>
                        <!-- End of Row -->
                    </div>
                    <!--  Blog-Share End  -->
                    <!--  Blog-Pager Start  -->
                    <div class=""blog-pager"">
                        <ul class=""pager"">
                            <li class=""previous""><a href=""#""><i class=""zmdi zmdi-chevron-left""></i>prev post</a></li>
                            <li class=""next""><a href=""#"">Next post<i class=""zmdi zmdi-chevron-right""></i></a></li>
                        </ul>
                    </div>
                    <!--  Blog-Pager End  -->
                </div>
                <!-- Blog Details End -->
                <!-- Blog Realated Post Start -->
                ");
#nullable restore
#line 89 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
           Write(await Component.InvokeAsync("RelatedPosts",new {id=Model.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
               
                <!-- Blog Realated Post end -->
                <!-- Comment Area Start -->
                <div class=""comment-area recent-post"">
                    <h3 class=""sidebar-title"">1 COMMENTS</h3>
                    <!-- Single Comment Start -->
                    <div class=""single-comment"">
                        <div class=""comment-img f-left pr-30"">
                            <img src=""img/blog/6.jpg"" alt=""blog-comment"">
                        </div>
                        <div class=""comment-details fix"">
                            <h4><a href=""#"">RICE JOHNNY</a></h4>
                            <span>August 10, 2018 at 11:08 am</span>
                            <p>But I must explain to you how all this mistaken idea of denouncing pleas praising pain born and I will give you a complete account of the system</p>
                        </div>
                        <a class=""reply"" href=""#"">reply</a>
                    </div>
                    <!-");
            WriteLiteral(@"- Single Comment End -->
                </div>
                <!-- Comment Area End -->
                <!-- Contact Email Area Start -->
                <div class=""blog-detail-contact"">
                    <h3 class=""mb-5"">Contact Us</h3>
                    <p class=""text-capitalize mb-40"">Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d99f284ac26d77a93d2f415b720e5520f3ca11718294", async() => {
                WriteLiteral(@"
                        <div class=""address-wrapper row"">
                            <div class=""col-md-12"">
                                <div class=""address-fname"">
                                    <input type=""text"" name=""name"" placeholder=""Name"">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""address-email"">
                                    <input type=""email"" name=""email"" placeholder=""Email"">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""address-web"">
                                    <input type=""text"" name=""website"" placeholder=""Website"">
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""address-subject"">
           ");
                WriteLiteral(@"                         <input type=""text"" name=""subject"" placeholder=""Subject"">
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""address-textarea"">
                                    <textarea name=""message"" placeholder=""Write your message""></textarea>
                                </div>
                            </div>
                            <p class=""form-message ml-15""></p>
                            <div class=""col-12 footer-content mail-content"">
                                <div class=""send-email pull-right"">
                                    <input type=""submit"" value=""Submit"" class=""submit"">
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- Contact Email Area End -->
            </div>
            <!-- Main Blog End -->
            <!-- Sidebar Main Blog Start -->
            <div class=""col-lg-4 col-12"">
                <div class=""main-right-sidebar border-default universal-padding"">
                    <!-- Recent Post Start -->
                    <div class=""recent-post pt-30 same-sidebar"">
                        <h3 class=""sidebar-title"">recent posts</h3>
                       ");
#nullable restore
#line 159 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
                  Write(await Component.InvokeAsync("ResentPosts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <!-- Recent Post End -->
                    <!-- Category Post Start -->
                    <div class=""categorie recent-post same-sidebar"">
                        <h3 class=""sidebar-title mt-40"">categories</h3>
                        <ul class=""categorie-list"">
                            <li><a href=""#"">Corporate</a></li>
                            <li><a href=""#"">Creative</a></li>
                            <li><a href=""#"">Design</a></li>
                            <li><a href=""#"">News</a></li>
                            <li><a href=""#"">Photography</a></li>
                            <li><a href=""#"">Technology</a></li>
                        </ul>
                    </div>
                    <!-- Category Post End -->
                    <!-- Meta Post Start -->
                    <div class=""categorie recent-post same-sidebar"">
                        <h3 class=""sidebar-title mt-40"">others</h3>
                        <ul clas");
            WriteLiteral(@"s=""categorie-list"">
                            <li><a href=""log-in.html"">Log in</a></li>
                            <li><a href=""#"">Entries <abbr title=""Really Simple Syndication"">RSS</abbr></a></li>
                            <li><a href=""#"">Comments <abbr title=""Really Simple Syndication"">RSS</abbr></a></li>
                            <li><a href=""#"">WordPress.org</a></li>
                        </ul>
                    </div>
                    <!-- Meta Post End -->
                    <!-- Meta Post Start -->
                    <div class=""categorie recent-post same-sidebar"">
                        <h3 class=""sidebar-title mt-40"">Tags</h3>
                        <ul class=""tag-list"">
");
#nullable restore
#line 190 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
                             foreach(var item in Model.TagCloud)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <li><a href=\"#\">");
#nullable restore
#line 192 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
                                              Write(item.Tag?.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 193 "D:\Yeni klasör\BigOn solution\BigOn.WebUI\Views\Blog\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                         
                           
                        </ul>
                    </div>
                    <!-- Meta Post End -->
                </div>
            </div>
            <!-- Sidebar Main Blog End -->
        </div>
    </div>
    <!-- Container End -->
</div>
<!-- Blog Area End -->
 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d99f284ac26d77a93d2f415b720e5520f3ca11725706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPost> Html { get; private set; }
    }
}
#pragma warning restore 1591