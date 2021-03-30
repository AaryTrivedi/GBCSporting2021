using System.Collections.Generic;
using GBCSporting2021.Models;

namespace GBCSporting2021.ViewModels
{
    public class IncidentListViewModel
    {

        private List<Incident> incidents;
        private string filterType;

        public List<Incident> Incidents {
            get => incidents;
            set => incidents = value;
        }

        public string FilterType
        {
            get => filterType;
            set => filterType = value;
        }

    }
}
