using System;
using CVihm.Models;
using CVihm.ModifierWord;   


namespace CVihm
{
     class Program
    {
        private static char caractereConfirma;

        static void Main(string[] args)
        {
            bool verifica;
            char caracterConfirma;
            ModifierWordDocModel modifierWordDocModel = new();

            do {
                Console.WriteLine("Insira seu nome: ");
                modifierWordDocModel.Nome = Console.ReadLine();
                Console.WriteLine("Insira seu contato: ");

                modifierWordDocModel.Contato = Console.ReadLine();
                Console.WriteLine("Insira seu email: ");

                modifierWordDocModel.Email = Console.ReadLine();

                ModifierWordAction.ReplaceElement(modifierWordDocModel.Nome, modifierWordDocModel.Contato, modifierWordDocModel.Email);
                Console.WriteLine("Modificações realizadas com sucesso!");

                while (true)
                {
                    Console.Write("Você deseja continuar no progarama?[N/s]");
                    caractereConfirma = char.Parse(Console.ReadLine());
                    if (caractereConfirma == 'N' || caractereConfirma == 'n')
                    {
                        verifica = false;
                        break;
                    }
                    else if (caractereConfirma == 'S' || caractereConfirma == 's')
                    {
                        verifica = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Insira um valor valido!");
                    }
                }

            } while (verifica); 
        }
    }
}