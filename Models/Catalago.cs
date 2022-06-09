using CatalagoPelis.Models;
namespace CatalagoPelis.Models
{
    public class Catalago
    {
        private List<Pelicula> _peliculasFavoritas;
        private List<Pelicula> _peliculasBuenas;
        private List<Pelicula> _peliculasMalas;

        public Catalago()
        {
            _peliculasFavoritas = new List<Pelicula>();
            _peliculasBuenas = new List<Pelicula>();
            _peliculasMalas = new List<Pelicula>();
        }

        public void showMenuPrincipal()
        {
            int opcionSeleccionada = 0;
            Console.Clear();

            do
            {
                Console.WriteLine("Bienvenido, ¿Que accion deseas realizar?");
                Console.WriteLine("1. Administrar Favoritas");
                Console.WriteLine("2. Administrar Buenas");
                Console.WriteLine("3. Administrar Malas");
                Console.WriteLine("4. Salir");
            } while (!validaMenu(4, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    showMenuFavoritas();
                    break;
                case 2:
                    showMenuBuenas();
                    break;
                case 3:
                    showMenuMalas();
                    break;
                case 4: break;
            }
        }

        private void showMenuFavoritas()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Administración de Peliculas por favoritas");
                Console.WriteLine("1.- Ver catalago");
                Console.WriteLine("2.- Crear");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Regresar");
            } while (!validaMenu(5, ref opcionSeleccionada));
            Console.Clear();
            switch (opcionSeleccionada)
            {

                case 1:
                    verCatalagoFavoritas();
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuFavoritas();
                    break;
                case 2:
                    crearPeliculaFavorita();
                    break;
                case 3:
                    editarPeliculaFavorita();
                    break;
                case 4:
                    eliminarPeliculaFavorita();
                    break;
                case 5:
                    showMenuPrincipal();
                    break;
            }
        }
        private void showMenuBuenas()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Administración de Peliculas buenas");
                Console.WriteLine("1.- Ver catalago");
                Console.WriteLine("2.- Crear");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Regresar");
            } while (!validaMenu(5, ref opcionSeleccionada));
            Console.Clear();
            switch (opcionSeleccionada)
            {
                case 1:
                    verCatalagoBuenas();
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuBuenas();
                    break;
                case 2:
                    crearPeliculaBuena();
                    break;
                case 3:
                    editarPeliculaBuena();
                    break;
                case 4:
                    eliminarPeliculaBuena();
                    break;
                case 5:
                    showMenuPrincipal();
                    break;
            }
        }
        private void showMenuMalas()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Administración de Peliculas malas");
                Console.WriteLine("1.- Ver catalago");
                Console.WriteLine("2.- Crear");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Regresar");
            } while (!validaMenu(5, ref opcionSeleccionada));
            Console.Clear();
            switch (opcionSeleccionada)
            {
                case 1:
                    verCatalagoMalas();
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuMalas();
                    break;
                case 2:
                    crearPeliculaMala();
                    break;
                case 3:
                    editarPeliculaMala();
                    break;
                case 4:
                    eliminarPeliculaMala();
                    break;
                case 5:
                    showMenuPrincipal();
                    break;
            }
        }

        //Opciones nivel 2

        private void verCatalagoFavoritas()
        {
            Console.WriteLine("Mostrando catalago de peliculas favoritas");
            foreach (Pelicula item in _peliculasFavoritas)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private void verCatalagoBuenas()
        {
            Console.WriteLine("Mostrando catalago de peliculas Buenas");
            foreach (Pelicula item in _peliculasBuenas)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private void verCatalagoMalas()
        {
            Console.WriteLine("Mostrando catalago de peliculas Malas");
            foreach (Pelicula item in _peliculasMalas)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private void eliminarPeliculaFavorita()
        {
            string? nombre;
            verCatalagoFavoritas();
            nombre = ingresarString("Escribe el nombre de la Pelicula a Eliminar");
            Pelicula? pelicula = _peliculasFavoritas.FirstOrDefault(e => e._nombre == nombre);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter'.");
            }
            else
            {
                _peliculasFavoritas.Remove(pelicula);
                Console.WriteLine($"La Pelicula de nombre: {pelicula._nombre} se eliminó correctamente. Presiona 'Enter'.");
            }
            Console.ReadLine();
            showMenuFavoritas();
        }
        private void eliminarPeliculaBuena()
        {
            string? nombre;
            verCatalagoBuenas();
            nombre = ingresarString("Escribe el nombre de la Pelicula a Eliminar");
            Pelicula? pelicula = _peliculasBuenas.FirstOrDefault(e => e._nombre == nombre);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter'.");
            }
            else
            {
                _peliculasBuenas.Remove(pelicula);
                Console.WriteLine($"La Pelicula de nombre: {pelicula._nombre} se eliminó correctamente. Presiona 'Enter'.");
            }
            Console.ReadLine();
            showMenuBuenas();
        }
        private void eliminarPeliculaMala()
        {
            string? nombre;
            verCatalagoMalas();
            nombre = ingresarString("Escribe el nombre de la Pelicula a Eliminar");
            Pelicula? pelicula = _peliculasMalas.FirstOrDefault(e => e._nombre == nombre);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter'.");
            }
            else
            {
                _peliculasMalas.Remove(pelicula);
                Console.WriteLine($"La Pelicula de nombre: {pelicula._nombre} se eliminó correctamente. Presiona 'Enter'.");
            }
            Console.ReadLine();
            showMenuMalas();
        }

        private void editarPeliculaFavorita()
        {
            string nombre;
            string genero;
            string director;
            Console.WriteLine("Editar de Pelicula");
            verCatalagoFavoritas();
            nombre = ingresarString("nombre de la Pelicula a Editar");
            Pelicula? pelicula = _peliculasFavoritas.FirstOrDefault(e => e._nombre == nombre);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter'.");
            }
            else
            {
                genero = ingresarString("Genero");
                director = ingresarString("Director");
                pelicula._genero = genero;
                pelicula._director = director;
                Console.WriteLine($"La pelicula de nombre: {pelicula._nombre} se editó correctamente. Presiona 'Enter'.");
            }
            Console.ReadLine();
            verCatalagoFavoritas();
        }
        private void editarPeliculaBuena()
        {
            string nombre;
            string genero;
            string director;
            Console.WriteLine("Editar de Pelicula");
            verCatalagoBuenas();
            nombre = ingresarString("nombre de la Pelicula a Editar");
            Pelicula? pelicula = _peliculasBuenas.FirstOrDefault(e => e._nombre == nombre);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter'.");
            }
            else
            {
                genero = ingresarString("Genero");
                director = ingresarString("Director");
                pelicula._genero = genero;
                pelicula._director = director;
                Console.WriteLine($"La pelicula de nombre: {pelicula._nombre} se editó correctamente. Presiona 'Enter'.");
            }
            Console.ReadLine();
            verCatalagoFavoritas();
        }
        private void editarPeliculaMala()
        {
            string nombre;
            string genero;
            string director;
            Console.WriteLine("Editar de Pelicula");
            verCatalagoMalas();
            nombre = ingresarString("nombre de la Pelicula a Editar");
            Pelicula? pelicula = _peliculasMalas.FirstOrDefault(e => e._nombre == nombre);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter'.");
            }
            else
            {
                genero = ingresarString("Genero");
                director = ingresarString("Director");
                pelicula._genero = genero;
                pelicula._director = director;
                Console.WriteLine($"La pelicula de nombre: {pelicula._nombre} se editó correctamente. Presiona 'Enter'.");
            }
            Console.ReadLine();
            verCatalagoFavoritas();
        }
        private void crearPeliculaFavorita()
        {
            string nombre;
            string genero;
            string director;
            Console.WriteLine("Alta de Pelicula Favorita");
            nombre = ingresarString("nombre");
            genero = ingresarString("Genero");
            director = ingresarString("Director");
            Console.Clear();
            verCatalagoFavoritas();
            Pelicula? pelicula = _peliculasFavoritas.FirstOrDefault(e => e._nombre == nombre);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter'.");
            }
            else
            {
                Pelicula nuevaPelicula = new Pelicula(nombre, genero, director);
                _peliculasFavoritas.Add(nuevaPelicula);
                Console.WriteLine($"Pelicula registrada correctamente. Presiona 'Enter'.");
            }
            Console.ReadLine();
            verCatalagoFavoritas();
        }
        private void crearPeliculaBuena()
        {
            string nombre;
            string genero;
            string director;
            Console.WriteLine("Alta de Pelicula Buena");
            nombre = ingresarString("nombre");
            genero = ingresarString("Genero");
            director = ingresarString("Director");
            Console.Clear();
            verCatalagoBuenas();
            Pelicula? pelicula = _peliculasBuenas.FirstOrDefault(e => e._nombre == nombre);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter'.");
            }
            else
            {
                Pelicula nuevaPelicula = new Pelicula(nombre, genero, director);
                _peliculasBuenas.Add(nuevaPelicula);
                Console.WriteLine($"Pelicula registrada correctamente. Presiona 'Enter'.");
            }
            Console.ReadLine();
            verCatalagoBuenas();
        }
        private void crearPeliculaMala()
        {
            string nombre;
            string genero;
            string director;
            Console.WriteLine("Alta de Pelicula Mala");
            nombre = ingresarString("nombre");
            genero = ingresarString("Genero");
            director = ingresarString("Director");
            Console.Clear();
            verCatalagoMalas();
            Pelicula? pelicula = _peliculasMalas.FirstOrDefault(e => e._nombre == nombre);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter'.");
            }
            else
            {
                Pelicula nuevaPelicula = new Pelicula(nombre, genero, director);
                _peliculasMalas.Add(nuevaPelicula);
                Console.WriteLine($"Pelicula registrada correctamente. Presiona 'Enter'.");
            }
            Console.ReadLine();
            verCatalagoMalas();
        }
        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción Invalida.");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es válido, debes ingresar un número.");
                return false;
            }
        }

        private string ingresarString(string texto)
        {
            string? valor;
            do
            {
                Console.Write($"{texto}: ");
                valor = Console.ReadLine();
                if (valor == null || valor == "")
                {
                    Console.WriteLine("Valor inválido.");
                }
            } while (valor == null || valor == "");
            return valor;
        }
        public void inicializarDatos()
        {
            Pelicula pelicula1 = new Pelicula("Wonder Woman 1984", "Accion","Patty Jenkins");
            Pelicula pelicula2 = new Pelicula("La chica danesa", "Drama", "Tom Hooper");
        }
    }
}