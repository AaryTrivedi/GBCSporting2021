using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GBCSporting2021.ViewModels
{
    public class TechIncidentGetViewModel
    {

        private List<SelectListItem> technicians;
        private int technicianId = -1;
        private Technician technician;

        public List<SelectListItem> Technicians
        {
            get => technicians;
            set => technicians = value;
        }

        public int TechnicianId
        {
            get => technicianId;
            set => technicianId = value;
        }

        public Technician Technician
        {
            get => technician;
            set => technician = value;
        }

    }
}
