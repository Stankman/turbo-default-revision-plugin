using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Handshake
{
    public class UserRightsSerializer : AbstractSerializer<UserRightsMessage>
    {
        public UserRightsSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, UserRightsMessage message)
        {
            packet.WriteInteger((int)message.ClubLevel);
            packet.WriteInteger((int)message.SecurityLevel);
            packet.WriteBoolean(message.IsAmbassador);
        }
    }
}