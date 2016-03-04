using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacebookSeller
{
    public partial class Form2 : Form
    {

        private readonly FbPost _fbPost;
        private readonly List<FbGroup> _fbGroups;
        private readonly FbRequest _fbRequest;

        public Form2()
        {
            InitializeComponent();
            checkedListBox1.ItemCheck += (sender, e) =>
            {
                _fbGroups[e.Index].IsChecked = (e.NewValue != CheckState.Unchecked);
            };
        }

        public Form2(FbPost fbPost, IEnumerable<FbGroup> fbGroups, FbRequest fbRequest) : this()
        {
            _fbPost = fbPost;
            _fbGroups = _fbGroups = fbGroups.Select(x => { x.IsChecked = false; return x; }).ToList();
            _fbRequest = fbRequest;
        }

        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            (new Form3(_fbPost, _fbGroups, _fbRequest)).Show();
            Close();
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            checkedListBox1.DataSource = _fbGroups;
            checkedListBox1.DisplayMember = "Name";
        }
    }
}
