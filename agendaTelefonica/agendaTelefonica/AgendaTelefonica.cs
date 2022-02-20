using System;
using System.Collections.Generic;
using System.Linq;

  class AgendaTelefonica
    {

        public Dictionary<string, string> Agenda { get; }
        public AgendaTelefonica()
    {
        this.Agenda = new Dictionary<string, string>();
    }
            public void Inserir (string nome, string numero)
    {
                Agenda.Add (nome, numero);
    }

                public string Buscar (string k)
    {
                  return Agenda [k];
    }

    }

  

