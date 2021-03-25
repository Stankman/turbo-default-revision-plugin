using System;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class ObjectsSerializer : AbstractSerializer<ObjectsMessage>
    {
        public ObjectsSerializer(int header) : base(header) { }
        protected override void Serialize(IServerPacket packet, ObjectsMessage message)
        {
            packet.WriteInteger(message.OwnersIdToUsername.Count);
            foreach(var entry in message.OwnersIdToUsername)
            {
                packet.WriteInteger(entry.Key);
                packet.WriteString(entry.Value);
            }

            packet.WriteInteger(message.Objects.Count);
            foreach(var obj in message.Objects)
            {
                ObjectDataSerializer.Serialize(packet, obj);
            }
        }
    }
}
