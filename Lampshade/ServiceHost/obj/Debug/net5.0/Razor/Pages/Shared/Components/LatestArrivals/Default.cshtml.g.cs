#pragma checksum "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4fbb34a30e21a5090018a689e8be4ed9bda8c5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.LatestArrivals.Pages_Shared_Components_LatestArrivals_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/LatestArrivals/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.LatestArrivals
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
#line 1 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fbb34a30e21a5090018a689e8be4ed9bda8c5c", @"/Pages/Shared/Components/LatestArrivals/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7dfa287772c6a1d9e6d57c20bf058d1e9f9c06", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_LatestArrivals_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampshadeQuery.Contracts.Product.ProductQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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

<div class=""single-row-slider-area section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title-wrapper text-center section-space--half"">
                    <h2 class=""section-title"">آخرین محصولات</h2>
                    <p class=""section-subtitle"">
                        لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""single-row-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                    ""slidesToShow"": 4,
                    ""slidesToScroll"": 1,
                    ""arrows"": true,
                    ""autoplay"": false,
                    ""autoplaySpeed"": 5000,
                    ""speed"": 10");
            WriteLiteral(@"00,
                    ""infinite"": true,
                    ""rtl"": true,
                    ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                    ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                }' data-slick-responsive='[
                    {""breakpoint"":1501, ""settings"": {""slidesToShow"": 4} },
                    {""breakpoint"":1199, ""settings"": {""slidesToShow"": 4, ""arrows"": false} },
                    {""breakpoint"":991, ""settings"": {""slidesToShow"": 3, ""arrows"": false} },
                    {""breakpoint"":767, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                    {""breakpoint"":575, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                    {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                ]'>
");
#nullable restore
#line 38 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                         foreach (var product in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col"">
                                <div class=""single-grid-product"">
                                    <div class=""single-grid-product__image"">
                                        <div class=""single-grid-product__label"">
");
#nullable restore
#line 44 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                             if (product.HasDiscount)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"sale\">-");
#nullable restore
#line 46 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                               Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\n                                                <span class=\"new\">جدید</span>\n");
#nullable restore
#line 48 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\n                                        <a href=\"single-product.html\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a4fbb34a30e21a5090018a689e8be4ed9bda8c5c7733", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2819, "~/ProductPictures/", 2819, 18, true);
#nullable restore
#line 51 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
AddHtmlAttributeValue("", 2837, product.Picture, 2837, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
AddHtmlAttributeValue("", 2878, product.PictureAlt, 2878, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
AddHtmlAttributeValue("", 2906, product.PictureTitle, 2906, 21, false);

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
                                        </a>
                                    </div>
                                    <div class=""single-grid-product__content"">
                                        <div class=""single-grid-product__category-rating"">
                                            <span class=""category""><a href=""shop-left-sidebar.html"">");
#nullable restore
#line 56 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                                               Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></span>
                                            <span class=""rating"">
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star active""></i>
                                                <i class=""ion-android-star-outline""></i>
                                            </span>
                                        </div>

                                        <h3 class=""single-grid-product__title"">
                                            <a href=""single-product.html"">");
#nullable restore
#line 67 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                     Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                        </h3>\n                                        <p class=\"single-grid-product__price\">\n");
#nullable restore
#line 70 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                             if (product.HasDiscount)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"discounted-price\">");
#nullable restore
#line 72 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                          Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\n                                                <span class=\"main-price discounted\">");
#nullable restore
#line 73 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\n");
#nullable restore
#line 74 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"main-price\">");
#nullable restore
#line 77 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                                                    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\n");
#nullable restore
#line 78 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </p>\n                                    </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 83 "C:\Users\Mobin\Desktop\InGesmat\LampShade_Project-5c1cf87d0effddd560af1336b5c2e22401c7abd0\Lampshade\ServiceHost\Pages\Shared\Components\LatestArrivals\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampshadeQuery.Contracts.Product.ProductQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
