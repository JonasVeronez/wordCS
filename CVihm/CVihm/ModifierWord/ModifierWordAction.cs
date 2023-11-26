using System;
using Xceed.Words.NET;
using CVihm.Models;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

namespace CVihm.ModifierWord
{
    public class ModifierWordAction
    {
          public static void ReplaceElement (string _Nome , string _Contato, string _Email)
        {
            var DiretorioATual =Directory.GetCurrentDirectory();

            try
            {
                var documento = DocX.Load(DiretorioATual + @"\Documentos\" + "ModeloWord.docx");
                var hora = new ModifierWordDocModel();

                documento.ReplaceText("#nome1", _Nome);
                documento.ReplaceText("#contato1", _Contato);
                documento.ReplaceText("#email1", _Email);
                documento.ReplaceText("#dataAtendimento1", hora.DataAtendimento.ToString);

                documento.SaveAs(DiretorioATual + @"\Documentos\Salvos\" + "novo-documento.docx");
                
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível iniciar seu documento.");
                throw;
            }

            
        }
    }
}
