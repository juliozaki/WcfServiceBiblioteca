using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfServiceBiblioteca.Modelo;

namespace WcfServiceBiblioteca.Repositorio
{
    public class LibroRepo
    {

        public IEnumerable<Libro_Ubicacion> getLibrosUbicacion()
        {
            using (BibliotecaEntities contexto = new BibliotecaEntities())
            {
                var libros = from lib in contexto.Libro_Ubicacion
                             .OrderBy(t => t.Isbn)
                             select lib;
                return libros.AsNoTracking().ToList();
                /*from lib in contexto.Libro
                         join ubi in contexto.Ubicacion
                         on lib.Isbn equals ubi.Isbn
                         select new
                         {
                             Isbn = ubi.Isbn,
                             Titulo = lib.Titulo,
                             Estante = ubi.Estante,
                             Sala = ubi.Sala,
                             Librero = ubi.Librero,
                             Posicion = ubi.Posicion
                         };*/
            }
        }

        public IEnumerable<Libro_Ubicacion> getFirstLibro()
        {
            using (BibliotecaEntities contexto = new BibliotecaEntities())
            {
                var isbn = from lib in contexto.Libro_Ubicacion.Min(t => t.Isbn)
                             select lib;
                
                string par = new string(isbn.ToArray());
                
                var libro = from lib2 in contexto.Libro_Ubicacion
                            where lib2.Isbn == par
                            select lib2;


                return libro.AsNoTracking().ToList();
            }
        }

        public IEnumerable<Libro_Ubicacion> getLastLibro()
        {
            using (BibliotecaEntities contexto = new BibliotecaEntities())
            {
                var isbn = from lib in contexto.Libro_Ubicacion.Max(t => t.Isbn)
                           select lib;

                string par = new string(isbn.ToArray());

                var libro = from lib2 in contexto.Libro_Ubicacion
                            where lib2.Isbn == par
                            select lib2;


                return libro.AsNoTracking().ToList();
            }
        }

        public void saveLibro(Libro_Ubicacion libro)
        {
            Libro libro1 = new Libro
            {
                Isbn = libro.Isbn,
                Titulo = libro.Titulo
            };
            Ubicacion ubicacion1 = new Ubicacion
            {
                Isbn = libro.Isbn,
                Estante = libro.Estante,
                Sala = libro.Sala,
                Librero = libro.Librero,
                Posicion = libro.Posicion
            };

            using (BibliotecaEntities contexto = new BibliotecaEntities())
            {
                try
                {
                    contexto.Libro.Add(libro1);
                    contexto.Ubicacion.Add(ubicacion1);

                    contexto.SaveChanges();
                }catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}