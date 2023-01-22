using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class PurchaseVipMembershipExtensionParser : AbstractParser<PurchaseVipMembershipExtensionMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new PurchaseVipMembershipExtensionMessage
        {
            OfferId = packet.PopInt()
        };
    }
}