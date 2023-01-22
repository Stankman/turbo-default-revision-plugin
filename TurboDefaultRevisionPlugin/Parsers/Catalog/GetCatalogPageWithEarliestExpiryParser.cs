using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class GetCatalogPageWithEarliestExpiryParser : AbstractParser<GetCatalogPageWithEarliestExpiryMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetCatalogPageWithEarliestExpiryMessage();
    }
}