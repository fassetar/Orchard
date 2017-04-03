using Orchard.UI.Resources;

namespace Orchard.Autoroute {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();
            manifest.DefineScript("AutorouteBrowser").SetUrl("autoroute-browser.js").SetDependencies("jQuery");
        }
    }
}
