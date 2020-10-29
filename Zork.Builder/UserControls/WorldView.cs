using System;
using System.Windows.Forms;
using Zork.Builder.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    public partial class WorldView : UserControl
    {
        public GameViewModel ViewModel { get; set; }

        public WorldView()
        {
            InitializeComponent();
        }
    }
}
