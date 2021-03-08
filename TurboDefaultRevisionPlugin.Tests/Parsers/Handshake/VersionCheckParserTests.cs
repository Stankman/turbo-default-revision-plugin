using AutoFixture;
using DotNetty.Buffers;
using System.Text;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using Xunit;

namespace Turbo.Packets.Tests.Parsers.Handshake
{
    public class VersionCheckParserTests
    {
        private readonly IFixture _fixture;
        private readonly IParser _sut;

        public VersionCheckParserTests()
        {
            _fixture = new Fixture();
            _sut = new VersionCheckParser();
        }

        [Fact]
        private void Parse_WithClientPacket_VersionCheckMessage()
        {
            // Arrange
            var packetHeader = _fixture.Create<int>();
            var clientId = _fixture.Create<int>();
            var clientUrl = _fixture.Create<string>();
            var externalVariablesUrl = _fixture.Create<string>();

            IByteBuffer buffer = Unpooled.Buffer();
            var encoding = Encoding.UTF8;

            buffer.WriteInt(clientId);
            buffer.WriteShort(encoding.GetByteCount(clientUrl));
            buffer.WriteString(clientUrl, encoding);
            buffer.WriteShort(encoding.GetByteCount(externalVariablesUrl));
            buffer.WriteString(externalVariablesUrl, encoding);

            var packet = new ClientPacket(packetHeader, buffer);

            // Act
            var result = (VersionCheckMessage)_sut.Parse(packet);

            // Assert
            Assert.Equal(clientId, result.ClientID);
            Assert.Equal(clientUrl, result.ClientURL);
            Assert.Equal(externalVariablesUrl, result.ExternalVariablesURL);
        }
    }
}
