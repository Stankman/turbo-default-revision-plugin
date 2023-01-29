using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class RoomSettingsSaveErrorSerializer : AbstractSerializer<RoomSettingsSaveErrorMessage>
    {
        public RoomSettingsSaveErrorSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RoomSettingsSaveErrorMessage message)
        {
            packet.WriteInteger(message.RoomId);
            packet.WriteInteger((int)message.ErrorCode);
            packet.WriteString(message.Info);
        }
    }
}