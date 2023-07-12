using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace collectionEditor
{
    public class Source
    {
        public int sourceType = 0;
        public int sourceId = 0;
        public Source()
        {

        }
        public override string ToString()
        {
            return String.Format("{0}: {1}", sourceType, sourceId);
        }
    }
}
