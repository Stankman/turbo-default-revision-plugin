using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Badges;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Badges
{
    public class BadgeSerializer : AbstractSerializer<BadgeMessage>
    {
        public BadgeSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, BadgeMessage message)
        {
            packet.WriteInteger(message.Badges.Count);

            foreach (var badge in message.Badges)
            {
                packet.WriteInteger(badge.Id);
                packet.WriteString(badge.BadgeCode);
            }

            packet.WriteInteger(message.ActiveBadges.Count);

            foreach (var badge in message.ActiveBadges)
            {
                packet.WriteInteger(badge.Id);
                packet.WriteString(badge.BadgeCode);
            }
        }
    }
}