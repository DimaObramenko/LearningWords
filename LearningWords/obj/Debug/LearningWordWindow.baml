   M S B A M L   `   `   `  ����H  DLearningWords, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LearningWordsLearningWords  5   	   &     LearningWords.LearningWordWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LearningWords     5   	     � Title$  LearingWord��5   	   $	��450��6   $	��400��6*   .��5	      � .+�5
   
   �� $��15q�6   ���#d9f4f4 �� Padding$ 40q�63    �� CornerRadius$ 20��6@    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 50Q�6#      Color$ #4b9797��63      ShadowDepth$ 5Q�6C   6U   5      �� 5   
   $��80,72,80,209q�6   
�������$��Center=�6:   $ 40q�6U   $ 20��6b   $	��138��6t    5        5      $ 50Q�6#   $ #4b9797��63   $ 5Q�6C   6U   5      �� 5   
   -   5         ��Name$ WordInEnglish��5      $��Center=�6'   $��24(�6D   $��50��6R   $��Center=�6^   $��108,99,108,270q�6�   .��6�   Word in english6�   �� 5   
   -   5        $ Translation��5      $��Center=�6%   $��18(�6B   $��50��6P   $	��140��6\   $��Center=�6h   $��126,153,126,216q�6�   .��6�   Translation6�   � 5   
   $
��Left=�6   $��Center=�6*   $	��250��6E   $��40��6Q   $��50,240,0,139q�6]   .+�5      �� -   5         ��Name$ IRememberThisWordCheckBox��5      $
��Left=�6:   $��Center=�6U   6r   �� 5      $
��Left=�6   $��Center=�6/   $��14(�6J   $��22,5,0,7q�6X   .��6j   I remember this word6�   5      � 5   
   $
��Left=�6   $��Center=�6*   $	��392��6E   $��40��6Q   $��
0,306,0,73q�6]   .+�5      �� -   5        ���#d9f4f4���#8f8f8f$
��Left=�5   _   $	��100��6z   $��30��6�   $��50,5,0,5q�6�   .��6�   Look translation6�   �� 5      -   5        ���#7ddbdd���#478c8e$��Right=�5   X   $	��100��6t   $��30��6�   $��0,5,50,5q�6�   .��6�   	Next word6�   5      �� 5   
   -   5        ���#d9f4f4���#d9f4f4$��Center=�5   Y   $��Bottom=�6v   $��48��6�   $��30��6�   $��172,0,172,38q�6�   .��6�   Home6�   5      5       