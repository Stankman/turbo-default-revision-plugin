using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class RoomsWithHighestScoreSearchParser : AbstractParser<RoomsWithHighestScoreSearchMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new RoomsWithHighestScoreSearchMessage();
    }
}
