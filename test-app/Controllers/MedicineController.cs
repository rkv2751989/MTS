using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using test_app.Models;

namespace test_app.Controllers
{
    public class MedicineController : ApiController
    {
       

       static IList<Medicine> medicines = new List<Medicine>()
        {
            new Medicine()
                {
                    FullName = "PeracitaMol", Brand = "Cipla", Price = 100, Quantity = 10, Notes=""
                },
        };

        [HttpGet]
        public IList<Medicine> GetAllMedicines()
        {
            return medicines;
        }
        [HttpGet]
        public Medicine GetMedicinesDetails(string name)
        {
          
            var medicine = medicines.FirstOrDefault(e => e.FullName == name);
            if (medicine == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return medicine;
        }

        [HttpPost]
        public void post([FromBody] Medicine medicine)
        {

            medicines.Add(medicine);
        }

    }
}
