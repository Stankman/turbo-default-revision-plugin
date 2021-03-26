using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Data;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Core.Packets.Messages;
using Turbo.Rooms.Object.Data.Types;

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
                        packet.WriteString(((LegacyStuffData)furnitureLogic.StuffData).Data);
                        break;
                    case StuffDataKey.MapKey:
                        {
                            var data = ((MapStuffData)furnitureLogic.StuffData).Data;
                            packet.WriteInteger(data.Count);

                            foreach (string key in data.Keys)
                            {
                                packet.WriteString(key);
                                packet.WriteString(data[key]);
                            }
                        }
                        break;
                    case StuffDataKey.StringKey:
                        {
                            var data = ((StringStuffData)furnitureLogic.StuffData).Data;
                            packet.WriteInteger(data.Count);

                            foreach (string value in data)
                            {
                                packet.WriteString(value);
                            }
                        }
                        break;
                    case StuffDataKey.VoteKey:
                        {

                        }
                        break;
                    case StuffDataKey.EmptyKey:
                        break;
                    case StuffDataKey.NumberKey:
                        {
                            var data = ((NumberStuffData)furnitureLogic.StuffData).Data;
                            packet.WriteInteger(data.Count);

                            foreach (int value in data)
                            {
                                packet.WriteInteger(value);
                            }
                        }
                        break;
                    case StuffDataKey.HighscoreKey:
                        {
                            //todo: this
                        }
                        break;
                    case StuffDataKey.CrackableKey:
                        {
                            var stuffdata = (CrackableStuffData)furnitureLogic.StuffData;
                            packet.WriteString(stuffdata.State);
                            packet.WriteInteger(stuffdata.Hits);
                            packet.WriteInteger(stuffdata.Target);
                        }
                        break;
                }

                if (furnitureLogic.StuffData.IsUnique())
                {
                    packet.WriteInteger(furnitureLogic.StuffData.UniqueNumber);
                    packet.WriteInteger(furnitureLogic.StuffData.UniqueSeries);
                }
            }
        }
    }
}
