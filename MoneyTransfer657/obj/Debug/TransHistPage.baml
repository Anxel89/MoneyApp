   M S B A M L   `   `   `  ����K  GMoneyTransfer657, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MoneyTransfer657MoneyTransfer657  5   	   $    MoneyTransfer657.TransHistPage   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MoneyTransfer657     5   	     � Title$  TransHistPage��5   	   $	��450��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��2* �6   .+�5   
   �� -   5         ��Name$ transHistMainLabel��5      $��Transaction History��6,   $��36(�6J   $��2��6X   $��Center=�6l   $��Center=�6�   �� 5   
   $��Sent/Recived��6   $��0q�6'   $��1��62   $��16(�6?   $��Center=�6M   $	��Top=�6j   �� 5   
   $��Bought/Sold��6   $��1��6&   $��1��63   $��16(�6C   $��Center=�6Q   $	��Top=�6n   �� 5   
   -   5         ��Name$ mainMenu1Button��5      $��	Main Menu��6*   $
��Left=�6>   $	��Top=�6Y   $��64��6q   $��35��6|   ���	#FF2FD878$��10(�6�   6�   �� 5   
   -   5         ��Name$ transHistSeparator��5      $��Center=�60   $��22��6M   $��197,95,196.6,0q�6Y   $	��Top=�6q   $	��400��6�   $��20(�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2��6�   z�5      V� 5      .~�5      ��  �� ScaleY$ 2Q�6%   �� 5      �� 5      T� 5      5      5      �� 5    
   $��Center=�6   $��247,115,246.6,0q�61   $��1��6J   $	��300��6W   $ 0.5,0.5&�6c   $��24��6�   $	��Top=�6�   $��2��6�   z�5!      V� 5"      .~�5#      �� $ 2Q�6%   �� 5$      �� 5%       �� Angle$ 90Q�6&   T� 5&      5'      5)      �� 5*   
   -   5        	 ��Name$	 sentRecListBox��5*      $��50,70,50,20q�6*   $��1��6?   �� 5+   
   -   5        $	 buySoldListBox��5+      $��50,70,50,20q�6*   $��1��6?   $��1��6L   �� 5,   
   -   5        
 ��Name$
 sentRecivedTextBox��5,      $
��Left=�6.   $��18��6I   $��	50,47,0,0q�6U   $��1��6h    �� TextWrapping$
 Wrap=�6u   $��Search��6�   $	��Top=�6�   $	��200��6�    J� Opacity$	 0.5Q�6�   �� 5-   
   -   5        $ sentRecSearchButton��5-      $��Search��6.   $
��Left=�6?   $��
272,46,0,0q�6Z   $��1��6n   $	��Top=�6{   $��75��6�   6�   �� 5.   
   -   5        $ TransEXData��5.      $��Load Example Data��6&   $��1��6B   $
��Left=�6R   $��269.2,10,0,0q�6m   $	��Top=�6�   $	��118��6�   ���	#FFEBFF00$��34��6�   6�   �� 5/   
   -	   5        $
 buySellTextBox��5/      $
��Left=�6*   $��18��6E   $��47.2,47,0,0q�6Q   $��1��6f   $
 Wrap=�6s   $��Search��6�   $	��Top=�6�   $	��200��6�   $	 0.5Q�6�   $��1��6�   �� 50   
   -
   5        $ buySellSearchButton��50      $��Search��6.   $
��Left=�6?   $��269.2,46,0,0q�6Z   $��1��6p   $	��Top=�6}   $��75��6�   $��1��6�   52      53      