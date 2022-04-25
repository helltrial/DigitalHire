namespace DigitalHire.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// AuthorizeController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizeController : Controller
    {
        /// <summary>
        /// Test
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string TestMethod()
        {
            return "Hello";
??
        }
    }
}