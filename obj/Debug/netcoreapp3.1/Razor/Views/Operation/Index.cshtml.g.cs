#pragma checksum "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\Operation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843c5e2612db8468a76383c47bc63420f395066f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operation_Index), @"mvc.1.0.view", @"/Views/Operation/Index.cshtml")]
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
#line 1 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\_ViewImports.cshtml"
using ASP.NET_Core依赖注入_DI_讲解;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\_ViewImports.cshtml"
using ASP.NET_Core依赖注入_DI_讲解.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843c5e2612db8468a76383c47bc63420f395066f", @"/Views/Operation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"359c47b84b6ad81f7a3042f58dc5508c8e929665", @"/Views/_ViewImports.cshtml")]
    public class Views_Operation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\Operation\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div>\r\n    <h1>\r\n        Controller Operations\r\n    </h1>\r\n\r\n    <h2> OperationTransient: ");
#nullable restore
#line 12 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\Operation\Index.cshtml"
                        Write(ViewBag.OperationTransient.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h2> OperationScoped: ");
#nullable restore
#line 14 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\Operation\Index.cshtml"
                     Write(ViewBag.OperationScoped.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h2> OperationSingleton: ");
#nullable restore
#line 16 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\Operation\Index.cshtml"
                        Write(ViewBag.OperationSingleton.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h2> OperationInstance: ");
#nullable restore
#line 18 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\Operation\Index.cshtml"
                       Write(ViewBag.OperationInstance.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n<div>\r\n\r\n    <h1> Services Operations </h1>\r\n\r\n    <h2> OperationTransient: ");
#nullable restore
#line 24 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\Operation\Index.cshtml"
                        Write(ViewBag._operationServices.OperationTransient.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h2> OperationScoped: ");
#nullable restore
#line 26 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\Operation\Index.cshtml"
                     Write(ViewBag._operationServices.OperationScoped.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h2> OperationSingleton: ");
#nullable restore
#line 28 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\Operation\Index.cshtml"
                        Write(ViewBag._operationServices.OperationSingleton.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h2> OperationInstance: ");
#nullable restore
#line 30 "G:\项目\学习\录视频\Chapter1\ConsoleApp1\ASP.NET Core依赖注入(DI)讲解\Views\Operation\Index.cshtml"
                       Write(ViewBag._operationServices.OperationInstance.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n");
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
