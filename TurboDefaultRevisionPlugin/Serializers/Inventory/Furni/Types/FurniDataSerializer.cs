using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Core.Packets.Messages;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types
{
    public static class FurniDataSerializer
    {
        public static void Serialize(IServerPacket packet, IRoomObject roomObject)
        {
            if (roomObject.Logic is IFurnitureLogic furnitureLogic)
            {
                string type = furnitureLogic.FurnitureDefinition.Type;
                packet.WriteInteger(roomObject.Id);
                packet.WriteString(type);
                packet.WriteInteger(roomObject.Id);// ref ??
                packet.WriteInteger(furnitureLogic.FurnitureDefinition.SpriteId);
                packet.WriteInteger(1); //todo: object category <see cref="Core.Game.Furniture.Types.FurniCategory"
                StuffDataSerializer.Serialize(packet, roomObject);
                packet.WriteBoolean(furnitureLogic.FurnitureDefinition.CanRecycle);
                packet.WriteBoolean(furnitureLogic.FurnitureDefinition.CanTrade);
                packet.WriteBoolean(furnitureLogic.FurnitureDefinition.CanGroup);
                packet.WriteBoolean(furnitureLogic.FurnitureDefinition.CanSell);
                packet.WriteInteger(-1);//secondsToExpiration
                packet.WriteBoolean(false);// hasRentPeriodStarted
                packet.WriteInteger(roomObject.Room.Id); // should just be set to -1 ?

                if(type.Equals("S"))
                {
                    packet.WriteString(""); //slotId
                    packet.WriteInteger(0); // extra
                }
            }
        }
    }
}
