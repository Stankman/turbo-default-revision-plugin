using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class GetIsOfferGiftableParser : AbstractParser<GetIsOfferGiftableMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetIsOfferGiftableMessage
        {
            OfferId = packet.PopInt()
        };
    }
}