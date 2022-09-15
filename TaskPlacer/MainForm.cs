using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPlacer
{
  public partial class MainForm : Form
  {
    private Chromosome _test;

    public MainForm()
    {
      InitializeComponent();
      _test = Chromosome.CreateFirstGeneration(DummyMasterTaskData.Create());
    }
  }
}
