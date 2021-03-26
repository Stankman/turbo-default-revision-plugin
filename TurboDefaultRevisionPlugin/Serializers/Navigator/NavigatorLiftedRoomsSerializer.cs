using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Headers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class NavigatorLiftedRoomsSerializer : AbstractSerializer<NavigatorLiftedRoomsMessage>
    {
        public NavigatorLiftedRoomsSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, NavigatorLiftedRoomsMessage message)
        {
            packet.WriteInteger(message.LiftedRooms?.Count ?? 0);
            message.LiftedRooms?.ForEach(room =>
            {
                packet.WriteInteger(room.FlatId);
                packet.WriteInteger(room.Unused);
                packet.WriteString(room.Image);
                packet.WriteString(room.Caption);
            });
        }
    }
}
