#pragma checksum "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Products\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0498bd6a5c8e9a43bff14800190c1f1e0d78c68b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Welcome), @"mvc.1.0.view", @"/Views/Products/Welcome.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0498bd6a5c8e9a43bff14800190c1f1e0d78c68b", @"/Views/Products/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41526fce979072ce677f99ed0fd41a4b75a6d046", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h2> Welcome ");
#nullable restore
#line 5 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Products\Welcome.cshtml"
        Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p> the secret nubmer is: ");
#nullable restore
#line 6 "D:\Code\Web_Dev\ASP_NET_Core_Web_Development\Basic_Products_APP\Views\Products\Welcome.cshtml"
                     Write(ViewBag.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
