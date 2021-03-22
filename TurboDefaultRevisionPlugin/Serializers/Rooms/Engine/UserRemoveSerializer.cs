using System;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class UserRemoveSerializer : AbstractSerializer<UserRemoveMessage>
    {
        public UserRemoveSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, UserRemoveMessage message)
        {
            packet.WriteString(message.Id.ToString());
        }
    }
}
