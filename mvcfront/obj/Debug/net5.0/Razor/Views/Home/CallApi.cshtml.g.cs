#pragma checksum "/home/dave/kubenet/mvcfront/Views/Home/CallApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0538ada4802d5a31f0c2ebbe2d3e798364e024e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CallApi), @"mvc.1.0.view", @"/Views/Home/CallApi.cshtml")]
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
#line 1 "/home/dave/kubenet/mvcfront/Views/_ViewImports.cshtml"
using mvcfront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dave/kubenet/mvcfront/Views/_ViewImports.cshtml"
using mvcfront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0538ada4802d5a31f0c2ebbe2d3e798364e024e7", @"/Views/Home/CallApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1492576e1cbcc4e8a940710f228cb2853de388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CallApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dave/kubenet/mvcfront/Views/Home/CallApi.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1>CALLAPI University</h1>
</div>
<div class=""row"">
    <div class=""col-md-4"">
        <h2>Welcome to CALLAPI University</h2>
        <p>
            Contoso University is a sample application that
            demonstrates how to use Entity Framework Core in an
            ASP.NET Core MVC web application.
        </p>
    </div>
    <div class=""col-md-4"">
        <h2>Build it from CALLAPI</h2>
        <p>You can build the application by following the steps in a series of tutorials.</p>
        <p><a class=""btn btn-default"" href=""https://docs.asp.net/en/latest/data/ef-mvc/intro.html"">See the tutorial &raquo;</a></p>
    </div>
    <div class=""col-md-4"">
        <h2>CALLAPI it</h2>
        <p>You can download the completed project from GitHub.</p>
        <p><a class=""btn btn-default"" href=""https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/data/ef-mvc/intro/samples/cu-final"">See project source code &raquo;</a></p>
    </div>
</div>

<h1>");
#nullable restore
#line 29 "/home/dave/kubenet/mvcfront/Views/Home/CallApi.cshtml"
Write(ViewData["json"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
