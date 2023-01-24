using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Catalog
{
    public class PurchaseNotAllowedSerializer : AbstractSerializer<PurchaseNotAllowedMessage>
    {
        public PurchaseNotAllowedSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, PurchaseNotAllowedMessage message)
        {
            packet.WriteInteger((int)message.ErrorCode);
        }
    }
}