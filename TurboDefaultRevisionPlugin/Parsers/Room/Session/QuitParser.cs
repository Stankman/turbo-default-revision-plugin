using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Session;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Room.Session
{
    public class QuitParser : AbstractParser<QuitMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new QuitMessage();
    }
}
