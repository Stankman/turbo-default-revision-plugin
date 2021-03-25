using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Core.Packets.Messages;
using TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types
{
    public static class ObjectDataSerializer
    {
        public static void Serialize(IServerPacket packet, IRoomObject roomObject)
        {
            if (roomObject.Logic is IFurnitureLogic furnitureLogic)
            {
                int type = furnitureLogic.FurnitureDefinition.SpriteId;
                packet.WriteInteger(roomObject.Id);
                packet.WriteInteger(type);
                packet.WriteInteger(roomObject.Location.X);
                packet.WriteInteger(roomObject.Location.Y);
                packet.WriteInteger((int)roomObject.Location.Rotation);
                packet.WriteDouble(roomObject.Location.Z);
                packet.WriteDouble(furnitureLogic.FurnitureDefinition.Z);// todo: fix this
                packet.WriteInteger(1); // todo: extra
                StuffDataSerializer.Serialize(packet, roomObject);
                packet.WriteInteger(-1);//secondsToExpiration
                packet.WriteInteger(1); // todo: fix usage policy
                packet.WriteInteger(1); // todo: owner id
                if (type < 0) packet.WriteString(""); // furnidata object name if it has no sprite id
            }
        }
    }
}
