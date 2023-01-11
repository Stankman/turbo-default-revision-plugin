using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Core.Packets.Messages;
using TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types;
using System;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types
{
    public static class ObjectDataSerializer
    {
        public static void Serialize(IServerPacket packet, IRoomObjectFloor floorObject)
        {
            int type = floorObject.Logic.FurnitureDefinition.SpriteId;

            packet.WriteInteger(floorObject.Id);
            packet.WriteInteger(type);
            packet.WriteInteger(floorObject.Location.X);
            packet.WriteInteger(floorObject.Location.Y);
            packet.WriteInteger((int)floorObject.Location.Rotation);
            packet.WriteString(string.Format("{0:N3}", floorObject.Location.Z));
            packet.WriteString(string.Format("{0:N3}", floorObject.Logic.FurnitureDefinition.Z));
            packet.WriteInteger(1); // todo: extra
            StuffDataSerializer.SerializeStuffData(packet, floorObject);
            packet.WriteInteger(-1);//secondsToExpiration
            packet.WriteInteger((int)floorObject.Logic.UsagePolicy);
            packet.WriteInteger(floorObject.RoomObjectHolder?.PlayerId ?? -1);

            if (type < 0) packet.WriteString(""); // furnidata object name if it has no sprite id
        }
    }
}
