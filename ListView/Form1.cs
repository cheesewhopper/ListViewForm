namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button2_Click(object sender, EventArgs e)
        {
            //현재 선택된 것을 찾기
           if(listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("삭제할 아이템을 선택 하세요.", "오류",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //사용자에게 확인
            ListViewItem selItem = listView1.SelectedItems[0];
            DialogResult dlg = MessageBox.Show("삭제할까요?\n"+ selItem.Text, "아이템삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg != System.Windows.Forms.DialogResult.Yes) return;
            
            //삭제코드
            
            listView1.Items.Remove(selItem);
            MessageBox.Show("삭제완료", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radDetail.Checked)
            {
                listView1.View = View.Details;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radLarge.Checked)
            {
                listView1.View = View.LargeIcon;
            }
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = listView1.Items.Add("new item", 3);
            newitem.SubItems.Add("날짜");
            newitem.SubItems.Add("file");
            newitem.SubItems.Add("1009");
        }
    }
}