using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Users;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Parsers.Users
{
    public class GetUserWalletParser : AbstractParser<GetUserWalletMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet) => new GetUserWalletMessage { };
    }
}
