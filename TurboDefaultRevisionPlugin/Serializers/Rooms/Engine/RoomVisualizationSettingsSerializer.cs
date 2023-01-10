using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class RoomVisualizationSettingsSerializer : AbstractSerializer<RoomVisualizationSettingsMessage>
    {
        public RoomVisualizationSettingsSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RoomVisualizationSettingsMessage message)
        {
            packet.WriteBoolean(message.WallsHidden);
            packet.WriteInteger(message.WallThickness);
            packet.WriteInteger(message.FloorThickness);
        }
    }
}
