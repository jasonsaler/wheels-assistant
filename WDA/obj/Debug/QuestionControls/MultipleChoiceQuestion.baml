   M S B A M L   `   `   `  ����N  JWheelsDataAssistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:WheelsDataAssistant.QuestionControls$WheelsDataAssistant.QuestionControls  5      A    ;WheelsDataAssistant.QuestionControls.MultipleChoiceQuestion   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:WheelsDataAssistant.QuestionControls     5      $
��auto��5      $��50,10,50,10q�5	      $
��auto��5
      $��Stretch=�5      .��5      � $
��auto��5   	   $	��Top=�5   	   $
��auto��5   	   $��Stretch=�5   	   .+�5   
   � $
��auto��5      $��Stretch=�5      $
��auto��5      $
��Left=�5      .+�5      �� -   5          ��Name$  commentCheckBox��5      $��Add comment box��5      $
��Left=�5      $��0,0,0,0q�5      $��bottom=�5      4  .System.Windows.Automation.AutomationProperties   HelpText$6 0Select to give the question a comment Box option��5      5       �� 5"      -   5         ��Name$ questionNumber��5#      $
��Left=�5$      $��0,0,0,0q�5%      $��1��5&      $	��Top=�5'      $��Calibri)�5(      $��16(�5)      $
��Bold"�5*      
���   �
������ $
��auto��5-       � ToolTip$' !Change the number to change order��5.       �� MaxLines$ 1��5/       �� 	MaxLength$ 4��50       �� IsUndoEnabled .  51      � 53      -   5         �Name$ deletIconBackground��54      $��25��55      $	��Top=�56      $��0,70,0,0q�57      $��25��58      $
��Left=�59      .+�5;      �� -   5         ��Name$ 	deletIcon��5<      $
��Left=�5=      $��25��5>      $��25��5?      $	��Top=�5@      $>��8/WheelsDataAssistant;component/Resources/CloseXBlack.png��5A      $ Delete this question��5D   3   5E      � 5G      -   5        $ plusIconBackground��5H      $��25��5I      $	��Top=�5J      $��	0,100,0,0q�5K      $��25��5L      $
��Left=�5M      .+�5O      �� -   5        $ plusIcon��5P      $
��Left=�5Q      $��25��5R      $��25��5S      $	��Top=�5T      $2��,/WheelsDataAssistant;component/PlusTrans.png��5U      $! Add another choice; up to 6��5X   2   5Y      � 5[      -   5        $ minusIconBackground��5\      $��25��5]      $	��Top=�5^      $��	0,130,0,0q�5_      $��25��5`      $
��Left=�5a      .+�5c      �� -   5        $ 	minusIcon��5d      $
��Left=�5e      $��25��5f      $��25��5g      $	��Top=�5h      $3��-/WheelsDataAssistant;component/MinusTrans.png��5i      $+ %Remove a choice; must have at least 2��5l   3   5m      �� 5o      -	   5        $  
naCheckbox��5p      $	��N/A��5q      $
��Left=�5r      $��0,37,0,0q�5s      $	��Top=�5t      $/ )Select to give the question an N/A option��5u      6v   5w      � 5y   
   $
��auto��5z      $��Stretch=�5{      $
��auto��5|      $
��Left=�5}      $��50,0,0,0q�5~      .+�5�      � $
��auto��5�      $	��Top=�5�      $
��auto��5�      $��Stretch=�5�      $��0,0,0,0q�5�      .+�5�      �� -
   5        	 ��Name$	 Question��5�      $��Stretch=�5�      $��0,0,0,0q�5�      $
��Wrap=�5�      $��This is the Question?��5�      $	��Top=�5�      $��Calibri)�5�      $
��auto��5�      $��16(�5�      
���   �$y�Hidden=�5�      �� 5�      -   5        $ newQuestion��5�      $��Stretch=�5�      $��0,0,0,0q�5�      
 �� TextWrapping$

 Wrap=�5�      $	��Top=�5�      $��Calibri)�5�      $��16(�5�      $
��auto��5�       �� 
AcceptsTab .  �� AcceptsReturn .  �� 	IsEnabled . $ 2��5�      $ Enter the question��5�       "  AppPrimaryBackgroundColorLight#��[  5�      $ ��Enter the question here...��5�      5�      5�      � 5�      -   5        $ buttonsGrid��5�      $
��auto��5�      $	��Top=�5�      $
��auto��5�      $��Stretch=�5�      $��	0,35,0,80q�5�      .+�5�      � -   5        $ firstButton��5�        multiChoiceStyle#��[ 5�      .+�5�      	� -   5         	�Name$ firstChoice��5�        multiChoiceButtonStyle#��[ 5�      $ Select the best option ��5�      5�      �� 5�      -   5        $ firstChoiceInput��5�        multiChoiceTextBoxStyle#��[ 5�      $ Input the choice option��5�      5�      5�      � 5�      -   5        $ secondButton��5�      #��[ 5�      $��0,25,0,0q�5�      .+�5�      	� -   5        $ secondChoice��5�      #��[ 5�      $ Select the best option ��5�      5�      �� 5�      -   5        $ secondChoiceInput��5�      #��[ 5�      $ Input the choice option��5�      5�      5�      � 5�      -   5        $ thirdButton��5�      #��[ 5�      $��0,50,0,0q�5�      .+�5�      	� -   5        $ thirdChoice��5�      #��[ 5�      $ Select the best option ��5�      5�      �� 5�      -   5        $ thirdChoiceInput��5�      #��[ 5�      $ Input the choice option��5�      5�      5�      � 5�      -   5        $ fourthButton��5�      #��[ 5�      $��0,75,0,0q�5�      .+�5�      	� -   5        $ fourthChoice��5�      #��[ 5�      $ Select the best option ��6I   6�   �� 5�      -   5        $ fourthChoiceInput��5�      #��[ 5�      $ Input the choice option��5�      5�      5�      � 5�      -   5        $ fifthButton��5�      #��[ 5�      $��	0,100,0,0q�5�      $y�	Collapsed=�5�      .+�5�      	� -   5        $ fifthdChoice��5      #��[ 5     $ Select the best option ��5     5     �� 5     -   5        $ fifthChoiceInput��5     #��[ 5     $ Input the choice option��5     5
     5     � 5     -   5        $ sixthButton��5     #��[ 5     $��	0,125,0,0q�5     $y�	Collapsed=�5     .+�5     	� -   5        $ sixthChoice��5     #��[ 5     $ Select the best option ��5     5     �� 5     -   5        $ sixthChoiceInput��5     #��[ 5     $ Input the choice option��5     5     5     5!     � 5#     -   5        $ commentGrid��5$     $
��auto��5%     $��Bottom=�5&     $
��auto��5'     $��Stretch=�5(     $��0,0,0,0q�5)     .+�5+     �� -    5        $	 commentTitle��5,     $��Stretch=�5-     $��0,0,0,0q�5.     $
��Wrap=�5/     $��
Comments: ��50     $	��Top=�51     $��Calibri)�52     $
��auto��53     $��16(�54     
���   �$y�	Collapsed=�56     �� 58     -!   5        $ userCommentBox��59     $��Stretch=�5:     $��0,20,0,0q�5;     $��Comments go here...��5<      �� 
IsReadOnly . 
�������$��Bottom=�5?     $��Calibri)�5@     $��16(�5A     
���   �$
��auto��5C      .  .  . $ 2��5G     $
 WrapWithOverflow=�5H      �� MinLines$ 2��5I     $y�	Collapsed=�5J     $% Enter any comments if necessary��5K     6�   5L     5M     5N     5O     