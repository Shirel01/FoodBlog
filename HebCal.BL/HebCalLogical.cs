using HebCal.DP;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace HebCal.BL
{
    public class HebCalLogic
    {

        public IEnumerable<string> IsHolidyWeek(string City)
        {
           List<string> HolidayList =new List<string>();

            DAL.HebCalAdapter dal = new DAL.HebCalAdapter();

            Root myHolyday = null;

            string myJson = dal.GetComingWeek(City);
            if (myJson != null)
            {
                myHolyday = JsonConvert.DeserializeObject<Root>(myJson);
            }

            foreach (var item in myHolyday.items)
            {
                if (item.category == "holiday")
                {
                    string holiday = item.hebrew;

                    HolidayList.Add(holiday);//רשימה של כל החגים הקרובים

                }
            }
            return HolidayList;


        }
    }
}