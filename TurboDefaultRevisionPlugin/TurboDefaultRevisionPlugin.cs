using Microsoft.Extensions.Logging;
using System;
using Turbo.Packets.Revisions;
using Turbo.Plugins;

namespace TurboDefaultRevisionPlugin
{
    public class TurboDefaultRevisionPlugin : ITurboPlugin
    {
        private readonly IRevisionManager _revisionManager;
        private readonly ILogger<TurboDefaultRevisionPlugin> _logger;

        public string PluginName => "Default Revision Plugin";

        public string PluginAuthor => "ur mom";

        public TurboDefaultRevisionPlugin(IRevisionManager revisionManager, ILogger<TurboDefaultRevisionPlugin> logger)
        {
            _revisionManager = revisionManager;
            _logger = logger;

            IRevision myRevision = new Revision();
            string nitroRev = "NITRO-0-4-0";
            _revisionManager.Revisions.Add(myRevision.Revision, myRevision);

            _revisionManager.Revisions.Add(nitroRev, myRevision);

            _revisionManager.DefaultRevision = myRevision;

            _logger.LogInformation($"{GetType().Name} - Registered revisions: {myRevision.Revision} and {nitroRev}");
        }
    }
}
