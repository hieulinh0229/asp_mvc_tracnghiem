#pragma checksum "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21bd48a006f3231ac0a10cf0e9ffcd3b4419bf1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\_ViewImports.cshtml"
using TRACNGHIEMONLINE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Login\Index.cshtml"
using TRACNGHIEMONLINE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21bd48a006f3231ac0a10cf0e9ffcd3b4419bf1e", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c917d78255881e3a4d0bb73801ae0df2f337d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Login\Index.cshtml"
  
    ViewBag.Title = "Đăng Nhập Hệ Thống Trắc Nghiệm Online";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21bd48a006f3231ac0a10cf0e9ffcd3b4419bf1e4779", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>\r\n        ");
#nullable restore
#line 14 "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Login\Index.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </title>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21bd48a006f3231ac0a10cf0e9ffcd3b4419bf1e6275", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21bd48a006f3231ac0a10cf0e9ffcd3b4419bf1e7454", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21bd48a006f3231ac0a10cf0e9ffcd3b4419bf1e9345", async() => {
                WriteLiteral(@"
    <div class=""container h-100"">
        <div class=""d-flex justify-content-center h-100"">
            <div class=""user_card"">
                <div class=""d-flex justify-content-center"">
                    <div class=""brand_logo_container"">
                        <img src=""https://cdn.freebiesupply.com/logos/large/2x/pinterest-circle-logo-png-transparent.png"" class=""brand_logo"" alt=""Logo"">
                    </div>
                </div>
             
                <div class=""d-flex justify-content-center form_container"">
");
#nullable restore
#line 36 "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Login\Index.cshtml"
                     using (Html.BeginForm("Index", "Login", FormMethod.Post))
                    {
                        if (ViewBag.error != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <div class=\"custom-control custom-checkbox\">\r\n                                    <span class=\"error\">");
#nullable restore
#line 42 "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Login\Index.cshtml"
                                                   Write(ViewBag.error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 45 "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Login\Index.cshtml"
         
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""input-group mb-3"">
                            <div class=""input-group-append"">
                                <span class=""input-group-text""><i class=""fas fa-user""></i></span>
                            </div>
                            ");
#nullable restore
#line 51 "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Login\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Username, new { @class = "form-control input_user", @required = "required", @placeholder = "username", @autofocus = "autofocus" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <!-- <input type=""text"" name="""" class=""form-control input_user"" value="""" placeholder=""username"">-->
                        </div>
                        <div class=""input-group mb-2"">
                            <div class=""input-group-append"">
                                <span class=""input-group-text""><i class=""fas fa-key""></i></span>
                            </div>
                            ");
#nullable restore
#line 58 "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Login\Index.cshtml"
                       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control input_pass", @placeholder = "password", @required = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <!--<input type=\"password\" name=\"\" class=\"form-control input_pass\" value=\"\" placeholder=\"password\">-->\r\n                        </div>\r\n");
                WriteLiteral("                        <div class=\"d-flex justify-content-center mt-3 login_container\">\r\n                            <button type=\"submit\" name=\"button\" class=\"btn login_btn\">Login</button>\r\n                        </div>\r\n");
#nullable restore
#line 65 "C:\Users\chinh.hm_3si\Source\Repos\asp_mvc_tracnghiem\TRACNGHIEMONLINE\Views\Login\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>

                    <div class=""mt-4"">
                        <div class=""d-flex justify-content-center links"">
                            Don't have an account? <a href=""#"" class=""ml-2"">Sign Up</a>
                        </div>
                        <div class=""d-flex justify-content-center links"">
                            <a href=""#"">Forgot your password?</a>
                        </div>
                    </div>
                </div>
        </div>
    </div>
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
