using AutoFixture;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class NavigatorAddSavedSearchParserTests : AbstractParserTestBase<NavigatorAddSavedSearchParser, NavigatorAddSavedSearchMessage>
    {
        public NavigatorAddSavedSearchParserTests() : base()
        {
        }

        [Fact]
        private void Parse_WithClientPacket_NavigatorAddSavedSearchMessage()
        {
            // Arrange
            var searchCode = _fixture.Create<string>();
            var filter = _fixture.Create<string>();

            WriteString(searchCode);
            WriteString(filter);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (NavigatorAddSavedSearchMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(searchCode, result.SearchCode);
            Assert.Equal(filter, result.Filter);
        }
    }
}
