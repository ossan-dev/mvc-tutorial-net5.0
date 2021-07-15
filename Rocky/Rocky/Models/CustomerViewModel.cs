using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class CustomerViewModel
    {        
        [JsonProperty("val")]
        public string CustomerId { get; set; }
        [JsonProperty("label")]
        public string CustomerName { get; set; }
    }
}
