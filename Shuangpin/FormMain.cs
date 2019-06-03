using System.Windows.Forms;

namespace Shuangpin
{
	public partial class FormMain : Form
	{
		KeyMgr mgr;
		string current;

		public FormMain()
		{
			InitializeComponent();
			mgr = new KeyMgr();
			current = null;
		}

		private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar=='1')
			{
				mgr.Save();
				return;
			}

			if(current != null)
			{
				if(!mgr.Check(current, e.KeyChar))
				{
					key.Text = new string(mgr.GetKey(current), 1);
					return;
				}
			}

			key.Text = "";
			current = mgr.RandomPinyin();
			pinyin.Text = current;
		}
	}
}
