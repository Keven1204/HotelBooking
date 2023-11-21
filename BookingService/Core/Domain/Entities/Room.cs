using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Room
    {
        public Room()
        {
        }

        public int Id { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public bool InMaintenance

        { 
            get
             
            {
                if (this.InMaintenance) || this.HasGuest)
             { 
                    return false;
              }
                {
                    return true;
                }
            }
        }

            public bool HasGuest
        { 
            // Verificar se existem Bookins abertos para essa Room
            get return true;
            }
        }
    }
}



