#pragma checksum "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Ide.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "354729bef0bbfd2133437ab9a65f5df664f4ca5b"
// <auto-generated/>
#pragma warning disable 1591
namespace CodeSubmissionTool.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\_Imports.razor"
using CodeSubmissionTool.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\_Imports.razor"
using CodeSubmissionTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Ide.razor"
using CodeSubmissionTool.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ide")]
    public partial class Ide : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "ide-container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "ide-wrapper");
            __builder.AddMarkupContent(4, "<div class=\"header\">Online IDE</div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "control-panel");
            __builder.AddMarkupContent(7, "\r\n    \r\n            Select Language:\r\n            &nbsp; &nbsp;\r\n            ");
            __builder.OpenElement(8, "select");
            __builder.AddAttribute(9, "id", "languages");
            __builder.AddAttribute(10, "class", "language");
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Ide.razor"
                                                               changeLanguage

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(12, "option");
            __builder.AddAttribute(13, "value", "python");
            __builder.AddContent(14, "Python");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "cpp");
            __builder.AddContent(18, "C++");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "csharp");
            __builder.AddContent(22, "C#");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "java");
            __builder.AddContent(26, "Java");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "sql");
            __builder.AddContent(30, "SQL");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "javascript");
            __builder.AddContent(34, "JavaScript");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n        <div class=\"editor\" id=\"editor\"></div>\r\n\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "button-container");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Ide.razor"
                                          executeCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Run");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        <div class=\"output\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Ide.razor"
       

    Test test = new Test();

    private async Task changeLanguage(ChangeEventArgs e)
    {

        await JsRuntime.InvokeVoidAsync("changeLanguage");

    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JsRuntime.InvokeVoidAsync("showEditor");
        }

    }


    private async Task executeCode()
    {
        test.Code = await JsRuntime.InvokeAsync<string>("getCode");
        test.Language = "Python3.0";
        await HttpClient.PostAsJsonAsync("api/tests", test);
        NavigationManager.NavigateTo("/result");

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
