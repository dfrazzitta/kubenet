#pragma checksum "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12de5a87ba6ff7efe51fe11b97289336f968e87e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enrollments_Index), @"mvc.1.0.view", @"/Views/Enrollments/Index.cshtml")]
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
#line 1 "G:\f16kube\kubenet\mvcfront\Views\_ViewImports.cshtml"
using mvcfront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\f16kube\kubenet\mvcfront\Views\_ViewImports.cshtml"
using mvcfront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12de5a87ba6ff7efe51fe11b97289336f968e87e", @"/Views/Enrollments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1492576e1cbcc4e8a940710f228cb2853de388", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Enrollments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<mvcfront.Models.Enrollment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 10 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 15 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Course.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 18 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Student.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 26 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 29 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Course.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 32 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Student.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 35 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 38 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id=item.EnrollmentID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 39 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
       Write(Html.ActionLink("Details", "Details", new { id=item.EnrollmentID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n            ");
#nullable restore
#line 40 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id=item.EnrollmentID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 43 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n<div><h1>");
#nullable restore
#line 48 "G:\f16kube\kubenet\mvcfront\Views\Enrollments\Index.cshtml"
    Write(ViewData["ip"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<mvcfront.Models.Enrollment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
