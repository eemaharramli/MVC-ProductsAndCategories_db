#pragma checksum "/Users/elnur/Desktop/C#/MVC/MVC-ProductsAndCategories_db/MVC-ProductsAndCategories_db/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a33ccf3d3da0648f2b5cbfdc742c10b962a5877"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "/Users/elnur/Desktop/C#/MVC/MVC-ProductsAndCategories_db/MVC-ProductsAndCategories_db/Views/_ViewImports.cshtml"
using MVC_ProductsAndCategories_db.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/elnur/Desktop/C#/MVC/MVC-ProductsAndCategories_db/MVC-ProductsAndCategories_db/Views/_ViewImports.cshtml"
using MVC_ProductsAndCategories_db.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a33ccf3d3da0648f2b5cbfdc742c10b962a5877", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5110cd5d86b43945ba6eb2cc23c113c2b9192de3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/elnur/Desktop/C#/MVC/MVC-ProductsAndCategories_db/MVC-ProductsAndCategories_db/Views/Home/Detail.cshtml"
  
    ViewBag.Title = "title";
    Product product = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Home Detail</h2>\n<h4>Product detail: ");
#nullable restore
#line 7 "/Users/elnur/Desktop/C#/MVC/MVC-ProductsAndCategories_db/MVC-ProductsAndCategories_db/Views/Home/Detail.cshtml"
               Write(product);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
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
