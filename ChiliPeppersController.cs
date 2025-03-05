ÿusing Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiliPeppersController : ControllerBase
    {
        [HttpGet(template: "ChiliPeppers")]

        public int ChiliPeppers(string Ingredients)
        {

            /// <summary>
            /// Endpoint to calculate the total heat level based on the provided chili pepper ingredients.
            /// </summary>
            /// <remarks>
            /// Example request: GET api/ChiliPeppers?Ingredients=Poblano,Mirasol,Serrano
            /// </remarks>
            /// <param name="Ingredients">Comma-separated list of chili pepper names</param>
            /// <returns>Total Scoville Heat Unit (SHU) of the provided chili peppers 23000</returns>

            int heatTotal = 0;

            string[] subs = Ingredients.Split(',');

            foreach (var sub in subs)
            {
                if (sub == "Poblano")
                {
                    heatTotal = heatTotal + 1500;
                }
                else if (sub == "Mirasol")
                {
                    heatTotal = heatTotal + 6000;
                }
                else if (sub == "Serrano")
                {
                    heatTotal = heatTotal + 15500;
                }
                else if (sub == "Cayenne")
                {
                    heatTotal = heatTotal + 40000;
                }
                else if (sub == "Thai")
                {
                    heatTotal = heatTotal + 75000;
                }
                else if (sub == "Habanero")
                {
                    heatTotal = heatTotal + 125000;
                }


                
            }
            return heatTotal;
        }
    }
}
