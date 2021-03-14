using System;
using Turbo.Core.Game.Rooms.Mapping;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class HeightMapUpdateSerializer : AbstractSerializer<HeightMapUpdateMessage>
    {
        public HeightMapUpdateSerializer(int header) : base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, HeightMapUpdateMessage message)
        {
            packet.WriteByte(message.TilesToUpdate.Count);
            foreach(IRoomTile tile in message.TilesToUpdate) 
            {
                packet.WriteByte(tile.Location.X);
                packet.WriteByte(tile.Location.Y);
                packet.WriteShort(tile.RelativeHeight);
            }
        }
    }
}
