﻿using System;
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
        
        public IActionResult Index(DateTime dateBegin, DateTime dateEnd)
        {
            DateTime defaultDate = new DateTime();
            System.Diagnostics.Debug.WriteLine("Fecha: " + dateBegin + "----------------------------------");
            List<Item> result = new List<Item>();
            
            if(dateBegin != defaultDate && dateEnd != defaultDate)
            {
                result = ApiCall.call(dateBegin, dateEnd);
            }
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
    }

    public class ApiCall
    {
        public static List<Item> call(DateTime dateBegin, DateTime dateEnd)
        {
            List<Item> resultList = new List<Item>();
            string begin = Convert.ToDateTime(dateBegin).ToString("yyyy-MM-dd");
            string end = Convert.ToDateTime(dateEnd).ToString("yyyy-MM-dd");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-08&end_date=2015-09-09&detailed=false&api_key=cUqV7cuC5PYAx1afjZkyo2VFcb1jY12SMmkI4DHN");
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
                        resultList.Add(item);
                    }
                }
                return (resultList);
            }
        }
    }
}
