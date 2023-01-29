using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.RoomSettings;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.RoomSettings
{
    public class GetFlatControllersParser : AbstractParser<GetFlatControllersMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetFlatControllersMessage
        {
            RoomId = packet.PopInt()
        };
    }
}