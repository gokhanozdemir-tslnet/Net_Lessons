using Microsoft.AspNetCore.Mvc;

namespace Lesson006_ViewComponent.Components
{
    public class MenuStrongly : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("MenuStrongly");
        }
    }
}
