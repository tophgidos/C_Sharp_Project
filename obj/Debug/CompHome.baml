   M S B A M L   `   `   `  ����D  @Employees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Employees	Employees  5          Employees.CompHome   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Employees     5        N� Title$  Employees - Home��5      .��5
      � $��
10,0,10,10q�6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��57* �6   $��40��6)   �� 5      $	��57* �6   $��30��6)   �� 5      $
��147* �6   �� 5      $
��Auto �6   .+�5   
   ��    WatermarkImage#��[  6   $��0��68   $	��156��6H   $��3��6U   $	��181��6f   $��1��6r   �� 5   
   $��1��6     headerTextStyle#��[ 6    $��35��6I   $��0,0,0,5q�6U   $��	Employees��6f   �� 5   
   -   5        $��EmployeeTypeRadioButtons��5      $��1��62   $��1��6B     HorizontalRadioList#��[ 6O   .@�5      ��   HorizontalRadio#��[ 6   $��0,5,0,0q�6C   $��50��6U   $	��All��6c   �� 5       #��[ 6   $��75��6D   $��Managers��6R   �� 5!      #��[ 6   $��50��6D   $��Sales��6R   �� 5"      #��[ 6   $��50��6D   $��Other��6R   5#      &   System.Windows.Controls.DataGrid  5&   
   -   5        $��dgEmps��5&      $��1��6!   $��2��61      AutoGenerateColumns .     CanUserAddRows .     HeadersVisibility$ Column=�5'         Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      MinWidth$ 45Q�6H   	   
IsReadOnly	 . 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+6V     5*      $ 
First Name��6%   $ 80Q�6W   	 . 
 69   �� *	FirstName+6e     5+      $ 	Last Name��6%   $ 80Q�6U   	 . 
 68   �� *
LastName+6c     5,      $
 Role��6%   $ 90Q�6L   	 . 
 63   �� *Role+6Z   5.      �� 51   
   -   5        $��1��51      $��3��6!     buttonStyle#��[ 6D   $
��Auto��6i   .��6w   	Details6�   52      53      