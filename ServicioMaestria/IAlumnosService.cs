using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ServicioMaestria.Models;

namespace ServicioMaestria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlumnosService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAlumnosService
    {
        [OperationContract]

        bool Actualizar(string nc, string ap, string am, string nom);

        [OperationContract]
        bool Agregar(string nc, string ap, string am, string nom);

        [OperationContract]
        Alumno BuscarxNC(string nc);

        [OperationContract]
        List<Alumno> Consultar();

        [OperationContract]
        bool Eliminar(string nc);

    }
}
