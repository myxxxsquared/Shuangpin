using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shuangpin
{
	class KeyMgr
	{
		public Dictionary<string, int> values;
		public Dictionary<string, char> data;
		private Random random;

		public KeyMgr()
		{
			random = new Random();
			data = new Dictionary<string, char>();
			values = new Dictionary<string, int>();
			using (var dlg = new System.Windows.Forms.OpenFileDialog())
			{
				dlg.Filter = "双拼练习文档|*.spd";
				if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					using (var stream = System.IO.File.OpenRead(dlg.FileName))
					using (var reader = new System.IO.StreamReader(stream))
					{
						while (!reader.EndOfStream)
						{
							//							try
							//							{
							string line = reader.ReadLine();
							string[] record = line.Split('!');
							data.Add(record[0].Trim(), record[1].Trim().ToUpper().ToCharArray()[0]);
							values.Add(record[0].Trim(), Convert.ToInt32(record[2]));
							//							}
							//							catch
							//							{
							//								throw;
							//							}
						}
					}
				}
				else
				{
					Environment.Exit(0);
				}
			}
		}

		public void Save()
		{
			var dlg = new System.Windows.Forms.SaveFileDialog();
			dlg.Filter = "双拼练习文档|*.spd";
			if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				using (var stream = System.IO.File.OpenWrite(dlg.FileName))
				using (var writter = new System.IO.StreamWriter(stream))
				{
					foreach (var item in data)
					{
						var sb = new StringBuilder();
						sb.Append(item.Key);
						sb.Append('!');
						sb.Append(item.Value);
						sb.Append('!');
						sb.Append(values[item.Key]);
						writter.WriteLine(sb.ToString());
					}
				}
			}
		}

		public string RandomPinyin()
		{
			int sum = 0;
			foreach (var item in values)
			{
				sum += item.Value;
			}

			int r = random.Next(sum - 1);

			sum = 0;
			foreach (var item in values)
			{
				sum += item.Value;
				if (sum >= r)
					return item.Key;
			}

			return data.Keys.ElementAt(0);
		}

		public bool Check(string pinyin, char ch)
		{
			if (new string(ch, 1).ToUpper().ToCharArray()[0] == data[pinyin])
			{
				int i = values[pinyin];
				if (i > 2)
					i = i / 2;
				values[pinyin] = i;
				return true;
			}
			else
			{
				int i = values[pinyin];
				if (i < 65536)
					i = i * 4;
				values[pinyin] = i;
				return false;
			}
		}

		public char GetKey(string pinyin)
		{
			return data[pinyin];
		}
	}
}
