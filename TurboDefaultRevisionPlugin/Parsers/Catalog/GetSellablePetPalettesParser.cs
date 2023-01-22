using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class GetSellablePetPalettesParser : AbstractParser<GetSellablePetPalettesMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetSellablePetPalettesMessage
        {
            LocalizationId = packet.PopInt()
        };
    }
}