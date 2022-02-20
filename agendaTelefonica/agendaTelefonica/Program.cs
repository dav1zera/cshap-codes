using System;
using System.Collections.Generic;

    class Telefone
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agen = new AgendaTelefonica();
            agen.Inserir("Bielsa", "9999-9999");
            agen.Inserir("Zidane", "8888-8888");
            agen.Inserir("Makelele", "7777-7777");
            agen.Inserir("Diego Souza", "4444-4444");

        string numeRecuperar = agen.Buscar("Bielsa");
        Console.WriteLine($"O numero do telefone enontrado eh: {numeRecuperar}");

        foreach (string k in agen.Agenda.Keys)
        {
            Console.WriteLine($"{k} / {agen.Agenda[k]}");
        }
        }
    }

