using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Engine
{
    public class MoveWallItemParser : AbstractParser<MoveWallItemMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new MoveWallItemMessage
        {
            ObjectId = packet.PopInt(),
            Location = packet.PopString()
        };
    }
}
