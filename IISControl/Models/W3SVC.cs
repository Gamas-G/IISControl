namespace IISControl.Models
{
    public class W3SVC
    {
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public int Estado { get; set; }
    }
    public enum Estado
    {
        STOPPED = 2,
        RUNNING = 4
    }
}
