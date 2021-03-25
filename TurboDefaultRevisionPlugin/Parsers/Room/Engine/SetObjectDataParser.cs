using System.Collections.Generic;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Engine
{
    public class SetObjectDataParser : AbstractParser<SetObjectDataMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) 
        {
            int furniId = packet.PopInt();
            int count = packet.PopInt() / 2;
            Dictionary<string, string> data = new();

            for (int i = 0; i < count; i++)
            {
                data.Add(packet.PopString(), packet.PopString());
            }

            return new SetObjectDataMessage
            {
                FurniId = furniId,
                Data = data
            };
        }
    }
}
