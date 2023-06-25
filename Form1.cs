

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace collectionEditor
{
    public partial class Form1 : Form
    {

        string[] typeList = { "item(物品类型数据)", "card", "npc", "pet(宠物数据类型)","animal(动物数据类型)" };
        string[] childeTypeList = { "dish(食物)", "build(建筑)", "product(产物)", "clothes(衣服)", "mine(矿石)" };


        List<CollectionSource> SourceList;//结构体列表
        CollectionSource currentItem = null;

        string currentFilename;

        bool disableCallback =false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeCom.DataSource = typeList;
            childTypeCom.DataSource = childeTypeList;
            SourceList = new List<CollectionSource>();
        }

        private void add_Click(object sender, EventArgs e)
        {
            long id = 0;

            foreach (var c in SourceList)
            {
                if (id < c.index) id = c.index;//如果条件为真，运行，自传，每次开始赋值
            }

            id++;

            var card = new CollectionSource();
            card.index = id;
            SourceList.Add(card);
            disableCallback = true;
            itemList.DataSource = null;
            if (SourceList.Count == 1)
            {
                disableCallback = false;
            }
            itemList.DataSource = SourceList;
            disableCallback = false;
            itemList.SelectedIndex = SourceList.Count - 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (disableCallback) return;

            if (itemList.SelectedIndex == -1)
            {
                currentItem = null;
            }
            else
            {
                currentItem = SourceList[itemList.SelectedIndex];
            }

            disableCallback = true;
            refresh();
            disableCallback = false;
        }

        private void idT_TextChanged(object sender, EventArgs e)
        {
            if (currentItem == null) return;
            if (disableCallback) return;

            if (idT.Text.Length == 0) return;

            currentItem.id = int.Parse(idT.Text);

            disableCallback = true;
            itemList.DataSource = null;
            itemList.DataSource = SourceList;

            int index = SourceList.IndexOf(currentItem);
            itemList.SelectedIndex = index;
            disableCallback = false;
        }

        private void refresh()
        {
            disableAll();
            if (currentItem != null)//
            {
                enableAll();
                idT.Text = currentItem.id.ToString();//在tbid显示返回字符串
                typeCom.SelectedIndex =currentItem.type;
                childTypeCom.SelectedIndex = currentItem.childType;
                desT.Text = currentItem.desStr;
            }
        }

        private void disableAll()//关闭属性
        {

            idT.Enabled = false;
            typeCom.Enabled = false;
            childTypeCom.Enabled = false;
            desT.Enabled =false;


        }

        private void enableAll()//关闭属性
        {

            idT.Enabled = true;
            typeCom.Enabled = true;
            childTypeCom.Enabled = true;
            desT.Enabled = true;
        }

        private void typeCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentItem == null) return;
            if (disableCallback) return;

            currentItem.type = typeCom.SelectedIndex;
        }

        private void childTypeCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentItem == null) return;
            if (disableCallback) return;

            currentItem.childType = childTypeCom.SelectedIndex;
        }

        private void desT_TextChanged(object sender, EventArgs e)
        {
            if (currentItem == null) return;
            if (disableCallback) return;

            currentItem.desStr = desT.Text;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex < 0) return;

            int index = itemList.SelectedIndex;

            SourceList.RemoveAt(index);

            if (SourceList.Count > 0)
                disableCallback = true;

            itemList.DataSource = null;
            itemList.DataSource = SourceList;
            disableCallback = false;

            if (index >= SourceList.Count)
            {
                index--;
            }

            if (index >= 0)
            {
                if (itemList.SelectedIndex == index)
                {
                    itemList.SelectedIndex = -1;
                }

                itemList.SelectedIndex = index;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JSON文件(*.json)|*.json";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFilename = saveFileDialog1.FileName;
                saveJson();
            }
        }

        private void saveJson()
        {
            //写入json
            var jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(SourceList);//序列化对象
           
            File.WriteAllText(currentFilename, jsonStr);//写入

        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "JSON文件(*.json)|*.json";
            ofd.RestoreDirectory = true;
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentFilename = ofd.FileName;

                  
                    string jsonStr = File.ReadAllText(currentFilename);
                    SourceList = JsonConvert.DeserializeObject<List<CollectionSource>>(jsonStr);


                    long tempIndex = 0;

                    foreach (var c in SourceList)
                    {
                        c.index = tempIndex;
                        tempIndex++;
                    }

                    itemList.DataSource = null;
                    itemList.DataSource = SourceList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}