#pragma checksum "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20fe3993e01d7269390c3343327d1b3875b3cf3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Charity.WebApp.Pages.Pages_EventsVedios), @"mvc.1.0.razor-page", @"/Pages/EventsVedios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EventsVedios.cshtml", typeof(Charity.WebApp.Pages.Pages_EventsVedios), null)]
namespace Charity.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\_ViewImports.cshtml"
using Charity.WebApp;

#line default
#line hidden
#line 5 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
using Charity.WebApp.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20fe3993e01d7269390c3343327d1b3875b3cf3d", @"/Pages/EventsVedios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aface1c96bf45ef50cc5de419f76ca209de9af5f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EventsVedios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(132, 329, true);
            WriteLiteral(@"<!-- Page Banner Section -->
<section class=""page-banner"">
    <div class=""image-layer lazy-image"" data-bg=""url('images/background/bg-banner-1.jpg')""></div>
    <div class=""bottom-rotten-curve""></div>

    <div class=""auto-container"">
        <h1>Our Events</h1>
        <ul class=""bread-crumb clearfix"">
            <li>");
            EndContext();
            BeginContext(461, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20fe3993e01d7269390c3343327d1b3875b3cf3d3917", async() => {
                BeginContext(482, 46, false);
#line 15 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
                               Write(SharedLocalizer.GetLocalizedHtmlString("Home"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(532, 38, true);
            WriteLiteral("</li>\r\n            <li class=\"active\">");
            EndContext();
            BeginContext(571, 48, false);
#line 16 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Events"));

#line default
#line hidden
            EndContext();
            BeginContext(619, 207, true);
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n\r\n</section>\r\n<!--End Banner Section -->\r\n<!--Events Section-->\r\n<section class=\"events-section\">\r\n    <div class=\"auto-container\">\r\n\r\n        <div class=\"row clearfix\">\r\n\r\n");
            EndContext();
#line 28 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
             foreach (var item in Model.vedioResult)
            {

#line default
#line hidden
            BeginContext(895, 400, true);
            WriteLiteral(@"                <!--Event Block-->
                <div class=""event-block-three col-lg-4 col-md-6 col-sm-12"">

                    <div class=""inner-box wow fadeInUp"" data-wow-delay=""0ms"">
                        <div class=""image-box"">
                            <figure class=""image"">
                                <a>
                                    <iframe height=""250"" width=""400""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1295, "\"", 1310, 1);
#line 37 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
WriteAttributeValue("", 1301, item.URL, 1301, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1311, 313, true);
            WriteLiteral(@" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
                                </a>
                            </figure>
                            <div class=""date""><span class=""month"">");
            EndContext();
            BeginContext(1625, 9, false);
#line 40 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
                                                             Write(item.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1634, 232, true);
            WriteLiteral("</span></div>\r\n                        </div>\r\n                        <div class=\"lower-content\">\r\n                            <ul class=\"info clearfix\">\r\n                                <li><span class=\"icon far fa-clock\"></span> ");
            EndContext();
            BeginContext(1867, 14, false);
#line 44 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
                                                                       Write(item.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1881, 126, true);
            WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 49 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
            }

#line default
#line hidden
            BeginContext(2022, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
             if (Model.vedioResult.Count == 0)
            {

#line default
#line hidden
            BeginContext(2087, 101, true);
            WriteLiteral("                <div class=\"event-block-three col-lg-12 col-md-6 col-sm-12\">\r\n                    <p>");
            EndContext();
            BeginContext(2189, 48, false);
#line 54 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
                  Write(SharedLocalizer.GetLocalizedHtmlString("NoData"));

#line default
#line hidden
            EndContext();
            BeginContext(2237, 30, true);
            WriteLiteral("</p>\r\n                </div>\r\n");
            EndContext();
#line 56 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\EventsVedios.cshtml"
            }

#line default
#line hidden
            BeginContext(2282, 42, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</section>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Charity.WebApp.Pages.EventsVediosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Charity.WebApp.Pages.EventsVediosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Charity.WebApp.Pages.EventsVediosModel>)PageContext?.ViewData;
        public Charity.WebApp.Pages.EventsVediosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
