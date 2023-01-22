using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class GetNextTargetedOfferParser : AbstractParser<GetNextTargetedOfferMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetNextTargetedOfferMessage
        {
            OfferId = packet.PopInt()
        };
    }
}