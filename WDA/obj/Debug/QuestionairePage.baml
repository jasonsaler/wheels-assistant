   M S B A M L   `   `   `  ����N  JWheelsDataAssistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WheelsDataAssistantWheelsDataAssistant  5      *    $WheelsDataAssistant.QuestionairePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WheelsDataAssistant     5        N� Title$  QuestionairePage��5	       "  AppPrimaryBackgroundColorLight N� 
Background# [  5
      .��5      � .+�5   
   � $
��Left=�5   
   $��60��5   
   $��0,0,-1400,0q�5      $	��Top=�5   
    ! AppPrimaryBackgroundColorDark#��[ 5   
   ��5   
   �� *ActualWidth+ �� ElementName$ TopBarDesign��5   
   �� 5   
   -   5         ��Name$ TopBarDesign��5   
   $��Right=�5   
   $��60��5   
   $	��Top=�5   
   $
��auto��6"   $'��!Resources/WaveBackgroundBlue2.png��5   
   $
��Fill=�5   
   �� 5   
   -   5        $ 
LetuShield��5   
   $
��Left=�5   
   $��50��5   
   $��15,5,0,0q�5    
   $	��Top=�5!   
   $��50��5"   
   $#��Resources/LetuShieldSmall.png��5#   
   �� 5%   
   -   5         ��Name$ TitleLabel_Copy��5&   
     titleTextStyle#��[ 5'   
   $��Wheels Data Assistant��5(   
   $
��Left=�5)   
   $��70,5,0,0q�5*   
   $	��Top=�5+   
    J� RenderTransformOrigin$ -5.174,0.576&�5,   
   � 51   
   -   5         �Name$ openSpaceGrid��52      $
��Left=�53      $
��auto��54      $��0,90,0,0q�55      $��Stretch=�56      ��57      �� *ActualWidth+$ TopBarDesign��.+�59      �� -   5         ��Name$ scrollingView��5:      $��Center=�5;      $
��auto��5<      $	��Top=�5=      $��0,0,0,0q�5?      ��5>      �� *ActualWidth+$ TopBarDesign��.��5A      � -   5        $ inScrollerGrid��5B      $
��auto��5C      $
��auto��5D      $��Stretch=�5E      $��Stretch=�5F      .+�5H      � -   5        $ pageShadowGrid��5I      $��Center=�5J      $
��auto��5K      $
��1100��5L      $��30,30,30,30q�5M      $	��Top=�5N      $
��auto��5O      $	��250��5P      
�������.+�5S      �� -   5         ��Name$ pageGrid��5T      $��Center=�5U      $
��auto��5V      $
��1100��5W      $��0,1,1,0q�5X      $��
16,0,16,50q�5Y      $	��Top=�5Z      $
��auto��5[      $	��250��5\      
�������
�������$��Disabled=�5_      $��Disabled=�5`      ��. .@�5c      �� -	   5        $ 	pageSizer��5d   !   $�� ��5e   !   $
��Left=�5f   !   $	��850��5g   !   $��0,45,0,0q�5h   !   $	��Top=�5i   !   � 5k      -
   5        $ descriptionGrid��5l   !   $
��Left=�5m   !   $
��auto��5n   !   $��
50,20,50,0q�5o   !   $	��Top=�5p   !   $
��auto��5q   !   .+�5s   "   �� -   5        	 ��Name$	 instructionslabel��5t   %   $��Instructions...��5u   %   $
��Left=�5v   %   $��	0,10,0,20q�5w   %   $
��Wrap=�5x   %   $	��950��5y   %   $��Center=�5z   %   $��16(�5{   %   $��Calibri)�5|   %   5}      5~      � 5�      -   5        $ 	titleGrid��5�      $��Center=�5�      $
��auto��5�      $��
50,60,50,0q�5�      $	��Top=�5�      $
��auto��5�      .+�5�      �� -   5        $ 
titlelabel��5�   !   $��Questionaire Title��5�   !   $��Center=�5�   !   $��0,0,0,0q�5�   !   $��Center=�5�   !   $��19(�5�   !   $��Calibri)�5�   !   5�      5�      5�      5�      5�      � 5�   
   -   5        $ menuBar��5�      $
��Left=�5�      $��30��5�      $��0,60,0,0q�5�      $	��Top=�5�      #���  5�      ��5�      �� *ActualWidth+$ TopBarDesign��.+�5�      �� -   5        
 ��Name$
 
saveButton��5�        menuButtonStyle#��[ 5�      $��Save Progress��5�      $��95��5�      6   �� 5�      -   5        $
 saveNewButton��5�      #��[ 5�      $��Save New As��5�      $��96,0,0,0q�6'   $��90��5�      6   �� 5�      -   5        $
 FinishButton��5�      #��[ 5�      $��Finish��5�      $��	187,0,0,0q�6"   65   �� 5�      -   5        $
 
helpButton��5�      #��[ 5�      $
��Help��5�      $��	258,0,0,0q�5�      $
��Auto��5�      $��Stretch=�5�      5�      �� 5�      -   5        $
 cancelButton��5�      #��[ 5�      $��Cancel��5�      $��Right=�5�      $��Bottom=�5�      $��0q�5�      5�      5�      5�      5�      