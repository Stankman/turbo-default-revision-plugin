using System;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Session
{
    public class RoomForwardSerializer : AbstractSerializer<RoomForwardMessage>
    {
        public RoomForwardSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RoomForwardMessage message)
        {
            packet.WriteInteger(message.RoomId);
        }
    }
}
