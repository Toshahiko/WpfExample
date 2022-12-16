using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExample.ViewModels
{
    public class Window1ViewModel
    {
        public class Data { }
        public Window1ViewModel()
        {
            ItemsSource = new[] { new Data(), new Data(), new Data(), new Data(), new Data(), };
        }

        public IReadOnlyCollection<Data> ItemsSource { get; set; }
    }

}
