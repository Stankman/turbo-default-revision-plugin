using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class ObjectUpdateSerializer : AbstractSerializer<ObjectUpdateMessage>
    {
        public ObjectUpdateSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, ObjectUpdateMessage message)
        {
            ObjectDataSerializer.Serialize(packet, message.Object);
        }
    }
}
