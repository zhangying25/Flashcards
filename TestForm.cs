using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcard
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public int GetCharacterCount()
        {
            return Decimal.ToInt32(countUpDown.Value);
        }

        public int GetDurationMinute()
        {
            return Decimal.ToInt32(durationUpDown.Value);
        }
    }
}
