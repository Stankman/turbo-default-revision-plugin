using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Handshake
{
    public class InitDiffieHandshakeParser : AbstractParser<InitDiffieHandshakeMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new InitDiffieHandshakeMessage();
    }
}
