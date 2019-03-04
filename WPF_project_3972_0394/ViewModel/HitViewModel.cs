using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using WPF_project_3972_0394.Models;
using WPF_project_3972_0394.Commands;

namespace WPF_project_3972_0394.ViewModel
{
    public class HitViewModel : INotifyPropertyChanged, IHitViewModel
    {
        public HitModel CurrentModel { get; set; }
        public AddHitCommand AddHit { get; set; }


        public ObservableCollection<Hit> Hits { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        public HitViewModel()
        {
            CurrentModel = new HitModel();
            Hits = new ObservableCollection<Hit>(CurrentModel.Hits);

            // פקודת הוספת נפילה לפי מתודה ראשונה
            AddHit = new AddHitCommand(this);

        }
    }
    }
