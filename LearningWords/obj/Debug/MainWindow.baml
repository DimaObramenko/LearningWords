   M S B A M L   `   `   `  ����H  DLearningWords, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LearningWordsLearningWords  5   	       LearningWords.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LearningWords     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��400��6)   .��5	      � .+�5
   
   �� $��15q�6   ���#d9f4f4 �� Padding$ 40q�63    �� CornerRadius$ 20��6@    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 50Q�6#      Color$ #4b9797��63      ShadowDepth$ 5Q�6C   6U   5      �� 5   
   $��Center=�6   $
��Bold"�6-   $��34(�6?   $��96,52,96,304q�6M   $	��200��6c   .��6o   Select deck6|   �� 5   
   -   5         ��Name$ 
MyComboBox��5      $��Center=�6'   $	��200��6D   $��20(�6P   $��0 150 0 220q�6^   6u   �� 5   
   -   5        $��16(�5      ���#7ddbdd$��Center=�6V   $��50��6s   $	��120��6   $��100 210 100 100q�6�   .��6�   Learn words6�   �� 5   
   -   5        ���#b8ebec$��Right=�5   G   $��80��6c   $��34��6n   $��Bottom=�6z   $��40 55q�6�   .��6�   Create deck6�   �� 5   
   -   5         ��Name$ NumberOfWords��5      $��16(�6'   $
��Left=�65   $��50��6P   $��40��6[   $��Bottom=�6h   $��
150,0,0,50q�6�   �� 5   
   $
��Left=�6   $	��110��6+   $��40��67   $��16(�6C   $��Bottom=�6Q   $��40 50q�6l   .��6{   Your progress:6�   5      5      