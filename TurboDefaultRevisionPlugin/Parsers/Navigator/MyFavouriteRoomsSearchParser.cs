using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class MyFavouriteRoomsSearchParser : AbstractParser<MyFavouriteRoomsSearchMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new MyFavouriteRoomsSearchMessage();
    }
}
