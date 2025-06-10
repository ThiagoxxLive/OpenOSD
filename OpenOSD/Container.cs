using Autofac;
using OpenOSD.Forms;
using OpenOSD.Entity;


namespace OpenOSD
{
    public static class Container
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //Entity
            
            builder.RegisterType<CPU>().AsSelf().SingleInstance();
            builder.RegisterType<GPU>().AsSelf().SingleInstance();
            builder.RegisterType<RAM>().AsSelf().SingleInstance();
            builder.RegisterType<LAN>().AsSelf().SingleInstance();

            //Service
            builder.RegisterType<CpuService>().AsSelf().SingleInstance();
            builder.RegisterType<GpuService>().AsSelf().SingleInstance();
            builder.RegisterType<RamService>().AsSelf().SingleInstance();
            builder.RegisterType<LanService>().AsSelf().SingleInstance();

            //Form            
            builder.RegisterType<FrmSensors>();
            builder.RegisterType<FrmConfigs>();

            return builder.Build();
        }
    }
}
