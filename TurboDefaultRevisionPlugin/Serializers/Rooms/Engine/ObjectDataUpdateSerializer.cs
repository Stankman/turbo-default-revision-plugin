using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class ObjectDataUpdateSerializer : AbstractSerializer<ObjectDataUpdateMessage>
    {
        public ObjectDataUpdateSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, ObjectDataUpdateMessage message)
        {
            packet.WriteString(message.Object.Id.ToString());
            StuffDataSerializer.Serialize(packet, message.Object);
        }
    }
}
