   M S B A M L   `   `   `  ���� 
  OA_App    OA_App.Project_Window   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Project_Window��$	��700��$
��1028�� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� �� $	��632 � � ColumnDefinitions �� $	��874 ��� $	��150 �.+��� $��Images\UI\intTemp.jpg��$
��Left=�$	��768��$	��Top=�$
��1024��$��2��$��2��$��-10,-28,0,-3q��� $��
Project ID��$��0��$��0��$��
14,0,142,0q�$��Arial)�$��13(�$
��Bold"�$��2���� $��Project Name��$��0��$��0��$��
117,0,33,0q�$��Arial)�$��13(�$
��Bold"��� $��Project Description��$��0��$��0��$��
287,0,63,0q�$��Arial)�$��13(�$
��Bold"��� $��	Employee ��$��0��$��0��$��
504,0,96,0q�$��Arial)�$��13(�$
��Bold"��� -    ��Name$ btn_Add_Project��$��
Add Project��$	��145��$��65��$��Center=�$��863,30,13,0q�$	��Top=� J� RenderTransformOrigin$ 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(�$��2��$��2������  �� ImageSource$ Images/Buttons/btnAdd.jpg���� -   $ btn_Emp_stats��$��


Employee��$��Center=�$��864,85,14,0q�$��1��$	��Top=�$	��146��$��65��$ 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(�$��2������ $ Images/Buttons/btnEmp.jpg���� -   $ btn_Exit��$��

Exit ��$��Center=�$��864,537,14,0q�$	��Top=�$	��146��$��60��$ 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(�$��1��$��2������ $  Images/Buttons/btnExit.jpg���� -    ��Name$ My_Data_List��$��1��$��0��$��	0,0,10,36q����� ��Z� ���� .R��  �� �� �� �� �� �� .+��� $
��Bold"� �� TextAlignment$ Center=�
����İ�$��90��$��1��$��0��$��1,0,0,0q����� 	 �� Path$	 Proj_Id��� $
��Bold"�$ Center=�
����İ�$��1��$	��120��$��1��$��5,0,0,0q����� $	 	Proj_Name��� $
��Bold"�$ Center=�
����İ�$	��260��$��2��$��1��$��5,0,0,0q����� $	 Proj_Des��� $
��Bold"�$ Center=�
����İ�$��1��$	��120��$��3��$��5,0,0,0q����� $	 Emp_Name��� $
��Bold"�$ Center=�
�������$��1��$	��120��$��4��$��5,0,0,0q����� $	 Proj_Status��� $ btn_View��-   $��View Project��
�������$��5��$��85��$��30��$��12,0,0,0q��� $��Project Status ��$��0��$��0��$��628,0,122,0q�$��Arial)�$��13(�$
��Bold"�$��2���� -   
 ��Name$
 cboGetMonth��$
��Left=�$��867,238,0,0q�$	��Top=�$	��142��$��2��$��1��
����İ��� $��Select Project By Month��$
��Bold"�$��Center=�$��865,211,12,0q�$��1��$	��Top=�$	��147��$ 0.423,0.615&�$��2���� -    ��Name$ 	txtSearch��$
��Left=�$��23��$��868,334,0,0q�$��1�� �� TextWrapping$
 Wrap=�$	��Top=�$	��141��$��2���� $��Search Project By Name��$
��Bold"�$
��Left=�$��864,306,0,0q�$��1��$	��Top=�$	��145��$��2���� -   $ 	btnSearch��$��Search��$��1��$
��Bold"�
����İ�$
��Left=�$��
19,364,0,0q�$��1��$	��Top=�$��92���� $C��=_____________________________________________________________��$
��Bold"�
�������$
��Left=�$��862,186,0,0q�$��1��$	��Top=�$	��149��$��2���� $C��=_____________________________________________________________��$
��Bold"�
�������$
��Left=�$��864,275,0,0q�$��1��$	��Top=�$	��149��$��2��o� -	    o�Name$ MenuItem��$��
864,0,10,0q�$��0��$	��Top=�$��2��
����İ����	#FFFFF9F9$��14(�$��30��.@�m� $��   Load Projects  >>�����	#FF060505$	��146��$��SemiBold"�$��30����Z� .@�m� -
   $��	Completed��$
��Left=�$��Medium"�
����������	#FFFBF5F5$��12(�m� -   $��Ongoing    ��$
��Left=�$��Medium"�
����������	#FFFBF5F5$��12(�m� -   $��All Projects��$
��Left=�$��Medium"�
����������	#FFFBF5F5$��12(�