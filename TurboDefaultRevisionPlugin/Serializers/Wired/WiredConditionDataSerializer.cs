using Turbo.Packets.Serializers;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Wired;

namespace TurboDefaultRevisionPlugin.Serializers.Wired
{
    public class WiredConditionDataSerializer : AbstractSerializer<WiredConditionDataMessage>
    {
        public WiredConditionDataSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, WiredConditionDataMessage message)
        {
            WiredDataSerializer.Serialize(packet, message);
        }
    }
}