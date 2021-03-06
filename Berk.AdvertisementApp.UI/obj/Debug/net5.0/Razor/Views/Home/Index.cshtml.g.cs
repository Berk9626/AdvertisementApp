#pragma checksum "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5c34754a1a2787685e6ebf9ba7bf5806668e0fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using Berk.AdvertisementApp.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using Berk.AdvertisementApp.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using Berk.Advertisement.Common.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c34754a1a2787685e6ebf9ba7bf5806668e0fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"944f43038af7de6a22dcaba52c837e151792bb30", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProvideServiceListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\Index.cshtml"
  
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Content section 1-->\r\n");
            WriteLiteral(@"
<!-- Header-->
<header class=""masthead text-center text-white"">
	<div class=""masthead-content"">
		<div class=""container px-5"">
			<h1 class=""masthead-heading mb-0"">Berk Bili??im</h1>
			<h2 class=""masthead-subheading mb-0"">Masa??st?? Web ve Mobil Uygulamalar</h2>
			<a class=""btn btn-primary btn-xl rounded-pill mt-5"" href=""#scroll"">Daha fazla</a>
		</div>
	</div>
	<div class=""bg-circle-1 bg-circle""></div>
	<div class=""bg-circle-2 bg-circle""></div>
	<div class=""bg-circle-3 bg-circle""></div>
	<div class=""bg-circle-4 bg-circle""></div>
</header>

");
#nullable restore
#line 25 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\Index.cshtml"
 for (int i = 0; i < Model?.Count; i++)//modelim bo?? de??ilse count??n?? al,count?? kadar d??n
{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t<section id=\"scroll\">\r\n\t\t<div class=\"container px-5\">\r\n\t\t\t<div class=\"row gx-5 align-items-center\">\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 976, "\"", 1027, 3);
            WriteAttributeValue("", 984, "col-lg-6", 984, 8, true);
#nullable restore
#line 31 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 992, i % 2 == 0 ? "order-lg-2" : "", 993, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1026, "", 1027, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("\t\t\t\t\t<div class=\"p-5\">\r\n\t\t\t\t\t\t<img class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 1210, "\"", 1235, 1);
#nullable restore
#line 34 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1216, Model[i].ImagePath, 1216, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1274, "\"", 1316, 2);
            WriteAttributeValue("", 1282, "col-lg-6", 1282, 8, true);
#nullable restore
#line 37 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1290, i%2==0?"order-lg-1":"", 1291, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t<div class=\"p-5\">\r\n\t\t\t\t\t\t<h2 class=\"display-4\">");
#nullable restore
#line 39 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\Index.cshtml"
                                         Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t\t\t\t\t<p>");
#nullable restore
#line 40 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\Index.cshtml"
                      Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n");
#nullable restore
#line 46 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProvideServiceListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
