using Microsoft.AspNetCore.Mvc;

namespace SquareColorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SquareController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> squares = new List<string>();
            for(int i = 1; i <= 50; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    squares.Add("<div style='background-color: yellow; width: 50px; height: 50px; display: inline-block;'>" + i + "</div>");
                }
                else if(i % 3 == 0)
                {
                    squares.Add("<div style='background-color: green; width: 50px; height: 50px; display: inline-block;'>" + i + "</div>");
                }
                else if(i % 5 == 0)
                {
                    squares.Add("<div style='background-color: blue; width: 50px; height: 50px; display: inline-block;'>" + i + "</div>");
                }
                else
                {
                    squares.Add("<div style='background-color: white; width: 50px; height: 50px; display: inline-block;'>" + i + "</div>");
                }
            }
            return squares;
        }
    }
}
