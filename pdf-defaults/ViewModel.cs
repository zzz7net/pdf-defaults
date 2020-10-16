using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace pdf_defaults
{
    public class ViewModel
    {
        public ObservableCollection<string> CmbContent_ZoomFactor { get; private set; }
        public ObservableCollection<string> CmbContent_NaviPanels { get; private set; }
        public ObservableCollection<string> CmbContent_PageLayout { get; private set; }
        public ObservableCollection<string> CmbContent_DocsMagnif { get; private set; }

        public ViewModel()
        {
            CmbContent_ZoomFactor = new ObservableCollection<string>
            {                                
                "Inherit Zoom",
                "Actual Size",
                "Fit Page",
                "Fit Width",
                "Fit Visible",
                "Zoom To:"
            };

            CmbContent_NaviPanels = new ObservableCollection<string>
            {
                "Page Only",
                "Bookmarks Panel and Page",
                "Pages Panel and Page",
                "Attachments Panel and Page",
                "Layers Panel and Page"
            };

            CmbContent_PageLayout = new ObservableCollection<string>
            {
                "Default",
                "Single Page",
                "Single Page Continuous",
                "Two-Up (Facing)",
                "Two-Up Continuous (Facing)",
                "Two-Up (Cover Page)",
                "Two-Up Continuous (Cover Page)"
            };

            CmbContent_DocsMagnif = new ObservableCollection<string>
            {
                "Default",
                "Actual Size",
                "Fit Page",
                "Fit Width",
                "Fit Height",
                "Fit Visible"
            };
        }
    }
}
