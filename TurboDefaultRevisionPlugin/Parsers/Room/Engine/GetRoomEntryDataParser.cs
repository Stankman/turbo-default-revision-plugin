﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Engine
{
    public class GetRoomEntryDataParser : AbstractParser<GetRoomEntryDataMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetRoomEntryDataMessage();
    }
}
