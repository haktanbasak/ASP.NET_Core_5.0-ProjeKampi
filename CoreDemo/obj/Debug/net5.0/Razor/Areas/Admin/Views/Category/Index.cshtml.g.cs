#pragma checksum "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed335dbe7c6dbab5504eab8e8d7b6a89ee66f00c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed335dbe7c6dbab5504eab8e8d7b6a89ee66f00c", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e273681fe023035aba1d643f355c88c8bae0c4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kategori Listesi</h1>

<br />

<table class=""table table-bordered table-responsive"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th>Kategori Adı</th>
            <th>Pasif Yap</th>
            <th>Aktif Yap</th>
            <th>Düzenle</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 28 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
                           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 742, "\"", 796, 2);
            WriteAttributeValue("", 749, "/Admin/Category/CategoryDelete/", 749, 31, true);
#nullable restore
#line 31 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 780, item.CategoryID, 780, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""DeleteBtn""
                       onclick=""return confirm('Silmek istediğinizden emin misiniz ?');""
                       class=""btn btn-secondary"">Pasif Yap</a>
                </td>
                <td><a href=""#"" class=""btn btn-primary"">Aktif Yap</a></td>
                <td><a href=""#"" class=""btn btn-success"">Düzenle</a></td>
            </tr>
");
#nullable restore
#line 38 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/Admin/Category/AddCategory\" class=\"btn btn-primary\">Yeni Kategori</a>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 44 "C:\Users\Burak\Documents\GitHub\ASP.NET_Core_5.0-ProjeKampi\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
