namespace OpenOSD.Entity
{
    public class CPU
    {
        public string Name { get; set; }
        public string Vendor { get; set; }
        public float Temperature { get; set; }
        public float Clock { get; set; }

        public int Usage { get; set; }

        public float Voltage { get; set; }

        public string MotherboardName { get; set; }
    }
}
