﻿using DragDrop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DragDrop.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Point startPoint { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lvDrag_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            // Store the mouse position
            startPoint = e.GetPosition(null);
        }

        private void lvDrag_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            //// Get the current mouse position
            //Point mousePos = e.GetPosition(null);
            //Vector diff = startPoint - mousePos;

            //if (e.LeftButton == MouseButtonState.Pressed &&
            //    Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
            //    Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
            //{
            //    // Get the dragged ListViewItem
            //    ListView listView = sender as ListView;
            //    ListViewItem listViewItem =
            //        FindAnchestor<ListViewItem>((DependencyObject)sender);

            //    // Find the data behind the ListViewItem
            //    Person person = (Person)listView.ItemContainerGenerator.
            //        ItemFromContainer(listViewItem);

            //    // Initialize the drag & drop operation
            //    DataObject dragData = new DataObject("myFormat", person);
            //    System.Windows.DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);
            //}

        }
        // Helper to search up the VisualTree
        private static T FindAnchestor<T>(DependencyObject current)
            where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }
        private void lvDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("myFormat") ||
                sender == e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void lvDrop_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                Person person = e.Data.GetData("myFormat") as Person;
                ListView listView = sender as ListView;
                listView.Items.Add(person);
            }
        }

        private void lvDrag_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the current mouse position
            Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
                Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
            {
                // Get the dragged ListViewItem
                ListView listView = sender as ListView;
                ListViewItem listViewItem =
                    FindAnchestor<ListViewItem>((DependencyObject)e.OriginalSource);
                if (listViewItem != null)
                {
                    // Find the data behind the ListViewItem
                    Person person = (Person)listView.ItemContainerGenerator.
                        ItemFromContainer(listViewItem);

                    // Initialize the drag & drop operation
                    DataObject dragData = new DataObject("myFormat", person);
                    System.Windows.DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);

                }
            }

        }
    }
}
