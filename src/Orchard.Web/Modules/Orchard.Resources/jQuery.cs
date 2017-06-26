using Orchard.UI.Resources;

namespace Orchard.Resources {
    public class jQuery : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            // jQuery.
            manifest.DefineScript("jQuery").SetUrl("jquery.min.js", "jquery.js").SetVersion("2.1.4").SetCdn("//ajax.aspnetcdn.com/ajax/jQuery/jquery-2.1.4.min.js", "//ajax.aspnetcdn.com/ajax/jQuery/jquery-2.1.4.js", true);

            // Additional utilities and plugins.
            manifest.DefineScript("jQueryUtils").SetUrl("jquery.utils.min.js", "jquery.utils.js").SetDependencies("jQuery");
            manifest.DefineScript("jQueryPlugin").SetUrl("jquery.plugin.min.js", "jquery.plugin.js").SetDependencies("jQuery");

            // jQuery Calendars.
            manifest.DefineScript("jQueryCalendars").SetUrl("Calendars/jquery.calendars.all.min.js", "Calendars/jquery.calendars.all.js").SetDependencies("jQueryPlugin").SetVersion("2.0.1");
            manifest.DefineScript("jQueryCalendars_Picker").SetUrl("Calendars/jquery.calendars.picker.full.min.js", "Calendars/jquery.calendars.picker.full.js").SetDependencies("jQueryCalendars").SetVersion("2.0.1");
            manifest.DefineStyle("jQueryCalendars_Picker").SetUrl("Calendars/jquery.calendars.picker.full.min.css", "Calendars/jquery.calendars.picker.full.css").SetDependencies("jQueryUI_Orchard").SetVersion("2.0.1");

            // jQuery Time Entry.
            manifest.DefineScript("jQueryTimeEntry").SetUrl("TimeEntry/jquery.timeentry.min.js", "TimeEntry/jquery.timeentry.js").SetDependencies("jQueryPlugin").SetVersion("2.0.1");
            manifest.DefineStyle("jQueryTimeEntry").SetUrl("TimeEntry/jquery.timeentry.min.css", "TimeEntry/jquery.timeentry.css").SetVersion("2.0.1");

            // jQuery Date/Time Editor Enhancements.
            manifest.DefineStyle("jQueryDateTimeEditor").SetUrl("jquery-datetime-editor.min.css", "jquery-datetime-editor.css").SetDependencies("DateTimeEditor");

            // jQuery File Upload.
            manifest.DefineScript("jQueryFileUpload").SetUrl("jquery.fileupload-full.min.js", "jquery.fileupload-full.js").SetVersion("9.11.2").SetDependencies("jQueryUI_Widget");

            // jQuery Color Box.
            manifest.DefineScript("jQueryColorBox").SetUrl("jquery.colorbox.min.js", "jquery.colorbox.js").SetVersion("1.6.3").SetDependencies("jQuery");
            manifest.DefineStyle("jQueryColorBox").SetUrl("jquery.colorbox.min.css", "jquery.colorbox.css").SetVersion("1.6.3");

            // jQuery Cookie.
            manifest.DefineScript("jQueryCookie").SetUrl("jquery.cookie.min.js", "jquery.cookie.js").SetVersion("1.4.1").SetDependencies("jQuery");
        }
    }
}
