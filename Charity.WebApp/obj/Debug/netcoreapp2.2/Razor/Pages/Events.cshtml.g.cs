#pragma checksum "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09e15a1117ebbb7d0bd1760f2421d675f1252abd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Charity.WebApp.Pages.Pages_Events), @"mvc.1.0.razor-page", @"/Pages/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Events.cshtml", typeof(Charity.WebApp.Pages.Pages_Events), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e15a1117ebbb7d0bd1760f2421d675f1252abd", @"/Pages/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aface1c96bf45ef50cc5de419f76ca209de9af5f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Events : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(55, 329, true);
            WriteLiteral(@"<!-- Page Banner Section -->
<section class=""page-banner"">
    <div class=""image-layer lazy-image"" data-bg=""url('images/background/bg-banner-1.jpg')""></div>
    <div class=""bottom-rotten-curve""></div>

    <div class=""auto-container"">
        <h1>Our Events</h1>
        <ul class=""bread-crumb clearfix"">
            <li>");
            EndContext();
            BeginContext(384, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e15a1117ebbb7d0bd1760f2421d675f1252abd3704", async() => {
                BeginContext(404, 4, true);
                WriteLiteral("Home");
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
            BeginContext(412, 255, true);
            WriteLiteral("</li>\r\n            <li class=\"active\">Our Events</li>\r\n        </ul>\r\n    </div>\r\n\r\n</section>\r\n<!--End Banner Section -->\r\n<!--Events Section-->\r\n<section class=\"events-section\">\r\n    <div class=\"auto-container\">\r\n\r\n        <div class=\"row clearfix\">\r\n\r\n");
            EndContext();
#line 26 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Events.cshtml"
             foreach (var item in Model.result)
            {

#line default
#line hidden
            BeginContext(731, 319, true);
            WriteLiteral(@"                <!--Event Block-->
                <div class=""event-block-three col-lg-4 col-md-6 col-sm-12"">

                    <div class=""inner-box wow fadeInUp"" data-wow-delay=""0ms"">
                        <div class=""image-box"">
                            <figure class=""image""><a><img class=""lazy-image""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1050, "\"", 1089, 2);
            WriteAttributeValue("", 1056, "data:image/png;base64,", 1056, 22, true);
#line 33 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Events.cshtml"
WriteAttributeValue("", 1078, item.Image, 1078, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1090, 116, true);
            WriteLiteral(" alt=\"images\" style=\"height:150px\"></a></figure>\r\n                            <div class=\"date\"><span class=\"month\">");
            EndContext();
            BeginContext(1207, 9, false);
#line 34 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Events.cshtml"
                                                             Write(item.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1216, 135, true);
            WriteLiteral("</span></div>\r\n                        </div>\r\n                        <div class=\"lower-content\">\r\n                            <h3><a>");
            EndContext();
            BeginContext(1352, 16, false);
#line 37 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Events.cshtml"
                              Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1368, 148, true);
            WriteLiteral(" <br></a></h3>\r\n                            <ul class=\"info clearfix\">\r\n                                <li><span class=\"icon far fa-clock\"></span> ");
            EndContext();
            BeginContext(1517, 14, false);
#line 39 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Events.cshtml"
                                                                       Write(item.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1531, 126, true);
            WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 44 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Events.cshtml"
            }

#line default
#line hidden
            BeginContext(1672, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 45 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Events.cshtml"
             if (Model.result.Count == 0)
            {

#line default
#line hidden
            BeginContext(1730, 157, true);
            WriteLiteral("                <div class=\"event-block-three col-lg-12 col-md-6 col-sm-12\">\r\n                    <p>No Data To Be Shown.......</p>\r\n                </div>\r\n");
            EndContext();
#line 50 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Events.cshtml"
            }

#line default
#line hidden
            BeginContext(1902, 56, true);
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Charity.WebApp.Pages.EventsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Charity.WebApp.Pages.EventsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Charity.WebApp.Pages.EventsModel>)PageContext?.ViewData;
        public Charity.WebApp.Pages.EventsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
