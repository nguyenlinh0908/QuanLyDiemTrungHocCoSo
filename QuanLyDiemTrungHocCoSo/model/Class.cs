using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemTrungHocCoSo.model
{
    class Class : sdk.MainService
    {
        private string id;

        public Class() { }
        public Class(string id)
        {
            Id = id;
       
        }

        public string Id { get => id; set => id = value; }

        public override void addObject()
        {
            throw new NotImplementedException();
        }

        public override void editObject()
        {
            throw new NotImplementedException();
        } 
    }
}
