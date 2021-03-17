using System;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Session
{
    public class CantConnectSerializer : AbstractSerializer<CantConnectMessage>
    {
        public CantConnectSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, CantConnectMessage message)
        {
            packet.WriteInteger((int)message.Reason);
            packet.WriteString(message.Parameter);
        }
    }
}
