using Microsoft.AspNetCore.Components;
using WebApplication.ViewModels;

namespace WebApplication.Views
{
    public class SampleBase : ComponentBase
    {
        [Inject]
        public SampleViewModel ViewModel { get; set; }
    }
}
