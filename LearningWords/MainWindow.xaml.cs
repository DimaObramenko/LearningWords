using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace LearningWords
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                AddItemsToComboBox();
                ShowNumberOfLearnedWords();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AddItemsToComboBox()
        {
            string path = "decks.txt";
            string[] lines = File.ReadAllLines(path);
            foreach (var item in lines)
            {
                MyComboBox.Items.Add(item);
            }
        }

        private void ShowNumberOfLearnedWords()
        {
            string path = "decks.txt";
            string[] lines = File.ReadAllLines(path);
            int numberOfAllWords = 0;
            int numberOfLearnedWords = 0;
            foreach (var item in lines)
            {
                string pathToDeck = item + ".txt";
                string[] lines1 = File.ReadAllLines(pathToDeck);
                numberOfAllWords += lines1.Length;
                for(int i = 0; i < lines1.Length; i++)
                {
                    if (lines1[i].Contains('!'))
                    {
                        numberOfLearnedWords++;
                    }
                }
            }
            NumberOfWords.Content = numberOfLearnedWords + "/" + numberOfAllWords;
        }

        private void Learn_Words_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MyComboBox.Text == "")
                {
                    MessageBox.Show("Please, select the deck");
                }
                else
                {
                    LearningWordWindow learningWordWindow = new LearningWordWindow(MyComboBox.Text);
                    learningWordWindow.Show();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Create_Deck_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddNewDeck addNewDeck = new AddNewDeck();
                addNewDeck.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
