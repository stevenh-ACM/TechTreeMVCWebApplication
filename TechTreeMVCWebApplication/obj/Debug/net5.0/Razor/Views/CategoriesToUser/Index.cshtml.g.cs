#pragma checksum "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e88212d4733c3c63553e0b9d1e63718b1e9d6398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoriesToUser_Index), @"mvc.1.0.view", @"/Views/CategoriesToUser/Index.cshtml")]
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
#line 1 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e88212d4733c3c63553e0b9d1e63718b1e9d6398", @"/Views/CategoriesToUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f497735ae3055e8624d62bf37cdeb301ce2ba2ee", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoriesToUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechTreeMVCWebApplication.Models.CategoriesToUserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row mt-5\">\r\n    <div class=\"col-md-10\">\r\n        <h2>Choose your Courses</h2>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88212d4733c3c63553e0b9d1e63718b1e9d63984435", async() => {
                WriteLiteral("\r\n    <div class=\"rom mt-3\">\r\n        <div class=\"col-md-10\">\r\n            <table class=\"table table-bordered\">\r\n");
#nullable restore
#line 12 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml"
                 if(Model != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <thead>\r\n                        <tr>\r\n                            <th></th>\r\n                            <th>Category</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml"
                         foreach(var category in Model.Categories) 
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td style=\"text-align:center; width:150px;\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml"
                                     if (Model.CategoriesSelected != null && Model.CategoriesSelected.Contains(category, new CompareCategories()))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"checkbox\" class=\"form-check-input\" id=\"CategoriesSelected\" name=\"CategoriesSelected\" checked");
                BeginWriteAttribute("value", " value=\"", 1146, "\"", 1166, 1);
#nullable restore
#line 28 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml"
WriteAttributeValue("", 1154, category.Id, 1154, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 29 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"checkbox\" class=\"form-check-input\" id=\"CategoriesSelected\" name=\"CategoriesSelected\"");
                BeginWriteAttribute("value", " value=\"", 1429, "\"", 1449, 1);
#nullable restore
#line 32 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml"
WriteAttributeValue("", 1437, category.Id, 1437, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 33 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml"
                               Write(category.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n");
#nullable restore
#line 40 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Views\CategoriesToUser\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-10 d-flex\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-outline-info ml-auto\" />\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechTreeMVCWebApplication.Models.CategoriesToUserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
