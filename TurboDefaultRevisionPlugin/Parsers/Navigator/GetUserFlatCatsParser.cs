using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class GetUserFlatCatsParser : AbstractParser<GetUserFlatCatsMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetUserFlatCatsMessage();
    }
}
