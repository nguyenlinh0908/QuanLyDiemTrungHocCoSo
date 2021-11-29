using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemTrungHocCoSo.model
{
    class Student : sdk.MainService
    {
        private string id, name, dateOfBirth, address;
        private byte gender;

        public Student() {}
        public Student(string id, string name, string dateOfBirth, string address, byte gender)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.gender = gender;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public byte Gender { get => gender; set => gender = value; }

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
