using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class DeleteRoomParser : AbstractParser<DeleteRoomMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new DeleteRoomMessage
        {
            RoomID = packet.PopInt()
        };
    }
}
