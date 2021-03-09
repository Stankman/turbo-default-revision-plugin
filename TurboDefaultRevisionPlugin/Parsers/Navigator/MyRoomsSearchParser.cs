using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class MyRoomsSearchParser : AbstractParser<MyRoomsSearchMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new MyRoomsSearchMessage();
    }
}
