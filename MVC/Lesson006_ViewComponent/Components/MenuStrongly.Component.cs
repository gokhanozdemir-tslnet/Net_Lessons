using Microsoft.AspNetCore.Mvc;

namespace Lesson006_ViewComponent.Components
{
    public class MenuStrongly : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<string> menus = new List<string> {
                "Home St",
                "Contact St",
                "About Us St"
            };
            return View("MenuStrongly", menus);
        }
    }
}
