// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
