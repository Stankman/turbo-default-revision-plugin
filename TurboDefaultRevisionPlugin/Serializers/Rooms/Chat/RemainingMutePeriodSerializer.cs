using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Chat
{
    public class RemainingMutePeriodSerializer : AbstractSerializer<RemaningMutePeriodMessage>
    {
        public RemainingMutePeriodSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RemaningMutePeriodMessage message)
        {
            packet.WriteInteger(message.MuteSecondsRemaining);
        }
    }
}