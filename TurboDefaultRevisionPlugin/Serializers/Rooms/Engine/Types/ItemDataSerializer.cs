using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Core.Packets.Messages;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types
{
    public static class ItemDataSerializer
    {
        public static void Serialize(IServerPacket packet, IRoomObject roomObject)
        {
            if (roomObject.Logic is IFurnitureLogic furnitureLogic)
            {
                int type = furnitureLogic.FurnitureDefinition.SpriteId;
                packet.WriteInteger(roomObject.Id);
                packet.WriteInteger(type);
                packet.WriteString(""); // todo: walllocation
                packet.WriteString("0"); // todo: dataStr
                packet.WriteInteger(-1);//secondsToExpiration
                packet.WriteInteger(1); // todo: fix usage policy
                packet.WriteInteger(1); // todo: owner id
            }
        }
    }
}
