using DesafioPOO.Models;

Console.WriteLine("==================================================");
Console.WriteLine("Teste iphone");
Console.WriteLine("==================================================");
var iphone = new Iphone(ObterNumero(), "iphone15", ObterImeiRandomico(), 128);
iphone.InstalarAplicativo("instagram");
iphone.ReceberLigacao();
Console.WriteLine($"modelo do iphone: {iphone.Modelo}");
Console.WriteLine($"imei do iphone: {iphone.IMEI}");
Console.WriteLine($"numero do iphone: {iphone.Numero}");
Console.WriteLine($"memoria interna do iphone: {iphone.Memoria}");

Console.WriteLine();

Console.WriteLine("==================================================");
Console.WriteLine("Teste Nokia");
Console.WriteLine("==================================================");
var nokia = new Nokia(ObterNumero(), "Nokia G11 Plus NK095", ObterImeiRandomico(), 128);
nokia.InstalarAplicativo("instagram");
nokia.ReceberLigacao();
Console.WriteLine($"modelo do nokia: {nokia.Modelo}");
Console.WriteLine($"imei do nokia: {nokia.IMEI}");
Console.WriteLine($"numero do nokia: {nokia.Numero}");
Console.WriteLine($"memoria interna do nokia: {nokia.Memoria}");


static string ObterNumero()
{
    var rdm = new Random();
    return $"(0{rdm.Next(10, 99)}) 9 {rdm.Next(1000,9999)}-{rdm.Next(1000, 9999)}";
}

static string ObterImeiRandomico() 
{
    var rdm = new Random();
    return $"{rdm.Next(100000, 999999)}/{rdm.Next(10, 99)}/{rdm.Next(100000, 999999)}/{rdm.Next(1, 9)}";
}  