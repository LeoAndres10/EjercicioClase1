
using EjercicioClase;

string puedeVolar;

SuperHeroe Superheroe1 = new SuperHeroe();
SuperHeroe Superheroe2 = new SuperHeroe();
SuperHeroe Superheroe3 = new SuperHeroe();



for (int i = 0; i < 1; i++)
{
    Console.WriteLine("Ingrese el nombre: ");
    Superheroe1.Nombre =Console.ReadLine();
    Console.WriteLine("Ingrese la identidad secreta: ");
    Superheroe1.identidadSecreta = Console.ReadLine();
    Console.WriteLine("Ingrese la ciudad: ");
    Superheroe1.ciudad = Console.ReadLine();
    Console.WriteLine("Puede Volar? (s/n)");
    puedeVolar=Console.ReadLine();
    if (puedeVolar == "s")
    {
        Superheroe1.puedeVolar = true;
    }
    else
    {
        Superheroe1.puedeVolar= false;
    }
    Console.WriteLine("Ingrese el superpoder: ");
    Superheroe1.superPoder.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la descripcion: ");
    Superheroe1.superPoder.descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese el nivel");
    Superheroe1.superPoder.nivel = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
  
}
for (int i = 0; i < 1; i++)
{
    Console.WriteLine("Ingrese el nombre: ");
    Superheroe2.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la identidad secreta: ");
    Superheroe2.identidadSecreta = Console.ReadLine();
    Console.WriteLine("Ingrese la ciudad: ");
    Superheroe2.ciudad = Console.ReadLine();
    Console.WriteLine("Puede Volar? (s/n)");
    puedeVolar = Console.ReadLine();
    if (puedeVolar == "s")
    {
        Superheroe2.puedeVolar = true;
    }
    else
    {
        Superheroe2.puedeVolar = false;
    }
    Console.WriteLine("Ingrese el superpoder: ");
    Superheroe2.superPoder.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la descripcion: ");
    Superheroe2.superPoder.descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese el nivel");
    Superheroe2.superPoder.nivel = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();


}
for (int i = 0; i < 1; i++)
{

    Console.WriteLine("Ingrese el nombre: ");
    Superheroe3.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la identidad secreta: ");
    Superheroe3.identidadSecreta = Console.ReadLine();
    Console.WriteLine("Ingrese la ciudad: ");
    Superheroe3.ciudad = Console.ReadLine();
    Console.WriteLine("Puede Volar? (s/n)");
    puedeVolar = Console.ReadLine();
    if (puedeVolar == "s")
    {
        Superheroe3.puedeVolar = true;
    }
    else
    {
        Superheroe3.puedeVolar = false;
    }
    Console.WriteLine("Ingrese el superpoder: ");
    Superheroe3.superPoder.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la descripcion: ");
    Superheroe3.superPoder.descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese el nivel");
    Superheroe3.superPoder.nivel = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();


}

Superheroe1.Imprimir();
Superheroe2.Imprimir();
Superheroe3.Imprimir();



