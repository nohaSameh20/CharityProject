#pragma checksum "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b391913639633c31c487060d0de58dfd114f0c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Charity.WebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Charity.WebApp.Pages.Pages_Index), null)]
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
#line 1 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\_ViewImports.cshtml"
using Charity.WebApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b391913639633c31c487060d0de58dfd114f0c7f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aface1c96bf45ef50cc5de419f76ca209de9af5f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Donate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("theme-btn btn-style-one"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("theme-btn btn-style-three"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EventsVedios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 1543, true);
            WriteLiteral(@"
<style>
    .overlay {
        position: absolute;
        top: 0;
        bottom: 0;
        left: 33px;
        right: 0;
        opacity: 0;
        transition: .5s ease-in-out;
        background-color: #69d5a9;
        width: 222px;
        height: 201px;
    }

    .container:hover .overlay {
        opacity: 1;
    }

    .text {
        color: white;
        font-size: 20px;
        position: absolute;
        top: 50%;
        left: 50%;
        -webkit-transform: translate(-50%, -50%);
        -ms-transform: translate(-50%, -50%);
        transform: translate(-50%, -50%);
        text-align: center;
    }
    button:after {
        background:none
    }

    #title:after, #title:before {
        background-color: #189849;
        content: """";
        display: inline-block;
        height: 3px;
        position: relative;
        vertical-align: middle;
        width: 22%;
        margin: 16px
    }
  /*  .banner-section .owl-theme .owl-nav .owl-prev:after");
            WriteLiteral(@" {
        left:50%
    }
    .banner-section .owl-theme .owl-nav .owl-prev {
        left: -170px;
    }*/
  
</style>
<!-- Banner Section -->
<section class=""banner-section"">
    <div class=""banner-carousel love-carousel owl-theme owl-carousel"" data-options='{""loop"": true, ""margin"": 0, ""autoheight"":true, ""lazyload"":true, ""nav"": true, ""dots"": true, ""autoplay"": true, ""autoplayTimeout"": 6000, ""smartSpeed"": 300, ""responsive"":{ ""0"" :{ ""items"": ""1"" }, ""768"" :{ ""items"" : ""1"" } , ""1000"":{ ""items"" : ""1"" }}}'>
");
            EndContext();
            BeginContext(1640, 319, true);
            WriteLiteral(@"        <div class=""slide-item"">

            <div class=""image-layer lazy-image"" data-bg=""url('images/main-slider/1.jpg')""></div>

            <div class=""auto-container"">
                <div class=""content-box"">
                    <h2>You Can Help  <br>The Poor</h2>
                    <div class=""btn-box"">");
            EndContext();
            BeginContext(1959, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b391913639633c31c487060d0de58dfd114f0c7f6860", async() => {
                BeginContext(2013, 41, true);
                WriteLiteral("<span class=\"btn-title\">Donate Now</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2058, 70, true);
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            EndContext();
            BeginContext(2154, 317, true);
            WriteLiteral(@"        <div class=""slide-item"">
            <div class=""image-layer lazy-image"" data-bg=""url('images/main-slider/2.jpg')""></div>

            <div class=""auto-container"">
                <div class=""content-box"">
                    <h2>You Can Help  <br>The Poor</h2>
                    <div class=""btn-box"">");
            EndContext();
            BeginContext(2471, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b391913639633c31c487060d0de58dfd114f0c7f8860", async() => {
                BeginContext(2525, 41, true);
                WriteLiteral("<span class=\"btn-title\">Donate Now</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2570, 70, true);
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            EndContext();
            BeginContext(2666, 317, true);
            WriteLiteral(@"        <div class=""slide-item"">
            <div class=""image-layer lazy-image"" data-bg=""url('images/main-slider/3.jpg')""></div>

            <div class=""auto-container"">
                <div class=""content-box"">
                    <h2>You Can Help  <br>The Poor</h2>
                    <div class=""btn-box"">");
            EndContext();
            BeginContext(2983, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b391913639633c31c487060d0de58dfd114f0c7f10860", async() => {
                BeginContext(3037, 41, true);
                WriteLiteral("<span class=\"btn-title\">Donate Now</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3082, 764, true);
            WriteLiteral(@"</div>
                </div>
            </div>
        </div>

    </div>
</section>



<!--End Banner Section -->


<!--Media Section-->
<section class=""about-section"">
    <div class=""top-rotten-curve""></div>
    <div class=""bottom-rotten-curve""></div>
    <div class=""circle-one""></div>
    <div class=""circle-two""></div>

    <div class=""auto-container"">
        <div class=""row clearfix"">
            <!--Left Column-->
            <div class=""right-column col-lg-6 col-md-12 col-sm-12"">
                <div class=""inner"">
                    <h1 style=""text-align: center;margin-top: -74px;padding-bottom: 52px"" id=""title"">Albums</h1>
                    <div class=""row clearfix"">
                        <!--About Feature-->
");
            EndContext();
#line 121 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
                         foreach (var item in Model.result.Take(4))
                        {

#line default
#line hidden
            BeginContext(3942, 173, true);
            WriteLiteral("                            <div class=\"about-feature col-md-6 col-sm-12\">\r\n                                <div class=\"container\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4115, "\"", 4154, 2);
            WriteAttributeValue("", 4121, "data:image/png;base64,", 4121, 22, true);
#line 125 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
WriteAttributeValue("", 4143, item.Image, 4143, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4155, 182, true);
            WriteLiteral(" style=\"height:200px;width: 222px;\" alt=\"Avatar\" class=\"image\">\r\n                                    <div class=\"overlay\">\r\n                                        <div class=\"text\">");
            EndContext();
            BeginContext(4338, 16, false);
#line 127 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
                                                     Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4354, 128, true);
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 131 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"

                        }

#line default
#line hidden
            BeginContext(4511, 485, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>


            <!--Right Column-->
            <div class=""right-column col-lg-6 col-md-12 col-sm-12"">
                <div class=""inner"">
                    <div>
                        <h1 style=""text-align: center;margin-top: -74px;padding-bottom: 52px""  id=""title"">Vedios</h1>
                    </div>
                    <div class=""row clearfix"">
                        <!--About Feature-->
");
            EndContext();
#line 147 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
                         foreach (var item in Model.vedioResult.Take(4))
                        {


#line default
#line hidden
            BeginContext(5099, 201, true);
            WriteLiteral("                            <div class=\"about-feature col-md-6 col-sm-12\">\r\n                                <div class=\"container\">\r\n                                    <iframe height=\"200\" width=\"250\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5300, "\"", 5315, 1);
#line 152 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
WriteAttributeValue("", 5306, item.URL, 5306, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5316, 246, true);
            WriteLiteral(" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 155 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5589, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 160 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
             if (Model.result.Count == 0)
            { 

#line default
#line hidden
            BeginContext(5722, 182, true);
            WriteLiteral("                   <div class=\"about-feature col-md-12 col-sm-12\">\r\n                       <p style=\"text-align:center\">No Data To Be Shown .........</p>\r\n                   </div>\r\n");
            EndContext();
#line 165 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5919, 33, true);
            WriteLiteral("            <!--Right Column-->\r\n");
            EndContext();
#line 167 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
             if (Model.result.Count > 0 && Model.vedioResult.Count > 0)
            {

#line default
#line hidden
            BeginContext(6040, 113, true);
            WriteLiteral("                <div class=\"left-column col-lg-6 col-md-12 col-sm-12\">\r\n                    <div class=\"btn-box\">");
            EndContext();
            BeginContext(6153, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b391913639633c31c487060d0de58dfd114f0c7f18181", async() => {
                BeginContext(6208, 40, true);
                WriteLiteral("<span class=\"btn-title\">Show More</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6252, 32, true);
            WriteLiteral("</div>\r\n                </div>\r\n");
            EndContext();
#line 172 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(6299, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 174 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
             if (Model.vedioResult.Count > 0 && Model.result.Count > 0)
            {

#line default
#line hidden
            BeginContext(6389, 114, true);
            WriteLiteral("                <div class=\"right-column col-lg-6 col-md-12 col-sm-12\">\r\n                    <div class=\"btn-box\">");
            EndContext();
            BeginContext(6503, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b391913639633c31c487060d0de58dfd114f0c7f20361", async() => {
                BeginContext(6564, 40, true);
                WriteLiteral("<span class=\"btn-title\">Show More</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6608, 32, true);
            WriteLiteral("</div>\r\n                </div>\r\n");
            EndContext();
#line 179 "C:\Users\Noha\source\repos\charity\Charity.WebApp\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(6655, 50, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
