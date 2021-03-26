using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Engine
{
    public class UseWallItemParser : AbstractParser<UseWallItemMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new UseWallItemMessage
        {
            ObjectId = packet.PopInt(),
            Param = packet.PopInt()
        };
    }
}
