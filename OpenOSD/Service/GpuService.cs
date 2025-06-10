using LibreHardwareMonitor.Hardware;
using OpenOSD.Service;
using System;
using System.Linq;

namespace OpenOSD.Entity
{
    public class GpuService : BaseService
    {
        private readonly Computer Computer;
        private GPU gpu;
        private readonly object _updateLock = new object();

        public GpuService(GPU gpu)
        {
            this.gpu = gpu;
            this.Computer = this.GetComputer();
            this.Computer.Open();
        }

        private Computer GetComputer()
        {
            return new Computer
            {
                IsGpuEnabled = true
            };
        }

        private IHardware[] GetHardware(IHardware hardware)
        {
            return new IHardware[] { hardware };
        }

        public void Update()
        {
            lock (_updateLock) 
            {

                var Hardware = this.Computer.Hardware.FirstOrDefault(h => h.HardwareType == HardwareType.GpuAmd || h.HardwareType == HardwareType.GpuNvidia || h.HardwareType == HardwareType.GpuIntel);

                if (Hardware != null)
                {
                    Hardware.Update();

                    this.gpu.Name = Hardware.Name;
                    this.gpu.Vendor = this.HandleGpuVendor(Hardware.Name);
                    this.gpu.Temperature = this.GetGpuTemperature(Hardware);
                    this.gpu.Clock = this.GetGpuClock(Hardware);
                    this.gpu.Usage = this.GetGpuLoad(Hardware);
                    this.gpu.Voltage = this.GetGpuVoltage(Hardware);
                    this.gpu.Vram = this.GetVram(Hardware);
                }
            }
        }

        private string HandleGpuVendor(string Name)
        {   
            return new[] { "NVIDIA", "AMD", "Intel" }.FirstOrDefault(v => Name.IndexOf(v, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private float GetGpuTemperature(IHardware hardware)
        {            
            return GetValues(this.GetHardware(hardware), SensorType.Temperature, new[] { "gpu core", "gpu temperature", "core" });
        }

        private float GetGpuClock(IHardware hardware)
        {            
            return GetValues(this.GetHardware(hardware), SensorType.Clock, new[] { "gpu core", "GPU Core", "Core", "Graphics" });
        }

        private int GetGpuLoad(IHardware hardware)
        {            
            return (int)Math.Round(GetValues(this.GetHardware(hardware), SensorType.Load, new[] { "GPU Core", "GPU Usage", "Usage" }));
        }

        private float GetGpuVoltage(IHardware hardware)
        {            
            return GetValues(this.GetHardware(hardware), SensorType.Voltage, new[] { "GPU Core", "Core", "GPU" });
        }

        private float GetVram(IHardware hardware)
        {            
            return GetValues(this.GetHardware(hardware), SensorType.SmallData, new[] { "Memory Used" });
        }

        public void Close()
        {
            this.Computer.Close();
        }
    }
}
