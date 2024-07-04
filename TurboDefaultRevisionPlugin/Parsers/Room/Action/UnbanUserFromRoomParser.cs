using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Action;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Action
{
    public class UnbanUserFromRoomParser : AbstractParser<UnbanUserFromRoomMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new UnbanUserFromRoomMessage
        {
            PlayerId = packet.PopInt(),
            RoomId = packet.PopInt()
        };
    }
}