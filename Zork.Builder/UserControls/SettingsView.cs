using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder.UserControls
{
    public partial class SettingsView : UserControl
    {
        public GameViewModel ViewModel { get; set; }

        public SettingsView()
        {
            InitializeComponent();
        }
    }
}
