using System;
using System.Windows;

namespace LearningWords
{
    public partial class AddNewWordsToNewDeckWindow : Window
    {
        private static Deck deck;
        public AddNewWordsToNewDeckWindow(string deckName)
        {
            InitializeComponent();
            deck = new Deck(deckName);
        }

        private void Add_Word_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EnglishWord.Text == "" || UkrainianWord.Text == "")
                {
                    MessageBox.Show("Invalid input");
                }
                else
                {
                    deck.AddNewWord(EnglishWord.Text, UkrainianWord.Text);
                }
                EnglishWord.Text = "";
                UkrainianWord.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void Go_To_Main_Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
