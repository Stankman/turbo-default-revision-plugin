using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class RoomPropertySerializer : AbstractSerializer<RoomPropertyMessage>
    {
        public RoomPropertySerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, RoomPropertyMessage message)
        {
            packet.WriteString(message.Property);
            packet.WriteString(message.Value);
        }
    }
}
