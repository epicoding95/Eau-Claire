#pragma checksum "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f74a54a423e30965e5e95c48e9b86607ed82c25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Edit), @"mvc.1.0.view", @"/Views/Clients/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Edit.cshtml", typeof(AspNetCore.Views_Clients_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f74a54a423e30965e5e95c48e9b86607ed82c25", @"/Views/Clients/Edit.cshtml")]
    public class Views_Clients_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 20, true);
            WriteLiteral("\n<h3>edit the list: ");
            EndContext();
            BeginContext(81, 36, false);
#line 8 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Edit.cshtml"
              Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(117, 7, true);
            WriteLiteral("</h3>\n\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(157, 39, false);
#line 12 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.HiddenFor(model => model.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(203, 34, false);
#line 14 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(244, 35, false);
#line 15 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(285, 44, true);
            WriteLiteral("     <input type =\"submit\" value =\"Save\" />\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Edit.cshtml"

}

#line default
#line hidden
            BeginContext(332, 5, true);
            WriteLiteral("\n<p> ");
            EndContext();
            BeginContext(338, 40, false);
#line 22 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(378, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
