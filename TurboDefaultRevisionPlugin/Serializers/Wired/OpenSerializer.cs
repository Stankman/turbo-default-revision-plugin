using Turbo.Packets.Serializers;
using Turbo.Core.Packets.Messages;
using TurboWiredPlugin.Packets.Outgoing.Wired;

namespace TurboDefaultRevisionPlugin.Serializers.Wired
{
    public class OpenSerializer : AbstractSerializer<OpenMessage>
    {
        public OpenSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, OpenMessage message)
        {
            packet.WriteInteger(message.ItemId);
        }
    }
}