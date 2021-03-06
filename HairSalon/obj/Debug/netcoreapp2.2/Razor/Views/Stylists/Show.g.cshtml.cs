#pragma checksum "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9233d370671ea5aff9fe60b2e8a100c80649b9ed"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9233d370671ea5aff9fe60b2e8a100c80649b9ed", @"/Views/Stylists/Show.cshtml")]
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
            BeginContext(302, 34, true);
            WriteLiteral("</ol>\n\n<h3>Specialties:</h3>\n<ol>\n");
            EndContext();
#line 16 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
   if (Model["stylistSpecialties"].Count == 0)
  {

#line default
#line hidden
            BeginContext(387, 42, true);
            WriteLiteral("    <p>No specialties have been added</p>\n");
            EndContext();
#line 19 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
  }

#line default
#line hidden
            BeginContext(433, 2, true);
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
            BeginContext(550, 12, true);
            WriteLiteral("      <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 562, "\"", 605, 2);
            WriteAttributeValue("", 569, "/specialties/", 569, 13, true);
#line 24 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 582, specialty.specialty_id, 582, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(606, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(608, 25, false);
#line 24 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
                                                    Write(specialty.specialty_style);

#line default
#line hidden
            EndContext();
            BeginContext(633, 10, true);
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
            BeginContext(653, 53, true);
            WriteLiteral("</ol>\n<h3>Add a specialty to this stylist:</h3>\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 706, "\"", 766, 3);
            WriteAttributeValue("", 715, "/stylists/", 715, 10, true);
#line 29 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 725, Model["stylist"].stylist_id, 725, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 753, "/addSpecialty", 753, 13, true);
            EndWriteAttribute();
            BeginContext(767, 97, true);
            WriteLiteral(" method=\"post\" >\n  <select name=\'specialtyId\' type=\'number\'>\n    <option value = 0>None</option>\n");
            EndContext();
#line 32 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
     foreach (var specialty in @Model["specialty"])
    {

#line default
#line hidden
            BeginContext(922, 13, true);
            WriteLiteral("      <option");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 935, "\'", 966, 1);
#line 34 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 943, specialty.specialty_id, 943, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(967, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(969, 25, false);
#line 34 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
                                         Write(specialty.specialty_style);

#line default
#line hidden
            EndContext();
            BeginContext(994, 10, true);
            WriteLiteral("</option>\n");
            EndContext();
#line 35 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
    }

#line default
#line hidden
            BeginContext(1010, 193, true);
            WriteLiteral("  </select>\n  <button type=\"submit\">Add Specialty</button>\n</form>\n\n\n<form action=\"/stylists/{stylistId}/deleteClients\" method=\"Post\">\n  <button type=\"submit\">Delete all clients</button>\n\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1203, "\'", 1260, 3);
            WriteAttributeValue("", 1210, "/stylists/", 1210, 10, true);
#line 44 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Stylists/Show.cshtml"
WriteAttributeValue("", 1220, Model["stylist"].stylist_id, 1220, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1248, "/clients/new", 1248, 12, true);
            EndWriteAttribute();
            BeginContext(1261, 124, true);
            WriteLiteral(">Add a new client</a></p>\n<p><a href=\'/stylists\'>Return to stylist list</a></p>\n\n<p><a href=\'/\'>Return to Main Page</a></p>\n");
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
