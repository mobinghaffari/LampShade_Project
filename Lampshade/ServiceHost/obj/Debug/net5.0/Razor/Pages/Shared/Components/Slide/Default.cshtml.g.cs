#pragma checksum "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94d46ed462daf6e6f1dd7f13f37962db9b3ba573"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Slide.Pages_Shared_Components_Slide_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Slide/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Slide
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
#line 1 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d46ed462daf6e6f1dd7f13f37962db9b3ba573", @"/Pages/Shared/Components/Slide/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7dfa287772c6a1d9e6d57c20bf058d1e9f9c06", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Slide_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampshadeQuery.Contracts.Slide.SlideQueryModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero-slider-area section-space"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""hero-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                        ""slidesToShow"": 1,
                        ""slidesToScroll"": 1,
                        ""arrows"": true,
                        ""dots"": true,
                        ""autoplay"": true,
                        ""autoplaySpeed"": 5000,
                        ""speed"": 1000,
                        ""fade"": true,
                        ""infinite"": true,
                        ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                        ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                    }' data-slick-responsive='[
                        {""breakpoint"":1501, ""settings"": {""slidesToShow"": 1} },
                        {""breakpoint"":1199, ""settings"": {");
            WriteLiteral(@"""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":991, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":767, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":575, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                    ]'>

");
#nullable restore
#line 29 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                         foreach (var slide in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-slider-item\">\n                                <div class=\"hero-slider-item-wrapper\">\n                                    <div class=\"container\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94d46ed462daf6e6f1dd7f13f37962db9b3ba5735233", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1853, "~/ProductPictures/", 1853, 18, true);
#nullable restore
#line 34 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
AddHtmlAttributeValue("", 1871, slide.Picture, 1871, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
AddHtmlAttributeValue("", 1892, slide.PictureAlt, 1892, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
AddHtmlAttributeValue("", 1918, slide.PictureTitle, 1918, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-lg-12"">
                                                <div class=""hero-slider-content hero-slider-content--left-space"">
                                                    <p class=""slider-title slider-title--big-light"">");
#nullable restore
#line 38 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                               Write(slide.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                                    <p class=\"slider-title slider-title--big-bold\">");
#nullable restore
#line 39 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                              Write(slide.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                                    <p class=\"slider-title slider-title--small\">\n                                                        ");
#nullable restore
#line 41 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                   Write(slide.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                    </p>\n                                                    <a class=\"hero-slider-button\"");
            BeginWriteAttribute("href", " href=\"", 2720, "\"", 2738, 1);
#nullable restore
#line 43 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2727, slide.Link, 2727, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                        ");
#nullable restore
#line 44 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                   Write(slide.BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""ion-ios-plus-empty""></i>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 52 "C:\Users\Mobin\Desktop\Atrya\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampshadeQuery.Contracts.Slide.SlideQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
