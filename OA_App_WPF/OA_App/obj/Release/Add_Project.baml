   M S B A M L   `   `   `  ���� 
  OA_App    OA_App.Add_Project   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Add_Project��$	��700��$
��1024�� � WindowStartupLocation$ CenterScreen=�.��� .+��� $��Images\UI\intTemp.jpg��$
��Left=�$	��700��$	��Top=�$
��1024��$��-6,-31,-2,0q��� $%��Project ID                   : ��$
��Left=�$��	70,74,0,0q�$	��Top=�$��14(�$��Arial)�$
��Bold"�$	��236���� $!��Project Name             : ��$
��Left=�$��
70,124,0,0q�$	��Top=�$��14(�$��Arial)�$
��Bold"��� $��Project Description   : ��$
��Left=�$��
70,174,0,0q�$	��Top=�$��14(�$��Arial)�$
��Bold"��� $"��Started Date              : ��$
��Left=�$��
70,290,0,0q�$	��Top=�$��14(�$��Arial)�$
��Bold"��� $#��End Date                   : ��$
��Left=�$��
70,340,0,0q�$	��Top=�$��14(�$��Arial)�$
��Bold"��� $(��"File                            : ��$
��Left=�$��
66,481,0,0q�$	��Top=�$��14(�$��Arial)�$
��Bold"��� $!��Employee                 : ��$
��Left=�$��
70,391,0,0q�$	��Top=�$��14(�$��Arial)�$
��Bold"��� -    ��Name$ 	txtProjID��$��--��$
��Left=�$��38��$��254,80,0,553q�$
��Wrap=�$��Stretch=�$	��390��$��14(��� -    ��Name$ txtProjName��$
��Left=�$��28��$��251,128,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��450��$��14(�$��Arial)��� -   $ 
txtProjDes��$
��Left=�$��93��$��251,174,0,0q�$
 Wrap=�$	��Top=�$	��450��$��14(�$��Arial)��� -    ��Name$ btn_Project��$��

Back to Projects��$��Center=�$��869,465,2,0q�$	��Top=�$	��145��$��65�� J� RenderTransformOrigin$ 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(�����  �� ImageSource$  Images/Buttons/btnBack.jpg���� -   $ btn_Emp_stats��$��


Employee��$��Center=�$��869,366,2,0q�$	��Top=�$	��145��$��65��$ 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(����� $ Images/Buttons/btnEmp.jpg���� -   $ btn_Exit��$��

Exit ��$��Center=�$��870,559,2,0q�$	��Top=�$	��144��$��65��$ 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(����� $  Images/Buttons/btnExit.jpg���� -   $ btn_Add��$��Add This Project��$��Center=�$��
869,33,2,0q�$	��Top=�$	��145��$��65��$ 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(����� $* $Images/Buttons/btnAddThisProject.jpg���� -    ��Name$ Combo��$
��Left=�$��254,397,0,0q�$	��Top=�$	��268������ 	 �� Path$	 Emp_Name��� -	   $ 
btn_Delete��$��

Delete��$��Center=�$��869,142,2,0q�$	��Top=�$	��145��$��65��$ 
0.438,0.23&�$��1q�$��Sitka Small)�$��14(����� $" Images/Buttons/btnDelete.jpg���� -
   $ txtInformation��$
��Left=�$��1,0,0,44q�$
��Wrap=�$��
----------��$��25��$	��865��$��12(�$
��Bold"�$��Bottom=��� -   $ 	btnUpload��$��Upload��$
��Left=�$��252,481,0,0q�$	��Top=�$	��268��$��28��$
��Bold"����� 
 �� EndPoint$
 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFB5D1F9�� � Offset$ 0Q�� $ 	#FF7AB3D3��$ 1Q�(  "System.Windows.Controls.DatePicker  -     Name$ SDatePicker��$
��Left=�$��254,294,0,0q�$	��Top=�$	��268��  -   $ EDatePicker��$
��Left=�$��254,343,0,0q�$	��Top=�$	��268��� -    �Name$ prgBar01��$
��Left=�$��5��$��
-6,619,0,0q�$	��Top=�$	��871���� -   $ txtNameCount��$
��Left=�$��709,137,0,0q�$
��Wrap=�$	��Top=�$��19��$	��138���� -   $ txtsdate��$
��Left=�$��542,299,0,0q�$
��Wrap=�$	��Top=�$��19��$	��138���� -   $ txtedate��$
��Left=�$��542,346,0,0q�$
��Wrap=�$	��Top=�$��19��$	��138���� -   $ txtEmployee��$
��Left=�$��542,400,0,0q�$
��Wrap=�$	��Top=�$��19��$	��138���� -   $ txtEmployeeName_Gray��$
��Left=�$��254,424,0,0q� �� TextAlignment$ Center=�
���OO/�$
��Wrap=�$	��Top=�$��19��$	��266���� -    ��Name$ lblMark��$ ��Mark This Project As    : ��$
��Left=�$��
63,543,0,0q�$	��Top=�$��12(�$��Arial)�$
��Bold"�	� -    	�Name$ 
rbnOngoing��$��Ongoing Project��$
��Left=�$��251,550,0,0q� d� 	IsChecked$
 TrueY�$	��Top=�	� -   $ rbnCompleted��$��Completed Project��$
��Left=�$��396,550,0,0q�$	��Top=�