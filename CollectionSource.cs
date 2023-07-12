using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace collectionEditor
{
    public class CollectionSource
    {
        [Newtonsoft.Json.JsonIgnore]
        public long index = 0;

        public int id = 0;
        public int type = 0;//枚举类型
        public int childType = 0;//自变量的枚举类型
        public string desStr = "test";//描述字符串

        [Newtonsoft.Json.JsonIgnore]
        public List<Source> sourceList = new List<Source>();//templist转换map用

        public Dictionary<int, int> sourceMap = new Dictionary<int, int>();//<type,id>

        public override string ToString()//只显示这两种
        {
            return String.Format("{0}: {1}", index, id);
        }
    }
}
