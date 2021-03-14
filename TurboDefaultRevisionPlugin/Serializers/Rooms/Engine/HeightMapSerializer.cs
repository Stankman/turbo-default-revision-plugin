using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Game.Rooms.Mapping;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine
{
    public class HeightMapSerializer : AbstractSerializer<HeightMapMessage>
    {
        public HeightMapSerializer(int header) :base(header)
        {

        }

        protected override void Serialize(IServerPacket packet, HeightMapMessage message)
        {
            packet.WriteInteger(message.RoomModel.TotalX);
            packet.WriteInteger(message.RoomModel.TotalSize);
            foreach(IRoomTile tile in message.RoomMap.Tiles)
            {
                packet.WriteShort(tile.RelativeHeight);
            }
        }
    }
}
