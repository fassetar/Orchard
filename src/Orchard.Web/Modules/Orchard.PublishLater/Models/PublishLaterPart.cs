using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.ContentManagement.Utilities;
using System;

namespace Orchard.PublishLater.Models {
    public class PublishLaterPart : ContentPart<PublishLaterPart>, IPublishingControlAspect {
        private readonly LazyField<DateTime?> _scheduledPublishUtc = new LazyField<DateTime?>();
        public LazyField<DateTime?> ScheduledPublishUtc { get { return _scheduledPublishUtc; } }
    }
}