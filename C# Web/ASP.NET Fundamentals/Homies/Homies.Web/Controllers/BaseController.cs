using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Homies.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}