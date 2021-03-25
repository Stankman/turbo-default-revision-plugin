using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Action
{
    public class SleepSerializer : AbstractSerializer<SleepMessage>
    {
        public SleepSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, SleepMessage message)
        {
            packet.WriteInteger(message.UserId);
            packet.WriteBoolean(message.Sleeping);
        }
    }
}
