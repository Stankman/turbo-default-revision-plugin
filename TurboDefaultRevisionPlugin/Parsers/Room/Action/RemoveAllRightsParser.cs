using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Action;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Action
{
    public class RemoveAllRightsParser : AbstractParser<RemoveAllRightsMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new RemoveAllRightsMessage
        {
            RoomId = packet.PopInt()
        };
    }
}