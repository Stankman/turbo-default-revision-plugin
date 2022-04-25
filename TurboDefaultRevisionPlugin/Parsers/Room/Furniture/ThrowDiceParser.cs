using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Furniture;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Furniture
{
    public class ThrowDiceParser : AbstractParser<ThrowDiceMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new ThrowDiceMessage
        {
            ObjectId = packet.PopInt()
        };
    }
}
