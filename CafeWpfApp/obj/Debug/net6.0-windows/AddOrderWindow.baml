   M S B A M L   `   `   `  ����E  ACafeWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CafeWpfApp
CafeWpfApp  5   	       CafeWpfApp.AddOrderWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CafeWpfApp     5   	     � Title$'  !Добавление заказа��5   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�6<   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��BackBtn��5      $	��100��5      $��30��5      $��
Назад��5      $��	10 0 10 0q�5      �� 5      -   5        $��AddOrderBtn��5      $	��100��5      $��30��5      $��Добавить��5      5      5      &   System.Windows.Controls.DataGrid  5!   
   -   5        $��DishesDGrid��5#      $��1��5!      $��10q�5"         AutoGenerateColumns$ False��5$         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5%         CanUserAddRows$ False��5&         
IsReadOnly$
 True��5'      	   Columns	 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+5,        5.   
   -   5        $��DishesInOrderDGrid��51      $��1��5.      $��1��5/      $��10q�50      $ False��52      $
 True��53      $ False��54      	 55        56      $
 Название��6%      Width$ * 6P    67   �� *Name+6P     57      $
 Кол-во��6%   $ 50 6O    65   �� *Count+6O   59      5:      5;      