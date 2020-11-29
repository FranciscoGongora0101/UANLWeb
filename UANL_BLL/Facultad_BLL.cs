using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UANL_DAL;

namespace UANL_BLL
{
    public class Facultad_BLL
    {
        public List<Facultad> cargarFacultades()
        {
            Facultad_DAL facultad = new Facultad_DAL();
            return facultad.cargarFacultades();
        }
    }
}
