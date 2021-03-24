using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Data;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Core.Packets.Messages;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types
{
    public static class StuffDataSerializer
    {
        public static void Serialize(IServerPacket packet, IRoomObject roomObject)
        {
            if (roomObject.Logic is IFurnitureLogic furnitureLogic)
            {
                packet.WriteInteger((int)furnitureLogic.DataKey);

                switch(furnitureLogic.DataKey) // todo: finish this
                {
                    case StuffDataKey.LegacyKey:
                        break;
                }
            }
        }
    }
}
