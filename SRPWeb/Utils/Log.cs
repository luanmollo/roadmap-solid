namespace SRPWeb.Utils
{
    public class Log
    {
        private readonly string Nombre = "log.txt";

        public async void Guardar(string content)
        {
            await File.WriteAllTextAsync(Nombre, content);
        }
    }
}
