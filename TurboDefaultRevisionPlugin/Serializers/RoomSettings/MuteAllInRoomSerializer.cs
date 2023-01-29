using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class MuteAllInRoomSerializer : AbstractSerializer<MuteAllInRoomMessage>
    {
        public MuteAllInRoomSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, MuteAllInRoomMessage message)
        {
            packet.WriteBoolean(message.Muted);
        }
    }
}