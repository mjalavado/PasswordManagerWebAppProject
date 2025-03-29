using Microsoft.AspNetCore.Mvc;
using PassManagerAPI.Models;

namespace PassManagerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PasswordsController : ControllerBase
    {
        private static readonly List<Passwords> _pass = Passwords.GetCredentials();

        private readonly ILogger _logger;

        public PasswordsController(ILogger<PasswordsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPasswordsList")]
        public IEnumerable<Passwords> Get() => Passwords.GetCredentials();
    }
}
