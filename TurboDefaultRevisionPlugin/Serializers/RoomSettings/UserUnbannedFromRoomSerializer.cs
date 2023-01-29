using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class UserUnbannedFromRoomSerializer : AbstractSerializer<UserUnbannedFromRoomMessage>
    {
        public UserUnbannedFromRoomSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, UserUnbannedFromRoomMessage message)
        {
            packet.WriteInteger(message.RoomId);
            packet.WriteInteger(message.PlayerId);
        }
    }
}