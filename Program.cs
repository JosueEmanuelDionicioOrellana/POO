using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("+-----------------------------------------+");
            System.Console.WriteLine("|Ingrese el numero de estudiantes  ");
            int limite = Int32.Parse(Console.ReadLine());
            Estudiantes[] lista_de_estudiante = new Estudiantes[limite];
            int contador = 0;
            while(contador<limite){
                System.Console.WriteLine("|Ingrese nombre:");
                string nombre = Console.ReadLine();

                System.Console.WriteLine("|Ingrese la edad:");
                int edad = Int32.Parse(Console.ReadLine());

                System.Console.WriteLine("|Ingrese el carnet:");
                string carnet = Console.ReadLine();

                System.Console.WriteLine("|Esta solvente?");
                Boolean solvencia = Boolean.Parse(Console.ReadLine());

                System.Console.WriteLine("|Escriba el curso");
                String curso = Console.ReadLine();

                System.Console.WriteLine("|Escriba calificacion del primer parcial");
                int parcial1 =Int32.Parse(Console.ReadLine());

                System.Console.WriteLine("|Escriba calificacion del segundo parcial");
                int parcial2 = Int32.Parse(Console.ReadLine());

                System.Console.WriteLine("|Escriba calificacion de la nota final");
                int nota_final = Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("+-----------------------------------------+");

                Estudiantes estudiante = new Estudiantes(nombre,edad,carnet,solvencia,curso,parcial1,parcial2,nota_final);
                lista_de_estudiante[contador] = estudiante;
                contador++;
            }
            
            System.Console.WriteLine(" ");
            System.Console.WriteLine("+-------------------------------------------------------+");
            System.Console.WriteLine("|Lista de estudiantes");
            for (int i = 0; i < limite; i++)
            {
                Estudiantes estudiante = lista_de_estudiante[i];
                System.Console.WriteLine("|Nombre: " + estudiante.nombre + "   Carnet: " + estudiante.carnet );
                System.Console.WriteLine(" ");
            }
            System.Console.WriteLine("+-------------------------------------------------------+");

        }
    }

    class Estudiantes{
        public string nombre;
        int edad;
        public string carnet;
        Boolean solvencia;
        string curso;
        int parcial1;
        int parcial2;
        int nota_final;

        public Estudiantes(string nombres,int edades, string carnets,Boolean solvencias,string cursos,int parcial1s,int parcial2s,int nota_finales){
            
            nombre = nombres;
            edad = edades;
            carnet = carnets;
            solvencia = solvencias;
            curso = cursos;
            parcial1 = parcial1s;
            parcial2 = parcial2s;
            nota_final = nota_finales;
        }
    }
}
