using System;

class pooMensagem
{
        static void Main (string [] args)
    {
        Mensagem msg1, msg2;
        msg1 = new Mensagem();
        msg1.textoMensagem = "Oi rapaziada";
        msg1.ExibirMensagem();

        msg2 = new Mensagem();
        msg2.textoMensagem = "Segundo Objeto";
        msg2.ExibirMensagem();

           Console.ReadKey();
    }
}