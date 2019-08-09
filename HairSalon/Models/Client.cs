using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Client
    {
        public Client()
        {
            this.Stylists = new HashSet<Stylist>();
        }
         public int StylistId {get; set;} 
         public string Name {get; set;}
        public string Details{ get; set;}
        public virtual ICollection<Stylist> Stylists {get; set;}
    }
}