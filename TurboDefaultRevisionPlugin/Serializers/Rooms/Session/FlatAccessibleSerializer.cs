using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Session
{
    public class FlatAccessibleSerializer : AbstractSerializer<FlatAccessibleMessage>
    {
        public FlatAccessibleSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, FlatAccessibleMessage message)
        {
            packet.WriteString(message.Username ?? "");
        }
    }
}
