using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Session;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Session
{
    public class OpenFlatConnectionParser : AbstractParser<OpenFlatConnectionMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new OpenFlatConnectionMessage { 
            RoomId = packet.PopInt(),
            Password = packet.PopString()
        };
    }
}
