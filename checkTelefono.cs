using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Telefono
{

    public static string Check(string[] input)
    {
        foreach (string numero in input) //faccio scorrere l'array con i vari numeri di telefono.
        {
          bool sus = false;
for (int i = 0; i < numero.Length; i++) 
{ 
    if (numero[i] == ' ')
    {
        sus = true;
    }
}
            

            //Controllo se il numero inizia con 3,+39 o 0039, tramite la funzione "StartWith"
            // selezionando il migliore grazie alla lunghezza.
            if (numero.Length == 10 && numero.StartsWith("3") && sus == false)
            {
                return numero; //se il numero rispetta i  criteri lo riporto.
            }
            else if (numero.Length == 13 && (numero.StartsWith("+39") || numero.StartsWith("0039")))
            {
                return numero;
            }

            else if (numero.Length == 14 && (numero.StartsWith("+39") || numero.StartsWith("0039")))
            {
                return numero;
            }
            
        }
        //in caso contrario mostro "" come richiesto.
        return "";
    }
}

