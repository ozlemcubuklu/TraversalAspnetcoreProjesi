#pragma checksum "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Default\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "462a34ff62e252f422ac6dcdb278cf9231457887d83bde591f9dfef0118c2eee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"462a34ff62e252f422ac6dcdb278cf9231457887d83bde591f9dfef0118c2eee", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4a3972d0249d1a0a8a49e858d5130149b1477c78a75332ca208b2a6310121e3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_SliderPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_PopulerDestination"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_Statistics"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_Feature"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_SubAbout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\OA\Desktop\Projeler\TraversalCoreProje\TraversalCoreProje\Views\Default\Index.cshtml"
Write(await Component.InvokeAsync("_Testimonial"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
