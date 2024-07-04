using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Action;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Action
{
    public class RoomUserKickParser : AbstractParser<RoomUserKickMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new RoomUserKickMessage
        {
            PlayerId = packet.PopInt()
        };
    }
}
