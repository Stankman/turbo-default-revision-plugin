using System;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    class RoomEntryInfoSerializer : AbstractSerializer<RoomEntryInfoMessage>
    {
        public RoomEntryInfoSerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, RoomEntryInfoMessage message)
        {
            packet.WriteInteger(message.RoomId);
            packet.WriteBoolean(message.Owner);
        }
    }
}
