using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class ObjectAddSerializer : AbstractSerializer<ObjectAddMessage>
    {
        public ObjectAddSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, ObjectAddMessage message)
        {
            ObjectDataSerializer.Serialize(packet, message.Object);
            packet.WriteString(message.OwnerName);
        }
    }
}
