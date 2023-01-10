using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Core.Packets.Messages;
using TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types;
using System;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types
{
    public static class ObjectDataSerializer
    {
        public static void Serialize(IServerPacket packet, IRoomObject roomObject)
        {
            if (roomObject.Logic is not IFurnitureLogic furnitureLogic) return;

            int type = furnitureLogic.FurnitureDefinition.SpriteId;

            packet.WriteInteger(roomObject.Id);
            packet.WriteInteger(type);
            packet.WriteInteger(roomObject.Location.X);
            packet.WriteInteger(roomObject.Location.Y);
            packet.WriteInteger((int)roomObject.Location.Rotation);
            packet.WriteString(string.Format("{0:N3}", roomObject.Location.Z));
            packet.WriteString(string.Format("{0:N3}", furnitureLogic.FurnitureDefinition.Z));
            packet.WriteInteger(1); // todo: extra
            StuffDataSerializer.SerializeStuffData(packet, roomObject);
            packet.WriteInteger(-1);//secondsToExpiration
            packet.WriteInteger((int)furnitureLogic.UsagePolicy);

            if (roomObject.RoomObjectHolder is IRoomObjectFurnitureHolder holder)
            {
                packet.WriteInteger(holder.PlayerId);
            }
            else
            {
                packet.WriteInteger(-1);
            }

            if (type < 0) packet.WriteString(""); // furnidata object name if it has no sprite id
        }
    }
}
