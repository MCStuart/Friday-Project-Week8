#pragma checksum "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfc0466f4412b8b44f4ca07820c98e0a2d68ef03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Specialties_Index), @"mvc.1.0.view", @"/Views/Specialties/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Specialties/Index.cshtml", typeof(AspNetCore.Views_Specialties_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc0466f4412b8b44f4ca07820c98e0a2d68ef03", @"/Views/Specialties/Index.cshtml")]
    public class Views_Specialties_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 47, true);
            WriteLiteral("\n<h2>Select a Specialty for details</h2>\n\n<ul>\n");
            EndContext();
#line 5 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Index.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(80, 50, true);
            WriteLiteral("        <p>No specialties have been added yet</p>\n");
            EndContext();
#line 8 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(136, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 9 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Index.cshtml"
     if(Model.Count != 0)
    {
        

#line default
#line hidden
#line 11 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Index.cshtml"
         foreach (var specialty in Model)
        {

#line default
#line hidden
            BeginContext(220, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 234, "\"", 277, 2);
            WriteAttributeValue("", 241, "/specialties/", 241, 13, true);
#line 13 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Index.cshtml"
WriteAttributeValue("", 254, specialty.specialty_id, 254, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(278, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(280, 25, false);
#line 13 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Index.cshtml"
                                                      Write(specialty.specialty_style);

#line default
#line hidden
            EndContext();
            BeginContext(305, 9, true);
            WriteLiteral("</a><br>\n");
            EndContext();
#line 14 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Index.cshtml"
        }

#line default
#line hidden
#line 14 "/Users/mcstuart/Desktop/Friday-Project-Week8/HairSalon/Views/Specialties/Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(330, 212, true);
            WriteLiteral("</ul>\n\n<h1><a href=\"/specialties/new\">Add a new specialty</a></h1>\n<a href=\"/\">Back to homepage</a>\n<form action=\"/specialties/delete\" method=\"post\">\n    <button type=\"submit\">Delete specialties</button>\n</form>\n");
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
