using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace CapstoneApp.Controllers.API
{
    public class WatsonController : Controller
    {
        public void Post ([FromBody]string text)
        {
            // Logic to make API call to Watson service using credentials and 
            // text string from request body

            // Receive wav audio stored in byte array - figure our how to convert
            // byte array into wav file using a library compatible with .NET Core (5.0)

            // Figure out how to play newly created .wav file for user 
        }
    }
}
