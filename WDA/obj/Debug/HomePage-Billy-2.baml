   M S B A M L   `   `   `  ����N  JWheelsDataAssistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WheelsDataAssistantWheelsDataAssistant  5      "    WheelsDataAssistant.HomePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WheelsDataAssistant     5        N� Title$  HomePage��5
       "  AppPrimaryBackgroundColorLight N� 
Background# [  5      .��5      � .+�5   
   � $
��Left=�5      $��60��5      $��0,0,0,0q�5      $	��Top=�5       ! AppPrimaryBackgroundColorDark#��[ 5      ��5      �� *ActualWidth+ �� ElementName$ TopBarDesign��5      �� 5   
   -   5         ��Name$ TopBarDesign��5      $��Right=�5      $��60��5      $	��Top=�5      $
��auto��5      $��WaveBackgroundBlue2.png��5      $
��Fill=�5      � 5    
   -   5         �Name$ menuBar��5!      $
��Left=�5"      $��30��5#      $��0,60,0,0q�5$      $	��Top=�5%      #���  5&      ��5'      �� *ActualWidth+$ TopBarDesign��.+�5)      �� -   5         ��Name$ 
fileButton��5*        menuButtonStyle#��[ 5+      $
��File��5,      6    �� 5.      -   5        $ aboutButton��5/      #��[ 50      $��About��51      $��71,0,0,0q�6!   63   �� 53      -   5        $ 
helpButton��54      #��[ 55      $
��Help��56      $��	142,0,0,0q�6    63   o� 59      -   5         o�Name$ fileMenu��5:      $
��Left=�5;      $��96��5<      $��0,30,0,-100q�5=      $	��Top=�5>      $	��175��5?      #���  5@      $y�Hidden=�5A      .@�5C      �� -   5         ��Name$ generateButton��5D        dropMenuButtonStyle#��[ 5E      $��Generate Summary Sheet��5F      $	��165��5G      6!   �� 5H      -   5        $ newQuestionaireButton��5I      #��[ 5J      $��New Questionaire��5K      $	��165��5L      6!   �� 5M      -	   5        $ editQuestionaireButton��5N      #��[ 5O      $��Edit Questionaire��5P      $	��165��5Q      � 5R      $	��100��6   $	��100��6$   5S      5U      � 5W   
   -
   5        $ questionaireGrid��5X      $
��Left=�5Y      $	��100��5Z      $��480,125,0,0q�5[      $	��Top=�5\      $	��100��5]      �� 5_   
   -   5        $ 
LetuShield��5`      $
��Left=�5a      $��50��5b      $��15,5,0,0q�5c      $	��Top=�5d      $��50��5e      $��LetuShieldSmall.png��5f      �� 5h   
   -   5        $ 
TitleLabel��5i   
     titleTextStyle#��[ 5j   
   $��Wheels Data Assistant��5k   
   $
��Left=�5l   
   $��70,5,0,0q�5m   
   $	��Top=�5n   
    J� RenderTransformOrigin$ -5.174,0.576&�5o   
   � 5q   
   -   5        $ 
aboutPanel��5r      $
��Left=�5s      $
��auto��5t      $��0,90,0,0q�5u      $��Stretch=�5v      $	��210��5w      #��[ 5x      $y�Hidden=�6I   .+�5z      �� -   5        $ 
aboutLabel��5{      $��Calibri)�5|      $��14(�5}        TextLightColor#��[ 5~      $%��Wheels Data Assistant V.1.0.1.2��5      $��Center=�5�      $��	0,10,0,10q�5�      $	��Top=�5�      �� 5�      -   5        	 ��Name$	 aboutBox��5�      $��Center=�5�      $��10,35,10,10q�5�      $
��Wrap=�5�      $����The Wheels Data Assistant was developed by Collin Tompkins, Linah Alhaidari and Jason Saler.                 Developed for the LeTourneau University Wheels team under direction of Mrs. Rispin.                  09/30/2016��5�      $��Calibri)�5�      $��12(�5�      #��[ 5�      $	��Top=�5�      $	��480��5�      $	��170��5�      5�      � 5�   
   -   5        $&  generateSummaryNotificationToast��5�        notificationToastStyle#��[ 5�      $y�Hidden=�5�      .+�5�      �� -   5        $ 
toastLabel��5�        notificationToastLabelStyle#��[ 5�      $.��(Summary Sheet has generated successfully��5�      � 5�      -   5        $ CloseButtoBackground��5�      $��30��5�      $��30��5�      $��Right=�5�      $��Center=�5�      #��[ 5�      .+�5�      �� -   5        $ ToastCloseIcon��5�      $��30��5�      $��30��5�      $��Right=�5�      $��Center=�5�      $��CloseXTrans.png��5�      5�      5�      5�      � 5�   
   -   5        $ openSpaceGrid��5�      $
��Left=�5�      $��0,90,0,0q�5�      $��stretch=�5�      $
��auto��5�      ��5�      �� *ActualWidth+$ TopBarDesign��5�      5�      