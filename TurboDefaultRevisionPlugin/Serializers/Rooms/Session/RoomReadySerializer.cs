using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Session
{
    public class RoomReadySerializer : AbstractSerializer<RoomReadyMessage>
    {
        public RoomReadySerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RoomReadyMessage message)
        {
            packet.WriteString(message.RoomType);
            packet.WriteInteger(message.RoomId);
        }
    }
}
