using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.RoomSettings;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.RoomSettings
{
    public class UpdateRoomFilterParser : AbstractParser<UpdateRoomFilterMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new UpdateRoomFilterMessage
        {
            RoomId = packet.PopInt(),
            IsAddingWord = packet.PopBoolean(),
            Word = packet.PopString()
        };
    }
}