using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class ItemDataUpdateSerializer : AbstractSerializer<ItemDataUpdateMessage>
    {
        public ItemDataUpdateSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, ItemDataUpdateMessage message)
        {
            packet.WriteString(message.ItemId.ToString());
            packet.WriteString(message.ItemData);
        }
    }
}
