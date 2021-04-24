#pragma checksum "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d18f78d3e068bb73140bc7f955699c567076a03a"
// <auto-generated/>
#pragma warning disable 1591
namespace ContosoCrafts.WebSite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ProductList</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-columns");
#nullable restore
#line 8 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-img");
            __builder.AddAttribute(7, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 11 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenElement(11, "h5");
            __builder.AddAttribute(12, "class", "card-title");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                        product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-footer");
            __builder.OpenElement(17, "small");
            __builder.AddAttribute(18, "class", "text-muted");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                      (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "data-toggle", "modal");
            __builder.AddAttribute(22, "data-target", "#productModal");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddMarkupContent(24, "\r\n                        More Info\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
#nullable restore
#line 30 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "modal fade");
            __builder.AddAttribute(28, "id", "productModal");
            __builder.AddAttribute(29, "tabindex", "-1");
            __builder.AddAttribute(30, "role", "dialog");
            __builder.AddAttribute(31, "aria-labelledby", "productTitle");
            __builder.AddAttribute(32, "aria-hidden", "true");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(35, "role", "document");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-content");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal-header");
            __builder.OpenElement(40, "h5");
            __builder.AddAttribute(41, "class", "modal-title");
            __builder.AddAttribute(42, "id", "productTitle");
            __builder.AddContent(43, 
#nullable restore
#line 36 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                               selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.AddMarkupContent(45, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "modal-body");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "card-img");
            __builder.AddAttribute(53, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 43 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "card-body");
            __builder.OpenElement(57, "p");
            __builder.AddAttribute(58, "class", "card-text");
            __builder.AddContent(59, 
#nullable restore
#line 46 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                  selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-footer");
#nullable restore
#line 51 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(63, "<span>Be the first to vote!</span>");
#nullable restore
#line 54 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "span");
            __builder.AddContent(65, 
#nullable restore
#line 57 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, " ");
            __builder.AddContent(67, 
#nullable restore
#line 57 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                          voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                     for (var i = 0; i <= 4; ++i)
                    {
                        var currentStar = i;
                        if (i <= currRating)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(68, "span");
            __builder.AddAttribute(69, "class", "fa-star fa");
            __builder.AddAttribute(70, "style", "color: #c69500");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                                                      (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(72, "span");
            __builder.AddAttribute(73, "class", "fa-star fa");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                                                               (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\White\source\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
       
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating();
    }

    int currRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if (selectedProduct.Ratings == null)
        {
            currRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Ratings.Length;
            currRating = selectedProduct.Ratings.Sum() / voteCount;
            voteLabel = voteCount > 1 ? "votes" : "vote";
        }
        Console.WriteLine($"{selectedProduct.Id},{voteCount},{currRating},{voteLabel}");
    }

    void SubmitRating(int rating)
    {
        Console.WriteLine($"Rating recived for {selectedProduct.Id}:{rating}");
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591