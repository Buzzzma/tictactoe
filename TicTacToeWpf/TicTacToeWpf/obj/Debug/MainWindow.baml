   M S B A M L   `   `   `  ����G  CTicTacToeWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TicTacToeWpfTicTacToeWpf  5   	       TicTacToeWpf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TicTacToeWpf     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��350��6,   $	��500��6;   $	��350��6H   .��5	      � -   5         �Name$
 grid��5	       � RowDefinitions 5
   
   �� 5      $	��150 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��btn00��5      $��0��6   $��1��6.   6;   �� 5   
   -   5        $��btn01��5      $��1��6   $��1��6.   6;   �� 5   
   -   5        $��btn02��5      $��2��6   $��1��6.   6;   �� 5   
   -   5        $��btn10��5      $��0��6   $��2��6.   6;   �� 5   
   -   5        $��btn11��5      $��1��6   $��2��6.   6;   �� 5   
   -   5        $��btn12��5      $��2��6   $��2��6.   6;   �� 5   
   -   5        $��btn20��5      $��0��6   $��3��6.   6;   �� 5   
   -	   5        $��btn21��5      $��1��6   $��3��6.   6;   �� 5    
   -
   5        $��btn22��5       $��2��6   $��3��6.   6;   �� 5"   
   $#��Крестики-нолики��6   $��22(�6+   $��3��69   $��Center=�6M   5#      5$      