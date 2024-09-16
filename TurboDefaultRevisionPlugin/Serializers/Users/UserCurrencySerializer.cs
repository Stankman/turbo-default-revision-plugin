using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Users;
using Turbo.Packets.Serializers;

namespace TurboDefaultRevisionPlugin.Serializers.Users
{
    public class UserCurrencySerializer : AbstractSerializer<UserCurrencyMessage>
    {
        public UserCurrencySerializer(int header) : base(header) { }

        protected override void Serialize(IServerPacket packet, UserCurrencyMessage message)
        {
            packet.WriteInteger(message.playerWallet.Wallet.Count);

            foreach (var currency in message.playerWallet.Wallet)
            {
                packet.WriteInteger(currency.Key);
                packet.WriteInteger(currency.Value);
            }
        }
    }
}
