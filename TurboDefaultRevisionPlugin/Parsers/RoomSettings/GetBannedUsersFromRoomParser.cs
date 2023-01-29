using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.RoomSettings;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.RoomSettings
{
    public class GetBannedUsersFromRoomParser : AbstractParser<GetBannedUsersFromRoomMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetBannedUsersFromRoomMessage
        {
            RoomId = packet.PopInt()
        };
    }
}