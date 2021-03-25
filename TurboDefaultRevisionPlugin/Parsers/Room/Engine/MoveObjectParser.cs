using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Engine
{
    public class MoveObjectParser : AbstractParser<MoveObjectMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new MoveObjectMessage
        {
            ObjectId = packet.PopInt(),
            X = packet.PopInt(),
            Y = packet.PopInt(),
            Direction = packet.PopInt()
        };
    }
}
