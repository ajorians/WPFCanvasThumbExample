using System.Collections.Generic;
using System.ComponentModel;

namespace WPFCanvasThumbExample
{
   public class VM : INotifyPropertyChanged
   {
      public VM()
      {

      }

      private List<CircleVM> _items = new List<CircleVM>()
      {
         new CircleVM(140, 90 ),
         new CircleVM(240, 190 )
      };
      public List<CircleVM> Items => _items;

      public event PropertyChangedEventHandler PropertyChanged;
   }
}