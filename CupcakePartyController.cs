ÿusing Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CupcakePartyController : ControllerBase
    {
        [HttpPost(template:"CupCakes")]
        [Consumes("application/x-www-form-urlencoded")]
        public int CupcakeParty([FromForm] int RBox, [FromForm] int SBox)
        {
            /// <summary>
            /// The CupcakeParty method calculates the number of leftover cupcakes 
            /// after distributing them to students. It expects two form parameters:
            /// RBox (Regular boxes) and SBox (Special boxes), and it returns the
            /// remaining cupcakes after each student gets one.
            /// </summary>
            /// <param name="RBox">Number of regular cupcake boxes</param>
            /// <param name="SBox">Number of special cupcake boxes</param>
            /// <returns>The number of leftover cupcakes</returns>
            /// <remarks>
            /// Endpoint: POST api/CupcakeParty/CupCakes
            /// Description: Sends the number of regular and special cupcake boxes 
            /// to calculate the leftover cupcakes after distributing them among students.
            /// </remarks>

            int RBoxContains = 8;
            int SboxContaines = 3;
            int StudentsInClass = 28;


            int leftOvers = (((RBox * RBoxContains) + (SBox * SboxContaines)) - StudentsInClass);

            return leftOvers;
        }
    }
}
