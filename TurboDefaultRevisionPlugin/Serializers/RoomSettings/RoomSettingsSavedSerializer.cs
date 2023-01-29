using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class RoomSettingsSavedSerializer : AbstractSerializer<RoomSettingsSavedMessage>
    {
        public RoomSettingsSavedSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RoomSettingsSavedMessage message)
        {
            packet.WriteInteger(message.RoomId);
        }
    }
}