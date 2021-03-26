using System;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Furni;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Inventory.Furni
{
    public class RequestFurniInventoryWhenNotInRoomParser : AbstractParser<RequestFurniInventoryWhenNotInRoomMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new RequestFurniInventoryWhenNotInRoomMessage();
    }
}
