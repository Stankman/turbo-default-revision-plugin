using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Engine
{
    public class PickupObjectParser : AbstractParser<PickupObjectMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new PickupObjectMessage
        {
            ObjectCategory = packet.PopInt(),
            ObjectId = packet.PopInt()
        };
    }
}
