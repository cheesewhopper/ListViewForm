namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button2_Click(object sender, EventArgs e)
        {
            //���� ���õ� ���� ã��
           if(listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("������ �������� ���� �ϼ���.", "����",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //����ڿ��� Ȯ��
            ListViewItem selItem = listView1.SelectedItems[0];
            DialogResult dlg = MessageBox.Show("�����ұ��?\n"+ selItem.Text, "�����ۻ���", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg != System.Windows.Forms.DialogResult.Yes) return;
            
            //�����ڵ�
            
            listView1.Items.Remove(selItem);
            MessageBox.Show("�����Ϸ�", "Ȯ��", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
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
            newitem.SubItems.Add("��¥");
            newitem.SubItems.Add("file");
            newitem.SubItems.Add("1009");
        }
    }
}