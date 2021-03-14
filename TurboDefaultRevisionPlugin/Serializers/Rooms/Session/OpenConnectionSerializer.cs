using System;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Session
{
    public class OpenConnectionSerializer : AbstractSerializer<OpenConnectionMessage>
    {
        public OpenConnectionSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, OpenConnectionMessage message)
        {
           
        }
    }
}
