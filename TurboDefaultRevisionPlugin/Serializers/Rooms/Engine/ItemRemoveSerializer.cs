using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class ItemRemoveSerializer : AbstractSerializer<ItemRemoveMessage>
    {
        public ItemRemoveSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, ItemRemoveMessage message)
        {
            packet.WriteString(message.ItemId.ToString());
            packet.WriteInteger(message.PickerId);
        }
    }
}
