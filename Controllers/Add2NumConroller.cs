using Microsoft.AspNetCore.Mvc;

namespace SpacekKMCAdd2Nums.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2NumConroller : ControllerBase
    {
        [HttpGet]
        [Route("Add/{num1}/{num2}")]
        public string add(int num1, int num2)
        {
            return $"{num1} added to {num2} equals {num1 + num2}.";
        }
    }
}