   M S B A M L   `   `   `  ����N  JEnvironmentsManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:EnvironmentsManager.stylesEnvironmentsManager.styles  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType $   ComboBoxDarkToggleButtonTemplate � ColumnDefinitions �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value  ComboBoxDarkFlatStyle	 �� 
TargetType  applicationFontFamily
 �� 	ClickMode d� 	IsChecked �� Path �� RelativeSource �� Mode J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate �� 
IsReadOnly �� 
IsReadOnly � AllowsTransparency �� IsDropDownOpen J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      2local(clr-namespace:EnvironmentsManager.styles  5      %�  &	        &	 �    7   �� 5      "  d�6   .R�5   
   �  5      �� 5      �� 5	      $��20 �6#   .+�5      �� $��Border��5      $��2��5      
������ $ 0��5      $��
1, 1, 1, 1q�5      ���#2525255      �� 5      $��ButtonBorder��5      $��1��5      $��
1, 1, 1, 1q�5      ���#444$ 
0, 0, 0, 0��5      $��
0, 0, 0, 0q�5      ���#2525255      F� 5      $��Arrow��5      $��1��5      =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	$��Center=�5      ���#444$��Center=�5       $��	-10,0,0,0q�5!      5"       5#   
   P� 5$       �@J�IsMouseOver . . �5%      �� $ ButtonBorder��65    � ��
 ���� 6O   �� 5&      $ Border��65    � �� �#3535356I   �� 5'      $ Arrow��6/    � ��
 �����6B   5(      P� 5)       �@J�IsMouseOver .  . �5*      �� $ Arrow��6/    � ��
 �iii�6B   5+      P� 5,       �@d�	IsChecked$
 TrueY�68   . �5-      �� $ ButtonBorder��65    � ��
 ���� 6O   �� 5.      $ Arrow��6/    � ��
 ���� 6B   5/      P� 50       � {� .  . �51      �� $ Border��65    � ��
 �iii�6I   �� 52      $ ButtonBorder��65    � ��
 �iii�6O   �� 53      $ ButtonBorder��67    � ��
 �iii�6Q   �� 54       � ��
 �����6;   �� 55      $ Arrow��6/    � ��
 ���� 6B   56      58      �� 5:      "	 ��6*   .�5;   
   ��  �@J�SnapsToDevicePixels . 6:   �� 5<   
    �@�OverridesDefaultStyle . 6C   �� 5=   
    � ��$
 Auto=�6G   �� 5>   
    � ��$
 Auto=�6E   �� 5?   
    � �� . 6:   �� 5@   
    � ��
 �����63   �� 5A   
    �@�FocusVisualStyle 6>   Z� �� 5B   
    � ��# �  6'   �� 5C   
    � �� 5D      �� 5E      "  ��6"   .R�5F      � .+�5G      d� $��ToggleButton��6'   $��2��5H      $
 Press=�5I      |�.  8��   5K      �� $ IsDropDownOpen� �� *TemplatedParent+$ TwoWay=�5L      �� 5M      $��ContentSite��6+   #��z��5N       .  $
��Left=�5P      $��Center=�5Q      #��z 5R      #��z 5S      #��z��5T      �� 5U      $��PART_EditableTextBox��6"   $��3, 3, 23, 3q�5V   
   # z 5W   
   $y�Hidden=�5X   
   
������ $��Center=�5Z   
   $��Center=�5[   "   $��Center=�5\   
   |�. .��5]      ��5^      �� 5_   "   "  ��62   .R�5`   &   �� $��PART_ContentHost��6-   |�.  6E   5a   #   .��5b   0   5c      � 5e      $��Popup��6    $��Bottom=�5f      |�.   . #��z 5i      $
��Fade=�5j      .��5k      � $��DropDown��6#    . #��z 5m      #��z 5n      .+�5o   "   �� $��DropDownBorder��6)   
�������$��
0, 0, 0, 0q�5q      $ 0��5r      ���	#FF103766$��1q�5t      �� 5u   "   $��4q�6/    . .��5v   &   �� $ 	Contained=�65   5w   #   5x      5y      5z       5{      P� 5|       �@J�IsMouseOver . . �5}      ��  � ��
 �����6G   5~      P� 5       �@J�IsMouseOver .  . �5�      ��  � ��
 �����6G   5�      P� 5�       �@��HasItems .  . �5�      �� $ DropDownBorder��6K    � ��$ 95��6g   5�      P� 5�       � {� .  . �5�      ��  � ��
 �����6G   5�      P� 5�       �@��
IsGrouping . . �5�      ��  � �� .  6N   5�      P� 5�       �@��
IsEditable . . �5�      ��  �@  	IsTabStop .  6M   �� 5�      $ PART_EditableTextBox��6E    � y�$ Visible=�6g   �� 5�      $ ContentSite��6E    � y�$ Hidden=�6^   5�      P� 5�       �@��IsDropDownOpen . . �5�      ��  � ��
 �����6G   5�      5�      5�      5�      5�      