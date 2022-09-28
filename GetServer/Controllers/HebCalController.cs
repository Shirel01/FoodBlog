using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GetServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HebCalController : ControllerBase
    {
        // GET: api/<HebCalController>
        [HttpGet]
        public IEnumerable< string> Get()
        {
            /*נשלח פה את המיקום הנוכחי של האדם שעל זה נצטרך לקבל מידע
               למרות שזה לא משנה אם זה רק בארץ*/
            string city = "Haifa";

            HebCal.BL.HebCalLogic bl = new HebCal.BL.HebCalLogic();

            IEnumerable<string> answer = bl.IsHolidyWeek(city);//מחזיר את רשימת כל החגים הקרובים

            return answer; 
        }

        // GET api/<HebCalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HebCalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
