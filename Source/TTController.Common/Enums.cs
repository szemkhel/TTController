﻿namespace TTController.Common
{
    public enum ColorGenerationMethod
    {
        PerPort,
        SpanPorts
    }

    public enum SensorMixFunction
    {
        Minimum,
        Maximum,
        Average
    }

    public enum DeviceType
    {
        Default,
        RiingTrio,
        SwafanTrio,
        RiingDuo,
        FloeRiing,
        PurePlus
    }
}
