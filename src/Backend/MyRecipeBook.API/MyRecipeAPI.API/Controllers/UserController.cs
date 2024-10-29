using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeAPI.API.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{
	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
	public IActionResult Register(RequestRegisterUserJson request)
	{
		return Created();
	}
}
