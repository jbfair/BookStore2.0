#pragma checksum "C:\Users\jbfai\Source\Repos\BookStore2.0\BookStore\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993168669d00d18fdc641afacc6cfef4bd3a1f9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
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
#line 2 "C:\Users\jbfai\Source\Repos\BookStore2.0\BookStore\Pages\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993168669d00d18fdc641afacc6cfef4bd3a1f9e", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbb3e3229869d52893b39c95b541f9b3e9304e32", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Your Cart</h2>

<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Item</th>
            <th>Quantity</th>
            <th>Cost</th>
            <th>Subtotal</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 19 "C:\Users\jbfai\Source\Repos\BookStore2.0\BookStore\Pages\Cart.cshtml"
         foreach(var i in Model.basket.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\jbfai\Source\Repos\BookStore2.0\BookStore\Pages\Cart.cshtml"
           Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\jbfai\Source\Repos\BookStore2.0\BookStore\Pages\Cart.cshtml"
           Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\jbfai\Source\Repos\BookStore2.0\BookStore\Pages\Cart.cshtml"
           Write(i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\jbfai\Source\Repos\BookStore2.0\BookStore\Pages\Cart.cshtml"
            Write(i.Quantity * i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\jbfai\Source\Repos\BookStore2.0\BookStore\Pages\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\">Total:</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\jbfai\Source\Repos\BookStore2.0\BookStore\Pages\Cart.cshtml"
           Write(Model.basket.CalcTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<div>\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 790, "\"", 813, 1);
#nullable restore
#line 39 "C:\Users\jbfai\Source\Repos\BookStore2.0\BookStore\Pages\Cart.cshtml"
WriteAttributeValue("", 797, Model.ReturnUrl, 797, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Pages.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookStore.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookStore.Pages.CartModel>)PageContext?.ViewData;
        public BookStore.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
