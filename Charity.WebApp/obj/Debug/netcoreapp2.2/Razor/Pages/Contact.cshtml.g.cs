#pragma checksum "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3063697b7bcae9ab91f87d0857a89bf73124e0d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Charity.WebApp.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(Charity.WebApp.Pages.Pages_Contact), null)]
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
#line 5 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
using Charity.WebApp.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3063697b7bcae9ab91f87d0857a89bf73124e0d2", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aface1c96bf45ef50cc5de419f76ca209de9af5f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/contact.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(127, 385, true);
            WriteLiteral(@"<style>
    .contact-section .map-column {
        top: 90px;
    }

    .message {
        color: red;
    }
</style>


<!-- Page Banner Section -->
<section class=""page-banner"">
    <div class=""image-layer lazy-image"" data-bg=""url('images/background/bg-banner-1.jpg')""></div>
    <div class=""bottom-rotten-curve""></div>

    <div class=""auto-container"">
        <h1>");
            EndContext();
            BeginContext(513, 52, false);
#line 24 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("Contact_Us"));

#line default
#line hidden
            EndContext();
            BeginContext(565, 66, true);
            WriteLiteral("</h1>\r\n        <ul class=\"bread-crumb clearfix\">\r\n            <li>");
            EndContext();
            BeginContext(631, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3063697b7bcae9ab91f87d0857a89bf73124e0d27172", async() => {
                BeginContext(653, 46, false);
#line 26 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
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
            BeginContext(703, 38, true);
            WriteLiteral("</li>\r\n            <li class=\"active\">");
            EndContext();
            BeginContext(742, 52, false);
#line 27 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
                          Write(SharedLocalizer.GetLocalizedHtmlString("Contact_Us"));

#line default
#line hidden
            EndContext();
            BeginContext(794, 258, true);
            WriteLiteral(@"</li>
        </ul>
    </div>

</section>
<!--End Banner Section -->
<!--Contact Info Section-->
<section class=""contact-info-section"">
    <div class=""auto-container"">

        <div class=""sec-title centered"">
            <div class=""sub-title"">");
            EndContext();
            BeginContext(1053, 52, false);
#line 38 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
                              Write(SharedLocalizer.GetLocalizedHtmlString("Contact_Us"));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 24, true);
            WriteLiteral("</div>\r\n            <h2>");
            EndContext();
            BeginContext(1130, 54, false);
#line 39 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Get_In_Touch"));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 533, true);
            WriteLiteral(@"</h2>
        </div>

        <div class=""info-boxes"">
            <div class=""row clearfix"">
                <!--Info Box-->
                <div class=""info-box col-lg-4 col-md-6 col-sm-12"">
                    <div class=""inner-box wow fadeInUp"" data-wow-delay=""0ms"">
                        <div class=""image-layer lazy-image"" data-bg=""url('images/resource/contact-image-1.jpg')""></div>
                        <div class=""icon-box""><span class=""flaticon-home-location-marker""></span></div>
                        <h4>");
            EndContext();
            BeginContext(1718, 50, false);
#line 49 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
                       Write(SharedLocalizer.GetLocalizedHtmlString("FollowUs"));

#line default
#line hidden
            EndContext();
            BeginContext(1768, 834, true);
            WriteLiteral(@"</h4>
                        <ul>
                            <li><a href=""https://www.facebook.com/GiovaniXilBene/"">FaceBook</a></li>
                            <li><a href=""https://www.youtube.com/channel/UCoP85Zm67IBL10vI_-f6zZQ?fbclid=IwAR0CLQWYqgurv8XEYlrmmrP9XnsCROAc-MfeUcIv-ddCtkuZrXZJVgcIxBc"">Youtube</a></li>
                        </ul>
                    </div>
                </div>
                <!--Info Box-->
                <div class=""info-box col-lg-4 col-md-6 col-sm-12"">
                    <div class=""inner-box wow fadeInUp"" data-wow-delay=""300ms"">
                        <div class=""image-layer lazy-image"" data-bg=""url('images/resource/contact-image-2.jpg')""></div>
                        <div class=""icon-box""><span class=""flaticon-phone-call""></span></div>
                        <h4>");
            EndContext();
            BeginContext(2603, 52, false);
#line 61 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
                       Write(SharedLocalizer.GetLocalizedHtmlString("Our_Phones"));

#line default
#line hidden
            EndContext();
            BeginContext(2655, 737, true);
            WriteLiteral(@"</h4>
                        <ul>
                            <li><a href=""tel:(+55)654-545-5418"">(+55)  654 - 545 - 5418</a></li>
                            <li><a href=""tel:(+55)654-545-1235"">(+55)  654 - 545 - 1235</a></li>
                        </ul>
                    </div>
                </div>
                <!--Info Box-->
                <div class=""info-box col-lg-4 col-md-6 col-sm-12"">
                    <div class=""inner-box wow fadeInUp"" data-wow-delay=""600ms"">
                        <div class=""image-layer lazy-image"" data-bg=""url('images/resource/contact-image-3.jpg')""></div>
                        <div class=""icon-box""><span class=""flaticon-email""></span></div>
                        <h4>");
            EndContext();
            BeginContext(3393, 55, false);
#line 73 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
                       Write(SharedLocalizer.GetLocalizedHtmlString("Email_Address"));

#line default
#line hidden
            EndContext();
            BeginContext(3448, 654, true);
            WriteLiteral(@"</h4>
                        <ul>
                            <li><a href=""mailto:nohasameh583@gmail.com"">giovanixbene@gmail.com</a></li>
                            <li><a href=""mailto:nohasameh583@gmail.com"">giovanixbene@gmail.com</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

    </div>
</section>
<section class=""contact-section "">
    <div class=""outer-container clearfix"">

        <div class=""form-column clearfix"">
            <div class=""inner clearfix"">
                <div class=""sec-title centered "">
                    <div class=""sub-title"">");
            EndContext();
            BeginContext(4103, 52, false);
#line 91 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
                                      Write(SharedLocalizer.GetLocalizedHtmlString("Contact_Us"));

#line default
#line hidden
            EndContext();
            BeginContext(4155, 32, true);
            WriteLiteral("</div>\r\n                    <h2>");
            EndContext();
            BeginContext(4188, 57, false);
#line 92 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
                   Write(SharedLocalizer.GetLocalizedHtmlString("Leave_a_Message"));

#line default
#line hidden
            EndContext();
            BeginContext(4245, 133, true);
            WriteLiteral("</h2>\r\n                </div>\r\n                <!-- Contact Form-->\r\n                <div class=\"contact-form\">\r\n                    ");
            EndContext();
            BeginContext(4378, 1560, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3063697b7bcae9ab91f87d0857a89bf73124e0d215206", async() => {
                BeginContext(4416, 159, true);
                WriteLiteral("\r\n                        <div class=\"row clearfix\">\r\n                            <div class=\"col-md-6 col-sm-12 form-group\">\r\n                                ");
                EndContext();
                BeginContext(4575, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3063697b7bcae9ab91f87d0857a89bf73124e0d215758", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 99 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.model.Subject);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 99 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
AddHtmlAttributeValue("", 4631, SharedLocalizer.GetLocalizedHtmlString("Your_Name"), 4631, 52, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4685, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(4719, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3063697b7bcae9ab91f87d0857a89bf73124e0d218116", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 100 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.model.Subject);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4783, 145, true);
                WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"col-md-6 col-sm-12 form-group\">\r\n                                ");
                EndContext();
                BeginContext(4928, 121, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3063697b7bcae9ab91f87d0857a89bf73124e0d220055", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 104 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.model.EmailFromAddress);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 104 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
AddHtmlAttributeValue("", 4994, SharedLocalizer.GetLocalizedHtmlString("Your_Email"), 4994, 53, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5049, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(5083, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3063697b7bcae9ab91f87d0857a89bf73124e0d222425", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 105 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.model.EmailFromAddress);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5156, 146, true);
                WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"col-md-12 col-sm-12 form-group\">\r\n                                ");
                EndContext();
                BeginContext(5302, 118, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3063697b7bcae9ab91f87d0857a89bf73124e0d224374", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 109 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.model.Body);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 109 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
AddHtmlAttributeValue("", 5346, SharedLocalizer.GetLocalizedHtmlString("Write_your_message"), 5346, 61, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5420, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(5454, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3063697b7bcae9ab91f87d0857a89bf73124e0d226547", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 110 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.model.Body);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5515, 255, true);
                WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"col-md-12 col-sm-12 form-group text-center\">\r\n                                <button class=\"theme-btn btn-style-one\" type=\"submit\" name=\"submit-form\"><span class=\"btn-title\">");
                EndContext();
                BeginContext(5771, 54, false);
#line 114 "C:\Users\Noha\source\repos\Charity_New\CharityProject\Charity.WebApp\Pages\Contact.cshtml"
                                                                                                                            Write(SharedLocalizer.GetLocalizedHtmlString("Send_Message"));

#line default
#line hidden
                EndContext();
                BeginContext(5825, 106, true);
                WriteLiteral("</span></button>\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5938, 119, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"map-column clearfix\">\r\n            ");
            EndContext();
            BeginContext(6057, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3063697b7bcae9ab91f87d0857a89bf73124e0d230706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6091, 44, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Charity.WebApp.Pages.ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Charity.WebApp.Pages.ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Charity.WebApp.Pages.ContactModel>)PageContext?.ViewData;
        public Charity.WebApp.Pages.ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
