using Sitecore.Diagnostics;
using Sitecore.FXM.Abstractions;
using Sitecore.FXM.Matchers;
using Sitecore.FXM.Sites;

namespace Sagepath.Sitecore.FXM
{
    public class CustomFxmSiteProvider : FxmSiteProvider
    {
        public CustomFxmSiteProvider() : this(false)
        {
        }

        public CustomFxmSiteProvider(bool initializeDatabase) : 
            this(new DomainMatcherRepository(), new CustomDomainMatcherSiteFactory(), new ConfigurationFactoryWrapper(), initializeDatabase)
        {
        }

        public CustomFxmSiteProvider(IDomainMatcherRepository domainMatcherRepo, IDomainMatcherSiteFactory domainMatcherSiteFactory, IConfigurationFactory confFactory, bool initializeDatabase) : base(domainMatcherRepo, domainMatcherSiteFactory, confFactory, initializeDatabase)
        {
            Log.Info("[CustomFxmSiteProvider] Initialized", this);
        }
    }
}