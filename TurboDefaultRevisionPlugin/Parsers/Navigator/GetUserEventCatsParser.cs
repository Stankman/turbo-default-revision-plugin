using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class GetUserEventCatsParser : AbstractParser<GetUserEventCatsMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetUserEventCatsMessage();
    }
}
