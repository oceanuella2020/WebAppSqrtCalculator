#pragma checksum "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b66e3df3608d5dc7f0914fa4f12bbcf08e77134b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calcu_Sqrt), @"mvc.1.0.view", @"/Views/Calcu/Sqrt.cshtml")]
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
#line 1 "C:\Users\fatolu\WebAppSqrtCalculator\Views\_ViewImports.cshtml"
using WebAppSqrtCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatolu\WebAppSqrtCalculator\Views\_ViewImports.cshtml"
using WebAppSqrtCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b66e3df3608d5dc7f0914fa4f12bbcf08e77134b", @"/Views/Calcu/Sqrt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859bef620d502416790df9d469b7681a309a86ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Calcu_Sqrt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Calcu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sqrt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
  
    ViewData["Title"] = "SquareRoot Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">SquareRoot Calculator</h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
  
  if(ViewBag.numberOne==null&&ViewBag.numberTwo==null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <p></p>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
    }
    else if(ViewBag.numberOne!="firstNumber"&&ViewBag.numberTwo!="secondNumber")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <p>Error!!! This is a wrong input.</p>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
    }
    else if(ViewBag.result<ViewBag.result2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <p>The number ");
#nullable restore
#line 25 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
                     Write(ViewBag.numberTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with squareroot ");
#nullable restore
#line 25 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
                                                        Write(ViewBag.result2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has a higher squareroot than the number ");
#nullable restore
#line 25 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
                                                                                                                 Write(ViewBag.numberOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with ");
#nullable restore
#line 25 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
                                                                                                                                         Write(ViewBag.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
    }
    else if(ViewBag.result2<ViewBag.result)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div>\r\n            <p>The number ");
#nullable restore
#line 31 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
                     Write(ViewBag.numberOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with squareroot ");
#nullable restore
#line 31 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
                                                        Write(ViewBag.result);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has a higher squareroot than the number ");
#nullable restore
#line 31 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
                                                                                                                Write(ViewBag.numberTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with ");
#nullable restore
#line 31 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
                                                                                                                                        Write(ViewBag.result2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>  \r\n");
#nullable restore
#line 33 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
    }
    else if(ViewBag.result==ViewBag.result2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div>\r\n            <p>Your number ");
#nullable restore
#line 37 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
                      Write(ViewBag.numberOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and ");
#nullable restore
#line 37 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
                                             Write(ViewBag.numberTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" have the same squareroot. Enter another value. </p>\r\n        </div>  \r\n");
#nullable restore
#line 39 "C:\Users\fatolu\WebAppSqrtCalculator\Views\Calcu\Sqrt.cshtml"
    }
  

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n\r\n<div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b66e3df3608d5dc7f0914fa4f12bbcf08e77134b9029", async() => {
                WriteLiteral("\r\n\r\n<input type=\"text\" placeholder=\"First Number\" name=\"firstNumber\"/>\r\n<input type=\"test\" placeholder=\"Second Number\" name=\"secondNumber\"/>\r\n<button type=\"submit\">Submit</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
