using Pronia.ViewModels.Categories;
using Pronia.ViewModels.Products;
using Pronia.ViewModels.Sliders;

namespace Pronia.ViewModels.Defaults
{
    public class HomeVM
    {
        public IEnumerable<GetSliderVM> Sliders{ get; set; }
        public IEnumerable<GetCategoryVM> Categories{ get; set; }
    }
}
