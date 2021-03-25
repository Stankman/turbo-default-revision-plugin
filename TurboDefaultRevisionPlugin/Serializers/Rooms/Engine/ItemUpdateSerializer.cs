using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class ItemUpdateSerializer : AbstractSerializer<ItemUpdateMessage>
    {
        public ItemUpdateSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, ItemUpdateMessage message)
        {
            ItemDataSerializer.Serialize(packet, message.Object);
        }
    }
}
