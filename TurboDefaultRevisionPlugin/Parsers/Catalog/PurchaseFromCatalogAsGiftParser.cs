using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class PurchaseFromCatalogAsGiftParser : AbstractParser<PurchaseFromCatalogAsGiftMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new PurchaseFromCatalogAsGiftMessage
        {
            PageId = packet.PopInt(),
            OfferCode = packet.PopInt(),
            ExtraParam = packet.PopString(),
            RecieverName = packet.PopString(),
            Message = packet.PopString(),
            BoxStuffTypeId = packet.PopInt(),
            BoxTypeId = packet.PopInt(),
            RibbonTypeId = packet.PopInt(),
            ShowPurchaserName = packet.PopBoolean()
        };
    }
}