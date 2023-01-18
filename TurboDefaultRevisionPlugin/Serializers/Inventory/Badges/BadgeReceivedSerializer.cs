using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Badges;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Badges
{
    public class BadgeReceivedSerializer : AbstractSerializer<BadgeReceivedMessage>
    {
        public BadgeReceivedSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, BadgeReceivedMessage message)
        {
            packet.WriteInteger(message.Badge.Id);
            packet.WriteString(message.Badge.BadgeCode);
        }
    }
}