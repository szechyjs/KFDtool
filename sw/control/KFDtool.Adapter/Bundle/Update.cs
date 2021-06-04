using System.Collections.Generic;
using System.Text;

namespace KFDtool.Adapter.Bundle
{
    public class Update
    {
        public byte[] AppData { get; set; }

        public string AppVersion { get; set; }

        public string Audience { get; set; }

        public byte[] RamBslData { get; set; }

        public string RamBslVersion { get; set; }

        public List<Model> ProductModel { get; set; }

        public Update()
        {
            ProductModel = new List<Model>();
        }

        public string GetAppDataString()
        {
            return Encoding.UTF8.GetString(AppData);
        }

        public string GetRamBslDataString()
        {
            return Encoding.UTF8.GetString(RamBslData);
        }
    }
}
