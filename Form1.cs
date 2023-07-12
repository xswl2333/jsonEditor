

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace collectionEditor
{
    public partial class Form1 : Form
    {

        string[] typeList = { "item(��Ʒ��������)", "card", "npc", "pet(������������)", "animal(������������)", "wildanimal(Ұ��������������)" };
        string[] sourceTypeList = { "recipe(�䷽���䷽id)", "plant(ֲ��������Դ,itemid)", "mine(�ɿ���Դ��itemid)", "npc(npc����,npcId)", "drop(������,��Ӧ������id)", "animal_product(��Ӧ����Id)", "building(��ӦitemId,�ɿ�)" };
        string[] childeTypeList = { "card(����)", "npc", "dish(ʳ��)", "build(����)", "wildanimal(Ұ������)", "livestock(����)", "pet(����)", "plant(ֲ��)", "seafood(��з)", "mine(��ʯ)", "product(����)", "other(����)", "clothes(�·�)" };


        List<CollectionSource> SourceList;//�ṹ���б�
        CollectionSource currentItem = null;
        Source currentSource = null;

        string currentFilename;

        bool disableCallback = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeCom.DataSource = typeList;
            childTypeCom.DataSource = childeTypeList;
            sourceTypeCom.DataSource = sourceTypeList;
            SourceList = new List<CollectionSource>();
            currentItem = null;
            currentSource = null;
        }

        private void add_Click(object sender, EventArgs e)
        {
            long id = 0;

            foreach (var c in SourceList)
            {
                if (id < c.index) id = c.index;//�������Ϊ�棬���У��Դ���ÿ�ο�ʼ��ֵ
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
                idT.Text = currentItem.id.ToString();//��tbid��ʾ�����ַ���
                typeCom.SelectedIndex = currentItem.type;
                childTypeCom.SelectedIndex = currentItem.childType;
                desT.Text = currentItem.desStr;

                sourceMapList.DataSource = currentItem.sourceList;
                if (currentItem.sourceList.Count > 0)//��ǰ��������>0
                {
                    currentSource = currentItem.sourceList[0];
                    sourceMapList.SelectedIndex = 0;//Ĭ������
                    refreshSource();//ˢ�¼���
                }
            }
        }

        private void disableAll()//�ر�����
        {

            idT.Enabled = false;
            typeCom.Enabled = false;
            childTypeCom.Enabled = false;
            desT.Enabled = false;


        }

        private void enableAll()//�ر�����
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

            saveFileDialog1.Filter = "JSON�ļ�(*.json)|*.json";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFilename = saveFileDialog1.FileName;
                saveJson();
            }
        }

        private void saveJson()
        {

            foreach (var data in SourceList)
            {
                foreach (var list in data.sourceList)
                {
                    data.sourceMap[list.sourceType] = list.sourceId;
                }
            }
            //д��json
            var jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(SourceList);//���л�����

            File.WriteAllText(currentFilename, jsonStr);//д��

        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "JSON�ļ�(*.json)|*.json";
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
                        foreach (var list in c.sourceMap)
                        {
                            var source = new Source();
                            source.sourceType = list.Key;
                            source.sourceId = list.Value;
                            c.sourceList.Add(source);
                        }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentItem == null) return;
            if (currentSource == null) return;
            if (disableCallback) return;

            currentSource.sourceType = sourceTypeCom.SelectedIndex;
        }

        private void addMap_Click(object sender, EventArgs e)
        {
            if (currentItem == null) return;

            var source = new Source();
            // currentItem.sourceMap[0] = 0;
            currentItem.sourceList.Add(source);

            disableCallback = true;
            sourceMapList.DataSource = null;
            sourceMapList.DataSource = currentItem.sourceList;
            disableCallback = false;
            sourceMapList.SelectedIndex = -1;
            sourceMapList.SelectedIndex = currentItem.sourceMap.Count - 1;
        }


        private void sourceMapList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentItem == null) return;
            if (disableCallback == true) return;

            if (sourceMapList.SelectedIndex == -1)
            {
                currentSource = null;
            }
            else
            {
                currentSource = currentItem.sourceList[sourceMapList.SelectedIndex];
            }

            disableCallback = true;
            refreshSource();
            disableCallback = false;
        }

        private void deleteMap_Click(object sender, EventArgs e)
        {

            if (currentItem == null) return;
            if (sourceMapList.SelectedIndex < 0) return;

            int index = sourceMapList.SelectedIndex;

            currentItem.sourceList.RemoveAt(index);

            if (currentItem.sourceList.Count > 0)
                disableCallback = true;

            sourceMapList.DataSource = null;
            sourceMapList.DataSource = currentItem.sourceList;
            disableCallback = false;

            if (index >= currentItem.sourceList.Count)
            {
                index--;
            }

            if (index >= 0)
            {
                if (sourceMapList.SelectedIndex == index)
                {
                    sourceMapList.SelectedIndex = -1;
                }

                sourceMapList.SelectedIndex = index;
            }
        }

        private void refreshSource()
        {
            disableSource();
            if (currentSource != null)
            {
                enableSource();
                sourceIdT.Text = currentSource.sourceId.ToString();//��tbid��ʾ�����ַ���
                sourceTypeCom.SelectedIndex = currentSource.sourceType;
            }

        }
        private void disableSource()
        {
            sourceTypeCom.Enabled = false;
            sourceIdT.Enabled = false;

        }

        private void enableSource()
        {
            sourceTypeCom.Enabled = true;
            sourceIdT.Enabled = true;

        }

        private void sourceIdT_TextChanged(object sender, EventArgs e)
        {
            if (currentItem == null) return;
            if (currentSource == null) return;
            if (disableCallback) return;

            if (sourceIdT.Text.Length == 0) return;

            currentSource.sourceId = int.Parse(sourceIdT.Text);

            disableCallback = true;
            sourceMapList.DataSource = null;
            sourceMapList.DataSource = currentItem.sourceList;

            int index = currentItem.sourceList.IndexOf(currentSource);
            sourceMapList.SelectedIndex = index;
            disableCallback = false;
        }
    }
}