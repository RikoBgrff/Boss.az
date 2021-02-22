using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.az
{
    class Cv
    {
        public string Specialty { get; set; }
        public string Education { get; set; }
        public string AcceptanceScore { get; set; }
        public string Summary { get; set; }
        public OldCompany Company { get; set; }
        public Certificates Certificates { get; set; }
        public Language Languages { get; set; }
        
        public string GitHubLink { get; set; }
        public string Linkedln { get; set; }
        
    }
}
