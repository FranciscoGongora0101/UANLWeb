using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UANL_DAL;

namespace UANL_BLL
{
    public class Alumno_BLL
    {
        public List<object> cargarAlumnos()
        {
            Alumno_DAL alumno = new Alumno_DAL();
            return alumno.cargarAlumnos();
        }

        public Alumno cargarAlumno(int id)
        {
            Alumno_DAL alumno = new Alumno_DAL();
            return alumno.cargarAlumno(id);
        }

        public void eliminarAlumno(int id)
        {
            Alumno_DAL alumno = new Alumno_DAL();
            alumno.eliminarAlumno(id);
        }

        public void agregarAlumno(Alumno paramAlumno)
        {
            Alumno_DAL alumno = new Alumno_DAL();
            Alumno pAlumno = new Alumno();

            pAlumno = cargarAlumno(paramAlumno.matricula);

            if (pAlumno != null)
            {
                throw new Exception("La matricula ya existe, introduce una matricula diferente");
            }
            else
            {
                int edad = DateTime.Now.Year - paramAlumno.fechaNacimiento.Year;
                if (edad > 120)
                {
                    throw new Exception("Tiene una edad mayor a la permitida, introduzca una edad menor");
                }
                else
                {
                    if (edad < 10)
                    {
                        throw new Exception("Tiene una edad menor a la permitida, introduzca una edad mayor");
                    }
                    else
                    {
                        alumno.agregarAlumno(paramAlumno);
                    }
                }

            }
        }

        public void modificarAlumno(Alumno paramAlumno)
        {
            Alumno_DAL alumno = new Alumno_DAL();

                int edad = DateTime.Now.Year - paramAlumno.fechaNacimiento.Year;
                if (edad > 120)
                {
                    throw new Exception("Tiene una edad mayor a la permitida, introduzca una edad menor");
                }
                else
                {
                    if (edad < 10)
                    {
                        throw new Exception("Tiene una edad menor a la permitida, introduzca una edad mayor");
                    }
                    else
                    {
                        alumno.modificarAlumno(paramAlumno);
                    }
                }

            
        }
    }
}
