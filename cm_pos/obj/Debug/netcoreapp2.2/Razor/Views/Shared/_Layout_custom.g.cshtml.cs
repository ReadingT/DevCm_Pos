#pragma checksum "D:\cm_pos\Views\Shared\_Layout_custom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e1e68b296fbe95ae1db0fcc59784376e9335176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout_custom), @"mvc.1.0.view", @"/Views/Shared/_Layout_custom.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout_custom.cshtml", typeof(AspNetCore.Views_Shared__Layout_custom))]
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
#line 1 "D:\cm_pos\Views\_ViewImports.cshtml"
using cm_pos;

#line default
#line hidden
#line 2 "D:\cm_pos\Views\_ViewImports.cshtml"
using cm_pos.Models;

#line default
#line hidden
#line 3 "D:\cm_pos\Views\_ViewImports.cshtml"
using cm_pos.ViewModels;

#line default
#line hidden
#line 4 "D:\cm_pos\Views\_ViewImports.cshtml"
using cm_pos.services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e1e68b296fbe95ae1db0fcc59784376e9335176", @"/Views/Shared/_Layout_custom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ff9709f736cea12fdd24b51162def30a545c770", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout_custom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "print", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CookieConsentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition skin-blue sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(27, 1698, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e1e68b296fbe95ae1db0fcc59784376e93351766296", async() => {
                BeginContext(33, 15, true);
                WriteLiteral("\r\n\r\n    <title>");
                EndContext();
                BeginContext(49, 17, false);
#line 6 "D:\cm_pos\Views\Shared\_Layout_custom.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(66, 1652, true);
                WriteLiteral(@" - CMPOS</title>

    <link rel=""shortcut icon"" href=""/images/cmdev_logo.png"">

    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- Tell the browser to be responsive to screen width -->
    <meta content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"" name=""viewport"">
    <!-- Bootstrap 3.3.7 -->
    <link rel=""stylesheet"" href=""/adminlte/bower_components/bootstrap/dist/css/bootstrap.min.css"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""/adminlte/bower_components/font-awesome/css/font-awesome.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""/adminlte/bower_components/Ionicons/css/ionicons.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""/adminlte/dist/css/AdminLTE.min.css"">
    <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
    <link rel=""stylesheet"" href=""/adminlte/dist/css/skins/_all-skins.min.cs");
                WriteLiteral(@"s"">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
    <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
    <![endif]-->

    <!-- Google Font -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic"">

    <!-- My Style -->
    <link rel=""stylesheet"" href=""/css/myStyle.css"">

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
            BeginContext(1725, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1729, 10339, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e1e68b296fbe95ae1db0fcc59784376e93351769545", async() => {
                BeginContext(1782, 110, true);
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n\r\n        <header class=\"main-header\">\r\n\r\n            <!-- Logo -->\r\n            ");
                EndContext();
                BeginContext(1892, 436, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e1e68b296fbe95ae1db0fcc59784376e933517610053", async() => {
                    BeginContext(1951, 373, true);
                    WriteLiteral(@"
                <!-- mini logo for sidebar mini 50x50 pixels -->
                <span class=""logo-mini"">
                    <b>CMS</b>
                </span>
                <!-- logo for regular state and mobile devices -->
                <span class=""logo-lg"">
                    <img src=""/images/logo.png"" alt=""logo"">
                </span>
            ");
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
                BeginContext(2328, 3092, true);
                WriteLiteral(@"

            <!-- Header Navbar: style can be found in header.less -->
            <nav class=""navbar navbar-static-top navbar_custom"">
                <!-- Sidebar toggle button-->
                <a href=""#"" class=""sidebar-toggle"" data-toggle=""push-menu"" role=""button"">
                    <span class=""sr-only"">Toggle navigation</span>
                </a>
                <div class=""navbar-custom-menu"">
                    <ul class=""nav navbar-nav"">
                        <!-- User Account: style can be found in dropdown.less -->
                        <li class=""dropdown user user-menu"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                <img src=""/images/profile.jpg"" class=""user-image"" alt=""User Image"">
                                <span class=""hidden-xs"">Codemobiles</span>
                            </a>
                            <ul class=""dropdown-menu"">
                                <!-- User image -->
 ");
                WriteLiteral(@"                               <li class=""user-header"">
                                    <img src=""/images/profile.jpg"" class=""img-circle"" alt=""User Image"">
                                    <p>
                                        Codemobiles - Web Developer
                                        <small>Member since Nov. 2017</small>
                                    </p>
                                </li>
                                <!-- Menu Footer-->
                                <li class=""user-footer"">
                                    <div class=""pull-right"">
                                        <a href=""#"" class=""btn btn-default btn-flat"">Sign out</a>
                                    </div>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>

        <!-- Left side column. contains the logo and sidebar -->
        <asid");
                WriteLiteral(@"e class=""main-sidebar"">
            <!-- sidebar: style can be found in sidebar.less -->
            <section class=""sidebar"">
                <!-- sidebar menu: : style can be found in sidebar.less -->
                <ul class=""sidebar-menu"" data-widget=""tree"">
                    <li class=""header header_custom"">
                        <img src=""/images/profile.jpg"" height=""230px"" class=""img-responsive"" alt=""profile"">
                    </li>

                    <li class=""header"">MAIN NAVIGATION</li>

                    <li class=""treeview"">
                        <a href=""#"">
                            <i class=""fa fa-database""></i>
                            <span>Database</span>
                            <span class=""pull-right-container"">
                                <i class=""fa fa-angle-left pull-right""></i>
                            </span>
                        </a>
                        <ul class=""treeview-menu"">
                            <li>
            ");
                WriteLiteral("                    ");
                EndContext();
                BeginContext(5420, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e1e68b296fbe95ae1db0fcc59784376e933517615475", async() => {
                    BeginContext(5467, 72, true);
                    WriteLiteral("\r\n                                    <i class=\"fa fa-list\"></i>Products");
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
                BeginContext(5543, 104, true);
                WriteLiteral("\r\n                            </li>\r\n                             <li>\r\n                                ");
                EndContext();
                BeginContext(5647, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e1e68b296fbe95ae1db0fcc59784376e933517617329", async() => {
                    BeginContext(5668, 70, true);
                    WriteLiteral("\r\n                                    <i class=\"fa fa-print\"></i>Print");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5742, 3394, true);
                WriteLiteral(@"
                            </li>
                        </ul>
                    </li>

                    <li class=""treeview"">
                        <a href=""#"">
                            <i class=""fa fa-files-o""></i>
                            <span>Layout Options</span>
                            <span class=""pull-right-container"">
                                <span class=""label label-primary pull-right"">4</span>
                            </span>
                        </a>
                        <ul class=""treeview-menu"">
                            <li>
                                <a href=""#"">
                                    <i class=""fa fa-circle-o""></i> Top Navigation</a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <i class=""fa fa-circle-o""></i> Boxed</a>
                            </li>
                            <li>
                              ");
                WriteLiteral(@"  <a href=""#"">
                                    <i class=""fa fa-circle-o""></i> Fixed</a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <i class=""fa fa-circle-o""></i> Collapsed Sidebar</a>
                            </li>
                        </ul>
                    </li>

                    <li>
                        <a href=""#"">
                            <i class=""fa fa-th""></i>
                            <span>Widgets</span>
                            <span class=""pull-right-container"">
                                <small class=""label pull-right bg-green"">new</small>
                            </span>
                        </a>
                    </li>

                    <li>
                        <a href=""#"">
                            <i class=""fa fa-envelope""></i>
                            <span>Mailbox</span>
                            <span class=""");
                WriteLiteral(@"pull-right-container"">
                                <small class=""label pull-right bg-yellow"">12</small>
                                <small class=""label pull-right bg-green"">16</small>
                                <small class=""label pull-right bg-red"">5</small>
                            </span>
                        </a>
                    </li>

                    <li class=""header"">LABELS</li>

                    <li>
                        <a href=""#"">
                            <i class=""fa fa-circle-o text-red""></i>
                            <span>Important</span>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <i class=""fa fa-circle-o text-yellow""></i>
                            <span>Warning</span>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <i class=""fa fa-circ");
                WriteLiteral(@"le-o text-aqua""></i>
                            <span>Information</span>
                        </a>
                    </li>
                </ul>
            </section>
        </aside>

      

        <!-- Content Wrapper. Contains page content -->
            <div class=""content-wrapper"">
            ");
                EndContext();
                BeginContext(9136, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e1e68b296fbe95ae1db0fcc59784376e933517622424", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9175, 200, true);
                WriteLiteral("\r\n                <!-- Main content -->\r\n                <section class=\"content\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-xs-12\">\r\n                            ");
                EndContext();
                BeginContext(9376, 12, false);
#line 209 "D:\cm_pos\Views\Shared\_Layout_custom.cshtml"
                       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(9388, 2627, true);
                WriteLiteral(@" 
                        </div>
                    </div>
                </section>
                <!-- /.content -->
            </div>
        <!-- /.content-wrapper -->

        <footer class=""main-footer"">
            <div class=""pull-right"">
                <a href=""http://www.codemobiles.com"" target=""_blank"">
                    <img src=""/images/cm_logo.png"" height=""30px"">
                </a>
            </div>
            <div class=""row"">
                <div class=""col-md-5 contact_us"">
                    <span class=""footer_contact_header"">
                        Contact Us :
                    </span>
                    <div>
                        <img src=""/images/ic_tel.png"" class=""icon_contact_us"">
                        <span>081-359-9468 </span>
                    </div>
                    <img src=""/images/ic_mail.png"" class=""icon_contact_us"">
                    <span>support@codemobiles.com</span>
                </div>
                <div class=""co");
                WriteLiteral(@"l-md-3 contact_us"">
                     <span class=""footer_contact_header"">
                         Follow Us :
                     </span>
                    <div>
                        <a href=""https://web.facebook.com/groups/169533843170199/"" target=""_blank"">
                            <img src=""/images/ic_facebook.png"" class=""icon_follow_us"">
                        </a>
                        <a href=""https://web.facebook.com/groups/169533843170199/"" target=""_blank"">
                            <img src=""/images/ic_line.png"" class=""icon_follow_us"">
                        </a>
                        <a href=""https://www.youtube.com/channel/UCkgnZDuS9fM951TpyBTkNPg"" target=""_blank"">
                            <img src=""/images/ic_youtube.png"" class=""icon_follow_us"">
                        </a>
                    </div>
                </div>
            </div>
        </footer>
    </div>

    <!-- jQuery 3 -->
    <script src=""/adminlte/bower_components/jquery/dist/jquer");
                WriteLiteral(@"y.min.js""></script>
    <!-- Bootstrap 3.3.7 -->
    <script src=""/adminlte/bower_components/bootstrap/dist/js/bootstrap.min.js""></script>
    <!-- SlimScroll -->
    <script src=""/adminlte/bower_components/jquery-slimscroll/jquery.slimscroll.min.js""></script>
    <!-- FastClick -->
    <script src=""/adminlte/bower_components/fastclick/lib/fastclick.js""></script>
    <!-- AdminLTE App -->
    <script src=""/adminlte/dist/js/adminlte.min.js""></script>

     <!--  sweetalert -->
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>

    ");
                EndContext();
                BeginContext(12016, 41, false);
#line 269 "D:\cm_pos\Views\Shared\_Layout_custom.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(12057, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12068, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
