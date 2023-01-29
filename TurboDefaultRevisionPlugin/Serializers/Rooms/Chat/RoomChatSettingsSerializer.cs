using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Chat
{
    public class RoomChatSettingsSerializer : AbstractSerializer<RoomChatSettingsMessage>
    {
        public RoomChatSettingsSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RoomChatSettingsMessage message)
        {
            packet.WriteInteger((int)message.ChatMode);
            packet.WriteInteger((int)message.ChatWeight);
            packet.WriteInteger((int)message.ChatSpeed);
            packet.WriteInteger(message.ChatDistance);
            packet.WriteInteger((int)message.ChatProtection);
        }
    }
}