// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MudBlazorCrudST.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\_Imports.razor"
using MudBlazorCrudST;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\_Imports.razor"
using MudBlazorCrudST.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\Pages\AnimalSelected.razor"
using MudBlazorCrudST.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/animalsSelected")]
    public partial class AnimalSelected : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\OmarG\source\repos\MudBlazorCrudST\MudBlazorCrudST\Pages\AnimalSelected.razor"
       
	private bool _dense = false;
	private bool _multiSelect = true;
	private bool _virtualize = false;

	private HashSet<Animal> animals = new HashSet<Animal>();

	private TableGroupDefinition<Animal> _groupDefinition = new()
	{
		GroupName = "Group",
		Indentation = false,
		Expandable = false,
		Selector = (e) => e.Group
	};

	private IEnumerable<Animal> Animals = new List<Animal>();

	protected override async Task OnInitializedAsync()
	{
		Animals = GetAnimals();
	}

	private HashSet<Animal> GetAnimals()
	{
		animals = animalService.GetAnimals();
		return animals;
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazorCrudST.IService.IAnimalService animalService { get; set; }
    }
}
#pragma warning restore 1591