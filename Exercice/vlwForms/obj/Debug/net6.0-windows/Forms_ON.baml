   M S B A M L   `   `   `  ����J  FExercice Cours4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Cours04Cours04  5   	       Cours04.FormsWindow_ON   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Cours04     5   	     � Title$  Forms Window��5   	   $	��525��6   $	��500��6+   $��28(�67   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��130 �6   6-   �� 5      $��40 �6   6,   �� 5      6!    � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��60 �6   6*   �� 5      $��30 �6   6*   .+�5#   
   �� $��3��6    �� TextAlignment$ Center=�6(   $��20(�6?   $
��Bold"�6M   
�������$��40��6r   
���   �CREATE NEW USER6�   �� 5%   
   -   5         ��Name$ xPrefixText��5%      $��Center=�6)   $ Right=�6D   $��1��6Z   $
��Bold"�6g   $��14(�6y   Prefix6�   �� 5&   
   $��Center=�6   $��1��6.   $��2��6;   .+�5'      	� -   5         	�Name$ 	xMrPrefix��5'      $��0 0 10 0q�6-   $��13(�6@   .��6N   Mr6R   	� 5(      -   5        $ 
xMrsPrefix��5(      $��13(�6.   .��6<   Mrs6A   5)      �� 5+   
   -   5        $ xFirstNameText��5+      $��Center=�6,   $ Right=�6G   $��2��6]   $
��Bold"�6j   $��14(�6|   
First Name6�   �� 5,   
   -   5         ��Name$ 
xFirstName��5,      $��14(�6&   $
��Left=�64   $��2��6O   $��2��6\   $	��280��6l   $��20��6x   6�   �� 5.   
   -   5        $ xLastNameText��5.      $��Center=�6+   $ Right=�6F   $��3��6\   $
��Bold"�6i   $��14(�6{   	Last Name6�   �� 5/   
   -   5        $ 	xLastName��5/      $��14(�6%   $
��Left=�63   $��3��6O   $��2��6\   $	��280��6l   $��20��6x   6�   �� 51   
   -   5        $ xAddressText��51      $��Center=�6*   $��4��6E   $ Right=�6R   $��14(�6h   
Addresse6�   �� 52   
   -	   5        $ xAddress��52      $��14(�6$   $
��Left=�62   $��4��6M   $��3��6Z   $	��280��6j   $��20��6v   6�   �� 54   
   -
   5        $ xPostalCodeText��54      $��Center=�6-   $��5��6H   $ Right=�6U   $
��Bold"�6k   $��14(�6}   Postal Code6�   �� 55   
   -   5        $ xPostalCode��55      $��14(�6'   $
��Left=�65   $��5��6P   $��3��6]   $	��280��6m   $��20��6y   6�   �� 57   
   $��Center=�6   $��6��6/   $ Right=�6<   $��14(�6R   
Province6j   �� 58   
   -   5         ��Name$ 	xProvince��58      $
��Left=�6&   $��13(�6A   $��6��6O   $��3��6\   $	��280��6l   $��20��6x    �� Text$ Select a province��6�   $|�False��6�   	 �� 
IsEditable$
	 True��6�   
 �� 
IsReadOnly$

 True��6�   .@�59      �� .��6   QC6   �� 5:      .��6   ON6   �� 5;      .��6   BC6   5<      �� 5>   
   $��Center=�6   $��7��6/   $ Right=�6<   $��14(�6R   Date of Birth6o   �� 5?   
   -   5        $ xDateOfBirth��5?      $
��Left=�6)   $��13(�6D   $��7��6R   $��3��6_   $	��280��6o   $��20��6{   $ Select a date��6�   $|�False��6�   $
	 True��6�   $

 True��6�   .@�5@      (  "System.Windows.Controls.DatePicker     SelectedDateFormat$ Short=�6   5A      �� 5C   
   -   5        $ xUserNameText��5C      $��8��6+   $ Right=�68   $
��Bold"�6N   $��14(�6`   
Username6x   �� 5D   
   -   5        $ 	xUserName��5D      $��14(�6%   $
��Left=�63   $��8��6N   $��3��6[   $	��280��6k   $��20��6w   6�   �� 5F   
   -   5        $ xPasswordText��5F      $��Center=�6+   $��9��6F   $ Right=�6S   $
��Bold"�6i   $��14(�6{   
Password6�   G� 5G   
   -   5         G�Name$ 	xPassword��5G      $��14(�6)   $
��Left=�67   $��9��6R   $��3��6_   $	��280��6o   $��20��6{   6�   �� 5I   
   -   5        $ xConfimPasswordText��5I      $��Center=�61   $��10��6L   $ Right=�6Z   $
��Bold"�6p   $��14(�6�   Confirm Password6�   G� 5J   
   -   5        $ xConfimPassword��5J      $��14(�6/   $
��Left=�6=   $��10��6X   $��3��6f   $	��280��6v   $��20��6�   6�   �� 5L   
   -   5        $ 
xTermsText��5L      $��Center=�6(   $��11��6C   $ Right=�6Q   $
��Bold"�6g   $��14(�6y   I agree to terms6�   �� 5M   
   -   5         ��Name$ xTerms��5M      $��Center=�6#   $��11��6>   $��3��6L   6^   �� 5O   
   -   5        $ xSubscribeText��5O      $��Center=�6,   $��12��6G   $ Right=�6U   $��13(�6k   
Newsletter6�   �� 5P   
   -   5         ��Name$ 
xSubscribe��5P      $��12(�6%   $
��Left=�63   $��12��6N   $��3��6\   $��75��6l   $��20��6w   .��6�   	Subscribe6�   �� 5R   
   $��Center=�6   $��13��6.   $��2��6<   $��Center=�6L   .+�5S      �� -   5        $��15(�5S      
�������
���   �$��75��6I   $��25��6T   .��6o   Submit6w   �� 5T      -   5        $��15(�5T      
���   �
�������$��75��6I   $��25��6T   .��6n   Clear6u   5U      �� 5W   
   $��14��6   $��2��6"   $��14(�62   $ Center=�6@   $��Italic$�6W   $��User : 0��6j   6|   5Y      5Z      