#pragma checksum "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64364b90a1f341e426122d8152a72af695348c66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Show), @"mvc.1.0.view", @"/Views/Stylists/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Show.cshtml", typeof(AspNetCore.Views_Stylists_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64364b90a1f341e426122d8152a72af695348c66", @"/Views/Stylists/Show.cshtml")]
    public class Views_Stylists_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 57, true);
            WriteLiteral("<h3>Here are all the clients of this Stylist:</h3>\n\n<ol>\n");
            EndContext();
#line 4 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
   if (Model["client"].Count == 0)
  {

#line default
#line hidden
            BeginContext(96, 38, true);
            WriteLiteral("    <p>No clients have been added</p>\n");
            EndContext();
#line 7 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
  }

#line default
#line hidden
            BeginContext(138, 2, true);
            WriteLiteral("  ");
            EndContext();
#line 8 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
   foreach (var client in @Model["client"])
  {

#line default
#line hidden
            BeginContext(186, 10, true);
            WriteLiteral("    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 196, "\'", 267, 4);
            WriteAttributeValue("", 203, "/stylists/", 203, 10, true);
#line 10 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 213, Model["stylist"].stylist_id, 213, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 241, "/clients/", 241, 9, true);
#line 10 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 250, client.client_id, 250, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(268, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(270, 18, false);
#line 10 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
                                                                              Write(client.client_name);

#line default
#line hidden
            EndContext();
            BeginContext(288, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 11 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
  }

#line default
#line hidden
            BeginContext(302, 11, true);
            WriteLiteral("</ol>\n\n<h3>");
            EndContext();
            BeginContext(314, 29, false);
#line 14 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
Write(Model["stylist"].stylist_name);

#line default
#line hidden
            EndContext();
            BeginContext(343, 26, true);
            WriteLiteral("\'s Specialties:</h3>\n<ol>\n");
            EndContext();
#line 16 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
   if (Model["stylistSpecialties"].Count == 0)
  {

#line default
#line hidden
            BeginContext(420, 42, true);
            WriteLiteral("    <p>No specialties have been added</p>\n");
            EndContext();
#line 19 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
  }

#line default
#line hidden
            BeginContext(466, 2, true);
            WriteLiteral("  ");
            EndContext();
#line 20 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
   if (Model["stylistSpecialties"].Count != 0)
  {
    

#line default
#line hidden
#line 22 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
     foreach (var specialty in Model["stylistSpecialties"])
    {

#line default
#line hidden
            BeginContext(583, 12, true);
            WriteLiteral("      <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 595, "\"", 638, 2);
            WriteAttributeValue("", 602, "/specialties/", 602, 13, true);
#line 24 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 615, specialty.specialty_id, 615, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(639, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(641, 25, false);
#line 24 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
                                                    Write(specialty.specialty_style);

#line default
#line hidden
            EndContext();
            BeginContext(666, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 25 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
    }

#line default
#line hidden
#line 25 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
     
  }

#line default
#line hidden
            BeginContext(686, 53, true);
            WriteLiteral("</ol>\n<h3>Add a specialty to this stylist:</h3>\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 739, "\"", 799, 3);
            WriteAttributeValue("", 748, "/stylists/", 748, 10, true);
#line 29 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 758, Model["stylist"].stylist_id, 758, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 786, "/addSpecialty", 786, 13, true);
            EndWriteAttribute();
            BeginContext(800, 96, true);
            WriteLiteral(" method=\"post\" >\n  <select name=\'stylist_id\' type=\'number\'>\n    <option value = 0>None</option>\n");
            EndContext();
#line 32 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
     foreach (var specialty in @Model["specialty"])
    {

#line default
#line hidden
            BeginContext(954, 13, true);
            WriteLiteral("      <option");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 967, "\'", 998, 1);
#line 34 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 975, specialty.specialty_id, 975, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(999, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1001, 25, false);
#line 34 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
                                         Write(specialty.specialty_style);

#line default
#line hidden
            EndContext();
            BeginContext(1026, 10, true);
            WriteLiteral("</option>\n");
            EndContext();
#line 35 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
    }

#line default
#line hidden
            BeginContext(1042, 73, true);
            WriteLiteral("  </select>\n  <button type=\"submit\">Add Specialty</button>\n</form>\n\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1115, "\'", 1172, 3);
            WriteAttributeValue("", 1122, "/stylists/", 1122, 10, true);
#line 40 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 1132, Model["stylist"].stylist_id, 1132, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1160, "/clients/new", 1160, 12, true);
            EndWriteAttribute();
            BeginContext(1173, 123, true);
            WriteLiteral(">Add a new client</a></p>\n<p><a href=\'/stylists\'>Return to stylist list</a></p>\n<p><a href=\'/\'>Return to Main Page</a></p>\n");
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
