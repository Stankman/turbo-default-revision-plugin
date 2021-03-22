using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Avatar;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Avatar
{
    public class AvatarExpressionParser : AbstractParser<AvatarExpressionMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new AvatarExpressionMessage { TypeCode = packet.PopInt() };
    }
}
