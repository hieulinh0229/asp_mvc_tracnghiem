#pragma checksum "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b9b4bfeabaac6f9f7cf812e1036c4686e0d8a04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_StudentManagement), @"mvc.1.0.view", @"/Views/Admin/StudentManagement.cshtml")]
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
#line 1 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\_ViewImports.cshtml"
using TRACNGHIEMONLINE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\_ViewImports.cshtml"
using TRACNGHIEMONLINE.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
using TRACNGHIEMONLINE.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b9b4bfeabaac6f9f7cf812e1036c4686e0d8a04", @"/Views/Admin/StudentManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c917d78255881e3a4d0bb73801ae0df2f337d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_StudentManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TRACNGHIEMONLINE.Common.User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/users/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("users"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
  
    var user = Model;
    ViewBag.Title = "Hệ thống trắc nghiệm online";
    Layout = "";
    Class[] classes = ViewData["CLASS"] as Class[];


#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html dir=\"ltr\" lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b9b4bfeabaac6f9f7cf812e1036c4686e0d8a045670", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <title>\r\n        ");
#nullable restore
#line 18 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </title>
    <link rel=""canonical"" href=""https://www.wrappixel.com/templates/xtreme-admin-lite/"" />

    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""../../assets/images/favicon.png"">

    <link href=""../../dist/css/style.min.css"" rel=""stylesheet"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b9b4bfeabaac6f9f7cf812e1036c4686e0d8a047309", async() => {
                WriteLiteral(@"

    <div class=""preloader"">
        <div class=""lds-ripple"">
            <div class=""lds-pos""></div>
            <div class=""lds-pos""></div>
        </div>
    </div>
 
    <div id=""main-wrapper"" data-layout=""vertical"" data-navbarbg=""skin5"" data-sidebartype=""full""
         data-sidebar-position=""absolute"" data-header-position=""absolute"" data-boxed-layout=""full"">

        <header class=""topbar"" data-navbarbg=""skin5"">
            <nav class=""navbar top-navbar navbar-expand-md navbar-dark"">
                <div class=""navbar-header"" data-logobg=""skin5"">
               
                    <a class=""navbar-brand"" href=""/home"">
         
                        <b class=""logo-icon"">
                       
                            <img src=""../../assets/images/logo-icon.png"" alt=""homepage"" class=""dark-logo"" />
           
                            <img src=""../../assets/images/logo-light-icon.png"" alt=""homepage"" class=""light-logo"" />
                        </b>
                  
 ");
                WriteLiteral(@"                
                        <span class=""logo-text"">
                  
                            <img src=""../../assets/images/logo-text.png"" alt=""homepage"" class=""dark-logo"" />
                            <!-- Light Logo text -->
                            <img src=""../../assets/images/logo-light-text.png"" class=""light-logo"" alt=""homepage"" />
                        </span>
                    </a>
       
                    <a class=""nav-toggler waves-effect waves-light d-block d-md-none"" href=""javascript:void(0)"">
                        <i class=""ti-menu ti-close""></i>
                    </a>
                </div>
       
                <div class=""navbar-collapse collapse"" id=""navbarSupportedContent"" data-navbarbg=""skin5"">
           
                    <ul class=""navbar-nav float-start me-auto"">
             
                        <li class=""nav-item search-box"">

                        </li>
                    </ul>
            
                    <ul c");
                WriteLiteral(@"lass=""navbar-nav float-end"">
                 
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle text-muted waves-effect waves-dark pro-pic"" href=""#"" id=""navbarDropdown"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                <img src=""../../assets/images/users/1.jpg"" alt=""user"" class=""rounded-circle"" width=""31"">
                            </a>
                            <ul class=""dropdown-menu dropdown-menu-end user-dd animated"" aria-labelledby=""navbarDropdown"">
                                <a class=""dropdown-item"" href=""/admin/detail"">
                                    <i class=""ti-user m-r-5 m-l-5""></i>
                                    My Profile
                                </a>
                                <a class=""dropdown-item"" href=""javascript:void(0)"">
                                    <i class=""ti-wallet m-r-5 m-l-5""></i>
                                    My B");
                WriteLiteral(@"alance
                                </a>
                                <a class=""dropdown-item"" href=""javascript:void(0)"">
                                    <i class=""ti-email m-r-5 m-l-5""></i>
                                    Inbox
                                </a>
                            </ul>
                        </li>
            
                    </ul>
                </div>
            </nav>
        </header>

        <aside class=""left-sidebar"" data-sidebarbg=""skin6"">
     
            <div class=""scroll-sidebar"">
       
                <nav class=""sidebar-nav"">
                    <ul id=""sidebarnav"">
               
                        <li>
                      
                            <div class=""user-profile d-flex no-block dropdown m-t-20"">

                                <div class=""user-pic"">
");
#nullable restore
#line 115 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                     if (user.AVATAR == null)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2b9b4bfeabaac6f9f7cf812e1036c4686e0d8a0412142", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 120 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2b9b4bfeabaac6f9f7cf812e1036c4686e0d8a0413887", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5100, "~/Uploads/", 5100, 10, true);
#nullable restore
#line 124 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
AddHtmlAttributeValue("", 5110, user.AVATAR, 5110, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 126 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n\r\n                                <div class=\"user-content hide-menu m-l-10\">\r\n                                    <a href=\"#\"");
                BeginWriteAttribute("class", " class=\"", 5425, "\"", 5433, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""Userdd"" role=""button""
                                       data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        <h5 class=""m-b-0 user-name font-medium"">
                                            ");
#nullable restore
#line 133 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                       Write(user.NAME);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"fa fa-angle-down\"></i>\r\n                                        </h5>\r\n                                        <span class=\"op-5 user-email\">");
#nullable restore
#line 135 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                                                 Write(user.EMAIL);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    </a>\r\n                                    <div class=\"dropdown-menu dropdown-menu-end\" aria-labelledby=\"Userdd\">\r\n");
#nullable restore
#line 138 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                         if (user.IsAdmin())
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a class=\"dropdown-item\" href=\"/admin/detail\">\r\n                                                <i class=\"ti-user m-r-5 m-l-5\"></i> My Profile\r\n                                            </a>\r\n");
#nullable restore
#line 143 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <a class=\"dropdown-item\" href=\"/students/detail\">\r\n                                                <i class=\"ti-user m-r-5 m-l-5\"></i> My Profile\r\n                                            </a>\r\n");
#nullable restore
#line 149 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div class=""dropdown-divider""></div>
                                        <a class=""dropdown-item"" href=""/logout"">
                                            <i class=""fa fa-power-off m-r-5 m-l-5""></i> Logout
                                        </a>
                                    </div>
                                </div>
                            </div>
             
                        </li>

               
");
#nullable restore
#line 161 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                         if (user.IsAdmin())
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <li class=""sidebar-item"">
                                <a class=""sidebar-link waves-effect waves-dark sidebar-link""
                                   href=""/admin"" aria-expanded=""false"">
                                    <i class=""mdi mdi-view-dashboard""></i><span class=""hide-menu"">Dashboard</span>
                                </a>
                            </li>
                            <li class=""sidebar-item"">
                                <a class=""sidebar-link waves-effect waves-dark sidebar-link""
                                   href=""/admin/detail"" aria-expanded=""false"">
                                    <i class=""mdi mdi-account-network""></i><span class=""hide-menu"">Profile</span>
                                </a>
                            </li>
");
#nullable restore
#line 175 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <li class=""sidebar-item"">
                                <a class=""sidebar-link waves-effect waves-dark sidebar-link""
                                   href=""/students"" aria-expanded=""false"">
                                    <i class=""mdi mdi-view-dashboard""></i><span class=""hide-menu"">Dashboard</span>
                                </a>
                            </li>
                            <li class=""sidebar-item"">
                                <a class=""sidebar-link waves-effect waves-dark sidebar-link""
                                   href=""/students/detail"" aria-expanded=""false"">
                                    <i class=""mdi mdi-account-network""></i><span class=""hide-menu"">Profile</span>
                                </a>
                            </li>
");
#nullable restore
#line 190 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </ul>

                </nav>
     
            </div>

        </aside>
  
        <div class=""page-wrapper"">

            <div class=""page-breadcrumb"">
                <div class=""row align-items-center"">
                    <div class=""col-5"">
                        <div class=""d-flex align-items-center"">
                            <nav aria-label=""breadcrumb"">
                                <ol class=""breadcrumb"">
                                    <li class=""breadcrumb-item""><a href=""/home"">Home</a></li>
                                    <li class=""breadcrumb-item active"" aria-current=""page"">Detail</li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
  
  
            <div class=""container-fluid"">
          
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card"">
 ");
                WriteLiteral("                           <div class=\"card-body\">\r\n                                <h4 class=\"card-title\">\r\n                                    <i");
                BeginWriteAttribute("class", " class=\"", 10293, "\"", 10301, 0);
                EndWriteAttribute();
                WriteLiteral("></i> Danh sách sinh viên theo lớp\r\n                                </h4>\r\n");
#nullable restore
#line 226 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                 if (classes.Length > 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <div class="" m-t-10"">
                                        <a href=""/students/Create"">
                                            <i class=""fa fa-plus-square""></i> <span class=""hide-menu m-l-5"">Thêm sinh viên</span>
                                        </a>
                                    </div>
                                    <div class=""table-responsive"">
");
#nullable restore
#line 234 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                         for (var i = 0; i < classes.Length; i++)
                                        {
                                            var classe = classes[i];
                                            var sts = classe == null ? null : classe.Students.ToArray();
                                            var index = @i + 1;

                                            

#line default
#line hidden
#nullable disable
                WriteLiteral("<h6 class=\"card-title\">\r\n                                                <a>\r\n                                                    <i");
                BeginWriteAttribute("class", " class=\"", 11432, "\"", 11497, 6);
                WriteAttributeValue("", 11440, "m-r-5", 11440, 5, true);
                WriteAttributeValue(" ", 11445, "font-18", 11446, 8, true);
                WriteAttributeValue(" ", 11453, "mdi", 11454, 4, true);
                WriteAttributeValue(" ", 11457, "mdi-numeric-", 11458, 13, true);
#nullable restore
#line 242 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
WriteAttributeValue("", 11470, index, 11470, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 11476, "-box-multiple-outline", 11476, 21, true);
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                                                    ");
#nullable restore
#line 243 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                               Write(classe.Class_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </a>\r\n                                            </h6>\r\n");
#nullable restore
#line 246 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                             if (sts == null || sts.Length == 0)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <h6 class=\"card-title\">\r\n                                                    <span style=\"color:red\">Không có sinh viên  </span>\r\n                                                </h6>\r\n");
#nullable restore
#line 251 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <table class=""table"">
                                                    <thead>
                                                        <tr>
                                                            <th scope=""col"">#</th>
                                                            <th scope=""col"">Tên</th>
                                                            <th scope=""col"">Email</th>
                                                            <th scope=""col"">Địa chỉ</th>
                                                            <th scope=""col"">Giới tính</th>
                                                            <th scope=""col"">Phone</th>
                                                        </tr>
                                                    </thead>
");
#nullable restore
#line 265 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                                     for (var j = 1; j <= sts.Length; j++)
                                                    {
                                                        var st = sts[j - 1];

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <tbody>\r\n                                                            <tr>\r\n                                                                <th scope=\"row\">");
#nullable restore
#line 270 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                                                           Write(j);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                                                <td>");
#nullable restore
#line 271 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                                               Write(st.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 272 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                                               Write(st.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 273 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                                               Write(st.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 274 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                                               Write(st.Gender);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 275 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                                               Write(st.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                            </tr>\r\n\r\n                                                        </tbody>\r\n");
#nullable restore
#line 279 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                </table>\r\n");
#nullable restore
#line 281 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"

                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 282 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n");
#nullable restore
#line 285 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <div class="" m-t-10"">
                                        <h6 class=""card-title"">
                                            <span style=""color:red"">Không có lớp học </span>
                                        </h6>
                                    </div>
                                    <div class="" m-t-10"">
                                        <a href=""/class/create"">
                                            <i class=""fa fa-plus-square""></i> <span class=""hide-menu m-l-5"">Thêm lớp học</span>
                                        </a>
                                    </div>
");
#nullable restore
#line 298 "C:\Users\mchin\Downloads\LTrWeb.BaitapLon.03\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Admin\StudentManagement.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>

                        </div>
                    </div>

                </div>
            
           
            </div>

            <footer class=""footer text-center"">
                All Rights Reserved by  <a>TRACNGHIEMONLINE</a>.
            </footer>
    
        </div>
      
        <
    </div>
   

    <script src=""../../assets/libs/jquery/dist/jquery.min.js""></script>

    <script src=""../../assets/libs/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""../../dist/js/app-style-switcher.js""></script>

    <script src=""../../dist/js/waves.js""></script>

    <script src=""../../dist/js/sidebarmenu.js""></script>

    <script src=""../../dist/js/custom.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TRACNGHIEMONLINE.Common.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
