   M S B A M L   `   `   `  ����N  JWheelsDataAssistant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WheelsDataAssistantWheelsDataAssistant  5      "    WheelsDataAssistant.HomePage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WheelsDataAssistant     5        N� Title$  HomePage��5
       "  AppPrimaryBackgroundColorLight N� 
Background# [  5      .��5      � .+�5   
   � $
��Left=�5      $��80��5      $��0,0,0,0q�6   $	��Top=�5      $
��2000��5       ! AppPrimaryBackgroundColorDark#��[ 5      �� 5   
   -   5         ��Name$ label��5      $��Label��5      $
��Left=�5      $��172,144,0,0q�5      $	��Top=�5        TextLightColor#��[ 5      �� 5   
   -   5         ��Name$ yopBarDesign��5      $
��Left=�5       $��80��5!      $��0,0,0,0q�6   $	��Top=�5"      $
��1920��6%   $��WaveBackgroundBlue2.png��5#      $
��Fill=�5$      � 5&   
   $
��Left=�5'      $
��1200��5(      $��0,80,0,0q�5)      $	��Top=�5*      $	��300��5+       $  AppSecondaryBackgroundColorLight#��[ 5,      .+�5.      �� -   5        $ favoritesLabel��5/      $��	favorites��50      $
��Left=�51      $��	20,10,0,0q�52      $	��Top=�53       J� RenderTransformOrigin$ -5.174,0.576&�54      56      �� 58   
   -   5         ��Name$ favoritesItemsListView��59      $
��Left=�5:      $	��120��5;      $��
20,120,0,0q�6   $	��Top=�5<      $	��260��5=      $��0q�5>      #��[ 5?      5@      � 5B   
   -   5         �Name$ questionaireGrid��5C      $
��Left=�5D      $	��100��5E      $��480,125,0,0q�5F      $	��Top=�5G      $	��100��5H      �� 5J   
   -   5         ��Name$ 
lstButtons��5J      $��0��5K      $��
300,80,0,0q�6   ��5L      �� 5M      .R�5N      A�  A� Columns$ 4��6"   	 A� Rows$	 4��5O      5P      ��5R      �� 5S      .R�5T      �� -   5        5T      5V      5X      5]      5^      