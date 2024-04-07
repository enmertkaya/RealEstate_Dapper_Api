using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.Home
{
    public class _DefaultBottomGridComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
