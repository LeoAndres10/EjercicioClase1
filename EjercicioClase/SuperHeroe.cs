

namespace EjercicioClase
{
    public class SuperHeroe
    {
        public String Nombre { get; set; }

        public String identidadSecreta { get; set; }

        public String ciudad { get; set; }

        public bool puedeVolar { get; set; }

        public Superpoder superPoder { get; set; }

        public SuperHeroe()
        {
            puedeVolar = true;
            superPoder = new Superpoder();

        }

        public void Imprimir()
        {

            {
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Identidad Secreta: {identidadSecreta}");
                Console.WriteLine($"Ciudad: {ciudad}");
                Console.WriteLine($"Puede volar?: {(puedeVolar ? "Si" : "No")}");
                Console.WriteLine($"Super poder: {superPoder.Nombre}");
                Console.WriteLine($"Descripcion: {superPoder.descripcion}");
                Console.WriteLine($"Nivel: {Convert.ToInt32(superPoder.nivel)}");
                Console.WriteLine();



            }
        }


    }
}
