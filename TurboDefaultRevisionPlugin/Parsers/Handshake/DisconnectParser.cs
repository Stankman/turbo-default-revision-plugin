using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Handshake
{
    public class DisconnectParser : AbstractParser<DisconnectMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new DisconnectMessage();
    }
}
