#pragma checksum "F:\Fast\bakend\Lessons\FastMechanism\Pages\Employees\programs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef75b270f4e046ed3f1ca83cdc37802910320d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FastMechanism.Pages.Employees.Pages_Employees_programs), @"mvc.1.0.razor-page", @"/Pages/Employees/programs.cshtml")]
namespace FastMechanism.Pages.Employees
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
#line 1 "F:\Fast\bakend\Lessons\FastMechanism\Pages\_ViewImports.cshtml"
using FastMechanism;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef75b270f4e046ed3f1ca83cdc37802910320d6", @"/Pages/Employees/programs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5687bbacf46bd65e4e06cabb8c7a80ba781da6e0", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Employees_programs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Fast\bakend\Lessons\FastMechanism\Pages\Employees\programs.cshtml"
  
    ViewData["Title"] = "Programs";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""blurAuto"">
    <div class=""container"">
            <div class=""program_description""></div>
            <div class=""program_selected""></div>
            <div>
                <div class=""name_program"" id=""txt-program-name"">Name</div>
                <a");
            BeginWriteAttribute("href", " href=\"", 369, "\"", 376, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""btn-program-buy"" class=""dowload_program"">Download Now</a>
            </div>
            <img class=""item_program"" 
                    data-program-name=""text 1""
                    data-program-link=""/game1""
                    src=""https://placekitten.com/300/200""
                    data-program-big-img=""https://placekitten.com/300/200""/>
            <img class=""item_program"" 
                    data-program-name=""text 2""
                    data-program-link=""/game2""
                    src=""https://placekitten.com/300/200""
                    data-program-big-img=""https://placekitten.com/300/200""/>
            <img class=""item_program"" 
                    data-program-name=""text 3""
                    data-program-link=""/game3""
                    src=""https://placekitten.com/300/200""
                    data-program-big-img=""https://placekitten.com/300/200""/>
            <img class=""item_program down_item_program"" 
                    data-program-name=""text 4""
               ");
            WriteLiteral(@"     data-program-link=""/game4""
                    src=""https://placekitten.com/300/200""
                    data-program-big-img=""https://placekitten.com/300/200""/>
            <img class=""item_program down_item_program"" 
                    data-program-name=""text 5""
                    data-program-link=""/game5""
                    src=""https://placekitten.com/300/200""
                    data-program-big-img=""https://placekitten.com/300/200""/>
            <img class=""item_program down_item_program"" 
                    data-program-name=""text 6""
                    data-program-link=""/game6""
                    src=""https://placekitten.com/300/200""
                    data-program-big-img=""https://placekitten.com/300/200""/>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RezorPages.Pages.Employees.programsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RezorPages.Pages.Employees.programsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RezorPages.Pages.Employees.programsModel>)PageContext?.ViewData;
        public RezorPages.Pages.Employees.programsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
