   M S B A M L   `   `   `  ����  CaptchaInWpf    CaptchaInWpf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  
MainWindow��5   	   $	��850��6   $	��800��6)    � 	Resources 5         productListTemplate �� Orientation��%�  &	        �� 5	   
   .R�5
      �� $ 
Horizontal=�6   $��1��62   $��3��6?   .+�5      �� 
������$	��256��6.   $��0��6:   6L   �� 5      $��1��6   $	��400��6-   $��Center=�69   .+�5      �� $��28(�6   .��5      �� $
��Wrap=�6A   ��6$   �� *ProductName+6W   5      �� 5      .��5      �� $
��Wrap=�6H   ��6$   �� *ProductDescription+6^   5      �� 5      .��5      �� $
��Wrap=�6G   ��6$   �� *Manufacturer.Name+6]   5      �� 5      .��5      �� $
��Wrap=�6A   ��6$   �� *ProductCost+6W   5      5      �� 5      $��2��6C   $	��100��6S   ��6   �� *ProductQuantityInStock+6a   5      5      5      .��5      � $y�Visible=�6!   ��6   Z�  � RowDefinitions 5   
   �� 5       $��50 �6   6*   �� 5!      $��* �6   6)   �� 5"      $	��100 �6   6,    � ColumnDefinitions 5$   
   �� 5%      $	��256 �6   6-   �� 5&      $��* �6   6+   �� 5'      $	��250 �6   6-   .+�5)   
   �� $��0��6   $��3��6"   .+�5*      �� -   5         ��Name$ Label_UserFio��5*      $��30��6+   .��67   !ФИО пользователя6I   �� 5+      -   5         ��Name$ 
ButtonExit��5+      .��6)   
Выход60   5,      �� 5-   
   $��2��6   .+�5.      �� $ 
Horizontal=�6   .+�5/      �� .��6   Добавить6#   �� 50      .��6   Удалить6"   51      �� 52      $ 
Horizontal=�6   .+�53      �� .��6   Сортировать по6)   �� 54      -   5         ��Name$ ComboBox_manufacturerSort��54       �� SelectedIndex$ 0��6>   $	��220��6P   	 �� DisplayMemberPath$
	 Name��6\   55      56      57      �� 58   
   -   5        
 ��Name$
 productList��58   3   $��3��6   $��1��6&   #��[  6H   $��Disabled=�59      ��5:      �� 5;      .R�5<      � 6"   5=      5?      5@      5A      