﻿
using System.Windows.Controls;

namespace Logowanie.ViewModel

{
    public class SubItem
    {
        public SubItem(string name, UserControl screen = null)
        {
            Name = name;
            Screen = screen;
        }

        public string Name { get; private set; }

        public UserControl Screen { get; private set; }


    }
}