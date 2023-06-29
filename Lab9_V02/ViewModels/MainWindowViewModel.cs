using Lab9_V02.Business.Infastructure;
using Lab9_V02.Business.Managers;
using Lab9_V02.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02.ViewModels
{
    public class MainWindowViewModel : VieModelBase
    {
        ManagersFactory factory;
        GroupManager groupManager;
        StudentManager studentManager;
        #region Public properties
        /// <summary>
        /// Список групп
        /// </summary>
        public ObservableCollection<Group> Groups { get; set; }
        /// <summary>
        /// Список студентов группы
        /// </summary>
        public ObservableCollection<Student> Students { get; set; }
        public string Title { get => title; set => title = value; }

        #region Выбранная группа
        private Group _selectedGroup;
        public Group SelectedGroup
        {
            get => _selectedGroup;
            set
            {
                Set(ref _selectedGroup, value);
            }
        }

        #endregion
        #endregion
        private string title = "Groups Window";
        public MainWindowViewModel()
        {
            factory = new ManagersFactory();
            groupManager = factory.GetGroupManager();
            studentManager = factory.GetSudentManager();
            Groups = new ObservableCollection<Group>(groupManager.Groups);
            Students = new ObservableCollection<Student>();
        }
    }
}


