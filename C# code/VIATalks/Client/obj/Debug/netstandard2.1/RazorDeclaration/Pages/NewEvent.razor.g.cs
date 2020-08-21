#pragma checksum "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\Pages\NewEvent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74050140b868220c7bf96b9efb80e63630e4a1ea"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\_Imports.razor"
using DataClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\Pages\NewEvent.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\Pages\NewEvent.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/new_event")]
    public partial class NewEvent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\kenne\Documents\GitHub\SEP3-Re-Examination\C# code\VIATalks\Client\Pages\NewEvent.razor"
       
    private EventModel eventModel = new EventModel();
    private EditContext editContext;

    protected override void OnInitialized()
    {
        editContext = new EditContext(eventModel);
        eventModel.Host = new Event.EventHost(
            "Kenneth",
            "Jensen",
            "123@abc.com",
            "12345678");
    }

    private async Task HandleValidSubmit()
    {
        var isValid = editContext.Validate();

        if (isValid)
        {
            Console.WriteLine("IsValid\n");
            HttpResponseMessage rm = await Http.PostAsJsonAsync<Event>("event", eventModel.GetEvent());
            try
            {
                rm.EnsureSuccessStatusCode();
                UriHelper.NavigateTo("schedule");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
                // Display error
            }
        }
        else
        {
            Console.WriteLine("IsNotValid");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
