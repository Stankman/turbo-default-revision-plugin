using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.RoomSettings
{
    public class ShowEnforceRoomCategoryDialogSerializer : AbstractSerializer<ShowEnforceRoomCategoryDialogMessage>
    {
        public ShowEnforceRoomCategoryDialogSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, ShowEnforceRoomCategoryDialogMessage message)
        {
            packet.WriteInteger(message.SelectionType);
        }
    }
}