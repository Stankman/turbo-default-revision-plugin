using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Action;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Action
{
    public class AssignRightsParser : AbstractParser<AssignRightsMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new AssignRightsMessage
        {
            PlayerId = packet.PopInt()
        };
    }
}
