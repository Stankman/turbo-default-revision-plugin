using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Session;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Session
{
    public class GoToFlatParser : AbstractParser<GoToFlatMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GoToFlatMessage { RoomId = packet.PopInt() };
    }
}
