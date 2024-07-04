using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Action;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Action
{
    public class LetUserInParser : AbstractParser<LetUserInMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new LetUserInMessage
        {
            Username = packet.PopString(),
            CanEnter = packet.PopBoolean()
        };
    }
}