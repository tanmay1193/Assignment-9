   M S B A M L   `   `   `  ����B  >CarInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CarInfoCarInfo  5   	       CarInfo.MainWindow   5
      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CarInfo     5   	     � Title$  CarModelForm��5   	   $	��350��6   $	��525��6+    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5!   
   �� $<��6Car Model: Enter information and press create to begin��6   $��0��6Q   $��2��6^   $��Center=�6r   $��Center=�6�   6�   �� 5"   
   $��Enter Car Make:��6   $��Center=�6*   $��1��6G   $��0��6T   6f   �� 5#   
   $��1��6   $��1��6   $��Stretch=�6w   $��Center=�6�   $��10,10,10,10q�6�   ��6/   �� *Make+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5$   
   $��Enter Car Year:��6   $��Center=�6*   $��2��6G   $��0��6T   $��Center=�6d   6�   �� 5%   
   -   5        $��2��5%      $��1��6    �� 	MaxLength$ 4��6/   $��Stretch=�6�   $��Center=�6�   $��10,10,10,10q�6�   ��6=   �� *Year+$ TwoWay=�$ PropertyChanged=�6�   �� 5&   
   -   5        $#��Create/Update Car Information��5&      $��3��6N   $��2��6[   6q   �� 5'   
   $��Car Speed (km/h): ��6   $��Center=�6-   $��Center=�6J   $��4��6e   $��0��6r   6�   �� 5(   
   $��4��6\   $��1��6i   $��Stretch=�6y   $��Center=�6�   $��10,10,10,10q�6�   ��6   �� *Speed+$ TwoWay=�$ PropertyChanged=�6�   �� 5)   
   -   5        $��
Accelerate��5)      $��5��6<   $��0��6I   $��Stretch=�6Y   $��Stretch=�6w   6�   �� 5*   
   -   5        $��
Decelerate��5*      $��5��6<   $��1��6I   $��Stretch=�6Y   $��Stretch=�6w   6�   5+      5,      