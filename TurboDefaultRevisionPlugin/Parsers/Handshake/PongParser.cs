using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Handshake
{
    public class PongParser : AbstractParser<PongMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new PongMessage();
    }
}
