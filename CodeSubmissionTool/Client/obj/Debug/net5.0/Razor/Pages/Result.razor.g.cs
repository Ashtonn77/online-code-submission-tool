#pragma checksum "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef013bea4b5cb6637995940eb2174ffb7e822ffe"
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
#line 2 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor"
using CodeSubmissionTool.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/result")]
    public partial class Result : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor"
 if (submission == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3 class=\"mt-5\">Loading results ...</h3>");
#nullable restore
#line 9 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3 class=\"mt-5\">Code Submitted</h3>");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-dark mt-5");
            __builder.AddMarkupContent(4, "<thead><tr><th scope=\"col\">#</th>\r\n                <th scope=\"col\">Output</th>\r\n                <th scope=\"col\">Result</th></tr></thead>\r\n\r\n        ");
            __builder.OpenElement(5, "tbody");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th scope=\"row\">1</th>");
#nullable restore
#line 28 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor"
             if (submission != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 30 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor"
                     submission.Output

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 31 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor"
                     submission.Result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\ashto\Documents\LanguangeSpecific\dotnet\ASP.NET\blazor\CodeSubmissionTool\CodeSubmissionTool\Client\Pages\Result.razor"
       

    Submission submission;

    protected async override Task OnInitializedAsync()
    {
        submission = await HttpClient.GetFromJsonAsync<Submission>("api/submissions/1");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591