using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceBiblioteca.Modelo;
using WcfServiceBiblioteca.Repositorio;

namespace WcfServiceBiblioteca
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceLibro : ILibro
    {
        public IEnumerable<Libro_Ubicacion> Consultar()
        {
            LibroRepo libroRepo = new LibroRepo();

            return libroRepo.getLibrosUbicacion();

            //throw new NotImplementedException();
        }

        public IEnumerable<Libro_Ubicacion> Consultar1()
        {
            LibroRepo libroRepo = new LibroRepo();

            return libroRepo.getFirstLibro();

            //throw new NotImplementedException();
        }

        public IEnumerable<Libro_Ubicacion> Consultar2()
        {
            LibroRepo libroRepo = new LibroRepo();

            return libroRepo.getLastLibro();

            //throw new NotImplementedException();
        }

        public void guardaLibro(Libro_Ubicacion libro)
        {
            LibroRepo libroRepo = new LibroRepo();
            libroRepo.saveLibro(libro);
            //throw new NotImplementedException();
        }
    }
}
