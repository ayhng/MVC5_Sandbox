using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web.Http.Cors;

using MVC5_Sandbox.Services;
using MVC5_Sandbox.Models;

namespace MVC5_Sandbox.Controllers
{
    public class VolunteerController : ApiController
    {
        private VolunteerRepository volunteerRepository;

        public VolunteerController()
        {
            this.volunteerRepository = new VolunteerRepository();
        }

        [EnableCors(origins:"*", headers:"*", methods:"*")]
        public Volunteer[] get()
        {
            return this.volunteerRepository.GetAllVolunteers();
        }

        public Volunteer get(int id)
        {
            return this.volunteerRepository.GetAllVolunteers()[0];
        }
    }
}
