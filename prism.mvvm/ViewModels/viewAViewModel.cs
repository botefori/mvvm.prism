using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace prism.mvvm.ViewModels
{
    public class viewAViewModel:BindableBase
    {
        private string _firstname="Ibrahima Sory";
        public string FirstName
        {
            get { return _firstname; }
            set { SetProperty(ref _firstname, value); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        private DateTime? _lastUpdated;
        public DateTime? LastUpdated
        {
            get { return _lastUpdated; }
            set { SetProperty(ref _lastUpdated, value); }
        }

        public DelegateCommand UpdateCommand { get; set; }

        public viewAViewModel()
        {
            UpdateCommand = new DelegateCommand(execute, canExecute).ObservesProperty(()=>FirstName).ObservesProperty(()=>LastName);
        }

        private bool canExecute()
        {
            return !String.IsNullOrWhiteSpace(FirstName) & !String.IsNullOrWhiteSpace(LastName);
        }

        private void execute()
        {
            LastUpdated = DateTime.Now;
        }
    }
}
