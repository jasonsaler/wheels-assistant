   M S B A M L   `   `   `  ����N  JWheelsDataAssistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WheelsDataAssistantWheelsDataAssistant  5      -    'WheelsDataAssistant.RatingScaleQuestion   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WheelsDataAssistant     5      -   5          >�Name$  RatingScaleQuestionBox��5      $
��auto��5	      $��50,10,50,10q�5
      $
��auto��5      $��Stretch=�5      .��5      � $
��auto��5   	   $	��Top=�5   	   $
��auto��5   	   $��Stretch=�5   	   .+�5   
   � $
��auto��5      $��Stretch=�5      $
��auto��5      $
��Left=�5      .+�5      �� -   5         ��Name$ questionNumber��5      $��Stretch=�5      $��0,0,0,0q�5      $��1��5      $	��Top=�5      $��Calibri)�5       $��16(�5!      $
��Bold"�5"      
���   �
������ $
��auto��5%       � ToolTip$' !Change the number to change order��5&       �� MaxLines$ 1��5'       �� 	MaxLength$ 4��5(       �� IsUndoEnabled .  4  .System.Windows.Automation.AutomationProperties   HelpText$0 *Change the question number to change order��5)   '   � 5+      -   5         �Name$ deletIconBackground��5,      $��25��5-      $	��Top=�5.      $��0,70,0,0q�5/      $��25��50      $
��Left=�51      .+�53      �� -   5         ��Name$ 	deletIcon��54      $
��Left=�55      $��25��56      $��25��57      $	��Top=�58      $��Resources/CloseXBlack.png��59      $ Delete this question��5=      5>      �� 5@      -   5        	 ��Name$	 
naCheckbox��5A      $	��N/A��5B      $
��Left=�5C      $��0,37,0,0q�5D      $	��Top=�5E      $3 -Select to allow a N/A option on this question��5F      5H      5I      � 5K   
   $
��auto��5L      $��Stretch=�5M      $
��auto��5N      $
��Left=�5O      $��50,0,0,0q�5P      .+�5R      � $
��auto��5S      $��Stretch=�5T      $
��auto��5U      $��Stretch=�5V      $��	0,0,0,110q�5W      .+�5Y      �� -   5        
 ��Name$
 Question��5Z      $��Stretch=�5[      $��0,0,0,0q�5\      $
��Wrap=�5]      $��This is the Question?��5^      $	��Top=�5_      $��Calibri)�5`      $	��800��5a      $
��auto��5b      $��16(�5c      
���   �$y�Hidden=�5e      $��Medium"�5f      �� 5h      -   5        $ newQuestion��5i      $��Stretch=�5j      $��0,0,0,0q�5k       �� TextWrapping$
 Wrap=�5l      $	��Top=�5m      $��Calibri)�5n      $��16(�5o      $
��auto��5p       �� 
AcceptsTab .  �� AcceptsReturn .  �� 	IsEnabled . $ Enter the question��5t       "  AppPrimaryBackgroundColorLight#��[  5u      $ ��Enter the question here...��5v      $	��800��5w      5y      5z      � 5|      $
��auto��5}      $��Bottom=�5~      $
��auto��5      $��Stretch=�5�      $��
30,0,30,60q�5�       � ColumnDefinitions 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5        $
 	textBlock��5�      $��Center=�5�      $��1��5�      $��0��5�      $��0,0,0,0q�5�      $
��Wrap=�5�      $	��E/F��5�      $	��Top=�5�      �� 5�      -	   5        $
 
textBlock1��5�      $��1��5�      $��1��5�      $��Center=�5�      $��0,0,0,0q�5�      $
��Wrap=�5�      $��D��5�      $	��Top=�5�      �� 5�      -
   5        $
 
textBlock2��5�      $��1��5�      $��2��5�      $��Center=�5�      $��0,0,0,0q�5�      $
��Wrap=�5�      $��C��5�      $	��Top=�5�      �� 5�      -   5        $
 
textBlock3��5�      $��1��5�      $��3��5�      $��Center=�5�      $��0,0,0,0q�5�      $
��Wrap=�5�      $��B��5�      $	��Top=�5�      �� 5�      -   5        $
 
textBlock4��5�      $��1��5�      $��4��5�      $��Center=�5�      $��0,0,0,0q�5�      $
��Wrap=�5�      $��A��5�      $	��Top=�5�      5�      � 5�      $
��auto��5�      $��Bottom=�5�      $
��auto��5�      $��Stretch=�5�      $��	0,10,0,80q�5�       5�      �� 5�      $
��113* �6'   �� 5�      $
��147* �6'   .+�5�      �� -   5         ��Name$ RatingSlider��5�      $��Stretch=�5�      $	��Top=�5�      $	��200��5�      $
��auto��5�      $��
30,25,30,0q�5�       # AppSecondaryBackgroundColorDark#��[ 5�      $@ :Slide to give a rating from A(Excellent) to E/F(very poor)��6S   $��2��6�   �� 5�      -   5        $ sadImage��5�      $
��Left=�5�      $��20��5�      $��20��5�      $��0,25,0,0q�5�      $	��Top=�5�      $ ��Resources/sadFaceSmall.png��5�      �� 5�      -   5        $ 
happyImage��5�      $��Right=�5�      $��20��5�      $��20��5�      $��0,25,0,0q�5�      $	��Top=�5�      $"��Resources/happyFaceSmall.png��5�      $��1��6;   5�      � 5�      -   5        $ commentGrid��5�      $
��auto��5�      $��Bottom=�5�      $
��auto��5�      $��Stretch=�5�      $��0,0,0,0q�5�      .+�5�      �� -   5        $
 commentTitle��5�      $��Stretch=�5�      $��0,0,0,0q�5�      $
��Wrap=�5�      $��
Comments: ��5�      $	��Top=�5�      $��Calibri)�5�      $
��auto��5�      $��16(�5�      
���   �5�      �� 5�      -   5        $ userCommentBox��5�      $��Stretch=�5�      $��0,20,0,0q�5�      $��Comments go here...��5�       �� 
IsReadOnly . 
�������$��Bottom=�5�      $��Calibri)�5�      $��16(�5      
���   �$
��auto��5      .  .  . $ 2��5     $ WrapWithOverflow=�5      �� MinLines$ 2��5     $0 *Enter any additional comments as necessary��5	     5     5     5     5     5     