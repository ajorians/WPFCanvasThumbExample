using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCanvasThumbExample
{
   public class CircleVM : INotifyPropertyChanged
   {
      public CircleVM( double left, double top )
      {
         _left = left;
         _top = top;
      }

      private double _top;
      public double Top
      {
         get => _top;
         set
         {
            _top = value;
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( nameof( Top ) ) );
         }
      }

      private double _left;
      public double Left
      {
         get => _left;
         set
         {
            _left = value;
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( nameof( Left ) ) );
         }
      }

      public event PropertyChangedEventHandler PropertyChanged;
   }
}
