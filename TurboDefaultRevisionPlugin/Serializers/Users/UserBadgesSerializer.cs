using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Users;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Users
{
    public class UserBadgesSerializer : AbstractSerializer<UserBadgesMessage>
    {
        public UserBadgesSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, UserBadgesMessage message)
        {
            packet.WriteInteger(message.PlayerId);
            packet.WriteInteger(message.ActiveBadges.Count);

            foreach (var badge in message.ActiveBadges)
            {
                packet.WriteInteger(badge.SlotId ?? 0);
                packet.WriteString(badge.BadgeCode);
            }
        }
    }
}