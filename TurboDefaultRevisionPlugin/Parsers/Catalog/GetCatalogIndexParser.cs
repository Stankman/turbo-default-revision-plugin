using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class GetCatalogIndexParser : AbstractParser<GetCatalogIndexMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetCatalogIndexMessage
        {
            Type = packet.PopString()
        };
    }
}