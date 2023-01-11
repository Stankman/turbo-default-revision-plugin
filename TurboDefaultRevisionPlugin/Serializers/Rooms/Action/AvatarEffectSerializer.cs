using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Action
{
    public class AvatarEffectSerializer : AbstractSerializer<AvatarEffectMessage>
    {
        public AvatarEffectSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, AvatarEffectMessage message)
        {
            packet.WriteInteger(message.ObjectId);
            packet.WriteInteger(message.EffectId);
            packet.WriteInteger(message.DelayMilliSeconds);
        }
    }
}
