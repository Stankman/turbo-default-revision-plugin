using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Navigator
{
    public class NavigatorAddCollapsedCategoryParser : AbstractParser<NavigatorAddCollapsedCategoryMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new NavigatorAddCollapsedCategoryMessage
        {
            CategoryName = packet.PopString()
        };
    }
}
