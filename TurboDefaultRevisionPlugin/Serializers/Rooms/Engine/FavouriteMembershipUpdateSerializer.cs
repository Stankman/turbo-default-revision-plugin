using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class FavouriteMembershipUpdateSerializer : AbstractSerializer<FavouriteMembershipUpdateMessage>
    {
        public FavouriteMembershipUpdateSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, FavouriteMembershipUpdateMessage message)
        {
            packet.WriteInteger(message.RoomIndex);
            packet.WriteInteger(message.GroupId);
            packet.WriteInteger((int)message.Status);
            packet.WriteString(message.GroupName);
        }
    }
}
