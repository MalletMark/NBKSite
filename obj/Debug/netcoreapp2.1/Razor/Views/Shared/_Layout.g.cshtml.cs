#pragma checksum "C:\Projects\NBK\NBKSite\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "190ca4300a5a360bb33aff444f8efeac12c7c55a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"190ca4300a5a360bb33aff444f8efeac12c7c55a", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBKSite.Models.Home.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("58"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#navbar-main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(42, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(77, 1146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b1302fe621944d6ba2561299f5006e1", async() => {
                BeginContext(83, 1133, true);
                WriteLiteral(@"
  <meta charset=""utf-8"">
  <title>Natural Born Killers - A MapleStory 2 Guild</title>
  <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">
  <meta content="""" name=""keywords"">
  <meta content="""" name=""description"">

  <!-- Favicons -->
  <link href=""/img/favicon.png"" rel=""icon"">
  <link href=""/img/apple-touch-icon.png"" rel=""apple-touch-icon"">

  <!-- Google Fonts -->
  <link href=""https://fonts.googleapis.com/css?family=Open+Sans:Lato:300,400,700,300italic,400italic|Raleway:400,300,700"" rel=""stylesheet"">

  <!-- Bootstrap CSS File -->
  <link href=""/lib/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">

  <!-- Libraries CSS Files -->
  <link href=""/lib/icomoon/icomoon.css"" rel=""stylesheet"">

  <!-- Main Stylesheet File -->
  <link href=""/css/style.css"" rel=""stylesheet"">

  <!-- =======================================================
    Template Name: Shield
    Template URL: https://templatemag.com/shield-bootstrap-agency-template/
    Author: TemplateMag.com
 ");
                WriteLiteral("   License: https://templatemag.com/license/\r\n  ======================================================= -->\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1223, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1227, 2401, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a83bcefa8a74e69b10b7f5fdfd32034", async() => {
                BeginContext(1295, 716, true);
                WriteLiteral(@"


  <div id=""navbar-main"">
    <!-- Fixed navbar -->
    <div class=""navbar navbar-inverse navbar-fixed-top"">
      <div class=""container"">
        <div class=""navbar-header"">
          <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
            <span class=""icon icon-shield"" style=""font-size:30px; color:#3498db;""></span>
          </button>
          <a class=""navbar-brand hidden-xs hidden-sm smoothscroll"" href=""#home""><span class=""icon icon-shield"" style=""font-size:18px; color:#3498db;""></span></a>
        </div>
        <div class=""navbar-collapse collapse"">
          <ul class=""nav navbar-nav"">
            <li><a href=""/"">Home</a></li>
");
                EndContext();
#line 51 "C:\Projects\NBK\NBKSite\Views\Shared\_Layout.cshtml"
             if (Model.controllerName == "Index")
            {

#line default
#line hidden
                BeginContext(2077, 214, true);
                WriteLiteral("            <li><a href=\"#about\" class=\"smoothscroll home-only\" style=\"display: none;\"> About</a></li>\r\n            <li><a href=\"#services\" class=\"smoothscroll home-only\" style=\"display: none;\"> Services</a></li>\r\n");
                EndContext();
#line 55 "C:\Projects\NBK\NBKSite\Views\Shared\_Layout.cshtml"
            }

#line default
#line hidden
                BeginContext(2306, 337, true);
                WriteLiteral(@"            <li><a href=""/Home/BingoBook"">BingoBook</a></li>
            <li><a href=""/Home/TreasureList"">Treasure List</a></li>
            <li><a href=""/Home/Members"">Members</a></li>
            <li><a href=""/Home/Members"">Members</a></li>
        </div>
        <!--/.nav-collapse -->
      </div>
    </div>
  </div>

    ");
                EndContext();
                BeginContext(2644, 12, false);
#line 66 "C:\Projects\NBK\NBKSite\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2656, 965, true);
                WriteLiteral(@"

<div id=""copyrights"">
  <div class=""container"">
    <p>
      &copy; Copyrights <strong>Shield</strong>. All Rights Reserved
    </p>
    <div class=""credits"">
      <!--
        You are NOT allowed to delete the credit link to TemplateMag with free version.
        You can delete the credit link only if you bought the pro version.
        Buy the pro version with working PHP/AJAX contact form: https://templatemag.com/shield-bootstrap-agency-template/
        Licensing information: https://templatemag.com/license/
      -->
      Created with Shield template by <a href=""https://templatemag.com/"">TemplateMag</a>
    </div>
  </div>
</div>
<!-- / copyrights -->

<!-- JavaScript Libraries -->
<script src=""/lib/jquery/jquery.min.js""></script>
<script src=""/lib/bootstrap/js/bootstrap.min.js""></script>
<script src=""/lib/easing/easing.min.js""></script>

<!-- Template Main Javascript File -->
<script src=""/js/main.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3628, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBKSite.Models.Home.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
