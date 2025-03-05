using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Deliv_e_droidController : ControllerBase
    {
        [HttpPost(template:"Deliv-e-droid")]
        [Consumes("application/x-www-form-urlencoded")]

        public int DeliveryDroid([FromForm]int Deliveries, [FromForm]int Collisions) {
            /// <summary>
            /// Calculates the total points for a delivery droid based on the number of deliveries and collisions.
            /// The method assigns 50 points per delivery and subtracts 10 points per collision. 
            /// If the number of deliveries exceeds the number of collisions, an additional 500 points is awarded.
            /// </summary>
            /// <param name="Deliveries">The number of deliveries made by the droid.</param>
            /// <param name="Collisions">The number of collisions the droid encountered.</param>
            /// <returns>Returns the total points for the droid, factoring in deliveries, collisions, and any bonuses.</returns>
            /// <example>
            /// POST /api/deliverydroid
            /// Body:
            /// {
            ///     "Deliveries": 10,
            ///     "Collisions": 2
            /// }
            /// Response:
            /// 480
            /// </example>



            int DeliveryPoints = Deliveries * 50;
            int CollisionPoints = -10 * Collisions;
           
            int TotalPoints = (DeliveryPoints + CollisionPoints);
            if (Deliveries > Collisions)
            {
                TotalPoints += 500;
            }

            return TotalPoints;
        }

        }
    }
