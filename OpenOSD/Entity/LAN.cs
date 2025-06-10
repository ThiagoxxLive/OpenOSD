namespace OpenOSD.Entity
{
    public class LAN
    {
        public float DownloadSpeedBps { get; set; }
        public float UploadSpeedBps { get; set; }
        public string InternalIP { get; set; }
        public string ExternalIP { get; set; }

        public float DownloadMBps => this.DownloadSpeedBps / (1024f * 1024f);
        public float UploadMBps => this.UploadSpeedBps / (1024f * 1024f);
    }
}
