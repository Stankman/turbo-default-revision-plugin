using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.RoomSettings;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.RoomSettings
{
    public class GetRoomSettingsParser : AbstractParser<GetRoomSettingsMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetRoomSettingsMessage
        {
            RoomId = packet.PopInt()
        };
    }
}