#pragma checksum "C:\Users\Mateista\Desktop\mPloy-FinalProject_group5\FinalProject_ZPloy\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70f8f5aefe49fb9da0a5c3367b9548ec0f09ed72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProject_ZPloy.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace FinalProject_ZPloy.Pages
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
#line 1 "C:\Users\Mateista\Desktop\mPloy-FinalProject_group5\FinalProject_ZPloy\Pages\_ViewImports.cshtml"
using FinalProject_ZPloy;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f8f5aefe49fb9da0a5c3367b9548ec0f09ed72", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7516b472ec1797540435514bb7a910b4ca309389", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Mateista\Desktop\mPloy-FinalProject_group5\FinalProject_ZPloy\Pages\Index.cshtml"
   ViewData["Title"] = "Home page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70f8f5aefe49fb9da0a5c3367b9548ec0f09ed723273", async() => {
                WriteLiteral("\n\n\n\n\n\n");
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
            WriteLiteral(@"
<style>

    body {
        margin: 0px;
        padding-top: 20px;
    }

    .colour-block {
        background: #EBDCBC;
        padding: 7% 20% 10% 20%;
        color: #EBDCBC;
    }

    .white-block {
        background: #FFF1C5;
        padding: 7% 20% 10% 20%;
        color: #FFF1C5;
    }

    h1 {
        text-align: center;
        font-size: 80px;
        font-family: 'wire one', serif;
        font-weight: normal;
    }

    p {
        font-size: 20px;
        font-family: 'Raleway', serif;
    }

    .skew-cc {
        width: 100%;
        height: 100px;
        position: absolute;
        left: 0px;
        background: linear-gradient(to right bottom, #EBDCBC 49%, #FFF1C5 50%)
    }

    .skew-c {
        width: 100%;
        height: 100px;
        position: absolute;
        left: 0px;
        background: linear-gradient(to left bottom, #FFF1C5 49%, #EBDCBC 50%);
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70f8f5aefe49fb9da0a5c3367b9548ec0f09ed725154", async() => {
                WriteLiteral(@"

    <div class=""skew-c""></div>
    <div class=""colour-block"">
        <h1 style=""color:black"">
          mPloy - What is it about?
        </h1>
        <p style=""color:black"">
            Need help in furniture assembling? Or looking for someone to clean your appartment or take care of your garden? Or maybe you want to help others? ""Website name"" is exactly what you are looking for!</br>
            Hundreds of people are here and ready to help you with any kind of task and in any point of Copenhagen.
        </p>
    </div>
    <div class=""skew-cc""></div>
    <div class=""white-block"">
        <h1 style=""color:black"">How it works?</h1>
        <p style=""color:black"">
            If you are looking for someone to help you: Сreate a task and wait for application.</br> Approve. Enjoy.

        </p>
        <h1 style=""color:black"">Want to help others?</h1>
        <p style=""color:black"">
            Choose a task. Finish the task. And get paid.</br> Approve. Enjoy.
        </p>
    </div>
    <div class=""skew-");
                WriteLiteral(@"c""></div>
    <div class=""colour-block"">
        <h1 style=""color:black"">Skewed Clockwise.</h1>
        <p style=""color:black"">
            You need help?
            Hundreds of people are here and ready to help you with any kind of task in any point of Copenhagen.
            --How can we help you?
            (example : need a gartender)

            Describe what needs to be done
            Recieve applications with prices from Mployers
            Choose a Mployer and discuss the details
        </p>
    </div>


");
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
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591