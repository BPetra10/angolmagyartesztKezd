   M S B A M L   `   `   `  ����E  AWordTester, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WordTester
WordTester  5   	       WordTester.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WordTester     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ btnBetoltes��5
      $��Teszt betöltése��5      $��Right=�5      $	��Top=�6-   $��10,10q�5      $	��150��5      5      �� 5   
   $#��Angol-Magyar szófelkérdező��6   $��Center=�65   $	��Top=�5      $��23(�6(   �� 5   
   
���   �$��1q�6%   $
��Left=�5      $��42��6,   
�������$��
10,370,0,0q�5      $	��Top=�6%   $	��775��6=   ._�5      � .+�5      �� $��Teszte neve:��6   �� 5      -   5        $��lblFileName��5      �� 5      $��Teszt szókészlete:��6   �� 5      -   5        $��lblWordsNum��5      5      5      �� 5   
   -   5        $ btnStartTest��5      $��Teszt indítása��6'   $
��Left=�6@   $��336,331,0,0q�5      $	��Top=�6&   $��74��5      6   	� 5    
   -   5         	�Name$ rdoUK_HU��5       $��Angol-Magyar teszt��6(   $
��Left=�5!      $��	48,74,0,0q�61   $	��Top=�6D    d� 	IsChecked$
 TrueY�5"      	� 5#   
   -   5        $ rdoHU_UK��5#      $��Magyar-Angol teszt��6(   $
��Left=�5$      $��
205,77,0,0q�61   $	��Top=�6E   �� 5%   
   -   5         ��Name$ sliTestWordsNum��5%      $
��Left=�6*   $��
48,117,0,0q�5&      $	��Top=�6%   $��25��6=   $	��280��6I   5'      �� 5(   
   -   5        $��lblChoisedNum��5(      $��3��6%   $
��Left=�61   $��336,116,0,0q�5)      $	��Top=�6%   �� 5*   
   -	   5         ��Name$ chkIsCheckEveryWord��5*      $;��5Minden hibás válasz esetén kéri a jó megoldást?��60   $
��Left=�6j   $��
48,172,0,0q�6�   $	��Top=�6�   5,      5-      