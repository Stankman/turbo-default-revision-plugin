using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class NewNavigatorInitParser : AbstractParser<NewNavigatorInitMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new NewNavigatorInitMessage();
    }
}
