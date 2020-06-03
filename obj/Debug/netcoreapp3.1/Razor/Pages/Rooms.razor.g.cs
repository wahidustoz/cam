#pragma checksum "/Users/david/repos/cam/Pages/Rooms.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31b108b115b208dde26cc1fd391ceabe95daa0ba"
// <auto-generated/>
#pragma warning disable 1591
namespace cam.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/david/repos/cam/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/david/repos/cam/_Imports.razor"
using cam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/david/repos/cam/_Imports.razor"
using cam.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/david/repos/cam/Pages/Rooms.razor"
using cam.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/david/repos/cam/Pages/Rooms.razor"
using cam.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rooms")]
    public partial class Rooms : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "page-body");
            __builder.AddMarkupContent(2, "\n");
#nullable restore
#line 11 "/Users/david/repos/cam/Pages/Rooms.razor"
     foreach(var room in rooms)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-fluid");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenElement(7, "h2");
            __builder.AddAttribute(8, "class", "title-1");
            __builder.AddContent(9, 
#nullable restore
#line 14 "/Users/david/repos/cam/Pages/Rooms.razor"
                                 room.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n\n            ");
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "list");
            __builder.AddMarkupContent(13, "\n");
#nullable restore
#line 17 "/Users/david/repos/cam/Pages/Rooms.razor"
                 if(room.Classes != null)
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/david/repos/cam/Pages/Rooms.razor"
                     foreach(var c in room.Classes)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                        ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "list-item");
            __builder.AddMarkupContent(17, "\n                            ");
            __builder.AddContent(18, 
#nullable restore
#line 21 "/Users/david/repos/cam/Pages/Rooms.razor"
                             c.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, " - ");
            __builder.OpenElement(20, "label");
            __builder.AddAttribute(21, "class", "label-1");
            __builder.AddContent(22, 
#nullable restore
#line 21 "/Users/david/repos/cam/Pages/Rooms.razor"
                                                              c.Time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
#nullable restore
#line 23 "/Users/david/repos/cam/Pages/Rooms.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n\n            ");
            __builder.OpenElement(27, "label");
            __builder.AddAttribute(28, "class", "label-1");
            __builder.AddContent(29, "Supervisor - ");
            __builder.AddContent(30, 
#nullable restore
#line 26 "/Users/david/repos/cam/Pages/Rooms.razor"
                                                  room.SupervisorUserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#nullable restore
#line 28 "/Users/david/repos/cam/Pages/Rooms.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card-fluid");
            __builder.AddMarkupContent(36, "\n        ");
            __builder.AddMarkupContent(37, "<h2 class=\"title-1\">Add Room</h2>\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(38);
            __builder.AddAttribute(39, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "/Users/david/repos/cam/Pages/Rooms.razor"
                          room

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 31 "/Users/david/repos/cam/Pages/Rooms.razor"
                                               SaveRoom

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(42, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(43);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(45);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\n        ");
                __builder2.AddMarkupContent(47, "<label class=\"label-1\" for=\"name\">Room name<small>*</small></label>\n        ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "id", "name");
                __builder2.AddAttribute(51, "required", true);
                __builder2.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "/Users/david/repos/cam/Pages/Rooms.razor"
                                                     room.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.Name = __value, room.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n        ");
                __builder2.AddMarkupContent(55, "<label class=\"label-1\" for=\"supervisor\">Supervisor<small>*</small></label>\n        ");
                __builder2.OpenElement(56, "select");
                __builder2.AddAttribute(57, "type", "text");
                __builder2.AddAttribute(58, "id", "supervisor");
                __builder2.AddAttribute(59, "required", true);
                __builder2.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "/Users/david/repos/cam/Pages/Rooms.razor"
                                                            room.SupervisorUserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.SupervisorUserName = __value, room.SupervisorUserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(62, "\n            ");
                __builder2.OpenElement(63, "option");
                __builder2.AddAttribute(64, "value", true);
                __builder2.AddContent(65, "Select...");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n");
#nullable restore
#line 39 "/Users/david/repos/cam/Pages/Rooms.razor"
             foreach (var teacher in teachers)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(67, "                ");
                __builder2.OpenElement(68, "option");
                __builder2.AddAttribute(69, "value", 
#nullable restore
#line 41 "/Users/david/repos/cam/Pages/Rooms.razor"
                               teacher.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(70, 
#nullable restore
#line 41 "/Users/david/repos/cam/Pages/Rooms.razor"
                                                 teacher.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n");
#nullable restore
#line 42 "/Users/david/repos/cam/Pages/Rooms.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(72, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n        ");
                __builder2.AddMarkupContent(74, "<button type=\"submit\" class=\"submit-btn\">\n                Add\n        </button>\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "/Users/david/repos/cam/Pages/Rooms.razor"
 
    List<Room> rooms = new List<Room>();
    List<Data.AppUser> teachers = new List<Data.AppUser>();
    List<Class> classes = new List<Class>();

    Room room = new Room();

    protected override async Task OnInitializedAsync()
    {
        rooms = await roomRepo.Get();
        foreach (var room in rooms)
        {   
            room.Classes = await classRepo.GetForRoom(room.Id);
        }
        StateHasChanged();
        teachers = await userRepo.Get();
        StateHasChanged();
    }

    private async void SaveRoom()
    {
        await roomRepo.Insert(room);
        rooms = await roomRepo.Get();
        room = new Room();
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassService classRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoomService roomRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
