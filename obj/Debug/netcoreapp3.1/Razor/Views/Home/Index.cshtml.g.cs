#pragma checksum "C:\Users\Rahim\Desktop\dotNetCore_Apps\ArticlesApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cd0ce4dac34b68dff38b8a2e4477368084f95b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cd0ce4dac34b68dff38b8a2e4477368084f95b9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4544f42a03de5bac8fdd2d7fac86f98053b793b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArticlesApp.Models.Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Rahim\Desktop\dotNetCore_Apps\ArticlesApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main id=\"main\">\r\n        <section>\r\n\r\n            <h1>Trending Articles &#128293; </h1>\r\n\r\n            <div class=\"parent-of-articles\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Rahim\Desktop\dotNetCore_Apps\ArticlesApp\Views\Home\Index.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <article>\r\n                        <h2> ");
#nullable restore
#line 17 "C:\Users\Rahim\Desktop\dotNetCore_Apps\ArticlesApp\Views\Home\Index.cshtml"
                        Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                        <p>\r\n                            ");
#nullable restore
#line 19 "C:\Users\Rahim\Desktop\dotNetCore_Apps\ArticlesApp\Views\Home\Index.cshtml"
                       Write(item.body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <a class=\"btn\" href=\"#\">show more</a>\r\n                        </p>\r\n                    </article>\r\n");
#nullable restore
#line 23 "C:\Users\Rahim\Desktop\dotNetCore_Apps\ArticlesApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </section>\r\n\r\n    </main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArticlesApp.Models.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
