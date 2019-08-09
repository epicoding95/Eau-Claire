

namespace HairSalon.Models
{
    public class Stylist
    {
        public int stylistId {get; set;}
        public string Name {get; set;}
        public string Details {get; set;}

        public virtual Client client {get; set;}
    }
}