using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class PurchaseTargetedOfferParser : AbstractParser<PurchaseTargetedOfferMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new PurchaseTargetedOfferMessage
        {
            OfferId = packet.PopInt(),
            Quantity = packet.PopInt()
        };
    }
}