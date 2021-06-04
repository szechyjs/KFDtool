using System.Collections.Generic;

namespace KFDtool.Adapter.Bundle
{
    public class Model
    {
        public string Name { get; set; }

        public List<string> Revision { get; set; }

        public Model()
        {
            Revision = new List<string>();
        }
    }
}
