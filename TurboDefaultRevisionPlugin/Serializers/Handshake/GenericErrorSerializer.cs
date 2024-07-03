using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Handshake
{
    public class GenericErrorSerializer : AbstractSerializer<GenericErrorMessage>
    {
        public GenericErrorSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, GenericErrorMessage message)
        {
            packet.WriteInteger((int)message.ErrorCode);
        }
    }
}
