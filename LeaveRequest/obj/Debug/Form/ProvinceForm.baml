   M S B A M L   `   `   `  ����G  CLeaveRequest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:LeaveRequestLeaveRequest  5   	       LeaveRequest.ProvinceForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:LeaveRequest     5   	   -   5          � Title$  ProvinceForm��5   	   $	��500��6   $	��800��6+   .��5
      � .+�5   
   �� 
����d�$��1q�6-   $
��Left=�6A   $	��337��6\   $��
-1,132,0,0q�6i   $	��Top=�6}   $	��193��6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $	��117��6:   $	��Top=�6G   $	��168��6_   $7��1C:\Users\RIZKA\Downloads\Leave Request OK\MII.png��6k   $��	24,10,0,0q�6�   �� 5   
   -   5        $ image1��5      $
��Left=�6    $	��100��6;   $��
203,32,0,0q�6H   $	��Top=�6\   $	��579��6t   $9��3C:\Users\RIZKA\Downloads\Leave Request OK\garis.png��6�   �� 5   
   -   5         ��Name$ Home_Btn��5      $
��Home��6#   $��0,145,614,288q�62   $��16(�6I   $��Segoe UI Semibold)�6W   
�������
���   �6�   �� 5   
   -   5        $ Employee_Btn��5      $��Manage Employee��6'   $��-1,186,615,247q�6A   $��16(�6Y   $��Segoe UI Semibold)�6g   
�������
���   �6�   �� 5   
   -   5        $ Account_Btn��5      $��Manage Account��6&   $��-1,227,615,206q�6?   $��16(�6W   $��Segoe UI Semibold)�6e   
�������
���   �$��36��6�   �� 5   
   -   5        $ Department_Btn��5      $��Manage Department��6)   $��-1,268,615,165q�6E   $��16(�6]   $��Segoe UI Semibold)�6k   
�������
���   �$��36��6�   �� 5   
   -   5        $ Job_Btn��5      $��
Manage Job��6"   $��-1,309,615,124q�67   $��16(�6O   $��Segoe UI Semibold)�6]   
�������
���   �$��36��6�   �� 5   
   -	   5        $ LeaveAvailable_Btn��5      $��Manage Leave Availabe��6-   $��-1,350,615,83q�6M   $��16(�6d   $��Segoe UI Semibold)�6r   
�������
���   �$��36��6�   �� 5   
   -
   5        $ 
Logout_Btn��5      $��Logout��6%   $��-1,423,615,10q�66   $��16(�6M   $��Segoe UI Semibold)�6[   
�������
���   �6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��337��6T   $��312,122,0,0q�6a   $	��Top=�6v   $	��340��6�   ._�5      �� -   5         ��Name$ 	textBlock��5      $
��Wrap=�6+   $��Province��6?   $��-1,-1,-1,305q�6O   
����d�
�������$��20(�6�    �� TextAlignment$ Center=�6�   5      �� 5   
   -   5        $ 
textBlock1��5      $
��Left=�6(   $��334,170,0,0q�6C   $
��Wrap=�6X   $��Id��6l   $	��Top=�6v   $��13(�6�   $��Segoe UI Semibold)�6�   �� 5   
   -   5         ��Name$ IdProvince_Txt��5      $
��Left=�6*   $��23��6E   $��446,170,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $��53��6�   {�.  6�   �� 5   
   -   5        $ 
textBlock2��5      $
��Left=�6(   $��334,216,0,0q�6C   $
��Wrap=�6X   $��Province Name��6l   $	��Top=�6�   $��13(�6�   $��Segoe UI Semibold)�6�   �� 5   
   -   5        $ ProvinceName_Txt��5      $
��Left=�6,   $��23��6G   $��446,210,0,0q�6S   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��142��6�   �� 5   
   -   5        $ AddProvince_Btn��5      $	��Add��6*   $
��Left=�68   $��334,257,0,0q�6S   $	��Top=�6h   $��65��6�   
���   �
�������$��25��6�   6�   �� 5   
   -   5        $ UpdateProvince_Btn��5      $��Update��6-   $
��Left=�6>   $��446,257,0,0q�6Y   $	��Top=�6n   $��65��6�   
���   �
�������$��25��6�   6�   �� 5   
   -   5        $ DeleteProvince_Btn��5      $��Delete��6-   $
��Left=�6>   $��568,257,0,0q�6Y   $	��Top=�6n   $��65��6�   
���   �
�������$��25��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridProvince��5      $
��Left=�6-   $��334,306,0,0q�6H   $	��Top=�6]   $	��128��6u   $	��299��6�      AutoGenerateColumns .  	   Columns	 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5"      $
 Province��6%    67   �� *Name+5$      5)      5*      