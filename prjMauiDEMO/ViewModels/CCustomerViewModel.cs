using prjMAUIDEMO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMAUIDEMO.ViewModels
{
    public class CCustomerViewModel:INotifyPropertyChanged
    {
        List<CCustomer> _list = null;
        private int _position = 0;

        public CCustomerViewModel()
        {
            LoadData();
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public CCustomer current { get { return _list[_position]; } }

        public List<CCustomer> all { get { return _list; } }



        public void LoadData()
        {
            //string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //string path = Path.Combine(folder, "customers.txt");
            //string data = File.ReadAllText(path, Encoding.UTF8);
            //var lines = data.Split('\n');
            //foreach (var line in lines)
            //{
            //    if (!string.IsNullOrEmpty(line))
            //    {
            //        var cell = line.Split('\t');
            //        CCustomer x = new CCustomer();
            //        x.id = Convert.ToInt32(cell[0]);
            //        x.name = cell[1];
            //        x.phone = cell[2];
            //        x.email = cell[3];
            //        x.address = cell[4];
            //        _list.Add(x);
            //    }
            //}
            _list.Add(new CCustomer() { id = 1, name = "Tom", phone = "0910147258", email = "tom@gmail.com", address = "Taipei" });
            _list.Add(new CCustomer() { id = 2, name = "Storm", phone = "0910258369", email = "strom@gmail.com", address = "Keelung" });
            _list.Add(new CCustomer() { id = 3, name = "Steam", phone = "0910369147", email = "steam@gmail.com", address = "Taoyuan" });
        }

        public void moveFirst()
        {
            _position = 0;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }

        public void movePrevious()
        {
            _position--;
            if (_position < 0)
                _position = 0;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveNext()
        {
            _position++;
            if (_position >= _list.Count)
                _position = _list.Count - 1;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }
        public void moveLast()
        {
            _position = _list.Count - 1;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }

        public void moveTo(int to)
        {
            _position = to;
            PropertyChanged(this, new PropertyChangedEventArgs("current"));
        }

        public CCustomer queryByKeyword(string keyword)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].name.ToUpper().Contains(keyword.ToUpper()) ||
                    _list[i].phone.ToUpper().Contains(keyword.ToUpper()) ||
                    _list[i].email.ToUpper().Contains(keyword.ToUpper()) ||
                    _list[i].address.ToUpper().Contains(keyword.ToUpper()))
                {
                    _position = i;
                    PropertyChanged(this, new PropertyChangedEventArgs("current"));
                    return _list[i];
                }
            }
            return null;
        }
        public void persistant()
        {
            string s = "";
            foreach(var c in _list)
            {
                s += c.id.ToString() + "\t";
                s += c.name.ToString() + "\t";
                s += c.phone.ToString() + "\t";
                s += c.email.ToString() + "\t";
                s += c.address.ToString() + "\n";
            }
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string path = Path.Combine(folder, "customers.txt");
            File.WriteAllText(path, s, Encoding.UTF8);
        }
    }
}
