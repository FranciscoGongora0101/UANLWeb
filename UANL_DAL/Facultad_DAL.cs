using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UANL_DAL
{
    public class Facultad_DAL
    {
        UANLEntities modelo;

        public Facultad_DAL()
        {
            modelo = new UANLEntities();
        }

        public List<Facultad> cargarFacultades()
        {
            var facultades = from mFacultades in modelo.Facultad
                                select mFacultades;

            return facultades.ToList();
        }
    }
}
