using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class ForwardToSomeRoomParser : AbstractParser<ForwardToSomeRoomMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new ForwardToSomeRoomMessage
        {
            ForwardData = packet.PopString()
        };
    }
}
