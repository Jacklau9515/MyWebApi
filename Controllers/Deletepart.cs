using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [Route("api/arraycalc/[controller]")]
    public class DeletePart : Controller
    {
        [HttpGet]
        public string Get(int position, int[] productIds)
        {
            string outString = "[";
            int count = 0;
            for (int i = 0; i < productIds.Length; i++)
            {
                if (productIds[i] != position)
                {
                    if (count != 0) outString += ","; 
                    outString += productIds[i];
                    count++;
                }
            }
            outString += "]";
            return outString;
        }

        static bool Delete(int deleteWhat, int compare)
        {
            return compare != deleteWhat;
        }
    }
}
