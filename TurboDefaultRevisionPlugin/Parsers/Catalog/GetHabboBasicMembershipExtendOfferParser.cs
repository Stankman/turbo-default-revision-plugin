using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class GetHabboBasicMembershipExtendOfferParser : AbstractParser<GetHabboBasicMembershipExtendOfferMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetHabboBasicMembershipExtendOfferMessage();
    }
}