   M S B A M L   `   `   `  ����B  >surface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:surfacesurface  5   	       surface.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:surface     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5	         OnSelect_Click��%   &	        �� 5
   
   6   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [  5      5      .��5      ]� .+�5   
   c� $	��Top=�6   .@�5      �� -   5        $��提交��5      6"   �� 5      $��筛选��6   #��[  6"   5      &   System.Windows.Controls.DataGrid  5      $	��Top=�6   $��	0,0,0,167q�6L   $	��200��6_   ��6,   �� *	Persons+6_   ]� 5   
   $��	0,-74,0,0q�6   .+�5      �� $��筛选范畴:��6   .��5      �� $	��Top=�6   ��6/   �� *SelectTarget+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5       $��提取结果��6   .��5!      ��  �� 
IsReadOnly .  �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6l   $ �� HorizontalScrollBarVisibility$
 Auto=�6�   "	 �� VerticalScrollBarVisibility$
	 Auto=�6�   ��6   �� *CollectedText+
 �� Mode$
 OneWay=�6�   5"      5$      5'      5*      