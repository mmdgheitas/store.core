#pragma checksum "E:\source\store.core\store.core\Views\customer\login_singin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98456472aae7475ce3b3dc0841cbf9e38b800616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_customer_login_singin), @"mvc.1.0.view", @"/Views/customer/login_singin.cshtml")]
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
#line 1 "E:\source\store.core\store.core\Views\_ViewImports.cshtml"
using store.core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\source\store.core\store.core\Views\_ViewImports.cshtml"
using store.core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98456472aae7475ce3b3dc0841cbf9e38b800616", @"/Views/customer/login_singin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4e75c50806eab65826208f60ee7db31a0caf07a", @"/Views/_ViewImports.cshtml")]
    public class Views_customer_login_singin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "login0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-account text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/jquery-3.2.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\source\store.core\store.core\Views\customer\login_singin.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- login----------------------------------->
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg"">
            <section class=""page-account-box"">
                <div class=""col-lg-6 col-md-6 col-xs-12 mx-auto"">
                    <div class=""ds-userlogin"">
                        <a href=""#"" class=""account-box-logo"">digismart</a>
                        <div class=""account-box"">
                            <div class=""account-box-headline"">
                                <a class=""login-ds active"" id=""btn_login"">
                                    <span class=""title"">????????</span>
                                    <span class=""sub-title"">???? ???????? ????????????</span>
                                </a>
                                <a class=""register-ds"" id=""btn_signin"">
                                    <span class=""title"">?????? ??????</span>
                                    <span class=""sub-title"">???? ???????? ????????????</span>
                                </a>
            ");
            WriteLiteral(@"                </div>
                            <div class=""Login-to-account mt-4"" id=""login"">
                                <div class=""account-box-content"">
                                    <h4>???????? ???? ???????? ????????????</h4>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98456472aae7475ce3b3dc0841cbf9e38b8006166528", async() => {
                WriteLiteral(@"
                                        <div class=""form-account-title"">
                                            <label for=""username"">?????? ????????????</label>
                                            <input type=""text"" class=""number-email-input"" id=""user"" name=""UserName"">
                                        </div>
                                        <div class=""form-account-title"">
                                            <label for=""password"">?????? ????????</label>
                                            <a href=""#"" class=""account-link-password"">?????? ?????? ???? ???????????? ???????? ????</a>
                                            <input type=""text"" class=""password-input"" name=""PasswordHash"">
                                        </div>
                                        <div class=""form-auth-row"">
                                            <label for=""#"" class=""ui-checkbox mt-1"">
                                                <input type=""checkbox"" value=""1"" name=""login"" id=""remember"">
");
                WriteLiteral(@"                                                <span class=""ui-checkbox-check""></span>
                                            </label>
                                            <label for=""remember"" class=""remember-me mr-0"">?????? ???? ???????? ??????????</label>
                                        </div>
                                        <div class=""text-danger text-center"">");
#nullable restore
#line 43 "E:\source\store.core\store.core\Views\customer\login_singin.cshtml"
                                                                        Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                        <div class=""form-row-account"">
                                            <button id=""login"" class=""btn btn-primary btn-login"" type=""submit"">???????? ???? ???????? ????????????</button>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
                                </div>
                            </div>
                            <div class=""Login-to-account mt-4"" id=""signin"">
                                <div class=""account-box-content"">
                                    <h4>?????? ?????? ???? ???????? ????????????</h4>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98456472aae7475ce3b3dc0841cbf9e38b80061610466", async() => {
                WriteLiteral(@"

                                        <div class=""form-account-title"">
                                            <label for=""name"">??????</label>
                                            <input type=""text"" class=""number-email-input"" name=""name"">
                                        </div>
                                        <div class=""form-account-title"">
                                            <label for=""family"">?????? ????????????????</label>
                                            <input type=""text"" class=""number-email-input"" name=""family"">
                                        </div>
                                        <div class=""form-account-title"">
                                            <label for=""mobile"">????????????</label>
                                            <input type=""text"" class=""number-email-input"" name=""mobile"">
                                        </div>
                                        <div class=""form-account-title"">
                       ");
                WriteLiteral(@"                     <label for=""email"">??????????</label>
                                            <input type=""text"" class=""number-email-input"" name=""Email"">
                                        </div>
                                        <div class=""form-account-title"">
                                            <label for=""address"">????????</label>
                                            <input type=""text"" class=""number-email-input"" name=""address"">
                                        </div>
                                        <div class=""form-account-title"">
                                            <label for=""post"">???? ????????</label>
                                            <input type=""text"" class=""number-email-input""  name=""post"">
                                        </div>
                                        <div class=""form-account-title"">
                                            <label for=""username"">?????? ????????????</label>
                                          ");
                WriteLiteral(@"  <input type=""text"" class=""number-email-input"" name=""UserName"">
                                        </div>
                                        <div class=""form-account-title"">
                                            <label for=""password"">?????? ????????</label>
                                            <input type=""password"" class=""password-input"" id=""pass"" name=""pass"">
                                        </div>



                                        <div class=""form-auth-row"">
                                            <label for=""#"" class=""ui-checkbox mt-1"">
                                                <input type=""checkbox"" value=""1"" name=""login"" id=""remember"">
                                                <span class=""ui-checkbox-check""></span>
                                            </label>
                                            <label for=""remember"" class=""remember-me mr-0""><a href=""#"">???????? ??????????</a> ?? <a href=""#"">?????????? ???????????? </a>?????????????? ???? ?????????? ?????? ???????? ??");
                WriteLiteral(@"????????????????????? ???? ???????????? ?????????? ?? ???? ???????? ?????????? ???? ????????????.</label>
                                        </div>
                                        <div class=""form-row-account"">
                                            <button id=""btnr"" class=""btn btn-primary btn-register"" type=""submit"">?????? ?????? ???? ???????? ????????????</button>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
</div>
<!-- login----------------------------------->
<!-- scroll_Progress------------------------->
<div class=""progress-wrap"">
    <svg class=""progress-circle svg-content"" width=""100%"" height=""100%"" viewBox=""-1 -1 102 102"">
        <path d=""M50,1 a49,49 0 0,1 0,98 a49,49 0 0,1 0,-98"" />
    </svg>
</div>
<!-- scroll_Progress------------------------->
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98456472aae7475ce3b3dc0841cbf9e38b80061616566", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        $(""#signin"").css(""display"", ""none"");
        $(""#btn_login"").click(function () {
            $(""#signin"").fadeOut(200);
            $(""#btn_login"").addClass(""active"");
            $(""#btn_signin"").removeClass(""active"");
            $(""#login"").fadeIn(200);
        });
        $(""#btn_signin"").click(function () {
            $(""#login"").fadeOut(200);
            $(""#btn_signin"").addClass(""active"");
            $(""#btn_login"").removeClass(""active"");
            $(""#signin"").fadeIn(200);
        });
        $(""#login"").click(function () {
            $.get('customer/login', { username: $(""#user"").val(), password: $(""#pass"").val() }, function (data)
            {
                alert(""data"")
            })
        })
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
