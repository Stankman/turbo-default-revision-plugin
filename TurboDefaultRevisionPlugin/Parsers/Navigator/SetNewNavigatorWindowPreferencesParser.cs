using Turbo.Core.Game.Navigator.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class SetNewNavigatorWindowPreferencesParser : AbstractParser<SetNewNavigatorWindowPreferencesMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            var x = packet.PopInt();
            var y = packet.PopInt();
            var width = packet.PopInt();
            var height = packet.PopInt();
            var openSavedSearches = packet.PopBoolean();
            var resultsModeInt = packet.PopInt();

            NavigatorResultsMode resultsMode;
            switch(resultsModeInt)
            {
                case 1:
                    resultsMode = NavigatorResultsMode.Tiles;
                    break;
                default:
                    resultsMode = NavigatorResultsMode.Rows;
                    break;
            }

            return new SetNewNavigatorWindowPreferencesMessage
            {
                X = x,
                Y = y,
                Width = width,
                Height = height,
                OpenSavedSearches = openSavedSearches,
                ResultsMode = resultsMode
            };
        }
    }
}
