using System.Collections;
using System.Globalization;
using System.Text;
Console.Clear();
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
// Hacer un bucle para llamar nombres que empiecen por B
foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}



