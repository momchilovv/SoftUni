using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TaskBoardApp.Data;

namespace TaskBoardApp.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}