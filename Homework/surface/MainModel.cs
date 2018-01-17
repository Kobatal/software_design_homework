using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace surface
{
    class MainModel : INotifyPropertyChanged
    {
        public const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=homework1_16;Integrated Security=True;";
        public MainModel()
        {
            DataContext = new DataClasses1DataContext(ConnectionString);
        }

        public void Submit()
        {
            DataContext.SubmitChanges();
        }
        public Table<Person> Persons
        {
            get { return DataContext.Person; }
        }
        public DataClasses1DataContext DataContext { get; }
        private void OnPropertyChanged(string aPropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(aPropertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public string SelectTarget
        {
            get { return _SelectTarget; }
            set
            {
                if (_SelectTarget == value) return; _SelectTarget = value; OnPropertyChanged(nameof(SelectTarget));
            }
        }
        private string _SelectTarget;

        public string CollectedText { get { return _CollectedText; } private set { if (_CollectedText == value) return; _CollectedText = value; OnPropertyChanged(nameof(CollectedText)); } }
        private string _CollectedText;

        public void GetSelect()
        {
            string Result="";
            List<string> Datalist = new List<string>();
            var Persons = from r in DataContext.Person select r;
            foreach (Person aPerson in Persons)
            {
                string Person_Data = "Id:" + aPerson.Id + " Name:" + aPerson.Name + " Number:" + aPerson.Number + " Memo:" + aPerson.Memo;
                Datalist.Add(Person_Data);
            }
            string RegexStr = ".*?Memo:"+SelectTarget;
            for(int i = 0; i < Datalist.Count; i++)
            {
                if (Regex.IsMatch(Datalist[i], RegexStr))
                    Result = Result+Datalist[i]+"\r";
            }
            CollectedText = Result;
        }
    }
}
