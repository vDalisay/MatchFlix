#pragma checksum "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8572ea83a597711659313dbba1c4e34f9884a8b"
// <auto-generated/>
#pragma warning disable 1591
namespace MatchFlix_Frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using MatchFlix_Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using MatchFlix_Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using MatchFlix_Frontend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
using MatchFlix_Frontend.Components.IconSection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "carousel");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "containerTop");
            __builder.AddMarkupContent(4, "<div class=\"navbar\"><a>About</a>\r\n        <a>FAQ</a>\r\n        <a>Home</a></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "bannerbase");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "texts");
            __builder.AddMarkupContent(9, "<h1 id=\"bannertitle\">MatchFlix</h1>\r\n            ");
            __builder.OpenComponent<BlazorAnimate.Animate>(10);
            __builder.AddAttribute(11, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 17 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                Animations.FadeRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Easing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IEasing>(
#nullable restore
#line 17 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                              Easings.EaseInOutSine

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 17 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                                                               TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 17 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                                                                                               TimeSpan.FromSeconds(0.5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "IsManual", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                                                                                                                                    false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, "<h2 id=\"bannerslogan\">Match, Swipe, Watch</h2>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "matchbtn");
            __builder.OpenComponent<AntDesign.Button>(21);
            __builder.AddAttribute(22, "Shape", "round");
            __builder.AddAttribute(23, "id", "matchBtn");
            __builder.AddAttribute(24, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                         ToSwiping

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(26, "Match!");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenComponent<AntDesign.Carousel>(28);
            __builder.AddAttribute(29, "Autoplay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan>(
#nullable restore
#line 25 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                        TimeSpan.FromSeconds(5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.CarouselSlick>(31);
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(33, "<image src=\"/images/MOANA.JPG\"></image>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenComponent<AntDesign.CarouselSlick>(35);
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(37, "<image src=\"/images/OP.JPG\"></image>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<AntDesign.CarouselSlick>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(41, "<image src=\"/images/PB.JPG\"></image>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenComponent<AntDesign.CarouselSlick>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "<image src=\"/images/QB.JPG\"></image>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "iconSection");
            __builder.OpenComponent<AntDesign.Button>(49);
            __builder.AddAttribute(50, "Size", "large");
            __builder.AddAttribute(51, "Ghost", true);
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "<image src=\"/images/relationshipclr.png\"></image>\r\n        ");
                __builder2.AddMarkupContent(54, "<p class=\"iconText\">Match with friends and family</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.OpenComponent<AntDesign.Button>(56);
            __builder.AddAttribute(57, "Size", "large");
            __builder.AddAttribute(58, "Ghost", true);
            __builder.AddAttribute(59, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                        ToSwiping

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(61, "<image src=\"/images/swipeclr.png\"></image>\r\n        ");
                __builder2.AddMarkupContent(62, "<p class=\"iconText\">Swipe your favourite shows</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenComponent<AntDesign.Button>(64);
            __builder.AddAttribute(65, "Size", "large");
            __builder.AddAttribute(66, "Ghost", true);
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(68, "<image src=\"/images/watchingclr2.png\"></image>\r\n        ");
                __builder2.AddMarkupContent(69, "<p class=\"iconText\">Compare and watch your matched shows!</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "matchSection");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "hostBox");
            __builder.AddMarkupContent(75, "<h1>Host</h1>\r\n        ");
            __builder.OpenComponent<AntDesign.Search>(76);
            __builder.AddAttribute(77, "Placeholder", "Your Name");
            __builder.AddAttribute(78, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                               InputSize.Large

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "EnterButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.Boolean, System.String>>(
#nullable restore
#line 59 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                                               "Host"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "OnSearch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 59 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                                                                                          PostHostRoom

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(81, "Class", "joinInput");
            __builder.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                                                                      hostName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => hostName = __value, hostName))));
            __builder.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => hostName));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "joinBox");
            __builder.AddMarkupContent(88, "<h1>Join</h1>\r\n        ");
            __builder.OpenComponent<AntDesign.Search>(89);
            __builder.AddAttribute(90, "Placeholder", "Friend Code");
            __builder.AddAttribute(91, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                 InputSize.Large

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "EnterButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.Boolean, System.String>>(
#nullable restore
#line 63 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                                                 "Join"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "OnSearch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 63 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                                                                                                OnSearch

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(94, "Class", "joinInput");
            __builder.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
                                                                                                        txtJoinValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => txtJoinValue = __value, txtJoinValue))));
            __builder.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => txtJoinValue));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Index.razor"
      

    private string txtJoinValue { get; set; }
    private string hostName { get; set; }
    public string roomName { get; set; }

    private async Task PostHostRoom()
    {
        ReturnModel result = await Http.GetFromJsonAsync<ReturnModel>("https://localhost:5031/anime/host/" + hostName);
        ToHosting(result.name, result.roomName);
    }

    void ToHosting(string _hostName, string _roomName)
    {
        NavigationManager.NavigateTo("room" + "/" + _hostName + "/" + _roomName);
    }

    void ToSwiping()
    {
        NavigationManager.NavigateTo("swiping");
    }

    public async Task OnSearch()
    {
        await message.Loading($"Joining {txtJoinValue}", 2);
    }

    public class ReturnModel
    {
        public ReturnModel()
        {

        }
        public ReturnModel(string _name, string _roomName)
        {
            name = _name;
            roomName = _roomName;
        }
        public string name { get; set; }
        public string roomName { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService message { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
