#pragma checksum "D:\cm_pos\Views\Shared\components\User\user.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afbce7c4776380a78d2e5a86ce4366397eaa2d95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_components_User_user), @"mvc.1.0.view", @"/Views/Shared/components/User/user.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/components/User/user.cshtml", typeof(AspNetCore.Views_Shared_components_User_user))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afbce7c4776380a78d2e5a86ce4366397eaa2d95", @"/Views/Shared/components/User/user.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ff9709f736cea12fdd24b51162def30a545c770", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_components_User_user : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 904, true);
            WriteLiteral(@"


    <div class=""row"">
        <div class=""col-md-6"">
            <!-- USERS LIST -->
            <div class=""box box-danger"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Latest Members</h3>
    
                    <div class=""box-tools pull-right"">
                        <span class=""label label-danger"">8 New Members</span>
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse""><i class=""fa fa-minus""></i>
                        </button>
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i>
                        </button>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class=""box-body no-padding"">
                    <ul class=""users-list clearfix"">
");
            EndContext();
#line 23 "D:\cm_pos\Views\Shared\components\User\user.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1015, 338, true);
            WriteLiteral(@"                            <li>
                                <img src=""https://static.boredpanda.com/blog/wp-content/uploads/2018/04/handicapped-cat-rexie-the-handicat-dasha-minaeva-58-5acb4f1931e1b__700.jpg""
                                    alt=""User Image"">
                                <a class=""users-list-name"" href=""#"">");
            EndContext();
            BeginContext(1354, 9, false);
#line 28 "D:\cm_pos\Views\Shared\components\User\user.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1363, 117, true);
            WriteLiteral("</a>\r\n                                <span class=\"users-list-date\">Today</span>\r\n                            </li>\r\n");
            EndContext();
#line 31 "D:\cm_pos\Views\Shared\components\User\user.cshtml"
                        }

#line default
#line hidden
            BeginContext(1507, 1276, true);
            WriteLiteral(@"                    </ul>
                    <!-- /.users-list -->
                </div>
                <!-- /.box-body -->
                <div class=""box-footer text-center"">
                    <a href=""javascript:void(0)"" class=""uppercase"">View All Users</a>
                </div>
                <!-- /.box-footer -->
            </div>
            <!--/.box -->
        </div>

         <div class=""col-md-6"">
            <!-- USERS LIST -->
            <div class=""box box-danger"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Latest Members</h3>
    
                    <div class=""box-tools pull-right"">
                        <span class=""label label-danger"">8 New Members</span>
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse""><i class=""fa fa-minus""></i>
                        </button>
                        <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class");
            WriteLiteral("=\"fa fa-times\"></i>\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n                <!-- /.box-header -->\r\n                <div class=\"box-body no-padding\">\r\n                    <ul class=\"users-list clearfix\">\r\n");
            EndContext();
#line 61 "D:\cm_pos\Views\Shared\components\User\user.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2864, 338, true);
            WriteLiteral(@"                            <li>
                                <img src=""https://static.boredpanda.com/blog/wp-content/uploads/2018/04/handicapped-cat-rexie-the-handicat-dasha-minaeva-58-5acb4f1931e1b__700.jpg""
                                    alt=""User Image"">
                                <a class=""users-list-name"" href=""#"">");
            EndContext();
            BeginContext(3203, 9, false);
#line 66 "D:\cm_pos\Views\Shared\components\User\user.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3212, 117, true);
            WriteLiteral("</a>\r\n                                <span class=\"users-list-date\">Today</span>\r\n                            </li>\r\n");
            EndContext();
#line 69 "D:\cm_pos\Views\Shared\components\User\user.cshtml"
                        }

#line default
#line hidden
            BeginContext(3356, 408, true);
            WriteLiteral(@"                    </ul>
                    <!-- /.users-list -->
                </div>
                <!-- /.box-body -->
                <div class=""box-footer text-center"">
                    <a href=""javascript:void(0)"" class=""uppercase"">View All Users</a>
                </div>
                <!-- /.box-footer -->
            </div>
            <!--/.box -->
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
