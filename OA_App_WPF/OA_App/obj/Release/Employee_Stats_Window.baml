   M S B A M L   `   `   `  ���� 
  OA_App"    OA_App.Employee_Stats_Window   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Employee_Stats_Window��$	��700��$
��1024�� � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� �� $	��632 � � ColumnDefinitions �� $	��626 ��� $	��398 �.+��� $��Images\UI\intTemp.jpg��$
��Left=�$	��768��$	��Top=�$
��1024��$��2��$��2��$��-10,-28,0,-70q��� $��Employee ID��$��0��$��0��$��0,0,20,0q�$��Arial)�$��14(�$
��Bold"��� $
��Name��$��0��$��0��$��140,0,360,0q�$��Arial)�$��14(�$
��Bold"�$��2���� $��E-mail��$��0��$��0��$��311,0,289,0q�$��Arial)�$��14(�$
��Bold"�$��2���� $��Contact��$��0��$��0��$��453,0,247,0q�$��Arial)�$��14(�$
��Bold"�$��2���� -    ��Name$ My_Data_List��$��1��$��0��$��	0,0,328,0q�$��2������ ��Z� ���� .R��  �� �� �� �� �� �� .+��� $
��Bold"� �� TextAlignment$ Center=�
����İ�$��80��$��1��$��0��$��0,0,0,0q�����  �� Path$ Emp_Id��� $
��Bold"�$ Center=�
����İ�$��1��$	��150��$��1��$��5,0,0,0q����� $ Emp_Name��� $
��Bold"�$ Center=�
����İ�$	��190��$��2��$��1��$��5,0,0,0q����� $ Email��� $
��Bold"�$ Center=�
����İ�$��1��$��90��$��3��$��5,0,0,0q����� $ Contact���  ��Name$ 
btn_Update��-   $��Update��
�������$��4��$��75��$��30��$��5,0,0,0q��� $ 
btn_Delete��-   $��Delete��
�������$��5��$��75��$��30��$��5,0,0,0q��� -    ��Name$ 
tabControl��$
��Left=�$	��668��$��	70,2,-3,0q�$	��Top=�$	��331��$��1��$��2��.@��� -   	 ��Name$	 tabAdd��$��        Add             ��$��Arial)�$��14(�$
��Bold"�$��	0,0,-4,-3q�.��� 
����İ� �� .+��� -   $ btn_Add_Employeee��$��Add Employeee ��$��Center=�$��76,463,105,0q�$	��Top=�$	��140��$��40��
 J� RenderTransformOrigin$
 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(��� $��Employee ID   ��$
��Left=�$��	13,20,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� $��Password      ��$
��Left=�$��	13,60,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� $��Password again��$
��Left=�$��
13,100,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� $��Name          ��$
��Left=�$��
13,140,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� $��E-mail        ��$
��Left=�$��
13,180,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� $��Contact       ��$
��Left=�$��
13,220,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� -    ��Name$ Emp_Id��$
��Left=�$��23��$��
167,20,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��G� -    G�Name$ Emp_Pass��$
��Left=�$��23��$��
167,60,0,0q�$	��Top=�$	��120��G� -	   $ 	Emp_Pass2��$
��Left=�$��23��$��167,100,0,0q�$	��Top=�$	��120���� -
   $ Emp_Name��$
��Left=�$��23��$��167,140,0,0q�$
 Wrap=�$	��Top=�$	��120���� -   $ 	Emp_Email��$
��Left=�$��23��$��167,180,0,0q�$
 Wrap=�$	��Top=�$	��120���� -   $ Emp_Contact��$
��Left=�$��23��$��167,220,0,0q�$
 Wrap=�$	��Top=�$	��120���� -   $��

Back to Projects��$
��Left=�$��
10,549,0,0q�$	��Top=�$	��145��$��58������  �� ImageSource$  Images/Buttons/btnBack.jpg���� -   $ btn_ExitU_Copy��$��

Exit ��$��Center=�$��165,549,11,0q�$	��Top=�$	��145��$��58��$
 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(����� $  Images/Buttons/btnExit.jpg���� -   $	 	tabUpdate��$��        Update          ��$��Arial)�$��14(�$
��Bold"�.��� -   
����İ�$��	0,-1,1,-5q� �� .+��� -   $ 	btn_ExitU��$��

Exit ��$��Center=�$��167,555,12,0q�$	��Top=�$	��145��$��58��$
 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(����� $  Images/Buttons/btnExit.jpg���� $#��Update Employee LogIn Details��$
��Left=�$��1,10,0,0q�$	��Top=�$	��232��$	��313���� $��Employee ID   ��$
��Left=�$��	15,35,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� $��Password      ��$
��Left=�$��	15,75,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� $��Password again��$
��Left=�$��
15,115,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� -    ��Name$ txtUpdate_EMP_Id��$
��Left=�$��23��$��
156,35,0,0q�$
��Wrap=�$	��Top=�$	��133��G� -   $ txtUpdate_EMP_password_1��$
��Left=�$��
156,76,0,0q�$	��Top=�$	��133��$��22��G� -   $ txtUpdate_EMP_password_2��$
��Left=�$��156,111,0,0q�$	��Top=�$	��133��$��22���� -   $ btn_Update_Employee_Login��$��Update LogIn Details ��$��Center=�$��53,199,71,0q�$	��Top=�$	��200��$��30��$
 
0.438,0.23&�$��1q�$��Sitka Small)�$��13(��� $��Update Employee List��$
��Left=�$��	1,268,0,0q�$	��Top=�$	��248��$	��314���� -   $ txtUpdate_EMP_Id_emp_t��$
��Left=�$��23��$��173,296,0,0q�$
��Wrap=�$	��Top=�$	��120���� -   $ txtUpdate_EMP_Name��$
��Left=�$��23��$��173,340,0,0q�$
 Wrap=�$	��Top=�$	��120���� -   $ txtUpdate_EMP_email��$
��Left=�$��23��$��173,380,0,0q�$
 Wrap=�$	��Top=�$	��120���� -   $ txtUpdate_EMP_contact��$
��Left=�$��23��$��173,420,0,0q�$
 Wrap=�$	��Top=�$	��120���� -   $ btn_Update_Employee_List��$��Update List ��$��Center=�$��53,474,71,0q�$	��Top=�$	��200��$��30��$
 
0.438,0.23&�$��1q�$��Sitka Small)�$��13(��� $��Name          ��$
��Left=�$��
19,340,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� $��E-mail        ��$
��Left=�$��
19,380,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� $��Contact       ��$
��Left=�$��
19,420,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� $��Employee ID   ��$
��Left=�$��
17,296,0,0q�$	��Top=�$��Arial)�$��14(�$
��Bold"��� -   $��

Back to Projects��$
��Left=�$��
10,555,0,0q�$	��Top=�$	��145��$��58������ $  Images/Buttons/btnBack.jpg���� -   $ txtShowPassword��$ Center=�$
��Left=�$��
53,162,0,0q�$
��Wrap=�$��_________________________��$	��Top=�$	��200��$��Normal"�