#pragma checksum "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopulerDestination\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "872686239afdfc77f775d77828288f765562fde0d32d80d63cdd1fb105822c35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__PopulerDestination_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_PopulerDestination/Default.cshtml")]
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
#line 1 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using DTO.DTOs.ContactUsDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"872686239afdfc77f775d77828288f765562fde0d32d80d63cdd1fb105822c35", @"/Views/Shared/Components/_PopulerDestination/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4a3972d0249d1a0a8a49e858d5130149b1477c78a75332ca208b2a6310121e3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__PopulerDestination_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""w3l-grids-3 py-5"">
    <div class=""container py-md-5"">
        <div class=""title-content text-left mb-lg-5 mb-4"">
            <h6 class=""sub-title"">Seyahatni Planla</h6>
            <h3 class=""hny-title"">Popüler Tur Rotaları</h3>
        </div>
        <div class=""row bottom-ab-grids"">

");
#nullable restore
#line 10 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopulerDestination\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-6 subject-card mt-lg-0 mt-4"">
                    <div class=""subject-card-header p-4"">
                        <a href=""#"" class=""card_title p-lg-4d-block"">
                            <div class=""row align-items-center"">
                                <div class=""col-sm-5 subject-img"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 763, "\"", 799, 2);
            WriteAttributeValue("", 770, "/Destination/Details/", 770, 21, true);
#nullable restore
#line 17 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopulerDestination\Default.cshtml"
WriteAttributeValue("", 791, item.Id, 791, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img");
            BeginWriteAttribute("src", " src=\"", 806, "\"", 823, 1);
#nullable restore
#line 17 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopulerDestination\Default.cshtml"
WriteAttributeValue("", 812, item.Image, 812, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 842, "\"", 848, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height120px;\"></a>\r\n                                </div>\r\n                                <div class=\"col-sm-7 subject-content mt-sm-0 mt-4\">\r\n                                    <h4><a");
            BeginWriteAttribute("href", " href=\"", 1056, "\"", 1092, 2);
            WriteAttributeValue("", 1063, "/Destination/Details/", 1063, 21, true);
#nullable restore
#line 20 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopulerDestination\Default.cshtml"
WriteAttributeValue("", 1084, item.Id, 1084, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopulerDestination\Default.cshtml"
                                                                           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <p>");
#nullable restore
#line 21 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopulerDestination\Default.cshtml"
                                  Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"dst-btm\">\r\n                                        <h6");
            BeginWriteAttribute("class", " class=\"", 1276, "\"", 1284, 0);
            EndWriteAttribute();
            WriteLiteral("> Start From </h6>\r\n                                        <span>$ ");
#nullable restore
#line 24 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopulerDestination\Default.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <p class=\"sub-para\">");
#nullable restore
#line 26 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopulerDestination\Default.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 32 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PopulerDestination\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; } = default!;
        #nullable disable
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
