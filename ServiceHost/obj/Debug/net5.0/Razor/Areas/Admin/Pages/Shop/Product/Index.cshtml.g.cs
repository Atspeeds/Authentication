#pragma checksum "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87d5c584a7dc50d16e57870f9854fba5c9d888df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.Admin.Pages.Shop.Product.Areas_Admin_Pages_Shop_Product_Index), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Shop/Product/Index.cshtml")]
namespace ServiceHost.Areas.Admin.Pages.Shop.Product
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
#line 1 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87d5c584a7dc50d16e57870f9854fba5c9d888df", @"/Areas/Admin/Pages/Shop/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969d96dd6b2935a6943f888351cbdd486bb9e7c9", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Pages_Shop_Product_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "25", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"
  
    ViewData["AdminTitle"] = "مدیریت محصولات";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                <h4 class=""modal-title"">Modal Tittle</h4>
            </div>
            <div class=""modal-body"">
                Body goes here...
            </div>
            <div class=""modal-footer"">
                <button data-dismiss=""modal"" class=""btn btn-default"" type=""button"">Close</button>
                <button class=""btn btn-success"" type=""button"">Save changes</button>
            </div>
        </div>
    </div>
</div>
<!-- modal -->


<div class=""col-lg-12"">
    <section class=""panel"">
        <div class=""panel-body"">
            <a");
            BeginWriteAttribute("href", " href=\"", 1080, "\"", 1128, 2);
            WriteAttributeValue("", 1087, "#showmodal=", 1087, 11, true);
#nullable restore
#line 31 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"
WriteAttributeValue("", 1098, Url.Page("./Index", "Create"), 1098, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-white btn-icon-text my-2 ml-2"">
                افزودن  محصول<i class=""fe fe-download mr-2""></i>
            </a>
        </div>
    </section>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <section class=""panel"">
            <header class=""panel-heading"">
                محصولات (");
#nullable restore
#line 41 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"
                    Write(Model.products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")

            </header>
            <div id=""sample_1_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                <div class=""row""><div class=""col-sm-6""><div id=""sample_1_length"" class=""dataTables_length""><label><select size=""1"" name=""sample_1_length"" aria-controls=""sample_1"" class=""form-control"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87d5c584a7dc50d16e57870f9854fba5c9d888df7271", async() => {
                WriteLiteral("10");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87d5c584a7dc50d16e57870f9854fba5c9d888df8474", async() => {
                WriteLiteral("25");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87d5c584a7dc50d16e57870f9854fba5c9d888df9594", async() => {
                WriteLiteral("50");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87d5c584a7dc50d16e57870f9854fba5c9d888df10714", async() => {
                WriteLiteral("100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</select> records per page</label></div></div><div class=""col-sm-6""><div class=""dataTables_filter"" id=""sample_1_filter""><label>Search: <input type=""text"" aria-controls=""sample_1"" class=""form-control""></label></div></div></div><table class=""table table-striped border-top dataTable"" id=""sample_1"" aria-describedby=""sample_1_info"">
                    <thead>
                        <tr role=""row"">
                            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""sample_1"" rowspan=""1"" colspan=""1"" style=""width: 310px;"" aria-label=""id: activate to sort column ascending"">محصول</th>
                            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""sample_1"" rowspan=""1"" colspan=""1"" style=""width: 310px;"" aria-label=""picture: activate to sort column ascending"">محصول</th>
                            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""sample_1"" rowspan=""1"" colspan=""1"" style=""width: 113px;"" aria-label=""name: activate to sort c");
            WriteLiteral(@"olumn ascending"">نام</th>
                            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""sample_1"" rowspan=""1"" colspan=""1"" style=""width: 169px;"" aria-label=""code: activate to sort column ascending"">کد</th>
                            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""sample_1"" rowspan=""1"" colspan=""1"" style=""width: 179px;"" aria-label="": activate to sort column ascending"">تاریخ</th>
                            <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""sample_1"" rowspan=""1"" colspan=""1"" style=""width: 179px;"" aria-label="": activate to sort column ascending"">عملیات</th>

                        </tr>
                    </thead>

                    <tbody role=""alert"" aria-live=""polite"" aria-relevant=""all"">
");
#nullable restore
#line 59 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"
                         foreach (var product in Model.products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr role=\"row\" class=\"odd\">\r\n                                <td class=\"id\">");
#nullable restore
#line 62 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"
                                          Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td class=\"t-img\">\r\n                                    <a href=\"#\" class=\"pull-right thumb p-thumb\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 4169, "\"", 4206, 2);
            WriteAttributeValue("", 4175, "/Picturesapp/", 4175, 13, true);
#nullable restore
#line 66 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"
WriteAttributeValue("", 4188, product.Picture, 4188, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n                                    </a>\r\n                                </td>\r\n\r\n                                <td class=\"sorting_1\">");
#nullable restore
#line 70 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"
                                                 Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"
                               Write(product.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n                                <td class=\"date\">");
#nullable restore
#line 77 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"
                                            Write(product.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4611, "\"", 4676, 2);
            WriteAttributeValue("", 4618, "#showmodal=", 4618, 11, true);
#nullable restore
#line 80 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"
WriteAttributeValue("", 4629, Url.Page("./Index", "Edit",new{id=product.Id}), 4629, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info \">ویرایش<i class=\"icon-refresh\"></i></a>\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 84 "C:\Users\A\source\repos\AuthenticationApp\ServiceHost\Areas\Admin\Pages\Shop\Product\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table><div class=""row""><div class=""col-sm-6""><div class=""dataTables_info"" id=""sample_1_info"">Showing 1 to 10 of 25 entries</div></div><div class=""col-sm-6""><div class=""dataTables_paginate paging_bootstrap pagination""><ul><li class=""prev disabled""><a href=""#"">← Prev</a></li><li class=""active""><a href=""#"">1</a></li><li><a href=""#"">2</a></li><li><a href=""#"">3</a></li><li class=""next""><a href=""#"">Next → </a></li></ul></div></div></div>
            </div>
        </section>
    </div>
</div>
<!-- page end-->
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Areas.Admin.Pages.Shop.Product.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Admin.Pages.Shop.Product.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Admin.Pages.Shop.Product.IndexModel>)PageContext?.ViewData;
        public ServiceHost.Areas.Admin.Pages.Shop.Product.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
