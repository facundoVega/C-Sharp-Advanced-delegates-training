﻿using FieldValidatorAPI.FieldValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Views
{
    public class MainView : IView
    {
        private readonly IView _registerView;
        private readonly IView _loginView;

        public MainView(IView registerView, IView loginView)
        {
            _registerView = registerView;
            _loginView = loginView;
        }
        public IFieldValidator FieldValidator => null;

        public void RunView()
        {
            CommonOutputText.WriteMainHeading();

            Console.WriteLine("Please press 'l' to login or if you are not yet registered please press 'r'");
            ConsoleKey key = Console.ReadKey().Key;

            if(key == ConsoleKey.R)
            {
                RunUserRegistrationView();
                RunLoginView();
            }
            else if(key == ConsoleKey.L) 
            {
                RunLoginView();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Goodbye");
                Console.ReadKey();
            }

        }

        private void RunUserRegistrationView()
        {
            _registerView.RunView();
        }

        private void RunLoginView()
        {
            _loginView.RunView();
        }
    }
}
