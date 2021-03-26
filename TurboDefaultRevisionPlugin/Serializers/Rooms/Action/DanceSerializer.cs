using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Action
{
    public class DanceSerializer : AbstractSerializer<DanceMessage>
    {
        public DanceSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, DanceMessage message)
        {
            packet.WriteInteger(message.UserId);
            packet.WriteInteger(message.DanceStyle);
        }
    }
}
