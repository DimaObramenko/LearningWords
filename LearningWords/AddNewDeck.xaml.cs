using System;
using System.Windows;

namespace LearningWords
{
    public partial class AddNewDeck : Window
    {
        public AddNewDeck()
        {
            InitializeComponent();
        }

        private void Create_Deck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DeckNameTextBox.Text != "")
                {
                    Deck deck = new Deck(DeckNameTextBox.Text);
                    deck.AddNewDeck(DeckNameTextBox.Text);
                    AddNewWordsToNewDeckWindow addNewWordsToNewDeckWindow = new AddNewWordsToNewDeckWindow(DeckNameTextBox.Text);
                    addNewWordsToNewDeckWindow.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Please, enter the deck name");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
