   M S B A M L   `   `   `  ����K  GMoneyTransfer657, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MoneyTransfer657MoneyTransfer657  5   	       MoneyTransfer657.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MoneyTransfer657     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ accountsummeryLabel��5      $��$Label��6-   $��Center=�6>   $��	0,70,0,85q�6[   $��Center=�6n   $��36(�6�   �� 5   
   -   5        $ accountbaltxtLabel��5      $��Account Balance��6,   $��Center=�6F   $��	0,0,0,150q�6c   $��Bottom=�6v   $��16(�6�   �� 5   
   -   5         ��Name$ contactSearchTextBox��5      $��2��60   $
��Left=�6@   $��23��6[   $��10.2,40,0,0q�6g    �� TextWrapping$
 Wrap=�6|   $��Search��6�   $	��Top=�6�   $	��245��6�    J� Opacity$	 0.5Q�6�   �� 5   
   -   5        $ contactListLabel��5      $��Contacts��6*   $��2��6=   $
��Left=�6M   $��
10.2,9,0,0q�6h   $	��Top=�6|   $	��245��6�   �� 5   
   $��2��6   $
��Left=�6%   $	��334��6@   $��10.2,76,0,0q�6M   $	��Top=�6b   $	��245��6z   ���	#FFF1F1F1$��2��6�   .+�5      �� -   5        $ contactex3Label��5      $��
Erik Lomas��6-   $��
0,0,-0.2,0q�6B   �� 5      -   5        $ contactex2Label��5      $��Jane Doe��6-   �� 5      -   5        $ contactex1Label��5      $��
John Smith��6-   5      �� 5   
   -   5        $ recentTransSRLabel��5      $��Most Recent Transactions��6,   $��Center=�6O   $��	0,174,0,0q�6l   $	��Top=�6   �� 5   
   $
��Left=�6   $	��190��60   $��10,10.4,0,0q�6=   $��1��6R   $	��Top=�6_   $	��245��6w   ���	#FFF1F1F1.+�5      �� $$��John Smith: Electric bill -$60��6   �� 5      $��Jane Doe: Food +$30��6   5       �� 5!   
   -	   5         ��Name$ mainMenuButton��5!      $��	Main Menu��6)   $
��Left=�6=   $	��Top=�6X   $��64��6p   $��35��6{   ���	#FF2FD878$��10(�6�   6�   5#      5$      