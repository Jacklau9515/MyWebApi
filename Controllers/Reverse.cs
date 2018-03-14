using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [Route("api/arraycalc/[controller]")]
    public class Reverse : Controller
    {
        [HttpGet]
        public string Get(int[] productIds)
        {
            string outString = "[";
            for(int i=0; i<productIds.Length/2; i++)
            {
                int tmp = productIds[i];
                productIds[i] = productIds[productIds.Length - i - 1];
                productIds[productIds.Length - i - 1] = tmp;
            }
            for(int i=0; i<productIds.Length-1; i++) outString += (productIds[i]+",");
            outString += (productIds[productIds.Length-1]+"]");
            return outString;
        }
    }
}
