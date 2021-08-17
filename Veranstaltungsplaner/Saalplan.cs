using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veranstaltungsplaner
{
    public class Saalplan
    {
        public Veranstaltung Veranstaltung { get; set; } = new Veranstaltung();
        public Spielstätte Spielstätte { get; set; } = new Spielstätte();

        public List<Platz> Plätze { get; set; } = new List<Platz>();
    }
}
