using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Session;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Session
{
    public class ChangeQueueParser : AbstractParser<ChangeQueueMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new ChangeQueueMessage { TargetQueue = packet.PopInt() };
    }
}
