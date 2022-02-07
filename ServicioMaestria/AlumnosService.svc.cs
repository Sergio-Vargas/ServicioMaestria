using ServicioMaestria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;

namespace ServicioMaestria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AlumnosService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AlumnosService.svc o AlumnosService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AlumnosService : IAlumnosService
    {


        public bool Actualizar(string nc, string ap, string am, string nom)
        {
            bool Resultado = false;
            Alumno alumno = new Alumno {

                No_control = nc,
                Apepat=ap,
                Apemat=am,
                Nombre=nom
            };

            using (BD_MaestriaEntities bd = new BD_MaestriaEntities())
            {
                bd.Entry(alumno).State = EntityState.Modified;
                Resultado = bd.SaveChanges() > 0;
            }
            return Resultado;
        }

        public bool Agregar(string nc, string ap, string am, string nom)
        {
            bool Resultado = false;
            Alumno alumno = new Alumno
            {

                No_control = nc,
                Apepat = ap,
                Apemat = am,
                Nombre = nom
            };

            using (BD_MaestriaEntities bd = new BD_MaestriaEntities())
            {
                bd.Alumnos.Add(alumno);
                Resultado = bd.SaveChanges() > 0;
            }
            return Resultado;
        }

        public Alumno BuscarxNC(string nc)
        {
            using (BD_MaestriaEntities bd = new BD_MaestriaEntities())
            {
                return bd.Alumnos.Find(nc);
            }
        }

        public List<Alumno> Consultar()
        {
            using (BD_MaestriaEntities bd = new BD_MaestriaEntities())
            {
                return bd.Alumnos.ToList();
            }
        }

        public bool Eliminar(string nc)
        {
            bool Resultado = false;
            
            using (BD_MaestriaEntities bd = new BD_MaestriaEntities())
            {
                Alumno alumno = bd.Alumnos.Find(nc);
                bd.Alumnos.Remove(alumno);
                Resultado = bd.SaveChanges() > 0;
            }
            return Resultado;
        }
    }
}
