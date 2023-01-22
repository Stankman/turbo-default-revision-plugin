using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class SelectClubGiftParser : AbstractParser<SelectClubGiftMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new SelectClubGiftMessage
        {
            ProductCode = packet.PopString()
        };
    }
}