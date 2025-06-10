using System;
using System.Management;

namespace OpenOSD.Entity
{
    public class RamService
    {

        private RAM ram;

        public RamService(RAM ram) 
        {
            this.ram = ram;
        }

        public void Update()
        {
            try
            {
                this.UpdateUsage();

                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    this.ram.Brand = queryObj["Manufacturer"] != null ? queryObj["Manufacturer"].ToString().Trim() : "Desconhecido";
                    this.ram.Model = queryObj["PartNumber"] != null ? queryObj["PartNumber"].ToString().Trim() : "Desconhecido";
                    
                    this.ram.SpeedMHz = 0;

                    if (queryObj["Speed"] != null)
                    {
                        int speedParsed;
                        if (int.TryParse(queryObj["Speed"].ToString(), out speedParsed))
                        {
                            this.ram.SpeedMHz = speedParsed;
                        }
                    }
                    
                    this.ram.Type = "Desconhecido";

                    ushort memoryType = 0;

                    if (queryObj["SMBIOSMemoryType"] != null)
                    {
                        ushort typeParsed;

                        if (ushort.TryParse(queryObj["SMBIOSMemoryType"].ToString(), out typeParsed))
                        {
                            memoryType = typeParsed;
                        }
                    }

                    switch (memoryType)
                    {
                        case 20:
                            this.ram.Type = "DDR";
                            break;
                        case 21:
                            this.ram.Type = "DDR2";
                            break;
                        case 24:
                            this.ram.Type = "DDR3";
                            break;
                        case 26:
                            this.ram.Type = "DDR4";
                            break;
                        case 27:
                        case 34:
                            this.ram.Type = "DDR5";
                            break;
                        default:
                            this.ram.Type = "Desconhecido";
                            break;
                    }
                    
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter informações de memória: " + ex.Message);
            }
        }

        private void UpdateUsage()
        {
            try
            {
                var searcher = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize, FreePhysicalMemory FROM Win32_OperatingSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    ulong totalMemoryKB = Convert.ToUInt64(queryObj["TotalVisibleMemorySize"]);
                    ulong freeMemoryKB = Convert.ToUInt64(queryObj["FreePhysicalMemory"]);

                    ulong usedMemoryKB = totalMemoryKB - freeMemoryKB;

                    double usedPercent = (double)usedMemoryKB / totalMemoryKB * 100.0;
                    this.ram.UsedMemoryPercent = (int)Math.Round(usedPercent, 0);
                    
                    double usedMemoryGB = usedMemoryKB / 1024.0 / 1024.0;
                    double freeMemoryGB = freeMemoryKB / 1024.0 / 1024.0;

                    this.ram.UsedMemoryGb = (float)Math.Round(usedMemoryGB, 2);
                    this.ram.FreeMemoryGb = (float)Math.Round(freeMemoryGB, 2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter uso de memória: " + ex.Message);
                this.ram.UsedMemoryPercent = 0;
            }
        }
    }
}
