using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class ShopTargetedOfferViewedParser : AbstractParser<ShopTargetedOfferViewedMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new ShopTargetedOfferViewedMessage
        {
            TargetedOfferId = packet.PopInt(),
            TrackingState = packet.PopInt()
        };
    }
}