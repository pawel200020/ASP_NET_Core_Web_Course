#pragma checksum "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08a09dd0dca1b7579423250d115e06937fc946d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__productCard), @"mvc.1.0.view", @"/Views/Product/_productCard.cshtml")]
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
#line 1 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\_ViewImports.cshtml"
using ASP_NET_Core_Web_Development_course;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\_ViewImports.cshtml"
using ASP_NET_Core_Web_Development_course.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08a09dd0dca1b7579423250d115e06937fc946d9", @"/Views/Product/_productCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41526fce979072ce677f99ed0fd41a4b75a6d046", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__productCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_NET_Core_Web_Development_course.Models.ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
  
    var s = Model.Name;
    var firstWord = s.IndexOf(" ") > -1 ? s.Substring(0, s.IndexOf(" ")) : s;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 229, "\"", 294, 4);
            WriteAttributeValue("", 235, "https://loremflickr.com/g/150/150/", 235, 34, true);
#nullable restore
#line 9 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 269, firstWord, 269, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 279, "?lock=", 279, 6, true);
#nullable restore
#line 9 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 285, Model.Id, 285, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 316, "\"", 333, 1);
#nullable restore
#line 9 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 322, Model.Name, 322, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 11 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 12 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
                        Write(Html.DisplayFor(m => Model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">");
#nullable restore
#line 13 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 547, "\"", 584, 2);
            WriteAttributeValue("", 554, "/Product/ShowDetails/", 554, 21, true);
#nullable restore
#line 14 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 575, Model.Id, 575, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Show details</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 638, "\"", 668, 2);
            WriteAttributeValue("", 645, "/Product/Edit/", 645, 14, true);
#nullable restore
#line 15 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 659, Model.Id, 659, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 714, "\"", 746, 2);
            WriteAttributeValue("", 721, "/Product/Delete/", 721, 16, true);
#nullable restore
#line 16 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 737, Model.Id, 737, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n        <!-- Button trigger modal -->\r\n        <button");
            BeginWriteAttribute("value", " value=\"", 837, "\"", 854, 1);
#nullable restore
#line 18 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 845, Model.Id, 845, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-primary edit-product-button\" data-toggle=\"modal\" data-target=\"#editModal\">\r\n            Modal edit\r\n        </button>\r\n        <button");
            BeginWriteAttribute("value", " value=\"", 1019, "\"", 1036, 1);
#nullable restore
#line 21 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Product\_productCard.cshtml"
WriteAttributeValue("", 1027, Model.Id, 1027, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-primary details-product-button\" data-toggle=\"modal\" data-target=\"#detailsModal\">\r\n            Moodal details\r\n        </button>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_NET_Core_Web_Development_course.Models.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591