using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MVC5_Sandbox.Models;

namespace MVC5_Sandbox.Services
{
    public class VolunteerRepository
    {
        public Volunteer[] GetAllVolunteers()
        {
            return new Volunteer[]
            {
                new Volunteer
                {
                    Id = 1,
                    FirstName = "Paul",
                    LastName = "Smith"
                },

                new Volunteer
                {
                    Id = 2,
                    FirstName = "Mary",
                    LastName = "Ng"
                }
            };
        }
    }
}