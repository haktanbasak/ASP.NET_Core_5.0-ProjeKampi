#pragma checksum "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Writer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41a6b2bf980844ffd5e82eb1793830998e9b9687"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_Index), @"mvc.1.0.view", @"/Views/Writer/Index.cshtml")]
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
#line 1 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41a6b2bf980844ffd5e82eb1793830998e9b9687", @"/Views/Writer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e273681fe023035aba1d643f355c88c8bae0c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Writer\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Burası Layout alanı</h1>\r\n\r\n<h2>");
#nullable restore
#line 7 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Writer\Index.cshtml"
Write(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h2>");
#nullable restore
#line 9 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Writer\Index.cshtml"
Write(ViewBag.mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h3>Hoşgeldiniz ");
#nullable restore
#line 11 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Views\Writer\Index.cshtml"
           Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
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
