using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JenkinsTray.BusinessComponents;
using Spring.Context.Support;

namespace JenkinsTray.UI.Controls
{
    public partial class TooltipSettingsCtrl : DevExpress.XtraEditors.XtraUserControl
    {
        ConfigurationService configurationService;

        public TooltipSettingsCtrl()
        {
            InitializeComponent();
        }
    }
}
