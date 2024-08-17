using CountryPortel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryPortel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        public readonly TrainingDBContext trainingDBContext;
        public CountryController(TrainingDBContext _trainingDBContext)
        {
            trainingDBContext = _trainingDBContext;
        }
        [HttpGet("GetCountryDetails")]
        public List<Country> GetCountryDetails()
        {
            List<Country> lstCountry = new List<Country>();
            try
            {
                lstCountry = trainingDBContext.Country.ToList();
                return lstCountry;
            }
            catch (Exception ex)
            {
                lstCountry = new List<Country>();
                return lstCountry;
            }
        }
        [HttpPost("AddCountry")]
        public string AddCountry(Country country)
        {
            string message = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(country.CountryName))
                {
                    trainingDBContext.Add(country);
                    trainingDBContext.SaveChanges();
                    message = "Country added successfully";
                }
                else
                    message = "Country Name required.";

            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }
    }
}
