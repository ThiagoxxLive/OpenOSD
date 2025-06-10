namespace OpenOSD.Entity
{
    public class RAM
    {
        public string Brand { get; set; } = "Desconhecido";
        public string Model { get; set; } = "Desconhecido";
        public string Type { get; set; } = "Desconhecido";

        public int SpeedMHz { get;  set; } = 0;

        public int UsedMemoryPercent { get; set; }
        public float UsedMemoryGb { get; set; }
        public float FreeMemoryGb { get; set; }

        public string GetModel()
        {
            return $"{this.Brand.ToUpper()} {this.Type}-{this.SpeedMHz}";
        }
    }
}
