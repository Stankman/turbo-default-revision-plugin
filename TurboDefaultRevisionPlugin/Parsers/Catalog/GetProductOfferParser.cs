using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class GetProductOfferParser : AbstractParser<GetProductOfferMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetProductOfferMessage
        {
            OfferId = packet.PopInt()
        };
    }
}