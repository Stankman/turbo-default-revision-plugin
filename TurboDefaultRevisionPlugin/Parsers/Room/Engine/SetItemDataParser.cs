using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Engine
{
    public class SetItemDataParser : AbstractParser<SetItemDataMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new SetItemDataMessage
        {
            ObjectId = packet.PopInt(),
            ColorHex = packet.PopString(),
            Data = packet.PopString()
        };
    }
}
