#pragma checksum "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb2ac5e8e562fdb40b2aba004687a8e12bcd4ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Specialties_Show), @"mvc.1.0.view", @"/Views/Specialties/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Specialties/Show.cshtml", typeof(AspNetCore.Views_Specialties_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb2ac5e8e562fdb40b2aba004687a8e12bcd4ec9", @"/Views/Specialties/Show.cshtml")]
    public class Views_Specialties_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6, true);
            WriteLiteral("\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 6, "\"", 67, 3);
            WriteAttributeValue("", 15, "/specialties/", 15, 13, true);
#line 2 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
WriteAttributeValue("", 28, Model["specialty"].specialty_id, 28, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 60, "/delete", 60, 7, true);
            EndWriteAttribute();
            BeginContext(68, 121, true);
            WriteLiteral(" method=\"post\">\n    <button type=\"submit\">Delete Specialty</button>\n    <h1>Stylists with this specialization: </h1><br>\n");
            EndContext();
#line 5 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
     if (Model["stylistSpecialties"].Count != 0)
    {
        

#line default
#line hidden
#line 7 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
         foreach (var stylist in Model["stylistSpecialties"])
        {

#line default
#line hidden
            BeginContext(316, 18, true);
            WriteLiteral("            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 334, "\"", 370, 2);
            WriteAttributeValue("", 341, "/stylists/", 341, 10, true);
#line 9 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
WriteAttributeValue("", 351, stylist.stylist_id, 351, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(371, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(373, 20, false);
#line 9 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
                                                   Write(stylist.stylist_name);

#line default
#line hidden
            EndContext();
            BeginContext(393, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 10 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
        }

#line default
#line hidden
#line 10 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
         
    }

#line default
#line hidden
            BeginContext(419, 53, true);
            WriteLiteral("</ol>\n<h2>Add a stylist to this specialty:</h2>\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 472, "\"", 537, 3);
            WriteAttributeValue("", 481, "/specialties/", 481, 13, true);
#line 14 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
WriteAttributeValue("", 494, Model["specialty"].specialty_id, 494, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 526, "/addStylist", 526, 11, true);
            EndWriteAttribute();
            BeginContext(538, 94, true);
            WriteLiteral(" method=\"post\" >\n    <select name=\'id\' type=\'number\'>\n        <option value = 0>None</option>\n");
            EndContext();
#line 17 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
         foreach (var stylist in @Model["stylists"])
        {

#line default
#line hidden
            BeginContext(695, 19, true);
            WriteLiteral("            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 714, "\'", 741, 1);
#line 19 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
WriteAttributeValue("", 722, stylist.stylist_id, 722, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(742, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(744, 20, false);
#line 19 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
                                           Write(stylist.stylist_name);

#line default
#line hidden
            EndContext();
            BeginContext(764, 10, true);
            WriteLiteral("</option>\n");
            EndContext();
#line 20 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Show.cshtml"
        }

#line default
#line hidden
            BeginContext(784, 218, true);
            WriteLiteral("    </select>\n    <button type=\"submit\">Add Stylist</button>\n</form>\n\n<a href=\"/specialties/Model[\"specialty\"].specialty_id/edit\">Edit Specialty Information</a>\n<a href=\"/specialties\">Return to list of Specialties</a>\n");
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
