﻿using System;
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
using System.Windows.Shapes;
using System.Net.Http;
using System.Diagnostics;

namespace TrClient
{
    /// <summary>
    /// Interaction logic for dlgFindReplace.xaml
    /// </summary>
    public partial class dlgFindReplace : Window
    {
        private clsTrDocument CurrentDocument;
        private HttpClient CurrentClient;
        private clsTrTextLines FoundLines = new clsTrTextLines();

        private string TextToFind;
        private string TextToReplaceWith;

        public dlgFindReplace(clsTrDocument Document, HttpClient Client)
        {
            InitializeComponent();
            CurrentDocument = Document;

            CurrentClient = Client;
            txtFindText.Focus();
            btnFind.IsDefault = true;
            txtReplaceText.IsEnabled = false;
            btnReplace.IsEnabled = false;
        }

        private void BtnFind_Click(object sender, RoutedEventArgs e)
        {
            TextToFind = txtFindText.Text;
            // txtReplaceText.Clear();
            if (TextToFind != null)
                if (TextToFind != "")
                {
                    FoundLines = CurrentDocument.FindText(TextToFind);

                    lstLines.ItemsSource = FoundLines;
                    if (FoundLines.Count > 0)
                    {
                        lblCount.Content = FoundLines.Count.ToString();
                        btnFind.IsDefault = false;
                        txtReplaceText.IsEnabled = true;
                        txtReplaceText.Focus();
                        btnReplace.IsEnabled = true;
                        btnReplace.IsDefault = true;
                    }
                    else
                        lblCount.Content = "(none)";
                }
        }

        private void BtnReplace_Click(object sender, RoutedEventArgs e)
        {
            TextToReplaceWith = txtReplaceText.Text;
            if (TextToReplaceWith != null)
                if (TextToReplaceWith != "")
                {
                    foreach (clsTrTextLine TL in FoundLines)
                    {
                        TL.Replace(TextToFind, TextToReplaceWith);
                    }
                }
            txtFindText.Clear();
            txtReplaceText.Clear();
        }
    }
}
