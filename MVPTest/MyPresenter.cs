using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest
{
  class MyPresenter
  {
    private IMyView View { get; set; }
    public MyPresenter(IMyView view)
    {
      View = view;
      View.SomeData = "test string";
    }

    public void ChangeData()
    {
      View.SomeData = "Some changed data";
    }
  }
}
