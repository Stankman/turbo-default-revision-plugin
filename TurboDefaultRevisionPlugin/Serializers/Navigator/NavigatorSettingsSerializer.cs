using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Navigator
{
    public class NavigatorSettingsSerializer : AbstractSerializer<NavigatorSettingsMessage>
    {
        public NavigatorSettingsSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, NavigatorSettingsMessage message)
        {
            packet.WriteInteger(message.HomeRoomId);
            packet.WriteInteger(message.RoomIdToEnter);
        }
    }
}
