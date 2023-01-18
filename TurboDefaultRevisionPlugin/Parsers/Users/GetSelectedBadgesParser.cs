using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Users;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Users
{
    public class GetSelectedBadgesParser : AbstractParser<GetSelectedBadgesMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetSelectedBadgesMessage
        {
            PlayerId = packet.PopInt()
        };
    }
}