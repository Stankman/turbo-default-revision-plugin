using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Permissions;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Permissions
{
    public class YouAreControllerSerializer : AbstractSerializer<YouAreControllerMessage>
    {
        public YouAreControllerSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, YouAreControllerMessage message)
        {
            packet.WriteInteger((int)message.RoomControllerLevel);
        }
    }
}
