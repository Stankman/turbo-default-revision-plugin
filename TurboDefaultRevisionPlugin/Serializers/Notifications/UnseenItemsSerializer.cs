using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Notifications;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Notifications
{
    public class UnseenItemsSerializer : AbstractSerializer<UnseenItemsMessage>
    {
        public UnseenItemsSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, UnseenItemsMessage message)
        {
            packet.WriteInteger(message.Categories.Count);

            foreach (var category in message.Categories)
            {
                packet.WriteInteger((int)category.Key);

                packet.WriteInteger(category.Value.Count);

                foreach (var itemId in category.Value) packet.WriteInteger(itemId);
            }
        }
    }
}