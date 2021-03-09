using AutoFixture;
using DotNetty.Buffers;
using System.Text;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Parsers;

namespace TurboDefaultRevisionPlugin.Tests.Parsers
{
    public abstract class AbstractParserTestBase<P, M> 
        where P : AbstractParser<M>, new()
        where M : IMessageEvent
    {
        protected readonly IByteBuffer _buffer;
        protected readonly IFixture _fixture;
        protected readonly IParser _sut;

        private readonly Encoding _encoding;

        public AbstractParserTestBase()
        {
            _fixture = new Fixture();
            _buffer = Unpooled.Buffer();
            _sut = new P();

            _encoding = Encoding.UTF8;
        }

        protected void WriteString(string x)
        {
            _buffer.WriteShort(_encoding.GetByteCount(x));
            _buffer.WriteString(x, _encoding);
        }

        protected void WriteInt(int x) => _buffer.WriteInt(x);
        protected void WriteShort(short x) => _buffer.WriteShort(x);
    }
}
