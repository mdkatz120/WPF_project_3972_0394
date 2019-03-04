using BE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_project_3972_0394.Models;

namespace WPF_project_3972_0394.ViewModel
{
    public interface IHitViewModel
    {
        HitModel CurrentModel { get; set; }
        ObservableCollection<Hit> Hits { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
    }
}
