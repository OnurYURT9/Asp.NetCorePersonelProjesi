#pragma checksum "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "648e2cf6f14d8f4753ccdcd945493cf74d7785d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
#line 1 "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
using ProjeCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"648e2cf6f14d8f4753ccdcd945493cf74d7785d4", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6887fc2a081498e457a98abd035f4ecf5faaf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Birim>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Birim</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
           Write(x.BirimID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
           Write(x.Birimad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 465, "\"", 500, 2);
            WriteAttributeValue("", 472, "/Default/BirimSil/", 472, 18, true);
#nullable restore
#line 23 "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
WriteAttributeValue("", 490, x.BirimID, 490, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 557, "\"", 594, 2);
            WriteAttributeValue("", 564, "/Default/BirimGetir/", 564, 20, true);
#nullable restore
#line 24 "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
WriteAttributeValue("", 584, x.BirimID, 584, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 657, "\"", 694, 2);
            WriteAttributeValue("", 664, "/Default/BirimDetay/", 664, 20, true);
#nullable restore
#line 25 "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
WriteAttributeValue("", 684, x.BirimID, 684, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Ali Güral Lojman\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/Default/YeniBirim/\" class=\"btn btn-primary\">Yeni Birim</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Birim>> Html { get; private set; }
    }
}
#pragma warning restore 1591
