using AutoFixture;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class NewNavigatorSearchParserTests : AbstractParserTestBase<NewNavigatorSearchParser, NewNavigatorSearchMessage>
    {
        public NewNavigatorSearchParserTests() : base()
        {
        }

        [Fact]
        private void Parse_WithClientPacket_NewNavigatorSearchMessage()
        {
            // Arrange
            var view = _fixture.Create<string>();
            var query = _fixture.Create<string>();

            WriteString(view);
            WriteString(query);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (NewNavigatorSearchMessage)_sut.Parse(packet);

            // Assert
            Assert.Equal(view, result.View);
            Assert.Equal(query, result.Query);
        }
    }
}
