using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class GetDirectClubBuyAvailableParser : AbstractParser<GetDirectClubBuyAvailableMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetDirectClubBuyAvailableMessage
        {
            Days = packet.PopInt()
        };
    }
}