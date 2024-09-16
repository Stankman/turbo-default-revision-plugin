using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Users;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Users
{
    public class UserCreditsSerializer : AbstractSerializer<UserCreditsMessage>
    {
        public UserCreditsSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, UserCreditsMessage message)
        {
            packet.WriteString(message.credits + ".0");
        }
    }
}
