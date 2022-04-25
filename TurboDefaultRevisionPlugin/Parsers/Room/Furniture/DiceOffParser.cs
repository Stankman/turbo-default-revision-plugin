using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Furniture;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Furniture
{
    public class DiceOffParser : AbstractParser<DiceOffMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new DiceOffMessage
        {
            ObjectId = packet.PopInt()
        };
    }
}
