#pragma checksum "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74050140b868220c7bf96b9efb80e63630e4a1ea"
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
#line 2 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
using Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
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
            __builder.AddMarkupContent(0, "<h1>New Event</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
                  eventModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
                               eventModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n    ");
                __builder2.OpenElement(11, "p");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "label");
                __builder2.AddMarkupContent(14, "\r\n            Event Name:\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "eventName");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
                                                   eventModel.EventName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => eventModel.EventName = __value, eventModel.EventName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => eventModel.EventName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "p");
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "label");
                __builder2.AddMarkupContent(26, "\r\n            Event Category:\r\n            ");
                __Blazor.Client.Pages.NewEvent.TypeInference.CreateInputSelect_0(__builder2, 27, 28, "category", 29, 
#nullable restore
#line 22 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
                                                    eventModel.Category

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => eventModel.Category = __value, eventModel.Category)), 31, () => eventModel.Category, 32, (__builder3) => {
                    __builder3.AddMarkupContent(33, "\r\n                ");
                    __builder3.AddMarkupContent(34, "<option value>Select Category</option>\r\n                ");
                    __builder3.OpenElement(35, "option");
                    __builder3.AddAttribute(36, "value", "Educational");
                    __builder3.AddContent(37, 
#nullable restore
#line 24 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
                                             Event.CATEGORIES.Educational

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n                ");
                    __builder3.OpenElement(39, "option");
                    __builder3.AddAttribute(40, "value", "Entertainment");
                    __builder3.AddContent(41, 
#nullable restore
#line 25 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
                                               Event.CATEGORIES.Entertainment

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n            ");
                }
                );
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.OpenElement(46, "p");
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.OpenElement(48, "label");
                __builder2.AddMarkupContent(49, "\r\n            Maximum Accomidation:\r\n            ");
                __Blazor.Client.Pages.NewEvent.TypeInference.CreateInputNumber_1(__builder2, 50, 51, "accomidation", 52, 
#nullable restore
#line 32 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
                                                        eventModel.NumberOfSeats

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => eventModel.NumberOfSeats = __value, eventModel.NumberOfSeats)), 54, () => eventModel.NumberOfSeats);
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.OpenElement(58, "p");
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenElement(60, "label");
                __builder2.AddMarkupContent(61, "\r\n            Start time:\r\n            ");
                __Blazor.Client.Pages.NewEvent.TypeInference.CreateInputDate_2(__builder2, 62, 63, "startTime", 64, 
#nullable restore
#line 38 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
                                                   eventModel.StartTime

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => eventModel.StartTime = __value, eventModel.StartTime)), 66, () => eventModel.StartTime);
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenElement(70, "p");
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "label");
                __builder2.AddMarkupContent(73, "\r\n            End time:\r\n            ");
                __Blazor.Client.Pages.NewEvent.TypeInference.CreateInputDate_3(__builder2, 74, 75, "endTime", 76, 
#nullable restore
#line 44 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
                                                 eventModel.EndTime

#line default
#line hidden
#nullable disable
                , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => eventModel.EndTime = __value, eventModel.EndTime)), 78, () => eventModel.EndTime);
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n    ");
                __builder2.AddMarkupContent(82, "<button type=\"submit\">Submit</button>\r\n\r\n    <p id=\"errorMessage\"></p>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Bruger\Documents\GitHub\SEP3_Re\C# code\VIATalks\Client\Pages\NewEvent.razor"
       
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
namespace __Blazor.Client.Pages.NewEvent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
