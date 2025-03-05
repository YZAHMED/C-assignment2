ÿusing Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HarpTuningController : ControllerBase
    {
        [HttpGet(template:"HarpTuning")]

        public string HarpTuning(string inputFromQuery)
        {
            ///"AFB+8SC-4H-2GDPE+9";

            string input = inputFromQuery;
            string inputAlterd = "";
            string Segment = "";

            string message = "";

            List<String> WordListFromQuery = new List<string>();

            ///the below code taken the string and changes the - and + values to loosen and tighten
            ///also adds a white space back and forthe of the element and stores the string to a variable called alteredInput
           
            foreach(char c in input)
            {
                if( c == '-')
                {
                    inputAlterd += $" loosen ";
                } else if (c == '+')
                {
                    inputAlterd += $" tighten ";
                }else
                {
                    inputAlterd += c;
                }
            }
            
            
            ///This below loop takes the input altered string converts it into a list before the occurance of evey digit
            ///add the results to the list.
            
            foreach(Char c in inputAlterd)
            {
                if (Char.IsDigit(c)) 
                {
                    Segment += c;
                    WordListFromQuery.Add(Segment);
                    Segment = "";
                } else
                {
                    Segment += c;
                }
            }

            
            foreach (string word in WordListFromQuery)
            {
                message += word + "\n";
            }

         


            return message;
        }

    }
}
