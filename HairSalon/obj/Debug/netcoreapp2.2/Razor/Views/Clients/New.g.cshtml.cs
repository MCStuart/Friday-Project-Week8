#pragma checksum "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Clients/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9651831d0b973e3a0ba018dc599018ff56bdb645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_New), @"mvc.1.0.view", @"/Views/Clients/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/New.cshtml", typeof(AspNetCore.Views_Clients_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9651831d0b973e3a0ba018dc599018ff56bdb645", @"/Views/Clients/New.cshtml")]
    public class Views_Clients_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 24, true);
            WriteLiteral("<h1>Add a new client to ");
            EndContext();
            BeginContext(25, 15, false);
#line 1 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Clients/New.cshtml"
                   Write(Model.GetName());

#line default
#line hidden
            EndContext();
            BeginContext(40, 19, true);
            WriteLiteral("\'s list</h1>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 59, "\'", 100, 3);
            WriteAttributeValue("", 68, "/stylists/", 68, 10, true);
#line 3 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Clients/New.cshtml"
WriteAttributeValue("", 78, Model.GetId(), 78, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 92, "/clients", 92, 8, true);
            EndWriteAttribute();
            BeginContext(101, 70, true);
            WriteLiteral(" method=\'post\'>\n  <input id=\'stylistId\' name=\'stylistId\' type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 171, "\'", 193, 1);
#line 4 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Clients/New.cshtml"
WriteAttributeValue("", 179, Model.GetId(), 179, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(194, 158, true);
            WriteLiteral(">\n  <label for=\'clientName\'>Client Name: </label>\n  <input id=\'clientName\' name=\'clientName\' type=\'text\'>\n  <button type=\'submit\'>Add client</button>\n</form>\n");
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
