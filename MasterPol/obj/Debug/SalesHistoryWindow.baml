   M S B A M L   `   `   `  ����D  @MasterPol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MasterPol	MasterPol  5   	   "    MasterPol.SalesHistoryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MasterPol     5   	     � Title$!  История продаж��5   	   $	��450��6    $	��800��6-    � Icon$ icon.png��5	   	   .��5
      � $��10q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��SalesHistoryDataGrid��5         AutoGenerateColumns .     
IsReadOnly .    RowBackground
 �����   AlternatingRowBackground �#E8EEF5   GridLinesVisibility$
 None=�5   L   $   HorizontalScrollBarVisibility$
 Auto=�5      "   VerticalScrollBarVisibility$
 Auto=�68   ���#D3D8E0$��1q�6q   	   SelectionMode$	 Single=�5      
   SelectionUnit$
 FullRow=�6*      CanUserAddRows .   � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow��%�  '        '  �     �� 5      "  6   .�5      ��  � �� �#67BA8063   �� 5       � ��
 �����63   �� 5       � ��$
 Bold"�63   �� 5       � ��$ Center=�6C   �� 5       � ��$
 10,5q�60   5      �� 5      "  6   .�5      ��  � ��$ 14(�61   �� 5       � ��$ 30��6/   �� 5       � ��$ 2q�6/   5      5          Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ ID продажи��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *SaleID+6T     5$      $ ID партнера��6%   $ * 6X    6:   �� *	PartnerID+6X     5%      $ ID продукта��6%   $ * 6X    6:   �� *	ProductID+6X     5&      $ Дата продажи��6%   $ * 6h    6;   �� *
SaleDate+ �� StringFormat$ d��6h     5'      $ Количество��6%   $ * 6V    69   �� *
Quantity+6V     5(      $ Сумма продажи��6%   $ * 6k    6<   �� *
SaleAmount+$ C��6k   5*      5+      5,      