using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Furni;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Inventory.Furni
{
    public class RequestFurniInventoryParser : AbstractParser<RequestFurniInventoryMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new RequestFurniInventoryMessage();
    }
}
