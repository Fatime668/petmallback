#pragma checksum "C:\Users\user\source\repos\Petmall\Petmall\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95cbfd4a21c232cce182c41725aa1ee73885586"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\user\source\repos\Petmall\Petmall\Views\_ViewImports.cshtml"
using Petmall.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95cbfd4a21c232cce182c41725aa1ee73885586", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e34cdec0fac6b7c09cc041d8a2c7acd5dfb7ce6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer style=""border-top: 1px solid rgb(183, 182, 182);"">
    <div class=""container"">
        <ul class=""d-flex list-unstyled justify-content-center m-5"">
            <li><a href=""#"">Home</a></li>
            <li class=""ms-5""><a href=""#"">Shop</a></li>
            <li class=""ms-5""><a href=""#"">Track Your Orders</a></li>
            <li class=""ms-5""><a href=""#"">About</a></li>
            <li class=""ms-5""><a href=""#"">Contact Us</a></li>
        </ul>
        <div class=""brands m-5"">
");
#nullable restore
#line 12 "C:\Users\user\source\repos\Petmall\Petmall\Views\Shared\Components\Footer\Default.cshtml"
             foreach (var item in Model.Settings)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 596, "\"", 613, 1);
#nullable restore
#line 14 "C:\Users\user\source\repos\Petmall\Petmall\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 602, item.Brand, 602, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 614, "\"", 620, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 15 "C:\Users\user\source\repos\Petmall\Petmall\Views\Shared\Components\Footer\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"text-center\" style=\"color:rgb(114, 111, 111) ; font-size: 14px;\">\r\n            Copyright © 2021\r\n            Vinovathemes. All rights\r\n            reserved.\r\n        </div>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
