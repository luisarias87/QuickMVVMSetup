using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace QuickMVVMSetup
{
    public class MainVM : ChangeNotifier
    {
        

        public MainVM()
        {
            
            Persons = new ObservableCollection<Person>();
        }

        private Person person;

        public Person TargetPerson
        {
            get { return person; }
            set { person = value; OnPropertyChanged(nameof(TargetPerson)); }
        }

        private ObservableCollection<Person> _persons;

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { _persons = value;  }
        }

        

        public void AddPerson(object person1) 
        {
            Persons.Add(TargetPerson);// add it to the command 

            TargetPerson = new Person();
        }


        public ICommand CMDAdd => new RelayCommand(AddPerson, null);







    }
}
