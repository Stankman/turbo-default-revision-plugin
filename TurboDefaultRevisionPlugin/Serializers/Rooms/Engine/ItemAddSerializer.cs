using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class ItemAddSerializer : AbstractSerializer<ItemAddMessage>
    {
        public ItemAddSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, ItemAddMessage message)
        {
            ItemDataSerializer.Serialize(packet, message.Object);
            packet.WriteString(""); // todo: owner name
        }
    }
}
