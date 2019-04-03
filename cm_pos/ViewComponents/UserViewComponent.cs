using System.Threading.Tasks;
using cm_pos.services;
using Microsoft.AspNetCore.Mvc;

namespace cm_pos.ViewComponents
{
    public class UserViewComponent : ViewComponent
    {
        private readonly ProductService ProductService;

        public UserViewComponent(ProductService ProductService)
        {
            this.ProductService = ProductService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = ProductService.GetCategories();

            return View("user", result);  //default.cshtml
        }
    }
}