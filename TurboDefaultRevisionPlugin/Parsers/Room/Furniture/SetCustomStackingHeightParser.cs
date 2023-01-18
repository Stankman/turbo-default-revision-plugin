using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Furniture;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Furniture
{
    public class SetCustomStackingHeightParser : AbstractParser<SetCustomStackingHeightMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new SetCustomStackingHeightMessage
        {
            FurniId = packet.PopInt(),
            Height = packet.PopInt()
        };
    }
}