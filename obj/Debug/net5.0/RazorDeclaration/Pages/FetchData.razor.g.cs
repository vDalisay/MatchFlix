// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MatchFlix_Frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using MatchFlix_Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using MatchFlix_Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\Pages\FetchData.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\Pages\FetchData.razor"
       
    private ShowDTO[] dataSet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\Pages\FetchData.razor"
                                                                                                               

    private async Task LoadData(string dataURL)
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\Pages\FetchData.razor"
                           
        dataSet = await Http.GetFromJsonAsync<ShowDTO[]>(dataURL); //Todo: Replace with dynamic URL
    }

    public class ShowDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Media_type { get; set; }
        public string Description { get; set; }
        public string Release_date { get; set; }
        public string Image_url { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
