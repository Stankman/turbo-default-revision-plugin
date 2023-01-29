using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Chat
{
    public class FloodControlSerializer : AbstractSerializer<FloodControlMessage>
    {
        public FloodControlSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, FloodControlMessage message)
        {
            packet.WriteInteger(message.Seconds);
        }
    }
}