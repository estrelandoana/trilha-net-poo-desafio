using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    public static void Main(string[] args)
    {
        Nokia nokia = new Nokia("999999999", "Nokia 3310", "123456789", 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("TikTok");

        Iphone iphone = new Iphone("999999999", "Iphone 11", "123456789", 64);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}