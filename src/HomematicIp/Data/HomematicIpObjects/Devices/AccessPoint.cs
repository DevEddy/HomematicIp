namespace HomematicIp.Data.HomematicIpObjects.Devices
{
    [EnumMap(Enums.DeviceType.ACCESS_POINT)]
    public class AccessPoint : Device
    {
        public string ConnectionType { get; set; }
    }
}
