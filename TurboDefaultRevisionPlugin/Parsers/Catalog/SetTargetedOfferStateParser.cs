using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class SetTargetedOfferStateParser : AbstractParser<SetTargetedOfferStateMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new SetTargetedOfferStateMessage
        {
            TargetedOfferId = packet.PopInt(),
            TrackingState = packet.PopInt()
        };
    }
}