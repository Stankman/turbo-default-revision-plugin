using System.Collections.Generic;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Badges;
using Turbo.Packets.Parsers;
using Turbo.Core.Game;

namespace TurboDefaultRevisionPlugin.Parsers.Inventory.Badges
{
    public class SetActivatedBadgesParser : AbstractParser<SetActivatedBadgesMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            IDictionary<int, string> Badges = new Dictionary<int, string>();

            for (int i = 0; i < DefaultSettings.MaxActiveBadges; i++) Badges.Add(packet.PopInt(), packet.PopString());

            return new SetActivatedBadgesMessage
            {
                Badges = Badges
            };
        }
    }
}