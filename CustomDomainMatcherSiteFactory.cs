using Sitecore.Collections;
using Sitecore.Diagnostics;
using Sitecore.FXM.Matchers;
using Sitecore.FXM.Sites;
using Sitecore.Sites;

namespace Sagepath.Sitecore.FXM
{
    public class CustomDomainMatcherSiteFactory : IDomainMatcherSiteFactory
    {
        public Site Create(IDomainMatcher domainMatcher, string database)
        {
            Log.Info($"[CustomDomainMatcherSiteFactory] Creating FXM Site {domainMatcher.Name}", this);

            var properties = new StringDictionary
            {
                {"name", domainMatcher.Name},
                {"virtualFolder", "/"},
                {"physicalFolder", "/"},
                {"rootPath", "/sitecore/content"},
                {"startItem", "/home"},
                {"database", database},
                {"domain", "extranet"},
                {"cacheHtml", "true"},
                {"htmlCacheSize", "0MB"},
                {"registryCacheSize", "0MB"},
                {"viewStateCacheSize", "0MB"},
                {"xslCacheSize", "0MB"},
                {"filteredItemsCacheSize", "0MB"},
                {"renderingParametersCacheSize", "0MB"}
            };

            return new Site(domainMatcher.Name, properties);
        }
    }
}