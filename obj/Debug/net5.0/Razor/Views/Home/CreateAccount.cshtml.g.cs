#pragma checksum "/home/jessica/Documents/Training - OTJ/Notes App Jul- 2021/NotesApp/Views/Home/CreateAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e478f997f677b92f92083b7f463e62d40d1bf43c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateAccount), @"mvc.1.0.view", @"/Views/Home/CreateAccount.cshtml")]
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
#line 1 "/home/jessica/Documents/Training - OTJ/Notes App Jul- 2021/NotesApp/Views/_ViewImports.cshtml"
using NotesApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/jessica/Documents/Training - OTJ/Notes App Jul- 2021/NotesApp/Views/_ViewImports.cshtml"
using NotesApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e478f997f677b92f92083b7f463e62d40d1bf43c", @"/Views/Home/CreateAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee6e68c04d81313d4a59fab2f499029767cb0c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "/home/jessica/Documents/Training - OTJ/Notes App Jul- 2021/NotesApp/Views/Home/CreateAccount.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Create Account";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"display-4 text-center\">Create Account</h1>\r\n    <div class=\"center-form\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e478f997f677b92f92083b7f463e62d40d1bf43c3943", async() => {
                WriteLiteral("\r\n            <div class=\"form-container\">\r\n                <div class=\"form-section\">\r\n                    <label for=\"fname\">Forname</label>\r\n                    <input type=\"text\" id=\"fname\" name=\"fname\"");
                BeginWriteAttribute("value", " value=\"", 415, "\"", 423, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"sname\">Surname</label>\r\n                    <input type=\"text\" id=\"sname\" name=\"sname\"");
                BeginWriteAttribute("value", " value=\"", 545, "\"", 553, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"dob\">D.O.B</label>\r\n                    <input type=\"date\" id=\"dob\" name=\"dob\"");
                BeginWriteAttribute("value", " value=\"", 667, "\"", 675, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"email\">Email</label>\r\n                    <input type=\"email\" id=\"email\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 796, "\"", 804, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-section\">\r\n                    <label for=\"uname\">Username</label>\r\n                    <input type=\"text\" id=\"uname\" name=\"uname\"");
                BeginWriteAttribute("value", " value=\"", 995, "\"", 1003, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"pword\">Password</label>\r\n                    <input type=\"text\" id=\"pword\" name=\"pword\"");
                BeginWriteAttribute("value", " value=\"", 1126, "\"", 1134, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"confpw\">Confirm Password</label>\r\n                    <input type=\"text\" id=\"confpw\" name=\"confpw\"");
                BeginWriteAttribute("value", " value=\"", 1268, "\"", 1276, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <label class=\"terms-conditions\"><input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1390, "\"", 1398, 0);
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 1399, "\"", 1407, 0);
                EndWriteAttribute();
                WriteLiteral(">I agree to the terms and conditions.</label>\r\n            <div class=\"text-center\">\r\n                <input type=\"submit\" value=\"Submit\" class=\"form-buttons\">\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
