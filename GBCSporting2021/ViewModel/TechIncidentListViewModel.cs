using System.Collections.Generic;
using GBCSporting2021.Models;

namespace GBCSporting2021.ViewModels
{
    public class TechIncidentListViewModel
    {

        private Technician technician;
        private List<Incident> incidents = new List<Incident>();

        public Technician Technician
        {
            get => technician;
            set => technician = value;
        }

        public List<Incident> Incidents
        {
            get => incidents;
            set => incidents = value;
        }

    }
}
