#pragma checksum "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77c99b5c7c2cd8281a4525be2fbafb0888c0ad7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HumanResource), @"mvc.1.0.view", @"/Views/Home/HumanResource.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c99b5c7c2cd8281a4525be2fbafb0888c0ad7a", @"/Views/Home/HumanResource.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"944f43038af7de6a22dcaba52c837e151792bb30", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HumanResource : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdvertisementListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Advertisement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Send", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
   
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"dummy mt-5\">\r\n\r\n</div>\r\n\r\n<div class=\"container my-3\">\r\n\r\n\t<div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 14 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
         for (int i = 0; i < Model?.Count; i++)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"accordion-item\">\r\n\t\t\t<h2 class=\"accordion-header\"");
            BeginWriteAttribute("id", " id=\"", 320, "\"", 345, 2);
            WriteAttributeValue("", 325, "heading-", 325, 8, true);
#nullable restore
#line 17 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 333, Model[i].Id, 333, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t<button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapse-");
#nullable restore
#line 18 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                                                                                                              Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("aria-expanded", " aria-expanded=\"", 465, "\"", 488, 1);
#nullable restore
#line 18 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 481, i==0, 481, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 489, "\"", 526, 2);
            WriteAttributeValue("", 505, "collapse-", 505, 9, true);
#nullable restore
#line 18 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 514, Model[i].Id, 514, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t");
#nullable restore
#line 19 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
               Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</button>");
            WriteLiteral("\t\t\t</h2>\r\n\t\t\t<div");
            BeginWriteAttribute("id", " id=\"", 707, "\"", 733, 2);
            WriteAttributeValue("", 712, "collapse-", 712, 9, true);
#nullable restore
#line 22 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 721, Model[i].Id, 721, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 734, "\"", 787, 3);
            WriteAttributeValue("", 742, "accordion-collapse", 742, 18, true);
            WriteAttributeValue(" ", 760, "collapse", 761, 9, true);
#nullable restore
#line 22 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue(" ", 769, i==0?"show":"", 770, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 788, "\"", 826, 2);
            WriteAttributeValue("", 806, "heading-", 806, 8, true);
#nullable restore
#line 22 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 814, Model[i].Id, 814, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-parent=\"#accordionExample\">\r\n\t\t\t\t<div class=\"accordion-body\">\r\n\t\t\t\t\t");
#nullable restore
#line 24 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
               Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t<div>\r\n");
#nullable restore
#line 27 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                         if (User.Identity.IsAuthenticated) //bana burda ilgili userın Id'si lazım
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77c99b5c7c2cd8281a4525be2fbafb0888c0ad7a9627", async() => {
                WriteLiteral("Başvur");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-advertisementId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                                                                                               WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["advertisementId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-advertisementId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["advertisementId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"alert alert-light text-center\">\r\n\t\t\t\t\t\t\t\tBaşvuru yapabilmeniz için giriş yapmanız gerekmektedir ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77c99b5c7c2cd8281a4525be2fbafb0888c0ad7a12504", async() => {
                WriteLiteral("Giriş Yap");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 36 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 42 "C:\Users\berkb\source\repos\Berk.AdvertisementApp\Berk.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"

	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AdvertisementListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
