#pragma checksum "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9014b6d36934fbd6ed298b494732703c40e1bb34"
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
#nullable restore
#line 1 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\_ViewImports.cshtml"
using WebCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\_ViewImports.cshtml"
using WebCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9014b6d36934fbd6ed298b494732703c40e1bb34", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea914b35850a00275709f524f4b0ae27c2788f89", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApiModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n");
            WriteLiteral("<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9014b6d36934fbd6ed298b494732703c40e1bb344550", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">

    <title>Stock Calculations</title>
    <link rel=""stylesheet"" href=""css/styles.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <link rel=""stylesheet"" href=""//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
    <link rel=""stylesheet"" href=""/resources/demos/style.css"">
    <script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
    <script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-cookie/1.4.1/jquery.cookie.js""></script>
    <style>
        .grid-container {
            display: grid;
            grid-template-columns: auto auto auto;
            padding: 10px;
            margin-top: 70px;
        }

        .grid-item {
            background-color: rgba(255, 255, 255, 0.8);
            border: 1px solid rgba(0, 0, 0, 0.8);
            padding: 20px;
            font-size: 30px;
            text-align: ");
                WriteLiteral(@"center;
        }
        body {
        }

        #slider-range {
            margin: 0 auto;
            margin-top: 200px;
            width: 2000px;
        }

        p {
            font-size: 20px;
        }

        #amount, #pstyle {
            border: none;
            text-align: center;
        }

        #mainDiv {
            border: 1px solid black;
            height: 100px;
            width: 500px;
            text-align: center;
            margin: 0 auto;
            margin-top: 30px;
        }

        #compare, #lockin {
            text-align: center;
            margin-top: 75px;
            margin-left: 600px;
            height: 65px;
            width: 165px;
        }
        #lockin {
            margin-left: 390px;
        }
        form, form * {
            display: inline-block;
        }
    </style>
    <script>
        $(function () {
            var multiple = 0;
            var upper = 1;
            var lower = 0;
       ");
                WriteLiteral(@"     $(""#slider-range"").slider({
                range: true,
                min: 0,
                max: 365,
                //values: [Cookies.get(""lowerInt""), Cookies.get(""upperInt"")],
                values: [$.cookie('lowerInt') || lower, $.cookie('upperInt') || upper],
                step: 1,
                slide: function (event, ui) {
                    console.log(""clicked button1"");
                    $(""#amount"").val("""" + ui.values[0] + "" - "" + ui.values[1]);
                    multiple = ui.values[1] - ui.values[0];
                    upper = ui.values[1];
                    lower = ui.values[0];
                    
                    $.cookie('upperInt', upper);
                    $.cookie('lowerInt', lower);
                    $(""#form"").attr(""action"", (""/"" + upper + ""/"" + lower));
                }
            });
            $(""#amount"").val("""" + $(""#slider-range"").slider(""values"", 0) +
                "" - "" + $(""#slider-range"").slider(""values"", 1));
         ");
                WriteLiteral(@"   
            $(""#lockin"").click(function () {
                console.log(multiple);
                $(""#slider-range"").slider({
                    step: multiple,
                    min: 0,
                    max: 3650,
                    slide: function (event, ui) {
                        $(""#amount"").val("""" + ui.values[0] + "" - "" + ui.values[1]);
                        $.cookie('upperInt', upper);
                        $.cookie('lowerInt', lower);
                    }
                });


            });
        });
        
        
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9014b6d36934fbd6ed298b494732703c40e1bb349356", async() => {
                WriteLiteral(@"
    <div id=""mainDiv"">
        <p style=""margin: 0 auto;"">Please select a range to compare from(recent - past)</p>
        <p><input type=""text"" id=""amount"" readonly style=""border:0; font-weight:bold;margin: 0 auto;""></p>
    </div>

    <div id=""slider-range""></div>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9014b6d36934fbd6ed298b494732703c40e1bb349905", async() => {
                    WriteLiteral("\r\n        <input type=\"submit\" id=\"compare\" class=\"btn btn-primary\" value=\"compare values\" />\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <button id=\"lockin\" class=\"btn btn-success\">Lock-In</button>\r\n\r\n\r\n    <div class=\"grid-container\">\r\n        <div class=\"grid-item\">");
#nullable restore
#line 134 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\Home\Index.cshtml"
                          Write(Model.IVE);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div class=\"grid-item\">");
#nullable restore
#line 135 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\Home\Index.cshtml"
                          Write(Model.IVV);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div class=\"grid-item\">");
#nullable restore
#line 136 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\Home\Index.cshtml"
                          Write(Model.IVW);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div class=\"grid-item\">");
#nullable restore
#line 137 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\Home\Index.cshtml"
                          Write(Model.IJJ);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div class=\"grid-item\">");
#nullable restore
#line 138 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\Home\Index.cshtml"
                          Write(Model.IJH);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div class=\"grid-item\">");
#nullable restore
#line 139 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\Home\Index.cshtml"
                          Write(Model.IJK);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div class=\"grid-item\">");
#nullable restore
#line 140 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\Home\Index.cshtml"
                          Write(Model.IWN);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div class=\"grid-item\">");
#nullable restore
#line 141 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\Home\Index.cshtml"
                          Write(Model.IWM);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div class=\"grid-item\">");
#nullable restore
#line 142 "C:\Users\kevin\Desktop\webstockcalculator\WebCalculator\Views\Home\Index.cshtml"
                          Write(Model.IWO);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApiModel> Html { get; private set; }
    }
}
#pragma warning restore 1591