#pragma checksum "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "32446a12e6c47638e10b1b908388167304d1e3e9495501879629077cce41c3fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTO.DTOs.AnnoucementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Queries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"32446a12e6c47638e10b1b908388167304d1e3e9495501879629077cce41c3fa", @"/Areas/Admin/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3a597013130e5e19c93c2844e3ec178ebb9c996931c09001c6e4b1b76508bd95", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayaut.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Tur Rotaları</h3>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Şehir</th>
        <th>Fiyat</th>
        <th>Kapasite</th>
        <th>Sitede Gör</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>

");
#nullable restore
#line 20 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>#</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Capasity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 599, "\"", 641, 2);
            WriteAttributeValue("", 606, "/admin/Destination/Details/", 606, 27, true);
#nullable restore
#line 28 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 633, item.Id, 633, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Sitede Gör</a>\r\n               </td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 729, "\"", 781, 2);
            WriteAttributeValue("", 736, "/admin/Destination/DeleteDestination/", 736, 37, true);
#nullable restore
#line 30 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 773, item.Id, 773, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 847, "\"", 899, 2);
            WriteAttributeValue("", 854, "/admin/destination/updatedestination/", 854, 37, true);
#nullable restore
#line 31 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 891, item.Id, 891, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/admin/destination/adddestination/\" class=\"btn btn-outline-primary\">Yeni Tur Rotası</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
