using System;
using System.Collections.Generic;
using FizzBuzzAPIWeb.Models;
using System.Web.Http;

namespace FizzBuzzAPIWeb.Controllers
{
    public class FizzBuzzController : ApiController
    {
        public FizzBuzzOutput GetFizzBuzz(int start, int end)
        {
            FizzBuzzOutput output = new FizzBuzzOutput();
            List<string> convertedInts = new List<string>();
            for (int ii = start; ii <= end; ii++)
            {
                if (ii % 15 == 0)
                {
                    convertedInts.Add("fizzbuzz");
                    output.fizzbuzz++;
                }
                else if (ii % 3 == 0)
                {
                    convertedInts.Add("fizz");
                    output.fizz++;
                }
                else if (ii % 5 == 0)
                {
                    convertedInts.Add("buzz");
                    output.buzz++;
                }
                else
                {
                    convertedInts.Add(ii.ToString());
                    output.integer++;
                }
            }
            output.result = String.Join(" ", convertedInts);
            return output;
        }
    }
}