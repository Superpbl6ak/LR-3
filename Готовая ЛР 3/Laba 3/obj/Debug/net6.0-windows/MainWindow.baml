   M S B A M L   `   `   `  ????A  =Laba 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Laba3_wpf	Laba3_wpf  5   	       Laba3_wpf.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Laba3_wpf     5   	     ? Title$  
MainWindow??5   	   $	??600??6   $
??1300??6)   $	??600??66   $
??1000??6F   
?????f?.??5
      ?  ? RowDefinitions 5   
   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6   ?? 5      6    ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   ?? 5      6!   ?? 5      6!   ?? 5      6!   ?? 5      6!   ?? 5      6!   ?? 5       6!   ?? 5!      6!   .+?5$   
   ?? $??2??6   $??6??6$    ?? TextAlignment$ Center=?68   
???????$??40(?6a   $??38,10,58,42q?6o   $??2??6?   ?? 6?    ? Language$ ru-ru?6?   $0?*Лабораторная работа №3??6?   6?   ?? 5&   
   -   5        $??CreateBD??5&      $??9??6   $	??130??6G   $??40??6S   $??	4,3,10,10q?6_   .??5'      ?? $ Center=?6   Создать?? 69   БД6I   5(      ?? 5)   
   -   5        $??WriteBD??5)      $??10??6   $	??130??6F   $??40??6R   $??2??6^   $??144,0,15,13q?6r   .??5*      ?? $ Center=?6   
Вывод?? 67   БД6G   5+      ?? 5-   
   -   5        $??Z1??5-      $
??Left=?6.   $	??145??6I   $??2??6U   $??2,0,0,0q?6i   .??5.      ?? $ Center=?6   
Alfa Romeo6<   5/      ?? 50   
   -   5        $??Z2??50      $??4??6   $??
1,9,144,45q?6;   $??2??6O   $??2??6`   .??51      ?? $ Center=?6   BMW65   52      ?? 53   
   -   5        $??Z3??53      $??6??6   $??1,12,144,37q?6;   $??2??6P   $??2??6a   .??54      ?? $ Center=?6   Машины дешевле?? 6@   10000$6T   55      ?? 56   
   -   5        $??Z4??56      $??2??6.   $??
2,2,142,51q?6B   $??2??6V   $??1??6g   .??57      ?? $ Center=?6   Remark67   58      ?? 59   
   -   5        $??Z5??59      $??3??6   $??
1,7,144,46q?6;   $??2??6O   $??2??6`   .??5:      ?? $ Center=?6   " Склады с машинами?? 6A   2000-2005 гг.6[   5;      ?? 5<   
   -   5        $??Z6??5<      $??5??6   $??1,10,144,43q?6;   $??2??6P   $??2??6a   .??5=      ?? $ Center=?6   Машины?? 67   '%года выпуска до 2000 г.6\   5>      ?? 5?   
   -	   5        $??Z7??5?      $??2??6   $??
1,4,144,49q?6;   $??2??6O   $??2??6`   .??5@      ?? $ Center=?6   Вывод машин?? 6;   в файл .txt6S   5A      &   System.Windows.Controls.DataGrid  5C   
   -
   5        $??Table1??5C   U   $??1??6   $??1??6    $??8??60   $??9??6D   $??135,43,10,53q?6c   6{   5H      5I      