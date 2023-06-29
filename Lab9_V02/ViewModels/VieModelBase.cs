﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02.ViewModels
{
    public class VieModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Метод изменения свойства с вызовом события PropertyChanged
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="prop">Изменяемое свойство</param>
        /// <param name="value">Новое значение</param>
        /// <param name="propName">Имя свойства</param>
        /// <returns></returns>
        protected bool Set<T>(ref T prop, T value, [CallerMemberName] string propName=null)
        {
            if (Equals(prop, value)) 
                return false;
            prop = value;
            OnPropertyChanged(propName);
            return true;
        }
    }
}
   
