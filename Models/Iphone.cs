namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        // Sobrescrever o método "InstalarAplicativo"
        override public void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicatico {nomeApp} no IPhone.");
        }
    }
}