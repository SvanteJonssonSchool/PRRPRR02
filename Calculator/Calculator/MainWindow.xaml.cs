﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            var expressionModel = new ExpressionModel();

            expressionModel.MyProperty = 1;

            TextBlock screen = new TextBlock
            {
                Text = "hej hej detta är ett test",
                FontSize = 100
            };

            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 5; i++)
            {
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());

            }
            mainGrid.RowDefinitions[0].Height = new GridLength(2.0, GridUnitType.Star);
            mainGrid.Children.Add(screen);
            screen.SetValue(Grid.RowProperty, 0);
            screen.SetValue(Grid.ColumnProperty, 0);
            screen.SetValue(Grid.ColumnSpanProperty, 5);


            

            var button = new Button();
            button.Content = "1";

            string[,] buttonContent = new string[,]
            {
                {"^x", "√", "(", ")", "Quit"},
                {"7", "8", "9", "DEL", "AC"},
                {"4", "5", "6", "X", "/"},
                {"1", "2", "3", "+", "-"},
                {"0", ".", "EXP", "(-)", "EXE"}
            };

            for (int i = 0; i < buttonContent.GetLength(0); i++)
            {
                for (int j = 0; j < buttonContent.GetLength(1); j++)
                {
                    Button btn = new Button { 
                        Content = buttonContent[i, j],
                    };
                    btn.Click += Button_Clicked();
                    mainGrid.Children.Add(btn)
                }
            }

            /*
            
            for (int i = 0; i < 12; i++)
            {
                String btnName = "btn" + i.ToString();
                Button btn = new Button
                {
                    Name = btnName,
                    Content = i
                };
                if(i == 1)
                {
                    btn.Name = "btnPoint";
                    btn.Content = ",";
                }
                else if(i == 2)
                {
                    btn.Name = "btnDel";
                    btn.Content = "DEL";
                }
                else if(i >= 3)
                {
                    btn.Name = "btn" + (i - 2);
                    btn.Content = i - 2;
                }


                mainGrid.Children.Add(btn);
                btn.SetValue(Grid.RowProperty, 4 - i/3);
                btn.SetValue(Grid.ColumnProperty, 0 + i % 3);
                /*if(btn.Content.ToString() == "0")
                {
                    btn.SetValue(Grid.RowProperty, 4);
                    btn.SetValue(Grid.ColumnProperty, 2);
                }
                else
                {
                    btn.SetValue(Grid.RowProperty, 3 + i/3);
                    btn.SetValue(Grid.ColumnProperty, 3 + i%3);
                }*/
            
            }

        private RoutedEventHandler Button_Clicked()
        {
            throw new NotImplementedException();
        }
    }
    }
}
