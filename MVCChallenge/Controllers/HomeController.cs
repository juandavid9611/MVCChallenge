using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using MVCChallenge.Models;
using Newtonsoft.Json;

namespace MVCChallenge.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           return View();
        }

        [HttpPost]
        public IActionResult Index(DateTime dateBegin, DateTime dateEnd)
        {
            if (dateBegin > dateEnd)
                return View();
            DateTime defaultDate = new DateTime();
            List<Tuple<Item,Double>> result = new List<Tuple<Item, double>>();

            if (dateBegin == defaultDate && dateEnd == defaultDate)
            {
                dateBegin = new DateTime(DateTime.Now.Year, DateTime.Now.Month-1,1);
                dateEnd = dateBegin.AddDays(7);
            }
            result = ApiCall.call(dateBegin, dateEnd);
            return View(result);
        }


        public IActionResult Privacy()
        { 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
 
        public PartialViewResult GetQuery()
        {
            return PartialView("_query");
        }
    }

    public class ApiCall
    {
        public static List<Tuple<Item, double>> call(DateTime dateBegin, DateTime dateEnd)
        {
            List<Tuple<Item, double>> resList = new List<Tuple<Item, double>>();
            string begin = Convert.ToDateTime(dateBegin).ToString("yyyy-MM-dd");
            string end = Convert.ToDateTime(dateEnd).ToString("yyyy-MM-dd");
            System.Diagnostics.Debug.WriteLine("DateBegin: " + begin + "---------------------------------- DateEnd: " + end);
            string uri = "https://api.nasa.gov/neo/rest/v1/feed?start_date=" + begin + "&end_date=" + end+ "&detailed=false&api_key=cUqV7cuC5PYAx1afjZkyo2VFcb1jY12SMmkI4DHN";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-08&end_date=2015-09-09&detailed=false&api_key=cUqV7cuC5PYAx1afjZkyo2VFcb1jY12SMmkI4DHN");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var asteroid = JsonConvert.DeserializeObject<Rootobject>(json);

                foreach (KeyValuePair<string, Item[]> miItems in asteroid.near_earth_objects)
                {
                    foreach (Item item in miItems.Value)
                    {
                        resList.Add(new Tuple<Item, double>(item, item.DistanceCalculate()));
                    }
                }
                return (resList);
            }
        }
    }
}
