#pragma checksum "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "709802d44a204a08683a5630e2fedce11b4d72fd"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
#line 10 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\_Imports.razor"
using DataClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\Login.razor"
using Client.Security;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Login</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\Login.razor"
                    LoginAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n\r\n    ");
                __builder2.AddMarkupContent(5, "<h2>Input your credentials:</h2>\r\n\r\n    ");
                __builder2.OpenElement(6, "p");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "label");
                __builder2.AddMarkupContent(9, "\r\n            Username:\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "id", "username");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\Login.razor"
                                                  Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Username = __value, Username))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "p");
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "label");
                __builder2.AddMarkupContent(21, "\r\n            Password:\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "password");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\Login.razor"
                                                  Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Password = __value, Password))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n    ");
                __builder2.AddMarkupContent(30, "<button type=\"submit\">Login</button>\r\n\r\n    ");
                __builder2.OpenElement(31, "p");
                __builder2.AddAttribute(32, "style", "color:red");
                __builder2.AddContent(33, 
#nullable restore
#line 28 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\Login.razor"
                          ErrorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\Login.razor"
       
    private string Username { get; set; }
    private string Password { get; set; }
    private string ErrorMessage { get; set; } = "";

    public async Task LoginAsync()
    {
        if (Username != null || Username == "")
        {
            ErrorMessage = "You must input username";
            Password = "";
            return;
        }

        if(Password != null || Password == "")
        {
            ErrorMessage = "You must input password";
            Password = "";
            return;
        }

        Console.WriteLine("Login called");

        string hashedPass = UserManager.HashPassword(Password);

        List<bool> signedIn = await Http.GetFromJsonAsync<List<bool>>($"user/login?username={Username}&password={hashedPass}");

        if (!signedIn[0])
        {
            ErrorMessage = "Could not log in";
            Password = "";
            return;
        }

        User.LoggedIn = true;
        if(signedIn[1] == true)
        {
            User.Access = UserManager.UserPrivilege.Admin;
        } else
        {
            User.Access = UserManager.UserPrivilege.User;
        }

        UriHelper.NavigateTo("schedule");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager User { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591