using AutoFixture;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class ForwardToSomeRoomParserTests : AbstractParserTestBase<ForwardToSomeRoomParser, ForwardToSomeRoomMessage>
    {
        public ForwardToSomeRoomParserTests()
        {

        }

        [Fact]
        private void Parse_WithClientPacket_ForwardToSomeRoomMessage()
        {
            // Arrange
            var forwardData = _fixture.Create<string>();

            WriteString(forwardData);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (ForwardToSomeRoomMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(forwardData, result.ForwardData);
        }
    }
}
