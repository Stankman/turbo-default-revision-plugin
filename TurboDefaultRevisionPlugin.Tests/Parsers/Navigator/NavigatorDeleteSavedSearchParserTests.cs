using AutoFixture;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class NavigatorDeleteSavedSearchParserTests : AbstractParserTestBase<NavigatorDeleteSavedSearchParser, NavigatorDeleteSavedSearchMessage>
    {
        public NavigatorDeleteSavedSearchParserTests() : base()
        {
        }

        [Fact]
        private void Parse_WithClientPacket_NavigatorDeleteSavedSearchMessage()
        {
            // Arrange
            var searchId = _fixture.Create<int>();

            WriteInt(searchId);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (NavigatorDeleteSavedSearchMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(searchId, result.SearchID);
        }
    }
}
