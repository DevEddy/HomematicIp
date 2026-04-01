using System.Collections.Generic;
using Newtonsoft.Json;

namespace HomematicIp.Data.HomematicIpObjects.Groups
{
    
    [EnumMap(Enums.GroupType.EXTENDED_LINKED_NOTIFICATION)]
    public class ExtendedLinkedNotification : Group
    {
        [JsonProperty(PropertyName = "dimLevel")]
        public double? DimLevel { get; set; }
        [JsonProperty(PropertyName = "on")]
        public bool? IsOn { get; set; }
        [JsonProperty(PropertyName = "triggered")]
        public bool? IsTriggered { get; set; }
        public double? DimStep { get; set; }
        public double? VolumeLevel { get; set; }
        // SOUNDFILE_241
        public string SoundFile { get; set; }
        // YELLOW
        [JsonProperty(PropertyName = "simpleRGBColorState")]
        public string SimpleRgbColorState { get; set; }
        public string OpticalSignalBehaviour { get; set; }
        public double? OnVolumeLevel { get; set; }
        // SOUNDFILE_241
        public string OnSoundFile { get; set; }
        public double? SoundOnTime { get; set; }
        [JsonProperty(PropertyName = "onSimpleRGBColor")]
        public string OnSimpleRgbColor { get; set; }
        public double? OnLevel { get; set; }
        // ON
        public string OnOpticalSignalBehaviour { get; set; }
        // "sensorSpecificParameters": {
        //     "3014F711A00026E2698F48E6:1": {
        //         "type": "SINGLE_CHANNEL_INPUT_ACTION",
        //         "singleChannelInputAction": "ON_UP"
        //     }
        // },
    }
}