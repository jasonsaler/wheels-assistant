   M S B A M L   `   `   `  ����N  JWheelsDataAssistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WheelsDataAssistantWheelsDataAssistant  5      /    )WheelsDataAssistant.BlankResponseQuestion   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WheelsDataAssistant     5      $
��auto��5      $
��auto��5	      $	��200��5
      $��50,10,50,10q�5      $��Stretch=�5      $	��Top=�5      .��5      � -   5          �Name$  	wholeGrid��5   	   $
��auto��5   	   $	��Top=�5   	   $
��auto��5   	   $��Stretch=�5   	   .+�5   
   � $
��auto��5      $��Stretch=�5      $
��auto��5      $
��Left=�5      .+�5      �� -   5         ��Name$ questionNumber��5      $
��Left=�5      $��0,0,0,0q�5      $��1��5      $	��Top=�5       $��Calibri)�5!      $
��Bold"�5"      $��16(�5#      
���   �
������ $
��auto��5&       � ToolTip$' !Change the number to change order��5'       �� MaxLines$ 1��5(       �� 	MaxLength$ 4��6    �� IsUndoEnabled .  4  .System.Windows.Automation.AutomationProperties   HelpText$4 .Change the number to change the question order��6B   � 5*      -   5        $  deletIconBackground��5+      $��25��5,      $	��Top=�5-      $��0,30,0,0q�5.      $��25��5/      $
��Left=�50      $y�Visible=�51      .+�53      �� -   5         ��Name$ 	deletIcon��54      $
��Left=�55      $��25��56      $��25��57      $	��Top=�58      $��Resources/CloseXBlack.png��59      $ Delete the question��5=      5>      �� 5@      -   5         ��Name$ 
naCheckbox��5A      $	��N/A��5B      $
��Left=�5C      $��50,4,0,0q�5D      $	��Top=�5E      $5 /Select to include a Not Applicable (N/A) option��5F      $/ )Select to give the question an N/A option��5G      5I      5J      � 5L   
   -   5        $  
holderGrid��5M      $
��Left=�5N      $
��auto��5O      $��	100,0,0,0q�5P      $��Stretch=�5Q      $
��auto��5R      $	��100��5S      .+�5U      � -   5        $  
AnswerGrid��5V      $��Right=�5W      $
��auto��5X      $��	200,0,0,0q�5Y      $��Stretch=�5Z      $
��auto��5[      .+�5]      �� -   5        $ responseText��5^      $
��auto��5_      	 �� TextWrapping$
	 Wrap=�5`      $��Response goes here...��5a      $��Calibri)�5b      $��16(�5c      $	��Top=�5d      $
��Left=�5e      $
��auto��5f      $��50��5g      $	��400��5h      $��0,0,0,0q�5i      
 �� 	IsEnabled
 .  �� AcceptsReturn .  �� 
AcceptsTab . $( "Enter the response to the question��5m      5o      5p      � 5r      -	   5        $  QuestionGrid��5s      $
��Left=�5t      $
��auto��5u      $��0,0,0,0q�5v      $��50��5w      $��Stretch=�5x      $
��auto��5y      .+�5{      �� -
   5        $ questionTextInput��5|      $��Right=�5}      $
��auto��5~      $
	 Wrap=�5      $��Calibri)�5�      $��16(�5�      $	��Top=�5�      $
��auto��5�      $	��200��5�      $��50��5�      $��0,0,0,0q�5�      $ Question Here��5�      
 .  .  . $y�Visible=�5�      $ Enter the question��5�       "  AppPrimaryBackgroundColorLight#��[  5�      $ ��Enter the question here...��5�      5�      �� 5�      -   5         ��Name$ questionTextOutput��5�      $��Right=�5�      $
��Wrap=�5�      $#��Who is your favorite friend? ��5�      $��Medium"�5�      $��Calibri)�5�      $	��200��5�      $��10��5�      $��16(�5�      $	��Top=�5�      $y�	Collapsed=�5�      5�      5�      5�      5�      