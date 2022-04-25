using Microsoft.Extensions.Logging;
using Turbo.Core.Packets.Revisions;
using Turbo.Core.Plugins;
using Turbo.Packets.Revisions;

namespace TurboDefaultRevisionPlugin
{
    public class TurboDefaultRevisionPlugin : ITurboPlugin
    {
        private readonly IRevisionManager _revisionManager;
        private readonly ILogger<TurboDefaultRevisionPlugin> _logger;

        public string PluginName => "Default Turbo Revision Plugin";

        public string PluginAuthor => "Krews";

        public TurboDefaultRevisionPlugin(IRevisionManager revisionManager, ILogger<TurboDefaultRevisionPlugin> logger)
        {
            _revisionManager = revisionManager;
            _logger = logger;

            IRevision myRevision = new Revision();
            string nitroRev = "NITRO-2-0-0";
            _revisionManager.Revisions.Add(myRevision.Revision, myRevision);

            _revisionManager.Revisions.Add(nitroRev, myRevision);

            _revisionManager.DefaultRevision = myRevision;

            _logger.LogInformation($"{nameof(TurboDefaultRevisionPlugin)} - Registered revision: {myRevision.Revision}");
            _logger.LogInformation($"{nameof(TurboDefaultRevisionPlugin)} - Registered revision: {nitroRev}");
        }
    }
}
