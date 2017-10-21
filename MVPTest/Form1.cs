using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPTest
{
  public partial class Form1 : Form, IMyView
  {
    MyPresenter Presenter;
    public Form1()
    {
      InitializeComponent();
      Presenter = new MyPresenter(this);
    }

    public string SomeData
    {
      get
      {
        throw new NotImplementedException();
      }
      set
      {
        label1.Text = value;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Run.
      Presenter.ChangeData();
    }

  }
}
