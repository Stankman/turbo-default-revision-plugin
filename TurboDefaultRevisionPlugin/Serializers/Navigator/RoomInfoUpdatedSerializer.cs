using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class RoomInfoUpdatedSerializer : AbstractSerializer<RoomInfoUpdatedMessage>
    {
        public RoomInfoUpdatedSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, RoomInfoUpdatedMessage message)
        {
            packet.WriteInteger(message.RoomId);
        }
    }
}