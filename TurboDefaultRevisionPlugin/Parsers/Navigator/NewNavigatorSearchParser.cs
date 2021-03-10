using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class NewNavigatorSearchParser : AbstractParser<NewNavigatorSearchMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new NewNavigatorSearchMessage()
        {
            View = packet.PopString(),
            Query = packet.PopString()
        };
    }
}
