   M S B A M L   `   `   `  ����E  AWordTester, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WordTester
WordTester  5   	       WordTester.TestWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WordTester     5   	     � Title$  Szavak tesztelése��5   	   $	��200��6#   $	��400��60   .��5	      � -   5         �Name$ grCells��5	       � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   � -   5         �Name$ 
pbProcesss��5      $��Center=�5      $��15��61   ]� 5   
   $��1��6   $��Center=�6!   .+�5      �� $��Megadott szó:��6   �� 5      -   5        $��lblQuestion��5      $��Megadott szó:��6'   $
��Left=�6?   
���  ��$
��Bold"�5   !   5      ]� 5   
   $��2��6   $��Center=�6!   .+�5      �� $��Jelentése:��6   $
��Left=�6)   �� 5      -   5         ��Name$ 	txtAnswer��5      $
��Left=�6)    �� TextWrapping$
 Wrap=�6D   $	��120��6X   5      �� 5      -   5        $��lblActResult��5   +   $��Right=�6   $�� ��6?   $��Center=�6J   $	��Top=�6g   5      ]� 5   
   $��3��6   $��Center=�6!   $��Center=�6<   .+�5   
   �� -   5         ��Name$ 	btnAnswer��5      $��Válasz rögzítése��6$   $
��Left=�6?   $��24��6Z   $	��Top=�5      $	��220��6)   65   5!      5#      5$      