using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class BannedUsersFromRoomSerializer : AbstractSerializer<BannedUsersFromRoomMessage>
    {
        public BannedUsersFromRoomSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, BannedUsersFromRoomMessage message)
        {
            packet.WriteInteger(message.RoomId);
            packet.WriteInteger(message.Players.Count);

            foreach (var playerId in message.Players.Keys)
            {
                packet.WriteInteger(playerId);
                packet.WriteString(message.Players[playerId]);
            }
        }
    }
}