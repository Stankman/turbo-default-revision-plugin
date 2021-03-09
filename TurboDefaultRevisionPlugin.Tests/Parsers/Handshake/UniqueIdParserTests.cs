using AutoFixture;
using DotNetty.Buffers;
using System.Text;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Handshake;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using TurboDefaultRevisionPlugin.Tests.Parsers;
using Xunit;

namespace Turbo.Packets.Tests.Parsers.Handshake
{
    public class UniqueIdParserTests : AbstractParserTestBase<UniqueIdParser, UniqueIdMessage>
    {
        public UniqueIdParserTests() : base()
        {

        }

        [Fact]
        private void Parse_WithClientPacket_ReturnsUniqueIdMessage()
        {
            // Arrange
            var machineId = _fixture.Create<string>();
            var fingerprint = _fixture.Create<string>();
            var flashVersion = _fixture.Create<string>();

            WriteString(machineId);
            WriteString(fingerprint);
            WriteString(flashVersion);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (UniqueIdMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(machineId, result.MachineID);
            Assert.Equal(fingerprint, result.Fingerprint);
            Assert.Equal(flashVersion, result.FlashVersion);
        }
    }
}
