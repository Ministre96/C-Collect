#pragma checksum "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\Shared\_DisplayCommand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afde08e5dcbcc78d912ef68ec3aa2c16e208d8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DisplayCommand), @"mvc.1.0.view", @"/Views/Shared/_DisplayCommand.cshtml")]
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
#line 1 "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\_ViewImports.cshtml"
using CC_Cyx_Vansnick;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\_ViewImports.cshtml"
using CC_Cyx_Vansnick.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afde08e5dcbcc78d912ef68ec3aa2c16e208d8f", @"/Views/Shared/_DisplayCommand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b7e771dd5d41d9e50ea8e15513a58532c1c43f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DisplayCommand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CC_Cyx_Vansnick.Models.POCO.Command>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<table style=\"border: 1px solid; width: 70%; margin:auto;\">\r\n");
#nullable restore
#line 5 "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\Shared\_DisplayCommand.cshtml"
      
        float somme = 0;
        foreach (var item in Model.Articles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 11 "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\Shared\_DisplayCommand.cshtml"
           Write(item.Key.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 14 "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\Shared\_DisplayCommand.cshtml"
           Write(item.Key.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €\r\n            </td>\r\n            <td>\r\n                x ");
#nullable restore
#line 17 "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\Shared\_DisplayCommand.cshtml"
             Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n\r\n            <td>\r\n");
#nullable restore
#line 22 "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\Shared\_DisplayCommand.cshtml"
                  
                    float temp = item.Key.Price * item.Value;
                    somme += temp;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 26 "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\Shared\_DisplayCommand.cshtml"
           Write(temp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\Shared\_DisplayCommand.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                Somme Total: ");
#nullable restore
#line 33 "C:\Users\bapti\source\repos\CC_Cyx_Vansnick\CC_Cyx_Vansnick\Views\Shared\_DisplayCommand.cshtml"
                        Write(somme);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €\r\n            </td>\r\n            \r\n        </tr>\r\n");
            WriteLiteral("    </table>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CC_Cyx_Vansnick.Models.POCO.Command> Html { get; private set; }
    }
}
#pragma warning restore 1591
