using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clac
{
  public partial class MainApp : Form
  {
    public MainApp()
    {
      InitializeComponent();
    }

    private void MainApp_Load(object sender, EventArgs e)
    {

    }

    private void MainApp_MouseLeave(object sender, EventArgs e)
    {
      MainApp.ActiveForm.Opacity = 50;
    }
  }
}
