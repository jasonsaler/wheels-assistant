   M S B A M L   `   `   `  ����N  JWheelsDataAssistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WheelsDataAssistantWheelsDataAssistant  5      "    WheelsDataAssistant.HomePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WheelsDataAssistant     5        N� Title$  HomePage��5
       "  AppPrimaryBackgroundColorLight N� 
Background# [  5      .��5      � .+�5   
   � $
��Left=�5      $��60��5      $��0,0,0,0q�5      $	��Top=�5       ! AppPrimaryBackgroundColorDark#��[ 5      ��5      �� *ActualWidth+ �� ElementName$ TopBarDesign��5      �� 5   
   -   5         ��Name$ TopBarDesign��5      $��Right=�5      $��60��5      $	��Top=�5      $
��auto��5      $'��!Resources/WaveBackgroundBlue2.png��5      $
��Fill=�5      � 5    
   -   5         �Name$ pageSpaceGrid��5!      $��Stretch=�5"      $��0,90,0,0q�5#      $��Stretch=�5$      $
��auto��5%      ��5&      �� *ActualWidth+$ TopBarDesign��.+�5(      �� $
��Auto=�6   .��5)      � .+�5+      �� -   5         ��Name$ openSpaceGrid��5,      $��80,80,510,80q�5-      $��Center=�5.      $	��450��5/      �� 51      -   5        $ openSpaceGrid2��52      $��610,80,80,80q�53      $��Center=�54      $	��450��55      56      57      58      � 5:   
   -   5        $ menuBar��5;      $
��Left=�5<      $��30��5=      $��0,60,0,0q�5>      $	��Top=�5?      #���  5@      ��5A      �� *ActualWidth+$ TopBarDesign��.+�5C      �� -   5         ��Name$ 
fileButton��5D        menuButtonStyle#��[ 5E      $
��File��5F      6    �� 5H      -   5        $ aboutButton��5I      #��[ 5J      $��About��5K      $��71,0,0,0q�6!   63   �� 5M      -   5        $ 
helpButton��5N      #��[ 5O      $
��Help��5P      $��	142,0,0,0q�6    63   o� 5S      -	   5         o�Name$ fileMenu��5T      $
��Left=�5U      $��96��5V      $��0,30,0,-100q�5W      $	��Top=�5X      $	��175��5Y      #���  5Z      $y�Hidden=�5[      .@�5]      �� -
   5         ��Name$ generateButton��5^        dropMenuButtonStyle#��[ 5_      $��Generate Summary Sheet��5`      $	��165��5a      6!   �� 5b      -   5        $ newQuestionaireButton��5c      #��[ 5d      $��New Questionaire��5e      $	��165��5f      6!   �� 5g      -   5        $ editQuestionaireButton��5h      #��[ 5i      $��Edit Questionaire��5j      $	��165��5k      � 5l      $	��100��6   $	��100��6$   5m      5o      �� 5q   
   -   5        $ 
LetuShield��5r      $
��Left=�5s      $��50��5t      $��15,5,0,0q�5u      $	��Top=�5v      $��50��5w      $#��Resources/LetuShieldSmall.png��5x      �� 5z   
   -   5        $ 
TitleLabel��5{   
     titleTextStyle#��[ 5|   
   $��Wheels Data Assistant��5}   
   $
��Left=�5~   
   $��70,5,0,0q�5   
   $	��Top=�5�   
   	 J� RenderTransformOrigin$	 -5.174,0.576&�5�   
   � 5�   
   -   5        $ 
aboutPanel��5�      $
��Left=�5�      $
��auto��5�      $��0,90,0,0q�5�      $��Stretch=�5�      $	��210��5�      #��[ 5�      $y�Hidden=�6I   .+�5�      �� -   5        $ 
aboutLabel��5�      $��Calibri)�5�      $��14(�5�        TextLightColor#��[ 5�      $%��Wheels Data Assistant V.1.0.1.2��5�      $��Center=�5�      $��	0,10,0,10q�5�      $	��Top=�5�      �� 5�      -   5        
 ��Name$
 aboutBox��5�      $��Center=�5�      $��10,35,10,10q�5�      $
��Wrap=�5�      $����The Wheels Data Assistant was developed by Collin Tompkins, Linah Alhaidari and Jason Saler.                 Developed for the LeTourneau University Wheels team under direction of Mrs. Rispin.                  09/30/2016��5�      $��Calibri)�5�      $��12(�5�      #��[ 5�      $	��Top=�5�      $	��480��5�      $	��170��5�      5�      � 5�   
   -   5        $&  generateSummaryNotificationToast��5�        notificationToastStyle#��[ 5�      $y�Hidden=�5�      .+�5�      �� -   5        $ 
toastLabel��5�        notificationToastLabelStyle#��[ 5�      $.��(Summary Sheet has generated successfully��5�      � 5�      -   5        $ CloseButtoBackground��5�      $��30��5�      $��30��5�      $��Right=�5�      $��Center=�5�      #��[ 5�      .+�5�      �� -   5        $ ToastCloseIcon��5�      $��30��5�      $��30��5�      $��Right=�5�      $��Center=�5�      $7��1pack://siteoforigin:,,,/Resources/CloseXTrans.png��5�      5�      5�      5�      5�      5�      