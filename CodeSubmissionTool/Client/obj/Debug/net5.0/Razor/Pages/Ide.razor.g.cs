#pragma checksum "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\Pages\Ide.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23908c5919322c23d0793b25d90b5a48dbc46be2"
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
#line 1 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\_Imports.razor"
using CodeSubmissionTool.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\_Imports.razor"
using CodeSubmissionTool.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\Pages\Ide.razor"
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
            __builder.AddMarkupContent(0, "<style>\r\n\r\n    .ide-container {\r\n        width: 100%;\r\n        height: 90%;\r\n        max-height: 900px;\r\n        margin: auto;\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n        background: #134b5f;\r\n        padding: 15px;\r\n        font-family: monospace;\r\n        border-radius: 5px;\r\n    }\r\n\r\n\r\n    .ide-wrapper {\r\n        height: 100%;\r\n        width: 60%;\r\n        padding: 10px;\r\n    }\r\n\r\n    .output-container {\r\n        height: 100%;\r\n        width: 40%;\r\n        padding: 10px;\r\n    }\r\n\r\n    .ide {\r\n        width: 100%;\r\n        height: 65%;\r\n        padding: 5px;\r\n        display: flex;\r\n        flex-direction: column;\r\n    }\r\n\r\n    .button-container {\r\n        width: 100%;\r\n        height: 5%;\r\n        display: flex;\r\n        justify-content: flex-end;\r\n        align-items: center;\r\n        padding: 10px 5px 10px 0px;\r\n    }\r\n\r\n    .question-container {\r\n        width: 100%;\r\n        height: 30%;\r\n        padding: 5px;\r\n    }\r\n\r\n    .output, .question {\r\n        width: 100%;\r\n        height: 100%;\r\n        background: #fff;\r\n        border-radius: 5px;\r\n        padding: 20px;\r\n        text-align: justify;\r\n    }\r\n\r\n    .control-panel {\r\n        width: 100%;\r\n        height: 10%;\r\n        background: #2187ab;\r\n        padding: 10px;\r\n        display: flex;\r\n        justify-content: space-between;\r\n        align-items: center;\r\n        margin-bottom: 5px;\r\n        color: #fff;\r\n        border-radius: 5px;\r\n    }\r\n\r\n    .editor {\r\n        width: 100%;\r\n        height: 90%;\r\n        border-radius: 5px;\r\n    }\r\n    \r\n\r\n</style>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Nebula - Testing Environment</h1>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "ide-container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "ide-wrapper");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "ide");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "control-panel");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "language");
            __builder.AddMarkupContent(12, "\r\n                    Select Language:\r\n                    &nbsp;\r\n                    ");
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "id", "languages");
            __builder.AddAttribute(15, "class", "language");
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\Pages\Ide.razor"
                                                                       changeLanguage

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", "python");
            __builder.AddContent(19, "Python");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", "cpp");
            __builder.AddContent(23, "C++");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "csharp");
            __builder.AddContent(27, "C#");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "java");
            __builder.AddContent(31, "Java");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "sql");
            __builder.AddContent(35, "SQL");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", "javascript");
            __builder.AddContent(39, "JavaScript");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n                ");
            __builder.AddMarkupContent(41, "<span>&nbsp; Timer: 00:00:00</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n            <div class=\"editor\" id=\"editor\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "button-container");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-success btn-sm");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 127 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\Pages\Ide.razor"
                                                             executeCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Run");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "question-container");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "question");
#nullable restore
#line 134 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\Pages\Ide.razor"
                 if (question != null)
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, 
#nullable restore
#line 136 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\Pages\Ide.razor"
                     question.Description

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 136 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\Pages\Ide.razor"
                                         ;
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n    ");
            __builder.AddMarkupContent(57, "<div class=\"output-container\"><div class=\"output\"></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 152 "C:\Users\Ashton\OneDrive - Nebula\course-work\online-code-submission-tool\CodeSubmissionTool\Client\Pages\Ide.razor"
       

    Test test = new Test();
    Question question;

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

        //change hard coded language value
        test.Language = "Python3.0";
        await HttpClient.PostAsJsonAsync("api/tests", test);
        NavigationManager.NavigateTo("/result");

    }


    protected async override Task OnInitializedAsync()
    {
        IList<Question> questions = await HttpClient.GetFromJsonAsync<IList<Question>>("api/questions");
        int idx = new Random().Next(0, questions.Count);
        question = questions[idx];
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
