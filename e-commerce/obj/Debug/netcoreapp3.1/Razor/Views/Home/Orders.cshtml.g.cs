#pragma checksum "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7c8fe96b53f616d9c6dfd5f98e5396cf15b2e3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Orders), @"mvc.1.0.view", @"/Views/Home/Orders.cshtml")]
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
#nullable restore
#line 1 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\_ViewImports.cshtml"
using e_commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\_ViewImports.cshtml"
using e_commerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7c8fe96b53f616d9c6dfd5f98e5396cf15b2e3b", @"/Views/Home/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89f65dd6894ee13e717bed8c15fd34f1952c3ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<e_commerce.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>E-commerce Orders</h1>\r\n<h1>Welcome ");
#nullable restore
#line 3 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
       Write(ViewBag.LoginUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 3 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
                                    Write(ViewBag.LoginUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7c8fe96b53f616d9c6dfd5f98e5396cf15b2e3b4086", async() => {
#nullable restore
#line 9 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
                                                                              Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
                                            WriteLiteral(ViewData["NameSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7c8fe96b53f616d9c6dfd5f98e5396cf15b2e3b6579", async() => {
                WriteLiteral("Sold ");
                WriteLiteral("@");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
                                                WriteLiteral(ViewData["DateSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n            <th>Description</th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 15 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
 foreach (var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr style=\"color:Tomato;\">\r\n        <td>\r\n        ");
#nullable restore
#line 18 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
   Write(Html.DisplayFor(ModelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n        </td>\r\n       <td>\r\n        ");
#nullable restore
#line 21 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
   Write(Html.DisplayFor(ModelItem => item.UpdatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n       <td>\r\n        ");
#nullable restore
#line 24 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
   Write(Html.DisplayFor(ModelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 934, "\"", 941, 0);
            EndWriteAttribute();
            WriteLiteral(">see..more</a>\r\n</div>\r\n<!--");
#nullable restore
#line 32 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
     foreach (var item in ViewBag.AllOrders)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr style=\"color: blue;\">\r\n        <td>");
#nullable restore
#line 35 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
       Write(item.Products.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ProductId\'s:");
#nullable restore
#line 35 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
                                              Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
       Write(item.Products.UpdatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
       Write(item.Users.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" UserId:");
#nullable restore
#line 37 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
                                    Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
       Write(item.Products.Creator.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" CreatorId:");
#nullable restore
#line 38 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
                                                  Write(item.Products.Creator.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\chris\OneDrive\Desktop\C#\e-commerce\e-commerce\Views\Home\Orders.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<e_commerce.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
