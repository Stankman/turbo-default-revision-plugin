using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming;
using Turbo.Packets.Parsers;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers
{
    public abstract class EmptyPacketParserTestBase<P, M> : AbstractParserTestBase<P, M>
        where P : AbstractParser<M>, new()
        where M : IMessageEvent
    {
        public EmptyPacketParserTestBase() : base()
        {

        }

        [Fact]
        protected void Parse_ParsesBufferToMessage()
        {
            // Arrange
            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = _sut.Parse(packet);

            // Assert
            Assert.IsType<M>(result);
        }
    }
}
