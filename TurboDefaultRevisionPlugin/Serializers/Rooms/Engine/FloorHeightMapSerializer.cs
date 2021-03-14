using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class FloorHeightMapSerializer : AbstractSerializer<FloorHeightMapMessage>
    {
        public FloorHeightMapSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, FloorHeightMapMessage message)
        {
            packet.WriteBoolean(message.IsZoomedIn);
            packet.WriteInteger(message.WallHeight);
            packet.WriteString(message.RoomModel.Model);
        }
    }
}
