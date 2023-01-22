using Turbo.Core.Game.Catalog.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class GetClubOffersParser : AbstractParser<GetClubOffersMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetClubOffersMessage
        {
            RequestSource = (ClubOfferRequestSource)packet.PopInt()
        };
    }
}