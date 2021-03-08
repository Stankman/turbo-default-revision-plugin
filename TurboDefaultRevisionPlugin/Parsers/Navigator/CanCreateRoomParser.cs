using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class CanCreateRoomParser : AbstractParser<CanCreateRoomMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new CanCreateRoomMessage();
    }
}
