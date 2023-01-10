using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Core.Packets.Messages;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types
{
    public static class ItemDataSerializer
    {
        public static void Serialize(IServerPacket packet, IRoomObject roomObject)
        {
            if (roomObject.Logic is not IFurnitureLogic furnitureLogic) return;

            packet.WriteInteger(roomObject.Id);
            packet.WriteInteger(furnitureLogic.FurnitureDefinition.SpriteId);
            packet.WriteString(""); // todo: walllocation
            packet.WriteString(furnitureLogic.StuffData.GetLegacyString());
            packet.WriteInteger(-1);//secondsToExpiration
            packet.WriteInteger((int)furnitureLogic.UsagePolicy);

            if(roomObject.RoomObjectHolder is IRoomObjectFurnitureHolder holder)
            {
                packet.WriteInteger(holder.PlayerId);
            }
            else
            {
                packet.WriteInteger(-1);
            }
        }
    }
}
