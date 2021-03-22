﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Avatar;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Avatar
{
    public class DanceParser : AbstractParser<DanceMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new DanceMessage
        {
            Style = packet.PopInt()
        };
    }
}
