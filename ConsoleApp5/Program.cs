namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Diccionario> clientes = new Dictionary<string, Diccionario>();

            while (true)
            {
                Console.WriteLine("Ingrese los datos del cliente:");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Apellido: ");
                string apellido = Console.ReadLine();

                Console.Write("Número de Teléfono: ");
                string numeroTelefono = Console.ReadLine();

                var cliente = new Diccionario(nombre, apellido, numeroTelefono);
                clientes.Add(numeroTelefono, cliente);

                while (true)
                {
                    Console.Write("Ingrese una compra (o escriba 'fin' para terminar): ");
                    string compra = Console.ReadLine();
                    if (compra.ToLower() == "fin") break;

                    Console.Write("Ingrese el monto de la compra: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal monto))
                    {
                        cliente.AgregarCompra(compra, monto);
                    }
                    else
                    {
                        Console.WriteLine("Monto inválido. Intente de nuevo.");
                    }
                }

                Console.Write("¿Desea agregar otro cliente? (si/no): ");
                if (Console.ReadLine().ToLower() != "si") break;
            }

            Console.WriteLine("\nClientes registrados:");
            foreach (var cliente in clientes.Values)
            {
                Console.WriteLine(cliente);
                Console.WriteLine();
            }
        }
    }
}
