using System;
using Turbo.Core.Game.Rooms.Object;
using Turbo.Core.Game.Rooms.Object.Logic;
using Turbo.Core.Game.Furniture.Data;
using Turbo.Core.Packets.Messages;
using Turbo.Furniture.Data.Types;

namespace TurboDefaultRevisionPlugin.Serializers.Inventory.Furni.Types
{
    public static class StuffDataSerializer
    {
        public static void SerializeStuffData(IServerPacket packet, IRoomObjectFloor floorObject)
        {
            SerializeStuffData(packet, floorObject.Logic.StuffData);
        }

        public static void SerializeStuffData(IServerPacket packet, IStuffData stuffData)
        {
            packet.WriteInteger(stuffData.Flags);

            if (stuffData is CrackableStuffData crackableData)
            {
                packet.WriteString(crackableData.State);
                packet.WriteInteger(crackableData.Hits);
                packet.WriteInteger(crackableData.Target);
            }

            else if (stuffData is EmptyStuffData emptyData)
            {

            }

            else if (stuffData is HighscoreStuffData highscoreData)
            {

            }

            else if (stuffData is LegacyStuffData legacyData)
            {
                packet.WriteString(legacyData.Data);
            }

            else if (stuffData is MapStuffData mapData)
            {
                var data = mapData.Data;

                packet.WriteInteger(data.Count);

                foreach (string key in data.Keys)
                {
                    packet.WriteString(key);
                    packet.WriteString(data[key]);
                }
            }

            else if (stuffData is NumberStuffData numberData)
            {
                var data = numberData.Data;

                packet.WriteInteger(data.Count);

                foreach (int value in data)
                {
                    packet.WriteInteger(value);
                }
            }

            else if (stuffData is StringStuffData stringData)
            {
                var data = stringData.Data;

                packet.WriteInteger(data.Count);

                foreach (string value in data)
                {
                    packet.WriteString(value);
                }
            }

            else if (stuffData is VoteStuffData voteData)
            {

            }

            if (stuffData.IsUnique())
            {
                packet.WriteInteger(stuffData.UniqueNumber);
                packet.WriteInteger(stuffData.UniqueSeries);
            }
        }
    }
}
