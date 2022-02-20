using System;


    class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso("POO ||");

              curso.Notas.Add((decimal)5.0);
              curso.Notas.Add((decimal)6.0);
              curso.Notas.Add((decimal)6.1);
              curso.Notas.Add((decimal)5.0);
              curso.Notas.Add((decimal)5.0);
              curso.Notas.Add((decimal)7.0);

                Console.WriteLine($"Media de {curso.Nome}={curso.MediaNotas()}");
                Console.WriteLine($"Maior de {curso.Nome}={curso.MaiorNota()}");
                Console.WriteLine($"Menor de {curso.Nome}={curso.MenorNota()}");
    }
    }


