#pragma checksum "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdd70b0a695cd8dc6338183effe83fd703769124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ranking_Index), @"mvc.1.0.view", @"/Views/Ranking/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ranking/Index.cshtml", typeof(AspNetCore.Views_Ranking_Index))]
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
#line 1 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
using GreatTrade;

#line default
#line hidden
#line 2 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
using GreatTrade.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdd70b0a695cd8dc6338183effe83fd703769124", @"/Views/Ranking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69353d5a56d9084aabfee9212e305412563df20", @"/Views/_ViewImports.cshtml")]
    public class Views_Ranking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<IGrouping<GreatTrade.Models.Enum.TypeCountries, GreatTrade.Models.User>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
  
    ViewData["Title"] = "Ranking";
    Layout = "~/Views/Shared/ProfileLayout.cshtml";

#line default
#line hidden
            BeginContext(188, 1838, true);
            WriteLiteral(@"
<h2>Index</h2>

<section class=""section single-wrap"">
    <div class=""container"">
        <div class=""page-title"">
            <div class=""row"">
                <div class=""col-sx-12 text-center"">
                    <h3>Ranking de ventas</h3>
                    <div class=""bread"">
                        <ol class=""breadcrumb"">
                            <li><a href=""#"">Home</a></li>
                            <li class=""active"">Ranking</li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class=""content-top"">
            <div class=""row"">
                <div class=""col-sx-6 col-sm-6"">
                    <div class=""custommenu hidden-xs"">
                        <a id=""showLeft"" href=""#"" title="""" class=""bt-menu-trigger""><i class=""fa fa-bars""></i> <img src=""upload/fav.png"" alt=""""></a>
                    </div>
                </div>
                <div class=""col-sm-6 col-xs-12 cen-xs text-right"">
 ");
            WriteLiteral(@"                   <ul class=""list-inline social"">
                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-dribbble""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-behance""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-pinterest""></i></a></li>
                    </ul>
                </div>
            </div><!-- end row -->
        </div><!-- end content top -->
        <div class=""content-before"">
            <div class=""row"">
                <div class=""col-md-12 col-sx-12 cen-xs"">
                    ");
            EndContext();
            BeginContext(2026, 966, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6469a490fb2a40719f91a306633c8328", async() => {
                BeginContext(2049, 222, true);
                WriteLiteral("\r\n                        <div class=\"input-prepend\">\r\n                            <div class=\"btn-group\">\r\n                                <select name=\"orderby\" class=\"selectpicker\">\r\n                                    ");
                EndContext();
                BeginContext(2271, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db99af010ab54bd988cdd608f36cf18e", async() => {
                    BeginContext(2279, 13, true);
                    WriteLiteral("All Platforms");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2301, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2339, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0256d09b6e174b10b53a585d91cf18ed", async() => {
                    BeginContext(2347, 8, true);
                    WriteLiteral("IOS Apps");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2364, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2402, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de066a2569a84a98a362e45b664a7eb5", async() => {
                    BeginContext(2410, 12, true);
                    WriteLiteral("Android Apps");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2431, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2469, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07adb81954a94c8e858b4e2b92b4e4e8", async() => {
                    BeginContext(2477, 7, true);
                    WriteLiteral("UI Kits");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2493, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2531, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af7e810d461c4d6e907b95b2c99f5017", async() => {
                    BeginContext(2539, 14, true);
                    WriteLiteral("Site Templates");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2562, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2600, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f370d9b759f49e688aaac8b4ffbcd5e", async() => {
                    BeginContext(2608, 16, true);
                    WriteLiteral("WordPress Themes");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2633, 352, true);
                WriteLiteral(@"
                                </select>
                            </div>
                            <input type=""text"" class=""form-control"" placeholder=""Search anything here."">
                            <button class=""btn btn-primary"" tabindex=""-1""><i class=""fa fa-search""></i></button>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2992, 1554, true);
            WriteLiteral(@"
                </div>
                <div class=""col-md-6 text-right hidden-xs"">

                </div>
            </div><!-- end row -->
        </div><!-- end content before -->
        <div class=""content boxs"">
            <div class=""row"">
                <div class=""col-md-12 col-sm-12"">
                    <div class=""page-content"">
                        <div id=""bbpress-forums"">
                            <div class=""table-responsive"">
                                <ul class=""bbp-forums"">


                                    <li class=""bbp-body"">
                                        <ul class=""forum type-forum status-publish hentry loop-item-0 odd bbp-forum-status-open bbp-forum-visibility-publish"">
                                            <table class=""table table-striped"">
                                                <caption> Ranking de ventas globers</caption>
                                                <thead>
                                          ");
            WriteLiteral(@"          <tr>
                                                        <th scope=""col"">Posición</th>
                                                        <th scope=""col"">Nombre</th>
                                                        <th scope=""col"">Pais</th>
                                                        <th scope=""col"">Ventas</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
");
            EndContext();
#line 90 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                     for (int i = 0; i < Model.Count(); i++)
                                                    {

#line default
#line hidden
            BeginContext(4695, 138, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <th scope=\"row\">");
            EndContext();
            BeginContext(4834, 1, false);
#line 93 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4835, 71, true);
            WriteLiteral("</th>\r\n                                                            <td>");
            EndContext();
            BeginContext(4907, 55, false);
#line 94 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                           Write(Model.ToList().ElementAt(i).FirstOrDefault().FullName());

#line default
#line hidden
            EndContext();
            BeginContext(4962, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5034, 52, false);
#line 95 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                           Write(Model.ToList().ElementAt(i).FirstOrDefault().Country);

#line default
#line hidden
            EndContext();
            BeginContext(5086, 73, true);
            WriteLiteral("</td>\r\n                                                            <td>\r\n");
            EndContext();
#line 97 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                                 if (@Model.ToList().ElementAt(i).FirstOrDefault().SalesTransactions != null)
                                                                {
                                                                    

#line default
#line hidden
            BeginContext(5438, 70, false);
#line 99 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                               Write(Model.ToList().ElementAt(i).FirstOrDefault().SalesTransactions.Count());

#line default
#line hidden
            EndContext();
#line 99 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                                                                                                           
                                                                }

#line default
#line hidden
            BeginContext(5577, 130, true);
            WriteLiteral("                                                            </td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 103 "D:\Estudio\Integrador\2019-1\Trabajo Final\GreatTrade\GreatTrade\Views\Ranking\Index.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(5762, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6904, 544, true);
            WriteLiteral(@"                                                </tbody>
                                            </table>

                                        </ul><!-- end bbp forums -->
                                    </li>
                                </ul><!-- .forums-directory -->
                            </div>
                        </div> <!-- /bbpress -->
                    </div>
                </div><!-- end col -->
            </div><!-- end row -->
        </div><!-- end content -->
    </div>
</section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<IGrouping<GreatTrade.Models.Enum.TypeCountries, GreatTrade.Models.User>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
