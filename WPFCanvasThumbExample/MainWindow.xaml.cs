using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCanvasThumbExample
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
         DataContext = new VM();
      }

      private void Thumb_DragDelta( object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e )
      {
         Thumb movingThumb = sender as Thumb;
         CircleVM circleVM = movingThumb.DataContext as CircleVM;

         circleVM.Left += e.HorizontalChange;
         circleVM.Top += e.VerticalChange;
      }
   }
}
