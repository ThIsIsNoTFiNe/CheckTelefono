# Check Telefono
L'esercizio richiede, dati vari numeri di telefoni (italiani) sia corretti che sbagliati, di riconoscere i numeri di telefono corretti tramite l'inizio, mostrandoli in output. 

# Spiegazione passo a passo del problema:

Come prima cosa inizializziamo un *foreach* che servirà per prendere un solo numero di telefono il quale metteremo sotto analisi. La prima analisi che faremo sarà un controllo tramite *for*, il quale ciclerà il numero di telefono numero per numero, un *if* per controllare se all'interno del numero sono prensenti spazi e in caso essi siano prensenti cambiera una flag (settata su false) in ***true*** in modo da far considerare al programma il numero direttametnte sbagliato. Dopo iniziamo con i veri e propri controlli, tramite una serie di *if/else if*. Come primo processo faremo controllare la lunghezza del numero che stiamo analizzando e lo compariamo con la lunghezza predefinita per un telefono italiano (controlla in fondo le lunghezza predefinite dai numeri italiani). Aggiungendo un *&&* utilizziamo la funzione ***StartsWith***, la quale controlla se l'inizio del numero da noi analizzato è uguale ad una stringa che **noi** gli diamo in input. Nel caso il numero inizi con 3 inseriamo anche un altro *&&* con il quale andremo a riportare la flag prima menzionata in *false* (In questo caso si trova solo sul 3 ma si può benissimo anggiungere anche agli altri if, in caso sia necessario). Alla fine se in uno delle nostre analisi verifichiamo che un numero è corrertto lo restituiamo tramite un *return*. 

## Lunghezze dei numeri italiani secondo il loro prefisso:
  * +39/0039 = 13 numeri.
  * *39/0039 = 14 nuemri.  
  * 3 = 10 numeri.


### Ecco un piccolo accenno della funzione ***StartsWith***:

```C#
if (numero.Length == 10 && numero.StartsWith("3") && sus == false)
            {
                return numero; 
            }
```
Per ulteriori spiegazioni il codice nei file possiade dei commenti affianco alle varie linee di codice.
