using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class NavigatorSetSearchCodeViewModeParser : AbstractParser<NavigatorSetSearchCodeViewModeMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new NavigatorSetSearchCodeViewModeMessage
        {
            CategoryName = packet.PopString(),
            ViewMode = packet.PopInt()
        };
    }
}
