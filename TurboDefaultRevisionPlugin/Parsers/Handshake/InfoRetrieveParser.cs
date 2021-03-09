using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Handshake
{
    public class InfoRetrieveParser : AbstractParser<InfoRetrieveMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new InfoRetrieveMessage();
    }
}
