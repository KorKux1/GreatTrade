#pragma checksum "D:\Repositorios\GreatTrade\GreatTrade\Views\Users\MySales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95418b01cdeee77e3bece1a40eb42e7aa56aa6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_MySales), @"mvc.1.0.view", @"/Views/Users/MySales.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/MySales.cshtml", typeof(AspNetCore.Views_Users_MySales))]
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
#line 1 "D:\Repositorios\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
using GreatTrade;

#line default
#line hidden
#line 2 "D:\Repositorios\GreatTrade\GreatTrade\Views\_ViewImports.cshtml"
using GreatTrade.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95418b01cdeee77e3bece1a40eb42e7aa56aa6d", @"/Views/Users/MySales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69353d5a56d9084aabfee9212e305412563df20", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_MySales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GreatTrade.Models.Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/theme/upload/fav.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Repositorios\GreatTrade\GreatTrade\Views\Users\MySales.cshtml"
  
    ViewData["Title"] = "MySales";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 279, true);
            WriteLiteral(@"

<!DOCTYPE html>
<!--[if lt IE 7 ]><html class=""ie ie6"" lang=""en""> <![endif]-->
<!--[if IE 7 ]><html class=""ie ie7"" lang=""en""> <![endif]-->
<!--[if IE 8 ]><html class=""ie ie8"" lang=""en""> <![endif]-->
<!--[if (gte IE 9)|!(IE)]><!-->
<html lang=""en"">
 <!--<![endif]-->

");
            EndContext();
            BeginContext(422, 1898, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b945b9ebb474201a64e590eb8906d67", async() => {
                BeginContext(428, 1885, true);
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">

    <!-- SITE META -->
    <title>Catalog | Responsive Marketplace Showcase Template</title>
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <meta name=""keywords"" content="""">

    <!-- FAVICONS -->
    <link rel=""shortcut icon"" href=""images/favicon.ico"" type=""image/x-icon"">
    <link rel=""apple-touch-icon"" href=""images/apple-touch-icon.png"">
    <link rel=""apple-touch-icon"" sizes=""57x57"" href=""images/apple-touch-icon-57x57.png"">
    <link rel=""apple-touch-icon"" sizes=""72x72"" href=""images/apple-touch-icon-72x72.png"">
    <link rel=""apple-touch-icon"" sizes=""76x76"" href=""images/apple-touch-icon-76x76.png"">
    <link rel=""apple-touch-icon"" sizes=""114x114"" href=""images/apple-touch-icon-114x114.png"">
    <link rel=""apple-touch-icon"" sizes=""120x120"" href=""images/apple-touch-icon-120x120.png");
                WriteLiteral(@""">
    <link rel=""apple-touch-icon"" sizes=""144x144"" href=""images/apple-touch-icon-144x144.png"">
    <link rel=""apple-touch-icon"" sizes=""152x152"" href=""images/apple-touch-icon-152x152.png"">

    <!-- TEMPLATE STYLES -->
    <link rel=""stylesheet"" type=""text/css"" href=""css/font-awesome.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/bootstrap.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""style.css"">

    <!-- CUSTOM STYLES -->
    <link rel=""stylesheet"" type=""text/css"" href=""css/prettyPhoto.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/animate.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/responsive.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/custom.css"">

    <!--[if IE]>
    <script src=""http://html5shiv.googlecode.com/svn/trunk/html5.js""></script>
    <![endif]-->

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2320, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2322, 9814, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b8546f290b44191aa4867bc9b9b5075", async() => {
                BeginContext(2328, 3034, true);
                WriteLiteral(@"

    <!-- START SITE -->
    <div id=""wrapper"">

        <nav class=""hidden-xs cbp-spmenu cbp-spmenu-vertical cbp-spmenu-left"" id=""cbp-spmenu-s1"">
            <h3><i class=""fa fa-star-o""></i> Your Favorites</h3>
            <ul>
                <li>
                    <img src=""upload/item_01.jpg"" alt="""" class=""alignleft img-responsive"">
                    <h4><a href=""single-item.html"">User Profile App</a></h4>
                    <small><a href=""single-item.html""><i class=""fa fa-eye""></i> 221</a></small>
                    <small><a href=""single-item.html""><i class=""fa fa-comment-o""></i> 05</a></small>
                </li>
                <li>
                    <img src=""upload/item_02.jpg"" alt="""" class=""alignleft img-responsive"">
                    <h4><a href=""single-item.html"">Mail Application</a></h4>
                    <small><a href=""single-item.html""><i class=""fa fa-eye""></i> 435</a></small>
                    <small><a href=""single-item.html""><i class=""fa fa-comment-o""></");
                WriteLiteral(@"i> 13</a></small>
                </li>
                <li>
                    <img src=""upload/item_03.jpg"" alt="""" class=""alignleft img-responsive"">
                    <h4><a href=""single-item.html"">Showcase Podcast</a></h4>
                    <small><a href=""single-item.html""><i class=""fa fa-eye""></i> 551</a></small>
                    <small><a href=""single-item.html""><i class=""fa fa-comment-o""></i> 12</a></small>
                </li>
                <li>
                    <img src=""upload/item_04.jpg"" alt="""" class=""alignleft img-responsive"">
                    <h4><a href=""single-item.html"">Login Box (Custom)</a></h4>
                    <small><a href=""single-item.html""><i class=""fa fa-eye""></i> 412</a></small>
                    <small><a href=""single-item.html""><i class=""fa fa-comment-o""></i> 55</a></small>
                </li>
            </ul>
            <a href=""shop-favorites.html"" class=""btn btn-primary"">Go to Favorites</a>
        </nav>

        

        <section");
                WriteLiteral(@" class=""section single-wrap"">
            <div class=""container"">
                <div class=""page-title"">
                    <div class=""row"">
                        <div class=""col-sx-12 text-center"">
                            <h3>Mis ventas</h3>
                            <div class=""bread"">
                                <ol class=""breadcrumb"">
                                    <li><a href=""#"">Home</a></li>
                                    <li class=""active"">Mis ventas</li>
                                </ol>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""content-top"">
                    <div class=""row"">
                        <div class=""col-sx-6 col-sm-6"">
                            <div class=""custommenu hidden-xs"">
                                <a id=""showLeft"" href=""#"" title="""" class=""bt-menu-trigger""><i class=""fa fa-bars""></i> ");
                EndContext();
                BeginContext(5362, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9fe2087d38224d71bb5cc1e1ba7d5229", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5407, 1275, true);
                WriteLiteral(@"</a>
                            </div>
                        </div>

                        <div class=""col-sm-6 col-xs-12 cen-xs text-right"">
                            <ul class=""list-inline social"">
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

                
                <div class=""content boxs"">
                    <div class=""row"">
             ");
                WriteLiteral("           <div class=\"col-md-12 col-sm-12\">\r\n                            <div class=\"storelist panel panel-info\">\r\n                                <div class=\"panel-body\">\r\n                                    <div class=\"form-group row wow fadeIn\">\r\n");
                EndContext();
#line 138 "D:\Repositorios\GreatTrade\GreatTrade\Views\Users\MySales.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
                BeginContext(6795, 293, true);
                WriteLiteral(@"                                            <div class=""col-sm-2 col-xs-12"">
                                                <a href=""single-item.html"" class=""screenshot"" data-gal=""upload/item_12.jpg"" title=""This is an item title <span>$12.00</span>""><img class=""img-responsive img-thumbnail""");
                EndContext();
                BeginWriteAttribute("src", " src=", 7088, "", 7132, 1);
#line 141 "D:\Repositorios\GreatTrade\GreatTrade\Views\Users\MySales.cshtml"
WriteAttributeValue("", 7093, item.Product.Photos.ElementAt(0).Route, 7093, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7132, 223, true);
                WriteLiteral(" alt=\"\"></a>\r\n                                            </div>\r\n                                            <div class=\"col-sm-5 col-xs-12\">\r\n                                                <h4><a href=\"single-item.html\">");
                EndContext();
                BeginContext(7356, 18, false);
#line 144 "D:\Repositorios\GreatTrade\GreatTrade\Views\Users\MySales.cshtml"
                                                                          Write(item.Product.Title);

#line default
#line hidden
                EndContext();
                BeginContext(7374, 160, true);
                WriteLiteral("</a></h4>\r\n                                                <ul>\r\n                                                    <li><a href=\"#\"><i class=\"fa fa-user\"></i> ");
                EndContext();
                BeginContext(7535, 20, false);
#line 146 "D:\Repositorios\GreatTrade\GreatTrade\Views\Users\MySales.cshtml"
                                                                                          Write(item.Buyer.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(7555, 629, true);
                WriteLiteral(@"</a></li>
                                                    <li><a href=""#""><i class=""fa fa-envelope-o""></i>item.Product.City.Name</a></li>
                                                    <li><a href=""#""><i class=""fa fa-folder-open-o""></i>Celulares</a></li>
                                                </ul>
                                            </div>
                                            <div class=""col-sm-2 col-xs-12"">
                                                <h4>Detalles</h4>
                                                <ul>
                                                    <li>");
                EndContext();
                BeginContext(8185, 18, false);
#line 154 "D:\Repositorios\GreatTrade\GreatTrade\Views\Users\MySales.cshtml"
                                                   Write(item.Product.Price);

#line default
#line hidden
                EndContext();
                BeginContext(8203, 63, true);
                WriteLiteral("</li>\r\n                                                    <li>");
                EndContext();
                BeginContext(8267, 17, false);
#line 155 "D:\Repositorios\GreatTrade\GreatTrade\Views\Users\MySales.cshtml"
                                                   Write(item.Product.Date);

#line default
#line hidden
                EndContext();
                BeginContext(8284, 63, true);
                WriteLiteral("</li>\r\n                                                    <li>");
                EndContext();
                BeginContext(8348, 17, false);
#line 156 "D:\Repositorios\GreatTrade\GreatTrade\Views\Users\MySales.cshtml"
                                                   Write(item.Product.City);

#line default
#line hidden
                EndContext();
                BeginContext(8365, 164, true);
                WriteLiteral("</li>\r\n                                                </ul>\r\n                                            </div>\r\n                                            <hr>\r\n");
                EndContext();
#line 160 "D:\Repositorios\GreatTrade\GreatTrade\Views\Users\MySales.cshtml"
                                        }

#line default
#line hidden
                BeginContext(8572, 3557, true);
                WriteLiteral(@"                                        
                                    </div><!-- end form-group -->
                                </div><!-- end panel body -->
                            </div><!-- end storelist -->
                        </div><!-- end col -->
                    </div><!-- end row -->
                </div><!-- end content -->

                <div class=""content-after text-center boxs"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <nav class=""pagination-wrapper"">
                                <ul class=""pagination"">
                                    <li><a href=""#"">1</a></li>
                                    <li><a href=""#"">2</a></li>
                                    <li><a href=""#"">3</a></li>
                                    <li><a href=""#"">4</a></li>
                                    <li><a href=""#"">5</a></li>
                                    <li>
                         ");
                WriteLiteral(@"               <a href=""#"" aria-label=""Next"">
                                            <span aria-hidden=""true"">&raquo;</span>
                                        </a>
                                    </li>
                                </ul>
                            </nav>
                        </div>
                    </div><!-- end row -->
                </div><!-- end content after -->

                <div class=""content-message boxs"">
                    <div class=""row"">
                        <div class=""col-md-10 col-md-offset-1 text-center"">
                            <h2>See why over 10,000 designers and developers trust Catalog. Ready to take your marketplace to the next level?</h2>
                            <a href=""#"" class=""btn btn-default btn-lg"">Join Today</a>
                        </div>
                    </div><!-- end row -->
                </div><!-- end content message -->
            </div><!-- end container -->
        </section>

     ");
                WriteLiteral(@"   <footer class=""footer"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6 col-lg-5"">
                        <div class=""media cen-xs"">
                            <p>
                                &copy; Catalog INC. 2016 - All Rights Reserverd.<br>
                                Idea by <a class=""madeby"" href=""http://showwp.com"">Show WP</a> made with <i class=""fa fa-heart""></i> coded with <i class=""fa fa-html5""></i>
                            </p>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-7"">
                        <ul class=""list-inline text-right cen-xs"">
                            <li><a href=""#"">Home</a></li>
                            <li><a href=""#"">Site Terms</a></li>
                            <li><a href=""#"">Copyrights</a></li>
                            <li><a href=""#"">License</a></li>
                            <li><a href=""#"">Legal</a></li>
 ");
                WriteLiteral(@"                           <li><a class=""topbutton"" href=""#"">Back to top <i class=""fa fa-angle-up""></i></a></li>
                        </ul>
                    </div>
                </div><!-- end row -->
            </div><!-- end container -->
        </footer><!-- end footer -->
    </div><!-- end wrapper -->
    <!-- END SITE -->

    <script src=""js/jquery.min.js""></script>
    <script src=""js/bootstrap.js""></script>
    <script src=""js/custom.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12136, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GreatTrade.Models.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
