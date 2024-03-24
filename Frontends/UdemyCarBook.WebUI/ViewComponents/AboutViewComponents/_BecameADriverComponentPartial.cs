using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _BecameADriverComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
