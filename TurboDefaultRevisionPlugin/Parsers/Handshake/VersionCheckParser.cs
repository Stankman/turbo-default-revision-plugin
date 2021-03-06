using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Handshake
{
    public class VersionCheckParser : AbstractParser<VersionCheckMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            return new VersionCheckMessage
            {
                ClientID = packet.PopInt(),
                ClientURL = packet.PopString(),
                ExternalVariablesURL = packet.PopString()
            };
        }
    }
}
