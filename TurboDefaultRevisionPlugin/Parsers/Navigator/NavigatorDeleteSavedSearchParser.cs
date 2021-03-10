using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class NavigatorDeleteSavedSearchParser : AbstractParser<NavigatorDeleteSavedSearchMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new NavigatorDeleteSavedSearchMessage
        {
            SearchID = packet.PopInt()
        };
    }
}
