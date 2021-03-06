using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Room.Action;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Action
{
    public class KickUserParser : AbstractParser<KickUserMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            return new KickUserMessage
            {
                UserId = packet.PopInt()
            };
        }
    }
}
