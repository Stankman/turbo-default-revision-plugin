using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Chat
{
    public class RoomFilterSettingsSerializer : AbstractSerializer<RoomFilterSettingsMessage>
    {
        public RoomFilterSettingsSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RoomFilterSettingsMessage message)
        {
            packet.WriteInteger(message.BadWords.Count);

            foreach (var badWord in message.BadWords) packet.WriteString(badWord);
        }
    }
}