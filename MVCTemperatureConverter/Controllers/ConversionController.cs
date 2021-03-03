using MVCTemperatureConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTemperatureConverter.Controllers
{
    public class ConversionController : Controller
    {
        // GET: Conversion
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Conversion conversion)
        {
            double result = 0;
            string symbol = "";
            if (conversion.From == TemperatureUnit.Celsius && conversion.To == TemperatureUnit.Fahrenheith)
            {
                result = 1.8 * conversion.ToConvert + 32;
                symbol = "°F";
            }
            else if (conversion.From == TemperatureUnit.Fahrenheith && conversion.To == TemperatureUnit.Celsius)
            {
                result = (conversion.ToConvert - 32) / 1.8;
                symbol = "°C";
            }
            else if (conversion.From == TemperatureUnit.Celsius && conversion.To == TemperatureUnit.Kelvin)
            {
                result = conversion.ToConvert + 273.15;
                symbol = "°K";
            }
            else if (conversion.From == TemperatureUnit.Kelvin && conversion.To == TemperatureUnit.Celsius)
            {
                result = conversion.ToConvert - 273.15;
                symbol = "°C";
            }
            else if (conversion.From == TemperatureUnit.Fahrenheith && conversion.To == TemperatureUnit.Kelvin)
            {
                result = (conversion.ToConvert - 32) / 1.8 + 273.15;
                symbol = "°K";
            }
            else if (conversion.From == TemperatureUnit.Kelvin && conversion.To == TemperatureUnit.Fahrenheith)
            {
                result = (conversion.ToConvert - 273.15) * 1.8 + 32;
                symbol = "°F";
            }
            conversion.Result = string.Format("The conversion from {0} to {1} is : {2}{3}", conversion.From, conversion.To, result, symbol);
            return View(conversion);
        }
    }
}