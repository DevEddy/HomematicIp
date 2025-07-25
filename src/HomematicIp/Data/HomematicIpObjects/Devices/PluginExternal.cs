namespace HomematicIp.Data.HomematicIpObjects.Devices
{
    [EnumMap(Enums.DeviceType.PLUGIN_EXTERNAL)]
    public class PluginExternal : Device
    {
        public string ExternalService { get; set; }
        public string? AccountLinkingId { get; set; }
        // e.g de.eq3.plugin.homematic
        public string PluginId { get; set; }
        // e.g. 0034DF29B942EC:3
        public string PluginDeviceId { get; set; }
        // e.g PLUGIN 
        public string deviceArchetype { get; set; }
        // e.g. EXTERNAL
        public string ConnectionType { get; set; }
    }
}
