using Turbo.Core.Game.Navigator.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class NavigatorSetSearchCodeViewModeParser : AbstractParser<NavigatorSetSearchCodeViewModeMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            var categoryName = packet.PopString();
            var viewModeInt = packet.PopInt();

            NavigatorResultsMode viewMode;
            switch(viewModeInt)
            {
                case 1:
                    viewMode = NavigatorResultsMode.TILES;
                    break;
                default:
                    viewMode = NavigatorResultsMode.ROWS;
                    break;
            }

            return new NavigatorSetSearchCodeViewModeMessage
            {
                CategoryName = categoryName,
                ViewMode = viewMode
            };
        }
    }
}
