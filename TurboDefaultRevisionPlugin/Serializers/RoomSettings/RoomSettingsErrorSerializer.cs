using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class RoomSettingsErrorSerializer : AbstractSerializer<RoomSettingsErrorMessage>
    {
        public RoomSettingsErrorSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RoomSettingsErrorMessage message)
        {
            packet.WriteInteger(message.RoomId);
            packet.WriteInteger((int)message.ErrorCode);
        }
    }
}