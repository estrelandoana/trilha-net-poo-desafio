namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            // TODO: Sobrescrever o método "InstalarAplicativo"
            Console.WriteLine($"Instalando aplicativo {nomeApp} no seu aparelho Iphone...");
        }
    }
}