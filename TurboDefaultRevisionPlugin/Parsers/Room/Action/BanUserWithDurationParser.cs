using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Action;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Action
{
    public class BanUserWithDurationParser : AbstractParser<BanUserWithDurationMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new BanUserWithDurationMessage
        {
            PlayerId = packet.PopInt(),
            RoomId = packet.PopInt(),
            BanType = packet.PopString()
        };
    }
}