using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompetitionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BronzeCountController : ControllerBase
    {
        /// <summary>
        /// Determines the score required for the bronze level and how many participants achieved this score.
        /// </summary>
        /// <param name="scores">A list of participant scores.</param>
        /// <returns>A tuple containing the bronze level score and the number of participants who achieved it.</returns>
        /// <example>
        /// [71, 63, 54, 79]
        /// 1. Sort the scores in descending order: [73, 70, 62, 58]
        /// 2. The third distinct score is the bronze level score: 62
        /// 3. Count how many participants have the bronze score: 1
        ///
        /// Output:
        /// { "BronzeScore": 62, "Count": 1 }
        /// </example>
        [HttpPost("calculate-bronze")]
        public IActionResult CalculateBronze([FromBody] List<int> scores)
        {
            // Validate input
            if (!IsValidScoreList(scores, out var distinctScores))
            {
                return BadRequest("There must be at least three distinct scores.");
            }

            // Find the bronze score and count occurrences
            var (bronzeScore, bronzeCount) = GetBronzeScoreAndCount(scores, distinctScores);

            // Return the result
            return Ok(new { BronzeScore = bronzeScore, Count = bronzeCount });
        }

        /// <summary>
        /// Validates the list of scores and extracts distinct scores.
        /// </summary>
        private bool IsValidScoreList(List<int> scores, out List<int> distinctScores)
        {
            distinctScores = scores.Distinct().ToList();
            return distinctScores.Count >= 3;
        }

        /// <summary>
        /// Finds the bronze score and counts how many participants achieved it.
        /// </summary>
        private (int bronzeScore, int bronzeCount) GetBronzeScoreAndCount(List<int> scores, List<int> distinctScores)
        {
            // Sort the distinct scores in descending order
            distinctScores.Sort((a, b) => b.CompareTo(a)); // Sorting in descending order

            // The third distinct score is the bronze level score
            int bronzeScore = distinctScores[2];

            // Count how many participants achieved the bronze score
            int bronzeCount = scores.Count(score => score == bronzeScore);

            return (bronzeScore, bronzeCount);
        }
    }
}