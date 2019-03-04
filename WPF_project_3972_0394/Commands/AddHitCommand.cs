using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_project_3972_0394.ViewModel;

namespace WPF_project_3972_0394.Commands
{
    public class AddHitCommand : ICommand
    {
        public event EventHandler CanExecuteChangedadd
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private IHitViewModel CurrentVM;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            bool result = false;
            if (parameter != null)
            {
                result = true;
            }

            return result;
        }

        public void Execute(object parameter)
        {
            var fields = (object[])parameter ;
            // לפי שיטה ראשונה לעדכון
            CurrentVM.Hits.Add(new Hit {address = fields[2].ToString()+" " + fields[3].ToString() + ", "+ fields[4].ToString() ,
                                        hitNum = Int32.Parse(fields[5].ToString()),
                                        name = fields[0].ToString()+", " +fields[1].ToString(),
                                        Time = DateTime.Parse(fields[6].ToString().Replace("/","-") + " 00:00:00 PM") });
            GetAsyncCordinate(fields[2].ToString() + " " + fields[3].ToString() + ", " + fields[4].ToString());
        }

        public AddHitCommand(IHitViewModel CurrentVM)
        {
            this.CurrentVM = CurrentVM;
        }
    }
}
