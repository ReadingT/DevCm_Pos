#pragma checksum "D:\cm_pos\Views\product\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d23eedd4aed41f520dadae780a0865263b7346ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_product_index), @"mvc.1.0.view", @"/Views/product/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/product/index.cshtml", typeof(AspNetCore.Views_product_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d23eedd4aed41f520dadae780a0865263b7346ff", @"/Views/product/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ff9709f736cea12fdd24b51162def30a545c770", @"/Views/_ViewImports.cshtml")]
    public class Views_product_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_custom btn_custom-medium btn_custom-blue btn_custom-radius btn_float_right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\cm_pos\Views\product\index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(102, 112, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"/adminlte/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css\">\r\n\r\n");
            EndContext();
            BeginContext(236, 56, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"/css/button_ghost.css\">\r\n\r\n");
            EndContext();
            BeginContext(313, 57, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"/css/product/index.css\">\r\n\r\n");
            EndContext();
            BeginContext(389, 370, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box"">
            <span class=""info-box-icon"">
                <img src=""/images/ic_product.png"" class=""icon_head"" alt=""total product""/>
            </span>
            <div class=""info-box-content"">
                <p class=""p_custom"">Products</p>
                    <h2>");
            EndContext();
            BeginContext(760, 25, false);
#line 25 "D:\cm_pos\Views\product\index.cshtml"
                   Write(ViewData["total_product"]);

#line default
#line hidden
            EndContext();
            BeginContext(785, 410, true);
            WriteLiteral(@"</h2>
            </div>
        </div>
    </div>
    <div class=""col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box"">
            <span class=""info-box-icon"">
                <img src=""/images/ic_catagory.png"" class=""icon_head"" alt=""total categories""/>
            </span>
            <div class=""info-box-content"">
                <p class=""p_custom"">Category</p>
                    <h2>");
            EndContext();
            BeginContext(1196, 28, false);
#line 36 "D:\cm_pos\Views\product\index.cshtml"
                   Write(ViewData["total_categories"]);

#line default
#line hidden
            EndContext();
            BeginContext(1224, 409, true);
            WriteLiteral(@"</h2>
            </div>
        </div>
    </div>
    <div class=""col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box"">
            <span class=""info-box-icon"">
                <img src=""/images/ic_new.png"" class=""icon_head"" alt=""total new product""/>
            </span>
            <div class=""info-box-content"">
                <p class=""p_custom"">New Product</p>
                    <h2>");
            EndContext();
            BeginContext(1634, 29, false);
#line 47 "D:\cm_pos\Views\product\index.cshtml"
                   Write(ViewData["total_new_product"]);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 414, true);
            WriteLiteral(@"</h2>
            </div>
        </div>
    </div>
    <div class=""col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box"">
            <span class=""info-box-icon"">
                <img src=""/images/ic_out_of_stock.png"" class=""icon_head"" alt=""total out stock""/>
            </span>
            <div class=""info-box-content"">
                <p class=""p_custom"">Out Stock</p>
                    <h2>");
            EndContext();
            BeginContext(2078, 27, false);
#line 58 "D:\cm_pos\Views\product\index.cshtml"
                   Write(ViewData["total_out_stock"]);

#line default
#line hidden
            EndContext();
            BeginContext(2105, 63, true);
            WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(2210, 186, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"box\">\r\n    <div class=\"box-body\">\r\n        <div class=\"row custom_box-body\">\r\n            <div class=\"col-md-6\">\r\n                <h2>Product</h2>\r\n            </div>\r\n");
            EndContext();
            BeginContext(2429, 52, true);
            WriteLiteral("            <div class=\"col-md-6\">\r\n                ");
            EndContext();
            BeginContext(2481, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d23eedd4aed41f520dadae780a0865263b7346ff8912", async() => {
                BeginContext(2591, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(2605, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(2681, 18, true);
            WriteLiteral("        </div>\r\n\r\n");
            EndContext();
            BeginContext(2726, 576, true);
            WriteLiteral(@"        <div class=""table-responsive"">
            <table id=""example1"" class=""table table-bordered table-striped"">
                <thead>
                    <tr>
                        <th style=""width:80px"">ID</th>
                        <th>NAME</th>
                        <th style=""width:80px"">CATEGORY</th>
                        <th style=""width:50px"">PRICE</th>
                        <th style=""width:10px"">STOCK</th>
                        <th style=""width:80px""></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 94 "D:\cm_pos\Views\product\index.cshtml"
                     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(3354, 30, true);
            WriteLiteral("                        <tr>\r\n");
            EndContext();
            BeginContext(3430, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(3497, 13, false);
#line 98 "D:\cm_pos\Views\product\index.cshtml"
                           Write(item.CodeName);

#line default
#line hidden
            EndContext();
            BeginContext(3510, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
            BeginContext(3617, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3667, 168, true);
            WriteLiteral("                            <td>\r\n                                <span style=\"width: 70px;overflow: hidden;white-space: nowrap;\">\r\n                                    ");
            EndContext();
            BeginContext(3836, 9, false);
#line 105 "D:\cm_pos\Views\product\index.cshtml"
                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3845, 78, true);
            WriteLiteral("\r\n                                </span>\r\n                            </td>\r\n");
            EndContext();
            BeginContext(3993, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4041, 34, true);
            WriteLiteral("                            <td>\r\n");
            EndContext();
            BeginContext(4135, 35, true);
            WriteLiteral("                            </td>\r\n");
            EndContext();
            BeginContext(4240, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4291, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(4358, 10, false);
#line 118 "D:\cm_pos\Views\product\index.cshtml"
                           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4368, 39, true);
            WriteLiteral(" ฿\r\n                            </td>\r\n");
            EndContext();
            BeginContext(4477, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4528, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(4595, 15, false);
#line 124 "D:\cm_pos\Views\product\index.cshtml"
                           Write(item.TotalStock);

#line default
#line hidden
            EndContext();
            BeginContext(4610, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
            BeginContext(4717, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4765, 36, true);
            WriteLiteral("                            <td>\r\n\r\n");
            EndContext();
#line 131 "D:\cm_pos\Views\product\index.cshtml"
                                  
                                    var product_id = @item.ProductID;
                                

#line default
#line hidden
            BeginContext(4943, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4977, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d23eedd4aed41f520dadae780a0865263b7346ff14975", async() => {
                BeginContext(5025, 158, true);
                WriteLiteral("\r\n                                    <img src=\"/images/ic_edit.png\" alt=\"edit\" class=\"icon_action icon_action_margin_left\">\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 135 "D:\cm_pos\Views\product\index.cshtml"
                                                       WriteLiteral(product_id);

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
            BeginContext(5187, 228, true);
            WriteLiteral("\r\n\r\n                                <!-- <a asp-action=\"Edit\" asp-controller=\"Product\" asp-route-id=\"1150\">\r\n                                    แก้ไข\r\n                                </a> -->\r\n\r\n                                ");
            EndContext();
            BeginContext(5415, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d23eedd4aed41f520dadae780a0865263b7346ff17690", async() => {
                BeginContext(5465, 162, true);
                WriteLiteral("\r\n                                    <img src=\"/images/ic_detail.png\" alt=\"detail\" class=\"icon_action icon_action_margin_left\">\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 143 "D:\cm_pos\Views\product\index.cshtml"
                                                         WriteLiteral(product_id);

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
            BeginContext(5631, 112, true);
            WriteLiteral("\r\n\r\n                                <a class=\"delete\">\r\n                                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5743, "\"", 5762, 1);
#line 148 "D:\cm_pos\Views\product\index.cshtml"
WriteAttributeValue("", 5751, product_id, 5751, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5763, 60, true);
            WriteLiteral("/>\r\n                                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5823, "\"", 5841, 1);
#line 149 "D:\cm_pos\Views\product\index.cshtml"
WriteAttributeValue("", 5831, item.Name, 5831, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5842, 233, true);
            WriteLiteral(" />\r\n                                    <img src=\"/images/ic_delete.png\" alt=\"delete\" class=\"icon_action icon_action_margin_left icon_action_margin_right\">\r\n                                </a>\r\n\r\n                            </td>\r\n");
            EndContext();
            BeginContext(6145, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 156 "D:\cm_pos\Views\product\index.cshtml"
                    }

#line default
#line hidden
            BeginContext(6199, 64, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
            BeginContext(6288, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(6400, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6420, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(6446, 1852, true);
                WriteLiteral(@"    <script src=""/adminlte/bower_components/datatables.net/js/jquery.dataTables.min.js""></script>
    <script src=""/adminlte/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js""></script>

    <script>
        $(function () {
           setupTable()
           setupDelete()
        });

        function setupTable(){
            $(""#example1"").DataTable({
                    ""sDom"": '<""pull-left""f><""pull-right""l><""row datatables_custom"">t<""row datatables_custom""><""pull-left""i><""pull-right""p>',
                    language: {
                        search: """",
                        searchPlaceholder: ""Search""
                    },
                    stateSave: true //save state page
                });
        }

        function setupDelete(){

             $('.delete').click(function (e) {
                e.preventDefault();

                var id = $(this).children('input:nth-child(1)').val();
                var name = $(this).children('input:nth-child(2)').val");
                WriteLiteral(@"();

                swal({
                    text: `Are you sure delete '${name}' ?`,
                    icon: ""warning"",
                    buttons: [""cancel"", ""ok""]
                })
                .then((willDelete) => {
                    if (willDelete) {
                        $.ajax({
                            url: `/Product/Delete/${id}`, 
                            method: 'POST',
                            dataType: 'json',
                            success: function (response) {
                                swal(response, {
                                    icon: ""success"",
                                    buttons: false
                                });

                                setTimeout(function(){
                                    location.href = """);
                EndContext();
                BeginContext(8299, 30, false);
#line 219 "D:\cm_pos\Views\product\index.cshtml"
                                                Write(Url.Action("Index", "Product"));

#line default
#line hidden
                EndContext();
                BeginContext(8329, 438, true);
                WriteLiteral(@""";
                                }, 2000);

                            },
                            error: function (response) {
                                swal(response.responseText, {
                                    icon: ""error"",
                                });
                            }
                        });
                    }
                });
            });
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(8771, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
