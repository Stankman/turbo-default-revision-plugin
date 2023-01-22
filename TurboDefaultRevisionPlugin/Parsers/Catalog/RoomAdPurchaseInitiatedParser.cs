using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class RoomAdPurchaseInitiatedParser : AbstractParser<RoomAdPurchaseInitiatedMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new RoomAdPurchaseInitiatedMessage();
    }
}