#pragma checksum "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb24e032dcb67f376ad6092c055e6c5bea6a3096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Edit), @"mvc.1.0.view", @"/Views/Stylists/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Edit.cshtml", typeof(AspNetCore.Views_Stylists_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb24e032dcb67f376ad6092c055e6c5bea6a3096", @"/Views/Stylists/Edit.cshtml")]
    public class Views_Stylists_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 16, true);
            WriteLiteral("\n<h2><em>Update ");
            EndContext();
            BeginContext(17, 18, false);
#line 2 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Edit.cshtml"
          Write(Model.stylist_name);

#line default
#line hidden
            EndContext();
            BeginContext(35, 32, true);
            WriteLiteral("\'s information:</em></h2>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 67, "\'", 108, 3);
            WriteAttributeValue("", 76, "/stylists/", 76, 10, true);
#line 4 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Edit.cshtml"
WriteAttributeValue("", 86, Model.stylist_id, 86, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 103, "/edit", 103, 5, true);
            EndWriteAttribute();
            BeginContext(109, 125, true);
            WriteLiteral(" method=\'post\'>\n    <label for=\"stylistName\">Stylist name:</label>\n    <input id=\"stylistName\" name=\"stylistName\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 234, "\"", 261, 1);
#line 6 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Edit.cshtml"
WriteAttributeValue("", 242, Model.stylist_name, 242, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(262, 61, true);
            WriteLiteral(">\n    <button type=\'submit\'>Save Changes</button>\n</form>\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 323, "\"", 357, 2);
            WriteAttributeValue("", 330, "/stylists/", 330, 10, true);
#line 10 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Edit.cshtml"
WriteAttributeValue("", 340, Model.stylist_id, 340, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(358, 121, true);
            WriteLiteral(">Return to Stylist</a>\n<a href=\"/stylists\">Return to list of all Stylists</a>\n<a href=\"/\">Return to homepage</a><br><br>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
