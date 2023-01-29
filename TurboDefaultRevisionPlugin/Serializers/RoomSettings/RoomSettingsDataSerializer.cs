using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.RoomSettings.Types;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class RoomSettingsDataSerializer : AbstractSerializer<RoomSettingsDataMessage>
    {
        public RoomSettingsDataSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RoomSettingsDataMessage message)
        {
            packet.WriteInteger(message.RoomDetails.Id);
            packet.WriteString(message.RoomDetails.Name);
            packet.WriteString(message.RoomDetails.Description);
            packet.WriteInteger((int)message.RoomDetails.State);
            packet.WriteInteger(0); // categoryId
            packet.WriteInteger(message.RoomDetails.UsersMax); // current
            packet.WriteInteger(50); // max users possible
            packet.WriteInteger(0); // total tags, string[]
            packet.WriteInteger((int)message.RoomDetails.TradeType);
            packet.WriteInteger(message.RoomDetails.AllowPets ? 1 : 0);
            packet.WriteInteger(message.RoomDetails.AllowPetsEat ? 1 : 0);
            packet.WriteInteger(message.RoomDetails.BlockingDisabled ? 1 : 0);
            packet.WriteInteger(message.RoomDetails.HideWalls ? 1 : 0);
            packet.WriteInteger((int)message.RoomDetails.ThicknessWall);
            packet.WriteInteger((int)message.RoomDetails.ThicknessFloor);

            RoomChatSettingsSerializer.Serialize(packet, message.RoomDetails);

            packet.WriteBoolean(false); //_allowNavigatorDynamicCats

            RoomModerationSettingsSerializer.Serialize(packet, message.RoomDetails);
        }
    }
}