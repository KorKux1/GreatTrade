#pragma checksum "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b214d910cf8f9582a36adf4d8c666130aa36ef1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b214d910cf8f9582a36adf4d8c666130aa36ef1", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69353d5a56d9084aabfee9212e305412563df20", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GreatTrade.Models.Context.GreatTradeContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Laura\git\GreatTrade\GreatTrade\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";


#line default
#line hidden
            BeginContext(97, 276, true);
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
            BeginContext(373, 1969, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a4447a4848b4ee4a72ceebff46d6439", async() => {
                BeginContext(379, 1956, true);
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
    <link rel=""stylesheet"" type=""text/css"" href=""css/flexslider.css"">
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
            BeginContext(2342, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2344, 5765, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6ffbe6944914d109ce39858497b0f1a", async() => {
                BeginContext(2350, 2394, true);
                WriteLiteral(@"



    <section class=""section single-wrap"">
        <div class=""container"">
            <div class=""page-title"">
                <div class=""row"">
                    <div class=""col-sx-12 text-center"">
                        <h3>Login</h3>
                        <div class=""bread"">
                            <ol class=""breadcrumb"">
                                <li><a href=""#"">Home</a></li>
                                <li class=""active"">Login</li>
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

   ");
                WriteLiteral(@"                 <div class=""col-sm-6 col-xs-12 cen-xs text-right"">
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

                    <div class=""page-content"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                ");
                WriteLiteral(@"                <div class=""widget"">
                                    <div class=""widget-title"">
                                        <h4>Ingresa a GreatTrade</h4>
                                    </div><!-- end widget-title -->

                                    <div class=""login-form"">
                                        ");
                EndContext();
                BeginContext(4744, 1027, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bc2c38d8e314e0ba23f6a049ca342df", async() => {
                    BeginContext(4784, 980, true);
                    WriteLiteral(@"
                                            <div class=""form-group"">
                                                <label>Email</label>
                                                <input type=""email"" name=""email"" required class=""form-control"" placeholder="""" />
                                                <span class=""fa fa-user""></span>
                                            </div>
                                            <div class=""form-group"">
                                                <label>Contraseña</label>
                                                <input type=""password"" name=""password"" required class=""form-control"" placeholder="""" />
                                                <span class=""fa fa-lock""></span>
                                            </div>
                                            <button type=""submit"" name=""go"" class=""btn btn-primary"">Ingresar</button>
                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
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
                BeginContext(5771, 2331, true);
                WriteLiteral(@"
                                    </div><!-- end login-form -->
                                </div><!-- end widget -->
                            </div><!-- end col -->


                        </div><!-- end row -->
                    </div>
                </div><!-- end col -->
            </div><!-- end row -->
        </div><!-- end content -->

        <br>

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

    <footer class=""footer"">
        <div class=""container"">
            <div class=""row"">
                <d");
                WriteLiteral(@"iv class=""col-md-6 col-lg-5"">
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
                        <li><a class=""topbutton"" href=""#"">Back to top <i class=""fa fa-angle-up""></i></a></li>
                    </ul>
                </div>
            </div");
                WriteLiteral(@"><!-- end row -->
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
            BeginContext(8109, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GreatTrade.Models.Context.GreatTradeContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
