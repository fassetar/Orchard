using Orchard.Localization;
using Orchard.UI.Navigation;

namespace Orchard.MediaLibrary {
    public class AdminMenu : INavigationProvider {

        public Localizer T { get; set; }
        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder) {
            builder.Add(T("Media"), "6", media => media
                     .LinkToFirstChild(false)
                     .Add(T("Media"), "1", elements => elements.Action("Index", "Admin", new { area = "Orchard.MediaLibrary" }).Permission(Permissions.ManageOwnMedia)));
        }
    }
}