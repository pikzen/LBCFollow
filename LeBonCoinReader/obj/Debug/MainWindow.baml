   M S B A M L   `   `   `  ����J  FLeBonCoinReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LeBonCoinReaderLeBonCoinReader  5   	   D @LBCParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:LBCParser;assembly=LBCParser	LBCParser 5   	        LeBonCoinReader.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /localclr-namespace:LeBonCoinReader     5   	   :lbc*clr-namespace:LBCParser;assembly=LBCParser     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)   $	��600��65   $	��800��6E    � 	Resources 5        LBCParser.SearchQuery 	  query��%   &	          5   
   6*   5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��353* �6   �� 5      $
��439* �6   .+�5   
   � $	��100��6   $	��Top=�6   
���k���$��2��6K   .+�5      �� -   5         ��Name$
 logo��5      $
��Left=�6"   $	��100��6=   $	��200��6K   $	��Top=�6W     logo#���  6o   $��UniformToFill=�6�   �� 5      -   5         ��Name$ categorySelector��5       �� SelectedValuePath$ Value��61    �� DisplayMemberPath$	 Key��6K   $��0,5,1,0q�6c   $	��Top=�6t   $	��140��6�   $��22��6�   $��Right=�6�    �� SelectedIndex$ 0��6�   5      �� 5      -   5        $ regionSelector��5      $ Value��6/   $	 Key��6I   $��	0,5,145,0q�6a   $	��Top=�6t   $	��140��6�   $��22��6�   $��Right=�6�   $ 0��6�   5      �� 5      -   5         ��Name$ 	searchBox��5      $��22��6)   $
��Auto��65   $��200,5,290,0q�6B   	 �� TextWrapping$
	 Wrap=�6W   $��Search��6k   $	��Top=�6y   �� 5      -   5        
 ��Name$
 	searchBtn��5      $��
Rechercher��6(   $��Right=�6=   $��Bottom=�6Z   $��
0, 0, 1, 1q�6u   $��75��6�   6�   �� 5      -   5         ��Name$ 
inTitleOpt��5      $��In Title��6+   $
��Left=�6>   $��
200,27,0,0q�6Y   $	��Top=�6m   5      � 5   
   $
��Left=�6   $��
0,100,0,20q�6*   $	��215��6>   .+�5      �� -   5         ��Name$ adList��5      $��0q�6&   6:   5      � 5   
   $��215,100,0,20q�6   
�������$��2��6<   .+�5      #   LeBonCoinReader.PostPresenter  -	   5          Name$ postPresenter��5   "   5      �� 5   
   -
   5         ��Name$ 	statusBar��5      $��20��6(   $��0,0,0,0q�64   $��Bottom=�6E   $��2��6`   .@�5       �� $��Label��6   5!      5"      5#      