#pragma checksum "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc2c3c61d3e6cfa9d4970efe2e8fee7fc7ecd99c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__UsersListViewPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_UsersListViewPartial.cshtml")]
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
#line 1 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
using TechTreeMVCWebApplication.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc2c3c61d3e6cfa9d4970efe2e8fee7fc7ecd99c", @"/Areas/Admin/Views/Shared/_UsersListViewPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad55f50704b5d00f903fcf913fbc8f72c16bd8a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__UsersListViewPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechTreeMVCWebApplication.Areas.Admin.Models.UsersCategoryListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th>First Name</th>\r\n            <th>Last Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
         if(Model.Users != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
             foreach(var user in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"text-align:center\">\r\n");
#nullable restore
#line 19 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                     if (Model.UsersSelected != null && Model.UsersSelected.Contains(user, new CompareUsers()))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\" checked");
            BeginWriteAttribute("value", " value=\"", 742, "\"", 758, 1);
#nullable restore
#line 21 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 750, user.Id, 750, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 22 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\"");
            BeginWriteAttribute("value", " value=\"", 947, "\"", 963, 1);
#nullable restore
#line 25 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 955, user.Id, 955, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 26 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
               Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
               Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\sjhou\OneDrive - Acumatica\Documents\GitHub\TechTreeMVCWebApplication\TechTreeMVCWebApplication\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechTreeMVCWebApplication.Areas.Admin.Models.UsersCategoryListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
