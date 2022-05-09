using System;
using System.Collections.Generic;
using System.Windows;

namespace LearningWords
{
    public partial class LearningWordWindow : Window
    {

        private static Dictionary<string, string> words;
        private static int count = 0;
        private static int length;
        private Deck deck;
        public LearningWordWindow(string deckName)
        {
            InitializeComponent();

            try
            {
                deck = new Deck(deckName);
                words = deck.GetWordsFromDeck();
                length = words.Count;
                count = 0;
                FirstWord();
                Translation.Visibility = Visibility.Hidden;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FirstWord()
        {
            var e = words.GetEnumerator();
            e.MoveNext();
            var anElement = e.Current;
            WordInEnglish.Content = anElement.Key;
        }

        private void Look_Translation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Translation.Visibility = Visibility.Visible;
                var pair = words.GetEnumerator();
                for (int i = 0; i < count + 1; i++)
                {
                    pair.MoveNext();
                }
                var element = pair.Current;
                Translation.Content = element.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Next_Word_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (count + 2 > length)
                {
                    MessageBox.Show("The words are over in this deck");
                }
                Translation.Visibility = Visibility.Hidden;
                if (IRememberThisWordCheckBox.IsChecked == true)
                {
                    deck.IKnowThisWord(WordInEnglish.Content.ToString());
                }
                IRememberThisWordCheckBox.IsChecked = false;

                var pair = words.GetEnumerator();
                for (int i = 0; i < count + 2; i++)
                {
                    pair.MoveNext();
                }
                count++;
                var element = pair.Current;
                WordInEnglish.Content = element.Key;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Go_Home_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
