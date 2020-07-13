﻿using HomematicIp.Data.Enums;

namespace HomematicIp.Data.HomematicIpObjects.Channels
{
    [EnumMap(FunctionalChannelType.WALL_MOUNTED_THERMOSTAT_BASIC_CHANNEL)]
    public class WallMountedThermostatBasicChannel : ThermostatChannelBase
    {
        public double? ActualTemperature { get; set; }
        public double? VaporAmount { get; set; }
        public double? SetPointTemperature { get; set; }
        public ClimateControlDisplay Display { get; set; }
    }
}