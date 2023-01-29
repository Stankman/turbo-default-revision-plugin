using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Chat
{
    public class UserTypingSerializer : AbstractSerializer<UserTypingMessage>
    {
        public UserTypingSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, UserTypingMessage message)
        {
            packet.WriteInteger(message.ObjectId);
            packet.WriteInteger(message.IsTyping ? 1 : 0);
        }
    }
}