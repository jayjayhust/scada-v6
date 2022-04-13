﻿// Copyright (c) Rapid Software LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Scada.Lang;

namespace Scada.Comm.Drivers.DrvMqttClient.View
{
    /// <summary>
    /// The phrases used by the driver.
    /// <para>Фразы, используемые драйвером.</para>
    /// </summary>
    public static class DriverPhrases
    {
        // Scada.Comm.Drivers.DrvMqttClient.View.MqttClientConfigProvider
        public static string OptionsNode { get; private set; }
        public static string SubscriptionsNode { get; private set; }
        public static string CommandsNode { get; private set; }

        public static void Init()
        {
            LocaleDict dict = Locale.GetDictionary("Scada.Comm.Drivers.DrvMqttClient.View.MqttClientConfigProvider");
            OptionsNode = dict[nameof(OptionsNode)];
            SubscriptionsNode = dict[nameof(SubscriptionsNode)];
            CommandsNode = dict[nameof(CommandsNode)];
        }
    }
}