using System.Diagnostics.Metrics;
using System.Text;

var msg = Console.ReadLine();

var primeiraLetra = msg[0];
var ultimaLetra = msg[msg.Length -1];
var segundaLetra = msg[1];

byte[] asciiBytes = Encoding.ASCII.GetBytes(primeiraLetra.ToString());

for(int i = 0 ; i < msg.Length; i++)
{
    var msgSalva = msg;
    if(i == 2)
    {
        int sla = asciiBytes[0].ToString().Length;
        msgSalva = msgSalva.Substring(2);
        msgSalva = msgSalva.Insert(0, asciiBytes[0].ToString());
        msgSalva = msgSalva.Insert(sla, ultimaLetra.ToString());
        msgSalva = msgSalva.Remove(msgSalva.Length - 1, 1);
        msgSalva = msgSalva.Insert(msgSalva.Length, segundaLetra.ToString());
        Console.WriteLine(msgSalva);
    }
}

