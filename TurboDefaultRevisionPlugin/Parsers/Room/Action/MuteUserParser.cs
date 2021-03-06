using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Room.Action;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Action
{
    public class MuteUserParser : AbstractParser<MuteUserMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            return new MuteUserMessage
            {
                UserId = packet.PopInt(),
                RoomId = packet.PopInt(),
                Minutes = packet.PopInt()
            };
        }
    }
}
