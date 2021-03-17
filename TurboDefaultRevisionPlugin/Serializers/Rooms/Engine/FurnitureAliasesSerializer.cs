using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class FurnitureAliasesSerializer : AbstractSerializer<FurnitureAliasesMessage>
    {
        public FurnitureAliasesSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, FurnitureAliasesMessage message)
        {
            packet.WriteInteger(message.Aliases.Count);
            foreach(var entry in message.Aliases)
            {
                packet.WriteString(entry.Key);
                packet.WriteString(entry.Value);
            }
        }
    }
}
