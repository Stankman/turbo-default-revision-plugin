using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Handshake
{
    public class CompleteDiffieHandshakeParser : AbstractParser<CompleteDiffieHandshakeMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new CompleteDiffieHandshakeMessage
        {
            PublicKey = packet.PopString()
        };
    }
}
