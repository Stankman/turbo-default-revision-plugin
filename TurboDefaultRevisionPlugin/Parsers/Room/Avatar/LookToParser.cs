using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Avatar;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Avatar
{
    public class LookToParser : AbstractParser<LookToMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new LookToMessage
        {
            LocX = packet.PopInt(),
            LocY = packet.PopInt()
        };
    }
}
