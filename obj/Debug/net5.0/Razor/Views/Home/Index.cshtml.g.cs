#pragma checksum "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e27e0da70ca51ae16758c7a639ce28f1a15be181332dc4323c29bca55ac36559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e27e0da70ca51ae16758c7a639ce28f1a15be181332dc4323c29bca55ac36559", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1ab90e8470766233fccc8125bfca8455edb1ed725efd274e9e7669ed274bb2d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.FoodViewModel>
    #nullable disable
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
            WriteLiteral("\r\n<DOCTYPE! html>\r\n\t<html>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e27e0da70ca51ae16758c7a639ce28f1a15be181332dc4323c29bca55ac365593458", async() => {
                WriteLiteral("\r\n\t\t<title>\r\n\t\t\tFoodViewModel\r\n\t\t</title>\r\n\t");
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
            WriteLiteral("\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e27e0da70ca51ae16758c7a639ce28f1a15be181332dc4323c29bca55ac365594506", async() => {
                WriteLiteral("\r\n\r\n\t\t<div>\r\n\t\t\t<h4 style=\"color:chocolate\">HotMeal</h4>\r\n\t\t\t<hr style=\"border:2px solid chocolate\" />\r\n");
#nullable restore
#line 15 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
    foreach (var item in Model.Meals)
			{

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t\t\t<h5>Name: ");
                Write(
#nullable restore
#line 17 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               item.Name

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\r\n\t\t\t\t<h5>Type: ");
                Write(
#nullable restore
#line 18 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               item.FoodType

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\r\n\t\t\t\t<h5>Ingredients: </h5>\r\n\t\t\t\t<p>\r\n");
#nullable restore
#line 21 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
      foreach (var i in item.Ingredients)
					{

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t\t\t\t\t<span>");
                Write(
#nullable restore
#line 23 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
             i

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(",</span>\r\n");
#nullable restore
#line 24 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
					}

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t\t\t</p>\r\n");
                WriteLiteral("\t\t\t\t<h5>Price: ");
                Write(
#nullable restore
#line 27 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                item.Price

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("$</h5>\r\n\t\t\t\t<h5>Vegetarian: ");
                Write(
#nullable restore
#line 28 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                     item.IsVegetarian

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\r\n\t\t\t\t<hr style=\"border-color:chocolate\" />\r\n");
#nullable restore
#line 30 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
			}

#line default
#line hidden
#nullable disable

                WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<h4 style=\"color:brown\">FastFood</h4>\r\n\t\t\t<hr style=\"border:2px solid brown\" />\r\n");
#nullable restore
#line 36 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
    foreach (var item in Model.Foods)
			{

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t\t\t<h5>Name: ");
                Write(
#nullable restore
#line 38 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               item.Name

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\r\n\t\t\t\t<h5>Type: ");
                Write(
#nullable restore
#line 39 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               item.FoodType

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\r\n\t\t\t\t<h5>Ingredients: </h5>\r\n\t\t\t\t<p>\r\n");
#nullable restore
#line 42 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
      foreach (var i in item.Ingredients)
					{

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t\t\t\t\t<span>");
                Write(
#nullable restore
#line 44 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
             i

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(",</span>\r\n");
#nullable restore
#line 45 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
					}

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t\t\t</p>\r\n\t\t\t\t<h5>Price: ");
                Write(
#nullable restore
#line 47 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                item.Price

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("$</h5>\r\n\t\t\t\t<h5>Calories: ");
                Write(
#nullable restore
#line 48 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                   item.Calories

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\r\n\t\t\t\t<h5>Vegetarian: ");
                Write(
#nullable restore
#line 49 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                     item.IsVegetarian

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\r\n\t\t\t\t<hr style=\"border-color:brown\" />\r\n");
#nullable restore
#line 51 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
			}

#line default
#line hidden
#nullable disable

                WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<h4 style=\"color:deepskyblue\">Drink</h4>\r\n\t\t\t<hr style=\"border:2px solid deepskyblue\" />\r\n\r\n");
#nullable restore
#line 58 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
    foreach (var item in Model.Drinks)
			{

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t\t\t<h5>Name: ");
                Write(
#nullable restore
#line 60 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               item.Name

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\r\n\t\t\t\t<h5>Type: ");
                Write(
#nullable restore
#line 61 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               item.Type

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</h5>\r\n\t\t\t\t<h5>Price: ");
                Write(
#nullable restore
#line 62 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                item.Price

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("$</h5>\r\n\t\t\t\t<hr style=\"border-color:deepskyblue\" />\r\n");
#nullable restore
#line 64 "C:\Users\user\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
			}

#line default
#line hidden
#nullable disable

                WriteLiteral("\t\t</div>\r\n\r\n\t");
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
            WriteLiteral("\r\n</html>\r\n</DOCTYPE>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.FoodViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591