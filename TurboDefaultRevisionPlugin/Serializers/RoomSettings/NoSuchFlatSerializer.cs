using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class NoSuchFlatSerializer : AbstractSerializer<NoSuchFlatMessage>
    {
        public NoSuchFlatSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, NoSuchFlatMessage message)
        {
            packet.WriteInteger(message.RoomId);
        }
    }
}