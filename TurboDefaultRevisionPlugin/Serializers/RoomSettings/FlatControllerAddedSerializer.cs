using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class FlatControllerAddedSerializer : AbstractSerializer<FlatControllerAddedMessage>
    {
        public FlatControllerAddedSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, FlatControllerAddedMessage message)
        {
            packet.WriteInteger(message.RoomId);
            packet.WriteInteger(message.PlayerId);
            packet.WriteString(message.PlayerName);
        }
    }
}