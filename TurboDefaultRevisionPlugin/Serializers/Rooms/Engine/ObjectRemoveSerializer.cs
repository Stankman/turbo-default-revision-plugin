using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class ObjectRemoveSerializer : AbstractSerializer<ObjectRemoveMessage>
    {
        public ObjectRemoveSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, ObjectRemoveMessage message)
        {
            packet.WriteString(message.Id.ToString());
            packet.WriteBoolean(message.IsExpired);
            packet.WriteInteger(message.PickerId);
            packet.WriteInteger(message.Delay);
        }
    }
}
