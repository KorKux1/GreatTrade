#pragma checksum "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Shared\Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1774cadb36823cc3ea0c09a9b5edd666b4af0443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Header), @"mvc.1.0.view", @"/Views/Shared/Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Header.cshtml", typeof(AspNetCore.Views_Shared_Header))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1774cadb36823cc3ea0c09a9b5edd666b4af0443", @"/Views/Shared/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69353d5a56d9084aabfee9212e305412563df20", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SubCategories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 1269, true);
            WriteLiteral(@"<header class=""header"">
    <div class=""container-menu"">
        <nav class=""navbar navbar-default yamm"">
            <div class=""container"">
                <div class=""navbar-table"">
                    <div class=""navbar-cell"">
                        <div class=""navbar-header"">
                            <a class=""navbar-brand"" href=""""><i class=""fa fa-hashtag""></i>GreatTrade</a>
                            <div class=""open-menu"">
                                <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#bs-example-navbar-collapse-2"">
                                    <span class=""sr-only"">Toggle navigation</span>
                                    <span class=""fa fa-bars""></span>
                                </button>
                            </div>
                        </div><!-- end navbar-header -->
                    </div><!-- end navbar-cell -->
                    <div class=""navbar-cell stretch"">
                       ");
            WriteLiteral(" <div class=\"collapse navbar-collapse\" id=\"bs-example-navbar-collapse-2\">\r\n                            <div class=\"navbar-cell\">\r\n                                <ul class=\"nav navbar-nav navbar-center\">\r\n                                    <li>");
            EndContext();
            BeginContext(1269, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa8a09eb4e274f089549d0e854fbcb95", async() => {
                BeginContext(1328, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1336, 10018, true);
            WriteLiteral(@"</li>
                                    <li class=""dropdown megamenu yamm-half hovermenu"">
                                        <a href=""#"" data-toggle=""dropdown"" class=""dropdown-toggle"">Features <b class=""fa fa-angle-down""></b></a>
                                        <ul class=""dropdown-menu"">
                                            <li>
                                                <div class=""yamm-content"">
                                                    <div class=""row"">
                                                        <div class=""col-md-4 col-sm-6"">
                                                            <div class=""box"">
                                                                <ul>
                                                                    <li><a href=""shop-four.html"">Shop 4 Columns</a></li>
                                                                    <li><a href=""shop-three.html"">Shop 3 Columns</a></li>
                                   ");
            WriteLiteral(@"                                 <li><a href=""shop-two.html"">Shop 2 Columns</a></li>
                                                                    <li><a href=""shop-infinite.html"">Shop Infinite</a></li>
                                                                    <li><a href=""shop-filterable.html"">Shop Filterable</a></li>
                                                                    <li><a href=""single-item.html"">Shop Details (Single Item)</a></li>
                                                                    <li><a href=""shop-checkout.html"">Shop Checkout</a></li>
                                                                    <li><a href=""shop-favorites.html"">Shop Favorites</a></li>
                                                                </ul>
                                                            </div><!-- end box -->
                                                        </div><!-- end col -->
                                                        <div ");
            WriteLiteral(@"class=""col-md-4 col-sm-6"">
                                                            <div class=""box"">
                                                                <ul>
                                                                    <li><a href=""stores.html"">All Stores</a></li>
                                                                    <li><a href=""about.html"">About Us</a></li>
                                                                    <li><a href=""contact.html"">Contact Us</a></li>
                                                                    <li><a href=""services.html"">Custom Services</a></li>
                                                                    <li><a href=""pricing.html"">Pricing & Plan</a></li>
                                                                    <li><a href=""search.html"">Search Results</a></li>
                                                                    <li><a href=""maintenance.html"">Maintenance Mode</a></li>
                 ");
            WriteLiteral(@"                                                   <li><a href=""page.html"">Page Sidebar</a></li>
                                                                </ul>
                                                            </div><!-- end box -->
                                                        </div><!-- end col -->
                                                        <div class=""col-md-4 col-sm-6"">
                                                            <div class=""box"">
                                                                <ul>
                                                                    <li><a href=""page-fullwidth.html"">Page Fullwidth</a></li>
                                                                    <li><a href=""page-404.html"">404 - Not Found</a></li>
                                                                    <li><a href=""elements.html"">All Elements</a></li>
                                                                    <li><a href=""logi");
            WriteLiteral(@"n.html"">Login & Register</a></li>
                                                                    <li><a href=""faqs.html"">FAQS & Support</a></li>
                                                                    <li><a href=""single-forum.html"">Single Forum</a></li>
                                                                    <li><a href=""single.html"">Single Blog</a></li>
                                                                    <li><a href=""bundle.html"">Bundle (Landing Page)</a></li>
                                                                </ul>
                                                            </div><!-- end box -->
                                                        </div><!-- end col -->
                                                    </div>
                                                </div><!-- end ttmenu-content -->
                                            </li>
                                        </ul>
                               ");
            WriteLiteral(@"     </li><!-- end mega menu -->
                                    <li class=""dropdown megamenu yamm-half hovermenu"">
                                        <a href=""#"" data-toggle=""dropdown"" class=""dropdown-toggle"">Market <b class=""fa fa-angle-down""></b></a>
                                        <ul class=""dropdown-menu"">
                                            <li>
                                                <div class=""yamm-content"">
                                                    <div class=""row"">
                                                        <div class=""col-md-6 col-sm-6"">
                                                            <div class=""box"">
                                                                <h5>Market Categories</h5>
                                                                <ul>
                                                                    <li><a href=""category.html""><i class=""fa fa-apple""></i> IOS Applications</a></li>
            ");
            WriteLiteral(@"                                                        <li><a href=""category.html""><i class=""fa fa-android""></i> UI - GUI Kits</a></li>
                                                                    <li><a href=""category.html""><i class=""fa fa-fonticons""></i> Icons & Fonts</a></li>
                                                                    <li><a href=""category.html""><i class=""fa fa-envelope-o""></i> Email Templates</a></li>
                                                                    <li><a href=""category.html""><i class=""fa fa-html5""></i> Site Templates</a></li>
                                                                    <li><a href=""category.html""><i class=""fa fa-gear""></i> Admin Templates</a></li>
                                                                    <li><a href=""category.html""><i class=""fa fa-laptop""></i> Landing Templates</a></li>
                                                                </ul>
                                                         ");
            WriteLiteral(@"   </div><!-- end box -->
                                                        </div><!-- end col -->
                                                        <div class=""col-md-6 col-sm-6"">
                                                            <div class=""box"">
                                                                <h5>User Profile</h5>
                                                                <ul>
                                                                    <li><a href=""edit-account.html"">Edit Account</a></li>
                                                                    <li><a href=""public-profile.html"">Public profile</a></li>
                                                                    <li><a href=""sales.html"">My Sales</a></li>
                                                                    <li><a href=""messages.html"">Messages</a></li>
                                                                    <li><a href=""upload-item.html"">Upload Item</a><");
            WriteLiteral(@"/li>
                                                                    <li><a href=""downloads.html"">Downloads</a></li>
                                                                    <li><a href=""login.html"">Login & Register</a></li>
                                                                </ul>
                                                            </div><!-- end box -->
                                                        </div><!-- end col -->
                                                    </div>
                                                </div><!-- end ttmenu-content -->
                                            </li>
                                        </ul>
                                    </li><!-- end mega menu -->
                                    <li class=""dropdown megamenu yamm-half hovermenu"">
                                        <a href=""#"" data-toggle=""dropdown"" class=""dropdown-toggle"">Administración <b class=""fa fa-angle-down""></b></a>
");
            WriteLiteral(@"                                        <ul class=""dropdown-menu"">
                                            <li>
                                                <div class=""yamm-content"">
                                                    <div class=""row"">
                                                        <div class=""col-md-6 col-sm-6"">
                                                            <div class=""box"">
                                                                <h5>Market Categories</h5>
                                                                <ul>
                                                                    <li><a ><i class=""fa fa-apple""></i>Agregar administrador</a></li>
                                                                    <li>");
            EndContext();
            BeginContext(11354, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d2ae4bc5024598adf26cbbf0f48c01", async() => {
                BeginContext(11405, 47, true);
                WriteLiteral("<i class=\"fa fa-android\"></i>Agregar Categorias");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11456, 79, true);
            WriteLiteral("</li>\r\n                                                                    <li>");
            EndContext();
            BeginContext(11535, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9890d4a4db2e45f293fc27922ba00f7e", async() => {
                BeginContext(11589, 52, true);
                WriteLiteral("<i class=\"fa fa-fonticons\"></i>Agregar SubCategorias");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11645, 1980, true);
            WriteLiteral(@"</li>
                                                                    <li><a ><i class=""fa fa-envelope-o""></i>Administrar Usuarios</a></li>
                                                                    <li><a ><i class=""fa fa-html5""></i>Administrar Productos</a></li>
                                                                    <li><a ><i class=""fa fa-gear""></i>Ver Reportes</a></li>
                                                                    <li><a ><i class=""fa fa-laptop""></i> Landing Templates</a></li>
                                                                </ul>
                                                            </div><!-- end box -->
                                                        </div><!-- end col -->
                                                    </div>
                                                </div><!-- end ttmenu-content -->
                                            </li>
                                        </ul>
         ");
            WriteLiteral(@"                           </li><!-- end mega menu -->
                                    <li><a href=""forum.html"" title="""">Forum</a></li>
                                    <li><a href=""blog.html"" title="""">Blog</a></li>
                                    <li><a href=""contact.html"" title="""">Contact</a></li>
                                </ul>
                                <ul class=""nav navbar-nav navbar-right"">
                                    <li class=""dropdown membermenu hovermenu"">
                                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false""><img src=""upload/member.png"" alt="""" class=""img-circle""> <span class=""caret""></span></a>
                                        <ul class=""dropdown-menu"">
                                            <li class=""dropdown-header"">Profile</li>
                                            <li>");
            EndContext();
            BeginContext(13625, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "988a1d5c7e7e4521b28cd7e21e81233f", async() => {
                BeginContext(13686, 12, true);
                WriteLiteral("Edit Account");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13702, 55, true);
            WriteLiteral("</li>\r\n                                            <li>");
            EndContext();
            BeginContext(13757, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf1c3bcde04b453ca2a024e31ce64b93", async() => {
                BeginContext(13822, 13, true);
                WriteLiteral("Editar Perfil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13839, 279, true);
            WriteLiteral(@"</li>
                                            <li><a href=""#"">Logout</a></li>
                                            <li><hr></li>
                                            <li class=""dropdown-header"">Dashboard</li>
                                            <li>");
            EndContext();
            BeginContext(14118, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "841964037a114021ac7fda7161a34087", async() => {
                BeginContext(14185, 14, true);
                WriteLiteral("Public profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14203, 850, true);
            WriteLiteral(@"</li>
                                            <li><a href=""sales.html"">My Sales</a></li>
                                            <li><a href=""messages.html"">Messages</a></li>
                                            <li><a href=""upload-item.html"">Upload Item</a></li>
                                            <li><a href=""downloads.html"">Downloads</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </div><!-- end navbar-cell -->
                        </div><!-- /.navbar-collapse -->
                    </div><!-- end navbar cell -->
                </div><!-- end navbar-table -->
            </div><!-- end container fluid -->
        </nav><!-- end navbar -->
    </div><!-- end container -->
</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
