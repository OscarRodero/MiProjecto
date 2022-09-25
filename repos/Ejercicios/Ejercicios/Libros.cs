using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Libros
    {
        public ArrayList MisLibros = new ArrayList();
        public void Menu() {
            Boolean salir = false;
            int x = 0;            
            do {
                try
                {
                    Console.WriteLine("¿Que deseas hacer?");
                    Console.WriteLine("1. Insertar un libro nuevo");
                    Console.WriteLine("2. Ver los libros almacenados");
                    Console.WriteLine("3. Modificar un libro");
                    Console.WriteLine("4. Borrar algún libro");
                    Console.WriteLine("5. Salir");
                    x = int.Parse(Console.ReadLine());
                    switch(x){
                        case 1:
                            InsertarLibro();
                            break;
                        case 2:
                            VerLibros();
                            break;
                        case 3:
                            ModificarLibro();
                            break;
                        case 4:
                            BorrarLibro();
                            break;
                        default:
                            salir = true;
                            break;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);   
                }
            } while (!salir);
        }

        private void VerLibros()
        {
            for (int i = 0; i < MisLibros.Count; i++) {
                Console.WriteLine(i+". "+MisLibros[i]);
            }
        }

        private void InsertarLibro()
        {
            try {
                Console.WriteLine("Dame el Titulo de la obra");
                String t = Console.ReadLine();
                Console.WriteLine("Dame el Autor de la obra");
                String a = Console.ReadLine();
                Console.WriteLine("Dame el Estilo de la obra");
                String e = Console.ReadLine();
                Console.WriteLine("Dame la Editorial de la obra");
                String ed = Console.ReadLine();
                Libro n = new Libro(t, a, e, ed);
                this.MisLibros.Add(n);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            
        }
        private void ModificarLibro() {
            /*try {
                int x = 0;
                Console.WriteLine("¿Que libro (número) deseas modificar?");
                x = int.Parse(Console.ReadLine());
                if (MisLibros.Count <= x) {
                    Console.WriteLine("¿Que quieres modificar?");
                    Console.WriteLine("1. Titulo");
                    Console.WriteLine("2. Autor");
                    Console.WriteLine("3. Estilo");
                    Console.WriteLine("4. Editorial");
                    int y = int.Parse(Console.ReadLine());
                    switch (y) {
                        case 1:
                            Console.WriteLine("Dame el título nuevo");
                            MisLibros[x]
                    }
                }
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }*/
        }
        private void BorrarLibro() {
            int x = 0;
            Console.WriteLine("¿Que libro (número) deseas eliminar?");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Vas a eliminar el siguiente libro:");
            Console.WriteLine(MisLibros[x]);
            Console.WriteLine("Continuar (S/N)");
            String respuesta = Console.ReadLine();
            if (respuesta.Equals("s")||respuesta.Equals("S")) { 
                MisLibros.Remove(x);
            }
        }
    }
}

