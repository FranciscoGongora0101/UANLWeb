using System.Collections.Generic;
using System.Linq;

namespace UANL_DAL
{

    public class Alumno_DAL
    {
        UANLEntities modelo;

        public Alumno_DAL()
        {
            modelo = new UANLEntities();
        }

        public List<object> cargarAlumnos()
        {
            var alumnos = from mAlumnos in modelo.Alumno
                             select new
                             {
                                 matricula = mAlumnos.matricula,
                                 nombre = mAlumnos.nombre,
                                 apellido = mAlumnos.apellido,
                                 fechaNacimiento = mAlumnos.fechaNacimiento,
                                 nombreFacultad = mAlumnos.Facultad1.nombre,
                                 semestre = mAlumnos.semestre

                             };
            return alumnos.AsEnumerable<object>().ToList();



        }
        public void agregarAlumno(Alumno alumno)
        {
            modelo.Alumno.Add(alumno);
            modelo.SaveChanges();



        }

        public Alumno cargarAlumno(int id)
        {
            var alumno =
            (from mAlumno in modelo.Alumno
             where mAlumno.matricula == id
             select mAlumno).FirstOrDefault();
            return alumno;

        }


        public void modificarAlumno(Alumno pAlumno)
        {
            var alumno =
            (from mAlumno in modelo.Alumno
             where mAlumno.matricula == pAlumno.matricula
             select mAlumno).FirstOrDefault();

            alumno.nombre = pAlumno.nombre;
            alumno.apellido = pAlumno.apellido;
            alumno.fechaNacimiento = pAlumno.fechaNacimiento;
            alumno.facultad = pAlumno.facultad;
            alumno.semestre = pAlumno.semestre;


            modelo.SaveChanges();


        }
        public void eliminarAlumno(int id)
        {
            var alumno =
           (from mAlumno in modelo.Alumno
            where mAlumno.matricula == id
            select mAlumno).FirstOrDefault();

            modelo.Alumno.Remove(alumno);
            modelo.SaveChanges();

        }

    }

}
