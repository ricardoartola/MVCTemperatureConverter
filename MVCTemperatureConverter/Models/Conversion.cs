using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTemperatureConverter.Models
{
    public class Conversion
    {
        public TemperatureUnit From { get; set; }
        public TemperatureUnit To { get; set; }
        [Display(Name ="To Convert")]
        public double ToConvert { get; set; }
        public string Result { get; set; }
    }
}