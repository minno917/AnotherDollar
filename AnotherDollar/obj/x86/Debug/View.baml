   M S B A M L   `   `   `  ����H  DAnotherDollar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MPP.AnotherDollarMPP.AnotherDollar  5   	       MPP.AnotherDollar.View   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .ADclr-namespace:MPP.AnotherDollar     5   	   -   5        $��MainView��5   _     � Title$!  Another Day, Another Dollar��6	   $	��150��6-   $	��285��6:    � 	Resources 5      )  #MPP.AnotherDollar.DateTimeConverter   MyDateTimeConverter��%   &	          5   
   6   5      .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
   
   �� $	��120��6   .+�5      �� $��28��6   $��Today's Earnings:��6    �� 5      $��28��6   ��6    ��  �� Path$ TodaysEarnings��� 5      $��28��6   $��Day Completed:��6    �� 5      $��28��6   ��6!   �� $ PercentString�5      �� 5   
   .+�5   
   �� $ 
Horizontal=�6   .+�5      �� $��	Day's End��6   $��28��6(   $��Stretch=�64   $��Center=�6S   �� 5      -   5        $��28��5      $��Center=�6"   $��Center=�6?   $��80��6Z   ��6e   �� $ EndTime� �� 	Converter# [   �� Mode$ TwoWay=�6�   5      �� 5   
   $ 
Horizontal=�6   $��28��6.   .+�5      �� $
��Wage��6   $��0,0,20,0q�6#   $��28��65   �� 5      -   5        $��28��5      $��80��6"   ��6-   �� $
 Wage�$ TwoWay=�6U   5      �� 5      $ 
Horizontal=�6   $��28��62   .+�5      �� $��Hours��6   $��0,0,20,0q�6(   $��28��6:   �� 5      -   5        $��28��5      $��80��6&   ��61   �� $ HoursWorking�$ TwoWay=�6a   5      5      5      5      