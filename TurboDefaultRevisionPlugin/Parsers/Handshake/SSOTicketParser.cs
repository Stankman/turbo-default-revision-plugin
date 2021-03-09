using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Handshake
{
    public class SSOTicketParser : AbstractParser<SSOTicketMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new SSOTicketMessage
        {
            SSO = packet.PopString()
        };
    }
}
