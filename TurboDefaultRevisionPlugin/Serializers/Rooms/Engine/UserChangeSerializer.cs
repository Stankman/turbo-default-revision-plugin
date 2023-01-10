using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class UserChangeSerializer : AbstractSerializer<UserChangeMessage>
    {
        public UserChangeSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, UserChangeMessage message)
        {
            packet.WriteInteger(message.Id);
            packet.WriteString(message.Figure);
            packet.WriteString(message.Sex);
            packet.WriteString(message.CustomInfo);
            packet.WriteInteger(message.ActivityPoints);
        }
    }
}
