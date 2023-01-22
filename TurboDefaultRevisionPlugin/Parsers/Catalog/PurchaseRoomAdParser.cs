using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Catalog
{
    public class PurchaseRoomAdParser : AbstractParser<PurchaseRoomAdMessageMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new PurchaseRoomAdMessageMessage
        {
            PageId = packet.PopInt(),
            OfferId = packet.PopInt(),
            FlatId = packet.PopInt(),
            Name = packet.PopString(),
            Extended = packet.PopBoolean(),
            Description = packet.PopString(),
            CategoryId = packet.PopInt()
        };
    }
}