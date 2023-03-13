using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatioServices.Models.Contact
{
    public class Contact
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public bool UsrSincronizar { get; set; }
        public DateTime? ModifiedOn { get; set; }

    }
}
