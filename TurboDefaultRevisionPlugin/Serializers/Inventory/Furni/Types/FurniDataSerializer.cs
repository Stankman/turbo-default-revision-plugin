using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Core.Packets.Messages;
using Turbo.Core.Game.Inventory;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types
{
    public static class FurniDataSerializer
    {
        public static void Serialize(IServerPacket packet, IPlayerFurniture furniture)
        {
            string type = furniture.FurnitureDefinition.Type.ToUpper();
            packet.WriteInteger(furniture.Id);
            packet.WriteString(type);
            packet.WriteInteger(furniture.Id);// ref ??
            packet.WriteInteger(furniture.FurnitureDefinition.SpriteId);
            packet.WriteInteger(1); //todo: object category <see cref="Core.Game.Furniture.Types.FurniCategory"
            StuffDataSerializer.SerializeStuffData(packet, furniture.StuffData);
            packet.WriteBoolean(furniture.FurnitureDefinition.CanRecycle);
            packet.WriteBoolean(furniture.FurnitureDefinition.CanTrade);
            packet.WriteBoolean(furniture.FurnitureDefinition.CanGroup);
            packet.WriteBoolean(furniture.FurnitureDefinition.CanSell);
            packet.WriteInteger(-1);//secondsToExpiration
            packet.WriteBoolean(false);// hasRentPeriodStarted
            packet.WriteInteger(-1); // room id

            if(type.Equals("S"))
            {
                packet.WriteString(""); //slotId
                packet.WriteInteger(0); // extra
            }
        }
    }
}
