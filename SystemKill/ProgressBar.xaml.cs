using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SystemKill
{
    /// <summary>
    /// ProgressBar.xaml 的交互逻辑
    /// </summary>
    public partial class ProgressBar : UserControl
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        public double MaxValue { get { return pro.Maximum; } set { pro.Value = value; } }
        public double Value { get { return pro.Value; } set { pro.Value = value; } }
    }
}
