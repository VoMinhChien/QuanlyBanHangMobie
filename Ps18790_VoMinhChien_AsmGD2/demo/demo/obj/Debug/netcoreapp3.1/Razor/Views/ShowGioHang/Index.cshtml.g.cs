#pragma checksum "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22c077b6716793dc5a0da42221357b78ca5df0bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShowGioHang_Index), @"mvc.1.0.view", @"/Views/ShowGioHang/Index.cshtml")]
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
#line 1 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\_ViewImports.cshtml"
using demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\_ViewImports.cshtml"
using demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c077b6716793dc5a0da42221357b78ca5df0bd", @"/Views/ShowGioHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eae16e985384ed2ccc0dcb10dbe2dab2d21b6a3b", @"/Views/_ViewImports.cshtml")]
    public class Views_ShowGioHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShowGioHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GioHangs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThanhToan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
  
    Layout = "_Layout";
    float tong=0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
   /* .modal-header {
    align-items: center;
    display: flex;
    justify-content: space-between;
    border-bottom: 1px solid #aaaaaa;
    padding: 1rem;
  }
  
  h5.modal-title {
    font-size: 1.5rem;
  }
  
  .close {
    color: #aaaaaa;
    font-size: 28px;
    font-weight: bold;
    display: flex;
    flex-direction: row;
    justify-content: flex-end;
  }
  
  .close:hover,
  .close:focus {
    color: #000;
    text-decoration: none;
    cursor: pointer;
  }*/
   .modal-content {
    margin: 0 auto;
    width: 50%;
    position: relative;
    display: flex;
    flex-direction: column;
    background-color: #fff;
    background-clip: padding-box;
    border: 1px solid rgba(0, 0, 0, .2);
    border-radius: .3rem;
    outline: 0;
  
  }
  .modal-body {
    padding: 1rem;
  }
  
  .modal-footer {
    display: flex;
    border-top: 1px solid #aaaaaa;
    padding: 1rem;
    flex-direction: row;
    justify-content: flex-end;
    border-top: 1px s");
            WriteLiteral(@"olid #aaaaaa;
    padding: 1rem;
  }
  
  .modal-footer>:not(:first-child) {
    margin-left: .25rem;
  }
  #cart {
    font-size: 15px;
    color: #fff;
    background: #c7b200;
    border: 1px solid transparent;
    border-radius: 10px;
    outline: none;
    margin-left: 1rem;
    padding: 12px;
    cursor: pointer;
  }
  
  #cart:hover {
    border-color: #fff;
  }
  .cart-header {
    font-weight: bold;
    font-size: 1.25em;
    color: #333;
  }
  
  .cart-column {
    display: flex;
    align-items: center;
    border-bottom: 1px solid black;
    margin-right: 1.5em;
    padding-bottom: 10px;
    margin-top: 10px;
  }
  
  .cart-row {
    display: flex;
  }
  
  .cart-item {
    width: 45%;
  }
  
  .cart-price {
    width: 20%;
    font-size: 1.2em;
    color: #333;
  }
  
  .cart-quantity {
    width: 35%;
  }
  
  .cart-item-title {
    color: #333;
    margin-left: .5em;
    font-size: 1.2em;
  }
  
  .cart-item-image {
    width: 75px;");
            WriteLiteral(@"
    height: auto;
    border-radius: 10px;
  }
  
  .btn-danger {
    color: white;
    background-color: #EB5757;
    border: none;
    border-radius: .3em;
    font-weight: bold;
  }
  
  .btn-danger:hover {
    background-color: #CC4C4C;
  }
  
  .cart-quantity-input {
    height: 34px;
    width: 50px;
    border-radius: 5px;
    border: 1px solid #56CCF2;
    background-color: #eee;
    color: #333;
    padding: 0;
    text-align: center;
    font-size: 1.2em;
    margin-right: 25px;
  }
  
  .cart-row:last-child {
    border-bottom: 1px solid black;
  }
  
  .cart-row:last-child .cart-column {
    border: none;
  }
  
  .cart-total {
    text-align: end;
    margin-top: 10px;
    margin-right: 10px;
  }
  
  .cart-total-title {
    font-weight: bold;
    font-size: 1.5em;
    color: black;
    margin-right: 20px;
  }
  
  .cart-total-price {
    color: #333;
    font-size: 1.1em;
  }
  .cart-item-title {
    color: #333;
    margin-left: .5em;
  ");
            WriteLiteral("  font-size: 1.2em;\r\n  }\r\n</style>\r\n\r\n  <div class=\"text-center\">\r\n        ");
#nullable restore
#line 182 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
   Write(Html.Raw(TempData["checkout__alert--success"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n");
#nullable restore
#line 185 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
 if (ViewBag.cart != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""modal-content"">
        <div class=""modal-header"">
            <h5 class=""modal-title"">Giỏ Hàng</h5>
            <span class=""close"">&times;</span>
        </div>
        <div class=""modal-body"">
            <div class=""cart-row"">
                <span class=""cart-item cart-header cart-column"">Sản Phẩm</span>
                <span class=""cart-price cart-header cart-column"">Giá</span>
                <span class=""cart-quantity cart-header cart-column"">Số Lượng</span>
            </div>


            <div class=""cart-items"">

");
#nullable restore
#line 202 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
                 foreach (var item in ViewBag.cart)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 3951, "\"", 3959, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:43%;float:left\">");
#nullable restore
#line 204 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
                                                          Write(item.sp.TenSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 4041, "\"", 4049, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:36%;float:left\">");
#nullable restore
#line 205 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
                                                          Write(item.sp.GiaSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 4131, "\"", 4139, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:17%;float:left\">  ");
#nullable restore
#line 206 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
                                                            Write(item.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 207 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
                    // <span>@(int.Parse( item.sp.GiaSanPham )* item.SoLuong)</span> 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"width:4%;float:left\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22c077b6716793dc5a0da42221357b78ca5df0bd12286", async() => {
                WriteLiteral("X");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 208 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
                                                                                                           WriteLiteral(item.sp.MaSanPham);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</div>\r\n");
#nullable restore
#line 209 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"

                    // <span align="right" colspan="6">Sum</span>
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        


                        <div class=""cart-items"">

                        </div>
                        <div class=""cart-total"">
                            <strong class=""cart-total-title"">Tổng Cộng:</strong>
                            <span class=""cart-total-price"">");
#nullable restore
#line 222 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
                                                      Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"button\" class=\"btn btn-secondary close-footer\">Đóng</button>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22c077b6716793dc5a0da42221357b78ca5df0bd15898", async() => {
                WriteLiteral("Thanh Toán");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 231 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 233 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
 if(ViewBag.cart == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Không có sản phẩm nào trong giỏ</div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22c077b6716793dc5a0da42221357b78ca5df0bd17888", async() => {
                WriteLiteral("Tiếp tục mua sắm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 237 "E:\C4\ASM_past1\Ps18790_VoMinhChien_AsmGD2\demo\demo\Views\ShowGioHang\Index.cshtml"
}

    
                
           

             

#line default
#line hidden
#nullable disable
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
