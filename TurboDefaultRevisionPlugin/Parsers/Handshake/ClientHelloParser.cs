﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Handshake
{
    public class ClientHelloParser : AbstractParser<ClientHelloMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new ClientHelloMessage
        {
            Production = packet.PopString(),
            Platform = packet.PopString(),
            ClientPlatform = packet.PopInt(),
            DeviceCategory = packet.PopInt()
        };
    }
}
