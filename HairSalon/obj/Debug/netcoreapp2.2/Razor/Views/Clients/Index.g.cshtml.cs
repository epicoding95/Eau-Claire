#pragma checksum "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0167e166805dacca869988828a63c195653fc11b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Index.cshtml", typeof(AspNetCore.Views_Clients_Index))]
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
#line 6 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0167e166805dacca869988828a63c195653fc11b", @"/Views/Clients/Index.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HairSalon.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(92, 27, true);
            WriteLiteral("\n    <h1>Restaurants</h1>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Index.cshtml"
     if (@Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(153, 52, true);
            WriteLiteral("        <h3>No Restaurants have been added yet</h3>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(211, 9, true);
            WriteLiteral("\n    <ul>");
            EndContext();
#line 16 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Index.cshtml"
         foreach(Client client in Model)
        {

#line default
#line hidden
            BeginContext(263, 17, true);
            WriteLiteral("            <li> ");
            EndContext();
            BeginContext(281, 72, false);
#line 18 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Index.cshtml"
            Write(Html.ActionLink($"{client.Name}", "Details", new {id = client.ClientId}));

#line default
#line hidden
            EndContext();
            BeginContext(353, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(369, 15, true);
            WriteLiteral("    </ul>\n\n<p> ");
            EndContext();
            BeginContext(385, 43, false);
#line 22 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Index.cshtml"
Write(Html.ActionLink("Add new Client", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(428, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(437, 40, false);
#line 23 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Clients/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(477, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HairSalon.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
