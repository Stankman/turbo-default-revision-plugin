using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Packets.Messages;

namespace TurboDefaultRevisionPlugin.Serializers.Rooms.Engine.Types
{
    public static class ItemDataSerializer
    {
        public static void Serialize(IServerPacket packet, IRoomObjectWall wallObject)
        {
            packet.WriteString(wallObject.Id.ToString());
            packet.WriteInteger(wallObject.Logic.FurnitureDefinition.SpriteId);
            packet.WriteString(wallObject.WallLocation);
            packet.WriteString(wallObject.Logic.StuffData.GetLegacyString());
            packet.WriteInteger(-1);//secondsToExpiration
            packet.WriteInteger((int)wallObject.Logic.UsagePolicy);
            packet.WriteInteger(wallObject.RoomObjectHolder?.PlayerId ?? -1);
        }
    }
}
