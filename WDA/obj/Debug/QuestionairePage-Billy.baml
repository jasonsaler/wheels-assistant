   M S B A M L   `   `   `  ����N  JWheelsDataAssistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WheelsDataAssistantWheelsDataAssistant  5      *    $WheelsDataAssistant.QuestionairePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WheelsDataAssistant     5        N� Title$  QuestionairePage��5	       "  AppPrimaryBackgroundColorLight N� 
Background# [  5
      .��5      � .+�5   
   � $
��Left=�5   
   $��60��5   
   $��0,0,-1400,0q�6   $	��Top=�5   
   $
��2000��5   
    ! AppPrimaryBackgroundColorDark#��[ 5   
   �� 5   
   -   5         ��Name$ TopBarDesign��5   
   $��Right=�5   
   $��60��5   
   $	��Top=�5   
   $
��auto��6"   $��WaveBackgroundBlue2.png��5   
   $
��Fill=�5   
   �� 5   
   -   5        $ 
LetuShield��5   
   $
��Left=�5   
   $��50��5   
   $��15,5,0,0q�5   
   $	��Top=�5    
   $��50��5!   
   $��LetuShieldSmall.png��5"   
   �� 5$   
   -   5         ��Name$ TitleLabel_Copy��5%   
     titleTextStyle#��[ 5&   
   $��Wheels Data Assistant��5'   
   $
��Left=�5(   
   $��70,5,0,0q�5)   
   $	��Top=�5*   
    J� RenderTransformOrigin$ -5.174,0.576&�5+   
   � 5-   
   -   5         �Name$ menuBar��5.      $
��Left=�5/      $��30��50      $��0,60,0,0q�51      $	��Top=�52      #���  53      $
��3000��54      .+�56      �� -   5         ��Name$ 
saveButton��57        menuButtonStyle#��[ 58      $��Save Progress��59      $��95��5:      �� 5<      -   5        $ saveNewButton��5=      #��[ 5>      $��Save New As��5?      $��96,0,0,0q�6'   $��90��5@      6   �� 5B      -   5        $ FinishButton��5C      #��[ 5D      $��Finish��5E      $��	187,0,0,0q�6"   �� 5G      -   5        $ 
helpButton��5H      #��[ 5I      $
��Help��5J      $��	258,0,0,0q�6    $
��Auto��63   $��Stretch=�6A   6]   5L      �� 5N   
   -	   5         ��Name$ 	scrollBar��5O      $��Right=�5P      $��0,90,0,0q�5Q      $��Stretch=�5R      $��17��5S      � 5U   
   $��Center=�5V      $
��1100��5W      $	��800��5X      $	��Top=�5Y      $��	0,110,0,0q�5Z        TextLightColor#��[ 5[      .+�5]      �� -
   5        $ PageTitleLabel��5^      #��[ 5_      $��WCQ-C Questionaire��5`      $��Center=�5a      $��0,20,0,0q�5b      $	��Top=�5c        TextDarkColor#��[ 5d      $ -5.174,0.576&�5e      �� 5g      -   5        $ PageSubTitle��5h        headerTextStyle#��[ 5i      $3��-Answer all teh questions as best as possible.��5j      $��Center=�5k      $��0,58,0,0q�5l      $	��Top=�5m      �� 5n      -   5        $ 	NameLabel��5o      #��[ 5p      $��Name:��5q      $
��Left=�5r      $��40,105,319,0q�5s      $	��Top=�5t      �� 5v      -   5         ��Name$ 	NameInput��5w      #��[ 5x      $
��Left=�5y      $��23��5z      $��105,110,0,0q�5{      	 �� TextWrapping$
	 Wrap=�5|      $�� ��5}      $	��Top=�5~      $	��250��5      �� 5�      -   5        $ DOBLabel��5�      #��[ 5�      $��Date of Birth:��5�      $
��Left=�5�      $��390,105,0,0q�5�      $	��Top=�5�      �� 5�      -   5        $ DOBInput��5�      #��[ 5�      $
��Left=�5�      $��23��5�      $��500,110,0,0q�5�      $
	 Wrap=�5�      $�� ��5�      $	��Top=�5�      $	��250��5�      �� 5�      -   5        $ ExampleQuestion��5�      $��Center=�5�      $	��165��5�      $��100,150,100,0q�5�      $	��Top=�5�      $	��600��5�      $��Example question.PNG��5�      $��UniformToFill=�5�      �� 5�      -   5        
 ��Name$
 slider��5�      $��Center=�5�      $��	0,335,0,0q�5�      $	��Top=�5�      $	��600��5�      5�      5�      5�      