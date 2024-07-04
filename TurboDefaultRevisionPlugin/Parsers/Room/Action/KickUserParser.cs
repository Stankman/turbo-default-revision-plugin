using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Action;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Action
{
    public class KickUserParser : AbstractParser<KickUserMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new KickUserMessage
        {
            PlayerId = packet.PopInt()
        };
    }
}
