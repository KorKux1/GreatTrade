#pragma checksum "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838ac859076ac2fd16e276df9e0ab37fbfe21e9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profiles_Details), @"mvc.1.0.view", @"/Views/Profiles/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profiles/Details.cshtml", typeof(AspNetCore.Views_Profiles_Details))]
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
#line 1 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
using GreatTrade;

#line default
#line hidden
#line 2 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
using GreatTrade.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838ac859076ac2fd16e276df9e0ab37fbfe21e9e", @"/Views/Profiles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69353d5a56d9084aabfee9212e305412563df20", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GreatTrade.Models.Profile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ItemPublication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
  
    ViewData["Title"] = Model.User.FullName()+"- Perfil";
    Layout = "~/Views/Shared/ProfileLayout.cshtml";

#line default
#line hidden
            BeginContext(155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Seo", async() => {
                BeginContext(170, 5, true);
                WriteLiteral(" \r\n\r\n");
                EndContext();
            }
            );
            BeginContext(178, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(197, 5, true);
                WriteLiteral(" \r\n\r\n");
                EndContext();
            }
            );
            BeginContext(205, 231, true);
            WriteLiteral("<section class=\"section single-wrap\">\r\n    <div class=\"container\">\r\n        <div class=\"page-title public-profile-title\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sx-12 text-center\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 436, "\"", 481, 1);
#line 20 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
WriteAttributeValue("", 442, Html.DisplayFor(model => model.Avatar), 442, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(482, 53, true);
            WriteLiteral(" alt=\"\" class=\"img-circle\">\r\n                    <h3>");
            EndContext();
            BeginContext(536, 21, false);
#line 21 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                   Write(Model.User.FullName());

#line default
#line hidden
            EndContext();
            BeginContext(557, 30, true);
            WriteLiteral("</h3>\r\n                    <p>");
            EndContext();
            BeginContext(588, 46, false);
#line 22 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                  Write(Html.DisplayFor(model => model.User.City.Name));

#line default
#line hidden
            EndContext();
            BeginContext(634, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(638, 44, false);
#line 22 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                                                    Write(Html.DisplayFor(model => model.User.Country));

#line default
#line hidden
            EndContext();
            BeginContext(682, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(712, 43, false);
#line 23 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                  Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(755, 59, true);
            WriteLiteral("</p>\r\n                    <ul class=\"list-inline social\">\r\n");
            EndContext();
#line 25 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                         if (Model.Facebook != null && Model.Facebook != "")
                        {

#line default
#line hidden
            BeginContext(919, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 953, "\"", 975, 1);
#line 27 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
WriteAttributeValue("", 960, Model.Facebook, 960, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(976, 70, true);
            WriteLiteral(" title=\"Sigueme en Facebook\"><i class=\"fa fa-facebook\"></i></a></li>\r\n");
            EndContext();
#line 28 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(1073, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 29 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                         if (Model.Twitter != null && Model.Twitter != "")
                        {

#line default
#line hidden
            BeginContext(1176, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1210, "\"", 1231, 1);
#line 31 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
WriteAttributeValue("", 1217, Model.Twitter, 1217, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1232, 69, true);
            WriteLiteral(" title=\"Sigueme en Twritter\"><i class=\"fa fa-twitter\"></i></a></li>\r\n");
            EndContext();
#line 32 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(1328, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 33 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                         if (Model.Instagram != null && Model.Instagram != "")
                        {

#line default
#line hidden
            BeginContext(1435, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1469, "\"", 1490, 1);
#line 35 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
WriteAttributeValue("", 1476, Model.Twitter, 1476, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1491, 72, true);
            WriteLiteral(" title=\"Sigueme en Instagram\"><i class=\"fa fa-instagram\"></i></a></li>\r\n");
            EndContext();
#line 36 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(1590, 1408, true);
            WriteLiteral(@"                    </ul>
                    <a href=""#"" class=""followbtn"">Contact</a> <span>-</span> <a href=""#"" class=""followbtn"">Follow</a>
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
                    <div class=""bread"">
                        <ol class=""breadcrumb"">
                            <li><a href=""#"">Cuenta</a></li>
                            <li class=""active"">Perfil</li>
                        </ol>
                    </div>
                </div>
            </div><!-- end row -->
        </div><!-- end content top -->
        ");
            WriteLiteral(@"<div class=""content boxs nopadtop"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""publicprofile"">
                        <ul class=""nav nav-tabs"" role=""tablist"">
                            <li role=""presentation"" class=""active""><a href=""#publications"" aria-controls=""products"" role=""tab"" data-toggle=""tab"">Publicaciones (");
            EndContext();
            BeginContext(2999, 31, false);
#line 64 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                                                                                                                                           Write(Model.User.Publications.Count());

#line default
#line hidden
            EndContext();
            BeginContext(3030, 181, true);
            WriteLiteral(")</a></li>\r\n                            <li role=\"presentation\" class=\"\"><a href=\"#purchase_transactions\" aria-controls=\"products\" role=\"tab\" data-toggle=\"tab\">Productos Comprados (");
            EndContext();
            BeginContext(3212, 39, false);
#line 65 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                                                                                                                                                    Write(Model.User.PurchaseTransactions.Count());

#line default
#line hidden
            EndContext();
            BeginContext(3251, 177, true);
            WriteLiteral(")</a></li>\r\n                            <li role=\"presentation\" class=\"\"><a href=\"#sales_transactions\" aria-controls=\"products\" role=\"tab\" data-toggle=\"tab\">Productos Vendidos (");
            EndContext();
            BeginContext(3429, 36, false);
#line 66 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                                                                                                                                                Write(Model.User.SalesTransactions.Count());

#line default
#line hidden
            EndContext();
            BeginContext(3465, 238, true);
            WriteLiteral(")</a></li>\r\n                        </ul>\r\n                        <div class=\"tab-content\">\r\n                            <div role=\"tabpanel\" class=\"tab-pane active\" id=\"publications\">\r\n                                <div class=\"row\">\r\n");
            EndContext();
#line 71 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                     if (Model.User.Publications != null)
                                    {
                                        

#line default
#line hidden
#line 73 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                         foreach (var publication in Model.User.Publications)
                                        {

#line default
#line hidden
            BeginContext(3955, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(3999, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "864cc9bc046343a9b9ad6becb2ecc5c1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 75 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = publication;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4051, 12, true);
            WriteLiteral("</partial>\r\n");
            EndContext();
#line 76 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                        }

#line default
#line hidden
#line 76 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(4145, 245, true);
            WriteLiteral("                                </div><!-- end row -->\r\n                            </div>\r\n                            <div role=\"tabpanel\" class=\"tab-pane active\" id=\"purchase_transactions\">\r\n                                <div class=\"row\">\r\n");
            EndContext();
#line 82 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                     if (Model.User.PurchaseTransactions != null)
                                    {
                                        

#line default
#line hidden
#line 84 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                         foreach (var purchase in Model.User.PurchaseTransactions)
                                        {
                                            

#line default
#line hidden
#line 86 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                             if (purchase != null)
                                            {

#line default
#line hidden
            BeginContext(4770, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(4818, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1e331d8ed74a45a8acdedbd3126b6112", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 88 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = purchase.Product.Publication;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4887, 12, true);
            WriteLiteral("</partial>\r\n");
            EndContext();
#line 89 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                            }

#line default
#line hidden
#line 89 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                             
                                        }

#line default
#line hidden
#line 90 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(5028, 242, true);
            WriteLiteral("                                </div><!-- end row -->\r\n                            </div>\r\n                            <div role=\"tabpanel\" class=\"tab-pane active\" id=\"sales_transactions\">\r\n                                <div class=\"row\">\r\n");
            EndContext();
#line 96 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                     foreach (var sale in Model.User.SalesTransactions)
                                    {


#line default
#line hidden
            BeginContext(5400, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(5440, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "889ca44d270c4e48889eb2cee47ab311", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 99 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = sale.Product.Publication;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5505, 12, true);
            WriteLiteral("</partial>\r\n");
            EndContext();
#line 100 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5556, 958, true);
            WriteLiteral(@"                                </div><!-- end row -->
                            </div>
                        </div>
                    </div>
                </div><!-- end col -->
            </div><!-- end row -->
        </div><!-- end content -->
        <div class=""content-after text-center boxs"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <nav class=""pagination-wrapper"">
                        <ul class=""pagination"">
                            <li><a href=""#"">1</a></li>
                            <li>
                                <a href=""#"" aria-label=""Next"">
                                    <span aria-hidden=""true"">&raquo;</span>
                                </a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div><!-- end row -->
        </div><!-- end content after -->
");
            EndContext();
#line 124 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
         if (Model.Interests != null && Model.Interests != "")
        {

#line default
#line hidden
            BeginContext(6589, 232, true);
            WriteLiteral("            <div class=\"content-message boxs\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-10 col-md-offset-1 text-center\">\r\n                        <h3>Mis intereses</h3>\r\n                        <h2>");
            EndContext();
            BeginContext(6822, 41, false);
#line 130 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Interests));

#line default
#line hidden
            EndContext();
            BeginContext(6863, 123, true);
            WriteLiteral("</h2>\r\n                    </div>\r\n                </div><!-- end row -->\r\n            </div><!-- end content message -->\r\n");
            EndContext();
#line 134 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(6997, 59, true);
            WriteLiteral("    </div><!-- end container -->\r\n</section>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(7056, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1292c71ed8af4adf987b12c3724a19d9", async() => {
                BeginContext(7102, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 139 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Profiles\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7110, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(7118, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c7ed3a782a4a218796dbf1cc69e486", async() => {
                BeginContext(7140, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7156, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GreatTrade.Models.Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
