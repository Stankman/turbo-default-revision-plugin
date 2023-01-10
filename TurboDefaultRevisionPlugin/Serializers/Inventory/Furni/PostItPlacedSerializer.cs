using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Furni
{
    public class PostItPlacedSerializer : AbstractSerializer<PostItPlacedMessage>
    {
        public PostItPlacedSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, PostItPlacedMessage message)
        {
            packet.WriteInteger(message.Id);
            packet.WriteInteger(message.ItemsLeft);
        }
    }
}
