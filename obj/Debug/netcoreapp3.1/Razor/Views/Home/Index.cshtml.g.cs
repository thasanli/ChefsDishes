#pragma checksum "/Users/tural.hasanli/Desktop/Dojo_Assigments/C#/ChefsDishes/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc76ac82deb5c9176b1849b39ee0c25ab1346f23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/tural.hasanli/Desktop/Dojo_Assigments/C#/ChefsDishes/Views/_ViewImports.cshtml"
using ChefsDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tural.hasanli/Desktop/Dojo_Assigments/C#/ChefsDishes/Views/_ViewImports.cshtml"
using ChefsDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc76ac82deb5c9176b1849b39ee0c25ab1346f23", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4173e1c09328e4989c76d1431c897dfcd73c0666", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/tural.hasanli/Desktop/Dojo_Assigments/C#/ChefsDishes/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Chefs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div class=\"dataContainer\">\r\n    <div class=\"headerContainer\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 140, "\"", 147, 0);
            EndWriteAttribute();
            WriteLiteral(@">Chefs</a>
        <a href=""/dishes"">Dishes</a>
        <a href=""/new""> Add a Chef</a>
    </div>
    <h3>Check out our roster of Chefs</h3>
    <hr>
    <table>
        <thead>
            <tr>
                <th>Name</th>
                <th>Age</th>
                <th># of Dishes</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "/Users/tural.hasanli/Desktop/Dojo_Assigments/C#/ChefsDishes/Views/Home/Index.cshtml"
             foreach(var chef in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 28 "/Users/tural.hasanli/Desktop/Dojo_Assigments/C#/ChefsDishes/Views/Home/Index.cshtml"
               Write(chef.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "/Users/tural.hasanli/Desktop/Dojo_Assigments/C#/ChefsDishes/Views/Home/Index.cshtml"
                               Write(chef.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 29 "/Users/tural.hasanli/Desktop/Dojo_Assigments/C#/ChefsDishes/Views/Home/Index.cshtml"
               Write(chef.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 30 "/Users/tural.hasanli/Desktop/Dojo_Assigments/C#/ChefsDishes/Views/Home/Index.cshtml"
               Write(chef.DishesList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n");
#nullable restore
#line 32 "/Users/tural.hasanli/Desktop/Dojo_Assigments/C#/ChefsDishes/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591