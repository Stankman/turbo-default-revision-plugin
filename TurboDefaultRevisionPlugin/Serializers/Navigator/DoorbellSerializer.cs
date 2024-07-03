using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class DoorbellSerializer : AbstractSerializer<DoorbellMessage>
    {
        public DoorbellSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, DoorbellMessage message)
        {
            packet.WriteString(message.Username ?? "");
        }
    }
}
