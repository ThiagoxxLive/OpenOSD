using LibreHardwareMonitor.Hardware;
using System.Linq;

namespace OpenOSD.Service
{
    public class BaseService
    {
        public float GetValues(IHardware[] hardwares, SensorType sensorType, string[] targetSensorNames, float fallback = 0f, bool subtractCpuTempDiff = false){

            float highestValue = fallback;

            foreach (var hardware in hardwares)
            {
                hardware.Update();

                foreach (var subHardware in hardware.SubHardware)
                {
                    subHardware.Update();
                }

                var allSensors = hardware.Sensors.Concat(hardware.SubHardware.SelectMany(sh => sh.Sensors));

                foreach (var sensor in allSensors)
                {
                    if (sensor.SensorType == sensorType && sensor.Value.HasValue)
                    {
                        var sensorName = sensor.Name.ToLower();
                        
                        if (targetSensorNames.Any(target => sensorName.Contains(target.ToLower())))
                        {
                            var value = sensor.Value.Value;

                            if (subtractCpuTempDiff && sensorType == SensorType.Temperature)
                                value -= Properties.Settings.Default.CpuTempDiff;

                            return value;
                        }
                        
                        if (sensor.Value.Value > highestValue)
                        {
                            highestValue = sensor.Value.Value;
                        }
                    }
                }
            }

            return subtractCpuTempDiff && sensorType == SensorType.Temperature
                ? highestValue - Properties.Settings.Default.CpuTempDiff
                : highestValue;
        }
    }
}