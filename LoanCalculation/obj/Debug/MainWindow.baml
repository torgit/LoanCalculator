   M S B A M L   `   `   `  ����J  FLoanCalculation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LoanCalculationLoanCalculation  5   	        LoanCalculation.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:LoanCalculation     5   	     � Title$  
MainWindow��5   	   $��508.561��6   $��1210.152��6-   .��5	      � $��0,0,-8,2q�6    � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      $
��106* �6   �� 5      $
��Auto �6   �� 5      $	��88* �6   �� 5      $
��829* �6   �� 5      $	��75* �6   �� 5      $��0* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ label_amount��5      $��Amount��6&   $
��Left=�67   $��36��6R   $��	2,159,0,0q�6^   $	��Top=�6q   $	��120��6�   $��2��6�   �� 5   
   -   5        $ 
label_time��5      $��Payback time in years��6$   $
��Left=�6D   $��37��6_   $��
36,216,0,0q�6k   $	��Top=�6   $	��120��6�   $��1��6�   $��2��6�   �� 5   
   -   5         ��Name$ textBox_amount��5      $
��Left=�6*   $��36��6E   $��138,156,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��199��6�   $��2��6�   �� 5   
   -   5        $ textBox_time��5      $
��Left=�6(   $��37��6C   $��138,212,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��199��6�   $��2��6�   �� 5   
   -   5        $ label_paybackScheme��5      $��Payback scheme��6-   $
��Left=�6F   $��36��6a   $��
36,103,0,0q�6m   $	��Top=�6�   $	��120��6�   $��1��6�   $��2��6�   �� 5   
   -   5        $ label_loanType��5      $��	Loan type��6(   $
��Left=�6<   $��36��6W   $��2,39,0,0q�6c   $	��Top=�6u   $	��120��6�   $��2��6�   �� 5   
   -   5         ��Name$ comboBox_loanType��5      $
��Left=�6P   $��
138,39,0,0q�6k   $	��Top=�6   $	��199��6�   $��36��6�   $��2��6�   �� 5   
   -   5        $ comboBox_paymentScheme��5      $
��Left=�6Z   $��
138,99,0,0q�6u   $	��Top=�6�   $	��199��6�   $��36��6�   $��2��6�   �� 5   
   -	   5         ��Name$ button��5      $��Submit��6!   $
��Left=�62   $��114,284,0,0q�6M   $	��Top=�6b   $	��121��6z   $��35��6�   $��2��6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ dataGrid_result��5      $
��Left=�6,   $��	33,10,0,0q�6G   $	��Top=�6Z   $	��456��6r   $	��746��6   $��3��6�   $��3��6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   5      5      