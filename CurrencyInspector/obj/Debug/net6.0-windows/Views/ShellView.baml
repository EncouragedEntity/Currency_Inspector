   M S B A M L   `   `   `  ????L  HCurrencyInspector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CurrencyInspector.ViewsCurrencyInspector.Views  5   	   '    !CurrencyInspector.Views.ShellView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   6controls%clr-namespace:CurrencyInspector.Views   5   	   $	??720??5   	   $
??1080??6     ? WindowStartupLocation$  CenterScreen=?5   	    ? AllowsTransparency$
 True??6.    ? WindowStyle$
 None=?5   	   
?????? .??5
   
   ?? -   5        
??????? ?? CornerRadius$ 30??5      ._?5   
   ? -   5         ?Name$ MainGrid??5       ? ColumnDefinitions 5      ?? 5      $	??200 ?6#   ?? 5      $??* ?6#   .+?5      ? $??0??6    ? RowDefinitions 5      ?? 5      $
??auto ?6$   ?? 5      $??* ?6$   .+?5      ?? $??1??6   
???? ??$ 	0 50 0 30??6>   ._?5      ]? .+?5      ?? $??70??6!   $??70??6,    ?? Padding$ 8q?68   
???????$	 100??5   !   $	??Top=?5   !   $??Center=?66   $??0, 10, 0, 0q?5    !   ._?5!      A? ??5"   "   ?? 5#   &    ?? ImageSource$ /Images/coin.ico??61   5%      5&      ?? 5)      $??Currency Inspector??6$   
???????$??22(?6Q   $??SemiBold"?5*   $   	 ?? TextAlignment$	 Center=?6:   $	??Top=?6Q   $??30??6f   $??	5 25 0 10q?5+   $   ?? 5-      $??9q?6$   $	??Top=?6/   $	??0.8??6D   
????ح?$	??Top=?5.   ?   ?? 50      $	??Top=?6%   
 ?? Orientation$
 Vertical=?6:   .+?52      ?? -   5         ??Name$ LoadMainPage??52   %      
menuButton#??[  6;   .??53   "   ?? $
 
Horizontal=?6-   .+?54   &   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Bitcoin=?6<     menuButtonIcon#??[ 6K   ?? 55   &   $??Inspect??60   $??
0, 0, 8, 0q?6?   56   #   57      ?? 59      -   5        $
 NAME??59   %   #??[  63   .??5:   "   ?? $
 
Horizontal=?6.   .+?5;   &     $ Account=?6<   #??[ 6K   ?? 5<   &   $??Account??60   $??
0, 0, 8, 0q?6?   5=   #   5>      ?? 5?      #??[  6%   .??5@   "   ?? $
 
Horizontal=?6-   .+?5A   &     $	 Cog=?6<   #??[ 6G   ?? 5B   &   $??Settings??60   $??
0, 0, 8, 0q?6@   5C   #   5D      ?? 5E      #??[  6%   .??5F   "   ?? $
 
Horizontal=?6-   .+?5G   &     $
 Help=?6<   #??[ 6H   ?? 5H   &   $
??Help??60   $??
0, 0, 8, 0q?6<   5I   #   5J      5L      ?? 5M      -   5        $ LogOut??5M   !   #??[  61   $??Bottom=?5N   !   $??Bottom=?69   $??15,12q?5O   !   .??5P      ?? $
 
Horizontal=?6)   .+?5Q   "     $ Logout=?68   #??[ 6F   $??17??5R   8   $??17??6C   ?? 5S   "   $??17(?6,   $??Log Out??6:   $??
0, 0, 8, 0q?6I   5T      5U      5V      5W      5X      ?? 5[      -   5         ??Name$ 
ActiveItem??5\      $??0??5[      $??2??6*   $??	-50,0,0,0q?6:   5]      5^      5_      5`      