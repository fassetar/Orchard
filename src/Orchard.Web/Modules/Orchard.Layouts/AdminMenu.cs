using Orchard.Localization;
using Orchard.UI.Navigation;

namespace Orchard.Layouts {
    public class AdminMenu : INavigationProvider {

        public Localizer T { get; set; }
        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder) {
            builder.Add(T("Layouts"), "8", layouts => layouts
                    .LinkToFirstChild(false)
                    .Add(T("Elements"), "1", elements => elements.Action("Index", "BlueprintAdmin", new { area = "Orchard.Layouts" }).Permission(Permissions.ManageLayouts))
                    .Add(T("List"), "0", elements => elements.Action("List", "Admin", new { id = "Layout", area = "Contents" }).Permission(Permissions.ManageLayouts)));
        }
    }
}