using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.RoomSettings;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.RoomSettings
{
    public class GetCustomRoomFilterParser : AbstractParser<GetCustomRoomFilterMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetCustomRoomFilterMessage
        {
            RoomId = packet.PopInt()
        };
    }
}