   M S B A M L   `   `   `  ????L  HCurrencyInspector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CurrencyInspector.ViewModelsCurrencyInspector.ViewModels  5      *    $CurrencyInspector.Views.MainPageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      8local*clr-namespace:CurrencyInspector.ViewModels   5      
???????$??1??5
      $??60, 20, 20, 20q?6   .??5   
   ?   ? RowDefinitions  5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $??* ?6   ?? 5      $
??auto ?6   .+?5   
   ? $	??300??6   $
??Left=?6   .+?5      ?? -   5         ??Name$ textBlockSearch??5      $
??20 0q?61   $??Center=?6?   
??????? J? IsHitTestVisible$
 True??5       K? ZIndex$ 1??60   $??Search by name...??6A   $y?Visible=?5      ?? 5      -   5         ??Name$ 
textSearch??5         textBoxSearch#??[  6*   5   ;   .  (MahApps.Metro.IconPacks.PackIconMaterial  5          Kind$ Magnify=?6$   $??15??63   $??15??6>   $??Center=?5!   $   $??0,0,15,0q?6?   
???????$??Right=?5"   6   5#      ?? 5%   
   $??Assets??6   $??1??6"   $??32(?6/   $??SemiBold"?6=   $??15, 20, 0, 0q?5&      $
??Left=?6*   ???#1215186E   &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ assetsDataGrid??50         DataGridStyle1#???  5(        DataGridCellStyle1   	CellStyle# ?  5)        DataGridColumnHeaderStyle1   ColumnHeaderStyle# ?  5*        DataGridRowStyle1	   RowStyle#	 ?  5+      
   AutoGenerateColumns$
 False??5-         CanUserAddRows$ False??5.      $??5??50         CanUserReorderColumns$ False??68   ??5,      ?? *AssetsSimple+ ?? SelectedItem 5/      ?? *SelectedAsset+ ?? Mode$ TwoWay=?   Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6E      
IsReadOnly$
 True??6Q      CanUserResize$ False??6c      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ??  ?? Path$ ID?6y     53      $
 Name??6G   $
 True??6U   $ False??6g   $ * 6}    6)   ?? $
 Name?6}     54      $ Price??6H   $
 True??6W   $ False??6i   $
 auto 6    6)   ?? $ Price?6   4  .System.Windows.Controls.DataGridTemplateColumn  55         CellTemplate 56      ?? 57      .R?58      ??  ??Name$ ShowDetails??6%   -   5          gridDetailsButton#??[ 59   %   .??5:   &     $ DotsHorizontalCircle=?6<     gridButtonIcon#??[ 5;   <   5<   #   5=      5?      5A      ?? 5C   
   $??8??6   $??Right=?6   ???#dee4ec$??1q?6P    ?? CornerRadius$ 5??5D       ?? Padding$ 5q?6"   
???????$??0, 10, 10, 10q?6A   ._?5E      ??  ?? Orientation$ 
Horizontal=?6   .+?5F      ??   pagingButton#??[ 6   .??5G        $ ChevronLeft=?6,     pagingButtonIcon#??[ 6?   5H      ?? 5I      $??1??6   ???#dee4ec$
??3, 7q?65   ?? 5J      #??[ 6   .??5K        $ ChevronRight=?6,   #??[ 6@   5L      5M      5N      5O      5P      