#pragma checksum "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\EditRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1a28c6c476ef81f4aa549eb3a98fcff18f4c08b"
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
#line 2 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\EditRoom.razor"
using DataClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\EditRoom.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\EditRoom.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\EditRoom.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit_room/{RoomId:int}")]
    public partial class EditRoom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\EditRoom.razor"
       
    [Parameter]
    public int RoomId { get; set; }

    private RoomModel roomModel = new RoomModel();
    private EditContext editContext;

    private Room RoomEdit { get; set; }

    protected override async Task OnInitializedAsync()
    {
        List<Room> rooms = await Http.GetFromJsonAsync<List<Room>>($"room?id={RoomId}");
        RoomEdit = rooms[0];
        roomModel.SetRoom(RoomEdit);
        editContext = new EditContext(roomModel);
    }

    private async Task HandleValidSubmit()
    {
        var isValid = editContext.Validate();

        if (isValid)
        {
            Console.WriteLine("IsValid\n");
            HttpResponseMessage rm = await Http.PutAsJsonAsync<Room>($"room?id={RoomId}", roomModel.GetRoom());
            try
            {
                rm.EnsureSuccessStatusCode();
                UriHelper.NavigateTo("room");
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

    private async Task DeleteRoom()
    {
        Console.WriteLine("DeleteRoom called\n");
        HttpResponseMessage rm = await Http.DeleteAsync($"room?id={RoomId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
